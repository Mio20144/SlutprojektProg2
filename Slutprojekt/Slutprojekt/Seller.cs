﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slutprojekt
{
    class Seller : Customer
    {

        public List<string> bookNames = new List<string> { "Guide to Slaying Prices", "Swordfighting 101", "The Tale of a Bard" };

        public List<string> clothingNames = new List<string> { };
        public Seller()
        {
             
            Util u = new Util();

           


            
            string book = bookNames[u.generator.Next(0, 3)];
            





            int price = u.generator.Next(10, 21);

                

            



        }


    }
}
