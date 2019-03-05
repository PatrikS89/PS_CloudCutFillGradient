using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PS_CloudCutFillGradient
{
    class Helper
    {
        /// <summary>
        /// Calculates the distance between a point to a circles edge.
        /// </summary>
        /// <returns>Returns a negative distance if outside, a positive if inside.</returns>
        public static double DistancePointToCircleEdge(Point p, Cylinder c)
        {
            Point direction = new Point(p.x - c.position.x, p.y - c.position.y, p.z - c.position.z);
            double distToCenter = direction.LengthSquared2D();
            double distToEdge = c.radius - distToCenter;
            return distToEdge;
        }

        public static double ParseString(string value)
        {
            string s = value.Replace(",", ".").Replace("+", "");
            Match m = Regex.Match(s, @"^[+-]?(\d*\.)?\d+$");
            if (m.Success)
            {
                double val = double.Parse(m.Value, NumberStyles.Number, CultureInfo.InvariantCulture);
                return val;
            }
            else
            {
                Error(new Exception($"Värdet \"{value}\" är inte giltigt."));
                return -1;
            }
        }

        public static Point ColorizePoint(Point point, double amount, bool isInside, bool isOutsideMaxDistance, Settings settings, double distanceToEdge)
        {
            if (settings.colorType == ColorType.Intensity)  // Use Intensity
            {
                if (isOutsideMaxDistance) // If outside Max Distance, set Intensity to MaxValue
                {
                    return new Point(point.x, point.y, point.z, settings.intensityMax,
                        new ColorValue(point.color.red, point.color.green, point.color.blue), point.classification);
                }

                double intensityNew = point.intensity;
                if (settings.colorMode == ColorMode.Both) // Set Intensity of Both Sides
                {
                    intensityNew = LerpValue(settings.intensityMax, settings.intensityMin, amount);
                }
                else if (settings.colorMode == ColorMode.Inside) // Set Intensity of Inside
                {
                    if (isInside)
                        intensityNew = LerpValue(settings.intensityMax, settings.intensityMin, amount);
                }
                else if (settings.colorMode == ColorMode.Outside) // Set Intensity of Outside
                {
                    if (!isInside)
                        intensityNew = LerpValue(settings.intensityMax, settings.intensityMin, amount);
                }
                return new Point(point.x, point.y, point.z, intensityNew,
                    new ColorValue(point.color.red, point.color.green, point.color.blue), point.classification, distanceToEdge);
            }
            else // Use Colors
            {
                if (isOutsideMaxDistance) // If outside Max Distance, set Color to OutsideRange
                {
                    return new Point(point.x, point.y, point.z, point.intensity,
                        new ColorValue(settings.outsideColor.R, settings.outsideColor.G, settings.outsideColor.B), point.classification, distanceToEdge);
                }

                ColorValue colorNew = point.color;
                if (settings.colorMode == ColorMode.Both)  // Set Color of Both Sides
                {
                    colorNew = Helper.LerpColor(amount, settings);
                }
                else if (settings.colorMode == ColorMode.Inside) // Set Color of Outside
                {
                    if (isInside)
                        colorNew = Helper.LerpColor(amount, settings);
                }
                else if (settings.colorMode == ColorMode.Outside) // Set Color of Inside
                {
                    if (!isInside)
                        colorNew = Helper.LerpColor(amount, settings);
                }
                return new Point(point.x, point.y, point.z, point.intensity, colorNew, point.classification, distanceToEdge);
            }
        }

        /// <summary>
        /// Lerps between two Values, where From=1 and To=0.
        /// </summary>
        public static double LerpValue(double valueMin, double valueMax, double amount)
        {
            return (amount * valueMin) + ((1 - amount) * valueMax);
        }

        /// <summary>
        /// Lerps between two ColorValues, where From=1 and To=0.
        /// </summary>
        public static ColorValue LerpColor(double amount, Settings settings)
        {
            ColorValue cvMin = ColorToColorValue(settings.minColor);
            ColorValue cvMid = ColorToColorValue(settings.midColor);
            ColorValue cvMax = ColorToColorValue(settings.maxColor);

            // N-Way Interpolation
            Color color = InterpolateColor(new Color[] { settings.minColor, settings.midColor, settings.maxColor }, amount);
            return new ColorValue(color.R, color.G, color.B);

            // 2-Way Interpolation
            //double red = (amount * cvFrom.red) + ((1 - amount) * cvTo.red);
            //double green = (amount * cvFrom.green) + ((1 - amount) * cvTo.green);
            //double blue = (amount * cvFrom.blue) + ((1 - amount) * cvTo.blue);
            //return new ColorValue(red, green, blue);
        }

        public static ColorValue ColorToColorValue(Color color)
        {
            return new ColorValue(color.R, color.G, color.B);
        }

        public static char GetSeparator(Separator separator)
        {
            if (separator == Separator.Comma)
                return ',';
            else if (separator == Separator.Dot)
                return '.';
            else
                return ' ';
        }

        public static string GetSerializedColor(Point point, Settings settings)
        {
            if (settings.importRGBTypeInt != settings.exportRGBTypeInt) // Import and Export RGB Mismatch
            {
                if (settings.exportRGBTypeInt == true) // Export Type is "int" but Import Type was "float"
                {
                    return $"{point.color.red * 255} {point.color.green * 255} {point.color.blue * 255}";
                }
                else // Export Type is "float" but Import Type was "int"
                {
                    return $"{point.color.red / 255} {point.color.green / 255} {point.color.blue / 255}";
                }
            }
            else // Import and Export Types were the same, just pass the data through
            {
                return $"{point.color.red} {point.color.green} {point.color.blue}";
            }
        }

        public static FileTypeMode GetFileTypeMode(ComboBox comboBox, bool isImport)
        {
            if (isImport)
            {
                if (comboBox.SelectedIndex == 0)
                    return FileTypeMode.XYZ;
                else if (comboBox.SelectedIndex == 1)
                    return FileTypeMode.XYZI;
                else if (comboBox.SelectedIndex == 2)
                    return FileTypeMode.XYZRGB;
                else if (comboBox.SelectedIndex == 3)
                    return FileTypeMode.XYZRGBI;
                else if (comboBox.SelectedIndex == 4)
                    return FileTypeMode.XYZIC;
                else if (comboBox.SelectedIndex == 5)
                    return FileTypeMode.XYZRGBC;
                else if (comboBox.SelectedIndex == 6)
                    return FileTypeMode.XYZRGBIC;
                else
                    return FileTypeMode.CloudCompareXYZIC;
            }
            else
            {
                if (comboBox.SelectedIndex == 0)
                    return FileTypeMode.XYZI;
                else if (comboBox.SelectedIndex == 1)
                    return FileTypeMode.XYZRGB;
                else if (comboBox.SelectedIndex == 2)
                    return FileTypeMode.XYZRGBI;
                else if (comboBox.SelectedIndex == 3)
                    return FileTypeMode.XYZIC;
                else if (comboBox.SelectedIndex == 4)
                    return FileTypeMode.XYZRGBC;
                else if (comboBox.SelectedIndex == 5)
                    return FileTypeMode.XYZRGBIC;
                else
                    return FileTypeMode.CloudCompareXYZIC;
            }
        }

        public static void Error(Exception ex)
        {
            MessageBox.Show("Ett fel har uppstått: \n\n" + ex.ToString(), "Felmeddelande", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static Color InterpolateColor(Color[] colors, double amount)
        {
            double r = 0.0, g = 0.0, b = 0.0;
            double total = 0.0;
            double step = 1.0 / (double)(colors.Length - 1);
            double mu = 0.0;
            double sigma_2 = 0.035;

            foreach (Color color in colors)
            {
                total += Math.Exp(-(amount - mu) * (amount - mu) / (2.0 * sigma_2)) / Math.Sqrt(2.0 * Math.PI * sigma_2);
                mu += step;
            }

            mu = 0.0;
            foreach (Color color in colors)
            {
                double percent = Math.Exp(-(amount - mu) * (amount - mu) / (2.0 * sigma_2)) / Math.Sqrt(2.0 * Math.PI * sigma_2);
                mu += step;

                r += color.R * percent / total;
                g += color.G * percent / total;
                b += color.B * percent / total;
            }

            return Color.FromArgb(255, (int)r, (int)g, (int)b);
        }
    }
}
