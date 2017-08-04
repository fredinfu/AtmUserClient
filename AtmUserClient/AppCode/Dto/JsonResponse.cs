using  SucursalElectronicaCliente.AppCode.DtoModels;
using  System;
using  System.Collections.Generic;
using  System.Linq;
using  System.Text;
using  System.Threading.Tasks;

namespace  SucursalElectronicaCliente.AppCode.Dto
{
    class JsonResponse : JsonFormat
    {
        public string Result { get; set; }
        public UserDto UserAux { get; set; }
        public FileDto FileAux { get; set; }
        public List<UserDto> Users { get; set; }
        public List<FileDto> Files { get; set; }
    }
}
