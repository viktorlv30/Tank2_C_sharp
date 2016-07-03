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
    public partial class ucMiddle : UserControl
    {
        private readonly int Id;
        public ucMiddle(int id)
        {
            InitializeComponent();

            foreach (ColorEnum color in Enum.GetValues(typeof (ColorEnum)))
                cbColorMid.Items.Add(color);
            cbColorMid.SelectedIndex = 1;
            //cbColorMid.Items.Add(Color.Yellow);
            Id = id;
        }

        public ucMiddle(MiddleTank tank)
        {
            InitializeComponent();
            tbNameMid.Text = tank.Name;
            numArmorMid.Value = tank.Armor;
            numCisternMid.Value = tank.Cistern;
            cbColorMid.Items.Add(tank.Color);
            cbColorMid.SelectedIndex = 0;
            this.Enabled = false;
        }


        private ColorEnum GetSelectedColor()
        {
            ColorEnum color = (ColorEnum)Enum.Parse(
                typeof(ColorEnum),
                cbColorMid.SelectedItem.ToString()
                );
            return color;
        }

        public MiddleTank GetTank()
        {
            return new MiddleTank(Id)
            {
                Type = (int)TypeTank.Middle,
                Name = tbNameMid.Text,
                Armor = numArmorMid.Text.GetInt(),
                Cistern = (int)numCisternMid.Value,
                Color = GetSelectedColor().ToString()
            };
        }

        public bool ValidateControl()
        {
            if (tbNameMid.Text.Trim() == string.Empty)
            {
                return false;
            }
            if (numArmorMid.Value <= 0 ||
                numArmorMid.Value > 500)
            {
                return false;
            }
            if (numCisternMid.Value <= 0 ||
                numCisternMid.Value > 3000)
            {
                return false;
            }

            return true;
        }

    }
}
