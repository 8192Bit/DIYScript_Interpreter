
namespace DIYScript_Interpreter
{
    public partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.saveFileDialogPj = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.File = new System.Windows.Forms.ToolStripDropDownButton();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Option = new System.Windows.Forms.ToolStripDropDownButton();
            this.首选项ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Help = new System.Windows.Forms.ToolStripDropDownButton();
            this.程序帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Run = new System.Windows.Forms.ToolStripButton();
            this.imageListOBJSmall = new System.Windows.Forms.ImageList(this.components);
            this.groupBoxBG = new System.Windows.Forms.GroupBox();
            this.buttonNormalBG = new System.Windows.Forms.Button();
            this.buttonRefreshBG = new System.Windows.Forms.Button();
            this.buttonDeleteBG = new System.Windows.Forms.Button();
            this.buttonNewBG = new System.Windows.Forms.Button();
            this.listViewBG = new System.Windows.Forms.ListView();
            this.imageListBGLarge = new System.Windows.Forms.ImageList(this.components);
            this.imageListBGSmall = new System.Windows.Forms.ImageList(this.components);
            this.groupBoxOBJ = new System.Windows.Forms.GroupBox();
            this.buttonRefreshOBJ = new System.Windows.Forms.Button();
            this.buttonEditOBJ = new System.Windows.Forms.Button();
            this.buttonDelOBJ = new System.Windows.Forms.Button();
            this.buttonNewOBJ = new System.Windows.Forms.Button();
            this.listViewOBJ = new System.Windows.Forms.ListView();
            this.imageListOBJLarge = new System.Windows.Forms.ImageList(this.components);
            this.groupBoxAIBGMMdata = new System.Windows.Forms.GroupBox();
            this.tabControlAIOBJMdata = new System.Windows.Forms.TabControl();
            this.AI = new System.Windows.Forms.TabPage();
            this.groupBoxAction = new System.Windows.Forms.GroupBox();
            this.tabControlA = new System.Windows.Forms.TabControl();
            this.ATravel = new System.Windows.Forms.TabPage();
            this.comboBoxTSpeed = new System.Windows.Forms.ComboBox();
            this.pictureBoxTS = new System.Windows.Forms.PictureBox();
            this.tabControlT = new System.Windows.Forms.TabControl();
            this.tabPageTPosition = new System.Windows.Forms.TabPage();
            this.tabPageTOBJPosition = new System.Windows.Forms.TabPage();
            this.buttonTOOBJChoose = new System.Windows.Forms.Button();
            this.tabPageTDirection = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.tabPageTRoaming = new System.Windows.Forms.TabPage();
            this.comboBoxTRTType = new System.Windows.Forms.ComboBox();
            this.tabPageTStop = new System.Windows.Forms.TabPage();
            this.comboBoxTTType = new System.Windows.Forms.ComboBox();
            this.AArt = new System.Windows.Forms.TabPage();
            this.AWinLose = new System.Windows.Forms.TabPage();
            this.checkBoxWL = new System.Windows.Forms.CheckBox();
            this.AVfx = new System.Windows.Forms.TabPage();
            this.ASfx = new System.Windows.Forms.TabPage();
            this.ASwitch = new System.Windows.Forms.TabPage();
            this.checkBoxSONOFF = new System.Windows.Forms.CheckBox();
            this.radioButtonSD = new System.Windows.Forms.RadioButton();
            this.radioButtonSC = new System.Windows.Forms.RadioButton();
            this.radioButtonSB = new System.Windows.Forms.RadioButton();
            this.radioButtonSA = new System.Windows.Forms.RadioButton();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.listBoxAction = new System.Windows.Forms.ListBox();
            this.buttonAOK = new System.Windows.Forms.Button();
            this.groupBoxWhen = new System.Windows.Forms.GroupBox();
            this.tabControlC = new System.Windows.Forms.TabControl();
            this.CTap = new System.Windows.Forms.TabPage();
            this.pictureBoxCS = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioButtonTapSE = new System.Windows.Forms.RadioButton();
            this.radioButtonTapE = new System.Windows.Forms.RadioButton();
            this.radioButtonTapNE = new System.Windows.Forms.RadioButton();
            this.radioButtonTapSW = new System.Windows.Forms.RadioButton();
            this.radioButtonTapW = new System.Windows.Forms.RadioButton();
            this.radioButtonTapNW = new System.Windows.Forms.RadioButton();
            this.radioButtonTapS = new System.Windows.Forms.RadioButton();
            this.radioButtonTapN = new System.Windows.Forms.RadioButton();
            this.comboBoxClickSlide = new System.Windows.Forms.ComboBox();
            this.checkBoxArea = new System.Windows.Forms.CheckBox();
            this.CContact = new System.Windows.Forms.TabPage();
            this.CArt = new System.Windows.Forms.TabPage();
            this.CTime = new System.Windows.Forms.TabPage();
            this.checkBoxTISRandom = new System.Windows.Forms.CheckBox();
            this.trackBarTTO = new System.Windows.Forms.TrackBar();
            this.trackBarTTFROM = new System.Windows.Forms.TrackBar();
            this.CSwitch = new System.Windows.Forms.TabPage();
            this.buttonCSChoose = new System.Windows.Forms.Button();
            this.radioButtonCSD = new System.Windows.Forms.RadioButton();
            this.radioButtonCSC = new System.Windows.Forms.RadioButton();
            this.radioButtonCSB = new System.Windows.Forms.RadioButton();
            this.radioButtonCSA = new System.Windows.Forms.RadioButton();
            this.comboBoxST = new System.Windows.Forms.ComboBox();
            this.CWonLoss = new System.Windows.Forms.TabPage();
            this.comboBoxWL = new System.Windows.Forms.ComboBox();
            this.buttonCDel = new System.Windows.Forms.Button();
            this.buttonCAdd = new System.Windows.Forms.Button();
            this.buttonCDown = new System.Windows.Forms.Button();
            this.buttonCUp = new System.Windows.Forms.Button();
            this.listBoxCondition = new System.Windows.Forms.ListBox();
            this.buttonCOK = new System.Windows.Forms.Button();
            this.labelOBJName = new System.Windows.Forms.Label();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.labelScriptsList = new System.Windows.Forms.Label();
            this.pictureBoxOBJPic = new System.Windows.Forms.PictureBox();
            this.listBoxScript = new System.Windows.Forms.ListBox();
            this.BGM = new System.Windows.Forms.TabPage();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.buttonEditBGM = new System.Windows.Forms.Button();
            this.buttonDelBGM = new System.Windows.Forms.Button();
            this.buttonNewBGM = new System.Windows.Forms.Button();
            this.listViewBGM = new System.Windows.Forms.ListView();
            this.Metadata = new System.Windows.Forms.TabPage();
            this.labelTimeSet = new System.Windows.Forms.Label();
            this.maskedTextBoxTime = new System.Windows.Forms.MaskedTextBox();
            this.checkBoxTimeBOSS = new System.Windows.Forms.CheckBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.radioButtonSpeedS = new System.Windows.Forms.RadioButton();
            this.radioButtonSpeedM = new System.Windows.Forms.RadioButton();
            this.radioButtonSpeedQ = new System.Windows.Forms.RadioButton();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.labelComment = new System.Windows.Forms.Label();
            this.textBoxGameName = new System.Windows.Forms.TextBox();
            this.labelGameName = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogPj = new System.Windows.Forms.OpenFileDialog();
            this.NUT = new System.Windows.Forms.Button();
            this.toolStrip.SuspendLayout();
            this.groupBoxBG.SuspendLayout();
            this.groupBoxOBJ.SuspendLayout();
            this.groupBoxAIBGMMdata.SuspendLayout();
            this.tabControlAIOBJMdata.SuspendLayout();
            this.AI.SuspendLayout();
            this.groupBoxAction.SuspendLayout();
            this.tabControlA.SuspendLayout();
            this.ATravel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTS)).BeginInit();
            this.tabControlT.SuspendLayout();
            this.tabPageTOBJPosition.SuspendLayout();
            this.tabPageTDirection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPageTRoaming.SuspendLayout();
            this.AWinLose.SuspendLayout();
            this.ASwitch.SuspendLayout();
            this.groupBoxWhen.SuspendLayout();
            this.tabControlC.SuspendLayout();
            this.CTap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.CTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTTO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTTFROM)).BeginInit();
            this.CSwitch.SuspendLayout();
            this.CWonLoss.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOBJPic)).BeginInit();
            this.BGM.SuspendLayout();
            this.Metadata.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveFileDialogPj
            // 
            this.saveFileDialogPj.DefaultExt = "p42";
            this.saveFileDialogPj.Filter = "MakerMatic 42/DIYScript Interpreter 项目文件|*.p42|所有文件|*.*";
            this.saveFileDialogPj.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_FileOk);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File,
            this.Option,
            this.Help,
            this.toolStripSeparator1,
            this.Run});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1488, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip_ItemClicked);
            // 
            // File
            // 
            this.File.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.保存ToolStripMenuItem,
            this.打开ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.File.Image = ((System.Drawing.Image)(resources.GetObject("File.Image")));
            this.File.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(45, 22);
            this.File.Text = "文件";
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.保存ToolStripMenuItem.Text = "保存...";
            this.保存ToolStripMenuItem.Click += new System.EventHandler(this.保存ToolStripMenuItem_Click);
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.打开ToolStripMenuItem.Text = "打开...";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // Option
            // 
            this.Option.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Option.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.首选项ToolStripMenuItem});
            this.Option.Image = ((System.Drawing.Image)(resources.GetObject("Option.Image")));
            this.Option.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Option.Name = "Option";
            this.Option.Size = new System.Drawing.Size(45, 22);
            this.Option.Text = "选项";
            // 
            // 首选项ToolStripMenuItem
            // 
            this.首选项ToolStripMenuItem.Name = "首选项ToolStripMenuItem";
            this.首选项ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.首选项ToolStripMenuItem.Text = "首选项";
            this.首选项ToolStripMenuItem.Click += new System.EventHandler(this.首选项ToolStripMenuItem_Click);
            // 
            // Help
            // 
            this.Help.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.程序帮助ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.Help.Image = ((System.Drawing.Image)(resources.GetObject("Help.Image")));
            this.Help.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(45, 22);
            this.Help.Text = "帮助";
            // 
            // 程序帮助ToolStripMenuItem
            // 
            this.程序帮助ToolStripMenuItem.Name = "程序帮助ToolStripMenuItem";
            this.程序帮助ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.程序帮助ToolStripMenuItem.Text = "程序帮助";
            this.程序帮助ToolStripMenuItem.Click += new System.EventHandler(this.程序帮助ToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // Run
            // 
            this.Run.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Run.Image = ((System.Drawing.Image)(resources.GetObject("Run.Image")));
            this.Run.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(40, 22);
            this.Run.Text = "运行!";
            this.Run.Click += new System.EventHandler(this.NUT_Click);
            // 
            // imageListOBJSmall
            // 
            this.imageListOBJSmall.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageListOBJSmall.ImageSize = new System.Drawing.Size(32, 32);
            this.imageListOBJSmall.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // groupBoxBG
            // 
            this.groupBoxBG.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBoxBG.Controls.Add(this.buttonNormalBG);
            this.groupBoxBG.Controls.Add(this.buttonRefreshBG);
            this.groupBoxBG.Controls.Add(this.buttonDeleteBG);
            this.groupBoxBG.Controls.Add(this.buttonNewBG);
            this.groupBoxBG.Controls.Add(this.listViewBG);
            this.groupBoxBG.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBoxBG.Location = new System.Drawing.Point(1210, 28);
            this.groupBoxBG.Name = "groupBoxBG";
            this.groupBoxBG.Size = new System.Drawing.Size(265, 303);
            this.groupBoxBG.TabIndex = 8;
            this.groupBoxBG.TabStop = false;
            this.groupBoxBG.Text = "背景";
            // 
            // buttonNormalBG
            // 
            this.buttonNormalBG.Enabled = false;
            this.buttonNormalBG.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonNormalBG.FlatAppearance.BorderSize = 5;
            this.buttonNormalBG.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonNormalBG.Location = new System.Drawing.Point(172, 265);
            this.buttonNormalBG.Name = "buttonNormalBG";
            this.buttonNormalBG.Size = new System.Drawing.Size(87, 31);
            this.buttonNormalBG.TabIndex = 7;
            this.buttonNormalBG.Text = "设为默认背景";
            this.buttonNormalBG.UseVisualStyleBackColor = false;
            this.buttonNormalBG.Click += new System.EventHandler(this.buttonNormalBG_Click);
            // 
            // buttonRefreshBG
            // 
            this.buttonRefreshBG.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRefreshBG.BackgroundImage")));
            this.buttonRefreshBG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRefreshBG.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonRefreshBG.FlatAppearance.BorderSize = 5;
            this.buttonRefreshBG.Location = new System.Drawing.Point(6, 17);
            this.buttonRefreshBG.Name = "buttonRefreshBG";
            this.buttonRefreshBG.Size = new System.Drawing.Size(25, 25);
            this.buttonRefreshBG.TabIndex = 6;
            this.buttonRefreshBG.UseVisualStyleBackColor = true;
            this.buttonRefreshBG.Click += new System.EventHandler(this.buttonRefreshBG_Click);
            // 
            // buttonDeleteBG
            // 
            this.buttonDeleteBG.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonDeleteBG.FlatAppearance.BorderSize = 5;
            this.buttonDeleteBG.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonDeleteBG.Location = new System.Drawing.Point(89, 265);
            this.buttonDeleteBG.Name = "buttonDeleteBG";
            this.buttonDeleteBG.Size = new System.Drawing.Size(77, 31);
            this.buttonDeleteBG.TabIndex = 4;
            this.buttonDeleteBG.Text = "删除";
            this.buttonDeleteBG.UseVisualStyleBackColor = false;
            this.buttonDeleteBG.Click += new System.EventHandler(this.buttonDeleteBG_Click);
            // 
            // buttonNewBG
            // 
            this.buttonNewBG.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonNewBG.FlatAppearance.BorderSize = 5;
            this.buttonNewBG.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonNewBG.Location = new System.Drawing.Point(6, 265);
            this.buttonNewBG.Name = "buttonNewBG";
            this.buttonNewBG.Size = new System.Drawing.Size(77, 31);
            this.buttonNewBG.TabIndex = 3;
            this.buttonNewBG.Text = "新建";
            this.buttonNewBG.UseVisualStyleBackColor = false;
            this.buttonNewBG.Click += new System.EventHandler(this.buttonNewBG_Click);
            // 
            // listViewBG
            // 
            this.listViewBG.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listViewBG.HideSelection = false;
            this.listViewBG.LargeImageList = this.imageListBGLarge;
            this.listViewBG.Location = new System.Drawing.Point(6, 45);
            this.listViewBG.Name = "listViewBG";
            this.listViewBG.Size = new System.Drawing.Size(253, 215);
            this.listViewBG.SmallImageList = this.imageListBGSmall;
            this.listViewBG.TabIndex = 2;
            this.listViewBG.UseCompatibleStateImageBehavior = false;
            this.listViewBG.SelectedIndexChanged += new System.EventHandler(this.listViewBG_SelectedIndexChanged);
            // 
            // imageListBGLarge
            // 
            this.imageListBGLarge.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageListBGLarge.ImageSize = new System.Drawing.Size(64, 48);
            this.imageListBGLarge.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageListBGSmall
            // 
            this.imageListBGSmall.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageListBGSmall.ImageSize = new System.Drawing.Size(32, 24);
            this.imageListBGSmall.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // groupBoxOBJ
            // 
            this.groupBoxOBJ.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBoxOBJ.Controls.Add(this.buttonRefreshOBJ);
            this.groupBoxOBJ.Controls.Add(this.buttonEditOBJ);
            this.groupBoxOBJ.Controls.Add(this.buttonDelOBJ);
            this.groupBoxOBJ.Controls.Add(this.buttonNewOBJ);
            this.groupBoxOBJ.Controls.Add(this.listViewOBJ);
            this.groupBoxOBJ.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBoxOBJ.Location = new System.Drawing.Point(823, 28);
            this.groupBoxOBJ.Name = "groupBoxOBJ";
            this.groupBoxOBJ.Size = new System.Drawing.Size(381, 541);
            this.groupBoxOBJ.TabIndex = 7;
            this.groupBoxOBJ.TabStop = false;
            this.groupBoxOBJ.Text = "对象";
            // 
            // buttonRefreshOBJ
            // 
            this.buttonRefreshOBJ.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRefreshOBJ.BackgroundImage")));
            this.buttonRefreshOBJ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRefreshOBJ.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonRefreshOBJ.FlatAppearance.BorderSize = 5;
            this.buttonRefreshOBJ.Location = new System.Drawing.Point(6, 17);
            this.buttonRefreshOBJ.Name = "buttonRefreshOBJ";
            this.buttonRefreshOBJ.Size = new System.Drawing.Size(24, 25);
            this.buttonRefreshOBJ.TabIndex = 7;
            this.buttonRefreshOBJ.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonRefreshOBJ.UseVisualStyleBackColor = true;
            this.buttonRefreshOBJ.Click += new System.EventHandler(this.buttonRefreshOBJ_Click);
            // 
            // buttonEditOBJ
            // 
            this.buttonEditOBJ.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonEditOBJ.FlatAppearance.BorderSize = 5;
            this.buttonEditOBJ.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonEditOBJ.Location = new System.Drawing.Point(257, 497);
            this.buttonEditOBJ.Name = "buttonEditOBJ";
            this.buttonEditOBJ.Size = new System.Drawing.Size(118, 38);
            this.buttonEditOBJ.TabIndex = 5;
            this.buttonEditOBJ.Text = "编辑";
            this.buttonEditOBJ.UseVisualStyleBackColor = false;
            this.buttonEditOBJ.Click += new System.EventHandler(this.buttonEditOBJ_Click);
            // 
            // buttonDelOBJ
            // 
            this.buttonDelOBJ.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonDelOBJ.FlatAppearance.BorderSize = 5;
            this.buttonDelOBJ.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonDelOBJ.Location = new System.Drawing.Point(133, 497);
            this.buttonDelOBJ.Name = "buttonDelOBJ";
            this.buttonDelOBJ.Size = new System.Drawing.Size(118, 38);
            this.buttonDelOBJ.TabIndex = 4;
            this.buttonDelOBJ.Text = "删除";
            this.buttonDelOBJ.UseVisualStyleBackColor = false;
            this.buttonDelOBJ.Click += new System.EventHandler(this.buttonDelOBJ_Click);
            // 
            // buttonNewOBJ
            // 
            this.buttonNewOBJ.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonNewOBJ.FlatAppearance.BorderSize = 5;
            this.buttonNewOBJ.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonNewOBJ.Location = new System.Drawing.Point(9, 497);
            this.buttonNewOBJ.Name = "buttonNewOBJ";
            this.buttonNewOBJ.Size = new System.Drawing.Size(118, 38);
            this.buttonNewOBJ.TabIndex = 3;
            this.buttonNewOBJ.Text = "新建";
            this.buttonNewOBJ.UseVisualStyleBackColor = false;
            this.buttonNewOBJ.Click += new System.EventHandler(this.buttonNewOBJ_Click_1);
            // 
            // listViewOBJ
            // 
            this.listViewOBJ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listViewOBJ.HideSelection = false;
            this.listViewOBJ.LargeImageList = this.imageListOBJLarge;
            this.listViewOBJ.Location = new System.Drawing.Point(6, 45);
            this.listViewOBJ.Name = "listViewOBJ";
            this.listViewOBJ.Size = new System.Drawing.Size(369, 446);
            this.listViewOBJ.SmallImageList = this.imageListOBJSmall;
            this.listViewOBJ.TabIndex = 2;
            this.listViewOBJ.UseCompatibleStateImageBehavior = false;
            this.listViewOBJ.SelectedIndexChanged += new System.EventHandler(this.listViewOBJ_SelectedIndexChanged);
            // 
            // imageListOBJLarge
            // 
            this.imageListOBJLarge.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageListOBJLarge.ImageSize = new System.Drawing.Size(64, 64);
            this.imageListOBJLarge.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // groupBoxAIBGMMdata
            // 
            this.groupBoxAIBGMMdata.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBoxAIBGMMdata.Controls.Add(this.tabControlAIOBJMdata);
            this.groupBoxAIBGMMdata.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBoxAIBGMMdata.Location = new System.Drawing.Point(12, 28);
            this.groupBoxAIBGMMdata.Name = "groupBoxAIBGMMdata";
            this.groupBoxAIBGMMdata.Size = new System.Drawing.Size(805, 541);
            this.groupBoxAIBGMMdata.TabIndex = 9;
            this.groupBoxAIBGMMdata.TabStop = false;
            this.groupBoxAIBGMMdata.Text = "脚本,音乐与元数据";
            // 
            // tabControlAIOBJMdata
            // 
            this.tabControlAIOBJMdata.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlAIOBJMdata.Controls.Add(this.AI);
            this.tabControlAIOBJMdata.Controls.Add(this.BGM);
            this.tabControlAIOBJMdata.Controls.Add(this.Metadata);
            this.tabControlAIOBJMdata.Location = new System.Drawing.Point(6, 20);
            this.tabControlAIOBJMdata.Name = "tabControlAIOBJMdata";
            this.tabControlAIOBJMdata.SelectedIndex = 0;
            this.tabControlAIOBJMdata.Size = new System.Drawing.Size(793, 515);
            this.tabControlAIOBJMdata.TabIndex = 0;
            // 
            // AI
            // 
            this.AI.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AI.Controls.Add(this.groupBoxAction);
            this.AI.Controls.Add(this.groupBoxWhen);
            this.AI.Controls.Add(this.labelOBJName);
            this.AI.Controls.Add(this.buttonDel);
            this.AI.Controls.Add(this.buttonAdd);
            this.AI.Controls.Add(this.buttonDown);
            this.AI.Controls.Add(this.buttonUp);
            this.AI.Controls.Add(this.labelScriptsList);
            this.AI.Controls.Add(this.pictureBoxOBJPic);
            this.AI.Controls.Add(this.listBoxScript);
            this.AI.ForeColor = System.Drawing.Color.Black;
            this.AI.Location = new System.Drawing.Point(4, 22);
            this.AI.Name = "AI";
            this.AI.Padding = new System.Windows.Forms.Padding(3);
            this.AI.Size = new System.Drawing.Size(785, 489);
            this.AI.TabIndex = 0;
            this.AI.Text = "脚本";
            this.AI.Click += new System.EventHandler(this.AI_Click);
            // 
            // groupBoxAction
            // 
            this.groupBoxAction.Controls.Add(this.tabControlA);
            this.groupBoxAction.Controls.Add(this.button4);
            this.groupBoxAction.Controls.Add(this.button5);
            this.groupBoxAction.Controls.Add(this.button6);
            this.groupBoxAction.Controls.Add(this.button7);
            this.groupBoxAction.Controls.Add(this.listBoxAction);
            this.groupBoxAction.Controls.Add(this.buttonAOK);
            this.groupBoxAction.Location = new System.Drawing.Point(216, 276);
            this.groupBoxAction.Name = "groupBoxAction";
            this.groupBoxAction.Size = new System.Drawing.Size(563, 202);
            this.groupBoxAction.TabIndex = 9;
            this.groupBoxAction.TabStop = false;
            this.groupBoxAction.Text = "做......";
            // 
            // tabControlA
            // 
            this.tabControlA.Controls.Add(this.ATravel);
            this.tabControlA.Controls.Add(this.AArt);
            this.tabControlA.Controls.Add(this.AWinLose);
            this.tabControlA.Controls.Add(this.AVfx);
            this.tabControlA.Controls.Add(this.ASfx);
            this.tabControlA.Controls.Add(this.ASwitch);
            this.tabControlA.Location = new System.Drawing.Point(177, 20);
            this.tabControlA.Name = "tabControlA";
            this.tabControlA.SelectedIndex = 0;
            this.tabControlA.Size = new System.Drawing.Size(347, 172);
            this.tabControlA.TabIndex = 16;
            // 
            // ATravel
            // 
            this.ATravel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ATravel.Controls.Add(this.comboBoxTSpeed);
            this.ATravel.Controls.Add(this.pictureBoxTS);
            this.ATravel.Controls.Add(this.tabControlT);
            this.ATravel.Controls.Add(this.comboBoxTTType);
            this.ATravel.Location = new System.Drawing.Point(4, 22);
            this.ATravel.Name = "ATravel";
            this.ATravel.Padding = new System.Windows.Forms.Padding(3);
            this.ATravel.Size = new System.Drawing.Size(339, 146);
            this.ATravel.TabIndex = 0;
            this.ATravel.Text = "运动";
            this.ATravel.UseVisualStyleBackColor = true;
            // 
            // comboBoxTSpeed
            // 
            this.comboBoxTSpeed.AutoCompleteCustomSource.AddRange(new string[] {
            "触摸",
            "滑动"});
            this.comboBoxTSpeed.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboBoxTSpeed.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxTSpeed.FormattingEnabled = true;
            this.comboBoxTSpeed.Items.AddRange(new object[] {
            "慢",
            "较慢",
            "中等",
            "较快",
            "快"});
            this.comboBoxTSpeed.Location = new System.Drawing.Point(165, 5);
            this.comboBoxTSpeed.Name = "comboBoxTSpeed";
            this.comboBoxTSpeed.Size = new System.Drawing.Size(121, 20);
            this.comboBoxTSpeed.TabIndex = 13;
            this.comboBoxTSpeed.Text = "运动速度";
            // 
            // pictureBoxTS
            // 
            this.pictureBoxTS.Location = new System.Drawing.Point(7, 3);
            this.pictureBoxTS.Name = "pictureBoxTS";
            this.pictureBoxTS.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxTS.TabIndex = 12;
            this.pictureBoxTS.TabStop = false;
            // 
            // tabControlT
            // 
            this.tabControlT.Controls.Add(this.tabPageTPosition);
            this.tabControlT.Controls.Add(this.tabPageTOBJPosition);
            this.tabControlT.Controls.Add(this.tabPageTDirection);
            this.tabControlT.Controls.Add(this.tabPageTRoaming);
            this.tabControlT.Controls.Add(this.tabPageTStop);
            this.tabControlT.Location = new System.Drawing.Point(7, 32);
            this.tabControlT.Multiline = true;
            this.tabControlT.Name = "tabControlT";
            this.tabControlT.SelectedIndex = 0;
            this.tabControlT.Size = new System.Drawing.Size(326, 108);
            this.tabControlT.TabIndex = 3;
            this.tabControlT.TabIndexChanged += new System.EventHandler(this.tabControlT_TabIndexChanged);
            this.tabControlT.Click += new System.EventHandler(this.tabControlT_TabIndexChanged);
            // 
            // tabPageTPosition
            // 
            this.tabPageTPosition.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPageTPosition.Location = new System.Drawing.Point(4, 22);
            this.tabPageTPosition.Name = "tabPageTPosition";
            this.tabPageTPosition.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTPosition.Size = new System.Drawing.Size(318, 82);
            this.tabPageTPosition.TabIndex = 0;
            this.tabPageTPosition.Text = "位置";
            this.tabPageTPosition.UseVisualStyleBackColor = true;
            // 
            // tabPageTOBJPosition
            // 
            this.tabPageTOBJPosition.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPageTOBJPosition.Controls.Add(this.buttonTOOBJChoose);
            this.tabPageTOBJPosition.Location = new System.Drawing.Point(4, 22);
            this.tabPageTOBJPosition.Name = "tabPageTOBJPosition";
            this.tabPageTOBJPosition.Size = new System.Drawing.Size(318, 82);
            this.tabPageTOBJPosition.TabIndex = 4;
            this.tabPageTOBJPosition.Text = "OBJ";
            this.tabPageTOBJPosition.UseVisualStyleBackColor = true;
            // 
            // buttonTOOBJChoose
            // 
            this.buttonTOOBJChoose.Location = new System.Drawing.Point(3, 3);
            this.buttonTOOBJChoose.Name = "buttonTOOBJChoose";
            this.buttonTOOBJChoose.Size = new System.Drawing.Size(75, 23);
            this.buttonTOOBJChoose.TabIndex = 9;
            this.buttonTOOBJChoose.Text = "选择OBJ";
            this.buttonTOOBJChoose.UseVisualStyleBackColor = true;
            this.buttonTOOBJChoose.Click += new System.EventHandler(this.buttonTOOBJChoose_Click);
            // 
            // tabPageTDirection
            // 
            this.tabPageTDirection.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPageTDirection.Controls.Add(this.pictureBox2);
            this.tabPageTDirection.Controls.Add(this.radioButton1);
            this.tabPageTDirection.Controls.Add(this.radioButton2);
            this.tabPageTDirection.Controls.Add(this.radioButton3);
            this.tabPageTDirection.Controls.Add(this.radioButton4);
            this.tabPageTDirection.Controls.Add(this.radioButton5);
            this.tabPageTDirection.Controls.Add(this.radioButton6);
            this.tabPageTDirection.Controls.Add(this.radioButton7);
            this.tabPageTDirection.Controls.Add(this.radioButton8);
            this.tabPageTDirection.Location = new System.Drawing.Point(4, 22);
            this.tabPageTDirection.Name = "tabPageTDirection";
            this.tabPageTDirection.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTDirection.Size = new System.Drawing.Size(318, 82);
            this.tabPageTDirection.TabIndex = 1;
            this.tabPageTDirection.Text = "方向";
            this.tabPageTDirection.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DIYScript_Interpreter.Properties.Resources.Sides;
            this.pictureBox2.Location = new System.Drawing.Point(38, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 21);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // radioButton1
            // 
            this.radioButton1.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(70, 54);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(27, 22);
            this.radioButton1.TabIndex = 18;
            this.radioButton1.Text = "↘";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(70, 27);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(27, 22);
            this.radioButton2.TabIndex = 17;
            this.radioButton2.Text = "→";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(70, 0);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(27, 22);
            this.radioButton3.TabIndex = 16;
            this.radioButton3.Text = "↗";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 54);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(27, 22);
            this.radioButton4.TabIndex = 15;
            this.radioButton4.Text = "↙";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(6, 27);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(27, 22);
            this.radioButton5.TabIndex = 14;
            this.radioButton5.Text = "←";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(6, 0);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(27, 22);
            this.radioButton6.TabIndex = 13;
            this.radioButton6.Text = "↖";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(38, 54);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(27, 22);
            this.radioButton7.TabIndex = 12;
            this.radioButton7.Text = "↓";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton8.AutoSize = true;
            this.radioButton8.Checked = true;
            this.radioButton8.Location = new System.Drawing.Point(38, 0);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(27, 22);
            this.radioButton8.TabIndex = 11;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "↑";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // tabPageTRoaming
            // 
            this.tabPageTRoaming.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPageTRoaming.Controls.Add(this.comboBoxTRTType);
            this.tabPageTRoaming.Location = new System.Drawing.Point(4, 22);
            this.tabPageTRoaming.Name = "tabPageTRoaming";
            this.tabPageTRoaming.Size = new System.Drawing.Size(318, 82);
            this.tabPageTRoaming.TabIndex = 3;
            this.tabPageTRoaming.Text = "漫游";
            this.tabPageTRoaming.UseVisualStyleBackColor = true;
            // 
            // comboBoxTRTType
            // 
            this.comboBoxTRTType.AutoCompleteCustomSource.AddRange(new string[] {
            "触摸",
            "滑动"});
            this.comboBoxTRTType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboBoxTRTType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxTRTType.FormattingEnabled = true;
            this.comboBoxTRTType.Items.AddRange(new object[] {
            "震动",
            "随机",
            "反弹",
            "弹跳"});
            this.comboBoxTRTType.Location = new System.Drawing.Point(103, 29);
            this.comboBoxTRTType.Name = "comboBoxTRTType";
            this.comboBoxTRTType.Size = new System.Drawing.Size(121, 20);
            this.comboBoxTRTType.TabIndex = 14;
            this.comboBoxTRTType.Text = "漫游类型";
            // 
            // tabPageTStop
            // 
            this.tabPageTStop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPageTStop.Location = new System.Drawing.Point(4, 22);
            this.tabPageTStop.Name = "tabPageTStop";
            this.tabPageTStop.Size = new System.Drawing.Size(318, 82);
            this.tabPageTStop.TabIndex = 2;
            this.tabPageTStop.Text = "停止";
            this.tabPageTStop.UseVisualStyleBackColor = true;
            // 
            // comboBoxTTType
            // 
            this.comboBoxTTType.AutoCompleteCustomSource.AddRange(new string[] {
            "触摸",
            "滑动"});
            this.comboBoxTTType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboBoxTTType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxTTType.FormattingEnabled = true;
            this.comboBoxTTType.Items.AddRange(new object[] {
            "无",
            "线性",
            "快速",
            "缓慢",
            "平滑",
            "停留"});
            this.comboBoxTTType.Location = new System.Drawing.Point(38, 5);
            this.comboBoxTTType.Name = "comboBoxTTType";
            this.comboBoxTTType.Size = new System.Drawing.Size(121, 20);
            this.comboBoxTTType.TabIndex = 2;
            this.comboBoxTTType.Text = "运动类型";
            this.comboBoxTTType.SelectedIndexChanged += new System.EventHandler(this.comboBoxTTType_SelectedIndexChanged);
            // 
            // AArt
            // 
            this.AArt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AArt.Location = new System.Drawing.Point(4, 22);
            this.AArt.Name = "AArt";
            this.AArt.Size = new System.Drawing.Size(339, 146);
            this.AArt.TabIndex = 2;
            this.AArt.Text = "形象";
            this.AArt.UseVisualStyleBackColor = true;
            // 
            // AWinLose
            // 
            this.AWinLose.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AWinLose.Controls.Add(this.checkBoxWL);
            this.AWinLose.Location = new System.Drawing.Point(4, 22);
            this.AWinLose.Name = "AWinLose";
            this.AWinLose.Size = new System.Drawing.Size(339, 146);
            this.AWinLose.TabIndex = 3;
            this.AWinLose.Text = "成功/失败";
            this.AWinLose.UseVisualStyleBackColor = true;
            // 
            // checkBoxWL
            // 
            this.checkBoxWL.AutoSize = true;
            this.checkBoxWL.Checked = true;
            this.checkBoxWL.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxWL.Location = new System.Drawing.Point(149, 67);
            this.checkBoxWL.Name = "checkBoxWL";
            this.checkBoxWL.Size = new System.Drawing.Size(48, 16);
            this.checkBoxWL.TabIndex = 0;
            this.checkBoxWL.Text = "成功";
            this.checkBoxWL.UseVisualStyleBackColor = true;
            this.checkBoxWL.CheckedChanged += new System.EventHandler(this.checkBoxWL_CheckedChanged);
            // 
            // AVfx
            // 
            this.AVfx.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AVfx.Location = new System.Drawing.Point(4, 22);
            this.AVfx.Name = "AVfx";
            this.AVfx.Size = new System.Drawing.Size(339, 146);
            this.AVfx.TabIndex = 4;
            this.AVfx.Text = "视觉效果";
            this.AVfx.UseVisualStyleBackColor = true;
            // 
            // ASfx
            // 
            this.ASfx.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ASfx.Location = new System.Drawing.Point(4, 22);
            this.ASfx.Name = "ASfx";
            this.ASfx.Size = new System.Drawing.Size(339, 146);
            this.ASfx.TabIndex = 5;
            this.ASfx.Text = "听觉效果";
            this.ASfx.UseVisualStyleBackColor = true;
            // 
            // ASwitch
            // 
            this.ASwitch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ASwitch.Controls.Add(this.checkBoxSONOFF);
            this.ASwitch.Controls.Add(this.radioButtonSD);
            this.ASwitch.Controls.Add(this.radioButtonSC);
            this.ASwitch.Controls.Add(this.radioButtonSB);
            this.ASwitch.Controls.Add(this.radioButtonSA);
            this.ASwitch.Location = new System.Drawing.Point(4, 22);
            this.ASwitch.Name = "ASwitch";
            this.ASwitch.Size = new System.Drawing.Size(339, 146);
            this.ASwitch.TabIndex = 1;
            this.ASwitch.Text = "开关";
            this.ASwitch.UseVisualStyleBackColor = true;
            // 
            // checkBoxSONOFF
            // 
            this.checkBoxSONOFF.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxSONOFF.AutoSize = true;
            this.checkBoxSONOFF.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxSONOFF.Image = ((System.Drawing.Image)(resources.GetObject("checkBoxSONOFF.Image")));
            this.checkBoxSONOFF.Location = new System.Drawing.Point(154, 81);
            this.checkBoxSONOFF.Name = "checkBoxSONOFF";
            this.checkBoxSONOFF.Size = new System.Drawing.Size(39, 38);
            this.checkBoxSONOFF.TabIndex = 4;
            this.checkBoxSONOFF.Text = "    ";
            this.checkBoxSONOFF.UseVisualStyleBackColor = true;
            this.checkBoxSONOFF.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // radioButtonSD
            // 
            this.radioButtonSD.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonSD.AutoSize = true;
            this.radioButtonSD.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButtonSD.Location = new System.Drawing.Point(273, 19);
            this.radioButtonSD.Name = "radioButtonSD";
            this.radioButtonSD.Size = new System.Drawing.Size(31, 31);
            this.radioButtonSD.TabIndex = 3;
            this.radioButtonSD.Text = "D";
            this.radioButtonSD.UseVisualStyleBackColor = true;
            // 
            // radioButtonSC
            // 
            this.radioButtonSC.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonSC.AutoSize = true;
            this.radioButtonSC.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButtonSC.Location = new System.Drawing.Point(193, 19);
            this.radioButtonSC.Name = "radioButtonSC";
            this.radioButtonSC.Size = new System.Drawing.Size(31, 31);
            this.radioButtonSC.TabIndex = 2;
            this.radioButtonSC.Text = "C";
            this.radioButtonSC.UseVisualStyleBackColor = true;
            // 
            // radioButtonSB
            // 
            this.radioButtonSB.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonSB.AutoSize = true;
            this.radioButtonSB.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButtonSB.Location = new System.Drawing.Point(113, 19);
            this.radioButtonSB.Name = "radioButtonSB";
            this.radioButtonSB.Size = new System.Drawing.Size(31, 31);
            this.radioButtonSB.TabIndex = 1;
            this.radioButtonSB.Text = "B";
            this.radioButtonSB.UseVisualStyleBackColor = true;
            // 
            // radioButtonSA
            // 
            this.radioButtonSA.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonSA.AutoSize = true;
            this.radioButtonSA.Checked = true;
            this.radioButtonSA.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButtonSA.Location = new System.Drawing.Point(33, 19);
            this.radioButtonSA.Name = "radioButtonSA";
            this.radioButtonSA.Size = new System.Drawing.Size(31, 31);
            this.radioButtonSA.TabIndex = 0;
            this.radioButtonSA.TabStop = true;
            this.radioButtonSA.Text = "A";
            this.radioButtonSA.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.Location = new System.Drawing.Point(147, 107);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(23, 23);
            this.button4.TabIndex = 15;
            this.button4.Text = "-";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button5.Location = new System.Drawing.Point(147, 78);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(23, 23);
            this.button5.TabIndex = 14;
            this.button5.Text = "+";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button6.Location = new System.Drawing.Point(147, 49);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(23, 23);
            this.button6.TabIndex = 13;
            this.button6.Text = "▽";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button7.Location = new System.Drawing.Point(147, 20);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(23, 23);
            this.button7.TabIndex = 12;
            this.button7.Text = "△";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // listBoxAction
            // 
            this.listBoxAction.FormattingEnabled = true;
            this.listBoxAction.ItemHeight = 12;
            this.listBoxAction.Items.AddRange(new object[] {
            " "});
            this.listBoxAction.Location = new System.Drawing.Point(6, 20);
            this.listBoxAction.Name = "listBoxAction";
            this.listBoxAction.Size = new System.Drawing.Size(135, 172);
            this.listBoxAction.TabIndex = 11;
            // 
            // buttonAOK
            // 
            this.buttonAOK.Font = new System.Drawing.Font("宋体", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonAOK.Location = new System.Drawing.Point(488, 45);
            this.buttonAOK.Name = "buttonAOK";
            this.buttonAOK.Size = new System.Drawing.Size(56, 143);
            this.buttonAOK.TabIndex = 13;
            this.buttonAOK.Text = "OK";
            this.buttonAOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAOK.UseVisualStyleBackColor = true;
            // 
            // groupBoxWhen
            // 
            this.groupBoxWhen.Controls.Add(this.tabControlC);
            this.groupBoxWhen.Controls.Add(this.buttonCDel);
            this.groupBoxWhen.Controls.Add(this.buttonCAdd);
            this.groupBoxWhen.Controls.Add(this.buttonCDown);
            this.groupBoxWhen.Controls.Add(this.buttonCUp);
            this.groupBoxWhen.Controls.Add(this.listBoxCondition);
            this.groupBoxWhen.Controls.Add(this.buttonCOK);
            this.groupBoxWhen.Location = new System.Drawing.Point(216, 114);
            this.groupBoxWhen.Name = "groupBoxWhen";
            this.groupBoxWhen.Size = new System.Drawing.Size(563, 156);
            this.groupBoxWhen.TabIndex = 8;
            this.groupBoxWhen.TabStop = false;
            this.groupBoxWhen.Text = "当......";
            this.groupBoxWhen.Enter += new System.EventHandler(this.groupBoxWhen_Enter);
            // 
            // tabControlC
            // 
            this.tabControlC.Controls.Add(this.CTap);
            this.tabControlC.Controls.Add(this.CContact);
            this.tabControlC.Controls.Add(this.CArt);
            this.tabControlC.Controls.Add(this.CTime);
            this.tabControlC.Controls.Add(this.CSwitch);
            this.tabControlC.Controls.Add(this.CWonLoss);
            this.tabControlC.Location = new System.Drawing.Point(177, 20);
            this.tabControlC.Name = "tabControlC";
            this.tabControlC.SelectedIndex = 0;
            this.tabControlC.Size = new System.Drawing.Size(347, 124);
            this.tabControlC.TabIndex = 11;
            // 
            // CTap
            // 
            this.CTap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CTap.Controls.Add(this.pictureBoxCS);
            this.CTap.Controls.Add(this.pictureBox1);
            this.CTap.Controls.Add(this.radioButtonTapSE);
            this.CTap.Controls.Add(this.radioButtonTapE);
            this.CTap.Controls.Add(this.radioButtonTapNE);
            this.CTap.Controls.Add(this.radioButtonTapSW);
            this.CTap.Controls.Add(this.radioButtonTapW);
            this.CTap.Controls.Add(this.radioButtonTapNW);
            this.CTap.Controls.Add(this.radioButtonTapS);
            this.CTap.Controls.Add(this.radioButtonTapN);
            this.CTap.Controls.Add(this.comboBoxClickSlide);
            this.CTap.Controls.Add(this.checkBoxArea);
            this.CTap.Location = new System.Drawing.Point(4, 22);
            this.CTap.Name = "CTap";
            this.CTap.Padding = new System.Windows.Forms.Padding(3);
            this.CTap.Size = new System.Drawing.Size(339, 98);
            this.CTap.TabIndex = 1;
            this.CTap.Text = "触摸";
            this.CTap.UseVisualStyleBackColor = true;
            this.CTap.Click += new System.EventHandler(this.CTap_Click);
            // 
            // pictureBoxCS
            // 
            this.pictureBoxCS.Location = new System.Drawing.Point(7, 7);
            this.pictureBoxCS.Name = "pictureBoxCS";
            this.pictureBoxCS.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxCS.TabIndex = 11;
            this.pictureBoxCS.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DIYScript_Interpreter.Properties.Resources.Sides;
            this.pictureBox1.Location = new System.Drawing.Point(251, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // radioButtonTapSE
            // 
            this.radioButtonTapSE.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonTapSE.AutoSize = true;
            this.radioButtonTapSE.Location = new System.Drawing.Point(283, 63);
            this.radioButtonTapSE.Name = "radioButtonTapSE";
            this.radioButtonTapSE.Size = new System.Drawing.Size(27, 22);
            this.radioButtonTapSE.TabIndex = 9;
            this.radioButtonTapSE.TabStop = true;
            this.radioButtonTapSE.Text = "↘";
            this.radioButtonTapSE.UseVisualStyleBackColor = true;
            // 
            // radioButtonTapE
            // 
            this.radioButtonTapE.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonTapE.AutoSize = true;
            this.radioButtonTapE.Location = new System.Drawing.Point(283, 36);
            this.radioButtonTapE.Name = "radioButtonTapE";
            this.radioButtonTapE.Size = new System.Drawing.Size(27, 22);
            this.radioButtonTapE.TabIndex = 8;
            this.radioButtonTapE.TabStop = true;
            this.radioButtonTapE.Text = "→";
            this.radioButtonTapE.UseVisualStyleBackColor = true;
            this.radioButtonTapE.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // radioButtonTapNE
            // 
            this.radioButtonTapNE.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonTapNE.AutoSize = true;
            this.radioButtonTapNE.Location = new System.Drawing.Point(283, 9);
            this.radioButtonTapNE.Name = "radioButtonTapNE";
            this.radioButtonTapNE.Size = new System.Drawing.Size(27, 22);
            this.radioButtonTapNE.TabIndex = 7;
            this.radioButtonTapNE.TabStop = true;
            this.radioButtonTapNE.Text = "↗";
            this.radioButtonTapNE.UseVisualStyleBackColor = true;
            this.radioButtonTapNE.CheckedChanged += new System.EventHandler(this.radioButtonTapNE_CheckedChanged);
            // 
            // radioButtonTapSW
            // 
            this.radioButtonTapSW.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonTapSW.AutoSize = true;
            this.radioButtonTapSW.Location = new System.Drawing.Point(219, 63);
            this.radioButtonTapSW.Name = "radioButtonTapSW";
            this.radioButtonTapSW.Size = new System.Drawing.Size(27, 22);
            this.radioButtonTapSW.TabIndex = 6;
            this.radioButtonTapSW.TabStop = true;
            this.radioButtonTapSW.Text = "↙";
            this.radioButtonTapSW.UseVisualStyleBackColor = true;
            this.radioButtonTapSW.CheckedChanged += new System.EventHandler(this.radioButtonTapSW_CheckedChanged);
            // 
            // radioButtonTapW
            // 
            this.radioButtonTapW.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonTapW.AutoSize = true;
            this.radioButtonTapW.Location = new System.Drawing.Point(219, 36);
            this.radioButtonTapW.Name = "radioButtonTapW";
            this.radioButtonTapW.Size = new System.Drawing.Size(27, 22);
            this.radioButtonTapW.TabIndex = 5;
            this.radioButtonTapW.TabStop = true;
            this.radioButtonTapW.Text = "←";
            this.radioButtonTapW.UseVisualStyleBackColor = true;
            this.radioButtonTapW.CheckedChanged += new System.EventHandler(this.radioButtonTapW_CheckedChanged);
            // 
            // radioButtonTapNW
            // 
            this.radioButtonTapNW.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonTapNW.AutoSize = true;
            this.radioButtonTapNW.Location = new System.Drawing.Point(219, 9);
            this.radioButtonTapNW.Name = "radioButtonTapNW";
            this.radioButtonTapNW.Size = new System.Drawing.Size(27, 22);
            this.radioButtonTapNW.TabIndex = 4;
            this.radioButtonTapNW.TabStop = true;
            this.radioButtonTapNW.Text = "↖";
            this.radioButtonTapNW.UseVisualStyleBackColor = true;
            this.radioButtonTapNW.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButtonTapS
            // 
            this.radioButtonTapS.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonTapS.AutoSize = true;
            this.radioButtonTapS.Location = new System.Drawing.Point(251, 63);
            this.radioButtonTapS.Name = "radioButtonTapS";
            this.radioButtonTapS.Size = new System.Drawing.Size(27, 22);
            this.radioButtonTapS.TabIndex = 3;
            this.radioButtonTapS.TabStop = true;
            this.radioButtonTapS.Text = "↓";
            this.radioButtonTapS.UseVisualStyleBackColor = true;
            // 
            // radioButtonTapN
            // 
            this.radioButtonTapN.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonTapN.AutoSize = true;
            this.radioButtonTapN.Location = new System.Drawing.Point(251, 9);
            this.radioButtonTapN.Name = "radioButtonTapN";
            this.radioButtonTapN.Size = new System.Drawing.Size(27, 22);
            this.radioButtonTapN.TabIndex = 2;
            this.radioButtonTapN.TabStop = true;
            this.radioButtonTapN.Text = "↑";
            this.radioButtonTapN.UseVisualStyleBackColor = true;
            this.radioButtonTapN.CheckedChanged += new System.EventHandler(this.radioButtonTapN_CheckedChanged);
            // 
            // comboBoxClickSlide
            // 
            this.comboBoxClickSlide.AutoCompleteCustomSource.AddRange(new string[] {
            "触摸",
            "滑动"});
            this.comboBoxClickSlide.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboBoxClickSlide.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxClickSlide.FormattingEnabled = true;
            this.comboBoxClickSlide.Items.AddRange(new object[] {
            "触摸",
            "滑动"});
            this.comboBoxClickSlide.Location = new System.Drawing.Point(38, 9);
            this.comboBoxClickSlide.Name = "comboBoxClickSlide";
            this.comboBoxClickSlide.Size = new System.Drawing.Size(121, 20);
            this.comboBoxClickSlide.TabIndex = 1;
            this.comboBoxClickSlide.Text = "触摸方式";
            this.comboBoxClickSlide.SelectedIndexChanged += new System.EventHandler(this.comboBoxClickSlide_SelectedIndexChanged);
            // 
            // checkBoxArea
            // 
            this.checkBoxArea.AutoSize = true;
            this.checkBoxArea.Checked = true;
            this.checkBoxArea.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxArea.Location = new System.Drawing.Point(7, 33);
            this.checkBoxArea.Name = "checkBoxArea";
            this.checkBoxArea.Size = new System.Drawing.Size(54, 16);
            this.checkBoxArea.TabIndex = 0;
            this.checkBoxArea.Text = "此OBJ";
            this.checkBoxArea.UseVisualStyleBackColor = true;
            this.checkBoxArea.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // CContact
            // 
            this.CContact.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CContact.Location = new System.Drawing.Point(4, 22);
            this.CContact.Name = "CContact";
            this.CContact.Size = new System.Drawing.Size(339, 98);
            this.CContact.TabIndex = 5;
            this.CContact.Text = "接触";
            this.CContact.UseVisualStyleBackColor = true;
            // 
            // CArt
            // 
            this.CArt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CArt.Location = new System.Drawing.Point(4, 22);
            this.CArt.Name = "CArt";
            this.CArt.Size = new System.Drawing.Size(339, 98);
            this.CArt.TabIndex = 3;
            this.CArt.Text = "形象";
            this.CArt.UseVisualStyleBackColor = true;
            // 
            // CTime
            // 
            this.CTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CTime.Controls.Add(this.checkBoxTISRandom);
            this.CTime.Controls.Add(this.trackBarTTO);
            this.CTime.Controls.Add(this.trackBarTTFROM);
            this.CTime.Location = new System.Drawing.Point(4, 22);
            this.CTime.Name = "CTime";
            this.CTime.Size = new System.Drawing.Size(339, 98);
            this.CTime.TabIndex = 2;
            this.CTime.Text = "时间";
            this.CTime.UseVisualStyleBackColor = true;
            // 
            // checkBoxTISRandom
            // 
            this.checkBoxTISRandom.AutoSize = true;
            this.checkBoxTISRandom.Location = new System.Drawing.Point(29, 7);
            this.checkBoxTISRandom.Name = "checkBoxTISRandom";
            this.checkBoxTISRandom.Size = new System.Drawing.Size(72, 16);
            this.checkBoxTISRandom.TabIndex = 2;
            this.checkBoxTISRandom.Text = "准确时间";
            this.checkBoxTISRandom.UseVisualStyleBackColor = true;
            this.checkBoxTISRandom.CheckedChanged += new System.EventHandler(this.checkBoxTISRandom_CheckedChanged);
            // 
            // trackBarTTO
            // 
            this.trackBarTTO.Enabled = false;
            this.trackBarTTO.Location = new System.Drawing.Point(29, 65);
            this.trackBarTTO.Name = "trackBarTTO";
            this.trackBarTTO.Size = new System.Drawing.Size(289, 45);
            this.trackBarTTO.TabIndex = 1;
            this.trackBarTTO.Scroll += new System.EventHandler(this.trackBarTTO_Scroll);
            // 
            // trackBarTTFROM
            // 
            this.trackBarTTFROM.Location = new System.Drawing.Point(29, 36);
            this.trackBarTTFROM.Name = "trackBarTTFROM";
            this.trackBarTTFROM.Size = new System.Drawing.Size(289, 45);
            this.trackBarTTFROM.TabIndex = 0;
            this.trackBarTTFROM.Scroll += new System.EventHandler(this.trackBarTTO_Scroll);
            // 
            // CSwitch
            // 
            this.CSwitch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CSwitch.Controls.Add(this.buttonCSChoose);
            this.CSwitch.Controls.Add(this.radioButtonCSD);
            this.CSwitch.Controls.Add(this.radioButtonCSC);
            this.CSwitch.Controls.Add(this.radioButtonCSB);
            this.CSwitch.Controls.Add(this.radioButtonCSA);
            this.CSwitch.Controls.Add(this.comboBoxST);
            this.CSwitch.Location = new System.Drawing.Point(4, 22);
            this.CSwitch.Name = "CSwitch";
            this.CSwitch.Size = new System.Drawing.Size(339, 98);
            this.CSwitch.TabIndex = 4;
            this.CSwitch.Text = "开关";
            this.CSwitch.UseVisualStyleBackColor = true;
            // 
            // buttonCSChoose
            // 
            this.buttonCSChoose.Location = new System.Drawing.Point(69, 27);
            this.buttonCSChoose.Name = "buttonCSChoose";
            this.buttonCSChoose.Size = new System.Drawing.Size(75, 23);
            this.buttonCSChoose.TabIndex = 8;
            this.buttonCSChoose.Text = "选择OBJ";
            this.buttonCSChoose.UseVisualStyleBackColor = true;
            this.buttonCSChoose.Click += new System.EventHandler(this.buttonCSChoose_Click);
            // 
            // radioButtonCSD
            // 
            this.radioButtonCSD.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonCSD.AutoSize = true;
            this.radioButtonCSD.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButtonCSD.Location = new System.Drawing.Point(222, 28);
            this.radioButtonCSD.Name = "radioButtonCSD";
            this.radioButtonCSD.Size = new System.Drawing.Size(21, 22);
            this.radioButtonCSD.TabIndex = 7;
            this.radioButtonCSD.Text = "D";
            this.radioButtonCSD.UseVisualStyleBackColor = true;
            // 
            // radioButtonCSC
            // 
            this.radioButtonCSC.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonCSC.AutoSize = true;
            this.radioButtonCSC.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButtonCSC.Location = new System.Drawing.Point(198, 28);
            this.radioButtonCSC.Name = "radioButtonCSC";
            this.radioButtonCSC.Size = new System.Drawing.Size(21, 22);
            this.radioButtonCSC.TabIndex = 6;
            this.radioButtonCSC.Text = "C";
            this.radioButtonCSC.UseVisualStyleBackColor = true;
            // 
            // radioButtonCSB
            // 
            this.radioButtonCSB.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonCSB.AutoSize = true;
            this.radioButtonCSB.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButtonCSB.Location = new System.Drawing.Point(174, 28);
            this.radioButtonCSB.Name = "radioButtonCSB";
            this.radioButtonCSB.Size = new System.Drawing.Size(21, 22);
            this.radioButtonCSB.TabIndex = 5;
            this.radioButtonCSB.Text = "B";
            this.radioButtonCSB.UseVisualStyleBackColor = true;
            // 
            // radioButtonCSA
            // 
            this.radioButtonCSA.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonCSA.AutoSize = true;
            this.radioButtonCSA.Checked = true;
            this.radioButtonCSA.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButtonCSA.Location = new System.Drawing.Point(150, 28);
            this.radioButtonCSA.Name = "radioButtonCSA";
            this.radioButtonCSA.Size = new System.Drawing.Size(21, 22);
            this.radioButtonCSA.TabIndex = 4;
            this.radioButtonCSA.TabStop = true;
            this.radioButtonCSA.Text = "A";
            this.radioButtonCSA.UseVisualStyleBackColor = true;
            // 
            // comboBoxST
            // 
            this.comboBoxST.FormattingEnabled = true;
            this.comboBoxST.Items.AddRange(new object[] {
            "打开了",
            "打开时",
            "关上了",
            "关上时"});
            this.comboBoxST.Location = new System.Drawing.Point(69, 56);
            this.comboBoxST.Name = "comboBoxST";
            this.comboBoxST.Size = new System.Drawing.Size(174, 20);
            this.comboBoxST.TabIndex = 1;
            // 
            // CWonLoss
            // 
            this.CWonLoss.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CWonLoss.Controls.Add(this.comboBoxWL);
            this.CWonLoss.Location = new System.Drawing.Point(4, 22);
            this.CWonLoss.Name = "CWonLoss";
            this.CWonLoss.Size = new System.Drawing.Size(339, 98);
            this.CWonLoss.TabIndex = 6;
            this.CWonLoss.Text = "成功/失败";
            this.CWonLoss.UseVisualStyleBackColor = true;
            // 
            // comboBoxWL
            // 
            this.comboBoxWL.FormattingEnabled = true;
            this.comboBoxWL.Items.AddRange(new object[] {
            "成功",
            "已成功",
            "尚未成功",
            "失败",
            "已失败",
            "尚未失败"});
            this.comboBoxWL.Location = new System.Drawing.Point(96, 39);
            this.comboBoxWL.Name = "comboBoxWL";
            this.comboBoxWL.Size = new System.Drawing.Size(154, 20);
            this.comboBoxWL.TabIndex = 0;
            // 
            // buttonCDel
            // 
            this.buttonCDel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonCDel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonCDel.Location = new System.Drawing.Point(147, 107);
            this.buttonCDel.Name = "buttonCDel";
            this.buttonCDel.Size = new System.Drawing.Size(23, 23);
            this.buttonCDel.TabIndex = 10;
            this.buttonCDel.Text = "-";
            this.buttonCDel.UseVisualStyleBackColor = true;
            // 
            // buttonCAdd
            // 
            this.buttonCAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonCAdd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonCAdd.Location = new System.Drawing.Point(147, 78);
            this.buttonCAdd.Name = "buttonCAdd";
            this.buttonCAdd.Size = new System.Drawing.Size(23, 23);
            this.buttonCAdd.TabIndex = 9;
            this.buttonCAdd.Text = "+";
            this.buttonCAdd.UseVisualStyleBackColor = true;
            this.buttonCAdd.Click += new System.EventHandler(this.buttonCAdd_Click);
            // 
            // buttonCDown
            // 
            this.buttonCDown.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonCDown.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonCDown.Location = new System.Drawing.Point(147, 49);
            this.buttonCDown.Name = "buttonCDown";
            this.buttonCDown.Size = new System.Drawing.Size(23, 23);
            this.buttonCDown.TabIndex = 8;
            this.buttonCDown.Text = "▽";
            this.buttonCDown.UseVisualStyleBackColor = true;
            // 
            // buttonCUp
            // 
            this.buttonCUp.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonCUp.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonCUp.Location = new System.Drawing.Point(147, 20);
            this.buttonCUp.Name = "buttonCUp";
            this.buttonCUp.Size = new System.Drawing.Size(23, 23);
            this.buttonCUp.TabIndex = 7;
            this.buttonCUp.Text = "△";
            this.buttonCUp.UseVisualStyleBackColor = true;
            // 
            // listBoxCondition
            // 
            this.listBoxCondition.FormattingEnabled = true;
            this.listBoxCondition.ItemHeight = 12;
            this.listBoxCondition.Items.AddRange(new object[] {
            " "});
            this.listBoxCondition.Location = new System.Drawing.Point(6, 20);
            this.listBoxCondition.Name = "listBoxCondition";
            this.listBoxCondition.Size = new System.Drawing.Size(135, 124);
            this.listBoxCondition.TabIndex = 1;
            // 
            // buttonCOK
            // 
            this.buttonCOK.Font = new System.Drawing.Font("宋体", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonCOK.Location = new System.Drawing.Point(488, 45);
            this.buttonCOK.Name = "buttonCOK";
            this.buttonCOK.Size = new System.Drawing.Size(56, 95);
            this.buttonCOK.TabIndex = 12;
            this.buttonCOK.Text = "OK";
            this.buttonCOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCOK.UseVisualStyleBackColor = true;
            this.buttonCOK.Click += new System.EventHandler(this.buttonCOK_Click);
            // 
            // labelOBJName
            // 
            this.labelOBJName.AutoSize = true;
            this.labelOBJName.Font = new System.Drawing.Font("宋体", 32F);
            this.labelOBJName.Location = new System.Drawing.Point(103, 7);
            this.labelOBJName.Name = "labelOBJName";
            this.labelOBJName.Size = new System.Drawing.Size(234, 43);
            this.labelOBJName.TabIndex = 7;
            this.labelOBJName.Text = "未选中对象";
            this.labelOBJName.Click += new System.EventHandler(this.labelOBJName_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonDel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonDel.Location = new System.Drawing.Point(187, 201);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(23, 23);
            this.buttonDel.TabIndex = 6;
            this.buttonDel.Text = "-";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonAdd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonAdd.Location = new System.Drawing.Point(187, 172);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(23, 23);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonDown.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonDown.Location = new System.Drawing.Point(187, 143);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(23, 23);
            this.buttonDown.TabIndex = 4;
            this.buttonDown.Text = "▽";
            this.buttonDown.UseVisualStyleBackColor = true;
            // 
            // buttonUp
            // 
            this.buttonUp.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonUp.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonUp.Location = new System.Drawing.Point(187, 114);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(23, 23);
            this.buttonUp.TabIndex = 3;
            this.buttonUp.Text = "△";
            this.buttonUp.UseVisualStyleBackColor = true;
            // 
            // labelScriptsList
            // 
            this.labelScriptsList.AutoSize = true;
            this.labelScriptsList.Location = new System.Drawing.Point(6, 99);
            this.labelScriptsList.Name = "labelScriptsList";
            this.labelScriptsList.Size = new System.Drawing.Size(53, 12);
            this.labelScriptsList.TabIndex = 2;
            this.labelScriptsList.Text = "脚本列表";
            // 
            // pictureBoxOBJPic
            // 
            this.pictureBoxOBJPic.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxOBJPic.Image")));
            this.pictureBoxOBJPic.Location = new System.Drawing.Point(6, 6);
            this.pictureBoxOBJPic.Name = "pictureBoxOBJPic";
            this.pictureBoxOBJPic.Size = new System.Drawing.Size(90, 90);
            this.pictureBoxOBJPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxOBJPic.TabIndex = 1;
            this.pictureBoxOBJPic.TabStop = false;
            // 
            // listBoxScript
            // 
            this.listBoxScript.FormattingEnabled = true;
            this.listBoxScript.ItemHeight = 12;
            this.listBoxScript.Items.AddRange(new object[] {
            " "});
            this.listBoxScript.Location = new System.Drawing.Point(6, 114);
            this.listBoxScript.Name = "listBoxScript";
            this.listBoxScript.Size = new System.Drawing.Size(175, 364);
            this.listBoxScript.TabIndex = 0;
            // 
            // BGM
            // 
            this.BGM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BGM.Controls.Add(this.linkLabel1);
            this.BGM.Controls.Add(this.buttonEditBGM);
            this.BGM.Controls.Add(this.buttonDelBGM);
            this.BGM.Controls.Add(this.buttonNewBGM);
            this.BGM.Controls.Add(this.listViewBGM);
            this.BGM.ForeColor = System.Drawing.Color.Black;
            this.BGM.Location = new System.Drawing.Point(4, 22);
            this.BGM.Name = "BGM";
            this.BGM.Padding = new System.Windows.Forms.Padding(3);
            this.BGM.Size = new System.Drawing.Size(785, 489);
            this.BGM.TabIndex = 1;
            this.BGM.Text = "音乐";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.linkLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.linkLabel1.Font = new System.Drawing.Font("宋体", 144F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel1.Location = new System.Drawing.Point(74, 135);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(658, 194);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "施工中";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // buttonEditBGM
            // 
            this.buttonEditBGM.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonEditBGM.Location = new System.Drawing.Point(242, 277);
            this.buttonEditBGM.Name = "buttonEditBGM";
            this.buttonEditBGM.Size = new System.Drawing.Size(112, 38);
            this.buttonEditBGM.TabIndex = 9;
            this.buttonEditBGM.Text = "编辑";
            this.buttonEditBGM.UseVisualStyleBackColor = true;
            // 
            // buttonDelBGM
            // 
            this.buttonDelBGM.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonDelBGM.Location = new System.Drawing.Point(124, 277);
            this.buttonDelBGM.Name = "buttonDelBGM";
            this.buttonDelBGM.Size = new System.Drawing.Size(112, 38);
            this.buttonDelBGM.TabIndex = 8;
            this.buttonDelBGM.Text = "删除";
            this.buttonDelBGM.UseVisualStyleBackColor = true;
            // 
            // buttonNewBGM
            // 
            this.buttonNewBGM.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonNewBGM.Location = new System.Drawing.Point(6, 276);
            this.buttonNewBGM.Name = "buttonNewBGM";
            this.buttonNewBGM.Size = new System.Drawing.Size(112, 38);
            this.buttonNewBGM.TabIndex = 7;
            this.buttonNewBGM.Text = "新建";
            this.buttonNewBGM.UseVisualStyleBackColor = true;
            // 
            // listViewBGM
            // 
            this.listViewBGM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listViewBGM.HideSelection = false;
            this.listViewBGM.Location = new System.Drawing.Point(6, 6);
            this.listViewBGM.Name = "listViewBGM";
            this.listViewBGM.Size = new System.Drawing.Size(773, 263);
            this.listViewBGM.TabIndex = 6;
            this.listViewBGM.UseCompatibleStateImageBehavior = false;
            // 
            // Metadata
            // 
            this.Metadata.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Metadata.Controls.Add(this.labelTimeSet);
            this.Metadata.Controls.Add(this.maskedTextBoxTime);
            this.Metadata.Controls.Add(this.checkBoxTimeBOSS);
            this.Metadata.Controls.Add(this.labelTime);
            this.Metadata.Controls.Add(this.radioButtonSpeedS);
            this.Metadata.Controls.Add(this.radioButtonSpeedM);
            this.Metadata.Controls.Add(this.radioButtonSpeedQ);
            this.Metadata.Controls.Add(this.labelSpeed);
            this.Metadata.Controls.Add(this.textBoxComment);
            this.Metadata.Controls.Add(this.labelComment);
            this.Metadata.Controls.Add(this.textBoxGameName);
            this.Metadata.Controls.Add(this.labelGameName);
            this.Metadata.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Metadata.ForeColor = System.Drawing.Color.Black;
            this.Metadata.Location = new System.Drawing.Point(4, 22);
            this.Metadata.Name = "Metadata";
            this.Metadata.Size = new System.Drawing.Size(785, 489);
            this.Metadata.TabIndex = 2;
            this.Metadata.Text = "元数据";
            // 
            // labelTimeSet
            // 
            this.labelTimeSet.AutoSize = true;
            this.labelTimeSet.Location = new System.Drawing.Point(167, 182);
            this.labelTimeSet.Name = "labelTimeSet";
            this.labelTimeSet.Size = new System.Drawing.Size(53, 12);
            this.labelTimeSet.TabIndex = 11;
            this.labelTimeSet.Text = "时间(ms)";
            // 
            // maskedTextBoxTime
            // 
            this.maskedTextBoxTime.Location = new System.Drawing.Point(226, 178);
            this.maskedTextBoxTime.Mask = "000000ms";
            this.maskedTextBoxTime.Name = "maskedTextBoxTime";
            this.maskedTextBoxTime.Size = new System.Drawing.Size(100, 21);
            this.maskedTextBoxTime.TabIndex = 10;
            // 
            // checkBoxTimeBOSS
            // 
            this.checkBoxTimeBOSS.AutoSize = true;
            this.checkBoxTimeBOSS.Location = new System.Drawing.Point(74, 180);
            this.checkBoxTimeBOSS.Name = "checkBoxTimeBOSS";
            this.checkBoxTimeBOSS.Size = new System.Drawing.Size(78, 16);
            this.checkBoxTimeBOSS.TabIndex = 9;
            this.checkBoxTimeBOSS.Text = "BOSS 关卡";
            this.checkBoxTimeBOSS.UseVisualStyleBackColor = true;
            this.checkBoxTimeBOSS.CheckedChanged += new System.EventHandler(this.checkBoxTimeBOSS_CheckedChanged);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(15, 181);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(53, 12);
            this.labelTime.TabIndex = 8;
            this.labelTime.Text = "持续时间";
            // 
            // radioButtonSpeedS
            // 
            this.radioButtonSpeedS.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonSpeedS.AutoSize = true;
            this.radioButtonSpeedS.Location = new System.Drawing.Point(141, 143);
            this.radioButtonSpeedS.Name = "radioButtonSpeedS";
            this.radioButtonSpeedS.Size = new System.Drawing.Size(27, 22);
            this.radioButtonSpeedS.TabIndex = 7;
            this.radioButtonSpeedS.TabStop = true;
            this.radioButtonSpeedS.Text = "慢";
            this.radioButtonSpeedS.UseVisualStyleBackColor = true;
            // 
            // radioButtonSpeedM
            // 
            this.radioButtonSpeedM.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonSpeedM.AutoSize = true;
            this.radioButtonSpeedM.Location = new System.Drawing.Point(108, 143);
            this.radioButtonSpeedM.Name = "radioButtonSpeedM";
            this.radioButtonSpeedM.Size = new System.Drawing.Size(27, 22);
            this.radioButtonSpeedM.TabIndex = 6;
            this.radioButtonSpeedM.TabStop = true;
            this.radioButtonSpeedM.Text = "中";
            this.radioButtonSpeedM.UseVisualStyleBackColor = true;
            // 
            // radioButtonSpeedQ
            // 
            this.radioButtonSpeedQ.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonSpeedQ.AutoSize = true;
            this.radioButtonSpeedQ.Location = new System.Drawing.Point(75, 143);
            this.radioButtonSpeedQ.Name = "radioButtonSpeedQ";
            this.radioButtonSpeedQ.Size = new System.Drawing.Size(27, 22);
            this.radioButtonSpeedQ.TabIndex = 5;
            this.radioButtonSpeedQ.TabStop = true;
            this.radioButtonSpeedQ.Text = "快";
            this.radioButtonSpeedQ.UseVisualStyleBackColor = true;
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(15, 148);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(53, 12);
            this.labelSpeed.TabIndex = 4;
            this.labelSpeed.Text = "游戏速度";
            // 
            // textBoxComment
            // 
            this.textBoxComment.Location = new System.Drawing.Point(75, 44);
            this.textBoxComment.Multiline = true;
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(696, 93);
            this.textBoxComment.TabIndex = 3;
            // 
            // labelComment
            // 
            this.labelComment.AutoSize = true;
            this.labelComment.Location = new System.Drawing.Point(15, 45);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(53, 12);
            this.labelComment.TabIndex = 2;
            this.labelComment.Text = "游戏简介";
            // 
            // textBoxGameName
            // 
            this.textBoxGameName.Location = new System.Drawing.Point(74, 16);
            this.textBoxGameName.Name = "textBoxGameName";
            this.textBoxGameName.Size = new System.Drawing.Size(697, 21);
            this.textBoxGameName.TabIndex = 1;
            // 
            // labelGameName
            // 
            this.labelGameName.AutoSize = true;
            this.labelGameName.Location = new System.Drawing.Point(15, 19);
            this.labelGameName.Name = "labelGameName";
            this.labelGameName.Size = new System.Drawing.Size(53, 12);
            this.labelGameName.TabIndex = 0;
            this.labelGameName.Text = "游戏名称";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "1145j141919810.bmp";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // openFileDialogPj
            // 
            this.openFileDialogPj.DefaultExt = "p42";
            this.openFileDialogPj.Filter = "MakerMatic 42/DIYScript Interpreter 项目文件|*.p42|所有文件|*.*";
            // 
            // NUT
            // 
            this.NUT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NUT.BackColor = System.Drawing.SystemColors.Window;
            this.NUT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.NUT.Font = new System.Drawing.Font("Calibri", 32F);
            this.NUT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(69)))), ((int)(((byte)(20)))));
            this.NUT.Location = new System.Drawing.Point(1216, 349);
            this.NUT.Name = "NUT";
            this.NUT.Size = new System.Drawing.Size(260, 220);
            this.NUT.TabIndex = 6;
            this.NUT.Text = "NUT";
            this.NUT.UseVisualStyleBackColor = true;
            this.NUT.Click += new System.EventHandler(this.NUT_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1488, 581);
            this.Controls.Add(this.groupBoxAIBGMMdata);
            this.Controls.Add(this.groupBoxBG);
            this.Controls.Add(this.groupBoxOBJ);
            this.Controls.Add(this.NUT);
            this.Controls.Add(this.toolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "DIYScript Interpreter [Document:unnamed]";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.groupBoxBG.ResumeLayout(false);
            this.groupBoxOBJ.ResumeLayout(false);
            this.groupBoxAIBGMMdata.ResumeLayout(false);
            this.tabControlAIOBJMdata.ResumeLayout(false);
            this.AI.ResumeLayout(false);
            this.AI.PerformLayout();
            this.groupBoxAction.ResumeLayout(false);
            this.tabControlA.ResumeLayout(false);
            this.ATravel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTS)).EndInit();
            this.tabControlT.ResumeLayout(false);
            this.tabPageTOBJPosition.ResumeLayout(false);
            this.tabPageTDirection.ResumeLayout(false);
            this.tabPageTDirection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPageTRoaming.ResumeLayout(false);
            this.AWinLose.ResumeLayout(false);
            this.AWinLose.PerformLayout();
            this.ASwitch.ResumeLayout(false);
            this.ASwitch.PerformLayout();
            this.groupBoxWhen.ResumeLayout(false);
            this.tabControlC.ResumeLayout(false);
            this.CTap.ResumeLayout(false);
            this.CTap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.CTime.ResumeLayout(false);
            this.CTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTTO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTTFROM)).EndInit();
            this.CSwitch.ResumeLayout(false);
            this.CSwitch.PerformLayout();
            this.CWonLoss.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOBJPic)).EndInit();
            this.BGM.ResumeLayout(false);
            this.BGM.PerformLayout();
            this.Metadata.ResumeLayout(false);
            this.Metadata.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SaveFileDialog saveFileDialogPj;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripDropDownButton Help;
        private System.Windows.Forms.ToolStripMenuItem 程序帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton File;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.Button NUT;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton Run;
        private System.Windows.Forms.ImageList imageListOBJSmall;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxBG;
        private System.Windows.Forms.Button buttonDeleteBG;
        private System.Windows.Forms.Button buttonNewBG;
        private System.Windows.Forms.ListView listViewBG;
        private System.Windows.Forms.GroupBox groupBoxOBJ;
        private System.Windows.Forms.Button buttonEditOBJ;
        private System.Windows.Forms.Button buttonDelOBJ;
        private System.Windows.Forms.Button buttonNewOBJ;
        private System.Windows.Forms.ListView listViewOBJ;
        private System.Windows.Forms.GroupBox groupBoxAIBGMMdata;
        private System.Windows.Forms.TabControl tabControlAIOBJMdata;
        private System.Windows.Forms.TabPage AI;
        private System.Windows.Forms.TabPage BGM;
        private System.Windows.Forms.Button buttonEditBGM;
        private System.Windows.Forms.Button buttonDelBGM;
        private System.Windows.Forms.Button buttonNewBGM;
        private System.Windows.Forms.ListView listViewBGM;
        private System.Windows.Forms.TabPage Metadata;
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.Label labelComment;
        private System.Windows.Forms.TextBox textBoxGameName;
        private System.Windows.Forms.Label labelGameName;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripDropDownButton Option;
        private System.Windows.Forms.Button buttonRefreshBG;
        private System.Windows.Forms.Button buttonRefreshOBJ;
        private System.Windows.Forms.ToolStripMenuItem 首选项ToolStripMenuItem;
        private System.Windows.Forms.ImageList imageListOBJLarge;
        private System.Windows.Forms.ImageList imageListBGSmall;
        private System.Windows.Forms.ImageList imageListBGLarge;
        private System.Windows.Forms.Label labelScriptsList;
        private System.Windows.Forms.PictureBox pictureBoxOBJPic;
        private System.Windows.Forms.ListBox listBoxScript;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Label labelOBJName;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.GroupBox groupBoxAction;
        private System.Windows.Forms.GroupBox groupBoxWhen;
        private System.Windows.Forms.ListBox listBoxCondition;
        private System.Windows.Forms.Button buttonCDel;
        private System.Windows.Forms.Button buttonCAdd;
        private System.Windows.Forms.Button buttonCDown;
        private System.Windows.Forms.Button buttonCUp;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ListBox listBoxAction;
        private System.Windows.Forms.Button buttonNormalBG;
        private System.Windows.Forms.OpenFileDialog openFileDialogPj;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.Label labelTimeSet;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTime;
        private System.Windows.Forms.CheckBox checkBoxTimeBOSS;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.RadioButton radioButtonSpeedS;
        private System.Windows.Forms.RadioButton radioButtonSpeedM;
        private System.Windows.Forms.RadioButton radioButtonSpeedQ;
        private System.Windows.Forms.Button buttonAOK;
        private System.Windows.Forms.TabControl tabControlA;
        private System.Windows.Forms.TabPage ATravel;
        private System.Windows.Forms.TabPage ASwitch;
        private System.Windows.Forms.TabPage AArt;
        private System.Windows.Forms.TabPage AWinLose;
        private System.Windows.Forms.TabPage AVfx;
        private System.Windows.Forms.TabPage ASfx;
        private System.Windows.Forms.Button buttonCOK;
        private System.Windows.Forms.TabControl tabControlC;
        private System.Windows.Forms.TabPage CTap;
        private System.Windows.Forms.TabPage CContact;
        private System.Windows.Forms.TabPage CArt;
        private System.Windows.Forms.TabPage CTime;
        private System.Windows.Forms.TabPage CSwitch;
        private System.Windows.Forms.TabPage CWonLoss;
        private System.Windows.Forms.ComboBox comboBoxClickSlide;
        private System.Windows.Forms.CheckBox checkBoxArea;
        private System.Windows.Forms.RadioButton radioButtonTapN;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.RadioButton radioButtonTapS;
        private System.Windows.Forms.RadioButton radioButtonTapSE;
        private System.Windows.Forms.RadioButton radioButtonTapE;
        private System.Windows.Forms.RadioButton radioButtonTapNE;
        private System.Windows.Forms.RadioButton radioButtonTapSW;
        private System.Windows.Forms.RadioButton radioButtonTapW;
        private System.Windows.Forms.RadioButton radioButtonTapNW;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxCS;
        private System.Windows.Forms.RadioButton radioButtonSD;
        private System.Windows.Forms.RadioButton radioButtonSC;
        private System.Windows.Forms.RadioButton radioButtonSB;
        private System.Windows.Forms.RadioButton radioButtonSA;
        private System.Windows.Forms.CheckBox checkBoxSONOFF;
        private System.Windows.Forms.CheckBox checkBoxTISRandom;
        private System.Windows.Forms.TrackBar trackBarTTO;
        private System.Windows.Forms.TrackBar trackBarTTFROM;
        private System.Windows.Forms.ComboBox comboBoxWL;
        private System.Windows.Forms.ComboBox comboBoxST;
        private System.Windows.Forms.CheckBox checkBoxWL;
        private System.Windows.Forms.PictureBox pictureBoxTS;
        private System.Windows.Forms.TabControl tabControlT;
        private System.Windows.Forms.TabPage tabPageTPosition;
        private System.Windows.Forms.TabPage tabPageTOBJPosition;
        private System.Windows.Forms.TabPage tabPageTDirection;
        private System.Windows.Forms.TabPage tabPageTRoaming;
        private System.Windows.Forms.TabPage tabPageTStop;
        private System.Windows.Forms.ComboBox comboBoxTTType;
        private System.Windows.Forms.Button buttonCSChoose;
        private System.Windows.Forms.RadioButton radioButtonCSD;
        private System.Windows.Forms.RadioButton radioButtonCSC;
        private System.Windows.Forms.RadioButton radioButtonCSB;
        private System.Windows.Forms.RadioButton radioButtonCSA;
        private System.Windows.Forms.ComboBox comboBoxTSpeed;
        private System.Windows.Forms.Button buttonTOOBJChoose;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.ComboBox comboBoxTRTType;
    }
}

