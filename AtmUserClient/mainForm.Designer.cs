namespace  SecureFtpClient 
{
    partial class mainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.mlBack = new MetroFramework.Controls.MetroLink();
            this.mpMainPanel = new MetroFramework.Controls.MetroPanel();
            this.SuspendLayout();
            // 
            // mlBack
            // 
            this.mlBack.Image = ((System.Drawing.Image)(resources.GetObject("mlBack.Image")));
            this.mlBack.ImageSize = 32;
            this.mlBack.Location = new System.Drawing.Point(31, 25);
            this.mlBack.Margin = new System.Windows.Forms.Padding(4);
            this.mlBack.Name = "mlBack";
            this.mlBack.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("mlBack.NoFocusImage")));
            this.mlBack.Size = new System.Drawing.Size(51, 43);
            this.mlBack.TabIndex = 0;
            this.mlBack.UseSelectable = true;
            this.mlBack.Click += new System.EventHandler(this.mlBack_Click);
            // 
            // mpMainPanel
            // 
            this.mpMainPanel.HorizontalScrollbarBarColor = true;
            this.mpMainPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.mpMainPanel.HorizontalScrollbarSize = 12;
            this.mpMainPanel.Location = new System.Drawing.Point(0, 75);
            this.mpMainPanel.Margin = new System.Windows.Forms.Padding(4);
            this.mpMainPanel.Name = "mpMainPanel";
            this.mpMainPanel.Size = new System.Drawing.Size(963, 437);
            this.mpMainPanel.TabIndex = 1;
            this.mpMainPanel.VerticalScrollbarBarColor = true;
            this.mpMainPanel.VerticalScrollbarHighlightOnWheel = false;
            this.mpMainPanel.VerticalScrollbarSize = 13;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 540);
            this.Controls.Add(this.mpMainPanel);
            this.Controls.Add(this.mlBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "mainForm";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "      ATM User Client";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLink mlBack;
        private MetroFramework.Controls.MetroPanel mpMainPanel;
    }
}

