namespace Tank
{
    partial class ucHeavy
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
            this.lbGunMmHeav = new System.Windows.Forms.Label();
            this.numCaliebrHeav = new System.Windows.Forms.NumericUpDown();
            this.lbMmArmHeav = new System.Windows.Forms.Label();
            this.numArmorHeav = new System.Windows.Forms.NumericUpDown();
            this.tbNameHeav = new System.Windows.Forms.TextBox();
            this.lbArmorHeav = new System.Windows.Forms.Label();
            this.lbGunCaliber = new System.Windows.Forms.Label();
            this.lbCrewHeav = new System.Windows.Forms.Label();
            this.lbNameHeav = new System.Windows.Forms.Label();
            this.gbHeavy = new System.Windows.Forms.GroupBox();
            this.lbCrewNum = new System.Windows.Forms.Label();
            this.numCrewHeav = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numCaliebrHeav)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numArmorHeav)).BeginInit();
            this.gbHeavy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCrewHeav)).BeginInit();
            this.SuspendLayout();
            // 
            // lbGunMmHeav
            // 
            this.lbGunMmHeav.AutoSize = true;
            this.lbGunMmHeav.Location = new System.Drawing.Point(227, 111);
            this.lbGunMmHeav.Name = "lbGunMmHeav";
            this.lbGunMmHeav.Size = new System.Drawing.Size(23, 13);
            this.lbGunMmHeav.TabIndex = 22;
            this.lbGunMmHeav.Text = "mm";
            // 
            // numCaliebrHeav
            // 
            this.numCaliebrHeav.Location = new System.Drawing.Point(102, 104);
            this.numCaliebrHeav.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numCaliebrHeav.Name = "numCaliebrHeav";
            this.numCaliebrHeav.Size = new System.Drawing.Size(120, 20);
            this.numCaliebrHeav.TabIndex = 21;
            // 
            // lbMmArmHeav
            // 
            this.lbMmArmHeav.AutoSize = true;
            this.lbMmArmHeav.Location = new System.Drawing.Point(227, 75);
            this.lbMmArmHeav.Name = "lbMmArmHeav";
            this.lbMmArmHeav.Size = new System.Drawing.Size(23, 13);
            this.lbMmArmHeav.TabIndex = 19;
            this.lbMmArmHeav.Text = "mm";
            // 
            // numArmorHeav
            // 
            this.numArmorHeav.Location = new System.Drawing.Point(101, 68);
            this.numArmorHeav.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numArmorHeav.Name = "numArmorHeav";
            this.numArmorHeav.Size = new System.Drawing.Size(120, 20);
            this.numArmorHeav.TabIndex = 15;
            // 
            // tbNameHeav
            // 
            this.tbNameHeav.Location = new System.Drawing.Point(80, 31);
            this.tbNameHeav.Name = "tbNameHeav";
            this.tbNameHeav.Size = new System.Drawing.Size(200, 20);
            this.tbNameHeav.TabIndex = 14;
            // 
            // lbArmorHeav
            // 
            this.lbArmorHeav.AutoSize = true;
            this.lbArmorHeav.Location = new System.Drawing.Point(21, 75);
            this.lbArmorHeav.Name = "lbArmorHeav";
            this.lbArmorHeav.Size = new System.Drawing.Size(34, 13);
            this.lbArmorHeav.TabIndex = 13;
            this.lbArmorHeav.Text = "Armor";
            // 
            // lbGunCaliber
            // 
            this.lbGunCaliber.AutoSize = true;
            this.lbGunCaliber.Location = new System.Drawing.Point(19, 111);
            this.lbGunCaliber.Name = "lbGunCaliber";
            this.lbGunCaliber.Size = new System.Drawing.Size(61, 13);
            this.lbGunCaliber.TabIndex = 12;
            this.lbGunCaliber.Text = "Gun caliber";
            // 
            // lbCrewHeav
            // 
            this.lbCrewHeav.AutoSize = true;
            this.lbCrewHeav.Location = new System.Drawing.Point(19, 149);
            this.lbCrewHeav.Name = "lbCrewHeav";
            this.lbCrewHeav.Size = new System.Drawing.Size(69, 13);
            this.lbCrewHeav.TabIndex = 11;
            this.lbCrewHeav.Text = "Crew number";
            // 
            // lbNameHeav
            // 
            this.lbNameHeav.AutoSize = true;
            this.lbNameHeav.Location = new System.Drawing.Point(21, 38);
            this.lbNameHeav.Name = "lbNameHeav";
            this.lbNameHeav.Size = new System.Drawing.Size(35, 13);
            this.lbNameHeav.TabIndex = 10;
            this.lbNameHeav.Text = "Name";
            // 
            // gbHeavy
            // 
            this.gbHeavy.Controls.Add(this.lbCrewNum);
            this.gbHeavy.Controls.Add(this.numCrewHeav);
            this.gbHeavy.Controls.Add(this.lbGunMmHeav);
            this.gbHeavy.Controls.Add(this.numCaliebrHeav);
            this.gbHeavy.Controls.Add(this.lbMmArmHeav);
            this.gbHeavy.Controls.Add(this.numArmorHeav);
            this.gbHeavy.Controls.Add(this.tbNameHeav);
            this.gbHeavy.Controls.Add(this.lbArmorHeav);
            this.gbHeavy.Controls.Add(this.lbGunCaliber);
            this.gbHeavy.Controls.Add(this.lbCrewHeav);
            this.gbHeavy.Controls.Add(this.lbNameHeav);
            this.gbHeavy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbHeavy.Location = new System.Drawing.Point(0, 0);
            this.gbHeavy.Name = "gbHeavy";
            this.gbHeavy.Size = new System.Drawing.Size(300, 200);
            this.gbHeavy.TabIndex = 1;
            this.gbHeavy.TabStop = false;
            this.gbHeavy.Text = "Heavy tank";
            // 
            // lbCrewNum
            // 
            this.lbCrewNum.AutoSize = true;
            this.lbCrewNum.Location = new System.Drawing.Point(227, 149);
            this.lbCrewNum.Name = "lbCrewNum";
            this.lbCrewNum.Size = new System.Drawing.Size(56, 13);
            this.lbCrewNum.TabIndex = 24;
            this.lbCrewNum.Text = "man (men)";
            // 
            // numCrewHeav
            // 
            this.numCrewHeav.Location = new System.Drawing.Point(101, 142);
            this.numCrewHeav.Name = "numCrewHeav";
            this.numCrewHeav.Size = new System.Drawing.Size(120, 20);
            this.numCrewHeav.TabIndex = 23;
            // 
            // ucHeavy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbHeavy);
            this.Name = "ucHeavy";
            this.Size = new System.Drawing.Size(300, 200);
            ((System.ComponentModel.ISupportInitialize)(this.numCaliebrHeav)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numArmorHeav)).EndInit();
            this.gbHeavy.ResumeLayout(false);
            this.gbHeavy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCrewHeav)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbGunMmHeav;
        private System.Windows.Forms.NumericUpDown numCaliebrHeav;
        private System.Windows.Forms.Label lbMmArmHeav;
        private System.Windows.Forms.NumericUpDown numArmorHeav;
        private System.Windows.Forms.TextBox tbNameHeav;
        private System.Windows.Forms.Label lbArmorHeav;
        private System.Windows.Forms.Label lbGunCaliber;
        private System.Windows.Forms.Label lbCrewHeav;
        private System.Windows.Forms.Label lbNameHeav;
        private System.Windows.Forms.GroupBox gbHeavy;
        private System.Windows.Forms.Label lbCrewNum;
        private System.Windows.Forms.NumericUpDown numCrewHeav;
    }
}
