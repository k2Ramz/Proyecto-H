namespace Proyecto
{
    partial class fGaleria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fGaleria));
            this.picGaleria = new System.Windows.Forms.PictureBox();
            this.btnAleatorio = new System.Windows.Forms.Button();
            this.picRegresar = new System.Windows.Forms.PictureBox();
            this.picGaleriaM = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picGaleria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRegresar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGaleriaM)).BeginInit();
            this.SuspendLayout();
            // 
            // picGaleria
            // 
            this.picGaleria.Location = new System.Drawing.Point(12, 12);
            this.picGaleria.Name = "picGaleria";
            this.picGaleria.Size = new System.Drawing.Size(410, 293);
            this.picGaleria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGaleria.TabIndex = 0;
            this.picGaleria.TabStop = false;
            this.picGaleria.Click += new System.EventHandler(this.picGaleria_Click);
            // 
            // btnAleatorio
            // 
            this.btnAleatorio.Location = new System.Drawing.Point(182, 311);
            this.btnAleatorio.Name = "btnAleatorio";
            this.btnAleatorio.Size = new System.Drawing.Size(75, 38);
            this.btnAleatorio.TabIndex = 1;
            this.btnAleatorio.Text = "Aleatorio";
            this.btnAleatorio.UseVisualStyleBackColor = true;
            this.btnAleatorio.Click += new System.EventHandler(this.btnAleatorio_Click);
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
            this.picRegresar.TabIndex = 5;
            this.picRegresar.TabStop = false;
            this.picRegresar.Click += new System.EventHandler(this.picRegresar_Click);
            // 
            // picGaleriaM
            // 
            this.picGaleriaM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picGaleriaM.Image = ((System.Drawing.Image)(resources.GetObject("picGaleriaM.Image")));
            this.picGaleriaM.Location = new System.Drawing.Point(0, 0);
            this.picGaleriaM.Name = "picGaleriaM";
            this.picGaleriaM.Size = new System.Drawing.Size(434, 361);
            this.picGaleriaM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGaleriaM.TabIndex = 9;
            this.picGaleriaM.TabStop = false;
            // 
            // fGaleria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 361);
            this.Controls.Add(this.picRegresar);
            this.Controls.Add(this.btnAleatorio);
            this.Controls.Add(this.picGaleria);
            this.Controls.Add(this.picGaleriaM);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fGaleria";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Galeria";
            ((System.ComponentModel.ISupportInitialize)(this.picGaleria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRegresar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGaleriaM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picGaleria;
        private System.Windows.Forms.Button btnAleatorio;
        private System.Windows.Forms.PictureBox picRegresar;
        private System.Windows.Forms.PictureBox picGaleriaM;
    }
}