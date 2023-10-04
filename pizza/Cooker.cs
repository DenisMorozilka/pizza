using pizzeria.Strategies;
using System;

namespace pizzeria
{
    public class Cooker
    {
        public readonly string _name;

        public pizzeria _pizza;


        public Cooker(string name)
        {
            _name = name;

        }

        public void Setpizzaria(pizzeria pizza)
        {
            _pizza = pizza;
        }
        public void Cook()
        {
            Console.WriteLine(">>>");

            if (_pizza is null)
            {
                Console.WriteLine($"{_name} не может приготовить пиццу.");
                return;
            }

            Console.Write($" ");
            _pizza.menu();
            Console.WriteLine($"{_name} начал готовить пиццу");
            Console.WriteLine($"{_name} закончил готовить пиццу");

        }

    }




}

