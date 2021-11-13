
namespace DIYScript_Interpreter
{
    partial class BGMaker
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBGName = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxImport = new System.Windows.Forms.GroupBox();
            this.trackBarSmooth = new System.Windows.Forms.TrackBar();
            this.labelSmooth = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.groupBoxImport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSmooth)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(264, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(640, 480);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(12, 440);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(148, 23);
            this.Cancel.TabIndex = 9;
            this.Cancel.Text = "取消";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(12, 469);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(148, 23);
            this.OK.TabIndex = 8;
            this.OK.Text = "确定";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "名字";
            // 
            // textBoxBGName
            // 
            this.textBoxBGName.Location = new System.Drawing.Point(47, 6);
            this.textBoxBGName.Name = "textBoxBGName";
            this.textBoxBGName.Size = new System.Drawing.Size(211, 21);
            this.textBoxBGName.TabIndex = 10;
            this.textBoxBGName.TextChanged += new System.EventHandler(this.textBoxBGName_TextChanged);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // groupBoxImport
            // 
            this.groupBoxImport.Controls.Add(this.trackBarSmooth);
            this.groupBoxImport.Controls.Add(this.labelSmooth);
            this.groupBoxImport.Location = new System.Drawing.Point(12, 33);
            this.groupBoxImport.Name = "groupBoxImport";
            this.groupBoxImport.Size = new System.Drawing.Size(246, 169);
            this.groupBoxImport.TabIndex = 12;
            this.groupBoxImport.TabStop = false;
            this.groupBoxImport.Text = "导入选项";
            // 
            // trackBarSmooth
            // 
            this.trackBarSmooth.LargeChange = 1;
            this.trackBarSmooth.Location = new System.Drawing.Point(67, 20);
            this.trackBarSmooth.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.trackBarSmooth.Maximum = 4;
            this.trackBarSmooth.Name = "trackBarSmooth";
            this.trackBarSmooth.Size = new System.Drawing.Size(173, 42);
            this.trackBarSmooth.TabIndex = 8;
            this.trackBarSmooth.Scroll += new System.EventHandler(this.trackBarSmooth_Scroll);
            // 
            // labelSmooth
            // 
            this.labelSmooth.AutoSize = true;
            this.labelSmooth.Location = new System.Drawing.Point(8, 20);
            this.labelSmooth.Name = "labelSmooth";
            this.labelSmooth.Size = new System.Drawing.Size(53, 12);
            this.labelSmooth.TabIndex = 7;
            this.labelSmooth.Text = "平滑模式";
            // 
            // BGMaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 508);
            this.Controls.Add(this.groupBoxImport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxBGName);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.pictureBox1);
            this.Name = "BGMaker";
            this.Text = "BGMaker";
            this.Load += new System.EventHandler(this.BGMaker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.groupBoxImport.ResumeLayout(false);
            this.groupBoxImport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSmooth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBGName;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.GroupBox groupBoxImport;
        private System.Windows.Forms.TrackBar trackBarSmooth;
        private System.Windows.Forms.Label labelSmooth;
    }
}