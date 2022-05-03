
using System.Windows.Forms;

namespace DIYScript_Interpreter {
    partial class Animater {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Animater));
            this.listViewFrames = new System.Windows.Forms.ListView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.labelFrame = new System.Windows.Forms.Label();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.从GIFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.复制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.粘贴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.剪切ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabelARTName = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBoxARTName = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonAFront = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonABehind = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.pictureBoxCurrent = new System.Windows.Forms.PictureBox();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCurrent)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewFrames
            // 
            this.listViewFrames.HideSelection = false;
            this.listViewFrames.LargeImageList = this.imageList;
            this.listViewFrames.Location = new System.Drawing.Point(8, 40);
            this.listViewFrames.Name = "listViewFrames";
            this.listViewFrames.Size = new System.Drawing.Size(769, 96);
            this.listViewFrames.SmallImageList = this.imageList;
            this.listViewFrames.StateImageList = this.imageList;
            this.listViewFrames.TabIndex = 0;
            this.listViewFrames.UseCompatibleStateImageBehavior = false;
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "位图|*.bmp|jpeg 图像|*.jpg;*.jpeg|png 图像|*.png|所有文件|*.*";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOK);
            // 
            // labelFrame
            // 
            this.labelFrame.AutoSize = true;
            this.labelFrame.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelFrame.Location = new System.Drawing.Point(8, 40);
            this.labelFrame.Name = "labelFrame";
            this.labelFrame.Size = new System.Drawing.Size(25, 14);
            this.labelFrame.TabIndex = 8;
            this.labelFrame.Text = "0/0";
            this.labelFrame.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripSeparator1,
            this.toolStripLabelARTName,
            this.toolStripTextBoxARTName,
            this.toolStripSeparator2,
            this.toolStripButtonAFront,
            this.toolStripButtonABehind,
            this.toolStripButtonDel,
            this.toolStripSeparator3});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(784, 25);
            this.toolStrip.TabIndex = 9;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.从GIFToolStripMenuItem,
            this.复制ToolStripMenuItem,
            this.粘贴ToolStripMenuItem,
            this.剪切ToolStripMenuItem,
            this.删除ToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(49, 22);
            this.toolStripDropDownButton1.Text = "帧";
            // 
            // 从GIFToolStripMenuItem
            // 
            this.从GIFToolStripMenuItem.Name = "从GIFToolStripMenuItem";
            this.从GIFToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.从GIFToolStripMenuItem.Text = "从GIF......";
            this.从GIFToolStripMenuItem.Click += new System.EventHandler(this.从GIFToolStripMenuItem_Click);
            // 
            // 复制ToolStripMenuItem
            // 
            this.复制ToolStripMenuItem.Name = "复制ToolStripMenuItem";
            this.复制ToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.复制ToolStripMenuItem.Text = "复制";
            // 
            // 粘贴ToolStripMenuItem
            // 
            this.粘贴ToolStripMenuItem.Name = "粘贴ToolStripMenuItem";
            this.粘贴ToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.粘贴ToolStripMenuItem.Text = "粘贴";
            // 
            // 剪切ToolStripMenuItem
            // 
            this.剪切ToolStripMenuItem.Name = "剪切ToolStripMenuItem";
            this.剪切ToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.剪切ToolStripMenuItem.Text = "剪切";
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabelARTName
            // 
            this.toolStripLabelARTName.Name = "toolStripLabelARTName";
            this.toolStripLabelARTName.Size = new System.Drawing.Size(56, 22);
            this.toolStripLabelARTName.Text = "形象名称";
            // 
            // toolStripTextBoxARTName
            // 
            this.toolStripTextBoxARTName.Name = "toolStripTextBoxARTName";
            this.toolStripTextBoxARTName.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonAFront
            // 
            this.toolStripButtonAFront.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAFront.Image")));
            this.toolStripButtonAFront.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAFront.Name = "toolStripButtonAFront";
            this.toolStripButtonAFront.Size = new System.Drawing.Size(97, 22);
            this.toolStripButtonAFront.Text = "在前方插入...";
            this.toolStripButtonAFront.Click += new System.EventHandler(this.ButtonAddBefore_Click);
            // 
            // toolStripButtonABehind
            // 
            this.toolStripButtonABehind.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonABehind.Image")));
            this.toolStripButtonABehind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonABehind.Name = "toolStripButtonABehind";
            this.toolStripButtonABehind.Size = new System.Drawing.Size(97, 22);
            this.toolStripButtonABehind.Text = "在后方插入...";
            this.toolStripButtonABehind.Click += new System.EventHandler(this.buttonAddAfter_Click);
            // 
            // toolStripButtonDel
            // 
            this.toolStripButtonDel.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDel.Image")));
            this.toolStripButtonDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDel.Name = "toolStripButtonDel";
            this.toolStripButtonDel.Size = new System.Drawing.Size(52, 22);
            this.toolStripButtonDel.Text = "删除";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // buttonStop
            // 
            this.buttonStop.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonStop.BackColor = System.Drawing.Color.Transparent;
            this.buttonStop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonStop.BackgroundImage")));
            this.buttonStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonStop.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonStop.Location = new System.Drawing.Point(0, 200);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(23, 23);
            this.buttonStop.TabIndex = 6;
            this.buttonStop.UseVisualStyleBackColor = false;
            // 
            // buttonPause
            // 
            this.buttonPause.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonPause.BackColor = System.Drawing.Color.Transparent;
            this.buttonPause.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPause.BackgroundImage")));
            this.buttonPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPause.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonPause.Location = new System.Drawing.Point(0, 176);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(23, 23);
            this.buttonPause.TabIndex = 5;
            this.buttonPause.UseVisualStyleBackColor = false;
            // 
            // buttonPlay
            // 
            this.buttonPlay.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonPlay.BackColor = System.Drawing.Color.Transparent;
            this.buttonPlay.BackgroundImage = global::DIYScript_Interpreter.Properties.Resources.play;
            this.buttonPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPlay.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonPlay.Location = new System.Drawing.Point(0, 152);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(23, 24);
            this.buttonPlay.TabIndex = 4;
            this.buttonPlay.UseVisualStyleBackColor = false;
            // 
            // pictureBoxCurrent
            // 
            this.pictureBoxCurrent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxCurrent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxCurrent.Image = global::DIYScript_Interpreter.Properties.Resources.inm;
            this.pictureBoxCurrent.Location = new System.Drawing.Point(24, 152);
            this.pictureBoxCurrent.MinimumSize = new System.Drawing.Size(100, 100);
            this.pictureBoxCurrent.Name = "pictureBoxCurrent";
            this.pictureBoxCurrent.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxCurrent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCurrent.TabIndex = 1;
            this.pictureBoxCurrent.TabStop = false;
            this.pictureBoxCurrent.Click += new System.EventHandler(this.pictureBoxCurrent_Click);
            this.pictureBoxCurrent.DoubleClick += new System.EventHandler(this.pictureBoxCurrent_DoubleClick);
            // 
            // Animater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 256);
            this.Controls.Add(this.labelFrame);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonPause);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.pictureBoxCurrent);
            this.Controls.Add(this.listViewFrames);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Animater";
            this.Text = "动画";
            this.Load += new System.EventHandler(this.Animater_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCurrent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCurrent;
        private System.Windows.Forms.ListView listViewFrames;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Button buttonStop;
        private Label labelFrame;
        private ToolStrip toolStrip;
        private ToolStripTextBox toolStripTextBoxARTName;
        private ToolStripLabel toolStripLabelARTName;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButtonAFront;
        private ToolStripButton toolStripButtonABehind;
        private ToolStripButton toolStripButtonDel;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem 从GIFToolStripMenuItem;
        private ToolStripMenuItem 复制ToolStripMenuItem;
        private ToolStripMenuItem 粘贴ToolStripMenuItem;
        private ToolStripMenuItem 剪切ToolStripMenuItem;
        private ToolStripMenuItem 删除ToolStripMenuItem;
        private OpenFileDialog openFileDialog;
    }
}