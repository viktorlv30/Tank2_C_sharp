using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tank
{
    public partial class FormAddTank : Form
    {
        private ucLittle ucLittle;
        private ucMiddle ucMiddle;
        private ucHeavy ucHeavy;

        public FormAddTank(int tankId)
        {
            InitializeComponent();

            ucLittle = new ucLittle(tankId);
            ucMiddle = new ucMiddle(tankId);
            ucHeavy = new ucHeavy(tankId);

            //cbChooseAdd.Items.Add("c h o o s e");
            cbChooseAdd.Items.Add(TypeTank.Little);
            cbChooseAdd.Items.Add(TypeTank.Middle);
            cbChooseAdd.Items.Add(TypeTank.Heavy);
            cbChooseAdd.SelectedIndex = 0;

        }

        private void cbChooseAdd_SelectedIndexChanged(object sender, EventArgs e)
        {
            var type = GetSelectedTypeTank();
            switch (type)
            {
                case TypeTank.Little:
                    panelAddTank.Controls.Clear();
                    panelAddTank.Controls.Add(ucLittle);
                    break;
                case TypeTank.Middle:
                    panelAddTank.Controls.Clear();
                    panelAddTank.Controls.Add(ucMiddle);
                    break;
                case TypeTank.Heavy:
                    panelAddTank.Controls.Clear();
                    panelAddTank.Controls.Add(ucHeavy);
                    break;
            }
        }

        private TypeTank GetSelectedTypeTank()
        {
            TypeTank type = (TypeTank) Enum.Parse(
                typeof (TypeTank),
                cbChooseAdd.SelectedItem.ToString()
                );
            return type;
        }

        public Tank GetCreatedTank()
        {
            var type = GetSelectedTypeTank();
            switch (type)
            {
                case TypeTank.Little:
                    return ucLittle.GetTank();
                case TypeTank.Middle:
                    return ucMiddle.GetTank();
                case TypeTank.Heavy:
                    return ucHeavy.GetTank();
                default:
                    return null;
            }
            
        }

        private void FormAddTank_FormClosing(object sender, FormClosingEventArgs e)
        {
            var eventSource = (Form) sender;
            if (eventSource.DialogResult != DialogResult.Cancel)
            {
                if (!ValidateControls())
                {
                    MessageBox.Show("Please, enter correct data", "Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
        }

        private bool ValidateControls()
        {
            var type = GetSelectedTypeTank();
            switch (type)
            {
                case TypeTank.Little:
                    return ucLittle.ValidateControl();
                case TypeTank.Middle:
                    return ucMiddle.ValidateControl();
                case TypeTank.Heavy:
                    return ucHeavy.ValidateControl();
                default:
                    return true;
            }
        }
    }
}
