using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PS_CloudCutFillGradient
{
    public partial class Form1 : Form
    {
        Settings settings;
        PointHandler pointHandler;

        public Form1()
        {
            InitializeComponent();
            InitializeUI();

            // Debug
            //txtCylinderX.Text = "0.000";
            //txtCylinderY.Text = "0.000";
            //txtCylinderZ.Text = "0.000";
            //txtMaxDistance.Text = "0.300";
            //txtCylinderRadius.Text = "12.261";
            //txtCylinderHeight.Text = "0.000";
            //cbImportMode.SelectedIndex = 0;
            //cbOutsidePointsMode.SelectedIndex = 1;
            //cbColorMode.SelectedIndex = 1;
            //cbRowsToSkip.SelectedIndex = 0;
            //txtInputPath.Text = @"C:\Users\patrik\Desktop\PS_CloudCutFillGradient\GK_1cm_2axis_bestfit_lodad_rensad.txt";
        }

        void InitializeUI()
        {
            for (int i = 0; i <= 100; i++)
            {
                cbIntensityMin.Items.Add(i.ToString());
                cbIntensityMax.Items.Add(i.ToString());
            }

            cbColorByMode.SelectedIndex = 1;
            cbOutsidePointsMode.SelectedIndex = 2;
            cbImportSeparator.SelectedIndex = 0;
            cbExportSeparator.SelectedIndex = 0;
            cbRowsToSkip.SelectedIndex = 1;
            cbIntensityMin.SelectedIndex = 0;
            cbIntensityMax.SelectedIndex = 100;
            cbExportMode.SelectedIndex = 2;
            cbImportMode.SelectedIndex = 2;
            cbColorMode.SelectedIndex = 0;
            cbColorType.SelectedIndex = 0;
            cbImportRGBType.SelectedIndex = 0;
            cbExportRGBType.SelectedIndex = 0;
            this.Select();
        }

        private void btnBrowseInputPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Multiselect = false;

            if (string.IsNullOrEmpty(txtInputPath.Text))
                of.InitialDirectory = @"C:\";
            else
                of.InitialDirectory = new FileInfo(txtInputPath.Text).DirectoryName;

            of.Filter = "LiDAR ASCII|*.txt";
            of.Title = "Öppna fil";

            if (of.ShowDialog() == DialogResult.OK)
            {
                FileInfo file = new FileInfo(of.FileName);
                txtInputPath.Text = file.FullName;
                txtInputPath.SelectionStart = txtInputPath.Text.Length;
                txtInputPath.ScrollToCaret();
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            FileInfo sourceFile = new FileInfo(txtInputPath.Text);
            if (!sourceFile.Exists)
            {
                MessageBox.Show($"Filen existerar inte!\n\n'{sourceFile.FullName}'");
                return;
            }

            SaveFileDialog sf = new SaveFileDialog();
            sf.InitialDirectory = sourceFile.DirectoryName;
            sf.Filter = "LiDAR ASCII|*.txt";
            sf.Title = "Spara fil";

            if (sf.ShowDialog() == DialogResult.OK)
            {
                SetUIState(false);
                FileInfo saveFile = new FileInfo(sf.FileName);
                bool settingsSuccessful = UpdateSettings();
                if (settingsSuccessful)
                {
                    pointHandler = new PointHandler(settings);
                    pointHandler.LoadPoints();
                    await pointHandler.CalculatePointsAsync();
                    pointHandler.SavePoints(saveFile);


                    // Stats
                    int pointCount = pointHandler.pointList.Count;
                    double highestDistance = pointHandler.highestDistanceToEdge;
                    double averageDistance = (pointCount == 0 ? 0 : (pointHandler.sumDistanceToEdge / pointCount));
                    MessageBox.Show(
                        $"Sparade '{pointCount}' punkter.\n\nLängsta Avstånd: " +
                        $"{highestDistance.ToString("0.00", CultureInfo.InvariantCulture)}\nMedelavstånd: " +
                        $"{averageDistance.ToString("0.00", CultureInfo.InvariantCulture)}", "Färdig!");
                }
                SetUIState(true);
            }
        }

        private bool UpdateSettings()
        {
            settings = new Settings();

            try
            {
                settings.file = new FileInfo(txtInputPath.Text);

                // Colors
                settings.minColor = panelColorMinDistance.BackColor;
                settings.midColor = panelColorMidDistance.BackColor;
                settings.maxColor = panelColorMaxDistance.BackColor;
                settings.outsideColor = panelColorOutsideDistance.BackColor;

                // Intensity
                settings.intensityMin = Helper.ParseString((string)cbIntensityMin.SelectedItem);
                settings.intensityMax = Helper.ParseString((string)cbIntensityMax.SelectedItem);

                // Color Type
                if (cbColorType.SelectedIndex == 0)
                    settings.colorType = ColorType.Color;
                else
                    settings.colorType = ColorType.Intensity;

                // Color Mode
                if (cbColorMode.SelectedIndex == 0)
                    settings.colorMode = ColorMode.Both;
                else if (cbColorMode.SelectedIndex == 1)
                    settings.colorMode = ColorMode.Outside;
                else
                    settings.colorMode = ColorMode.Inside;

                // ColorBy Mode
                if (cbColorByMode.SelectedIndex == 0)
                    settings.colorByMode = ColorByMode.ByLongestDistance;
                else
                    settings.colorByMode = ColorByMode.ByMaxDistance;

                // Outside Points Mode
                if (cbOutsidePointsMode.SelectedIndex == 0)
                    settings.outsidePointsMode = OutsidePointsMode.Ignore;
                else if (cbOutsidePointsMode.SelectedIndex == 1)
                    settings.outsidePointsMode = OutsidePointsMode.Remove;
                else
                    settings.outsidePointsMode = OutsidePointsMode.Colorize;

                // Ignore Points above or below the cylinder
                settings.ignorePointsAboveBelow = cbIgnorePointsAboveBelow.Checked;

                // Max Distance
                settings.maxDistance = Helper.ParseString(txtMaxDistance.Text);

                // Cylinder
                double x = Helper.ParseString(txtCylinderX.Text);
                double y = Helper.ParseString(txtCylinderY.Text);
                double z = Helper.ParseString(txtCylinderZ.Text);
                double height = Helper.ParseString(txtCylinderHeight.Text);
                double radius = Helper.ParseString(txtCylinderRadius.Text);
                settings.cylinder = new Cylinder(new Point(x, y, z), height, radius);

                // Import
                // Separator
                if (cbImportSeparator.SelectedIndex == 0)
                    settings.importSeparator = Separator.Space;
                else if (cbImportSeparator.SelectedIndex == 1)
                    settings.importSeparator = Separator.Comma;
                else
                    settings.importSeparator = Separator.Dot;

                // RGB Type
                if (cbImportRGBType.SelectedIndex == 0)
                    settings.importRGBTypeInt = true;
                else
                    settings.importRGBTypeInt = false;

                // Rows to Skip
                if (cbRowsToSkip.SelectedIndex == 0)
                    settings.rowsToSkip = 0;
                else if (cbRowsToSkip.SelectedIndex == 1)
                    settings.rowsToSkip = 1;
                else if (cbRowsToSkip.SelectedIndex == 2)
                    settings.rowsToSkip = 2;
                else
                    settings.rowsToSkip = 3;

                // Import Mode
                settings.importMode = Helper.GetFileTypeMode(cbImportMode, true);

                // Export
                // Export Mode
                // Separator
                if (cbExportSeparator.SelectedIndex == 0)
                    settings.exportSeparator = Separator.Space;
                else if (cbExportSeparator.SelectedIndex == 1)
                    settings.exportSeparator = Separator.Comma;
                else
                    settings.exportSeparator = Separator.Dot;

                // RGB Type
                if (cbExportRGBType.SelectedIndex == 0)
                    settings.exportRGBTypeInt = true;
                else
                    settings.exportRGBTypeInt = false;

                settings.exportMode = Helper.GetFileTypeMode(cbExportMode, false);

                return true;
            }
            catch (Exception ex)
            {
                Helper.Error(ex);
                return false;
            }
        }

        private void panelColorMinDistance_MouseClick(object sender, MouseEventArgs e)
        {
            colorDialog.Color = panelColorMinDistance.BackColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                panelColorMinDistance.BackColor = colorDialog.Color;
            }
        }


        private void panelColorMidDistance_MouseClick(object sender, MouseEventArgs e)
        {
            colorDialog.Color = panelColorMidDistance.BackColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                panelColorMidDistance.BackColor = colorDialog.Color;
            }
        }

        private void panelColorMaxDistance_MouseClick(object sender, MouseEventArgs e)
        {
            colorDialog.Color = panelColorMaxDistance.BackColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                panelColorMaxDistance.BackColor = colorDialog.Color;
            }
        }

        private void panelColorOutsideMaxDistance_MouseClick(object sender, MouseEventArgs e)
        {
            colorDialog.Color = panelColorOutsideDistance.BackColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                panelColorOutsideDistance.BackColor = colorDialog.Color;
            }
        }

        private void cbColorType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbColorType.SelectedIndex == 0)
            {
                panelColorMinDistance.BorderStyle = BorderStyle.FixedSingle;
                panelColorMinDistance.Enabled = true;
                panelColorMaxDistance.BorderStyle = BorderStyle.FixedSingle;
                panelColorMaxDistance.Enabled = true;
                panelColorOutsideDistance.BorderStyle = BorderStyle.FixedSingle;
                panelColorOutsideDistance.Enabled = true;
                cbIntensityMin.Enabled = false;
                cbIntensityMax.Enabled = false;
            }
            else
            {
                panelColorMinDistance.BorderStyle = BorderStyle.Fixed3D;
                panelColorMinDistance.Enabled = false;
                panelColorMaxDistance.BorderStyle = BorderStyle.Fixed3D;
                panelColorMaxDistance.Enabled = false;
                panelColorOutsideDistance.BorderStyle = BorderStyle.Fixed3D;
                panelColorOutsideDistance.Enabled = false;
                cbIntensityMin.Enabled = true;
                cbIntensityMax.Enabled = true;
            }
        }

        private void SetUIState(bool enabled)
        {
            btnBrowseInputPath.Enabled = enabled;
            btnSave.Enabled = enabled;
        }
    }
}
