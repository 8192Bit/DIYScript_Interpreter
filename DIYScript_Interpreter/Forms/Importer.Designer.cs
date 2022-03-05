
namespace DIYScript_Interpreter
{
    partial class Importer
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
            this.canvas = new System.Windows.Forms.PictureBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBGName = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxImport = new System.Windows.Forms.GroupBox();
            this.labelInterpolation = new System.Windows.Forms.Label();
            this.comboBoxInterpolation = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.groupBoxImport.SuspendLayout();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.canvas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.canvas.Location = new System.Drawing.Point(264, 9);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(640, 480);
            this.canvas.TabIndex = 4;
            this.canvas.TabStop = false;
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
            this.groupBoxImport.Controls.Add(this.label2);
            this.groupBoxImport.Controls.Add(this.labelInterpolation);
            this.groupBoxImport.Controls.Add(this.comboBoxInterpolation);
            this.groupBoxImport.Location = new System.Drawing.Point(12, 33);
            this.groupBoxImport.Name = "groupBoxImport";
            this.groupBoxImport.Size = new System.Drawing.Size(246, 77);
            this.groupBoxImport.TabIndex = 12;
            this.groupBoxImport.TabStop = false;
            this.groupBoxImport.Text = "导入选项";
            // 
            // labelInterpolation
            // 
            this.labelInterpolation.AutoSize = true;
            this.labelInterpolation.Location = new System.Drawing.Point(6, 17);
            this.labelInterpolation.Name = "labelInterpolation";
            this.labelInterpolation.Size = new System.Drawing.Size(53, 12);
            this.labelInterpolation.TabIndex = 10;
            this.labelInterpolation.Text = "插值模式";
            // 
            // comboBoxInterpolation
            // 
            this.comboBoxInterpolation.FormattingEnabled = true;
            this.comboBoxInterpolation.Items.AddRange(new object[] {
            "默认",
            "低质量",
            "高质量",
            "双线性插值",
            "双三次插值",
            "最邻近插值",
            "高质量双线性插值",
            "高质量双三次插值"});
            this.comboBoxInterpolation.Location = new System.Drawing.Point(65, 14);
            this.comboBoxInterpolation.Name = "comboBoxInterpolation";
            this.comboBoxInterpolation.Size = new System.Drawing.Size(173, 20);
            this.comboBoxInterpolation.TabIndex = 9;
            this.comboBoxInterpolation.SelectedIndexChanged += new System.EventHandler(this.comboBoxInterpolation_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "label2";
            // 
            // Importer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 508);
            this.Controls.Add(this.groupBoxImport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxBGName);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.canvas);
            this.Name = "Importer";
            this.Text = "导入设置";
            this.Load += new System.EventHandler(this.Importer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.groupBoxImport.ResumeLayout(false);
            this.groupBoxImport.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBGName;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.GroupBox groupBoxImport;
        private System.Windows.Forms.ComboBox comboBoxInterpolation;
        private System.Windows.Forms.Label labelInterpolation;
        private System.Windows.Forms.Label label2;
    }
}