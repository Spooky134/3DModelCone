using System;
using System.Windows.Forms;

namespace andrei
{
    public partial class Form1 : Form
    {
        private bool _flag;
        private Figure _conus;

        public Form1() { InitializeComponent(); }
        private void Form1_Load(object sender, EventArgs e) { }
        private void Button_Click(object sender, EventArgs e)
        {
            DataUpdate();
            var button = (ButtonBase)sender;
            switch (button.Text)
            {
                case "Draw":
                    _conus = new Figure(Data.RadiusB, Data.RadiusS, Data.Height, Data.Aproximation);
                    _conus.Init();
                    _conus.RenderFigure(picture);
                    break;
                case "Redraw":
                    _conus.RenderFigure(picture);
                    break;
                case "Rotate":
                    _conus.Rotate(Data.Alpha,Data.Beta,Data.Gama);
                    _conus.RenderFigure(picture);
                    break;
                case "Move":
                    _conus.Move(Data.Dx,Data.Dy,Data.Dz);
                    _conus.RenderFigure(picture);
                    break;
                case "Scale":
                    _conus.Scale(Data.Sx,Data.Sy,Data.Sz);
                    _conus.RenderFigure(picture);
                    break;
                case "Auto":
                    if (_flag)
                    {
                        timer.Stop();
                        _flag = false;
                    }
                    else
                    {
                        timer.Start();
                        _flag = true;
                    }
                    break;
                case "Lines":
                    Data.FDraw = 1;
                    break;
                case "Points":
                    Data.FDraw = 2;
                    break;
                case "Polygon":
                    Data.FDraw = 3;
                    break;
                case "Frontal":
                    Data.FProj = 1;
                    break;
                case "Horizontal":
                    Data.FProj = 2;
                    break;
                case "Profile":
                    Data.FProj = 3;
                    break;
                case "Axonometric":
                    Data.FProj = 4;
                    break;
                case "Oblique":
                    Data.FProj = 5;
                    break;
                case "Perspective":
                    Data.FProj = 6;
                    break;
                case "Invisible lines":
                    break;
            };
        }
        
        private void timer_Tick(object sender, EventArgs e)
        {
            _conus.Rotate(1,1,1);
            _conus.RenderFigure(picture);
        }
        private void DataUpdate()
        {
            Data.RadiusB = double.Parse(Radius1.Text);
            Data.RadiusS = double.Parse(Radius2.Text);
            Data.Height = double.Parse(Height.Text);
            Data.Aproximation = int.Parse(Approximation.Text);
            Data.Alpha = double.Parse(alpha.Text);
            Data.Beta = double.Parse(beta.Text);
            Data.Gama = double.Parse(gama.Text);
            Data.Dx = double.Parse(Dx.Text);
            Data.Dy = double.Parse(Dy.Text);
            Data.Dz = double.Parse(Dz.Text);
            Data.Sx = double.Parse(Sx.Text);
            Data.Sy = double.Parse(Sy.Text);
            Data.Sz = double.Parse(Sz.Text);
            Data.Psi=double.Parse(Psi.Text);
            Data.Fi=double.Parse(Fi.Text);
            Data.L= double.Parse(l.Text);
            Data.A= double.Parse(a.Text); 
            Data.D= double.Parse(d.Text);
            Data.Teta= double.Parse(tetaT.Text);
            Data.F= double.Parse(fiT.Text);
            Data.Ro=double.Parse(roT.Text);
            Data.X = double.Parse(X.Text);
            Data.Y = double.Parse(Y.Text);
            Data.Z = double.Parse(Z.Text);
            Data.kd = double.Parse(kd.Text);
            Data.Il = double.Parse(Il.Text);
            Data.Ia = double.Parse(Ia.Text);
        }
    }
}
