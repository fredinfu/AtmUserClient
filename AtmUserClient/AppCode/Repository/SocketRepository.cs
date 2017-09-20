using Newtonsoft.Json;
using SucursalElectronicaCliente.AppCode.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SucursalElectronicaCliente.AppCode.Repository
{
    public class SocketRepository
    {
        private static int BUFFER_SIZE = 214748364;
        private Socket _clientSocket;
        private JsonResponse _jsonResponse;
        private JsonRequest _jsonRequest;

        public SocketRepository(Socket clientSocket, JsonRequest jsonRequest)
        {
            _clientSocket = clientSocket;
            _jsonRequest = jsonRequest;
            _jsonResponse = new JsonResponse();
        }


        public JsonResponse Connect()
        {
            while (!_clientSocket.Connected)
            {
                try
                {
                    _clientSocket.Connect(IPAddress.Loopback, 100);
                }
                catch (Exception ex)
                {
                    return new JsonResponse {
                        MessageResult = "Invalid"
                    };
                }
            }

            return GetResponse();
        }

        //private JsonResponse GetResponse(Socket _clientSocket)
        //{
        //    //var idClient = _clientSocket.LocalEndPoint.ToString();

        //    //var cryptoClass = new CryptographyRepository(idClient);

        //    //var json = JsonConvert.SerializeObject(_jsonRequest, Formatting.Indented);

        //    //var encrypt = cryptoClass.Encriptar(json);
        //    //var buffer = GetBufferFromEncryptRequest();// Encoding.ASCII.GetBytes(encrypt);

        //    //_clientSocket.Send(buffer);
        //    //var receivedBuffer = new byte[BUFFER_SIZE];
        //    //var receivedBytes = _clientSocket.Receive(receivedBuffer);
        //    //var data = new byte[receivedBytes];


        //    //Array.Copy(receivedBuffer, data, receivedBytes);

        //    ////var jsonResponse = Encoding.ASCII.GetString(data);
        //    //var encryptString = Encoding.ASCII.GetString(data);
        //    //var jsonResponse = cryptoClass.Desencriptar(encryptString);
        //    //_jsonResponse = JsonConvert.DeserializeObject<JsonResponse>(jsonResponse);
        //    //if (_jsonResponse.MessageResult == "Invalid")
        //    //{
        //    //    MessageBox.Show("No se pudo completar la acción.");
        //    //    return;
        //    //}
        //    //Instance.fileRepository.Files = JsonResponse.Files;
        //    //ucMisArchivosDescarga.Instance.fileRepository.Files = JsonResponse.Files;
        //    //Console.WriteLine("Received: " + Encoding.ASCII.GetString(data));
        //}

        private JsonResponse GetResponse()
        {
            SendBufferRequest();
            var jsonResponse = ReceiveServerResponse();
            return jsonResponse;
        }

        private void SendBufferRequest()
        {
            var buffer = GetBufferFromEncryptRequest();
            _clientSocket.Send(buffer);
        }

        private byte[] GetBufferFromEncryptRequest()
        {
            var idClient = _clientSocket.LocalEndPoint.ToString();

            var cryptoClass = new CryptographyRepository(idClient);

            var json = JsonConvert.SerializeObject(_jsonRequest, Formatting.Indented);

            var encrypt = cryptoClass.Encriptar(json);
            var buffer = Encoding.ASCII.GetBytes(encrypt);

            return buffer;
        }

        private JsonResponse ReceiveServerResponse()
        {

            var idClient = _clientSocket.LocalEndPoint.ToString();

            var cryptoClass = new CryptographyRepository(idClient);

            var receivedBuffer = new byte[BUFFER_SIZE];
            var receivedBytes = _clientSocket.Receive(receivedBuffer);
            var data = new byte[receivedBytes];


            Array.Copy(receivedBuffer, data, receivedBytes);

            var encryptString = Encoding.ASCII.GetString(data);
            var jsonResponse = cryptoClass.Desencriptar(encryptString);
            _jsonResponse = JsonConvert.DeserializeObject<JsonResponse>(jsonResponse);

            return _jsonResponse;
        }



    }
}
