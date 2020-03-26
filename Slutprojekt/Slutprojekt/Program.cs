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
            Stock st = new Stock();
            shopItem si = new shopItem();


           

            

            bool playing = true;

            while (playing == true)
            {

                int customerDecider = u.generator.Next(1, 3);
                if (customerDecider == 1)
                {
                    int picker = u.generator.Next(0, 3);
                    string name = st.stockBookNames[picker];
                    si.stockBookNames.Remove(name);

                    
                    

                    
                    
                    
                    

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

        public bool BuyerGui(string name, int price, int intelligence)
        {
            Console.WriteLine("This customer wants to buy something");
            Console.WriteLine("This customer wants to buy " + name);
            Console.WriteLine("The price currently is " + price + " gold");
            Console.ReadLine();
            if (intelligence > 2)
            {
                Console.WriteLine("The customer realizes that the item is overpriced");
                price -= 5;
                

                
            }
            bool success = false;
            while (success == false)
            {
                Console.WriteLine("Sell for " + price + " gold?");
                Console.WriteLine("Yes or no?");
                string answer = Console.ReadLine();
                
                string newAnswer = answer.ToLower();
                if (newAnswer == "yes") 
                {
                    success = true;
                    return true;
                   
                }
                else if (newAnswer == "no")
                {
                    success = true;
                    return false;
                }
                
                

                
                
                
            }
            

        }
    
    }
}
