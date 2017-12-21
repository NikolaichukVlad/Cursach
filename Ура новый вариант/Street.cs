using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ура_новый_вариант
{
    public class Street
    {
        public Int32 ID { get; set; }
        public String Name { get; set; }
        public Street(String aName)
        {
            Name = aName;
        }
    }
}
