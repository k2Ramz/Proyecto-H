namespace Proyecto
{
    partial class fVideos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fVideos));
            this.WMP = new AxWMPLib.AxWindowsMediaPlayer();
            this.picRegresar = new System.Windows.Forms.PictureBox();
            this.picVideos = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRegresar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVideos)).BeginInit();
            this.SuspendLayout();
            // 
            // WMP
            // 
            this.WMP.Enabled = true;
            this.WMP.Location = new System.Drawing.Point(12, 12);
            this.WMP.Name = "WMP";
            this.WMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMP.OcxState")));
            this.WMP.Size = new System.Drawing.Size(410, 260);
            this.WMP.TabIndex = 0;
            // 
            // picRegresar
            // 
            this.picRegresar.BackColor = System.Drawing.Color.Transparent;
            this.picRegresar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picRegresar.BackgroundImage")));
            this.picRegresar.Image = ((System.Drawing.Image)(resources.GetObject("picRegresar.Image")));
            this.picRegresar.Location = new System.Drawing.Point(12, 311);
            this.picRegresar.Name = "picRegresar";
            this.picRegresar.Size = new System.Drawing.Size(39, 38);
            this.picRegresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRegresar.TabIndex = 3;
            this.picRegresar.TabStop = false;
            this.picRegresar.Click += new System.EventHandler(this.picRegresar_Click);
            // 
            // picVideos
            // 
            this.picVideos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picVideos.Image = ((System.Drawing.Image)(resources.GetObject("picVideos.Image")));
            this.picVideos.Location = new System.Drawing.Point(0, 0);
            this.picVideos.Name = "picVideos";
            this.picVideos.Size = new System.Drawing.Size(434, 361);
            this.picVideos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picVideos.TabIndex = 9;
            this.picVideos.TabStop = false;
            // 
            // fVideos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 361);
            this.Controls.Add(this.picRegresar);
            this.Controls.Add(this.WMP);
            this.Controls.Add(this.picVideos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fVideos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Videos";
            this.Load += new System.EventHandler(this.fVideos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRegresar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVideos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer WMP;
        private System.Windows.Forms.PictureBox picRegresar;
        private System.Windows.Forms.PictureBox picVideos;
    }
}