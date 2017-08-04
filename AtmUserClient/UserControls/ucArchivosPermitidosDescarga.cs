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

namespace  SecureFtpClient.UserControls
{
    public partial class ucArchivosPermitidosDescarga : ucBase
    {
        public bool download { get; private set; }
        public ucArchivosPermitidosDescarga()
        {
            InitializeComponent();
            InitializeGrid();


        }
        static ucArchivosPermitidosDescarga _instance;

        public static ucArchivosPermitidosDescarga Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucArchivosPermitidosDescarga();
                return _instance;
            }
        }

        

        public override void LoadDataForm()
        {
            metroGrid1.DataSource = GetConsultasBancarias("Todos");
            //mcbTarjetasCredito.DataSource = ProductoBancarioController.GetTarjetasCredito();
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
            
        }

        private object GetConsultasBancarias(string autor)
        {
            var todos = new List<object>();
            var ffunez = new List<object> {
                new
                {
                    Fecha = "01/01/2017",
                    NombreArchivo = "video12341.mp4",
                    Peso = "10 MB",
                    Descripcion = "Video de cumple",
                    Autor = "ffunez"

                },
                new
                {
                    Fecha = "01/01/2017",
                    NombreArchivo = "video12341.mp4",
                    Peso = "10 MB",
                    Descripcion = "Video de fiesta",
                    Autor = "ffunez"

                }
            };

            var cpineda = new List<object> {
                new
                {
                    Fecha = "01/01/2017",
                    NombreArchivo = "foto8726384.jpg",
                    Peso = "1 MB",
                    Descripcion = "Foto de cumple",
                    Autor = "cpineda"

                },
                new
                {
                    Fecha = "01/01/2017",
                    NombreArchivo = "IMGWA73685638.png",
                    Peso = "2 MB",
                    Descripcion = "Foto de graduacion",
                    Autor = "cpineda"
                }
            };

            //var publico = new List<object> {
            //    new
            //    {
            //        Fecha = "01/01/2017",
            //        NombreArchivo = "wav8726384.wav",
            //        Peso = "6 MB",
            //        Descripcion = "Conferencia Angular",
            //        Autor = "Steve Goog"

            //    },
            //    new
            //    {
            //        Fecha = "01/01/2017",
            //        NombreArchivo = "SeekAndDestroy.mp3",
            //        Peso = "5 MB",
            //        Descripcion = "Rolota Metallica",
            //        Autor = "Metal Jordan"
            //    }
            //};
            switch (autor)
            {
                case "ffunez": return ffunez;
                case "cpineda": return cpineda;
                //case "Publico": return publico;
                case "Todos":
                    foreach (var item in ffunez)
                    {
                        todos.Add(item);
                    }
                    foreach (var item in cpineda)
                    {
                        todos.Add(item);
                    }
                    //foreach (var item in publico)
                    //{
                    //    todos.Add(item);
                    //}

                    return todos;
                default: return new List<object>();
            }
            
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

        //private void ShowDetalleCuentaBancaria()
        //{
        //    BringToFront(typeof(ucDetalleCuentaBancaria).Name);
        //}
        
        private void mcbCuentaBancaria_SelectedIndexChanged(object sender, EventArgs e)
        {
            var mcb = mcbTarjetasCredito.SelectedItem;
            metroGrid1.DataSource = mainForm.Instance.fileRepository.Files.Where(w => w.CreatedByUsername == mcb.ToString());
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void metroLink2_Click(object sender, EventArgs e)
        {
            mainForm.Instance.GetMisArchivosCompartidos();
            var files = mainForm.Instance.fileRepository.Files;
            var users = mainForm.Instance.userRepository.Users;
            Invoke((MethodInvoker)(delegate
            {
                metroGrid1.Font = new Font("Segoe UI", 11f, FontStyle.Regular, GraphicsUnit.Pixel);
                metroGrid1.AllowUserToAddRows = false;
                metroGrid1.DataSource = files;
            }));
            Invoke((MethodInvoker)(delegate
            {
                foreach(var user in users)
                {
                    mcbTarjetasCredito.Items.Add(user.Username);
                }
                //mcbTarjetasCredito.DataSource = users;
            }));
        }
    }
}
