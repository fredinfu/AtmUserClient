using SecureFtpClient.AppCode.Dto; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureFtpClient.AppCode.Repository
{
    class TarjetasCreditoRepository
    {
        public List<ProductoBancario> GetTarjetasCredito(string cliente)
        {
            return new List<ProductoBancario> {
                new ProductoBancario
                {
                    NumeroCuenta = "789114634",
                    Descripcion = "Gasoline Card",
                    Moneda = "LPS",
                    Saldo = 3500.00,
                    FechaCreacion = "01/03/2017"
                },
                new ProductoBancario
                {
                    NumeroCuenta = "789892753",
                    Descripcion = "PharmaCard",
                    Moneda = "LPS",
                    Saldo = 322780.00,
                    FechaCreacion = "01/01/2016"
                }
            };
        }
    }
}
