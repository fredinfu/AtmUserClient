using  System;
using  System.Collections.Generic;
using  System.ComponentModel;
using  System.Drawing;
using  System.Data;
using  System.Linq;
using  System.Text;
using  System.Threading.Tasks;
using  System.Windows.Forms;

namespace  SecureFtpClientUserControls
{
    public partial class ucProductos : UserControl
    {
        public ucProductos()
        {
            InitializeComponent();
        }

        private void ucProductos_Load(object sender, EventArgs e)
        {
            var productos = new
            {
                NumeroProducto = "8984321",
                TipoCuenta = "Cuenta de Ahorro",
                Etiqueta = "Ahorro en Dolares",
                MontoFavor = "9,888.00",
                SaldoEnLibros = ""
            };
        }
    }
}
