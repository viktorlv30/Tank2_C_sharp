namespace Tank
{
    partial class ucMiddle
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbMiddle = new System.Windows.Forms.GroupBox();
            this.lbLiterMid = new System.Windows.Forms.Label();
            this.numCisternMid = new System.Windows.Forms.NumericUpDown();
            this.cbColorMid = new System.Windows.Forms.ComboBox();
            this.lbMmArmMid = new System.Windows.Forms.Label();
            this.numArmorMid = new System.Windows.Forms.NumericUpDown();
            this.tbNameMid = new System.Windows.Forms.TextBox();
            this.lbArmorMid = new System.Windows.Forms.Label();
            this.lbCisternMid = new System.Windows.Forms.Label();
            this.lbColorMid = new System.Windows.Forms.Label();
            this.lbNameMid = new System.Windows.Forms.Label();
            this.gbMiddle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCisternMid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numArmorMid)).BeginInit();
            this.SuspendLayout();
            // 
            // gbMiddle
            // 
            this.gbMiddle.Controls.Add(this.lbLiterMid);
            this.gbMiddle.Controls.Add(this.numCisternMid);
            this.gbMiddle.Controls.Add(this.cbColorMid);
            this.gbMiddle.Controls.Add(this.lbMmArmMid);
            this.gbMiddle.Controls.Add(this.numArmorMid);
            this.gbMiddle.Controls.Add(this.tbNameMid);
            this.gbMiddle.Controls.Add(this.lbArmorMid);
            this.gbMiddle.Controls.Add(this.lbCisternMid);
            this.gbMiddle.Controls.Add(this.lbColorMid);
            this.gbMiddle.Controls.Add(this.lbNameMid);
            this.gbMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbMiddle.Location = new System.Drawing.Point(0, 0);
            this.gbMiddle.Name = "gbMiddle";
            this.gbMiddle.Size = new System.Drawing.Size(300, 200);
            this.gbMiddle.TabIndex = 0;
            this.gbMiddle.TabStop = false;
            this.gbMiddle.Text = "Middle tank";
            // 
            // lbLiterMid
            // 
            this.lbLiterMid.AutoSize = true;
            this.lbLiterMid.Location = new System.Drawing.Point(227, 111);
            this.lbLiterMid.Name = "lbLiterMid";
            this.lbLiterMid.Size = new System.Drawing.Size(23, 13);
            this.lbLiterMid.TabIndex = 22;
            this.lbLiterMid.Text = "liter";
            // 
            // numCisternMid
            // 
            this.numCisternMid.Location = new System.Drawing.Point(102, 104);
            this.numCisternMid.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numCisternMid.Name = "numCisternMid";
            this.numCisternMid.Size = new System.Drawing.Size(120, 20);
            this.numCisternMid.TabIndex = 21;
            // 
            // cbColorMid
            // 
            this.cbColorMid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbColorMid.FormattingEnabled = true;
            this.cbColorMid.Location = new System.Drawing.Point(102, 141);
            this.cbColorMid.Name = "cbColorMid";
            this.cbColorMid.Size = new System.Drawing.Size(121, 21);
            this.cbColorMid.TabIndex = 20;
            // 
            // lbMmArmMid
            // 
            this.lbMmArmMid.AutoSize = true;
            this.lbMmArmMid.Location = new System.Drawing.Point(227, 75);
            this.lbMmArmMid.Name = "lbMmArmMid";
            this.lbMmArmMid.Size = new System.Drawing.Size(23, 13);
            this.lbMmArmMid.TabIndex = 19;
            this.lbMmArmMid.Text = "mm";
            // 
            // numArmorMid
            // 
            this.numArmorMid.Location = new System.Drawing.Point(101, 68);
            this.numArmorMid.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numArmorMid.Name = "numArmorMid";
            this.numArmorMid.Size = new System.Drawing.Size(120, 20);
            this.numArmorMid.TabIndex = 15;
            // 
            // tbNameMid
            // 
            this.tbNameMid.Location = new System.Drawing.Point(80, 31);
            this.tbNameMid.Name = "tbNameMid";
            this.tbNameMid.Size = new System.Drawing.Size(200, 20);
            this.tbNameMid.TabIndex = 14;
            // 
            // lbArmorMid
            // 
            this.lbArmorMid.AutoSize = true;
            this.lbArmorMid.Location = new System.Drawing.Point(21, 75);
            this.lbArmorMid.Name = "lbArmorMid";
            this.lbArmorMid.Size = new System.Drawing.Size(34, 13);
            this.lbArmorMid.TabIndex = 13;
            this.lbArmorMid.Text = "Armor";
            // 
            // lbCisternMid
            // 
            this.lbCisternMid.AutoSize = true;
            this.lbCisternMid.Location = new System.Drawing.Point(19, 111);
            this.lbCisternMid.Name = "lbCisternMid";
            this.lbCisternMid.Size = new System.Drawing.Size(76, 13);
            this.lbCisternMid.TabIndex = 12;
            this.lbCisternMid.Text = "Cistern volume";
            // 
            // lbColorMid
            // 
            this.lbColorMid.AutoSize = true;
            this.lbColorMid.Location = new System.Drawing.Point(19, 149);
            this.lbColorMid.Name = "lbColorMid";
            this.lbColorMid.Size = new System.Drawing.Size(31, 13);
            this.lbColorMid.TabIndex = 11;
            this.lbColorMid.Text = "Color";
            // 
            // lbNameMid
            // 
            this.lbNameMid.AutoSize = true;
            this.lbNameMid.Location = new System.Drawing.Point(21, 38);
            this.lbNameMid.Name = "lbNameMid";
            this.lbNameMid.Size = new System.Drawing.Size(35, 13);
            this.lbNameMid.TabIndex = 10;
            this.lbNameMid.Text = "Name";
            // 
            // ucMiddle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbMiddle);
            this.Name = "ucMiddle";
            this.Size = new System.Drawing.Size(300, 200);
            this.gbMiddle.ResumeLayout(false);
            this.gbMiddle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCisternMid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numArmorMid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMiddle;
        private System.Windows.Forms.Label lbMmArmMid;
        private System.Windows.Forms.NumericUpDown numArmorMid;
        private System.Windows.Forms.TextBox tbNameMid;
        private System.Windows.Forms.Label lbArmorMid;
        private System.Windows.Forms.Label lbCisternMid;
        private System.Windows.Forms.Label lbColorMid;
        private System.Windows.Forms.Label lbNameMid;
        private System.Windows.Forms.ComboBox cbColorMid;
        private System.Windows.Forms.Label lbLiterMid;
        private System.Windows.Forms.NumericUpDown numCisternMid;
    }
}
