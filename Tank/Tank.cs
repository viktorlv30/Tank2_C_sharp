using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Tank
{
    [DataContract] //for serializator to Xml
    public class Tank : IDiscription
    {
        [DataMember] 
        private string _sName;
        [DataMember]
        private int _iArmor;
        [DataMember]
        private int _iType;
        [DataMember]
        public readonly int Id;
        

        public Tank( int id)
        {
            this.Id = id;
        }

        [DataMember]
        public string Name { get; set;}
        [DataMember]
        public int Armor { get; set; }
        [DataMember]
        public int Type { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
