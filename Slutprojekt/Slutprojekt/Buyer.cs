using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slutprojekt
{
    class Buyer : Customer
    {
        Util u = new Util();
        public Buyer()
        {
            int inventorySpace = u.generator.Next(1, 4);
            int intelligence = u.generator.Next()
        }

        

    }
}
