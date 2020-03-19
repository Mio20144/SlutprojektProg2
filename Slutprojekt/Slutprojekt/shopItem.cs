using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slutprojekt
{
    class shopItem
    {
        Util u = new Util();
        public shopItem()
        {
            int price = u.generator.Next(10, 31);
        }
        

    }
}
