using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaCalories
{
    class Pizza
    {
        private string name;
        private Dough dough;
        private List<Topping> toppings;

        public Pizza(string name, Dough dough)
        {
            this.Name = name;
            this.dough = dough;
            toppings = new List<Topping>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value) || value.Length > 15 || value.Length < 1)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
                else
                {
                    name = value;
                }
            }
        }
        public int ToppingsCount => toppings.Count;

        public Dough Dough
        {
            set
            {
                dough = value;
            }
        }

        public double Calories
        {
            get
            {
                return this.dough.Calories + toppings.Sum(n => n.Calories);
            }
        }

        public void AddToping(Topping topping)
        {
            if (this.toppings.Count < 10)
            {
                this.toppings.Add(topping);
            }
            else
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }
        }
    }
}
