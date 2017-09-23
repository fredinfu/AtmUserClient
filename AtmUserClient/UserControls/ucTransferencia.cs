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
using  SucursalElectronicaCliente.AppCode.Repository;
using  SucursalElectronicaCliente.AppCode.DtoModels;

namespace  SecureFtpClient.UserControls
{
    public partial class ucTransferencia : ucBase
    {
        public ucTransferencia()
        {
            //fileRepository = new FileRepository();
            InitializeComponent();
        }
        static ucTransferencia _instance;

        public static ucTransferencia Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucTransferencia();
                return _instance;
            }
        }



        public override void LoadDataForm()
        {
            ////if (mainForm.Instance.fileRepository.Files != null)
            //{
            //    var files = mainForm.Instance.fileRepository.Files;
            //    Invoke((MethodInvoker)(delegate
            //    {
            //        //metroGrid1.Font = new Font("Segoe UI", 11f, FontStyle.Regular, GraphicsUnit.Pixel);
            //        //metroGrid1.AllowUserToAddRows = false;
            //        //metroGrid1.DataSource = files;
            //    }));
            //}

            //if (!fileRepository.Files.Any()) return;
            //Invoke((MethodInvoker)(delegate
            //{
            //    metroGrid1.DataSource = fileRepository.Files;
            //}));
        }


        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //var cell = (DataGridViewImageCell)
            //    metroGrid1.Rows[e.RowIndex].Cells[e.ColumnIndex];

            //switch (cell.OwningColumn.HeaderText)
            //{
            //    case "Ver":
            //        account = metroGrid1.Rows[e.RowIndex].Cells[1].Value.ToString();
            //        description = metroGrid1.Rows[e.RowIndex].Cells[2].Value.ToString();
            //        ucDetalleCuentaBancaria.Instance.Controls["mlCuenta"].Text = account;
            //        ucDetalleCuentaBancaria.Instance.Controls["mlNombreCuenta"].Text = description;
            //        ShowDetalleCuentaBancaria();
            //        break;
            //}
        }

        private void ShowDetalleCuentaBancaria()
        {
            //BringToFront(typeof(ucDetalleCuentaBancaria).Name);
        }

        private void mcbCuentaBancaria_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void metroLink2_Click(object sender, EventArgs e)
        {
            mainForm.Instance.GetMisArchivosDescarga();
            var files = mainForm.Instance.fileRepository.Files;
            Invoke((MethodInvoker)(delegate
            {
                //metroGrid1.Font = new Font("Segoe UI", 11f, FontStyle.Regular, GraphicsUnit.Pixel);
                //metroGrid1.AllowUserToAddRows = false;
                //metroGrid1.DataSource = files;
            }));
        }
    }
}
