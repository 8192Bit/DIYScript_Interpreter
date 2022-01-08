
namespace DIYScript_Interpreter {
    partial class Locationer {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
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
            this.groupBoxStart = new System.Windows.Forms.GroupBox();
            this.buttonAddtoOBJ = new System.Windows.Forms.Button();
            this.checkBoxAllowOverlap = new System.Windows.Forms.CheckBox();
            this.radioButtonArea = new System.Windows.Forms.RadioButton();
            this.radioButtonPoint = new System.Windows.Forms.RadioButton();
            this.canvas = new System.Windows.Forms.PictureBox();
            this.groupBoxStart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxStart
            // 
            this.groupBoxStart.Controls.Add(this.buttonAddtoOBJ);
            this.groupBoxStart.Controls.Add(this.checkBoxAllowOverlap);
            this.groupBoxStart.Controls.Add(this.radioButtonArea);
            this.groupBoxStart.Controls.Add(this.radioButtonPoint);
            this.groupBoxStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBoxStart.Location = new System.Drawing.Point(12, 12);
            this.groupBoxStart.Name = "groupBoxStart";
            this.groupBoxStart.Size = new System.Drawing.Size(363, 69);
            this.groupBoxStart.TabIndex = 8;
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
            // 
            // canvas
            // 
            this.canvas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.canvas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.canvas.Location = new System.Drawing.Point(381, 12);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(640, 480);
            this.canvas.TabIndex = 7;
            this.canvas.TabStop = false;
            // 
            // Locationer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 509);
            this.Controls.Add(this.groupBoxStart);
            this.Controls.Add(this.canvas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Locationer";
            this.Text = "选择位置......";
            this.groupBoxStart.ResumeLayout(false);
            this.groupBoxStart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxStart;
        private System.Windows.Forms.Button buttonAddtoOBJ;
        private System.Windows.Forms.CheckBox checkBoxAllowOverlap;
        private System.Windows.Forms.RadioButton radioButtonArea;
        private System.Windows.Forms.RadioButton radioButtonPoint;
        private System.Windows.Forms.PictureBox canvas;
    }
}