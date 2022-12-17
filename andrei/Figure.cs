using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static System.Math;



namespace andrei
{
    public class Figure
    {
        private Points[,] _basement;
        private Points[,] _buffer;
        private readonly Rendering _rend = new Rendering();

      
        private readonly Points _viewpoint = new Points(0, 0, 10000);
        readonly List<Polygon> _polygons = new List<Polygon>();

        Points _lightpoint = new Points(1000, 0, 0);
        private double _ia = 127;
        private const double Ka = 1;
        private double _il = 127;
        private double _kd = 1;
       


        public double BigRad { get; set; }
        public double SmallRad { get; set; }
        public double Height { get; set; }
        public int Aprox { get; set; }

        public Figure(double bigradius, double smallradius, double height, int aproximation)
        {
            BigRad = bigradius;
            SmallRad = smallradius;
            Height = height;
            Aprox = aproximation;
        }

        public void Init()
        {
            _basement = new Points[Aprox, 3];
            _buffer = new Points[Aprox, 3];

            _basement[0, 2] = new Points(0, Height, 0);
            for (var i = 0; i < Aprox; i++)
            {
                _basement[i, 0] = Expansion(BigRad, i * 360 / Aprox);
                _basement[i, 1] = Expansion(SmallRad, i * 360 / Aprox);
            }
        }
        private static Points Expansion(double r, double deg)
        {
            var point = new Points
            {
                X = r * Cos(deg * PI / 180),
                Y = 0,
                Z = r * Sin(deg * PI / 180)
            };

            return point;
        }

        //преобразования
        public void Rotate(double alpha, double beta, double gama)
        {
            _basement[0, 2] = _basement[0, 2].Rotate(alpha, beta, gama);
            for (var i = 0; i < _basement.GetLength(0); i++)
            {
                _basement[i, 0] = _basement[i, 0].Rotate(alpha, beta, gama);
                _basement[i, 1] = _basement[i, 1].Rotate(alpha, beta, gama);
            }
        }
        public void Scale(double sx, double sy, double sz)
        {
            _basement[0, 2] = _basement[0, 2].Scale(sx, sy, sz);
            for (var i = 0; i < _basement.GetLength(0); i++)
            {
                _basement[i, 0] = _basement[i, 0].Scale(sx, sy, sz);
                _basement[i, 1] = _basement[i, 1].Scale(sx, sy, sz);
            }
        }
        public void Move(double dx, double dy, double dz)
        {
            _basement[0, 2] = GTools.Move(_basement[0, 2], dx, dy, dz);
            for (var i = 0; i < _basement.GetLength(0); i++)
            {
                _basement[i, 0] = GTools.Move(_basement[i, 0], dx, dy, dz);
                _basement[i, 1] = GTools.Move(_basement[i, 1], dx, dy, dz);
            }
        }

        //отрисовка
        public void RenderFigure(PictureBox picture)
        {
            Projection();
            switch (Data.FDraw)
            {
                case 1:
                    Render(picture);
                    break;
                case 2:
                    RenderPoints(picture);
                    break;
                case 3:
                    RenderPoligon(picture);
                    break;
            };
        }
        public void Render(PictureBox picture)
        {
            _rend.Gener(picture);

            _rend.Render(_buffer[_buffer.GetLength(0) - 1, 1], _buffer[0, 1],Color.Black);
            _rend.Render(_buffer[_buffer.GetLength(0) - 1, 0], _buffer[0, 0], Color.Black);

            _rend.Render(_buffer[_buffer.GetLength(0) - 1, 0], _buffer[0, 2], Color.Black);
            _rend.Render(_buffer[_buffer.GetLength(0) - 1, 1], _buffer[0, 2], Color.Black);

            _rend.Render(_buffer[_buffer.GetLength(0) - 1, 1], _buffer[_buffer.GetLength(0) - 1, 0], Color.Black);
            for (var i = 0; i < _buffer.GetLength(0)-1; i++)
            {
                _rend.Render(_buffer[i, 0], _buffer[i + 1, 0], Color.Black);
                _rend.Render(_buffer[i, 0], _buffer[0, 2], Color.Black);

                _rend.Render(_buffer[i, 1], _buffer[i + 1, 1], Color.Black);
                _rend.Render(_buffer[i, 1], _buffer[0, 2], Color.Black);

                _rend.Render(_buffer[i, 1], _buffer[i, 0], Color.Black);
            }
        }
        public void RenderPoints(PictureBox picture)
        {
            _rend.Gener(picture);
            _rend.RenderPoints(_buffer[0, 2], Color.MidnightBlue);
            for (var i = 1; i < _buffer.GetLength(0); i++)
            {
                _rend.RenderPoints(_buffer[i, 0], Color.MidnightBlue);
                _rend.RenderPoints(_buffer[i, 1], Color.MidnightBlue);
            }
        }
        public void RenderPoligon(PictureBox picture)
        {
            _rend.Gener(picture);
            for (var i = 0; i < _polygons.Count; i++)
                _rend.Polygon(_polygons[i].poly[0], _polygons[i].poly[1], _polygons[i].poly[2], _polygons[i].color);
        }

