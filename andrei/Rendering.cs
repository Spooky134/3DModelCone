using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;



namespace andrei
{
    public class Rendering
    {
        private static Bitmap bmp;
        private static Graphics _graph;

        //отрисовка линиями
        public void Render(Points point1,Points point2,Color color)
        {
            _graph.DrawLine(new Pen(color,2), (float)point1.X, (float)point1.Y, (float)point2.X, (float)point2.Y);
        }

        public void RenderPolygon(Points point1, Points point2, Points point3,Color color)
        {
            var points1 = new Point((int)point1.X, (int)point1.Y);
            var points2 = new Point((int)point2.X, (int)point2.Y);
            var points3 = new Point((int)point3.X, (int)point3.Y);
            Point[] curvePoints = { points1, points2, points3 };
            _graph.DrawPolygon(new Pen(color),curvePoints);
        }
        //отрисовка точками
        public void RenderPoints(Points point1,Color color)
        {
            _graph.DrawEllipse(new Pen(color), (float)point1.X, (float)point1.Y, 2, 2);
        }
        //полигоны
        public void Polygon(Points point1,Points point2,Points point3,Color color)
        {
            var points1 = new Point((int) point1.X, (int) point1.Y);
            var points2 = new Point((int) point2.X, (int) point2.Y);
            var points3 = new Point((int) point3.X, (int) point3.Y);
            Point[] curvePoints = {points1, points2, points3};
            _graph.FillPolygon(new SolidBrush(color), curvePoints);
        }
        public void Polygon(Points point1, Points point2, Points point3,Points point4,Color color)
        {
            var points1 = new Point((int)point1.X, (int)point1.Y);
            var points2 = new Point((int)point2.X, (int)point2.Y);
            var points3 = new Point((int)point3.X, (int)point3.Y);
            var points4 = new Point((int)point4.X, (int)point4.Y);
            Point[] curvePoints = { points1, points2, points3 ,points4};
               
            _graph.FillPolygon(new SolidBrush(color), curvePoints);
        }

        //грапх
        public void Gener(PictureBox pictureBox)
        {
            bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            _graph = Graphics.FromImage(bmp);
            _graph.SmoothingMode = SmoothingMode.AntiAlias;
            _graph.Clear(Color.White);
            //расположение фигуры по центру bmp
            _graph.TranslateTransform(pictureBox.Width / 2, pictureBox.Height / 2);
            _graph.ScaleTransform(1, -1);
            pictureBox.Image = bmp;

            //_graph = pictureBox.CreateGraphics();
            //_graph.SmoothingMode = SmoothingMode.AntiAlias;
            //_graph.Clear(Color.White);

            //_graph.TranslateTransform(pictureBox.Width / 2, pictureBox.Height / 2);
            //_graph.ScaleTransform(1, -1);
        }
    }
}
    

