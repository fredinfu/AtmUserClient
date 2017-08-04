using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace SucursalElectronicaCliente.UserControls
{
    public partial class ucDetalleCuentaBancaria : ucBase
    {
        public ucDetalleCuentaBancaria()
        {
            InitializeComponent();
            InitializeGridConsultasBancarias();
            mlNombreCuenta.Text = description;
            mlCuenta.Text = account;
        }



        private void InitializeGridConsultasBancarias()
        {
            metroGrid1.DataSource = GetConsultasBancarias();
            metroGrid1.Font = new Font("Segoe UI", 11f, FontStyle.Regular, GraphicsUnit.Pixel);
            metroGrid1.AllowUserToAddRows = false;
            metroGrid1.Columns[0].DisplayIndex = 3;
        }

        private object GetConsultasBancarias()
        {
            return new List<object> {
                new
                {
                    Fecha = "01/01/2017",
                    Transaccion = "12345687",
                    Codigo = "CP",
                    Descripcion = "Ruby Tuesday",
                    Debito = 350.00,
                    Credito = 0.00
                },
                new
                {
                    Fecha = "03/01/2017",
                    Transaccion = "132425345",
                    Codigo = "CP",
                    Descripcion = "Friday's",
                    Debito = 450.00,
                    Credito = 0.00
                },
                new
                {
                    Fecha = "05/01/2017",
                    Transaccion = "12345687",
                    Codigo = "CP",
                    Descripcion = "Acosa",
                    Debito = 620.00,
                    Credito = 0.00
                },
                new
                {
                    Fecha = "05/01/2017",
                    Transaccion = "12345687",
                    Codigo = "CP",
                    Descripcion = "Videocom Lucas",
                    Debito = 987.00,
                    Credito = 0.00
                }
            };
        }

        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
