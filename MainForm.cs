/*
 * Created by SharpDevelop.
 * User: Banana
 * Date: 6/2/2018
 * Time: 7:24 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Xml;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Timers;
using System.Collections.Generic;

namespace MultiScad
{
    /// <summary>
    /// Description of MainForm.
    /// </summary>
    /// 

    public partial class MainForm : Form
    {
        const string inkscape64Exe = @"C:\Program Files\Inkscape\inkscape.exe";
        const string inkscape86Exe = @"C:\Program Files (x86)\Inkscape\inkscape.exe";

        string inkscapeExe = "";
        string inkscapeVersionVar = "";
        string inkscapeBitVar = "";
        XmlDocument mainSettings = new XmlDocument();
        string OpenSCADLibs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\OpenSCAD\libraries\";

        LoadingSVGFile SVGProcessForm = new LoadingSVGFile();
        LayerForm LayersForm = new LayerForm();

        Image[] layerImages = new Image[9];

        Dictionary<string, string> svgInfo = new Dictionary<string, string>()
        {
            {"md5",""},
            {"name", ""},
            {"location",""},
            {"svgDir",""},
            {"tempDir",""},
            {"scadDir",""}
        };

        Dictionary<string, string> folderInfo = new Dictionary<string, string>()
        {
            {"main",""},
            {"svgs", ""},
            {"temp",""},
            {"scad",""}
        };


        string svgMD5;
        string svgInput;

        string TempDir;
        string MainDir;
        string SvgsDir;
        string ScadDir;
        //string SvgMD5;

        public MainForm()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();
            SVGProcessForm.ShowInTaskbar = false;
            LayersForm.ShowInTaskbar = false;

            folderInfo["main"] = getSetting("MainDir","string");
            folderInfo["temp"] = Path.Combine(folderInfo["main"], "Temp");
            folderInfo["svgs"] = Path.Combine(folderInfo["main"], "Svgs");
            folderInfo["scad"] = Path.Combine(folderInfo["main"], "Scads");
            MainDir = getSetting("MainDir","string");
            TempDir = Path.Combine(MainDir,"Temp");
            SvgsDir = Path.Combine(MainDir, "Svgs");
            ScadDir = Path.Combine(MainDir, "Scads");

            checkStartupFiles();
            loadFilesList();
            checkInkscape();



            #region polygonSetup
            polygonPrimaryHeightSlider.Value = getSetting("polygonPrimaryHeight","byte");
            polygonPrimaryHeightTxt.Text = (polygonPrimaryHeightSlider.Value / 10.0).ToString();
            polygonSecondaryHeightSlider.Value = getSetting("polygonSecondaryHeight", "byte");
            polygonSecondaryHeightTxt.Text = (polygonSecondaryHeightSlider.Value / 10.0).ToString();
            //polygonPrimarySelection.SelectedIndex = getSetting("polygonPrimarySelection","byte");
            //polygonPrimarySelected = polygonPrimarySelection.SelectedIndex;
            //polygonSecondarySelection.SelectedIndex = getSetting("polygonSecondarySelection","byte");
            //polygonSecondarySelected = polygonSecondarySelection.SelectedIndex;
            //polygonHollowSelection.SelectedIndex = getSetting("polygonHollowSelection","byte");
            //polygonHollowSelected = polygonHollowSelection.SelectedIndex;
            #endregion

        }

        private void loadFilesList()
        {
            string[] subdirectoryEntries = Directory.GetDirectories(SvgsDir);
            foreach (string subdirectory in subdirectoryEntries)
            {
                string tmpFolder = Path.GetFileName(subdirectory.TrimEnd(Path.DirectorySeparatorChar));
                string tmpMD5 = tmpFolder.Split('_')[0];
                string tmpName = tmpFolder.Split('_')[1] + ".svg";
                //Debug.WriteLine(tmpName + " - " + tmpMD5);
                reopenDropdown.Items.Add(tmpName + " - " + tmpMD5);
            }
        }
        private void checkStartupFiles()
        {
            if (!Directory.Exists(folderInfo["main"]))
            {
                Debug.Print("Creating Directory Structure for MultiScad");
                Directory.CreateDirectory(folderInfo["main"]);
                Directory.CreateDirectory(folderInfo["temp"]);
                Directory.CreateDirectory(folderInfo["svgs"]);
                Directory.CreateDirectory(folderInfo["scad"]);
            }
            else
            {
                if (!Directory.Exists(folderInfo["temp"]))
                {
                    Debug.Print("Creating Temp Directory for MultiScad");
                    Directory.CreateDirectory(folderInfo["temp"]);
                }
                if (!Directory.Exists(folderInfo["svgs"]))
                {
                    Debug.Print("Creating SVGs Directory for MultiScad");
                    Directory.CreateDirectory(folderInfo["svgs"]);
                }
                if (!Directory.Exists(folderInfo["scad"]))
                {
                    Debug.Print("Creating Scad Directory for MultiScad");
                    Directory.CreateDirectory(folderInfo["scad"]);
                }

            }
        }
        private void checkInkscape()
        {
            if (File.Exists(inkscape64Exe))
            {
                inkscapeExe = inkscape64Exe;
            }
            else if (File.Exists(inkscape86Exe))
            {
                inkscapeExe = inkscape86Exe;
            }
            else
            {
                inkscapeStatus.Text = "Inkscape not found";
                inkscapeStatus.ForeColor = Color.Red;
            }
            if (inkscapeExe != "")
            {
                var versionInfo = FileVersionInfo.GetVersionInfo(inkscapeExe);
                inkscapeVersionVar = versionInfo.ProductVersion;
                bool is86 = inkscapeExe.Contains("x86");
                inkscapeBitVar = is86 == true ? "86" : "64";
                inkscapeStatus.Text = "Inkscape ";
                inkscapeBit.Text = "x" + inkscapeBitVar + " (" + (inkscapeBitVar == "64" ? "64" : "32") + "-bit)";
                //x" + inkscapeBit + " (" + Convert.ToString(inkscapeVersion) + ")";
                inkscapeVersion.Text = inkscapeVersionVar;
                inkscapeStatus.ForeColor = Color.Green;
            }
        }

        private void cleanupTemp(object sender, FormClosedEventArgs e)
        {
            //Debug.WriteLine("Cleaning up Temporary Files");
        }


        //~~~~START INKSCAPE FUNCTIONS~~~~~
        #region inkscapeFunctions
        void InkscapeInstalledMsgClick(object sender, EventArgs e)
        {
            if (inkscapeStatus.ForeColor == Color.Red && 1 == 2)
            {
                MessageBox.Show("Inkscape was not found in the default install locations.\n" +
                                "Default Install Locations are:\n" +
                                "C:\\Program Files\\Inkscape\\inkscape.exe\n" +
                                "C:\\Program Files (x86)\\Inkscape\\inkscape.exe\n\n" +
                                "Would you like to set a custom location?", "INKSCAPE NOT FOUND");
            }
        }
        #endregion


        //~~~~~START LIBRARY FUNCTIONS~~~~~
        #region libraryFunctions
        string readVersion(string resName)
        {
            try
            {
                var assembly = Assembly.GetExecutingAssembly();
                var resourceName = "MultiScad.Resources." + resName + ".scad";

                using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                using (StreamReader reader = new StreamReader(stream))
                {
                    return reader.ReadLine().Replace("//", "");
                }
            }
            catch
            {
                return "";
            }
        }
        void ExportLibraryFile(string libraryName)
        {
            Debug.Print("");
            string fileName = OpenSCADLibs + libraryName + ".scad";
            using (var resource = Assembly.GetExecutingAssembly().GetManifestResourceStream("MultiScad.Resources." + libraryName + ".scad"))
            {
                using (var file = new FileStream(fileName, FileMode.Create, FileAccess.Write))
                {
                    resource.CopyTo(file);
                }
            }
        }
        #endregion


        //~~~~~START SETTING FUNCTIONS~~~~~
        #region settingsFunctions
        dynamic getSetting(string key, string type)
        {
            type = type.ToLower();
            switch (type)
            {
                case "bool":
                    return Convert.ToBoolean(Properties.Settings.Default[key].ToString());
                case "string":
                    return Properties.Settings.Default[key].ToString();
                case "int":
                    return Convert.ToInt32(Properties.Settings.Default[key].ToString());
                case "double":
                    return Convert.ToDouble(Properties.Settings.Default[key].ToString());
                case "byte":
                    return Convert.ToByte(Properties.Settings.Default[key].ToString());
                default:
                    return Properties.Settings.Default[key].ToString(); 
            }
        }
        void setSetting(string key, dynamic val)
        {
            Properties.Settings.Default[key] = val;
            Properties.Settings.Default.Save();
        }
        #endregion



        //~~~~~START BOTTOM STATUS BUTTONS~~~~~

        private void exportSettingsPage_Click(object sender, EventArgs e)
        {

        }

        private void polygonOutlineHeightSlider_ValueChanged(object sender, EventArgs e)
        {
            var polySlideVal = polygonPrimaryHeightSlider.Value / 10.0;
            polygonPrimaryHeightTxt.Text = polySlideVal.ToString();
        }

        public string MD5String(string input) {
            MD5 md5 = MD5.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }
        public string MD5File(string fileName)
        {
            //fileName = fileName.Replace("\\","\\\\");
            //Debug.Print("FileName: " +  fileName);
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(fileName))
                {
                    return BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", string.Empty);
                }
            }
        }

        private void polygonSettingsBtn_Click(object sender, EventArgs e)
        {
            SettingTabsList.SelectTab(polygonSettingsPage);
        }

        private void polygonPrimaryDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Debug.Print(polygonPrimarySelection.SelectedIndex.ToString());
        }

        private void polygonSettingsPage_Click(object sender, EventArgs e)
        {

        }

        private void importSVGFile(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "SVG files (*.svg, *.svgz)|*.svg;*.svgz|All files (*.*)|*.*";
            dlg.Title = "Please select a SVG to open.";

            if (dlg.ShowDialog() == DialogResult.OK)
            {

                //SVGFile = dlg.SafeFileName;
                string tempInput = Path.Combine(Path.GetDirectoryName(dlg.FileName), dlg.SafeFileName);
                svgMD5 = MD5File(tempInput);

                string tempSVGDir = Path.Combine(SvgsDir, svgMD5 + "_" + dlg.SafeFileName.Replace(".svg",""));
                string tempTempDir = Path.Combine(TempDir, svgMD5 + "_" + dlg.SafeFileName.Replace(".svg", ""));
                if(Directory.Exists(tempSVGDir) && Directory.Exists(tempTempDir))
                {
                    return;
                }
                svgInput = Path.Combine(SvgsDir, svgMD5 + "_" + dlg.SafeFileName.Replace(".svg", ""), dlg.SafeFileName);
                //Debug.Print(TempFile);

                if (!Directory.Exists(tempSVGDir) || !Directory.Exists(tempTempDir))
                {
                    Debug.Print("Creating SVGs Directory for MultiScad");
                    Directory.CreateDirectory(tempSVGDir);
                    Directory.CreateDirectory(tempTempDir);
                }
                File.Copy(tempInput, svgInput, true);
                svgFileName.Text = dlg.SafeFileName;
                svgFileMD5.Text = "Processing SVG File";
                this.Enabled = false;
                SVGProcessForm.Owner = this;
                SVGProcessForm.UpdateNameText = dlg.SafeFileName;
                SVGProcessForm.UpdateMD5Text = svgMD5;

                SVGProcessForm.Show(this);
                int x = this.DesktopBounds.Left + (this.Width - SVGProcessForm.Width) / 2;
                int y = this.DesktopBounds.Top + (this.Height - SVGProcessForm.Height) / 2;
                SVGProcessForm.SetDesktopLocation(x, y);




                processSVGFile(svgInput, svgMD5, tempSVGDir, tempTempDir, SVGProcessForm);
                this.Enabled = true;
                SVGProcessForm.Hide();

                svgFileName.Text = dlg.SafeFileName;
                svgFileMD5.Text = "MD5: " + svgMD5;
                copyFileLocationBtn.Enabled = true;
                openFileLocationBtn.Enabled = true;


            }
        }



        private void processSVGFile(string SVGInput, string MD5, string svgDir, string tempDir, LoadingSVGFile popupForm)
        {
            popupForm.UpdateProcessText = "Importing SVG";
            double width = processSVGWidth();
            double height = processSVGHeight();



            Debug.WriteLine(width);
            Debug.WriteLine(height);
            string imgFormat = width > height ? "96x" : "x96";

            ProcessLayer("1", SVGInput, MD5, svgDir, tempDir, popupForm, imgFormat);
            ProcessLayer("2", SVGInput, MD5, svgDir, tempDir, popupForm, imgFormat);
            ProcessLayer("3", SVGInput, MD5, svgDir, tempDir, popupForm, imgFormat);
            ProcessLayer("4", SVGInput, MD5, svgDir, tempDir, popupForm, imgFormat);
            ProcessLayer("5", SVGInput, MD5, svgDir, tempDir, popupForm, imgFormat);
            ProcessLayer("6", SVGInput, MD5, svgDir, tempDir, popupForm, imgFormat);
        }

        private void ProcessLayer(string layer, string SVGInput, string MD5, string svgDir, string tempDir, LoadingSVGFile popupForm, string sizeFormat)
        {
            popupForm.UpdateProcessText = "Processing Layer " + layer + " SVG";
            Process processLayer1 = new Process();
            ProcessStartInfo startInfoLayer1 = new ProcessStartInfo();
            startInfoLayer1.FileName = "inkscape.exe";
            startInfoLayer1.Arguments = "--without-gui --file=\"" + svgInput + "\" --export-plain-svg=\"" + svgDir + "\\Layer" + layer + ".svg\" --export-area-page --export-id-only --export-id=layer" + layer;
            startInfoLayer1.CreateNoWindow = true;
            processLayer1.StartInfo = startInfoLayer1;
            processLayer1.Start();
            processLayer1.WaitForExit();





            if (File.Exists(svgDir + "\\Layer" + layer + ".svg"))
            {
                popupForm.UpdateProcessText = "Processing Layer " + layer + " Image";
                Process processLayer1PNG = new Process();
                ProcessStartInfo startInfoLayer1PNG = new ProcessStartInfo();
                startInfoLayer1PNG.FileName = "convert.exe";
                startInfoLayer1PNG.Arguments = "-colors 2  -background none -geometry " + sizeFormat + " \"" + svgDir + "\\Layer" + layer + ".svg\" \"" + tempDir + "\\Layer" + layer + ".png\"";
                startInfoLayer1PNG.CreateNoWindow = true;
                startInfoLayer1PNG.RedirectStandardInput = true;
                startInfoLayer1PNG.RedirectStandardOutput = false;
                startInfoLayer1PNG.UseShellExecute = false;
                processLayer1PNG.StartInfo = startInfoLayer1PNG;
                processLayer1PNG.Start();
                processLayer1PNG.WaitForExit();

                layerImages[Convert.ToInt16(layer)] = Image.FromFile(tempDir + "\\Layer" + layer + ".png");
                //((PictureBox)this.Controls.Find("layer" + layer + "Image", true)[0]).Image = layerImages[Convert.ToInt16(layer)];
            }

        }

        private double processSVGWidth()
        {
            Process widthProcess = new Process();
            ProcessStartInfo widthStartInfo = new ProcessStartInfo();
            widthStartInfo.FileName = "inkscape.exe";
            widthStartInfo.Arguments = "--without-gui --file=\"" + svgInput + "\" -W";
            widthStartInfo.CreateNoWindow = true;
            widthStartInfo.UseShellExecute = false;
            widthStartInfo.RedirectStandardOutput = true;
            widthProcess.StartInfo = widthStartInfo;
            widthProcess.Start();
            widthProcess.WaitForExit();
            return Convert.ToDouble(widthProcess.StandardOutput.ReadLine());
        }

        private double processSVGHeight()
        {
            Process widthProcess = new Process();
            ProcessStartInfo widthStartInfo = new ProcessStartInfo();
            widthStartInfo.FileName = "inkscape.exe";
            widthStartInfo.Arguments = "--without-gui --file=\"" + svgInput + "\" -H";
            widthStartInfo.CreateNoWindow = true;
            widthStartInfo.UseShellExecute = false;
            widthStartInfo.RedirectStandardOutput = true;
            widthProcess.StartInfo = widthStartInfo;
            widthProcess.Start();
            widthProcess.WaitForExit();
            return Convert.ToDouble(widthProcess.StandardOutput.ReadLine());
        }

        private void ProcessLayerSVG()
        {

        }

        private void ProcessLayerImg()
        {

        }

        private void loadLayerImage(string fileName, string md5, string layerNumber)
        {

        }

        private void openSVGLocation(object sender, EventArgs e)
        {
            if (svgMD5 != null)
            {
                Debug.Print(Path.Combine(SvgsDir, svgMD5));
                Process.Start(Path.Combine(SvgsDir, svgMD5));
            }
        }

        private void copyFileLocation(object sender, EventArgs e)
        {
            if(svgInput != null)
            {
                Clipboard.SetText(svgInput);
            }
        }

        private void ShowMD5Tooltip(object sender, MouseEventArgs e)
        {
            var tempBox = sender as TextBox;
            if (tempBox.Text.Length >= 32)
            {
                toolTip1.SetToolTip(svgFileMD5, "Click to copy MD5 to Clipboard");
            }
        }

        private void copyMD5toClipboard(object sender, EventArgs e)
        {
            if (svgMD5 != null)
            {
                Clipboard.SetText(svgMD5);
            }
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            if(getSetting("showLayersForm","bool") == true)
            {
                layersMenuBtn.Text = "Hide Layers";
                LayersForm.Show(this);
                LayersForm.SetDesktopLocation(this.DesktopBounds.Right - 12, this.DesktopBounds.Top);
            } else
            {
                LayersForm.Hide();
                layersMenuBtn.Text = "Show Layers";
            }
        }

        private void MainForm_LocationChanged(object sender, EventArgs e)
        {
            LayersForm.SetDesktopLocation(this.DesktopBounds.Right - 12, this.DesktopBounds.Top);
        }


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void layersMenuBtn_Click_1(object sender, EventArgs e)
        {
            if (LayersForm.Visible == true)
            {
                LayersForm.Hide();
                layersMenuBtn.Text = "Show Layers";
            }
            else
            {
                layersMenuBtn.Text = "Hide Layers";
                LayersForm.Show(this);
                LayersForm.SetDesktopLocation(this.DesktopBounds.Right - 12, this.DesktopBounds.Top);
            }
        }

        private void layersMenuBtn_MouseMove(object sender, MouseEventArgs e)
        {
            //layersMenuBtn.AutoToolTip = true;
            //ToolTip.Show();
            //toolTip1.SetToolTip("Double Click to Hide/Show Layer Form");
        }

        private void reopenDropdown_SelectedValueChanged(object sender, EventArgs e)
        {
            string tmpInfo = reopenDropdown.Text;
            string tmpMD5 = tmpInfo.Split('-')[1].Trim(' ');
            string tmpFile = tmpInfo.Split('-')[0].Trim(' ');
            svgFileName.Text = tmpFile;
            svgFileMD5.Text = "MD5: " + tmpMD5;
            //Debug.WriteLine(reopenDropdown.Text);
        }
    }

}
