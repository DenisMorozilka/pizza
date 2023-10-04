using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizzeria.Strategies
{
    public class carbonara : pizzeria
    {
        void pizzeria.menu()
        {
            Console.WriteLine(" Заказ пицца карбонара");
        }


        public static void carbonara1()
        {
           
 Console.WriteLine($"Заказ пицца карбонара");
        }
    }
}

