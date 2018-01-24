namespace imagenes
{
    partial class frmPrincipal
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
            this.imgOriginal = new System.Windows.Forms.PictureBox();
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.btnGray = new System.Windows.Forms.Button();
            this.btnSobel = new System.Windows.Forms.Button();
            this.btnCanny = new System.Windows.Forms.Button();
            this.btnRojo = new System.Windows.Forms.Button();
            this.btnVerde = new System.Windows.Forms.Button();
            this.btnAzul = new System.Windows.Forms.Button();
            this.btnBuscaRectangulos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgOriginal)).BeginInit();
            this.SuspendLayout();
            // 
            // imgOriginal
            // 
            this.imgOriginal.Location = new System.Drawing.Point(12, 12);
            this.imgOriginal.Name = "imgOriginal";
            this.imgOriginal.Size = new System.Drawing.Size(906, 463);
            this.imgOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgOriginal.TabIndex = 0;
            this.imgOriginal.TabStop = false;
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadImage.Location = new System.Drawing.Point(924, 12);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(80, 37);
            this.btnLoadImage.TabIndex = 1;
            this.btnLoadImage.Text = "...";
            this.btnLoadImage.UseVisualStyleBackColor = true;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // btnGray
            // 
            this.btnGray.Location = new System.Drawing.Point(924, 81);
            this.btnGray.Name = "btnGray";
            this.btnGray.Size = new System.Drawing.Size(80, 24);
            this.btnGray.TabIndex = 2;
            this.btnGray.Text = "Gris";
            this.btnGray.UseVisualStyleBackColor = true;
            this.btnGray.Click += new System.EventHandler(this.btnGray_Click);
            // 
            // btnSobel
            // 
            this.btnSobel.Location = new System.Drawing.Point(924, 111);
            this.btnSobel.Name = "btnSobel";
            this.btnSobel.Size = new System.Drawing.Size(80, 23);
            this.btnSobel.TabIndex = 3;
            this.btnSobel.Text = "bordes sobel";
            this.btnSobel.UseVisualStyleBackColor = true;
            this.btnSobel.Click += new System.EventHandler(this.btnSobel_Click);
            // 
            // btnCanny
            // 
            this.btnCanny.Location = new System.Drawing.Point(924, 140);
            this.btnCanny.Name = "btnCanny";
            this.btnCanny.Size = new System.Drawing.Size(80, 23);
            this.btnCanny.TabIndex = 4;
            this.btnCanny.Text = "bordes canny";
            this.btnCanny.UseVisualStyleBackColor = true;
            this.btnCanny.Click += new System.EventHandler(this.btnCanny_Click);
            // 
            // btnRojo
            // 
            this.btnRojo.Location = new System.Drawing.Point(924, 183);
            this.btnRojo.Name = "btnRojo";
            this.btnRojo.Size = new System.Drawing.Size(75, 23);
            this.btnRojo.TabIndex = 5;
            this.btnRojo.Text = "Rojo";
            this.btnRojo.UseVisualStyleBackColor = true;
            this.btnRojo.Click += new System.EventHandler(this.btnRojo_Click);
            // 
            // btnVerde
            // 
            this.btnVerde.Location = new System.Drawing.Point(924, 212);
            this.btnVerde.Name = "btnVerde";
            this.btnVerde.Size = new System.Drawing.Size(75, 23);
            this.btnVerde.TabIndex = 6;
            this.btnVerde.Text = "Verde";
            this.btnVerde.UseVisualStyleBackColor = true;
            this.btnVerde.Click += new System.EventHandler(this.btnVerde_Click);
            // 
            // btnAzul
            // 
            this.btnAzul.Location = new System.Drawing.Point(924, 241);
            this.btnAzul.Name = "btnAzul";
            this.btnAzul.Size = new System.Drawing.Size(75, 23);
            this.btnAzul.TabIndex = 7;
            this.btnAzul.Text = "Azul";
            this.btnAzul.UseVisualStyleBackColor = true;
            this.btnAzul.Click += new System.EventHandler(this.btnAzul_Click);
            // 
            // btnBuscaRectangulos
            // 
            this.btnBuscaRectangulos.Location = new System.Drawing.Point(924, 294);
            this.btnBuscaRectangulos.Name = "btnBuscaRectangulos";
            this.btnBuscaRectangulos.Size = new System.Drawing.Size(75, 23);
            this.btnBuscaRectangulos.TabIndex = 8;
            this.btnBuscaRectangulos.Text = "rectangulo";
            this.btnBuscaRectangulos.UseVisualStyleBackColor = true;
            this.btnBuscaRectangulos.Click += new System.EventHandler(this.btnBuscaRectangulos_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 648);
            this.Controls.Add(this.btnBuscaRectangulos);
            this.Controls.Add(this.btnAzul);
            this.Controls.Add(this.btnVerde);
            this.Controls.Add(this.btnRojo);
            this.Controls.Add(this.btnCanny);
            this.Controls.Add(this.btnSobel);
            this.Controls.Add(this.btnGray);
            this.Controls.Add(this.btnLoadImage);
            this.Controls.Add(this.imgOriginal);
            this.Name = "frmPrincipal";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imgOriginal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgOriginal;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.Button btnGray;
        private System.Windows.Forms.Button btnSobel;
        private System.Windows.Forms.Button btnCanny;
        private System.Windows.Forms.Button btnRojo;
        private System.Windows.Forms.Button btnVerde;
        private System.Windows.Forms.Button btnAzul;
        private System.Windows.Forms.Button btnBuscaRectangulos;
    }
}

