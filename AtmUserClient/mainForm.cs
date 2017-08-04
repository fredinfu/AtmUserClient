using  MetroFramework.Controls;
using  MetroFramework.Forms;
using  Newtonsoft.Json;
using  SecureFtpClient.UserControls;
using  SucursalElectronicaCliente.AppCode;
using  SucursalElectronicaCliente.AppCode.Dto;
using  SucursalElectronicaCliente.AppCode.DtoModels;
using  SucursalElectronicaCliente.AppCode.Repository;
using  System;
using  System.Collections.Generic;
using  System.ComponentModel;
using  System.Data;
using  System.Drawing;
using  System.IO;
using  System.Linq;
using  System.Net;
using  System.Net.Sockets;
using  System.Security.Cryptography;
using  System.Text;
using  System.Threading.Tasks;
using  System.Windows.Forms;

namespace  SecureFtpClient
{
    public partial class mainForm : MetroForm
    {
        private static int BUFFER_SIZE = 214748364;
        static mainForm _instance;
        public FileRepository fileRepository { get; set; }
        public UserRepository userRepository { get; set; }
        private Socket _clientSocket;
        public Credentials Credentials { get; set; }
        private JsonResponse jsonResponse;
        private string safeFileNameSelected;

        internal JsonResponse JsonResponse
        {
            get
            {
                if (jsonResponse == null)
                    jsonResponse = new JsonResponse();
                return jsonResponse;
            }

            set
            {
                jsonResponse = value;
            }
        }
        internal string SafeFileNameSelected
        {
            get
            {
                if (safeFileNameSelected == string.Empty)
                    safeFileNameSelected = "NoFileSelected";
                return safeFileNameSelected;
            }

            set
            {
                safeFileNameSelected = value;
            }
        }
        public Socket ClientSocket
        {
            get
            {
                if (_clientSocket == null)
                    _clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                return _clientSocket;
            }
        }