        public Points PolarToDecart(double ro,double teta, double fi)
        {
            return new Points(ro*Sin(teta)*Cos(fi),ro*Sin(teta)*Sin(fi),ro*Cos(teta));
        }

        public void Projection()
        {
            _kd = Data.kd;
            _il = Data.Il;
            _ia = Data.Ia;
            _lightpoint = new Points(Data.X, Data.Y, Data.Z);
            switch (Data.FProj)
            {
                case 1:
                    Array.Copy(_basement, _buffer, _basement.Length);
                    CreatePolygon();
                    Painting();
                    RobertsAlgorithm();
                    break;
                case 2:
                    Horizontal();
                    break;
                case 3:
                    Profile();
                    break;
                case 4:
                    Axonometric(Data.Psi, Data.Fi);
                    break;
                case 5:
                    Oblique(Data.L, Data.A);
                    break;
                case 6:
                    Array.Copy(_basement, _buffer, _basement.Length);
                    Perspective(Data.D, Data.Teta, Data.F, Data.Ro);
                    break;
            };
        }
        public void Horizontal()
        {
            _buffer[0, 2] = _basement[0, 2].HorizontalProjection();
            for (var i = 0; i < _basement.GetLength(0); i++)
            {
                _buffer[i, 0] = _basement[i, 0].HorizontalProjection();
                _buffer[i, 1] = _basement[i, 1].HorizontalProjection();
            }
            _lightpoint = _lightpoint.HorizontalProjection();
            CreatePolygon();
            Painting();
            RobertsAlgorithm();

        }
        public void Profile()
        {
            _buffer[0, 2] = _basement[0, 2].ProfileProjection();
            for (var i = 0; i < _basement.GetLength(0); i++)
            {
                _buffer[i, 0] = _basement[i, 0].ProfileProjection();
                _buffer[i, 1] = _basement[i, 1].ProfileProjection();
            }

            _lightpoint = _lightpoint.ProfileProjection();
            CreatePolygon();
            Painting();
            RobertsAlgorithm();
        }
        public void Axonometric(double psi, double fi)
        {
            _buffer[0, 2] = _basement[0, 2].AxonometricProjection(psi, fi);
            for (var i = 0; i < _basement.GetLength(0); i++)
            {
                _buffer[i, 0] = _basement[i, 0].AxonometricProjection(psi, fi);
                _buffer[i, 1] = _basement[i, 1].AxonometricProjection(psi, fi);
            }
            CreatePolygon();
            Painting();
            RobertsAlgorithm();
        }
        public void Oblique(double l, double alpha)
        {
            _buffer[0, 2] = _basement[0, 2].ObliqueProjection(l, alpha);
            for (var i = 0; i < _basement.GetLength(0); i++)
            {
                _buffer[i, 0] = _basement[i, 0].ObliqueProjection(l, alpha);
                _buffer[i, 1] = _basement[i, 1].ObliqueProjection(l, alpha);
            }
            CreatePolygon();
            Painting();
            RobertsAlgorithm();
        }
    
