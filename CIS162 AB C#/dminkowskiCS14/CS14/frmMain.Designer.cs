namespace CS14
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.tileHorizontallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeWindowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbbChild1 = new System.Windows.Forms.ToolStripButton();
            this.tbbChild2 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbChild1 = new System.Windows.Forms.ToolStripButton();
            this.tsbChild2 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit,
            this.mnuWindow});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.mnuWindow;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(419, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(37, 20);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuWindow
            // 
            this.mnuWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tileHorizontallyToolStripMenuItem,
            this.cascadeWindowsToolStripMenuItem});
            this.mnuWindow.Name = "mnuWindow";
            this.mnuWindow.Size = new System.Drawing.Size(63, 20);
            this.mnuWindow.Text = "Window";
            // 
            // tileHorizontallyToolStripMenuItem
            // 
            this.tileHorizontallyToolStripMenuItem.Name = "tileHorizontallyToolStripMenuItem";
            this.tileHorizontallyToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.tileHorizontallyToolStripMenuItem.Text = "Tile Horizontally";
            this.tileHorizontallyToolStripMenuItem.Click += new System.EventHandler(this.tileHorizontallyToolStripMenuItem_Click);
            // 
            // cascadeWindowsToolStripMenuItem
            // 
            this.cascadeWindowsToolStripMenuItem.Name = "cascadeWindowsToolStripMenuItem";
            this.cascadeWindowsToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.cascadeWindowsToolStripMenuItem.Text = "Cascade Windows";
            this.cascadeWindowsToolStripMenuItem.Click += new System.EventHandler(this.cascadeWindowsToolStripMenuItem_Click);
            // 
            // tbbChild1
            // 
            this.tbbChild1.Name = "tbbChild1";
            this.tbbChild1.Size = new System.Drawing.Size(23, 23);
            // 
            // tbbChild2
            // 
            this.tbbChild2.Name = "tbbChild2";
            this.tbbChild2.Size = new System.Drawing.Size(23, 23);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbChild1,
            this.tsbChild2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(419, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbChild1
            // 
            this.tsbChild1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbChild1.Image = ((System.Drawing.Image)(resources.GetObject("tsbChild1.Image")));
            this.tsbChild1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbChild1.Name = "tsbChild1";
            this.tsbChild1.Size = new System.Drawing.Size(23, 22);
            this.tsbChild1.Click += new System.EventHandler(this.tsbChild1_Click);
            // 
            // tsbChild2
            // 
            this.tsbChild2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbChild2.Image = ((System.Drawing.Image)(resources.GetObject("tsbChild2.Image")));
            this.tsbChild2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbChild2.Name = "tsbChild2";
            this.tsbChild2.Size = new System.Drawing.Size(23, 22);
            this.tsbChild2.Click += new System.EventHandler(this.tsbChild2_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 303);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "CS14 by Dave Minkowski";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuWindow;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontallyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeWindowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tbbChild1;
        private System.Windows.Forms.ToolStripButton tbbChild2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbChild1;
        private System.Windows.Forms.ToolStripButton tsbChild2;
    }
}

