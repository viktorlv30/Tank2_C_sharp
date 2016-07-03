using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tank
{
    public class MiddleTank : Tank
    {

        private int _iCistern;
        private string _sColor;

        public MiddleTank(int id) : base(id)
        {
            this.Type = (int)TypeTank.Middle;
        }

        public int Cistern { get; set; }

        public string Color { get; set; }

        public override string ToString()
        {
            return string.Format("Tank name - {0}, type - {1}, armor thinckness - {2} mm, cistern volume - {3} litters, color - {4}", Name, TypeTank.Middle, Armor, Cistern, Color);
        }

        public static bool TryParse(string source, out MiddleTank result)
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



                    var middleTank = new MiddleTank(id)
                    {
                        Armor = armor,
                        Name = splitString[1]
                    };
                    result = middleTank;
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
