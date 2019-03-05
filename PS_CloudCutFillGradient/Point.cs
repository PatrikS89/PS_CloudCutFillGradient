using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS_CloudCutFillGradient
{
    struct Point
    {
        public double x;
        public double y;
        public double z;

        public double intensity;

        public ColorValue color;

        public double classification;

        // Tracking
        public double distanceToEdge;

        public Point(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;

            intensity = 0;
            color = new ColorValue(0, 0, 0);
            classification = 0;

            distanceToEdge = 0;
        }

        public Point(double x, double y, double z, double intensity)
        {
            this.x = x;
            this.y = y;
            this.z = z;

            this.intensity = intensity;
            color = new ColorValue(0, 0, 0);
            classification = 0;
            distanceToEdge = 0;
        }

        public Point(double x, double y, double z, double intensity, double classification)
        {
            this.x = x;
            this.y = y;
            this.z = z;

            this.intensity = intensity;
            color = new ColorValue(0, 0, 0);
            this.classification = classification;
            distanceToEdge = 0;
        }

        public Point(double x, double y, double z, double intensity, double red, double green, double blue, double classification)
        {
            this.x = x;
            this.y = y;
            this.z = z;

            this.intensity = intensity;
            this.color = new ColorValue(red, green, blue);
            this.classification = classification;
            distanceToEdge = 0;
        }

        public Point(double x, double y, double z, double intensity, ColorValue color, double classification)
        {
            this.x = x;
            this.y = y;
            this.z = z;

            this.intensity = intensity;
            this.color = new ColorValue(color.red, color.green, color.blue);
            this.classification = classification;
            distanceToEdge = 0;
        }

        public Point(double x, double y, double z, double intensity, ColorValue color, double classification, double distanceToEdge)
        {
            this.x = x;
            this.y = y;
            this.z = z;

            this.intensity = intensity;
            this.color = new ColorValue(color.red, color.green, color.blue);
            this.classification = classification;
            this.distanceToEdge = distanceToEdge;
        }

        public double LengthSquared3D()
        {
            return Math.Sqrt(x * x + y * y + z * z);
        }

        public double LengthSquared2D()
        {
            return Math.Sqrt(x * x + y * y);
        }
    }
}
