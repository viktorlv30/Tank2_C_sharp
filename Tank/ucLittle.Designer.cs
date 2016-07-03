namespace Tank
{
    partial class ucLittle
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
            this.gbLittle = new System.Windows.Forms.GroupBox();
            this.lbMmArmLit = new System.Windows.Forms.Label();
            this.lbBarrelMmLit = new System.Windows.Forms.Label();
            this.numBarrelLit = new System.Windows.Forms.NumericUpDown();
            this.dtpMadeLit = new System.Windows.Forms.DateTimePicker();
            this.numArmorLit = new System.Windows.Forms.NumericUpDown();
            this.tbNameLit = new System.Windows.Forms.TextBox();
            this.lbArmorLit = new System.Windows.Forms.Label();
            this.lbDateLit = new System.Windows.Forms.Label();
            this.lbBarrelLit = new System.Windows.Forms.Label();
            this.lbNameLittle = new System.Windows.Forms.Label();
            this.gbLittle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBarrelLit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numArmorLit)).BeginInit();
            this.SuspendLayout();
            // 
            // gbLittle
            // 
            this.gbLittle.Controls.Add(this.lbMmArmLit);
            this.gbLittle.Controls.Add(this.lbBarrelMmLit);
            this.gbLittle.Controls.Add(this.numBarrelLit);
            this.gbLittle.Controls.Add(this.dtpMadeLit);
            this.gbLittle.Controls.Add(this.numArmorLit);
            this.gbLittle.Controls.Add(this.tbNameLit);
            this.gbLittle.Controls.Add(this.lbArmorLit);
            this.gbLittle.Controls.Add(this.lbDateLit);
            this.gbLittle.Controls.Add(this.lbBarrelLit);
            this.gbLittle.Controls.Add(this.lbNameLittle);
            this.gbLittle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbLittle.Location = new System.Drawing.Point(0, 0);
            this.gbLittle.Name = "gbLittle";
            this.gbLittle.Size = new System.Drawing.Size(300, 200);
            this.gbLittle.TabIndex = 0;
            this.gbLittle.TabStop = false;
            this.gbLittle.Text = "Little tank";
            // 
            // lbMmArmLit
            // 
            this.lbMmArmLit.AutoSize = true;
            this.lbMmArmLit.Location = new System.Drawing.Point(226, 74);
            this.lbMmArmLit.Name = "lbMmArmLit";
            this.lbMmArmLit.Size = new System.Drawing.Size(23, 13);
            this.lbMmArmLit.TabIndex = 9;
            this.lbMmArmLit.Text = "mm";
            // 
            // lbBarrelMmLit
            // 
            this.lbBarrelMmLit.AutoSize = true;
            this.lbBarrelMmLit.Location = new System.Drawing.Point(226, 152);
            this.lbBarrelMmLit.Name = "lbBarrelMmLit";
            this.lbBarrelMmLit.Size = new System.Drawing.Size(23, 13);
            this.lbBarrelMmLit.TabIndex = 8;
            this.lbBarrelMmLit.Text = "mm";
            // 
            // numBarrelLit
            // 
            this.numBarrelLit.Location = new System.Drawing.Point(100, 145);
            this.numBarrelLit.Maximum = new decimal(new int[] {
            7000,
            0,
            0,
            0});
            this.numBarrelLit.Name = "numBarrelLit";
            this.numBarrelLit.Size = new System.Drawing.Size(120, 20);
            this.numBarrelLit.TabIndex = 7;
            // 
            // dtpMadeLit
            // 
            this.dtpMadeLit.Location = new System.Drawing.Point(100, 104);
            this.dtpMadeLit.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtpMadeLit.MinDate = new System.DateTime(1890, 1, 1, 0, 0, 0, 0);
            this.dtpMadeLit.Name = "dtpMadeLit";
            this.dtpMadeLit.Size = new System.Drawing.Size(179, 20);
            this.dtpMadeLit.TabIndex = 6;
            // 
            // numArmorLit
            // 
            this.numArmorLit.Location = new System.Drawing.Point(100, 67);
            this.numArmorLit.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numArmorLit.Name = "numArmorLit";
            this.numArmorLit.Size = new System.Drawing.Size(120, 20);
            this.numArmorLit.TabIndex = 5;
            // 
            // tbNameLit
            // 
            this.tbNameLit.Location = new System.Drawing.Point(79, 30);
            this.tbNameLit.Name = "tbNameLit";
            this.tbNameLit.Size = new System.Drawing.Size(200, 20);
            this.tbNameLit.TabIndex = 4;
            // 
            // lbArmorLit
            // 
            this.lbArmorLit.AutoSize = true;
            this.lbArmorLit.Location = new System.Drawing.Point(20, 74);
            this.lbArmorLit.Name = "lbArmorLit";
            this.lbArmorLit.Size = new System.Drawing.Size(34, 13);
            this.lbArmorLit.TabIndex = 3;
            this.lbArmorLit.Text = "Armor";
            // 
            // lbDateLit
            // 
            this.lbDateLit.AutoSize = true;
            this.lbDateLit.Location = new System.Drawing.Point(20, 112);
            this.lbDateLit.Name = "lbDateLit";
            this.lbDateLit.Size = new System.Drawing.Size(59, 13);
            this.lbDateLit.TabIndex = 2;
            this.lbDateLit.Text = "Date made";
            // 
            // lbBarrelLit
            // 
            this.lbBarrelLit.AutoSize = true;
            this.lbBarrelLit.Location = new System.Drawing.Point(20, 152);
            this.lbBarrelLit.Name = "lbBarrelLit";
            this.lbBarrelLit.Size = new System.Drawing.Size(66, 13);
            this.lbBarrelLit.TabIndex = 1;
            this.lbBarrelLit.Text = "Barrel length";
            // 
            // lbNameLittle
            // 
            this.lbNameLittle.AutoSize = true;
            this.lbNameLittle.Location = new System.Drawing.Point(20, 37);
            this.lbNameLittle.Name = "lbNameLittle";
            this.lbNameLittle.Size = new System.Drawing.Size(35, 13);
            this.lbNameLittle.TabIndex = 0;
            this.lbNameLittle.Text = "Name";
            // 
            // ucLittle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbLittle);
            this.Name = "ucLittle";
            this.Size = new System.Drawing.Size(300, 200);
            this.gbLittle.ResumeLayout(false);
            this.gbLittle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBarrelLit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numArmorLit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLittle;
        private System.Windows.Forms.Label lbArmorLit;
        private System.Windows.Forms.Label lbDateLit;
        private System.Windows.Forms.Label lbBarrelLit;
        private System.Windows.Forms.Label lbNameLittle;
        private System.Windows.Forms.Label lbMmArmLit;
        private System.Windows.Forms.Label lbBarrelMmLit;
        private System.Windows.Forms.NumericUpDown numBarrelLit;
        private System.Windows.Forms.DateTimePicker dtpMadeLit;
        private System.Windows.Forms.NumericUpDown numArmorLit;
        private System.Windows.Forms.TextBox tbNameLit;
    }
}
