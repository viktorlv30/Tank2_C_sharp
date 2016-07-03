namespace Tank
{
    partial class CoreTank
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoreTank));
            this.scContCore = new System.Windows.Forms.SplitContainer();
            this.lvTankList = new System.Windows.Forms.ListView();
            this.listVName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listVArmor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idTank = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openSavedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.scContCore)).BeginInit();
            this.scContCore.Panel1.SuspendLayout();
            this.scContCore.SuspendLayout();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // scContCore
            // 
            this.scContCore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scContCore.Location = new System.Drawing.Point(0, 24);
            this.scContCore.Name = "scContCore";
            // 
            // scContCore.Panel1
            // 
            this.scContCore.Panel1.Controls.Add(this.lvTankList);
            this.scContCore.Size = new System.Drawing.Size(528, 330);
            this.scContCore.SplitterDistance = 176;
            this.scContCore.TabIndex = 1;
            // 
            // lvTankList
            // 
            this.lvTankList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.listVName,
            this.listVArmor,
            this.idTank});
            this.lvTankList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvTankList.FullRowSelect = true;
            this.lvTankList.GridLines = true;
            this.lvTankList.Location = new System.Drawing.Point(0, 0);
            this.lvTankList.Name = "lvTankList";
            this.lvTankList.Size = new System.Drawing.Size(176, 330);
            this.lvTankList.TabIndex = 0;
            this.lvTankList.UseCompatibleStateImageBehavior = false;
            this.lvTankList.View = System.Windows.Forms.View.Details;
            this.lvTankList.SelectedIndexChanged += new System.EventHandler(this.lvTankList_SelectedIndexChanged);
            // 
            // listVName
            // 
            this.listVName.Text = "Name";
            this.listVName.Width = 85;
            // 
            // listVArmor
            // 
            this.listVArmor.Text = "Armor thinckness";
            this.listVArmor.Width = 82;
            // 
            // idTank
            // 
            this.idTank.Text = "Tank id";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.saveToFileToolStripMenuItem,
            this.saveToDBToolStripMenuItem,
            this.openSavedToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.toolStripSeparator1,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // saveToFileToolStripMenuItem
            // 
            this.saveToFileToolStripMenuItem.Name = "saveToFileToolStripMenuItem";
            this.saveToFileToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.saveToFileToolStripMenuItem.Text = "SaveToFile";
            this.saveToFileToolStripMenuItem.Click += new System.EventHandler(this.saveToFileToolStripMenuItem_Click);
            // 
            // saveToDBToolStripMenuItem
            // 
            this.saveToDBToolStripMenuItem.Name = "saveToDBToolStripMenuItem";
            this.saveToDBToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.saveToDBToolStripMenuItem.Text = "SaveToDB";
            // 
            // openSavedToolStripMenuItem
            // 
            this.openSavedToolStripMenuItem.Name = "openSavedToolStripMenuItem";
            this.openSavedToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.openSavedToolStripMenuItem.Text = "OpenSaved";
            this.openSavedToolStripMenuItem.Click += new System.EventHandler(this.openSavedToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(131, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // windowsToolStripMenuItem
            // 
            this.windowsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            this.windowsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.windowsToolStripMenuItem.Text = "Windows";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.exitToolStripMenuItem.Text = "Exit />";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.windowsToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(528, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // CoreTank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 354);
            this.Controls.Add(this.scContCore);
            this.Controls.Add(this.mainMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "CoreTank";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tank";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CoreTank_FormClosing);
            this.scContCore.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scContCore)).EndInit();
            this.scContCore.ResumeLayout(false);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SplitContainer scContCore;
        private System.Windows.Forms.ListView lvTankList;
        private System.Windows.Forms.ColumnHeader listVName;
        private System.Windows.Forms.ColumnHeader listVArmor;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ColumnHeader idTank;
        private System.Windows.Forms.ToolStripMenuItem saveToFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openSavedToolStripMenuItem;
    }
}

