namespace Proyecto
{
    partial class fLibros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLibros));
            this.picRegresar = new System.Windows.Forms.PictureBox();
            this.tabLibros = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.picLibros = new System.Windows.Forms.PictureBox();
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.axAcroPDF2 = new AxAcroPDFLib.AxAcroPDF();
            this.axAcroPDF3 = new AxAcroPDFLib.AxAcroPDF();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.axAcroPDF4 = new AxAcroPDFLib.AxAcroPDF();
            ((System.ComponentModel.ISupportInitialize)(this.picRegresar)).BeginInit();
            this.tabLibros.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLibros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF4)).BeginInit();
            this.SuspendLayout();
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
            this.picRegresar.TabIndex = 4;
            this.picRegresar.TabStop = false;
            this.picRegresar.Click += new System.EventHandler(this.picRegresar_Click);
            // 
            // tabLibros
            // 
            this.tabLibros.Controls.Add(this.tabPage1);
            this.tabLibros.Controls.Add(this.tabPage2);
            this.tabLibros.Controls.Add(this.tabPage3);
            this.tabLibros.Controls.Add(this.tabPage4);
            this.tabLibros.Location = new System.Drawing.Point(0, 0);
            this.tabLibros.Name = "tabLibros";
            this.tabLibros.SelectedIndex = 0;
            this.tabLibros.Size = new System.Drawing.Size(433, 305);
            this.tabLibros.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.axAcroPDF1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(425, 279);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "El Rey Leon";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.axAcroPDF2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(425, 279);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "El Zorro Y el Tigre";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.axAcroPDF3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(425, 279);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "La Sirenita";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnAgregar);
            this.tabPage4.Controls.Add(this.axAcroPDF4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(425, 279);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Libro Agregado";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(363, 255);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(59, 21);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // picLibros
            // 
            this.picLibros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picLibros.Image = ((System.Drawing.Image)(resources.GetObject("picLibros.Image")));
            this.picLibros.Location = new System.Drawing.Point(0, 0);
            this.picLibros.Name = "picLibros";
            this.picLibros.Size = new System.Drawing.Size(434, 361);
            this.picLibros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLibros.TabIndex = 9;
            this.picLibros.TabStop = false;
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(-4, 3);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(429, 280);
            this.axAcroPDF1.TabIndex = 0;
            // 
            // axAcroPDF2
            // 
            this.axAcroPDF2.Enabled = true;
            this.axAcroPDF2.Location = new System.Drawing.Point(-4, 0);
            this.axAcroPDF2.Name = "axAcroPDF2";
            this.axAcroPDF2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF2.OcxState")));
            this.axAcroPDF2.Size = new System.Drawing.Size(429, 283);
            this.axAcroPDF2.TabIndex = 0;
            // 
            // axAcroPDF3
            // 
            this.axAcroPDF3.Enabled = true;
            this.axAcroPDF3.Location = new System.Drawing.Point(0, 0);
            this.axAcroPDF3.Name = "axAcroPDF3";
            this.axAcroPDF3.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF3.OcxState")));
            this.axAcroPDF3.Size = new System.Drawing.Size(425, 283);
            this.axAcroPDF3.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // axAcroPDF4
            // 
            this.axAcroPDF4.Enabled = true;
            this.axAcroPDF4.Location = new System.Drawing.Point(0, 0);
            this.axAcroPDF4.Name = "axAcroPDF4";
            this.axAcroPDF4.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF4.OcxState")));
            this.axAcroPDF4.Size = new System.Drawing.Size(425, 276);
            this.axAcroPDF4.TabIndex = 1;
            // 
            // fLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 361);
            this.Controls.Add(this.tabLibros);
            this.Controls.Add(this.picRegresar);
            this.Controls.Add(this.picLibros);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fLibros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Libros";
            this.Load += new System.EventHandler(this.fLibros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picRegresar)).EndInit();
            this.tabLibros.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLibros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picRegresar;
        private System.Windows.Forms.TabControl tabLibros;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.PictureBox picLibros;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF2;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF4;
    }
}