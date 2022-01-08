
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
            this.ticker = new System.Windows.Forms.Timer(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.labelSmall = new System.Windows.Forms.Label();
            this.canvas = new System.Windows.Forms.PictureBox();
            this.labelGDI = new System.Windows.Forms.Label();
            this.labelMM42 = new System.Windows.Forms.Label();
            this.groupBoxDebugger = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelMouse = new System.Windows.Forms.Label();
            this.labelDirection = new System.Windows.Forms.Label();
            this.groupBoxRender = new System.Windows.Forms.GroupBox();
            this.labelTicked = new System.Windows.Forms.Label();
            this.labelRenderedFrame = new System.Windows.Forms.Label();
            this.trackBarSmooth = new System.Windows.Forms.TrackBar();
            this.labelSmooth = new System.Windows.Forms.Label();
            this.groupBoxState = new System.Windows.Forms.GroupBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonTickStrat = new System.Windows.Forms.Button();
            this.trackBarSpeed = new System.Windows.Forms.TrackBar();
            this.labelSpeed = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.groupBoxDebugger.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxRender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSmooth)).BeginInit();
            this.groupBoxState.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // ticker
            // 
            this.ticker.Interval = 1;
            this.ticker.Tick += new System.EventHandler(this.ticker_Tick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.labelSmall);
            this.splitContainer1.Panel1.Controls.Add(this.canvas);
            this.splitContainer1.Panel1.Controls.Add(this.labelGDI);
            this.splitContainer1.Panel1.Controls.Add(this.labelMM42);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxDebugger);
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxRender);
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxState);
            this.splitContainer1.Size = new System.Drawing.Size(1236, 548);
            this.splitContainer1.SplitterDistance = 655;
            this.splitContainer1.TabIndex = 8;
            // 
            // labelSmall
            // 
            this.labelSmall.AutoSize = true;
            this.labelSmall.Font = new System.Drawing.Font("宋体", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelSmall.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.labelSmall.Location = new System.Drawing.Point(481, 493);
            this.labelSmall.Name = "labelSmall";
            this.labelSmall.Size = new System.Drawing.Size(75, 12);
            this.labelSmall.TabIndex = 7;
            this.labelSmall.Text = "Powered by";
            // 
            // canvas
            // 
            this.canvas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.canvas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.canvas.Cursor = System.Windows.Forms.Cursors.Cross;
            this.canvas.Location = new System.Drawing.Point(11, 10);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(640, 480);
            this.canvas.TabIndex = 9;
            this.canvas.TabStop = false;
            // 
            // labelGDI
            // 
            this.labelGDI.AutoSize = true;
            this.labelGDI.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelGDI.Location = new System.Drawing.Point(542, 493);
            this.labelGDI.Name = "labelGDI";
            this.labelGDI.Size = new System.Drawing.Size(109, 46);
            this.labelGDI.TabIndex = 8;
            this.labelGDI.Text = "GDI+";
            // 
            // labelMM42
            // 
            this.labelMM42.AutoSize = true;
            this.labelMM42.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMM42.Location = new System.Drawing.Point(4, 493);
            this.labelMM42.Name = "labelMM42";
            this.labelMM42.Size = new System.Drawing.Size(342, 38);
            this.labelMM42.TabIndex = 6;
            this.labelMM42.Text = "MakerMatic42 Runtime";
            // 
            // groupBoxDebugger
            // 
            this.groupBoxDebugger.Controls.Add(this.groupBox1);
            this.groupBoxDebugger.Location = new System.Drawing.Point(282, 10);
            this.groupBoxDebugger.Name = "groupBoxDebugger";
            this.groupBoxDebugger.Size = new System.Drawing.Size(290, 528);
            this.groupBoxDebugger.TabIndex = 10;
            this.groupBoxDebugger.TabStop = false;
            this.groupBoxDebugger.Text = "运行时调试器";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelMouse);
            this.groupBox1.Controls.Add(this.labelDirection);
            this.groupBox1.Location = new System.Drawing.Point(6, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 40);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "鼠标状态";
            // 
            // labelMouse
            // 
            this.labelMouse.AutoSize = true;
            this.labelMouse.Location = new System.Drawing.Point(6, 17);
            this.labelMouse.Name = "labelMouse";
            this.labelMouse.Size = new System.Drawing.Size(53, 12);
            this.labelMouse.TabIndex = 0;
            this.labelMouse.Text = "鼠标状态";
            // 
            // labelDirection
            // 
            this.labelDirection.AutoSize = true;
            this.labelDirection.Location = new System.Drawing.Point(243, 17);
            this.labelDirection.Name = "labelDirection";
            this.labelDirection.Size = new System.Drawing.Size(29, 12);
            this.labelDirection.TabIndex = 1;
            this.labelDirection.Text = "方向";
            // 
            // groupBoxRender
            // 
            this.groupBoxRender.Controls.Add(this.labelTicked);
            this.groupBoxRender.Controls.Add(this.labelRenderedFrame);
            this.groupBoxRender.Controls.Add(this.trackBarSmooth);
            this.groupBoxRender.Controls.Add(this.labelSmooth);
            this.groupBoxRender.Location = new System.Drawing.Point(7, 430);
            this.groupBoxRender.Name = "groupBoxRender";
            this.groupBoxRender.Size = new System.Drawing.Size(269, 108);
            this.groupBoxRender.TabIndex = 9;
            this.groupBoxRender.TabStop = false;
            this.groupBoxRender.Text = "渲染与性能";
            // 
            // labelTicked
            // 
            this.labelTicked.AutoSize = true;
            this.labelTicked.Location = new System.Drawing.Point(7, 88);
            this.labelTicked.Name = "labelTicked";
            this.labelTicked.Size = new System.Drawing.Size(83, 12);
            this.labelTicked.TabIndex = 2;
            this.labelTicked.Text = "Tick数:     0";
            // 
            // labelRenderedFrame
            // 
            this.labelRenderedFrame.AutoSize = true;
            this.labelRenderedFrame.Location = new System.Drawing.Point(7, 76);
            this.labelRenderedFrame.Name = "labelRenderedFrame";
            this.labelRenderedFrame.Size = new System.Drawing.Size(83, 12);
            this.labelRenderedFrame.TabIndex = 1;
            this.labelRenderedFrame.Text = "已渲染帧数: 0";
            // 
            // trackBarSmooth
            // 
            this.trackBarSmooth.LargeChange = 1;
            this.trackBarSmooth.Location = new System.Drawing.Point(60, 46);
            this.trackBarSmooth.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.trackBarSmooth.Maximum = 4;
            this.trackBarSmooth.Name = "trackBarSmooth";
            this.trackBarSmooth.Size = new System.Drawing.Size(203, 45);
            this.trackBarSmooth.TabIndex = 6;
            // 
            // labelSmooth
            // 
            this.labelSmooth.AutoSize = true;
            this.labelSmooth.Location = new System.Drawing.Point(6, 46);
            this.labelSmooth.Name = "labelSmooth";
            this.labelSmooth.Size = new System.Drawing.Size(53, 12);
            this.labelSmooth.TabIndex = 4;
            this.labelSmooth.Text = "平滑模式";
            // 
            // groupBoxState
            // 
            this.groupBoxState.Controls.Add(this.buttonReset);
            this.groupBoxState.Controls.Add(this.buttonPause);
            this.groupBoxState.Controls.Add(this.buttonTickStrat);
            this.groupBoxState.Controls.Add(this.trackBarSpeed);
            this.groupBoxState.Controls.Add(this.labelSpeed);
            this.groupBoxState.Location = new System.Drawing.Point(7, 10);
            this.groupBoxState.Name = "groupBoxState";
            this.groupBoxState.Size = new System.Drawing.Size(269, 414);
            this.groupBoxState.TabIndex = 8;
            this.groupBoxState.TabStop = false;
            this.groupBoxState.Text = "解释器状态";
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(177, 84);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 7;
            this.buttonReset.Text = "重置";
            this.buttonReset.UseVisualStyleBackColor = true;
            // 
            // buttonPause
            // 
            this.buttonPause.Location = new System.Drawing.Point(96, 84);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(75, 23);
            this.buttonPause.TabIndex = 6;
            this.buttonPause.Text = "暂停";
            this.buttonPause.UseVisualStyleBackColor = true;
            // 
            // buttonTickStrat
            // 
            this.buttonTickStrat.Location = new System.Drawing.Point(15, 84);
            this.buttonTickStrat.Name = "buttonTickStrat";
            this.buttonTickStrat.Size = new System.Drawing.Size(75, 23);
            this.buttonTickStrat.TabIndex = 4;
            this.buttonTickStrat.Text = "起振";
            this.buttonTickStrat.UseVisualStyleBackColor = true;
            // 
            // trackBarSpeed
            // 
            this.trackBarSpeed.BackColor = System.Drawing.SystemColors.Control;
            this.trackBarSpeed.Location = new System.Drawing.Point(9, 32);
            this.trackBarSpeed.Maximum = 50;
            this.trackBarSpeed.Minimum = 1;
            this.trackBarSpeed.Name = "trackBarSpeed";
            this.trackBarSpeed.Size = new System.Drawing.Size(254, 45);
            this.trackBarSpeed.TabIndex = 3;
            this.trackBarSpeed.Value = 1;
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.BackColor = System.Drawing.Color.Transparent;
            this.labelSpeed.Location = new System.Drawing.Point(6, 17);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(71, 12);
            this.labelSpeed.TabIndex = 0;
            this.labelSpeed.Text = "时间速度: 1";
            // 
            // GamePlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 548);
            this.Controls.Add(this.splitContainer1);
            this.Name = "GamePlay";
            this.Text = "GamePlay";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GamePlay_FormClosed);
            this.Load += new System.EventHandler(this.GamePlay_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GamePlay_Paint);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.groupBoxDebugger.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxRender.ResumeLayout(false);
            this.groupBoxRender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSmooth)).EndInit();
            this.groupBoxState.ResumeLayout(false);
            this.groupBoxState.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer ticker;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label labelSmall;
        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.Label labelGDI;
        private System.Windows.Forms.Label labelMM42;
        private System.Windows.Forms.GroupBox groupBoxDebugger;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelMouse;
        private System.Windows.Forms.Label labelDirection;
        private System.Windows.Forms.GroupBox groupBoxRender;
        private System.Windows.Forms.Label labelTicked;
        private System.Windows.Forms.Label labelRenderedFrame;
        private System.Windows.Forms.TrackBar trackBarSmooth;
        private System.Windows.Forms.Label labelSmooth;
        private System.Windows.Forms.GroupBox groupBoxState;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Button buttonTickStrat;
        private System.Windows.Forms.TrackBar trackBarSpeed;
        private System.Windows.Forms.Label labelSpeed;
    }
}