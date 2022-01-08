
namespace DIYScript_Interpreter
{
    partial class OBJMaker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBoxOBJName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OK = new System.Windows.Forms.Button();
            this.canvas = new System.Windows.Forms.PictureBox();
            this.radioButtonPoint = new System.Windows.Forms.RadioButton();
            this.radioButtonArea = new System.Windows.Forms.RadioButton();
            this.groupBoxStart = new System.Windows.Forms.GroupBox();
            this.buttonAddtoOBJ = new System.Windows.Forms.Button();
            this.checkBoxAllowOverlap = new System.Windows.Forms.CheckBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.buttonEditART = new System.Windows.Forms.Button();
            this.buttonDelART = new System.Windows.Forms.Button();
            this.buttonNewART = new System.Windows.Forms.Button();
            this.listViewART = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonNormalART = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.groupBoxStart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxOBJName
            // 
            this.textBoxOBJName.Location = new System.Drawing.Point(47, 12);
            this.textBoxOBJName.Name = "textBoxOBJName";
            this.textBoxOBJName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxOBJName.Size = new System.Drawing.Size(209, 21);
            this.textBoxOBJName.TabIndex = 0;
            this.textBoxOBJName.TextChanged += new System.EventHandler(this.textBoxOBJName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "名字";
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(12, 466);
            this.OK.Name = "OK";
            this.OK.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.OK.Size = new System.Drawing.Size(125, 23);
            this.OK.TabIndex = 2;
            this.OK.Text = "确定";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // canvas
            // 
            this.canvas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.canvas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.canvas.Location = new System.Drawing.Point(381, 12);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(640, 480);
            this.canvas.TabIndex = 3;
            this.canvas.TabStop = false;
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseDown);
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            this.canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseUp);
            // 
            // radioButtonPoint
            // 
            this.radioButtonPoint.AutoSize = true;
            this.radioButtonPoint.Location = new System.Drawing.Point(6, 20);
            this.radioButtonPoint.Name = "radioButtonPoint";
            this.radioButtonPoint.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioButtonPoint.Size = new System.Drawing.Size(71, 16);
            this.radioButtonPoint.TabIndex = 4;
            this.radioButtonPoint.Text = "固定位置";
            this.radioButtonPoint.UseVisualStyleBackColor = true;
            this.radioButtonPoint.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButtonArea
            // 
            this.radioButtonArea.AutoSize = true;
            this.radioButtonArea.Location = new System.Drawing.Point(6, 42);
            this.radioButtonArea.Name = "radioButtonArea";
            this.radioButtonArea.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioButtonArea.Size = new System.Drawing.Size(71, 16);
            this.radioButtonArea.TabIndex = 5;
            this.radioButtonArea.Text = "区域随机";
            this.radioButtonArea.UseVisualStyleBackColor = true;
            this.radioButtonArea.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // groupBoxStart
            // 
            this.groupBoxStart.Controls.Add(this.buttonAddtoOBJ);
            this.groupBoxStart.Controls.Add(this.checkBoxAllowOverlap);
            this.groupBoxStart.Controls.Add(this.radioButtonArea);
            this.groupBoxStart.Controls.Add(this.radioButtonPoint);
            this.groupBoxStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBoxStart.Location = new System.Drawing.Point(12, 191);
            this.groupBoxStart.Name = "groupBoxStart";
            this.groupBoxStart.Size = new System.Drawing.Size(363, 69);
            this.groupBoxStart.TabIndex = 6;
            this.groupBoxStart.TabStop = false;
            this.groupBoxStart.Text = "初始位置";
            // 
            // buttonAddtoOBJ
            // 
            this.buttonAddtoOBJ.Location = new System.Drawing.Point(250, 13);
            this.buttonAddtoOBJ.Name = "buttonAddtoOBJ";
            this.buttonAddtoOBJ.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonAddtoOBJ.Size = new System.Drawing.Size(107, 23);
            this.buttonAddtoOBJ.TabIndex = 7;
            this.buttonAddtoOBJ.Text = "附加到OBJ...";
            this.buttonAddtoOBJ.UseVisualStyleBackColor = true;
            this.buttonAddtoOBJ.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBoxAllowOverlap
            // 
            this.checkBoxAllowOverlap.AutoSize = true;
            this.checkBoxAllowOverlap.Enabled = false;
            this.checkBoxAllowOverlap.Location = new System.Drawing.Point(83, 43);
            this.checkBoxAllowOverlap.Name = "checkBoxAllowOverlap";
            this.checkBoxAllowOverlap.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBoxAllowOverlap.Size = new System.Drawing.Size(72, 16);
            this.checkBoxAllowOverlap.TabIndex = 6;
            this.checkBoxAllowOverlap.Text = "允许重叠";
            this.checkBoxAllowOverlap.UseVisualStyleBackColor = true;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(12, 437);
            this.Cancel.Name = "Cancel";
            this.Cancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Cancel.Size = new System.Drawing.Size(125, 23);
            this.Cancel.TabIndex = 7;
            this.Cancel.Text = "取消";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // buttonEditART
            // 
            this.buttonEditART.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonEditART.FlatAppearance.BorderSize = 5;
            this.buttonEditART.Location = new System.Drawing.Point(262, 121);
            this.buttonEditART.Name = "buttonEditART";
            this.buttonEditART.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonEditART.Size = new System.Drawing.Size(113, 25);
            this.buttonEditART.TabIndex = 17;
            this.buttonEditART.Text = "编辑";
            this.buttonEditART.UseVisualStyleBackColor = true;
            // 
            // buttonDelART
            // 
            this.buttonDelART.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonDelART.FlatAppearance.BorderSize = 5;
            this.buttonDelART.Location = new System.Drawing.Point(262, 90);
            this.buttonDelART.Name = "buttonDelART";
            this.buttonDelART.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonDelART.Size = new System.Drawing.Size(113, 25);
            this.buttonDelART.TabIndex = 16;
            this.buttonDelART.Text = "删除";
            this.buttonDelART.UseVisualStyleBackColor = true;
            // 
            // buttonNewART
            // 
            this.buttonNewART.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonNewART.FlatAppearance.BorderSize = 5;
            this.buttonNewART.Location = new System.Drawing.Point(262, 59);
            this.buttonNewART.Name = "buttonNewART";
            this.buttonNewART.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonNewART.Size = new System.Drawing.Size(113, 25);
            this.buttonNewART.TabIndex = 15;
            this.buttonNewART.Text = "新建";
            this.buttonNewART.UseVisualStyleBackColor = true;
            this.buttonNewART.Click += new System.EventHandler(this.buttonNewART_Click);
            // 
            // listViewART
            // 
            this.listViewART.HideSelection = false;
            this.listViewART.Location = new System.Drawing.Point(12, 59);
            this.listViewART.Name = "listViewART";
            this.listViewART.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listViewART.Size = new System.Drawing.Size(244, 126);
            this.listViewART.TabIndex = 14;
            this.listViewART.UseCompatibleStateImageBehavior = false;
            this.listViewART.SelectedIndexChanged += new System.EventHandler(this.listViewART_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 18;
            this.label2.Text = "形象";
            this.label2.Click += new System.EventHandler(this.label4_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // buttonNormalART
            // 
            this.buttonNormalART.Enabled = false;
            this.buttonNormalART.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonNormalART.FlatAppearance.BorderSize = 5;
            this.buttonNormalART.Location = new System.Drawing.Point(262, 152);
            this.buttonNormalART.Name = "buttonNormalART";
            this.buttonNormalART.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonNormalART.Size = new System.Drawing.Size(113, 25);
            this.buttonNormalART.TabIndex = 19;
            this.buttonNormalART.Text = "设为默认形象...";
            this.buttonNormalART.UseVisualStyleBackColor = true;
            // 
            // OBJMaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 501);
            this.Controls.Add(this.buttonNormalART);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonEditART);
            this.Controls.Add(this.buttonDelART);
            this.Controls.Add(this.buttonNewART);
            this.Controls.Add(this.listViewART);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.groupBoxStart);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxOBJName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "OBJMaker";
            this.Text = "新建OBJ......";
            this.Load += new System.EventHandler(this.OBJMaker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.groupBoxStart.ResumeLayout(false);
            this.groupBoxStart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxOBJName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.RadioButton radioButtonPoint;
        private System.Windows.Forms.RadioButton radioButtonArea;
        private System.Windows.Forms.GroupBox groupBoxStart;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.CheckBox checkBoxAllowOverlap;
        private System.Windows.Forms.Button buttonAddtoOBJ;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button buttonEditART;
        private System.Windows.Forms.Button buttonDelART;
        private System.Windows.Forms.Button buttonNewART;
        private System.Windows.Forms.ListView listViewART;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button buttonNormalART;
    }
}