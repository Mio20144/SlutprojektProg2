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
        Customer c = new Customer();
        public Buyer()
        {
            int inventorySpace = u.generator.Next(1, 4);
            int intelligence = u.generator.Next(1, 4);
        }

        public void Buy(int money, int price)
        {
            if (money > price)
            {
                money -= price;

            }


        }

        public void Evaluate(int intelligence)
        {
            if (intelligence > 5)
            {

            }

        }

    }
}
