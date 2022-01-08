
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
            "",
            "EEGEE"}, "Logo42.jpg", System.Drawing.Color.Empty, System.Drawing.SystemColors.Window, null);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OBJChooser));
            this.OK = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.listViewOBJ = new System.Windows.Forms.ListView();
            this.imageListOBJ = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(262, 12);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(154, 26);
            this.OK.TabIndex = 0;
            this.OK.Text = "确定";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(262, 44);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(154, 26);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "取消";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
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
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OBJChooser";
            this.Text = "选择对象";
            this.Load += new System.EventHandler(this.OBJChooser_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.ListView listViewOBJ;
        private System.Windows.Forms.ImageList imageListOBJ;
    }
}