namespace  SecureFtpClient.UserControls
{
    partial class ucMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucMainMenu));
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.mlBack = new MetroFramework.Controls.MetroLink();
            this.mtFilePath = new MetroFramework.Controls.MetroLabel();
            this.mtExplore = new MetroFramework.Controls.MetroTile();
            this.lblMbCuentaOrigen = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.mtMisArchivosDl = new MetroFramework.Controls.MetroTile();
            this.mtShareDl = new MetroFramework.Controls.MetroTile();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Location = new System.Drawing.Point(3, 2);
            this.metroTabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(1217, 472);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroLabel3);
            this.metroTabPage2.Controls.Add(this.mlBack);
            this.metroTabPage2.Controls.Add(this.mtFilePath);
            this.metroTabPage2.Controls.Add(this.mtExplore);
            this.metroTabPage2.Controls.Add(this.lblMbCuentaOrigen);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 12;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(1209, 430);
            this.metroTabPage2.TabIndex = 6;
            this.metroTabPage2.Text = "&Subir Archivos";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 13;
            this.metroTabPage2.Click += new System.EventHandler(this.metroTabPage2_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(16, 151);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(91, 20);
            this.metroLabel3.TabIndex = 14;
            this.metroLabel3.Text = "Subir Archivo";
            // 
            // mlBack
            // 
            this.mlBack.Image = ((System.Drawing.Image)(resources.GetObject("mlBack.Image")));
            this.mlBack.ImageSize = 32;
            this.mlBack.Location = new System.Drawing.Point(16, 175);
            this.mlBack.Margin = new System.Windows.Forms.Padding(4);
            this.mlBack.Name = "mlBack";
            this.mlBack.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("mlBack.NoFocusImage")));
            this.mlBack.Size = new System.Drawing.Size(51, 43);
            this.mlBack.TabIndex = 13;
            this.mlBack.UseSelectable = true;
            this.mlBack.Click += new System.EventHandler(this.mlBack_Click);
            // 
            // mtFilePath
            // 
            this.mtFilePath.AutoSize = true;
            this.mtFilePath.Location = new System.Drawing.Point(16, 118);
            this.mtFilePath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mtFilePath.Name = "mtFilePath";
            this.mtFilePath.Size = new System.Drawing.Size(18, 20);
            this.mtFilePath.TabIndex = 12;
            this.mtFilePath.Text = "...";
            // 
            // mtExplore
            // 
            this.mtExplore.ActiveControl = null;
            this.mtExplore.Location = new System.Drawing.Point(16, 47);
            this.mtExplore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtExplore.Name = "mtExplore";
            this.mtExplore.Size = new System.Drawing.Size(187, 66);
            this.mtExplore.TabIndex = 11;
            this.mtExplore.Text = "Examinar...";
            this.mtExplore.UseSelectable = true;
            this.mtExplore.Click += new System.EventHandler(this.mtExplore_Click);
            // 
            // lblMbCuentaOrigen
            // 
            this.lblMbCuentaOrigen.AutoSize = true;
            this.lblMbCuentaOrigen.Location = new System.Drawing.Point(16, 20);
            this.lblMbCuentaOrigen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMbCuentaOrigen.Name = "lblMbCuentaOrigen";
            this.lblMbCuentaOrigen.Size = new System.Drawing.Size(112, 20);
            this.lblMbCuentaOrigen.TabIndex = 7;
            this.lblMbCuentaOrigen.Text = "Archivos Propios";
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.metroLabel4);
            this.metroTabPage3.Controls.Add(this.mtMisArchivosDl);
            this.metroTabPage3.Controls.Add(this.mtShareDl);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 12;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(1209, 430);
            this.metroTabPage3.TabIndex = 16;
            this.metroTabPage3.Text = "&Descargar Archivos";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 13;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(4, 18);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(235, 20);
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "Seleccione repositorio de descargas:";
            // 
            // mtMisArchivosDl
            // 
            this.mtMisArchivosDl.ActiveControl = null;
            this.mtMisArchivosDl.Location = new System.Drawing.Point(4, 40);
            this.mtMisArchivosDl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtMisArchivosDl.Name = "mtMisArchivosDl";
            this.mtMisArchivosDl.Size = new System.Drawing.Size(187, 66);
            this.mtMisArchivosDl.TabIndex = 5;
            this.mtMisArchivosDl.Text = "Mis Archivos";
            this.mtMisArchivosDl.UseSelectable = true;
            this.mtMisArchivosDl.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // mtShareDl
            // 
            this.mtShareDl.ActiveControl = null;
            this.mtShareDl.Location = new System.Drawing.Point(4, 109);
            this.mtShareDl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtShareDl.Name = "mtShareDl";
            this.mtShareDl.Size = new System.Drawing.Size(187, 66);
            this.mtShareDl.TabIndex = 6;
            this.mtShareDl.Text = "Archivos Permitidos";
            this.mtShareDl.UseSelectable = true;
            this.mtShareDl.Click += new System.EventHandler(this.mtShareDl_Click);
            // 
            // ucMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroTabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ucMainMenu";
            this.Size = new System.Drawing.Size(1236, 565);
            this.Load += new System.EventHandler(this.ucMainMenu_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.metroTabPage3.ResumeLayout(false);
            this.metroTabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroLabel lblMbCuentaOrigen;
        private MetroFramework.Controls.MetroTile mtExplore;
        private MetroFramework.Controls.MetroLabel mtFilePath;
        private MetroFramework.Controls.MetroLink mlBack;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTile mtMisArchivosDl;
        private MetroFramework.Controls.MetroTile mtShareDl;
    }
}
