using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using SucursalElectronicaCliente.AppCode.Dto;
using Newtonsoft.Json;

namespace SecureFtpClient.UserControls
{
    public partial class ucMainMenu : ucBase
    {
        public ucMainMenu()
        {
            InitializeComponent();
        }

        private void ucMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void MakeDigitarCuentaVisible()
        {
            //mtbDigitarCuenta.Visible = true;
            //mcbCuentaDestino.Visible = false;
        }

        private void MakeSelectCuentaVisible()
        {
            //mtbDigitarCuenta.Visible = false;
            //mcbCuentaDestino.Visible = true;
        }

        private void mbCuentaOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            //mpCuentaDestino.Visible = true;
        }

        private void mrbDigitarCuenta_CheckedChanged(object sender, EventArgs e)
        {
            MakeDigitarCuentaVisible();
        }

        private void mrbPropias_CheckedChanged(object sender, EventArgs e)
        {
            MakeSelectCuentaVisible();
        }

        private void mtbDigitarCuenta_TextChanged(object sender, EventArgs e)
        {
            //mpMonto.Visible = mtbDigitarCuenta.Text.Trim() != string.Empty;
        }

        private void mcbCuentaDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            //mpMonto.Visible = true;
        }

        private void mtbLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void mrbFavoritos_CheckedChanged(object sender, EventArgs e)
        {
            MakeSelectCuentaVisible();
        }

        private void metroQryCuentas_Click(object sender, EventArgs e)
        {
            ShowMisArchivosDescarga();
        }

        private void ShowMisArchivosDescarga()
        {
            //mainForm.Instance.GetMisArchivosDescarga();
            BringToFront(typeof(ucMisArchivosDescarga).Name);
            ucMisArchivosDescarga.Instance.LoadDataForm();
        }

        private void ShowRetiroUI()
        {
            //mainForm.Instance.GetMisArchivosDescarga();
            BringToFront(typeof(ucRetiroMisCuentas).Name);
            ucRetiroMisCuentas.Instance.LoadDataForm();
        }

        //private void metroQryTarjetas_Click(object sender, EventArgs e)
        //{
        //    BringToFront(typeof(ucConsultasTarjetasCredito).Name);
        //    ucConsultasTarjetasCredito.Instance.LoadDataForm();
        //}

        private void mtExplore_Click(object sender, EventArgs e)
        {
            ShowRetiroUI();
            return;
            var dialog = new OpenFileDialog();
            dialog.Title = "Selecciona tu archivo";
            dialog.InitialDirectory = @"C:\";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                //mtFilePath.Text = dialog.FileName;
                //mainForm.Instance.SafeFileNameSelected = dialog.SafeFileName;
            }
            //var openFileDialog1 = new OpenFileDialog();
            //if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //{
            //    var sr = new System.IO.StreamReader(openFileDialog1.FileName);

            //}
        }

        private void metroTabPage2_Click(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

            ShowMisArchivosDescarga();
        }

        private void mtShareDl_Click(object sender, EventArgs e)
        {
            BringToFront(typeof(ucArchivosPermitidosDescarga).Name);
            ucArchivosPermitidosDescarga.Instance.LoadDataForm();
        }



        private void mlBack_Click(object sender, EventArgs e)
        {
            //if (mtFilePath.Text.Trim() == string.Empty)
            //{
            //    MessageBox.Show("Debe seleccionar un archivo antes de hacer click en subir.");
            //    return;
            //}
            //mainForm.Instance.UploadArchivoSeleccionado(mtFilePath.Text);
        }

        private void metroLink2_Click(object sender, EventArgs e)
        {
            var bitacora = new List<object> {
                new
                {
                    Accion = "Inicio Sesion",
                    Fecha = "12/31/2016",
                    Descripcion = "El usuario ha iniciado sesion correctamente."
                },
                new
                {
                    Accion = "Inicio Sesion",
                    Fecha = "12/31/2016",
                    Descripcion = "El usuario ha ingresado un password incorrecto."
                },
                new
                {
                    Accion = "Inicio Sesion",
                    Fecha = "12/31/2016",
                    Descripcion = "El usuario ha iniciado sesion correctamente."
                }
            };
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            BringToFront(typeof(ucConsultaDeSaldo).Name);
            ucConsultaDeSaldo.Instance.LoadDataForm();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