        public static mainForm Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new mainForm();
                return _instance;
            }
        }

        public MetroPanel MetroContainer
        {
            get { return mpMainPanel; }
            set { mpMainPanel = value; }
        }

        public MetroLink MetroBack
        {
            get { return mlBack; }
            set { mlBack = value; }
        }
        
        public mainForm()
        {
            InitializeComponent();
            FormClosing += new FormClosingEventHandler(mainform_FormClosing);
            fileRepository = new FileRepository();
            userRepository = new UserRepository();
        }

        void mainform_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_clientSocket == null) return;
            var jsonRequest = new JsonRequest
            {
                Action = "Desconectar del sistema",
                Credentials = new Credentials()
            };
            var json = JsonConvert.SerializeObject(jsonRequest, Formatting.Indented);

            var buffer = Encoding.ASCII.GetBytes(json);
            _clientSocket.Send(buffer);
            _clientSocket.Close();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            //_clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            mlBack.Visible = false;
            _instance = this;
            LoadMainPanelControls();
        }

        private void LoadMainPanelControls()
        {
            mpMainPanel.Controls.Add(new ucLogin { Dock = DockStyle.Fill });
            mpMainPanel.Controls.Add(new ucMisArchivosDescarga { Dock = DockStyle.Fill });
            mpMainPanel.Controls.Add(new ucArchivosPermitidosDescarga { Dock = DockStyle.Fill });
        }

        private void mlBack_Click(object sender, EventArgs e)
        {
            BringToFront(typeof(ucMainMenu).Name);
            mlBack.Visible = false;
        }

        protected void BringToFront(string control)
        {
            if (!Instance.MetroContainer.Controls.ContainsKey(control))
            {
                var uc = new ucMainMenu();
                uc.Dock = DockStyle.Fill;
                Instance.MetroContainer.Controls.Add(uc);
            }
            Instance.MetroContainer.Controls[control].BringToFront();
            Instance.MetroBack.Visible = true;
        }

        #region Files
        public void GetMisArchivosDescarga()
        {
            var _clientSocket = Instance.ClientSocket;
            while (!_clientSocket.Connected)
            {
                try
                {
                    _clientSocket.Connect(IPAddress.Loopback, 100);
                }
                catch (Exception)
                {
                    return;
                }
            }

            SendMyFilesRequest(_clientSocket);
        }

        private void SendMyFilesRequest(Socket _clientSocket)
        {
            var idClient = _clientSocket.LocalEndPoint.ToString();

            var cryptoClass = new CryptographyObject(idClient);

            var jsonRequest = new JsonRequest
            {
                Controller = "FileController",
                Action = "Listar Archivos",
                Credentials = new Credentials
                {
                    Username = Instance.Credentials.Username,
                    Password = Instance.Credentials.Password,
                    Hash = cryptoClass.Md5Gen()
                }
            };

            var json = JsonConvert.SerializeObject(jsonRequest, Formatting.Indented);

            //var buffer = Encoding.ASCII.GetBytes(json);
            var encrypt = cryptoClass.Encriptar(json);
            //var desencryptToJson = mainForm.Instance.Desencriptar(encrypt);
            var buffer = Encoding.ASCII.GetBytes(encrypt);

            _clientSocket.Send(buffer);
            var receivedBuffer = new byte[BUFFER_SIZE];
            var receivedBytes = _clientSocket.Receive(receivedBuffer);
            var data = new byte[receivedBytes];


            Array.Copy(receivedBuffer, data, receivedBytes);

            //var jsonResponse = Encoding.ASCII.GetString(data);
            var encryptString = Encoding.ASCII.GetString(data);
            var jsonResponse = cryptoClass.Desencriptar(encryptString);
            JsonResponse = JsonConvert.DeserializeObject<JsonResponse>(jsonResponse);
            if (JsonResponse.Result == "Invalid")
            {
                MessageBox.Show("No se pudo completar la acción.");
                return;
            }
            Instance.fileRepository.Files = JsonResponse.Files;
            //ucMisArchivosDescarga.Instance.fileRepository.Files = JsonResponse.Files;
            //Console.WriteLine("Received: " + Encoding.ASCII.GetString(data));
        }

        public void UploadArchivoSeleccionado(string filePath)
        {
            var _clientSocket = Instance.ClientSocket;
            while (!_clientSocket.Connected)
            {
                try
                {
                    _clientSocket.Connect(IPAddress.Loopback, 100);
                }
                catch (Exception)
                {
                    return;
                }
            }

            SendUploadFileRequest(_clientSocket, filePath);
        }

        private void SendUploadFileRequest(Socket _clientSocket, string filePath)
        {
            try
            {
                var idClient = _clientSocket.LocalEndPoint.ToString();

                var cryptoClass = new CryptographyObject(idClient);

                var fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                var bytesArray = new byte[fs.Length];
                var bytesToRead = (int)fs.Length;
                //var bytesRead = 0;

                var br = new BinaryReader(fs);
                var bytes = new FileInfo(filePath);
                var numBytes = bytes.Length;
                var fileBuff = br.ReadBytes(bytesToRead);
                var fileData = Convert.ToBase64String(fileBuff);

                var jsonRequest = new JsonRequest
                {
                    Controller = "FileController",
                    Action = "Subir Archivo",
                    Credentials = new Credentials
                    {
                        Username = Instance.Credentials.Username,
                        Password = Instance.Credentials.Password,
                        Hash = cryptoClass.Md5Gen(),

                    },
                    FileAux = new FileDto
                    {
                        FileName = Instance.safeFileNameSelected,
                        FileData = fileData
                    }
                };

                //var json = JsonConvert.SerializeObject(jsonRequest, Formatting.Indented);

                //var buffer = Encoding.ASCII.GetBytes(json);

                var json = JsonConvert.SerializeObject(jsonRequest, Formatting.Indented);


                var encrypt = cryptoClass.Encriptar(json);
                //var desencryptToJson = cryptoClass.Desencriptar(encrypt);

                var buffer = Encoding.ASCII.GetBytes(encrypt);

                _clientSocket.Send(buffer);
                var receivedBuffer = new byte[BUFFER_SIZE];
                var receivedBytes = _clientSocket.Receive(receivedBuffer);
                var data = new byte[receivedBytes];


                Array.Copy(receivedBuffer, data, receivedBytes);

                //var jsonResponse = Encoding.ASCII.GetString(data);
                var encryptString = Encoding.ASCII.GetString(data);
                var jsonResponse = cryptoClass.Desencriptar(encryptString);
                JsonResponse = JsonConvert.DeserializeObject<JsonResponse>(jsonResponse);
                if (JsonResponse.Result == "Invalid Request")
                {
                    MessageBox.Show("No se pudo completar la acción.");
                    return;
                }
                MessageBox.Show(JsonResponse.Result);
            }
            catch (Exception ex)
            {

            }

        }

        public void GetMisArchivosCompartidos()
        {
            var _clientSocket = Instance.ClientSocket;
            while (!_clientSocket.Connected)
            {
                try
                {
                    _clientSocket.Connect(IPAddress.Loopback, 100);
                }
                catch (Exception)
                {
                    return;
                }
            }

            SendMySharedFilesRequest(_clientSocket);
        }

        private void SendMySharedFilesRequest(Socket _clientSocket)
        {
            var idClient = _clientSocket.LocalEndPoint.ToString();

            var cryptoClass = new CryptographyObject(idClient);
            var jsonRequest = new JsonRequest
            {
                Controller = "FileController",
                Action = "Listar Archivos Compartidos",
                Credentials = new Credentials
                {
                    Username = Instance.Credentials.Username,
                    Password = Instance.Credentials.Password,
                    Hash = cryptoClass.Md5Gen()
                }
            };

            var json = JsonConvert.SerializeObject(jsonRequest, Formatting.Indented);
            var encryptSendText = cryptoClass.Encriptar(json);

            var buffer = Encoding.ASCII.GetBytes(encryptSendText);

            _clientSocket.Send(buffer);
            var receivedBuffer = new byte[BUFFER_SIZE];
            var receivedBytes = _clientSocket.Receive(receivedBuffer);
            var data = new byte[receivedBytes];


            Array.Copy(receivedBuffer, data, receivedBytes);

            var encryptString = Encoding.ASCII.GetString(data);
            var jsonResponse = cryptoClass.Desencriptar(encryptString);

            JsonResponse = JsonConvert.DeserializeObject<JsonResponse>(jsonResponse);
            if (JsonResponse.Result == "Invalid Request")
            {
                MessageBox.Show("No se pudo completar la acción.");
                return;
            }
            MessageBox.Show(JsonResponse.Result);
            Instance.fileRepository.Files = JsonResponse.Files;
            Instance.userRepository.Users = JsonResponse.Users;
            //ucMisArchivosDescarga.Instance.fileRepository.Files = JsonResponse.Files;
            //Console.WriteLine("Received: " + Encoding.ASCII.GetString(data));
        }
        #endregion
        
    }

}
