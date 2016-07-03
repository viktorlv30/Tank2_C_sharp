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
            return string.Format("{0};{1};{2};{3};{4};{5}", Id, Name, TypeTank.Middle, Armor, Cistern, Color);
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

                    int cistern = splitString[4].GetInt();
                    if (cistern == -1)
                    {
                        throw new Exception("Cannot parse cistern volume of tank");
                    }
                    
                    var middleTank = new MiddleTank(id)
                    {
                        Name = splitString[1],
                        Type = (int)TypeTank.Middle,
                        Armor = armor,
                        Cistern = cistern,
                        Color = splitString[5]
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
