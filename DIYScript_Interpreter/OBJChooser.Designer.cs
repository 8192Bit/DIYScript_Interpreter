
namespace DIYScript_Interpreter
{
    partial class OBJChooser
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "WarioILoveYou",
            "EEGEE"}, "Logo42.jpg", System.Drawing.Color.Empty, System.Drawing.SystemColors.Window, null);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OBJChooser));
            this.OK = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.OffsetX = new System.Windows.Forms.NumericUpDown();
            this.OffsetY = new System.Windows.Forms.NumericUpDown();
            this.labelOffsetX = new System.Windows.Forms.Label();
            this.labelOffsetY = new System.Windows.Forms.Label();
            this.groupBoxOffset = new System.Windows.Forms.GroupBox();
            this.listViewOBJ = new System.Windows.Forms.ListView();
            this.imageListOBJ = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.OffsetX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OffsetY)).BeginInit();
            this.groupBoxOffset.SuspendLayout();
            this.SuspendLayout();
            // 
            // OK
            // 
            this.OK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OK.Location = new System.Drawing.Point(262, 88);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(154, 26);
            this.OK.TabIndex = 0;
            this.OK.Text = "确定";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Cancel
            // 
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cancel.Location = new System.Drawing.Point(262, 120);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(154, 26);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "取消";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // OffsetX
            // 
            this.OffsetX.Location = new System.Drawing.Point(23, 15);
            this.OffsetX.Name = "OffsetX";
            this.OffsetX.Size = new System.Drawing.Size(120, 21);
            this.OffsetX.TabIndex = 2;
            // 
            // OffsetY
            // 
            this.OffsetY.Location = new System.Drawing.Point(23, 42);
            this.OffsetY.Name = "OffsetY";
            this.OffsetY.Size = new System.Drawing.Size(120, 21);
            this.OffsetY.TabIndex = 3;
            // 
            // labelOffsetX
            // 
            this.labelOffsetX.AutoSize = true;
            this.labelOffsetX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelOffsetX.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelOffsetX.Location = new System.Drawing.Point(6, 17);
            this.labelOffsetX.Name = "labelOffsetX";
            this.labelOffsetX.Size = new System.Drawing.Size(13, 14);
            this.labelOffsetX.TabIndex = 4;
            this.labelOffsetX.Text = "X";
            // 
            // labelOffsetY
            // 
            this.labelOffsetY.AutoSize = true;
            this.labelOffsetY.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelOffsetY.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelOffsetY.Location = new System.Drawing.Point(6, 44);
            this.labelOffsetY.Name = "labelOffsetY";
            this.labelOffsetY.Size = new System.Drawing.Size(13, 14);
            this.labelOffsetY.TabIndex = 5;
            this.labelOffsetY.Text = "Y";
            // 
            // groupBoxOffset
            // 
            this.groupBoxOffset.Controls.Add(this.OffsetX);
            this.groupBoxOffset.Controls.Add(this.labelOffsetY);
            this.groupBoxOffset.Controls.Add(this.OffsetY);
            this.groupBoxOffset.Controls.Add(this.labelOffsetX);
            this.groupBoxOffset.Location = new System.Drawing.Point(262, 12);
            this.groupBoxOffset.Name = "groupBoxOffset";
            this.groupBoxOffset.Size = new System.Drawing.Size(153, 70);
            this.groupBoxOffset.TabIndex = 6;
            this.groupBoxOffset.TabStop = false;
            this.groupBoxOffset.Text = "偏移";
            // 
            // listViewOBJ
            // 
            this.listViewOBJ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listViewOBJ.HideSelection = false;
            this.listViewOBJ.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listViewOBJ.LargeImageList = this.imageListOBJ;
            this.listViewOBJ.Location = new System.Drawing.Point(12, 12);
            this.listViewOBJ.Name = "listViewOBJ";
            this.listViewOBJ.Size = new System.Drawing.Size(244, 518);
            this.listViewOBJ.TabIndex = 7;
            this.listViewOBJ.UseCompatibleStateImageBehavior = false;
            this.listViewOBJ.View = System.Windows.Forms.View.Tile;
            this.listViewOBJ.SelectedIndexChanged += new System.EventHandler(this.listViewOBJ_SelectedIndexChanged);
            // 
            // imageListOBJ
            // 
            this.imageListOBJ.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListOBJ.ImageStream")));
            this.imageListOBJ.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListOBJ.Images.SetKeyName(0, "Logo42.jpg");
            // 
            // OBJChooser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 554);
            this.Controls.Add(this.listViewOBJ);
            this.Controls.Add(this.groupBoxOffset);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OBJChooser";
            this.Text = "选择对象";
            this.Load += new System.EventHandler(this.OBJChooser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OffsetX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OffsetY)).EndInit();
            this.groupBoxOffset.ResumeLayout(false);
            this.groupBoxOffset.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.NumericUpDown OffsetX;
        private System.Windows.Forms.NumericUpDown OffsetY;
        private System.Windows.Forms.Label labelOffsetX;
        private System.Windows.Forms.Label labelOffsetY;
        private System.Windows.Forms.GroupBox groupBoxOffset;
        private System.Windows.Forms.ListView listViewOBJ;
        private System.Windows.Forms.ImageList imageListOBJ;
    }
}