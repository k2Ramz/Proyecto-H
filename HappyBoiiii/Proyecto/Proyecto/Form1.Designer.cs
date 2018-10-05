namespace Proyecto
{
    partial class fCarga
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCarga));
            this.picCarga = new System.Windows.Forms.PictureBox();
            this.pgCarga = new System.Windows.Forms.ProgressBar();
            this.lblCarga = new System.Windows.Forms.Label();
            this.tmCarga = new System.Windows.Forms.Timer(this.components);
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCarga)).BeginInit();
            this.SuspendLayout();
            // 
            // picCarga
            // 
            this.picCarga.Image = ((System.Drawing.Image)(resources.GetObject("picCarga.Image")));
            this.picCarga.Location = new System.Drawing.Point(0, 43);
            this.picCarga.Name = "picCarga";
            this.picCarga.Size = new System.Drawing.Size(411, 200);
            this.picCarga.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCarga.TabIndex = 0;
            this.picCarga.TabStop = false;
            // 
            // pgCarga
            // 
            this.pgCarga.Location = new System.Drawing.Point(35, 249);
            this.pgCarga.Name = "pgCarga";
            this.pgCarga.Size = new System.Drawing.Size(327, 23);
            this.pgCarga.TabIndex = 1;
            // 
            // lblCarga
            // 
            this.lblCarga.AutoSize = true;
            this.lblCarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarga.Location = new System.Drawing.Point(184, 275);
            this.lblCarga.Name = "lblCarga";
            this.lblCarga.Size = new System.Drawing.Size(30, 25);
            this.lblCarga.TabIndex = 2;
            this.lblCarga.Text = "...";
            // 
            // tmCarga
            // 
            this.tmCarga.Enabled = true;
            this.tmCarga.Interval = 60;
            this.tmCarga.Tick += new System.EventHandler(this.tmCarga_Tick);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(387, 25);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Centro de Entretenimiento \"Happy Boy\"";
            // 
            // fCarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(411, 310);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblCarga);
            this.Controls.Add(this.pgCarga);
            this.Controls.Add(this.picCarga);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fCarga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carga";
            this.TransparencyKey = System.Drawing.Color.Gray;
            this.Load += new System.EventHandler(this.fCarga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCarga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCarga;
        private System.Windows.Forms.ProgressBar pgCarga;
        private System.Windows.Forms.Label lblCarga;
        private System.Windows.Forms.Timer tmCarga;
        private System.Windows.Forms.Label lblTitulo;
    }
}

