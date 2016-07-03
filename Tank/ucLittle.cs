using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tank
{
    public partial class ucLittle : UserControl
    {

        private readonly int Id;
        
        public ucLittle(int id)
        {
            InitializeComponent();
            Id = id;
        }

        public ucLittle(LittleTank tank)
        {
            InitializeComponent();
            tbNameLit.Text = tank.Name;
            numArmorLit.Value = tank.Armor; 
            dtpMadeLit.Value = tank.Date;
            numBarrelLit.Value = tank.Barrel;
            this.Enabled = false;
        }
        
        public LittleTank GetTank()
        {
            return new LittleTank(Id)
            {
                Type = (int) TypeTank.Little,
                Name = tbNameLit.Text,
                Armor = (int)numArmorLit.Value,
                Date = dtpMadeLit.Value,
                Barrel = (int)numBarrelLit.Value
            };
        }

        public bool ValidateControl()
        {
            if (tbNameLit.Text.Trim() == string.Empty)
            {
                return false;
            }
            if (numArmorLit.Value <= 0 ||
                numArmorLit.Value > 500)
            {
                return false;
            }
            if (dtpMadeLit.Value.Year < 1890 ||
                dtpMadeLit.Value > DateTime.Now)
            {
                return false;
            }
            if (numBarrelLit.Value <= 0 ||
                numBarrelLit.Value > 7000)
            {
                return false;
            }
            return true;
        }

    }
}
