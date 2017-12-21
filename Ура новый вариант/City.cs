using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ура_новый_вариант
{
    public class City
    {
        public Int32 ID { get; set; }
        public String Name { get; set; }
        public List<Street> StreetList { get; set; }
        public City(String aName, List<Street> aStreets)
        {
            Name = aName;
            StreetList = aStreets;
        }
    }
}
