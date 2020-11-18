using System;
using System.Collections.Generic;

namespace PizzaCalories
{
    class Topping
    {
        private const double meatModifier = 1.2;
        private const double veggiesModifier = 0.8;
        private const double cheesetModifier = 1.1;
        private const double sauceModifier = 0.9;

        private double grams;
        private double modifier;
        private string type;

        public Topping(string type, double grams)
        {
            this.Type = type;
            this.Grams = grams;
        }

        private string Type
        {
            set
            {
                switch (value.ToLower())
                {
                    case "meat":
                        type = "Meat";
                        modifier = meatModifier;
                        break;
                    case "veggies":
                        type = "Veggies";
                        modifier = veggiesModifier;
                        break;
                    case "cheese":
                        type = "Cheese";
                        modifier = cheesetModifier;
                        break;
                    case "sauce":
                        type = "Sauce";
                        modifier = sauceModifier;
                        break;
                    default:
                        throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
            }
        }

        private double Grams
        {
            set
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException($"{this.type} weight should be in the range [1..50].");
                }
                else
                {
                    this.grams = value;
                }
            }
        }

        public double Calories
        {
            get
            {
                return 2 * this.grams * this.modifier;
            }
        }

    }
}

