namespace Tank
{
    partial class Remove
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Remove));
            this.lbRemove = new System.Windows.Forms.Label();
            this.numRemoveTank = new System.Windows.Forms.NumericUpDown();
            this.bRemoveTank = new System.Windows.Forms.Button();
            this.bCancelRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numRemoveTank)).BeginInit();
            this.SuspendLayout();
            // 
            // lbRemove
            // 
            this.lbRemove.AutoSize = true;
            this.lbRemove.Location = new System.Drawing.Point(30, 36);
            this.lbRemove.Name = "lbRemove";
            this.lbRemove.Size = new System.Drawing.Size(83, 13);
            this.lbRemove.TabIndex = 0;
            this.lbRemove.Text = "Index to remove";
            // 
            // numRemoveTank
            // 
            this.numRemoveTank.Location = new System.Drawing.Point(140, 28);
            this.numRemoveTank.Name = "numRemoveTank";
            this.numRemoveTank.Size = new System.Drawing.Size(62, 20);
            this.numRemoveTank.TabIndex = 1;
            // 
            // bRemoveTank
            // 
            this.bRemoveTank.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bRemoveTank.Location = new System.Drawing.Point(154, 86);
            this.bRemoveTank.Name = "bRemoveTank";
            this.bRemoveTank.Size = new System.Drawing.Size(75, 23);
            this.bRemoveTank.TabIndex = 2;
            this.bRemoveTank.Text = "Remove X";
            this.bRemoveTank.UseVisualStyleBackColor = true;
            // 
            // bCancelRemove
            // 
            this.bCancelRemove.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancelRemove.Location = new System.Drawing.Point(235, 86);
            this.bCancelRemove.Name = "bCancelRemove";
            this.bCancelRemove.Size = new System.Drawing.Size(75, 23);
            this.bCancelRemove.TabIndex = 3;
            this.bCancelRemove.Text = "Cancel";
            this.bCancelRemove.UseVisualStyleBackColor = true;
            // 
            // Remove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 121);
            this.Controls.Add(this.bCancelRemove);
            this.Controls.Add(this.bRemoveTank);
            this.Controls.Add(this.numRemoveTank);
            this.Controls.Add(this.lbRemove);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Remove";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Remove";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Remove_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numRemoveTank)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbRemove;
        private System.Windows.Forms.NumericUpDown numRemoveTank;
        private System.Windows.Forms.Button bRemoveTank;
        private System.Windows.Forms.Button bCancelRemove;
    }
}