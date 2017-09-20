using  SucursalElectronicaCliente.AppCode.DtoModels;
using  System;
using  System.Collections.Generic;
using  System.Linq;
using  System.Text;
using  System.Threading.Tasks;

namespace  SucursalElectronicaCliente.AppCode.Dto
{
    public class JsonResponse : JsonFormat
    {
        public string MessageResult { get; set; }
        public string CustomerNumber { get; set; }
        public string CustomerName { get; set; }
        public List<LogDto> Logs { get; set; }
        public UserDto UserAux { get; set; }
        public FileDto FileAux { get; set; }
        public List<UserDto> Users { get; set; }
        public List<FileDto> Files { get; set; }
    }
}
