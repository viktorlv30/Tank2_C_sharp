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
    public partial class Remove : Form
    {
        
        private int _iCountTank;
        private List<Tank> _lTanks; 

        public Remove()
        {
            InitializeComponent();
        }

        public Remove(List<Tank> tanks)
        {
            InitializeComponent();
            
            _lTanks = tanks;
            _iCountTank = tanks.Count;
        }

        public bool ValidateControl()
        {
            
            if (numRemoveTank.Value < 0 ||
                numRemoveTank.Value >= _iCountTank)
            {
                return false;
            }
            return true;
        }

        private void Remove_FormClosing(object sender, FormClosingEventArgs e)
        {
            var formSender = (Form)sender;
            if (formSender.DialogResult != DialogResult.Cancel)
            {
                if (ValidateControl())
                {
                    /*do  somethink*/
                    _lTanks.RemoveAt((int)numRemoveTank.Value);
                    MessageBox.Show("Good validate", "Super", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Enter correct index", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
        }

        public int GetEnteredIndex()
        {
            return (int)numRemoveTank.Value;
        }

    }
}
