
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
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.File = new System.Windows.Forms.ToolStripDropDownButton();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Option = new System.Windows.Forms.ToolStripDropDownButton();
            this.首选项ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Help = new System.Windows.Forms.ToolStripDropDownButton();
            this.程序帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Run = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.NUT = new System.Windows.Forms.Button();
            this.imageListOBJSmall = new System.Windows.Forms.ImageList(this.components);
            this.groupBoxBG = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.buttonRefreshBG = new System.Windows.Forms.Button();
            this.buttonEditBG = new System.Windows.Forms.Button();
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
            this.groupBoxAIBGMMdata = new System.Windows.Forms.GroupBox();
            this.tabControlAIOBJMdata = new System.Windows.Forms.TabControl();
            this.AI = new System.Windows.Forms.TabPage();
            this.groupBoxAction = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.listBoxAction = new System.Windows.Forms.ListBox();
            this.groupBoxWhen = new System.Windows.Forms.GroupBox();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBoxScript = new System.Windows.Forms.ListBox();
            this.BGM = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Metadata = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelComment = new System.Windows.Forms.Label();
            this.textBoxGameName = new System.Windows.Forms.TextBox();
            this.labelGameName = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.imageListOBJLarge = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip.SuspendLayout();
            this.groupBoxBG.SuspendLayout();
            this.groupBoxOBJ.SuspendLayout();
            this.groupBoxAIBGMMdata.SuspendLayout();
            this.tabControlAIOBJMdata.SuspendLayout();
            this.AI.SuspendLayout();
            this.groupBoxAction.SuspendLayout();
            this.groupBoxWhen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.BGM.SuspendLayout();
            this.Metadata.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_FileOk);
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
            this.toolStrip.Text = "toolStrip1";
            this.toolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip_ItemClicked);
            // 
            // File
            // 
            this.File.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.退出ToolStripMenuItem,
            this.保存ToolStripMenuItem});
            this.File.Image = ((System.Drawing.Image)(resources.GetObject("File.Image")));
            this.File.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(45, 22);
            this.File.Text = "文件";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.保存ToolStripMenuItem.Text = "保存";
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
            // NUT
            // 
            this.NUT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NUT.BackColor = System.Drawing.SystemColors.Window;
            this.NUT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NUT.BackgroundImage")));
            this.NUT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.NUT.Font = new System.Drawing.Font("Calibri", 32F);
            this.NUT.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.NUT.Location = new System.Drawing.Point(1216, 369);
            this.NUT.Name = "NUT";
            this.NUT.Size = new System.Drawing.Size(260, 200);
            this.NUT.TabIndex = 6;
            this.NUT.Text = "NUT";
            this.NUT.UseVisualStyleBackColor = false;
            this.NUT.Click += new System.EventHandler(this.NUT_Click);
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
            this.groupBoxBG.Controls.Add(this.button8);
            this.groupBoxBG.Controls.Add(this.buttonRefreshBG);
            this.groupBoxBG.Controls.Add(this.buttonEditBG);
            this.groupBoxBG.Controls.Add(this.buttonDeleteBG);
            this.groupBoxBG.Controls.Add(this.buttonNewBG);
            this.groupBoxBG.Controls.Add(this.listViewBG);
            this.groupBoxBG.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBoxBG.Location = new System.Drawing.Point(1210, 28);
            this.groupBoxBG.Name = "groupBoxBG";
            this.groupBoxBG.Size = new System.Drawing.Size(265, 323);
            this.groupBoxBG.TabIndex = 8;
            this.groupBoxBG.TabStop = false;
            this.groupBoxBG.Text = "背景";
            // 
            // button8
            // 
            this.button8.Enabled = false;
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button8.FlatAppearance.BorderSize = 5;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Location = new System.Drawing.Point(6, 294);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(253, 21);
            this.button8.TabIndex = 7;
            this.button8.Text = "设为默认背景";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // buttonRefreshBG
            // 
            this.buttonRefreshBG.BackgroundImage = global::DIYScript_Interpreter.Properties.Resources.OIP_C_dgtB_f92LGrw6igoaGVw7QHaHa;
            this.buttonRefreshBG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRefreshBG.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonRefreshBG.FlatAppearance.BorderSize = 5;
            this.buttonRefreshBG.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRefreshBG.Location = new System.Drawing.Point(6, 17);
            this.buttonRefreshBG.Name = "buttonRefreshBG";
            this.buttonRefreshBG.Size = new System.Drawing.Size(25, 25);
            this.buttonRefreshBG.TabIndex = 6;
            this.buttonRefreshBG.UseVisualStyleBackColor = true;
            this.buttonRefreshBG.Click += new System.EventHandler(this.buttonRefreshBG_Click);
            // 
            // buttonEditBG
            // 
            this.buttonEditBG.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonEditBG.FlatAppearance.BorderSize = 5;
            this.buttonEditBG.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEditBG.Location = new System.Drawing.Point(182, 266);
            this.buttonEditBG.Name = "buttonEditBG";
            this.buttonEditBG.Size = new System.Drawing.Size(77, 22);
            this.buttonEditBG.TabIndex = 5;
            this.buttonEditBG.Text = "编辑";
            this.buttonEditBG.UseVisualStyleBackColor = true;
            this.buttonEditBG.Click += new System.EventHandler(this.buttonEditBG_Click);
            // 
            // buttonDeleteBG
            // 
            this.buttonDeleteBG.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonDeleteBG.FlatAppearance.BorderSize = 5;
            this.buttonDeleteBG.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDeleteBG.Location = new System.Drawing.Point(94, 266);
            this.buttonDeleteBG.Name = "buttonDeleteBG";
            this.buttonDeleteBG.Size = new System.Drawing.Size(77, 22);
            this.buttonDeleteBG.TabIndex = 4;
            this.buttonDeleteBG.Text = "删除";
            this.buttonDeleteBG.UseVisualStyleBackColor = true;
            this.buttonDeleteBG.Click += new System.EventHandler(this.buttonDeleteBG_Click);
            // 
            // buttonNewBG
            // 
            this.buttonNewBG.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonNewBG.FlatAppearance.BorderSize = 5;
            this.buttonNewBG.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonNewBG.Location = new System.Drawing.Point(6, 266);
            this.buttonNewBG.Name = "buttonNewBG";
            this.buttonNewBG.Size = new System.Drawing.Size(77, 22);
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
            this.buttonRefreshOBJ.BackgroundImage = global::DIYScript_Interpreter.Properties.Resources.OIP_C_dgtB_f92LGrw6igoaGVw7QHaHa;
            this.buttonRefreshOBJ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRefreshOBJ.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonRefreshOBJ.FlatAppearance.BorderSize = 5;
            this.buttonRefreshOBJ.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
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
            this.buttonEditOBJ.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
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
            this.buttonDelOBJ.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
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
            this.buttonNewOBJ.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
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
            this.tabControlAIOBJMdata.Appearance = System.Windows.Forms.TabAppearance.Buttons;
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
            this.AI.Controls.Add(this.pictureBox1);
            this.AI.Controls.Add(this.listBoxScript);
            this.AI.ForeColor = System.Drawing.Color.Black;
            this.AI.Location = new System.Drawing.Point(4, 25);
            this.AI.Name = "AI";
            this.AI.Padding = new System.Windows.Forms.Padding(3);
            this.AI.Size = new System.Drawing.Size(785, 486);
            this.AI.TabIndex = 0;
            this.AI.Text = "脚本";
            // 
            // groupBoxAction
            // 
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
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.Location = new System.Drawing.Point(147, 107);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(23, 23);
            this.button4.TabIndex = 15;
            this.button4.Text = "-";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button5.Location = new System.Drawing.Point(147, 78);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(23, 23);
            this.button5.TabIndex = 14;
            this.button5.Text = "+";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button6.Location = new System.Drawing.Point(147, 49);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(23, 23);
            this.button6.TabIndex = 13;
            this.button6.Text = "▽";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
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
            // 
            // buttonCDel
            // 
            this.buttonCDel.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonCDel.Location = new System.Drawing.Point(147, 107);
            this.buttonCDel.Name = "buttonCDel";
            this.buttonCDel.Size = new System.Drawing.Size(23, 23);
            this.buttonCDel.TabIndex = 10;
            this.buttonCDel.Text = "-";
            this.buttonCDel.UseVisualStyleBackColor = true;
            // 
            // buttonCAdd
            // 
            this.buttonCAdd.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonCAdd.Location = new System.Drawing.Point(147, 78);
            this.buttonCAdd.Name = "buttonCAdd";
            this.buttonCAdd.Size = new System.Drawing.Size(23, 23);
            this.buttonCAdd.TabIndex = 9;
            this.buttonCAdd.Text = "+";
            this.buttonCAdd.UseVisualStyleBackColor = true;
            // 
            // buttonCDown
            // 
            this.buttonCDown.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonCDown.Location = new System.Drawing.Point(147, 49);
            this.buttonCDown.Name = "buttonCDown";
            this.buttonCDown.Size = new System.Drawing.Size(23, 23);
            this.buttonCDown.TabIndex = 8;
            this.buttonCDown.Text = "▽";
            this.buttonCDown.UseVisualStyleBackColor = true;
            // 
            // buttonCUp
            // 
            this.buttonCUp.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
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
            // 
            // buttonDel
            // 
            this.buttonDel.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
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
            this.buttonAdd.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
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
            this.buttonDown.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonDown.Location = new System.Drawing.Point(187, 143);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(23, 23);
            this.buttonDown.TabIndex = 4;
            this.buttonDown.Text = "▽";
            this.buttonDown.UseVisualStyleBackColor = true;
            // 
            // buttonUp
            // 
            this.buttonUp.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
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
            this.BGM.Controls.Add(this.button1);
            this.BGM.Controls.Add(this.button2);
            this.BGM.Controls.Add(this.button3);
            this.BGM.Controls.Add(this.listView1);
            this.BGM.ForeColor = System.Drawing.Color.Black;
            this.BGM.Location = new System.Drawing.Point(4, 25);
            this.BGM.Name = "BGM";
            this.BGM.Padding = new System.Windows.Forms.Padding(3);
            this.BGM.Size = new System.Drawing.Size(785, 486);
            this.BGM.TabIndex = 1;
            this.BGM.Text = "音乐";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(242, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 38);
            this.button1.TabIndex = 9;
            this.button1.Text = "编辑";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(124, 277);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 38);
            this.button2.TabIndex = 8;
            this.button2.Text = "删除";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(6, 276);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 38);
            this.button3.TabIndex = 7;
            this.button3.Text = "新建";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(6, 6);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(773, 264);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Metadata
            // 
            this.Metadata.Controls.Add(this.textBox1);
            this.Metadata.Controls.Add(this.labelComment);
            this.Metadata.Controls.Add(this.textBoxGameName);
            this.Metadata.Controls.Add(this.labelGameName);
            this.Metadata.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Metadata.ForeColor = System.Drawing.Color.Black;
            this.Metadata.Location = new System.Drawing.Point(4, 25);
            this.Metadata.Name = "Metadata";
            this.Metadata.Size = new System.Drawing.Size(785, 486);
            this.Metadata.TabIndex = 2;
            this.Metadata.Text = "元数据";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(75, 44);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(696, 93);
            this.textBox1.TabIndex = 3;
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
            this.openFileDialog.FileName = "1145141919810.bmp";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // imageListOBJLarge
            // 
            this.imageListOBJLarge.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageListOBJLarge.ImageSize = new System.Drawing.Size(64, 64);
            this.imageListOBJLarge.TransparentColor = System.Drawing.Color.Transparent;
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
            this.groupBoxWhen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.BGM.ResumeLayout(false);
            this.Metadata.ResumeLayout(false);
            this.Metadata.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
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
        private System.Windows.Forms.Button buttonEditBG;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TabPage Metadata;
        private System.Windows.Forms.TextBox textBox1;
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
        private System.Windows.Forms.PictureBox pictureBox1;
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
        private System.Windows.Forms.Button button8;
    }
}

