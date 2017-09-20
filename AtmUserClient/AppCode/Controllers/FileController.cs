using  Newtonsoft.Json;
using  SucursalElectronicaCliente.AppCode.Dto;
using  System;
using  System.Collections.Generic;
using  System.Linq;
using  System.Net;
using  System.Net.Sockets;
using  System.Text;
using  System.Threading.Tasks;

namespace  SucursalElectronicaCliente.AppCode.Controllers
{
    public class FileController
    {
        public string GetFiles(Socket _clientSocket)
        {
            while (!_clientSocket.Connected)
            {
                try
                {
                    _clientSocket.Connect(IPAddress.Loopback, 100);
                }
                catch (Exception)
                {
                    return "0";
                }
            }

            return SendMyFilesRequest(_clientSocket, new Credentials());
        }

        private string SendMyFilesRequest(Socket _clientSocket, Credentials credentials)
        {
            //while (true)
            //{
            //Console.WriteLine("Enter a request: ");
            //var request = Console.ReadLine();


            var jsonRequest = new JsonRequest
            {
                Service = "FileController",
                Action = "Listar Archivos",
                Credentials = new Credentials
                {
                    CustomerNumber = credentials.CustomerNumber,
                    Pin = credentials.Pin
                }
            };

            var json = JsonConvert.SerializeObject(jsonRequest, Formatting.Indented);

            var buffer = Encoding.ASCII.GetBytes(json);

            _clientSocket.Send(buffer);
            var receivedBuffer = new byte[1024];
            var receivedBytes = _clientSocket.Receive(receivedBuffer);
            var data = new byte[receivedBytes];


            Array.Copy(receivedBuffer, data, receivedBytes);

            return Encoding.ASCII.GetString(data);
            //JsonResponse = JsonConvert.DeserializeObject<JsonResponse>(jsonResponse);
            //if (JsonResponse.MessageResult == "Invalid")
            //{
            //    MessageBox.Show("No se pudo completar la acción.");
            //    return;
            //}
            //mainForm.Instance.fileRepository.Files = JsonResponse.Files;
            //ucMisArchivosDescarga.Instance.fileRepository.Files = JsonResponse.Files;
            //Console.WriteLine("Received: " + Encoding.ASCII.GetString(data));
        }


    }
}
