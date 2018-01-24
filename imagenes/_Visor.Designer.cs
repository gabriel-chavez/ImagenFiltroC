namespace imagenes
{
    partial class _Visor
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
            this.imgVisor = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgVisor)).BeginInit();
            this.SuspendLayout();
            // 
            // imgVisor
            // 
            this.imgVisor.Location = new System.Drawing.Point(12, 12);
            this.imgVisor.Name = "imgVisor";
            this.imgVisor.Size = new System.Drawing.Size(511, 474);
            this.imgVisor.TabIndex = 0;
            this.imgVisor.TabStop = false;
            // 
            // _Visor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 498);
            this.Controls.Add(this.imgVisor);
            this.Name = "_Visor";
            this.Text = "_Visor";
            ((System.ComponentModel.ISupportInitialize)(this.imgVisor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgVisor;
    }
}