using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPatternPOC
{
    public class Client
    {
        public static void Test()
        {
            //Create an instance of Concrete Component
            // base obj
            PlainPizza plainPizzaObj = new();

            //Calling the MakePizza method will create the pizza without chicken and vegetables
            string plainPizza = plainPizzaObj.MakePizza();
            Console.WriteLine(plainPizza);

            //Adding Chicken to the Plain Pizza
            //Create an instance PizzaDecorator class and 
            //pass existing plainPizzaObj as a parameter to the Constructor which we want to decorate
            // additional features
            PizzaDecorator chickenPizzaDecorator = new ChickenPizzaDecorator(plainPizzaObj);

            //Calling the MakePizza Method using the chickenPizzaDecorator object will add Chicken to the existing Plain Pizza
            string chickenPizza = chickenPizzaDecorator.MakePizza();
            Console.WriteLine("\n'" + chickenPizza + "' using ChickenPizzaDecorator");

            //The Process is the same for adding vegetables to the existing pizza
            // additional features
            VegPizzaDecorator vegPizzaDecorator = new VegPizzaDecorator(plainPizzaObj);
            string vegPizza = vegPizzaDecorator.MakePizza();
            Console.WriteLine("\n'" + vegPizza + "' using VegPizzaDecorator");
            Console.Read();
        }

    }
}
