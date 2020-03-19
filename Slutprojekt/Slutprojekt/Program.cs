using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slutprojekt
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = 0;
            Util u = new Util();
            Customer c = new Customer();
            Seller s = new Seller();
            Buyer b = new Buyer();
           
            
            
          
            bool playing = true;

            while (playing == true)
            {

                int customerDecider = u.generator.Next(1, 3);
                if (customerDecider == 1)
                {
                   
                    

                }
                else
                {

                   
                    
                    
                    
                }
                
                
                


            }




        }

        public void Tick(int day)
        {
            day++;
            if (day == 7)
            {
                day = 0;
            }
        }
    }
}
