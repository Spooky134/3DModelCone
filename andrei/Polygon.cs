using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace andrei
{
    class Polygon
    {
        public Points[] poly = new Points[3];
        public Points centerPoints;
        public Color color = Color.Coral;
        public int sign;

        public Polygon(Points point1, Points point2, Points point3,int sign, Color color)
        {
            poly = new[] { point1, point2, point3};
            this.color = color;
            this.sign = sign;
            centerPoints = new Points((poly[0].X + poly[1].X + poly[2].X) / 3, (poly[0].Y + poly[1].Y + poly[2].Y) / 3, (poly[0].Z + poly[1].Z + poly[2].Z) / 3);
        }
        public Polygon(Points point1, Points point2, Points point3, Color color)
        {
            poly = new[] { point1, point2, point3 };
            this.color = color;
            centerPoints = new Points((poly[0].X + poly[1].X + poly[2].X) / 3, (poly[0].Y + poly[1].Y + poly[2].Y) / 3, (poly[0].Z + poly[1].Z + poly[2].Z) / 3);
        }
        public Polygon(Points point1, Points point2, Points point3)
        {
            poly = new[] { point1, point2, point3 };
            centerPoints = new Points((poly[0].X + poly[1].X + poly[2].X) / 3, (poly[0].Y + poly[1].Y + poly[2].Y) / 3, (poly[0].Z + poly[1].Z + poly[2].Z) / 3);
        }
        public Points CenterPoint()
        {
            return new Points((poly[0].X + poly[1].X + poly[2].X) / 3, (poly[0].Y + poly[1].Y + poly[2].Y) / 3, (poly[0].Z + poly[1].Z + poly[2].Z) / 3);
        }
    }
}
