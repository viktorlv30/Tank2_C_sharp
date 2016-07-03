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
    public partial class ucHeavy : UserControl
    {
        private readonly int Id;
        public ucHeavy(int id)
        {
            InitializeComponent();
            Id = id;
        }

        public ucHeavy(HeavyTank tank)
        {
            InitializeComponent();
            tbNameHeav.Text = tank.Name;
            numArmorHeav.Value = tank.Armor;
            numCaliebrHeav.Value = tank.Caliber;
            numCrewHeav.Value = tank.Crew;
            this.Enabled = false;
        }

        public HeavyTank GetTank()
        {
            return new HeavyTank(Id)
            {
                Type = (int) TypeTank.Heavy,
                Name = tbNameHeav.Text,
                Armor = numArmorHeav.Text.GetInt(),
                Caliber = (int)numCaliebrHeav.Value,
                Crew = (int)numCrewHeav.Value
            };
        }

        public bool ValidateControl()
        {
            if (tbNameHeav.Text.Trim() == string.Empty)
            {
                return false;
            }
            if (numArmorHeav.Value <= 0 ||
                numArmorHeav.Value > 500)
            {
                return false;
            }
            if (numCaliebrHeav.Value <= 0 ||
                numCaliebrHeav.Value > 500)
            {
                return false;
            }
            if (numCrewHeav.Value < 0 ||
                numCrewHeav.Value > 100)
            {
                return false;
            }

            return true;
        }
    }
}
