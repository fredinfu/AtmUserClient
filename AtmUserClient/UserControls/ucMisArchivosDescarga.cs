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
    public partial class ucMisArchivosDescarga : ucBase
    {
        public FileRepository fileRepository { get; set; }
        public bool download { get; private set; }
        public ucMisArchivosDescarga()
        {
            fileRepository = new FileRepository();
            InitializeComponent();
            InitializeGrid();
        }
        static ucMisArchivosDescarga _instance;

        public static ucMisArchivosDescarga Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucMisArchivosDescarga();
                return _instance;
            }
        }



        public override void LoadDataForm()
        {
            //if (!fileRepository.Files.Any()) return;
            //Invoke((MethodInvoker)(delegate
            //{
            //    metroGrid1.DataSource = fileRepository.Files;
            //}));
        }

        public override void Download(bool set)
        {
            //mlDownload.Visible = set;
            //mlDownload.Enabled = set;
        }

        private void InitializeGrid()
        {
            metroGrid1.Font = new Font("Segoe UI", 11f, FontStyle.Regular, GraphicsUnit.Pixel);
            metroGrid1.AllowUserToAddRows = false;
            return;
            if (mainForm.Instance.fileRepository.Files != null)
            {
                var files = mainForm.Instance.fileRepository.Files;
                Invoke((MethodInvoker)(delegate
                {
                    metroGrid1.Font = new Font("Segoe UI", 11f, FontStyle.Regular, GraphicsUnit.Pixel);
                    metroGrid1.AllowUserToAddRows = false;
                    metroGrid1.DataSource = files;
                }));
            }
            Invoke((MethodInvoker)(delegate
            {
                metroGrid1.Font = new Font("Segoe UI", 11f, FontStyle.Regular, GraphicsUnit.Pixel);
                metroGrid1.AllowUserToAddRows = false;
                metroGrid1.DataSource = fileRepository.Files == null ? new List<FileDto>() : fileRepository.Files;
            }));

        }

        private object GetConsultasBancarias()
        {
            return new List<object> {
                new
                {
                    Fecha = "01/01/2017",
                    NombreArchivo = "video12341.mp4",
                    Peso = "10 MB",
                    Descripcion = "Video de cumple",
                },
                new
                {
                    Fecha = "01/01/2017",
                    NombreArchivo = "video12341.mp4",
                    Peso = "10 MB",
                    Descripcion = "Video de cumple",
                },
                new
                {
                    Fecha = "01/01/2017",
                    NombreArchivo = "video12341.mp4",
                    Peso = "10 MB",
                    Descripcion = "Video de cumple",
                },
                new
                {
                    Fecha = "01/01/2017",
                    NombreArchivo = "video12341.mp4",
                    Peso = "10 MB",
                    Descripcion = "Video de cumple",
                }
            };
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
            if (download)
            {
                //mlDownload.Visible = true;
                //mlDownload.Enabled = true;
            }

        }

        private void metroLink2_Click(object sender, EventArgs e)
        {
            mainForm.Instance.GetMisArchivosDescarga();
            var files = mainForm.Instance.fileRepository.Files;
            Invoke((MethodInvoker)(delegate
            {
                metroGrid1.Font = new Font("Segoe UI", 11f, FontStyle.Regular, GraphicsUnit.Pixel);
                metroGrid1.AllowUserToAddRows = false;
                metroGrid1.DataSource = files;
            }));
        }
    }
}
