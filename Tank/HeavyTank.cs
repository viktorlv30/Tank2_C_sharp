using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tank
{
    public class HeavyTank : Tank
    {

        private int _iGunCaliber;
        private int _iCrewNum;

        public HeavyTank(int id) : base(id)
        {
            this.Type = (int)TypeTank.Heavy;
        }

        public int Caliber { get; set; }

        public int Crew { get; set; }

        public override string ToString()
        {
            return string.Format("{0};{1};{2};{3};{4};{5}", Id, Name, TypeTank.Heavy, Armor, Caliber, Crew);
        }

        public static bool TryParse(string source, out HeavyTank result)
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



                    var heavyTank = new HeavyTank(id)
                    {
                        Armor = armor,
                        Name = splitString[1]
                    };
                    result = heavyTank;
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
