
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GamePlay));
            this.labelMM42 = new System.Windows.Forms.Label();
            this.labelSmall = new System.Windows.Forms.Label();
            this.labelGDI = new System.Windows.Forms.Label();
            this.canvas = new System.Windows.Forms.PictureBox();
            this.ticker = new System.Windows.Forms.Timer(this.components);
            this.groupBoxState = new System.Windows.Forms.GroupBox();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonTickStrat = new System.Windows.Forms.Button();
            this.trackBarSpeed = new System.Windows.Forms.TrackBar();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelTicked = new System.Windows.Forms.Label();
            this.labelRenderedFrame = new System.Windows.Forms.Label();
            this.groupBoxRender = new System.Windows.Forms.GroupBox();
            this.comboBoxSmooth = new System.Windows.Forms.ComboBox();
            this.labelSmooth = new System.Windows.Forms.Label();
            this.labelRefresh = new System.Windows.Forms.Label();
            this.comboBoxRefresh = new System.Windows.Forms.ComboBox();
            this.groupBoxDebugger = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.groupBoxState.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxRender.SuspendLayout();
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
            this.labelSmall.Location = new System.Drawing.Point(482, 495);
            this.labelSmall.Name = "labelSmall";
            this.labelSmall.Size = new System.Drawing.Size(75, 12);
            this.labelSmall.TabIndex = 2;
            this.labelSmall.Text = "Powered by";
            // 
            // labelGDI
            // 
            this.labelGDI.AutoSize = true;
            this.labelGDI.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelGDI.Location = new System.Drawing.Point(543, 495);
            this.labelGDI.Name = "labelGDI";
            this.labelGDI.Size = new System.Drawing.Size(109, 46);
            this.labelGDI.TabIndex = 3;
            this.labelGDI.Text = "GDI+";
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
            this.ticker.Interval = 1;
            this.ticker.Tick += new System.EventHandler(this.ticker_Tick);
            // 
            // groupBoxState
            // 
            this.groupBoxState.Controls.Add(this.buttonPause);
            this.groupBoxState.Controls.Add(this.buttonTickStrat);
            this.groupBoxState.Controls.Add(this.trackBarSpeed);
            this.groupBoxState.Controls.Add(this.labelSpeed);
            this.groupBoxState.Controls.Add(this.pictureBox1);
            this.groupBoxState.Location = new System.Drawing.Point(659, 13);
            this.groupBoxState.Name = "groupBoxState";
            this.groupBoxState.Size = new System.Drawing.Size(269, 349);
            this.groupBoxState.TabIndex = 6;
            this.groupBoxState.TabStop = false;
            this.groupBoxState.Text = "解释器状态";
            // 
            // buttonPause
            // 
            this.buttonPause.Location = new System.Drawing.Point(176, 84);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(75, 23);
            this.buttonPause.TabIndex = 6;
            this.buttonPause.Text = "暂停";
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // buttonTickStrat
            // 
            this.buttonTickStrat.Location = new System.Drawing.Point(15, 84);
            this.buttonTickStrat.Name = "buttonTickStrat";
            this.buttonTickStrat.Size = new System.Drawing.Size(75, 23);
            this.buttonTickStrat.TabIndex = 4;
            this.buttonTickStrat.Text = "起振";
            this.buttonTickStrat.UseVisualStyleBackColor = true;
            this.buttonTickStrat.Click += new System.EventHandler(this.buttonTickStrat_Click);
            // 
            // trackBarSpeed
            // 
            this.trackBarSpeed.BackColor = System.Drawing.SystemColors.Control;
            this.trackBarSpeed.Location = new System.Drawing.Point(6, 32);
            this.trackBarSpeed.Maximum = 100;
            this.trackBarSpeed.Minimum = 1;
            this.trackBarSpeed.Name = "trackBarSpeed";
            this.trackBarSpeed.Size = new System.Drawing.Size(257, 42);
            this.trackBarSpeed.TabIndex = 3;
            this.trackBarSpeed.Value = 1;
            this.trackBarSpeed.Scroll += new System.EventHandler(this.trackBarSpeed_Scroll);
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.BackColor = System.Drawing.Color.Transparent;
            this.labelSpeed.Location = new System.Drawing.Point(6, 17);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(71, 12);
            this.labelSpeed.TabIndex = 0;
            this.labelSpeed.Text = "时间速度: 0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(87, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 51);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // labelTicked
            // 
            this.labelTicked.AutoSize = true;
            this.labelTicked.Location = new System.Drawing.Point(7, 79);
            this.labelTicked.Name = "labelTicked";
            this.labelTicked.Size = new System.Drawing.Size(71, 12);
            this.labelTicked.TabIndex = 2;
            this.labelTicked.Text = "Ticker数: 0";
            // 
            // labelRenderedFrame
            // 
            this.labelRenderedFrame.AutoSize = true;
            this.labelRenderedFrame.Location = new System.Drawing.Point(7, 67);
            this.labelRenderedFrame.Name = "labelRenderedFrame";
            this.labelRenderedFrame.Size = new System.Drawing.Size(83, 12);
            this.labelRenderedFrame.TabIndex = 1;
            this.labelRenderedFrame.Text = "已渲染帧数: 0";
            // 
            // groupBoxRender
            // 
            this.groupBoxRender.Controls.Add(this.comboBoxSmooth);
            this.groupBoxRender.Controls.Add(this.labelTicked);
            this.groupBoxRender.Controls.Add(this.labelSmooth);
            this.groupBoxRender.Controls.Add(this.labelRenderedFrame);
            this.groupBoxRender.Controls.Add(this.labelRefresh);
            this.groupBoxRender.Controls.Add(this.comboBoxRefresh);
            this.groupBoxRender.Location = new System.Drawing.Point(659, 368);
            this.groupBoxRender.Name = "groupBoxRender";
            this.groupBoxRender.Size = new System.Drawing.Size(269, 173);
            this.groupBoxRender.TabIndex = 7;
            this.groupBoxRender.TabStop = false;
            this.groupBoxRender.Text = "渲染与性能";
            // 
            // comboBoxSmooth
            // 
            this.comboBoxSmooth.FormattingEnabled = true;
            this.comboBoxSmooth.Items.AddRange(new object[] {
            "标准",
            "高速度",
            "高质量",
            "无",
            "抗锯齿"});
            this.comboBoxSmooth.Location = new System.Drawing.Point(65, 44);
            this.comboBoxSmooth.Name = "comboBoxSmooth";
            this.comboBoxSmooth.Size = new System.Drawing.Size(198, 20);
            this.comboBoxSmooth.TabIndex = 5;
            this.comboBoxSmooth.SelectedIndexChanged += new System.EventHandler(this.comboBoxSmooth_SelectedIndexChanged);
            // 
            // labelSmooth
            // 
            this.labelSmooth.AutoSize = true;
            this.labelSmooth.Location = new System.Drawing.Point(7, 47);
            this.labelSmooth.Name = "labelSmooth";
            this.labelSmooth.Size = new System.Drawing.Size(53, 12);
            this.labelSmooth.TabIndex = 4;
            this.labelSmooth.Text = "平滑模式";
            // 
            // labelRefresh
            // 
            this.labelRefresh.AutoSize = true;
            this.labelRefresh.Location = new System.Drawing.Point(6, 23);
            this.labelRefresh.Name = "labelRefresh";
            this.labelRefresh.Size = new System.Drawing.Size(53, 12);
            this.labelRefresh.TabIndex = 3;
            this.labelRefresh.Text = "刷新模式";
            // 
            // comboBoxRefresh
            // 
            this.comboBoxRefresh.FormattingEnabled = true;
            this.comboBoxRefresh.Items.AddRange(new object[] {
            "Ticker Only",
            "Ticker+Code DBuffer",
            "Ticker+WinForm DBuffer",
            "Winform RePaint"});
            this.comboBoxRefresh.Location = new System.Drawing.Point(65, 20);
            this.comboBoxRefresh.Name = "comboBoxRefresh";
            this.comboBoxRefresh.Size = new System.Drawing.Size(198, 20);
            this.comboBoxRefresh.TabIndex = 0;
            this.comboBoxRefresh.SelectedIndexChanged += new System.EventHandler(this.comboBoxRefresh_SelectedIndexChanged);
            // 
            // groupBoxDebugger
            // 
            this.groupBoxDebugger.Location = new System.Drawing.Point(934, 13);
            this.groupBoxDebugger.Name = "groupBoxDebugger";
            this.groupBoxDebugger.Size = new System.Drawing.Size(290, 528);
            this.groupBoxDebugger.TabIndex = 7;
            this.groupBoxDebugger.TabStop = false;
            this.groupBoxDebugger.Text = "调试器";
            // 
            // GamePlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 548);
            this.Controls.Add(this.labelSmall);
            this.Controls.Add(this.groupBoxDebugger);
            this.Controls.Add(this.groupBoxRender);
            this.Controls.Add(this.groupBoxState);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.labelGDI);
            this.Controls.Add(this.labelMM42);
            this.Name = "GamePlay";
            this.Text = "GamePlay";
            this.Load += new System.EventHandler(this.GamePlay_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GamePlay_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.groupBoxState.ResumeLayout(false);
            this.groupBoxState.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxRender.ResumeLayout(false);
            this.groupBoxRender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelMM42;
        private System.Windows.Forms.Label labelSmall;
        private System.Windows.Forms.Label labelGDI;
        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.Timer ticker;
        private System.Windows.Forms.GroupBox groupBoxState;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.GroupBox groupBoxRender;
        private System.Windows.Forms.GroupBox groupBoxDebugger;
        private System.Windows.Forms.Label labelTicked;
        private System.Windows.Forms.Label labelRenderedFrame;
        private System.Windows.Forms.ComboBox comboBoxRefresh;
        private System.Windows.Forms.Label labelRefresh;
        private System.Windows.Forms.Label labelSmooth;
        private System.Windows.Forms.ComboBox comboBoxSmooth;
        private System.Windows.Forms.TrackBar trackBarSpeed;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Button buttonTickStrat;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}