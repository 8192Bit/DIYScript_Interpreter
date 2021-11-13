
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.buttonEditART = new System.Windows.Forms.Button();
            this.buttonDelART = new System.Windows.Forms.Button();
            this.buttonNewART = new System.Windows.Forms.Button();
            this.listViewART = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxOBJName
            // 
            this.textBoxOBJName.Location = new System.Drawing.Point(59, 12);
            this.textBoxOBJName.Name = "textBoxOBJName";
            this.textBoxOBJName.Size = new System.Drawing.Size(199, 21);
            this.textBoxOBJName.TabIndex = 0;
            this.textBoxOBJName.TextChanged += new System.EventHandler(this.textBoxOBJName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "名字";
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(1051, 687);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(148, 23);
            this.OK.TabIndex = 2;
            this.OK.Text = "确定";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // canvas
            // 
            this.canvas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.canvas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.canvas.Location = new System.Drawing.Point(559, 15);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(640, 480);
            this.canvas.TabIndex = 3;
            this.canvas.TabStop = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(71, 16);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "固定位置";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(71, 16);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "区域随机";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(969, 583);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 69);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "初始位置";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(149, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "附加到OBJ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(83, 43);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 16);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "允许重叠";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1051, 658);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(546, 501);
            this.trackBar1.Maximum = 639;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(661, 42);
            this.trackBar1.TabIndex = 8;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(546, 532);
            this.trackBar2.Maximum = 639;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(661, 42);
            this.trackBar2.TabIndex = 9;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(508, 5);
            this.trackBar3.Maximum = 479;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar3.Size = new System.Drawing.Size(42, 503);
            this.trackBar3.TabIndex = 10;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // trackBar4
            // 
            this.trackBar4.Location = new System.Drawing.Point(457, 5);
            this.trackBar4.Maximum = 479;
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar4.Size = new System.Drawing.Size(42, 503);
            this.trackBar4.TabIndex = 11;
            this.trackBar4.Scroll += new System.EventHandler(this.trackBar4_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(506, 511);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "from";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(455, 534);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "to";
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
            this.buttonEditART.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEditART.Location = new System.Drawing.Point(264, 154);
            this.buttonEditART.Name = "buttonEditART";
            this.buttonEditART.Size = new System.Drawing.Size(112, 38);
            this.buttonEditART.TabIndex = 17;
            this.buttonEditART.Text = "编辑";
            this.buttonEditART.UseVisualStyleBackColor = true;
            // 
            // buttonDelART
            // 
            this.buttonDelART.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonDelART.FlatAppearance.BorderSize = 5;
            this.buttonDelART.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDelART.Location = new System.Drawing.Point(264, 110);
            this.buttonDelART.Name = "buttonDelART";
            this.buttonDelART.Size = new System.Drawing.Size(112, 38);
            this.buttonDelART.TabIndex = 16;
            this.buttonDelART.Text = "删除";
            this.buttonDelART.UseVisualStyleBackColor = true;
            // 
            // buttonNewART
            // 
            this.buttonNewART.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonNewART.FlatAppearance.BorderSize = 5;
            this.buttonNewART.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonNewART.Location = new System.Drawing.Point(264, 66);
            this.buttonNewART.Name = "buttonNewART";
            this.buttonNewART.Size = new System.Drawing.Size(112, 38);
            this.buttonNewART.TabIndex = 15;
            this.buttonNewART.Text = "新建";
            this.buttonNewART.UseVisualStyleBackColor = true;
            this.buttonNewART.Click += new System.EventHandler(this.buttonNewART_Click);
            // 
            // listViewART
            // 
            this.listViewART.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listViewART.HideSelection = false;
            this.listViewART.Location = new System.Drawing.Point(14, 66);
            this.listViewART.Name = "listViewART";
            this.listViewART.Size = new System.Drawing.Size(244, 126);
            this.listViewART.TabIndex = 14;
            this.listViewART.UseCompatibleStateImageBehavior = false;
            this.listViewART.SelectedIndexChanged += new System.EventHandler(this.listViewART_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 18;
            this.label4.Text = "形象";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // OBJMaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 725);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonEditART);
            this.Controls.Add(this.buttonDelART);
            this.Controls.Add(this.buttonNewART);
            this.Controls.Add(this.listViewART);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBar4);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxOBJName);
            this.Name = "OBJMaker";
            this.Text = "新建OBJ......";
            this.Load += new System.EventHandler(this.OBJMaker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxOBJName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.TrackBar trackBar4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button buttonEditART;
        private System.Windows.Forms.Button buttonDelART;
        private System.Windows.Forms.Button buttonNewART;
        private System.Windows.Forms.ListView listViewART;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}