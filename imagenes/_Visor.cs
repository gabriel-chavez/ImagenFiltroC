using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imagenes
{
    public partial class _Visor : Form
    {
        public _Visor()
        {
            InitializeComponent();
        }
        public _Visor(Image img, string titulo)
        {
            InitializeComponent();
            imgVisor.Image = img;
            this.Text = titulo;
            this.Width = img.Width + 40;
            this.Height = img.Height + 100;
            imgVisor.SizeMode = PictureBoxSizeMode.AutoSize;
        }
    }

}
