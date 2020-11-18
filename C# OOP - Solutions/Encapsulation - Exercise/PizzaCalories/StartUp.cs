using System;

namespace PizzaCalories
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string pizzaName = Console.ReadLine().Split()[1];
            string[] doughArguments = Console.ReadLine().Split();

            try
            {
                var dough = new Dough(doughArguments[1], doughArguments[2], double.Parse(doughArguments[3]));
                var pizza = new Pizza(pizzaName, dough);
                while (true)
                {
                    string[] toppingInput = Console.ReadLine().Split();
                    if (toppingInput[0] == "END")
                    {
                        break;
                    }

                    var topping = new Topping(toppingInput[1], double.Parse(toppingInput[2]));
                    pizza.AddToping(topping);
                }


                Console.WriteLine($"{pizza.Name} - {pizza.Calories:F2} Calories.");
            }
            catch (Exception ae)
            {

                Console.WriteLine(ae.Message);
            }
        }
    }
}
