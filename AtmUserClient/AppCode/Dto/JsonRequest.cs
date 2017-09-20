using  SucursalElectronicaCliente.AppCode.DtoModels;
using  System;
using  System.Collections.Generic;
using  System.Linq;
using  System.Text;
using  System.Threading.Tasks;

namespace  SucursalElectronicaCliente.AppCode.Dto
{
    public class JsonRequest : JsonFormat
    {
        public string Service { get; set; }
        public string Action { get; set; }
        public UserDto UserAux { get; set; }
        public FileDto FileAux { get; set; }
    }
}
