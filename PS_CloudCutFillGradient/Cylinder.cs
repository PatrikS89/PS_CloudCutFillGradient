using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS_CloudCutFillGradient
{
    class Cylinder
    {
        public Point position;
        public double height;
        public double radius;

        public Cylinder()
        {

        }

        public Cylinder(Point position, double height, double radius)
        {
            this.position = position;
            this.height = height;
            this.radius = radius;
        }
    }
}
