using SecureFtpClient.AppCode.Dto; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureFtpClient.AppCode.Repository
{
    class CuentasBancariaRepository
    {
        public List<ProductoBancario> GetCuentasBancarias(string cliente)
        {
            return new List<ProductoBancario> {
                new ProductoBancario
                {
                    NumeroCuenta = "789854654",
                    Descripcion = "Cuenta Planilla",
                    Moneda = "LPS",
                    Saldo = 3500.00,
                    FechaCreacion = "01/03/2017"
                },
                new ProductoBancario
                {
                    NumeroCuenta = "789854654",
                    Descripcion = "Cuenta Ahorro",
                    Moneda = "LPS",
                    Saldo = 22780.00,
                    FechaCreacion = "01/01/2016"
                }
            };
        }
    }
}
