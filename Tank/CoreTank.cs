using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tank
{
    public partial class CoreTank : Form
    {
        private int _idTank = 1;
        private List<Tank> _lTanks = new List<Tank>(); 

        public CoreTank()
        {
            InitializeComponent();
        }

        public int GetNumberTanks()
        {
            return _lTanks.Count;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddTank addt = new FormAddTank(_idTank);
            if (addt.ShowDialog() == DialogResult.OK)
            {
                var tank = addt.GetCreatedTank();
                _lTanks.Add(tank);

                AddItemToListView(tank);

                _idTank++;
            }

        }

        private void AddItemToListView(Tank tank)
        {
            var item = new ListViewItem(tank.Name);
            item.SubItems.Add(tank.Armor.ToString());
            item.SubItems.Add(_idTank.ToString());

            lvTankList.Items.Add(item);
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Remove rem = new Remove(_lTanks);
            
            if (rem.ShowDialog() == DialogResult.OK)
            {
                int indexTankDelete = rem.GetEnteredIndex();

                scContCore.Panel2.Controls.Clear();
                lvTankList.Items.RemoveAt(indexTankDelete);
            }
            
        }

        private void CoreTank_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("See later Viktor!", "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void lvTankList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var listView = (ListView) sender;
            if (listView.SelectedItems.Count > 0)
            {
                var listViewItem = listView.SelectedItems[0];

                int id = listViewItem.SubItems[2].Text.GetInt();

                foreach (var tank in _lTanks)
                {
                    if (tank.Id == id)
                    {
                        scContCore.Panel2.Controls.Clear();
                        switch (tank.Type)
                        {
                            case (int)TypeTank.Little:
                                scContCore.Panel2.Controls.Add(
                                    new ucLittle((LittleTank)tank)
                                    {
                                        Dock = DockStyle.Fill
                                    }
                                    );
                                break;
                            case (int)TypeTank.Middle:
                                scContCore.Panel2.Controls.Add(
                                    new ucMiddle((MiddleTank)tank)
                                    {
                                        Dock = DockStyle.Fill
                                    }
                                    );
                                break;
                            case (int)TypeTank.Heavy:
                                scContCore.Panel2.Controls.Add(
                                    new ucHeavy((HeavyTank)tank)
                                    {
                                        Dock = DockStyle.Fill
                                    }
                                    );
                                break;
                        }
                    }
                    
                }
            }
        }

        private void saveToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveToFile();
            //SaveToFileStreamSafe();
            //SaveToFileSimple();
        }

        private void SaveToFile()
        {
            Stream st = null;
            StreamWriter sw = null;
            try
            {
                st = new FileStream(@"d:\docs\C#\TANK_WFA\Tank_git\base.txt", FileMode.Append);
                sw = new StreamWriter(st);
                foreach (var tank in _lTanks)
                {
                    sw.Write(tank.ToString() + Environment.NewLine);
                }
                //sw.Close();
                //st.Close();
                MessageBox.Show("Saved OK", "Good", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new Exception(ex.Message, ex);
            }
            finally
            {
                if (sw != null)
                {
                    sw.Close();
                    sw.Dispose();
                }

                if (st != null)
                {
                    st.Close();
                    st.Dispose();
                }
            }
        }

        private void SaveToFileStreamSafe()
        {

            try
            {
                using (var st = new FileStream(@"d:\docs\C#\TANK_WFA\Tank_git\base.txt",
                    FileMode.Append))
                {
                    using (var sw = new StreamWriter(st))
                    {
                        foreach (var tank in _lTanks)
                        {
                            sw.Write(tank + Environment.NewLine);
                        }
                        sw.Close();
                        //sw.Dispose(); //- here Dispose() calls automatical 
                    }
                    st.Close();
                    //st.Dispose(); //- here Dispose() calls automatical
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            
        }

        private void SaveToFileSimple()
        {
            string result = String.Empty;
            foreach (var tank in _lTanks)
            {
                result += tank + Environment.NewLine;
            }

            File.AppendAllText(@"d:\docs\C#\TANK_WFA\Tank_git\base.txt", result);

        }

        private void openSavedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Text files only|*.txt";
            openFile.Multiselect = false;
            openFile.InitialDirectory = Directory.GetCurrentDirectory();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string fileText = File.ReadAllText(openFile.FileName);
                List<string> stringTanks = fileText.Split(Environment.NewLine.ToCharArray(),
                    StringSplitOptions.RemoveEmptyEntries).ToList();
                _lTanks.Clear();

                foreach (var stringTank in stringTanks)
                {
                    
                    var stringTankType = stringTank.Split(';').ToList()[2];
                    TypeTank type;
                    Enum.TryParse(stringTankType, true, out type);

                    switch (type)
                    {
                        case TypeTank.Little:
                            LittleTank lTank;
                            if (LittleTank.TryParse(stringTank, out lTank))
                            {
                                _lTanks.Add(lTank);
                                AddItemToListView(lTank);
                            }
                            break;
                        case TypeTank.Middle:
                            MiddleTank mTank;
                            if (MiddleTank.TryParse(stringTank, out mTank))
                            {
                                _lTanks.Add(mTank);
                                AddItemToListView(mTank);
                            }
                            break;
                        case TypeTank.Heavy:
                            HeavyTank hTank;
                            if (HeavyTank.TryParse(stringTank, out hTank))
                            {
                                _lTanks.Add(hTank);
                                AddItemToListView(hTank);
                            }
                            break;
                    }
                }
            }
        }
    }
}
