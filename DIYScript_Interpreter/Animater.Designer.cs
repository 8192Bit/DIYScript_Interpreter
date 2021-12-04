
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
            this.buttonAddBefore = new System.Windows.Forms.Button();
            this.buttonAddAfter = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.pictureBoxCurrent = new System.Windows.Forms.PictureBox();
            this.buttonDel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCurrent)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewFrames
            // 
            this.listViewFrames.HideSelection = false;
            this.listViewFrames.Location = new System.Drawing.Point(13, 13);
            this.listViewFrames.Name = "listViewFrames";
            this.listViewFrames.Size = new System.Drawing.Size(769, 113);
            this.listViewFrames.TabIndex = 0;
            this.listViewFrames.UseCompatibleStateImageBehavior = false;
            // 
            // buttonAddBefore
            // 
            this.buttonAddBefore.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddBefore.Location = new System.Drawing.Point(13, 132);
            this.buttonAddBefore.Name = "buttonAddBefore";
            this.buttonAddBefore.Size = new System.Drawing.Size(93, 23);
            this.buttonAddBefore.TabIndex = 2;
            this.buttonAddBefore.Text = "在前方插入...";
            this.buttonAddBefore.UseVisualStyleBackColor = true;
            this.buttonAddBefore.Click += new System.EventHandler(this.ButtonAddBefore_Click);
            // 
            // buttonAddAfter
            // 
            this.buttonAddAfter.Enabled = false;
            this.buttonAddAfter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddAfter.Location = new System.Drawing.Point(112, 132);
            this.buttonAddAfter.Name = "buttonAddAfter";
            this.buttonAddAfter.Size = new System.Drawing.Size(93, 23);
            this.buttonAddAfter.TabIndex = 3;
            this.buttonAddAfter.Text = "在后方插入...";
            this.buttonAddAfter.UseVisualStyleBackColor = true;
            this.buttonAddAfter.Click += new System.EventHandler(this.buttonAddAfter_Click);
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOK);
            // 
            // buttonPause
            // 
            this.buttonPause.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonPause.BackColor = System.Drawing.Color.Transparent;
            this.buttonPause.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPause.BackgroundImage")));
            this.buttonPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPause.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPause.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonPause.Location = new System.Drawing.Point(653, 161);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(23, 23);
            this.buttonPause.TabIndex = 5;
            this.buttonPause.UseVisualStyleBackColor = false;
            // 
            // buttonStop
            // 
            this.buttonStop.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonStop.BackColor = System.Drawing.Color.Transparent;
            this.buttonStop.BackgroundImage = global::DIYScript_Interpreter.Properties.Resources.stop;
            this.buttonStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStop.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonStop.Location = new System.Drawing.Point(653, 190);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(23, 23);
            this.buttonStop.TabIndex = 6;
            this.buttonStop.UseVisualStyleBackColor = false;
            // 
            // buttonPlay
            // 
            this.buttonPlay.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonPlay.BackColor = System.Drawing.Color.Transparent;
            this.buttonPlay.BackgroundImage = global::DIYScript_Interpreter.Properties.Resources._25b6;
            this.buttonPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPlay.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonPlay.Location = new System.Drawing.Point(653, 132);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(23, 23);
            this.buttonPlay.TabIndex = 4;
            this.buttonPlay.UseVisualStyleBackColor = false;
            // 
            // pictureBoxCurrent
            // 
            this.pictureBoxCurrent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxCurrent.Location = new System.Drawing.Point(682, 132);
            this.pictureBoxCurrent.Name = "pictureBoxCurrent";
            this.pictureBoxCurrent.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxCurrent.TabIndex = 1;
            this.pictureBoxCurrent.TabStop = false;
            this.pictureBoxCurrent.Click += new System.EventHandler(this.pictureBoxCurrent_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDel.Location = new System.Drawing.Point(13, 162);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(93, 23);
            this.buttonDel.TabIndex = 7;
            this.buttonDel.Text = "删除";
            this.buttonDel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(653, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "0/0";
            // 
            // Animater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 244);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonPause);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonAddAfter);
            this.Controls.Add(this.buttonAddBefore);
            this.Controls.Add(this.pictureBoxCurrent);
            this.Controls.Add(this.listViewFrames);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Animater";
            this.Text = "动画";
            this.Load += new System.EventHandler(this.Animater_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCurrent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCurrent;
        private System.Windows.Forms.ListView listViewFrames;
        private System.Windows.Forms.Button buttonAddBefore;
        private System.Windows.Forms.Button buttonAddAfter;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonDel;
        private Label label1;
    }
}