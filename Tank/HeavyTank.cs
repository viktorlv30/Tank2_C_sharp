using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Tank
{
    [DataContract]
    public class HeavyTank : Tank
    {

        private int _iGunCaliber;
        private int _iCrewNum;

        public HeavyTank()
        {

        }

        public static HeavyTank Copy(HeavyTank tank, int id)
        {
            HeavyTank newTank = new HeavyTank(id);
            newTank.Name = tank.Name;
            newTank.Armor = tank.Armor;
            newTank.Type = tank.Type;
            newTank.Caliber = tank.Caliber;
            newTank.Crew = tank.Crew;
            return newTank;
        }

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

                    int caliber = splitString[4].GetInt();
                    if (caliber == -1)
                    {
                        throw new Exception("Cannot parse barrel's caliber of tank");
                    }

                    int crew = splitString[5].GetInt();
                    if (crew == -1)
                    {
                        throw new Exception("Cannot parse crew number of tank");
                    }

                    var heavyTank = new HeavyTank(id)
                    {
                        Name = splitString[1],
                        Type = (int)TypeTank.Heavy,
                        Armor = armor,
                        Caliber = caliber,
                        Crew = crew
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
