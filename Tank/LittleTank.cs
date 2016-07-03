using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tank
{
    public class LittleTank : Tank
    {

        private DateTime _dDate;
        private int _iBarrelLength;

        public LittleTank(int id) : base(id)
        {
            this.Type = (int) TypeTank.Little;
        }

        public DateTime Date { get; set; }

        public int Barrel { get; set; }

        public override string ToString()
        {
            return string.Format("{0};{1};{2};{3};{4};{5}", Id, Name, TypeTank.Little, Armor, Date.ToShortDateString(), Barrel);
        }

        public static bool TryParse(string source, out LittleTank result)
        {
            result = null;

            List<string> splitString = source.Split(';').ToList();
            try
            {
                int id = splitString[0].GetInt();
                if (id == -1)
                {
                    throw new Exception("Cannot parse id of tank");
                }
                else
                {
                    int armor = splitString[3].GetInt();
                    if (armor == -1)
                    {
                        throw new Exception("Cannot parse armor of tank");
                    }

                    //DateTime date = splitString[4].GetDate();
                    //if (date == -1)
                    //{
                    //    throw new Exception("Cannot parse date made of tank");
                    //}

                    

                    var littleTank = new LittleTank(id)
                    {
                        Armor = armor,
                        Name = splitString[1]
                    };
                    result = littleTank;
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }

            
        }


    }
}
