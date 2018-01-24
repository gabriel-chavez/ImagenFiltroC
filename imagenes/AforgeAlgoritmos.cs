using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;

using AForge;
using AForge.Imaging.Filters;
using AForge.Imaging.ColorReduction;
using AForge.Imaging.Formats;
using AForge.Imaging;
using AForge.Math.Geometry;
using System;
using System.Collections.Generic;

namespace imagenes
{
    class AforgeAlgoritmos
    {
        public static Bitmap EscalaGrises(Bitmap image)
        {
            try
            {
                AForge.Imaging.Filters.Grayscale filter = new AForge.Imaging.Filters.Grayscale(0.30, 0.59, 0.11);
                System.Drawing.Bitmap newImage = filter.Apply(image);
                return newImage;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("No se puede apllicar el filtro" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public static Bitmap sobel(Bitmap image)
        {
            try
            {
                Bitmap gris = EscalaGrises(image);
                AForge.Imaging.Filters.SobelEdgeDetector filter = new AForge.Imaging.Filters.SobelEdgeDetector();
                System.Drawing.Bitmap newImage = filter.Apply(gris);
                return newImage;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public static Bitmap canny(Bitmap image)
        {
            try
            {
                Bitmap gris = EscalaGrises(image);
                AForge.Imaging.Filters.CannyEdgeDetector filter = new AForge.Imaging.Filters.CannyEdgeDetector();
                System.Drawing.Bitmap newImage = filter.Apply(gris);
                return newImage;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public static Bitmap getRojo(Bitmap image)
        {
            try
            {
                AForge.Imaging.Filters.ChannelFiltering filter = new ChannelFiltering(new IntRange(0, 255), new IntRange(0, 0), new IntRange(0, 0));
                System.Drawing.Bitmap newImage = filter.Apply(image);
                return newImage;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("No se puede apllicar el filtro" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public static Bitmap getVerde(Bitmap image)
        {
            try
            {
                AForge.Imaging.Filters.ChannelFiltering filter = new ChannelFiltering(new IntRange(0, 0), new IntRange(0, 255), new IntRange(0, 0));
                System.Drawing.Bitmap newImage = filter.Apply(image);
                return newImage;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("No se puede apllicar el filtro" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public static Bitmap getAzul(Bitmap image)
        {
            try
            {
                AForge.Imaging.Filters.ChannelFiltering filter = new ChannelFiltering(new IntRange(0, 0), new IntRange(0, 0), new IntRange(0, 255));
                System.Drawing.Bitmap newImage = filter.Apply(image);
                return newImage;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("No se puede apllicar el filtro" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public static Bitmap buscaRectangulos(Bitmap bitmap)
        {
            Blob[] blobs;
            Rectangle area = new Rectangle(0, 0, bitmap.Width, bitmap.Height);
            // lock image
            BitmapData bitmapData = bitmap.LockBits(area, ImageLockMode.ReadWrite, bitmap.PixelFormat);
            // Filtramos la imagen para determinar hasts cuando de ROJO, VERDE Y AZUL se permitiráanalizar
            ColorFiltering colorFilter = new ColorFiltering();
            colorFilter.Red = new IntRange(0, 104);
            colorFilter.Green = new IntRange(0, 104);
            colorFilter.Blue = new IntRange(0, 104);
            colorFilter.FillOutsideRange = false;colorFilter.ApplyInPlace(bitmapData);
            // Localizamos objetos en la imagen          
            BlobCounter blobCounter = new BlobCounter();
            blobCounter.FilterBlobs = true;
            blobCounter.MinHeight = 15;
            blobCounter.MinWidth = 15;
            blobCounter.ProcessImage(bitmapData);
            blobs = blobCounter.GetObjectsInformation();
            bitmap.UnlockBits(bitmapData);
            // step 3 -check objects' type and highlight
            SimpleShapeChecker shapeChecker = new SimpleShapeChecker();
            Graphics g = Graphics.FromImage(bitmap);
            Pen yellowPen = new Pen(Color.Yellow, 2);
            // Para cada figuura encontrada
            for (int i = 0, n = blobs.Length; i < n; i++)
            {
                List<IntPoint> edgePoints = blobCounter.GetBlobsEdgePoints(blobs[i]);
                List<IntPoint> corners;
                // Cuadrado
                if (shapeChecker.IsQuadrilateral(edgePoints, out corners))
                {//Obtenemos cuantas esquinas tiene el shape
                    PolygonSubType subType = shapeChecker.CheckPolygonSubType(corners);
                    //Pintamos las áreas detectadas
                    areaInteres(g, corners);
                }
            }
            //yellowPen.Dispose();
            g.Dispose();
            // put new image to clipboard
            Clipboard.SetDataObject(bitmap);
            // and to picture box
            return (bitmap);
        }
        //---Dibuja unas lineas alrededor de un candidato a rostro
        public static void areaInteres(Graphics g, List<IntPoint> corners)
        {
            Pen pen = new Pen(Color.Yellow, 2);
            Font fuente = new Font("Arial", 8.0f);
            Brush b = new SolidBrush(Color.LightYellow);
            g.DrawPolygon(pen, ToPointsArray(corners));
        }
        //Retorna un vector de Points
        private static System.Drawing.Point[] ToPointsArray(List<IntPoint> points)
        {
            System.Drawing.Point[] array = new System.Drawing.Point[points.Count];
            for (int i = 0, n = points.Count; i < n; i++)
            {
                array[i] = new System.Drawing.Point(points[i].X, points[i].Y);
            }
            return array;
        }
    }
}
