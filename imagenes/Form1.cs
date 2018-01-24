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
    public partial class frmPrincipal : Form
    {
        Bitmap original = null;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "Imagenes|*.jpg;*.gif;*.png;*.bmp";
            if (f.ShowDialog() == DialogResult.OK)
            {
                imgOriginal.Image = System.Drawing.Image.FromFile(f.FileName);
                original = (Bitmap)imgOriginal.Image;
            }
        }

        private void btnGray_Click(object sender, EventArgs e)
        {
            Bitmap img = AforgeAlgoritmos.EscalaGrises(original);
            _Visor imgModificada = new _Visor(img, "Imagen en escala de grises");
            imgModificada.Show();
        }

        private void btnSobel_Click(object sender, EventArgs e)
        {
            Bitmap img = AforgeAlgoritmos.sobel(original);
            _Visor imgModificada = new _Visor(img, "Bordes Sobel");
            imgModificada.Show();
        }

        private void btnCanny_Click(object sender, EventArgs e)
        {
            Bitmap img = AforgeAlgoritmos.canny(original);
            _Visor imgModificada = new _Visor(img, "Bordes Canny");
            imgModificada.Show();

        }

        private void btnRojo_Click(object sender, EventArgs e)
        {
            Bitmap img = AforgeAlgoritmos.getRojo(original);
            _Visor imgModificada = new _Visor(img, "Color verde");
            imgModificada.Show();
        }

        private void btnVerde_Click(object sender, EventArgs e)
        {
            Bitmap img = AforgeAlgoritmos.getVerde(original);
            _Visor imgModificada = new _Visor(img, "Color verde");
            imgModificada.Show();
        }

        private void btnAzul_Click(object sender, EventArgs e)
        {
            Bitmap img = AforgeAlgoritmos.getAzul(original);
            _Visor imgModificada = new _Visor(img, "Color verde");
            imgModificada.Show();
        }

        private void btnBuscaRectangulos_Click(object sender, EventArgs e)
        {
            Bitmap img = (Bitmap)imgOriginal.Image;
            //Del area recortada remarcamos las posibles placas detectadas
            Bitmap imgRegion = AforgeAlgoritmos.buscaRectangulos(img);
            _Visor imgModificada = new _Visor(imgRegion, "Rectangulos");
            imgModificada.Show();
        }
    }
}
