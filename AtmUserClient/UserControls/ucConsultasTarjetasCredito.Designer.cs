namespace SucursalElectronicaCliente.UserControls
{
    partial class ucConsultasTarjetasCredito
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucConsultasTarjetasCredito));
            this.mcbTarjetasCredito = new MetroFramework.Controls.MetroComboBox();
            this.mlCuenta = new MetroFramework.Controls.MetroLabel();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.mlDownload = new MetroFramework.Controls.MetroLink();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // mcbTarjetasCredito
            // 
            this.mcbTarjetasCredito.FormattingEnabled = true;
            this.mcbTarjetasCredito.ItemHeight = 24;
            this.mcbTarjetasCredito.Items.AddRange(new object[] {
            "ffunez",
            "cpineda",
            "Todos"});
            this.mcbTarjetasCredito.Location = new System.Drawing.Point(83, 30);
            this.mcbTarjetasCredito.Margin = new System.Windows.Forms.Padding(4);
            this.mcbTarjetasCredito.Name = "mcbTarjetasCredito";
            this.mcbTarjetasCredito.PromptText = "&Seleccione una fuente de datos";
            this.mcbTarjetasCredito.Size = new System.Drawing.Size(283, 30);
            this.mcbTarjetasCredito.TabIndex = 9;
            this.mcbTarjetasCredito.UseSelectable = true;
            this.mcbTarjetasCredito.SelectedIndexChanged += new System.EventHandler(this.mcbCuentaBancaria_SelectedIndexChanged);
            // 
            // mlCuenta
            // 
            this.mlCuenta.AutoSize = true;
            this.mlCuenta.Location = new System.Drawing.Point(16, 30);
            this.mlCuenta.Name = "mlCuenta";
            this.mlCuenta.Size = new System.Drawing.Size(51, 20);
            this.mlCuenta.TabIndex = 1;
            this.mlCuenta.Text = "Autor: ";
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(16, 79);
            this.metroGrid1.Margin = new System.Windows.Forms.Padding(4);
            this.metroGrid1.MultiSelect = false;
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(1093, 366);
            this.metroGrid1.TabIndex = 0;
            this.metroGrid1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellClick);
            this.metroGrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellContentClick);
            // 
            // mlDownload
            // 
            this.mlDownload.Enabled = false;
            this.mlDownload.Image = ((System.Drawing.Image)(resources.GetObject("mlDownload.Image")));
            this.mlDownload.ImageSize = 32;
            this.mlDownload.Location = new System.Drawing.Point(16, 453);
            this.mlDownload.Margin = new System.Windows.Forms.Padding(4);
            this.mlDownload.Name = "mlDownload";
            this.mlDownload.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("mlDownload.NoFocusImage")));
            this.mlDownload.Size = new System.Drawing.Size(51, 43);
            this.mlDownload.TabIndex = 14;
            this.mlDownload.UseSelectable = true;
            this.mlDownload.Visible = false;
            // 
            // ucConsultasTarjetasCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mlDownload);
            this.Controls.Add(this.mcbTarjetasCredito);
            this.Controls.Add(this.mlCuenta);
            this.Controls.Add(this.metroGrid1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ucConsultasTarjetasCredito";
            this.Size = new System.Drawing.Size(1128, 602);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroLabel mlCuenta;
        private MetroFramework.Controls.MetroComboBox mcbTarjetasCredito;
        private MetroFramework.Controls.MetroLink mlDownload;
    }
}
