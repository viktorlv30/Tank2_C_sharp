namespace Tank
{
    partial class FormAddTank
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddTank));
            this.lbChooseAdd = new System.Windows.Forms.Label();
            this.cbChooseAdd = new System.Windows.Forms.ComboBox();
            this.panelAddTank = new System.Windows.Forms.Panel();
            this.bCanselAdd = new System.Windows.Forms.Button();
            this.bSaveAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbChooseAdd
            // 
            this.lbChooseAdd.AutoSize = true;
            this.lbChooseAdd.Location = new System.Drawing.Point(24, 22);
            this.lbChooseAdd.Name = "lbChooseAdd";
            this.lbChooseAdd.Size = new System.Drawing.Size(90, 13);
            this.lbChooseAdd.TabIndex = 0;
            this.lbChooseAdd.Text = "Choose type tank";
            // 
            // cbChooseAdd
            // 
            this.cbChooseAdd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChooseAdd.FormattingEnabled = true;
            this.cbChooseAdd.Location = new System.Drawing.Point(133, 14);
            this.cbChooseAdd.Name = "cbChooseAdd";
            this.cbChooseAdd.Size = new System.Drawing.Size(137, 21);
            this.cbChooseAdd.TabIndex = 1;
            this.cbChooseAdd.SelectedIndexChanged += new System.EventHandler(this.cbChooseAdd_SelectedIndexChanged);
            // 
            // panelAddTank
            // 
            this.panelAddTank.Location = new System.Drawing.Point(27, 51);
            this.panelAddTank.Name = "panelAddTank";
            this.panelAddTank.Size = new System.Drawing.Size(310, 210);
            this.panelAddTank.TabIndex = 2;
            // 
            // bCanselAdd
            // 
            this.bCanselAdd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCanselAdd.Location = new System.Drawing.Point(281, 276);
            this.bCanselAdd.Name = "bCanselAdd";
            this.bCanselAdd.Size = new System.Drawing.Size(75, 23);
            this.bCanselAdd.TabIndex = 3;
            this.bCanselAdd.Text = "Cancel";
            this.bCanselAdd.UseVisualStyleBackColor = true;
            // 
            // bSaveAdd
            // 
            this.bSaveAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bSaveAdd.Location = new System.Drawing.Point(194, 276);
            this.bSaveAdd.Name = "bSaveAdd";
            this.bSaveAdd.Size = new System.Drawing.Size(75, 23);
            this.bSaveAdd.TabIndex = 4;
            this.bSaveAdd.Text = "Save";
            this.bSaveAdd.UseVisualStyleBackColor = true;
            // 
            // FormAddTank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 311);
            this.Controls.Add(this.bSaveAdd);
            this.Controls.Add(this.bCanselAdd);
            this.Controls.Add(this.panelAddTank);
            this.Controls.Add(this.cbChooseAdd);
            this.Controls.Add(this.lbChooseAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAddTank";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Tank";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAddTank_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbChooseAdd;
        private System.Windows.Forms.ComboBox cbChooseAdd;
        private System.Windows.Forms.Panel panelAddTank;
        private System.Windows.Forms.Button bCanselAdd;
        private System.Windows.Forms.Button bSaveAdd;
    }
}