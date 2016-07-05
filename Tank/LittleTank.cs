using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Tank
{
    [DataContract]
    public class LittleTank : Tank
    {

        private DateTime _dDate;
        private int _iBarrelLength;

        public static LittleTank Copy(LittleTank tank, int id)
        {
            LittleTank newTank = new LittleTank(id);
            newTank.Name = tank.Name;
            newTank.Armor = tank.Armor;
            newTank.Type = tank.Type;
            newTank.Date = tank.Date;
            newTank.Barrel = tank.Barrel;
            return newTank;
        }

        public LittleTank()
        {
            
        }

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

                    DateTime date = splitString[4].GetDate();
                    if (date == DateTime.Parse("01.01.0001"))
                    {
                        throw new Exception("Cannot parse date made of tank");
                    }

                    int barrel = splitString[5].GetInt();
                    if (barrel == -1)
                    {
                        throw new Exception("Cannot parse barrel length of tank");
                    }


                    var littleTank = new LittleTank(id)
                    {
                        
                        Name = splitString[1],
                        Type = (int)TypeTank.Little,
                        Armor = armor,
                        Date = date,
                        Barrel = barrel
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
