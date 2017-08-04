using  System;
using  System.Collections.Generic;
using  System.ComponentModel;
using  System.Drawing;
using  System.Data;
using  System.Linq;
using  System.Text;
using  System.Threading.Tasks;
using  System.Windows.Forms;
using  MetroFramework.Controls;
using  System.Net;
using  System.Net.Sockets;
using  SucursalElectronicaCliente.AppCode.Dto;
using  Newtonsoft.Json;
using  SucursalElectronicaCliente.AppCode;

namespace  SecureFtpClient.UserControls
{
    public partial class ucLogin : ucBase
    {
        private static int BUFFER_SIZE = 214748364;
        public ucLogin()
        {
            InitializeComponent();
        }

        private void mlSettings_Click(object sender, EventArgs e)
        {
            ShowSettings();
        }

        private void ShowSettings()
        {
            mpSettings.Visible = true;
            this.Controls["mpSettings"].BringToFront();
            mpLogin.Enabled = false;
        }

        private void mlBackSettings_Click(object sender, EventArgs e)
        {
            ShowLogin();
        }

        private void ShowLogin()
        {
            mpSettings.Visible = false;
            mpLogin.Enabled = true;
        }

        private void mbLogin_Click(object sender, EventArgs e)
        {
            LoginServer();
            if (JsonResponse.Result == "Autorizado")
            {

                ShowMainMenu();
            }
            else
                MessageBox.Show("No se pudo conectar.");
        }

        private void ShowMainMenu()
        {
            BringToFront(typeof(ucMainMenu).Name);
            mainForm.Instance.MetroBack.Visible = false;
        }

        private void LoginServer()
        {
            var _clientSocket = mainForm.Instance.ClientSocket;
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

            SendLoginRequest(_clientSocket);
        }



        private void SendLoginRequest(Socket _clientSocket)
        {
            var idClient = _clientSocket.LocalEndPoint.ToString();

            var cryptoClass = new CryptographyObject(idClient);

            var jsonLogin = new JsonRequest
            {
                Controller = "UserController",
                Action = "Iniciar Sesion",
                Credentials = new Credentials
                {
                    Username = txtUsername.Text,
                    Password = txtPassword.Text,
                    Hash = cryptoClass.Md5Gen()
                }
            };

            var json = JsonConvert.SerializeObject(jsonLogin, Formatting.Indented);


            var encrypt = cryptoClass.Encriptar(json);

            //var desencryptToJson = mainForm.Instance.Desencriptar(encrypt);

            var buffer = Encoding.ASCII.GetBytes(encrypt);
            //var buffer = Encoding.ASCII.GetBytes(json);

            _clientSocket.Send(buffer);
            var receivedBuffer = new byte[BUFFER_SIZE];
            var receivedBytes = _clientSocket.Receive(receivedBuffer);
            var data = new byte[receivedBytes];


            Array.Copy(receivedBuffer, data, receivedBytes);

            var encryptString = Encoding.ASCII.GetString(data);
            var jsonResponse = cryptoClass.Desencriptar(encryptString);
            //var jsonResponse = encryptString;
            JsonResponse = JsonConvert.DeserializeObject<JsonResponse>(jsonResponse);
            mainForm.Instance.Credentials = mainForm.Instance.Credentials == null ? JsonResponse.Result == "Autorizado" ? JsonResponse.Credentials : mainForm.Instance.Credentials : new Credentials();

            //Console.WriteLine("Received: " + Encoding.ASCII.GetString(data));
            //return Encoding.ASCII.GetString(data) == "0" ? 0 : 1;

            //}
        }

    }
}
    