
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
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.imageListOBJSmall = new System.Windows.Forms.ImageList(this.components);
            this.groupBoxBG = new System.Windows.Forms.GroupBox();
            this.buttonNormalBG = new System.Windows.Forms.Button();
            this.buttonDeleteBG = new System.Windows.Forms.Button();
            this.buttonNewBG = new System.Windows.Forms.Button();
            this.listViewBG = new System.Windows.Forms.ListView();
            this.imageListBGLarge = new System.Windows.Forms.ImageList(this.components);
            this.imageListBGSmall = new System.Windows.Forms.ImageList(this.components);
            this.groupBoxOBJ = new System.Windows.Forms.GroupBox();
            this.buttonEditOBJ = new System.Windows.Forms.Button();
            this.buttonDelOBJ = new System.Windows.Forms.Button();
            this.buttonNewOBJ = new System.Windows.Forms.Button();
            this.listViewOBJ = new System.Windows.Forms.ListView();
            this.imageListOBJLarge = new System.Windows.Forms.ImageList(this.components);
            this.groupBoxAIBGMMdata = new System.Windows.Forms.GroupBox();
            this.tabControlAIOBJMdata = new System.Windows.Forms.TabControl();
            this.AI = new System.Windows.Forms.TabPage();
            this.groupBoxAction = new System.Windows.Forms.GroupBox();
            this.buttonAOK = new System.Windows.Forms.Button();
            this.tabControlA = new System.Windows.Forms.TabControl();
            this.ATravel = new System.Windows.Forms.TabPage();
            this.ASwitch = new System.Windows.Forms.TabPage();
            this.AArt = new System.Windows.Forms.TabPage();
            this.AWinLose = new System.Windows.Forms.TabPage();
            this.AVfx = new System.Windows.Forms.TabPage();
            this.ASfx = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.listBoxAction = new System.Windows.Forms.ListBox();
            this.groupBoxWhen = new System.Windows.Forms.GroupBox();
            this.buttonCOK = new System.Windows.Forms.Button();
            this.tabControlC = new System.Windows.Forms.TabControl();
            this.CTap = new System.Windows.Forms.TabPage();
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
            this.CSwitch = new System.Windows.Forms.TabPage();
            this.CWonLoss = new System.Windows.Forms.TabPage();
            this.buttonCDel = new System.Windows.Forms.Button();
            this.buttonCAdd = new System.Windows.Forms.Button();
            this.buttonCDown = new System.Windows.Forms.Button();
            this.buttonCUp = new System.Windows.Forms.Button();
            this.listBoxCondition = new System.Windows.Forms.ListBox();
            this.labelOBJName = new System.Windows.Forms.Label();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.labelScriptsList = new System.Windows.Forms.Label();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxOBJPic = new System.Windows.Forms.PictureBox();
            this.buttonRefreshBG = new System.Windows.Forms.Button();
            this.buttonRefreshOBJ = new System.Windows.Forms.Button();
            this.NUT = new System.Windows.Forms.Button();
            this.File = new System.Windows.Forms.ToolStripDropDownButton();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Option = new System.Windows.Forms.ToolStripDropDownButton();
            this.首选项ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Help = new System.Windows.Forms.ToolStripDropDownButton();
            this.程序帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Run = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip.SuspendLayout();
            this.groupBoxBG.SuspendLayout();
            this.groupBoxOBJ.SuspendLayout();
            this.groupBoxAIBGMMdata.SuspendLayout();
            this.tabControlAIOBJMdata.SuspendLayout();
            this.AI.SuspendLayout();
            this.groupBoxAction.SuspendLayout();
            this.tabControlA.SuspendLayout();
            this.groupBoxWhen.SuspendLayout();
            this.tabControlC.SuspendLayout();
            this.CTap.SuspendLayout();
            this.BGM.SuspendLayout();
            this.Metadata.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOBJPic)).BeginInit();
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
            this.Run,
            this.toolStripButton1});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1488, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip_ItemClicked);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
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
            this.buttonNormalBG.UseVisualStyleBackColor = true;
            this.buttonNormalBG.Click += new System.EventHandler(this.buttonNormalBG_Click);
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
            this.buttonDeleteBG.UseVisualStyleBackColor = true;
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
            this.buttonNewBG.UseVisualStyleBackColor = true;
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
            this.buttonEditOBJ.UseVisualStyleBackColor = true;
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
            this.buttonDelOBJ.UseVisualStyleBackColor = true;
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
            this.buttonNewOBJ.UseVisualStyleBackColor = true;
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
            this.groupBoxAction.Controls.Add(this.buttonAOK);
            this.groupBoxAction.Controls.Add(this.tabControlA);
            this.groupBoxAction.Controls.Add(this.button4);
            this.groupBoxAction.Controls.Add(this.button5);
            this.groupBoxAction.Controls.Add(this.button6);
            this.groupBoxAction.Controls.Add(this.button7);
            this.groupBoxAction.Controls.Add(this.listBoxAction);
            this.groupBoxAction.Location = new System.Drawing.Point(216, 276);
            this.groupBoxAction.Name = "groupBoxAction";
            this.groupBoxAction.Size = new System.Drawing.Size(563, 202);
            this.groupBoxAction.TabIndex = 9;
            this.groupBoxAction.TabStop = false;
            this.groupBoxAction.Text = "做......";
            // 
            // buttonAOK
            // 
            this.buttonAOK.Font = new System.Drawing.Font("宋体", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonAOK.Location = new System.Drawing.Point(530, 45);
            this.buttonAOK.Name = "buttonAOK";
            this.buttonAOK.Size = new System.Drawing.Size(23, 143);
            this.buttonAOK.TabIndex = 13;
            this.buttonAOK.Text = "OK";
            this.buttonAOK.UseVisualStyleBackColor = true;
            // 
            // tabControlA
            // 
            this.tabControlA.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControlA.Controls.Add(this.ATravel);
            this.tabControlA.Controls.Add(this.ASwitch);
            this.tabControlA.Controls.Add(this.AArt);
            this.tabControlA.Controls.Add(this.AWinLose);
            this.tabControlA.Controls.Add(this.AVfx);
            this.tabControlA.Controls.Add(this.ASfx);
            this.tabControlA.Location = new System.Drawing.Point(177, 20);
            this.tabControlA.Name = "tabControlA";
            this.tabControlA.SelectedIndex = 0;
            this.tabControlA.Size = new System.Drawing.Size(347, 172);
            this.tabControlA.TabIndex = 16;
            // 
            // ATravel
            // 
            this.ATravel.Location = new System.Drawing.Point(4, 25);
            this.ATravel.Name = "ATravel";
            this.ATravel.Padding = new System.Windows.Forms.Padding(3);
            this.ATravel.Size = new System.Drawing.Size(339, 143);
            this.ATravel.TabIndex = 0;
            this.ATravel.Text = "运动";
            this.ATravel.UseVisualStyleBackColor = true;
            // 
            // ASwitch
            // 
            this.ASwitch.Location = new System.Drawing.Point(4, 25);
            this.ASwitch.Name = "ASwitch";
            this.ASwitch.Size = new System.Drawing.Size(339, 143);
            this.ASwitch.TabIndex = 1;
            this.ASwitch.Text = "开关";
            this.ASwitch.UseVisualStyleBackColor = true;
            // 
            // AArt
            // 
            this.AArt.Location = new System.Drawing.Point(4, 25);
            this.AArt.Name = "AArt";
            this.AArt.Size = new System.Drawing.Size(339, 143);
            this.AArt.TabIndex = 2;
            this.AArt.Text = "形象";
            this.AArt.UseVisualStyleBackColor = true;
            // 
            // AWinLose
            // 
            this.AWinLose.Location = new System.Drawing.Point(4, 25);
            this.AWinLose.Name = "AWinLose";
            this.AWinLose.Size = new System.Drawing.Size(339, 143);
            this.AWinLose.TabIndex = 3;
            this.AWinLose.Text = "成功/失败";
            this.AWinLose.UseVisualStyleBackColor = true;
            // 
            // AVfx
            // 
            this.AVfx.Location = new System.Drawing.Point(4, 25);
            this.AVfx.Name = "AVfx";
            this.AVfx.Size = new System.Drawing.Size(339, 143);
            this.AVfx.TabIndex = 4;
            this.AVfx.Text = "视觉效果";
            this.AVfx.UseVisualStyleBackColor = true;
            // 
            // ASfx
            // 
            this.ASfx.Location = new System.Drawing.Point(4, 25);
            this.ASfx.Name = "ASfx";
            this.ASfx.Size = new System.Drawing.Size(339, 143);
            this.ASfx.TabIndex = 5;
            this.ASfx.Text = "听觉效果";
            this.ASfx.UseVisualStyleBackColor = true;
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
            this.listBoxAction.Location = new System.Drawing.Point(6, 20);
            this.listBoxAction.Name = "listBoxAction";
            this.listBoxAction.Size = new System.Drawing.Size(135, 172);
            this.listBoxAction.TabIndex = 11;
            // 
            // groupBoxWhen
            // 
            this.groupBoxWhen.Controls.Add(this.buttonCOK);
            this.groupBoxWhen.Controls.Add(this.tabControlC);
            this.groupBoxWhen.Controls.Add(this.buttonCDel);
            this.groupBoxWhen.Controls.Add(this.buttonCAdd);
            this.groupBoxWhen.Controls.Add(this.buttonCDown);
            this.groupBoxWhen.Controls.Add(this.buttonCUp);
            this.groupBoxWhen.Controls.Add(this.listBoxCondition);
            this.groupBoxWhen.Location = new System.Drawing.Point(216, 114);
            this.groupBoxWhen.Name = "groupBoxWhen";
            this.groupBoxWhen.Size = new System.Drawing.Size(563, 156);
            this.groupBoxWhen.TabIndex = 8;
            this.groupBoxWhen.TabStop = false;
            this.groupBoxWhen.Text = "当......";
            this.groupBoxWhen.Enter += new System.EventHandler(this.groupBoxWhen_Enter);
            // 
            // buttonCOK
            // 
            this.buttonCOK.Font = new System.Drawing.Font("宋体", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonCOK.Location = new System.Drawing.Point(530, 45);
            this.buttonCOK.Name = "buttonCOK";
            this.buttonCOK.Size = new System.Drawing.Size(23, 95);
            this.buttonCOK.TabIndex = 12;
            this.buttonCOK.Text = "OK";
            this.buttonCOK.UseVisualStyleBackColor = true;
            // 
            // tabControlC
            // 
            this.tabControlC.Appearance = System.Windows.Forms.TabAppearance.Buttons;
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
            this.CTap.Location = new System.Drawing.Point(4, 25);
            this.CTap.Name = "CTap";
            this.CTap.Padding = new System.Windows.Forms.Padding(3);
            this.CTap.Size = new System.Drawing.Size(339, 95);
            this.CTap.TabIndex = 1;
            this.CTap.Text = "触摸";
            this.CTap.UseVisualStyleBackColor = true;
            this.CTap.Click += new System.EventHandler(this.CTap_Click);
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
            this.comboBoxClickSlide.Location = new System.Drawing.Point(7, 7);
            this.comboBoxClickSlide.Name = "comboBoxClickSlide";
            this.comboBoxClickSlide.Size = new System.Drawing.Size(121, 20);
            this.comboBoxClickSlide.TabIndex = 1;
            this.comboBoxClickSlide.SelectedIndexChanged += new System.EventHandler(this.comboBoxClickSlide_SelectedIndexChanged);
            // 
            // checkBoxArea
            // 
            this.checkBoxArea.AutoSize = true;
            this.checkBoxArea.Checked = true;
            this.checkBoxArea.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxArea.Location = new System.Drawing.Point(134, 9);
            this.checkBoxArea.Name = "checkBoxArea";
            this.checkBoxArea.Size = new System.Drawing.Size(54, 16);
            this.checkBoxArea.TabIndex = 0;
            this.checkBoxArea.Text = "此OBJ";
            this.checkBoxArea.UseVisualStyleBackColor = true;
            this.checkBoxArea.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // CContact
            // 
            this.CContact.Location = new System.Drawing.Point(4, 25);
            this.CContact.Name = "CContact";
            this.CContact.Size = new System.Drawing.Size(339, 95);
            this.CContact.TabIndex = 5;
            this.CContact.Text = "接触";
            this.CContact.UseVisualStyleBackColor = true;
            // 
            // CArt
            // 
            this.CArt.Location = new System.Drawing.Point(4, 25);
            this.CArt.Name = "CArt";
            this.CArt.Size = new System.Drawing.Size(339, 95);
            this.CArt.TabIndex = 3;
            this.CArt.Text = "形象";
            this.CArt.UseVisualStyleBackColor = true;
            // 
            // CTime
            // 
            this.CTime.Location = new System.Drawing.Point(4, 25);
            this.CTime.Name = "CTime";
            this.CTime.Size = new System.Drawing.Size(339, 95);
            this.CTime.TabIndex = 2;
            this.CTime.Text = "时间";
            this.CTime.UseVisualStyleBackColor = true;
            // 
            // CSwitch
            // 
            this.CSwitch.Location = new System.Drawing.Point(4, 25);
            this.CSwitch.Name = "CSwitch";
            this.CSwitch.Size = new System.Drawing.Size(339, 95);
            this.CSwitch.TabIndex = 4;
            this.CSwitch.Text = "开关";
            this.CSwitch.UseVisualStyleBackColor = true;
            // 
            // CWonLoss
            // 
            this.CWonLoss.Location = new System.Drawing.Point(4, 25);
            this.CWonLoss.Name = "CWonLoss";
            this.CWonLoss.Size = new System.Drawing.Size(339, 95);
            this.CWonLoss.TabIndex = 6;
            this.CWonLoss.Text = "成功/失败";
            this.CWonLoss.UseVisualStyleBackColor = true;
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
            this.listBoxCondition.Location = new System.Drawing.Point(6, 20);
            this.listBoxCondition.Name = "listBoxCondition";
            this.listBoxCondition.Size = new System.Drawing.Size(135, 124);
            this.listBoxCondition.TabIndex = 1;
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
            // listBoxScript
            // 
            this.listBoxScript.FormattingEnabled = true;
            this.listBoxScript.ItemHeight = 12;
            this.listBoxScript.Location = new System.Drawing.Point(6, 114);
            this.listBoxScript.Name = "listBoxScript";
            this.listBoxScript.Size = new System.Drawing.Size(175, 364);
            this.listBoxScript.TabIndex = 0;
            // 
            // BGM
            // 
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
            this.linkLabel1.Location = new System.Drawing.Point(53, 44);
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
            this.listViewBGM.Size = new System.Drawing.Size(773, 267);
            this.listViewBGM.TabIndex = 6;
            this.listViewBGM.UseCompatibleStateImageBehavior = false;
            // 
            // Metadata
            // 
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
            this.Metadata.Cursor = System.Windows.Forms.Cursors.IBeam;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DIYScript_Interpreter.Properties.Resources.c154427a76fb8da6161c0fe97d71dc92_512_512_jpg_ys;
            this.pictureBox1.Location = new System.Drawing.Point(251, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
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
            // buttonRefreshBG
            // 
            this.buttonRefreshBG.BackgroundImage = global::DIYScript_Interpreter.Properties.Resources.OIP_C_dgtB_f92LGrw6igoaGVw7QHaHa;
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
            // buttonRefreshOBJ
            // 
            this.buttonRefreshOBJ.BackgroundImage = global::DIYScript_Interpreter.Properties.Resources.OIP_C_dgtB_f92LGrw6igoaGVw7QHaHa;
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
            // NUT
            // 
            this.NUT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NUT.BackColor = System.Drawing.SystemColors.Window;
            this.NUT.BackgroundImage = global::DIYScript_Interpreter.Properties.Resources._8i1;
            this.NUT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.NUT.Font = new System.Drawing.Font("Calibri", 32F);
            this.NUT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(69)))), ((int)(((byte)(20)))));
            this.NUT.Location = new System.Drawing.Point(1216, 349);
            this.NUT.Name = "NUT";
            this.NUT.Size = new System.Drawing.Size(260, 220);
            this.NUT.TabIndex = 6;
            this.NUT.Text = "NUT";
            this.NUT.UseVisualStyleBackColor = false;
            this.NUT.Click += new System.EventHandler(this.NUT_Click);
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
            // Run
            // 
            this.Run.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Run.Image = ((System.Drawing.Image)(resources.GetObject("Run.Image")));
            this.Run.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(40, 22);
            this.Run.Text = "运行!";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(87, 22);
            this.toolStripButton1.Text = "GamePlaynet";
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
            this.Text = "DIYScript Interpreter";
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
            this.groupBoxWhen.ResumeLayout(false);
            this.tabControlC.ResumeLayout(false);
            this.CTap.ResumeLayout(false);
            this.CTap.PerformLayout();
            this.BGM.ResumeLayout(false);
            this.BGM.PerformLayout();
            this.Metadata.ResumeLayout(false);
            this.Metadata.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOBJPic)).EndInit();
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
        private System.Windows.Forms.ToolStripButton toolStripButton1;
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
    }
}

