using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS_CloudCutFillGradient
{
    class PointHandler
    {
        public List<Point> pointList = new List<Point>();
        private Settings settings;
        public double highestDistanceToEdge = 0;
        public double sumDistanceToEdge = 0;

        public PointHandler(Settings settings)
        {
            this.settings = settings;
        }

        public async Task CalculatePointsAsync()
        {
            await Task.Run(() => CalculatePoints());
        }

        public void CalculatePoints()
        {
            List<Point> pointListNew = new List<Point>();
            highestDistanceToEdge = 0;
            sumDistanceToEdge = 0;

            for (int i = 0; i < pointList.Count; i++)
            {
                // TODO: Implement LongestDistance Setting
                Point point = pointList[i];

                double distanceToEdge = Helper.DistancePointToCircleEdge(point, settings.cylinder);
                double amount = Math.Abs(distanceToEdge) / settings.maxDistance;
                bool isOutsideMaxDistance = Math.Abs(distanceToEdge) > settings.maxDistance;

                if (isOutsideMaxDistance) // Outside Max Distance
                {
                    if (settings.outsidePointsMode == OutsidePointsMode.Colorize) // Colorize Point
                    {
                        Point pointNew = Helper.ColorizePoint(point, amount, false, isOutsideMaxDistance, settings, distanceToEdge);
                        AddPointToList(pointNew, ref pointListNew);
                    }
                    else if (settings.outsidePointsMode == OutsidePointsMode.Ignore) // "Ignore" Point, add Original
                    {
                        AddPointToList(point, ref pointListNew);
                    }
                    else // Remove Point
                    {
                        continue;
                    }
                }
                else // Inside Max Distance
                {
                    bool isInside = (distanceToEdge >= 0f);
                    if (settings.colorMode == ColorMode.Inside & !isInside) // Skip if not Inside
                    {
                        continue;
                    }
                    else if (settings.colorMode == ColorMode.Outside & isInside) // Skip if not Outside
                    {
                        continue;
                    }
                    else // Colorize it
                    {
                        Point pointNew = Helper.ColorizePoint(point, amount, isInside, false, settings, distanceToEdge);
                        AddPointToList(pointNew, ref pointListNew);
                    }
                }
            }

            pointList = pointListNew;
        }

        private void AddPointToList(Point point, ref List<Point> pointList)
        {
            if (Math.Abs(point.distanceToEdge) > Math.Abs(highestDistanceToEdge))
                highestDistanceToEdge = point.distanceToEdge;
            sumDistanceToEdge += point.distanceToEdge;

            pointList.Add(point);
        }

        public void LoadPoints()
        {
            pointList.Clear();
            const int bufferSize = 128;
            int lineCounter = -1;
            char separator = Helper.GetSeparator(settings.importSeparator);

            try
            {
                FileStream fileStream = new FileStream(
                    settings.file.FullName, FileMode.Open, FileAccess.Read,
                    FileShare.Read, bufferSize, FileOptions.SequentialScan);

                using (fileStream = File.OpenRead(settings.file.FullName))
                {
                    using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, bufferSize))
                    {
                        string line;
                        while ((line = streamReader.ReadLine()) != null)
                        {
                            lineCounter++;
                            if (lineCounter < settings.rowsToSkip)
                                continue;

                            // Process line
                            string[] lines = line.Split(separator);
                            Point point = ParsePoint(lines);
                            pointList.Add(point);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                pointList.Clear();
                Helper.Error(new Exception($"Inläsningsfel upptäckt vid rad {lineCounter.ToString()}. Importen avbruten.\n\n" + ex.ToString()));
            }
        }

        public void SavePoints(FileInfo file)
        {
            int pointCounter = 0;
            try
            {
                StringBuilder stringbuilder = new StringBuilder();
                foreach (Point p in pointList)
                {
                    stringbuilder.AppendLine(SerializePoint(p));
                    pointCounter++;
                }

                if (file.Exists)
                    File.Delete(file.FullName);

                using (FileStream fs = File.Create(file.FullName)) { }

                File.AppendAllText(file.FullName, stringbuilder.ToString());
            }
            catch (Exception ex)
            {
                Helper.Error(new Exception($"Skrivfel upptäckt vid rad {pointCounter.ToString()}. Exporten avbruten.\n\n" + ex.ToString()));
            }
        }

        string SerializePoint(Point p)
        {
            char separator = Helper.GetSeparator(settings.exportSeparator);
            string exportString = "";

            if (settings.exportMode == FileTypeMode.XYZI)
            {
                exportString = $"{p.x} {p.y} {p.z} {p.intensity}";
            }
            else if (settings.exportMode == FileTypeMode.XYZIC)
            {
                exportString = $"{p.x} {p.y} {p.z} {p.intensity} {p.classification}";
            }
            else if (settings.exportMode == FileTypeMode.XYZRGBI)
            {
                exportString = $"{p.x} {p.y} {p.z} {Helper.GetSerializedColor(p, settings)} {p.intensity}";
            }
            else if (settings.exportMode == FileTypeMode.XYZRGBIC)
            {
                exportString = $"{p.x} {p.y} {p.z} {Helper.GetSerializedColor(p, settings)} {p.intensity} {p.classification}";
            }
            else if (settings.exportMode == FileTypeMode.XYZRGB)
            {
                exportString = $"{p.x} {p.y} {p.z} {Helper.GetSerializedColor(p, settings)}";
            }
            else if (settings.exportMode == FileTypeMode.XYZRGBC)
            {
                exportString = $"{p.x} {p.y} {p.z} {Helper.GetSerializedColor(p, settings)} {p.classification}";
            }
            else if (settings.exportMode == FileTypeMode.CloudCompareXYZIC)
            {
                exportString = $"{p.x} {p.y} {p.z} 0.000 0.000 0.000 0.000 0.000 0.000 {p.intensity} {p.classification}";
            }
            return exportString.Replace(',', '.').Replace(' ', separator);
        }

        Point ParsePoint(string[] lines) // TODO: Check for import file column count
        {
            double x = 0, y = 0, z = 0, i = 0, r = 0, g = 0, b = 0, c = 0;

            x = Helper.ParseString(lines[0]);
            y = Helper.ParseString(lines[1]);
            z = Helper.ParseString(lines[2]);

            if (settings.importMode == FileTypeMode.XYZI)
            {
                i = Helper.ParseString(lines[3]);
            }
            else if (settings.importMode == FileTypeMode.XYZIC)
            {
                i = Helper.ParseString(lines[3]);
                c = Helper.ParseString(lines[4]);
            }
            else if (settings.importMode == FileTypeMode.XYZRGBI)
            {
                r = Helper.ParseString(lines[3]);
                g = Helper.ParseString(lines[4]);
                b = Helper.ParseString(lines[5]);
                i = Helper.ParseString(lines[6]);
            }
            else if (settings.importMode == FileTypeMode.XYZRGBIC)
            {
                r = Helper.ParseString(lines[3]);
                g = Helper.ParseString(lines[4]);
                b = Helper.ParseString(lines[5]);
                i = Helper.ParseString(lines[6]);
                c = Helper.ParseString(lines[7]);
            }
            else if (settings.importMode == FileTypeMode.XYZRGB)
            {
                r = Helper.ParseString(lines[3]);
                g = Helper.ParseString(lines[4]);
                b = Helper.ParseString(lines[5]);
            }
            else if (settings.importMode == FileTypeMode.XYZRGBC)
            {
                r = Helper.ParseString(lines[3]);
                g = Helper.ParseString(lines[4]);
                b = Helper.ParseString(lines[5]);
                c = Helper.ParseString(lines[6]);
            }
            else if (settings.importMode == FileTypeMode.CloudCompareXYZIC)
            {
                x = Helper.ParseString(lines[0]);
                y = Helper.ParseString(lines[1]);
                z = Helper.ParseString(lines[2]);
                i = Helper.ParseString(lines[9]);
                c = Helper.ParseString(lines[10]);
            }

            Point point = new Point(x, y, z, i, new ColorValue(r, g, b), c);
            return point;
        }

        public Point GetAveragePoint()
        {
            double x = 0;
            double y = 0;
            double z = 0;
            int count = 0;

            foreach (Point p in pointList)
            {
                x += p.x;
                y += p.y;
                z += p.z;
                count++;
            }

            return new Point(x / count, y / count, z / count);
        }
    }
}