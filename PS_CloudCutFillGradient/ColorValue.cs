using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS_CloudCutFillGradient
{
    struct ColorValue
    {
        public double red;
        public double green;
        public double blue;

        public ColorValue(double red, double green, double blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
        }

        public override string ToString()
        {
            return $"[{red},{green},{blue}]";
        }
    }
}
