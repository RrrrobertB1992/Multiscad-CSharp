/*
 * Created by SharpDevelop.
 * User: Banana
 * Date: 6/2/2018
 * Time: 7:24 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace MultiScad
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openSVGToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem importSettingsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exportSettingsToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem resetSettingsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem readMeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inkscapeStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.inkscapeBit = new System.Windows.Forms.ToolStripMenuItem();
            this.inkscapeVersion = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingTabsList = new System.Windows.Forms.TabControl();
            this.mainSettingsPage = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.openFileLocationBtn = new System.Windows.Forms.Button();
            this.copyFileLocationBtn = new System.Windows.Forms.Button();
            this.openSVGBtn = new System.Windows.Forms.Button();
            this.svgFileMD5 = new System.Windows.Forms.TextBox();
            this.svgFileName = new System.Windows.Forms.TextBox();
            this.exportAllBtn = new System.Windows.Forms.Button();
            this.polygonSettingsPage = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.polygonSecondaryHeightSlider = new System.Windows.Forms.TrackBar();
            this.polygonSecondaryHeightTxt = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.polygonPrimaryHeightSlider = new System.Windows.Forms.TrackBar();
            this.polygonPrimaryHeightTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.bookmarkSettingsPage = new System.Windows.Forms.TabPage();
            this.formCutterSettingsPage = new System.Windows.Forms.TabPage();
            this.keychainSettingsPage = new System.Windows.Forms.TabPage();
            this.badgeSettingsPage = new System.Windows.Forms.TabPage();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.openSVGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem16 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem17 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem18 = new System.Windows.Forms.ToolStripMenuItem();
            this.resetSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lithophaneSettingsPage = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.polygonSizePage = new System.Windows.Forms.TabPage();
            this.polygonLayerPage = new System.Windows.Forms.TabPage();
            this.polygonExportPage = new System.Windows.Forms.TabPage();
            this.layersMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.LayersPinned = new System.Windows.Forms.ToolStripMenuItem();
            this.layersInformationBox = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.reopenDropdown = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.SettingTabsList.SuspendLayout();
            this.mainSettingsPage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.polygonSettingsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.polygonSecondaryHeightSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.polygonPrimaryHeightSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.polygonSizePage.SuspendLayout();
            this.layersInformationBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.configurationToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.inkscapeStatus,
            this.layersMenuBtn});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.ShowItemToolTips = true;
            this.menuStrip1.Size = new System.Drawing.Size(394, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openSVGToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(167, 6);
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importSettingsToolStripMenuItem,
            this.exportSettingsToolStripMenuItem,
            this.toolStripMenuItem16,
            this.toolStripSeparator2,
            this.toolStripMenuItem17,
            this.toolStripMenuItem18,
            this.resetSettingsToolStripMenuItem});
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.configurationToolStripMenuItem.Text = "Settings";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(193, 6);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readMeToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // inkscapeStatus
            // 
            this.inkscapeStatus.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.inkscapeStatus.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inkscapeBit,
            this.inkscapeVersion});
            this.inkscapeStatus.Name = "inkscapeStatus";
            this.inkscapeStatus.Size = new System.Drawing.Size(97, 20);
            this.inkscapeStatus.Text = "inkscapeStatus";
            // 
            // inkscapeBit
            // 
            this.inkscapeBit.Name = "inkscapeBit";
            this.inkscapeBit.Size = new System.Drawing.Size(158, 22);
            this.inkscapeBit.Text = "inkscapeBit";
            // 
            // inkscapeVersion
            // 
            this.inkscapeVersion.Name = "inkscapeVersion";
            this.inkscapeVersion.Size = new System.Drawing.Size(158, 22);
            this.inkscapeVersion.Text = "inkscapeVersion";
            // 
            // SettingTabsList
            // 
            this.SettingTabsList.Controls.Add(this.mainSettingsPage);
            this.SettingTabsList.Controls.Add(this.polygonSettingsPage);
            this.SettingTabsList.Controls.Add(this.bookmarkSettingsPage);
            this.SettingTabsList.Controls.Add(this.formCutterSettingsPage);
            this.SettingTabsList.Controls.Add(this.keychainSettingsPage);
            this.SettingTabsList.Controls.Add(this.badgeSettingsPage);
            this.SettingTabsList.Controls.Add(this.lithophaneSettingsPage);
            this.SettingTabsList.Location = new System.Drawing.Point(2, 24);
            this.SettingTabsList.Name = "SettingTabsList";
            this.SettingTabsList.SelectedIndex = 0;
            this.SettingTabsList.Size = new System.Drawing.Size(391, 290);
            this.SettingTabsList.TabIndex = 3;
            // 
            // mainSettingsPage
            // 
            this.mainSettingsPage.Controls.Add(this.layersInformationBox);
            this.mainSettingsPage.Controls.Add(this.exportAllBtn);
            this.mainSettingsPage.Controls.Add(this.groupBox2);
            this.mainSettingsPage.Controls.Add(this.pictureBox4);
            this.mainSettingsPage.Location = new System.Drawing.Point(4, 22);
            this.mainSettingsPage.Name = "mainSettingsPage";
            this.mainSettingsPage.Padding = new System.Windows.Forms.Padding(3);
            this.mainSettingsPage.Size = new System.Drawing.Size(383, 264);
            this.mainSettingsPage.TabIndex = 0;
            this.mainSettingsPage.Text = "Main";
            this.mainSettingsPage.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.reopenDropdown);
            this.groupBox2.Controls.Add(this.openFileLocationBtn);
            this.groupBox2.Controls.Add(this.copyFileLocationBtn);
            this.groupBox2.Controls.Add(this.openSVGBtn);
            this.groupBox2.Controls.Add(this.svgFileMD5);
            this.groupBox2.Controls.Add(this.svgFileName);
            this.groupBox2.Location = new System.Drawing.Point(7, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(370, 131);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SVG Information";
            // 
            // openFileLocationBtn
            // 
            this.openFileLocationBtn.Enabled = false;
            this.openFileLocationBtn.Location = new System.Drawing.Point(188, 100);
            this.openFileLocationBtn.Name = "openFileLocationBtn";
            this.openFileLocationBtn.Size = new System.Drawing.Size(176, 23);
            this.openFileLocationBtn.TabIndex = 5;
            this.openFileLocationBtn.Text = "Open SVG Location";
            this.openFileLocationBtn.UseVisualStyleBackColor = true;
            this.openFileLocationBtn.Click += new System.EventHandler(this.openSVGLocation);
            // 
            // copyFileLocationBtn
            // 
            this.copyFileLocationBtn.Enabled = false;
            this.copyFileLocationBtn.Location = new System.Drawing.Point(6, 100);
            this.copyFileLocationBtn.Name = "copyFileLocationBtn";
            this.copyFileLocationBtn.Size = new System.Drawing.Size(176, 23);
            this.copyFileLocationBtn.TabIndex = 4;
            this.copyFileLocationBtn.Text = "Copy SVG Location";
            this.copyFileLocationBtn.UseVisualStyleBackColor = true;
            this.copyFileLocationBtn.Click += new System.EventHandler(this.copyFileLocation);
            // 
            // openSVGBtn
            // 
            this.openSVGBtn.Location = new System.Drawing.Point(7, 45);
            this.openSVGBtn.Name = "openSVGBtn";
            this.openSVGBtn.Size = new System.Drawing.Size(176, 23);
            this.openSVGBtn.TabIndex = 3;
            this.openSVGBtn.Text = "Open SVG File";
            this.openSVGBtn.UseVisualStyleBackColor = true;
            this.openSVGBtn.Click += new System.EventHandler(this.importSVGFile);
            // 
            // svgFileMD5
            // 
            this.svgFileMD5.Enabled = false;
            this.svgFileMD5.Location = new System.Drawing.Point(7, 74);
            this.svgFileMD5.Name = "svgFileMD5";
            this.svgFileMD5.ReadOnly = true;
            this.svgFileMD5.Size = new System.Drawing.Size(357, 20);
            this.svgFileMD5.TabIndex = 2;
            this.svgFileMD5.Click += new System.EventHandler(this.copyMD5toClipboard);
            this.svgFileMD5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ShowMD5Tooltip);
            // 
            // svgFileName
            // 
            this.svgFileName.Enabled = false;
            this.svgFileName.Location = new System.Drawing.Point(189, 45);
            this.svgFileName.Name = "svgFileName";
            this.svgFileName.ReadOnly = true;
            this.svgFileName.Size = new System.Drawing.Size(175, 20);
            this.svgFileName.TabIndex = 1;
            this.svgFileName.Text = "No SVG Open";
            // 
            // exportAllBtn
            // 
            this.exportAllBtn.Enabled = false;
            this.exportAllBtn.Location = new System.Drawing.Point(6, 235);
            this.exportAllBtn.Name = "exportAllBtn";
            this.exportAllBtn.Size = new System.Drawing.Size(371, 23);
            this.exportAllBtn.TabIndex = 19;
            this.exportAllBtn.Text = "Export All";
            this.exportAllBtn.UseVisualStyleBackColor = true;
            // 
            // polygonSettingsPage
            // 
            this.polygonSettingsPage.Controls.Add(this.tabControl1);
            this.polygonSettingsPage.Location = new System.Drawing.Point(4, 22);
            this.polygonSettingsPage.Name = "polygonSettingsPage";
            this.polygonSettingsPage.Padding = new System.Windows.Forms.Padding(3);
            this.polygonSettingsPage.Size = new System.Drawing.Size(383, 264);
            this.polygonSettingsPage.TabIndex = 1;
            this.polygonSettingsPage.Text = "Polygon";
            this.polygonSettingsPage.UseVisualStyleBackColor = true;
            this.polygonSettingsPage.Click += new System.EventHandler(this.polygonSettingsPage_Click);
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(274, 46);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 16);
            this.label13.TabIndex = 31;
            this.label13.Text = "Max: 20mm";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // polygonSecondaryHeightSlider
            // 
            this.polygonSecondaryHeightSlider.AutoSize = false;
            this.polygonSecondaryHeightSlider.LargeChange = 10;
            this.polygonSecondaryHeightSlider.Location = new System.Drawing.Point(6, 66);
            this.polygonSecondaryHeightSlider.Maximum = 200;
            this.polygonSecondaryHeightSlider.Minimum = 5;
            this.polygonSecondaryHeightSlider.Name = "polygonSecondaryHeightSlider";
            this.polygonSecondaryHeightSlider.Size = new System.Drawing.Size(314, 20);
            this.polygonSecondaryHeightSlider.TabIndex = 30;
            this.polygonSecondaryHeightSlider.TickFrequency = 10;
            this.polygonSecondaryHeightSlider.Value = 50;
            // 
            // polygonSecondaryHeightTxt
            // 
            this.polygonSecondaryHeightTxt.Location = new System.Drawing.Point(326, 66);
            this.polygonSecondaryHeightTxt.Name = "polygonSecondaryHeightTxt";
            this.polygonSecondaryHeightTxt.Size = new System.Drawing.Size(30, 20);
            this.polygonSecondaryHeightTxt.TabIndex = 29;
            this.polygonSecondaryHeightTxt.Text = "5.0";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(3, 46);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(180, 16);
            this.label14.TabIndex = 28;
            this.label14.Text = "Indent Height";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(274, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 16);
            this.label10.TabIndex = 23;
            this.label10.Text = "Max: 20mm";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // polygonPrimaryHeightSlider
            // 
            this.polygonPrimaryHeightSlider.AutoSize = false;
            this.polygonPrimaryHeightSlider.Location = new System.Drawing.Point(6, 23);
            this.polygonPrimaryHeightSlider.Maximum = 200;
            this.polygonPrimaryHeightSlider.Minimum = 5;
            this.polygonPrimaryHeightSlider.Name = "polygonPrimaryHeightSlider";
            this.polygonPrimaryHeightSlider.Size = new System.Drawing.Size(314, 20);
            this.polygonPrimaryHeightSlider.TabIndex = 22;
            this.polygonPrimaryHeightSlider.TickFrequency = 10;
            this.polygonPrimaryHeightSlider.Value = 100;
            this.polygonPrimaryHeightSlider.ValueChanged += new System.EventHandler(this.polygonOutlineHeightSlider_ValueChanged);
            // 
            // polygonPrimaryHeightTxt
            // 
            this.polygonPrimaryHeightTxt.Location = new System.Drawing.Point(326, 23);
            this.polygonPrimaryHeightTxt.Name = "polygonPrimaryHeightTxt";
            this.polygonPrimaryHeightTxt.Size = new System.Drawing.Size(30, 20);
            this.polygonPrimaryHeightTxt.TabIndex = 21;
            this.polygonPrimaryHeightTxt.Text = "10.0";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(3, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(180, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Full Height";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bookmarkSettingsPage
            // 
            this.bookmarkSettingsPage.Location = new System.Drawing.Point(4, 22);
            this.bookmarkSettingsPage.Name = "bookmarkSettingsPage";
            this.bookmarkSettingsPage.Size = new System.Drawing.Size(654, 264);
            this.bookmarkSettingsPage.TabIndex = 2;
            this.bookmarkSettingsPage.Text = "Bookmark";
            this.bookmarkSettingsPage.UseVisualStyleBackColor = true;
            // 
            // formCutterSettingsPage
            // 
            this.formCutterSettingsPage.Location = new System.Drawing.Point(4, 22);
            this.formCutterSettingsPage.Name = "formCutterSettingsPage";
            this.formCutterSettingsPage.Size = new System.Drawing.Size(654, 264);
            this.formCutterSettingsPage.TabIndex = 3;
            this.formCutterSettingsPage.Text = "Form Cutter";
            this.formCutterSettingsPage.UseVisualStyleBackColor = true;
            // 
            // keychainSettingsPage
            // 
            this.keychainSettingsPage.Location = new System.Drawing.Point(4, 22);
            this.keychainSettingsPage.Name = "keychainSettingsPage";
            this.keychainSettingsPage.Size = new System.Drawing.Size(654, 264);
            this.keychainSettingsPage.TabIndex = 4;
            this.keychainSettingsPage.Text = "Keychain";
            this.keychainSettingsPage.UseVisualStyleBackColor = true;
            // 
            // badgeSettingsPage
            // 
            this.badgeSettingsPage.Location = new System.Drawing.Point(4, 22);
            this.badgeSettingsPage.Name = "badgeSettingsPage";
            this.badgeSettingsPage.Size = new System.Drawing.Size(654, 264);
            this.badgeSettingsPage.TabIndex = 5;
            this.badgeSettingsPage.Text = "Badges";
            this.badgeSettingsPage.UseVisualStyleBackColor = true;
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 1000;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(462, 6);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(0, 0);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // openSVGToolStripMenuItem
            // 
            this.openSVGToolStripMenuItem.Image = global::MultiScad.MenuIcons.svg;
            this.openSVGToolStripMenuItem.Name = "openSVGToolStripMenuItem";
            this.openSVGToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openSVGToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.openSVGToolStripMenuItem.Text = "Open SVG";
            this.openSVGToolStripMenuItem.Click += new System.EventHandler(this.importSVGFile);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::MultiScad.MenuIcons.close;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // importSettingsToolStripMenuItem
            // 
            this.importSettingsToolStripMenuItem.Image = global::MultiScad.MenuIcons.import;
            this.importSettingsToolStripMenuItem.Name = "importSettingsToolStripMenuItem";
            this.importSettingsToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.importSettingsToolStripMenuItem.Text = "Load Program Settings";
            // 
            // exportSettingsToolStripMenuItem
            // 
            this.exportSettingsToolStripMenuItem.Image = global::MultiScad.MenuIcons.export;
            this.exportSettingsToolStripMenuItem.Name = "exportSettingsToolStripMenuItem";
            this.exportSettingsToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.exportSettingsToolStripMenuItem.Text = "Save Program Settings";
            // 
            // toolStripMenuItem16
            // 
            this.toolStripMenuItem16.Image = global::MultiScad.MenuIcons.refresh;
            this.toolStripMenuItem16.Name = "toolStripMenuItem16";
            this.toolStripMenuItem16.Size = new System.Drawing.Size(196, 22);
            this.toolStripMenuItem16.Text = "Reset Program Settings";
            // 
            // toolStripMenuItem17
            // 
            this.toolStripMenuItem17.Image = global::MultiScad.MenuIcons.import;
            this.toolStripMenuItem17.Name = "toolStripMenuItem17";
            this.toolStripMenuItem17.Size = new System.Drawing.Size(196, 22);
            this.toolStripMenuItem17.Text = "Load Program Settings";
            // 
            // toolStripMenuItem18
            // 
            this.toolStripMenuItem18.Image = global::MultiScad.MenuIcons.export;
            this.toolStripMenuItem18.Name = "toolStripMenuItem18";
            this.toolStripMenuItem18.Size = new System.Drawing.Size(196, 22);
            this.toolStripMenuItem18.Text = "Save Program Settings";
            // 
            // resetSettingsToolStripMenuItem
            // 
            this.resetSettingsToolStripMenuItem.Image = global::MultiScad.MenuIcons.refresh;
            this.resetSettingsToolStripMenuItem.Name = "resetSettingsToolStripMenuItem";
            this.resetSettingsToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.resetSettingsToolStripMenuItem.Text = "Reset Export Settings";
            // 
            // readMeToolStripMenuItem
            // 
            this.readMeToolStripMenuItem.Image = global::MultiScad.MenuIcons.readme;
            this.readMeToolStripMenuItem.Name = "readMeToolStripMenuItem";
            this.readMeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.readMeToolStripMenuItem.Text = "Read Me";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::MultiScad.MenuIcons.about;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            // 
            // lithophaneSettingsPage
            // 
            this.lithophaneSettingsPage.Location = new System.Drawing.Point(4, 22);
            this.lithophaneSettingsPage.Name = "lithophaneSettingsPage";
            this.lithophaneSettingsPage.Size = new System.Drawing.Size(654, 264);
            this.lithophaneSettingsPage.TabIndex = 6;
            this.lithophaneSettingsPage.Text = "Lithophane";
            this.lithophaneSettingsPage.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.polygonSizePage);
            this.tabControl1.Controls.Add(this.polygonLayerPage);
            this.tabControl1.Controls.Add(this.polygonExportPage);
            this.tabControl1.Location = new System.Drawing.Point(7, 7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(370, 250);
            this.tabControl1.TabIndex = 2;
            // 
            // polygonSizePage
            // 
            this.polygonSizePage.Controls.Add(this.label13);
            this.polygonSizePage.Controls.Add(this.label9);
            this.polygonSizePage.Controls.Add(this.polygonSecondaryHeightSlider);
            this.polygonSizePage.Controls.Add(this.polygonPrimaryHeightTxt);
            this.polygonSizePage.Controls.Add(this.polygonSecondaryHeightTxt);
            this.polygonSizePage.Controls.Add(this.polygonPrimaryHeightSlider);
            this.polygonSizePage.Controls.Add(this.label14);
            this.polygonSizePage.Controls.Add(this.label10);
            this.polygonSizePage.Location = new System.Drawing.Point(4, 22);
            this.polygonSizePage.Name = "polygonSizePage";
            this.polygonSizePage.Padding = new System.Windows.Forms.Padding(3);
            this.polygonSizePage.Size = new System.Drawing.Size(362, 224);
            this.polygonSizePage.TabIndex = 0;
            this.polygonSizePage.Text = "Size Settings";
            this.polygonSizePage.UseVisualStyleBackColor = true;
            // 
            // polygonLayerPage
            // 
            this.polygonLayerPage.Location = new System.Drawing.Point(4, 22);
            this.polygonLayerPage.Name = "polygonLayerPage";
            this.polygonLayerPage.Padding = new System.Windows.Forms.Padding(3);
            this.polygonLayerPage.Size = new System.Drawing.Size(362, 224);
            this.polygonLayerPage.TabIndex = 1;
            this.polygonLayerPage.Text = "Layer Settings";
            this.polygonLayerPage.UseVisualStyleBackColor = true;
            // 
            // polygonExportPage
            // 
            this.polygonExportPage.Location = new System.Drawing.Point(4, 22);
            this.polygonExportPage.Name = "polygonExportPage";
            this.polygonExportPage.Size = new System.Drawing.Size(362, 224);
            this.polygonExportPage.TabIndex = 2;
            this.polygonExportPage.Text = "Export Settings";
            this.polygonExportPage.UseVisualStyleBackColor = true;
            // 
            // layersMenuBtn
            // 
            this.layersMenuBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.layersMenuBtn.BackColor = System.Drawing.SystemColors.Control;
            this.layersMenuBtn.Checked = true;
            this.layersMenuBtn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.layersMenuBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.layersMenuBtn.DoubleClickEnabled = true;
            this.layersMenuBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LayersPinned});
            this.layersMenuBtn.Name = "layersMenuBtn";
            this.layersMenuBtn.Size = new System.Drawing.Size(84, 20);
            this.layersMenuBtn.Text = "Show Layers";
            this.layersMenuBtn.ToolTipText = "Double Click to Hide/Show Layer Form";
            this.layersMenuBtn.DoubleClick += new System.EventHandler(this.layersMenuBtn_Click_1);
            this.layersMenuBtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.layersMenuBtn_MouseMove);
            // 
            // LayersPinned
            // 
            this.LayersPinned.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.LayersPinned.Name = "LayersPinned";
            this.LayersPinned.Size = new System.Drawing.Size(180, 22);
            this.LayersPinned.Text = "Pinned to Window";
            // 
            // layersInformationBox
            // 
            this.layersInformationBox.Controls.Add(this.textBox1);
            this.layersInformationBox.Location = new System.Drawing.Point(8, 143);
            this.layersInformationBox.Name = "layersInformationBox";
            this.layersInformationBox.Size = new System.Drawing.Size(182, 50);
            this.layersInformationBox.TabIndex = 20;
            this.layersInformationBox.TabStop = false;
            this.layersInformationBox.Text = "Layers Information";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(169, 20);
            this.textBox1.TabIndex = 0;
            // 
            // reopenDropdown
            // 
            this.reopenDropdown.FormattingEnabled = true;
            this.reopenDropdown.Location = new System.Drawing.Point(8, 18);
            this.reopenDropdown.Name = "reopenDropdown";
            this.reopenDropdown.Size = new System.Drawing.Size(356, 21);
            this.reopenDropdown.TabIndex = 6;
            this.reopenDropdown.SelectedValueChanged += new System.EventHandler(this.reopenDropdown_SelectedValueChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 315);
            this.Controls.Add(this.SettingTabsList);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "MultiScad";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.cleanupTemp);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.LocationChanged += new System.EventHandler(this.MainForm_LocationChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.SettingTabsList.ResumeLayout(false);
            this.mainSettingsPage.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.polygonSettingsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.polygonSecondaryHeightSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.polygonPrimaryHeightSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.polygonSizePage.ResumeLayout(false);
            this.polygonSizePage.PerformLayout();
            this.layersInformationBox.ResumeLayout(false);
            this.layersInformationBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
        private System.Windows.Forms.ToolStripMenuItem inkscapeStatus;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem16;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem17;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem18;
        private System.Windows.Forms.ToolStripMenuItem inkscapeBit;
        private System.Windows.Forms.ToolStripMenuItem inkscapeVersion;
        private System.Windows.Forms.TabControl SettingTabsList;
        private System.Windows.Forms.TabPage mainSettingsPage;
        private System.Windows.Forms.TabPage polygonSettingsPage;
        private System.Windows.Forms.TabPage bookmarkSettingsPage;
        private System.Windows.Forms.TabPage formCutterSettingsPage;
        private System.Windows.Forms.TabPage keychainSettingsPage;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button exportAllBtn;
        private System.Windows.Forms.TextBox polygonPrimaryHeightTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar polygonPrimaryHeightSlider;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TrackBar polygonSecondaryHeightSlider;
        private System.Windows.Forms.TextBox polygonSecondaryHeightTxt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox svgFileMD5;
        private System.Windows.Forms.TextBox svgFileName;
        private System.Windows.Forms.Button openSVGBtn;
        private System.Windows.Forms.Button openFileLocationBtn;
        private System.Windows.Forms.Button copyFileLocationBtn;
        private System.Windows.Forms.TabPage badgeSettingsPage;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage polygonSizePage;
        private System.Windows.Forms.TabPage polygonLayerPage;
        private System.Windows.Forms.TabPage polygonExportPage;
        private System.Windows.Forms.TabPage lithophaneSettingsPage;
        private System.Windows.Forms.ToolStripMenuItem LayersPinned;
        private System.Windows.Forms.ToolStripMenuItem layersMenuBtn;
        private System.Windows.Forms.GroupBox layersInformationBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox reopenDropdown;
    }
}
