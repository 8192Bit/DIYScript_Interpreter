
namespace DIYScript_Interpreter
{
    partial class GamePlay
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
            this.labelMM42 = new System.Windows.Forms.Label();
            this.labelSmall = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.canvas = new System.Windows.Forms.PictureBox();
            this.ticker = new System.Windows.Forms.Timer(this.components);
            this.groupBoxState = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.groupBoxState.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMM42
            // 
            this.labelMM42.AutoSize = true;
            this.labelMM42.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMM42.Location = new System.Drawing.Point(5, 495);
            this.labelMM42.Name = "labelMM42";
            this.labelMM42.Size = new System.Drawing.Size(342, 38);
            this.labelMM42.TabIndex = 1;
            this.labelMM42.Text = "MakerMatic42 Runtime";
            // 
            // labelSmall
            // 
            this.labelSmall.AutoSize = true;
            this.labelSmall.Font = new System.Drawing.Font("宋体", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelSmall.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.labelSmall.Location = new System.Drawing.Point(462, 495);
            this.labelSmall.Name = "labelSmall";
            this.labelSmall.Size = new System.Drawing.Size(75, 12);
            this.labelSmall.TabIndex = 2;
            this.labelSmall.Text = "Powered by";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(543, 495);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 46);
            this.label3.TabIndex = 3;
            this.label3.Text = "GDI+";
            // 
            // canvas
            // 
            this.canvas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.canvas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.canvas.Location = new System.Drawing.Point(12, 12);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(640, 480);
            this.canvas.TabIndex = 5;
            this.canvas.TabStop = false;
            // 
            // ticker
            // 
            this.ticker.Tick += new System.EventHandler(this.ticker_Tick);
            // 
            // groupBoxState
            // 
            this.groupBoxState.Controls.Add(this.label4);
            this.groupBoxState.Location = new System.Drawing.Point(659, 13);
            this.groupBoxState.Name = "groupBoxState";
            this.groupBoxState.Size = new System.Drawing.Size(269, 528);
            this.groupBoxState.TabIndex = 6;
            this.groupBoxState.TabStop = false;
            this.groupBoxState.Text = "解释器状态";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "label4";
            // 
            // GamePlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 548);
            this.Controls.Add(this.groupBoxState);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelSmall);
            this.Controls.Add(this.labelMM42);
            this.Name = "GamePlay";
            this.Text = "GamePlay";
            this.Load += new System.EventHandler(this.GamePlay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.groupBoxState.ResumeLayout(false);
            this.groupBoxState.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelMM42;
        private System.Windows.Forms.Label labelSmall;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.Timer ticker;
        private System.Windows.Forms.GroupBox groupBoxState;
        private System.Windows.Forms.Label label4;
    }
}