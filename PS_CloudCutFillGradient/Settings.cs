using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS_CloudCutFillGradient
{
    struct Settings
    {
        public FileInfo file;

        public Color minColor;
        public Color midColor;
        public Color maxColor;
        public Color outsideColor;

        public double intensityMin;
        public double intensityMax;

        public ColorType colorType;
        public ColorMode colorMode;
        public ColorByMode colorByMode;
        public OutsidePointsMode outsidePointsMode;
        public bool ignorePointsAboveBelow;

        public double maxDistance;
        public Cylinder cylinder;

        public FileTypeMode importMode;
        public Separator importSeparator;
        public int rowsToSkip;
        public bool importRGBTypeInt;

        public FileTypeMode exportMode;
        public Separator exportSeparator;
        public bool exportRGBTypeInt;
    }
}