        public void Perspective(double d,double teta, double fi, double ro)
        {
            CreatePolygon();
            Painting();
            for (var i = 0; i < _polygons.Count; i++)
            {
                _polygons[i].poly[0] = _polygons[i].poly[0].SpeciesTransformation(teta, fi, ro);
                _polygons[i].poly[1] = _polygons[i].poly[1].SpeciesTransformation(teta, fi, ro);
                _polygons[i].poly[2] = _polygons[i].poly[2].SpeciesTransformation(teta, fi, ro);
            }
            for (var i = 0; i < _polygons.Count; i++)
            {
                _polygons[i].poly[0] = _polygons[i].poly[0].PerspectiveProjection(d);
                _polygons[i].poly[1] = _polygons[i].poly[1].PerspectiveProjection(d);
                _polygons[i].poly[2] = _polygons[i].poly[2].PerspectiveProjection(d);
            }
            RobertsAlgorithm();

            Species(teta, fi, ro);
            _buffer[0, 2] = _buffer[0, 2].PerspectiveProjection(d);
            for (var i = 0; i < _basement.GetLength(0); i++)
            {
                _buffer[i, 0] = _buffer[i, 0].PerspectiveProjection(d);
                _buffer[i, 1] = _buffer[i, 1].PerspectiveProjection(d);
            }
        }

        public void Species(double teta, double fi, double ro)
        {
            //viewpoint = PolarToDecart(Data.Ro, Data.Teta, Data.F);
            //lightpoint = -lightpoint;
           
            _buffer[0, 2] = _basement[0, 2].SpeciesTransformation(teta, fi, ro);
            for (var i = 0; i < _basement.GetLength(0); i++)
            {
                _buffer[i, 0] = _basement[i, 0].SpeciesTransformation(teta, fi, ro);
                _buffer[i, 1] = _basement[i, 1].SpeciesTransformation(teta, fi, ro);
            }

        }

        private static Color Light(Color color, float factor)
        {
            var r = (byte)((color.R * factor));
            var g = (byte)((color.G * factor));
            var b = (byte)((color.B * factor));
            return Color.FromArgb(255, r, g, b);
        }

        public void Painting()
        {
            for (var i = 0; i < _polygons.Count; i++)
            {
                var cosLight = Cos(GTools.Angle(_polygons[i].poly[0], _polygons[i].poly[1], _polygons[i].poly[2],  _lightpoint));
                var intensity = ((float)(_ia * Ka + (_il * _kd * cosLight) / 255));
                _polygons[i].color = Light(Color.White, intensity);
            }
        }
        public void RobertsAlgorithm()
        {
            double cosView;
            for (var i = _polygons.Count-1; i >=0 ; i--)
            {
                cosView = GTools.Angle(_polygons[i].poly[0], _polygons[i].poly[1], _polygons[i].poly[2], _viewpoint);
                if (RadtoDeg(cosView) > 90 || RadtoDeg(cosView) < 0) _polygons.RemoveAt(i); 
            }
        }
        public void CreatePolygon()
        {
            _polygons.Clear();
            //внутрений
            for (var i = 1; i < _basement.GetLength(0); i++)
            {
                _polygons.Add(new Polygon(_buffer[i, 1], _buffer[0, 2], _buffer[i - 1, 1]));
            }
            _polygons.Add(new Polygon(_buffer[0, 1], _buffer[0, 2], _buffer[_buffer.GetLength(0) - 1, 1]));
            //основание
            for (var i = 1; i < _basement.GetLength(0); i++)
            {
                _polygons.Add(new Polygon(_buffer[i - 1, 1], _buffer[i - 1, 0], _buffer[i, 0]));
                _polygons.Add(new Polygon(_buffer[i - 1, 1], _buffer[i, 0], _buffer[i, 1]));
            }
            _polygons.Add(new Polygon(_buffer[_buffer.GetLength(0) - 1, 1], _buffer[_buffer.GetLength(0) - 1, 0], _buffer[0, 0]));
            _polygons.Add(new Polygon(_buffer[_buffer.GetLength(0) - 1, 1], _buffer[0, 0], _buffer[0, 1]));
            //внешний
            for (var i = 1; i < _basement.GetLength(0); i++)
            {
                _polygons.Add(new Polygon(_buffer[i - 1, 0], _buffer[0, 2], _buffer[i, 0]));
            }
            _polygons.Add(new Polygon(_buffer[_buffer.GetLength(0) - 1, 0], _buffer[0, 2], _buffer[0, 0]));
           
        }
        public static double RadtoDeg(double grad)
        {
            return grad * 180 / PI;
        }
    }
}


