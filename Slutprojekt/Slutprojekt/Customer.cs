using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slutprojekt
{
    class Customer
    {
        Util u = new Util();




        public Customer()
        {


            int money = u.generator.Next(20, 51);
            int charisma = u.generator.Next(1, 11);
        }
        
        


    }

    
}
