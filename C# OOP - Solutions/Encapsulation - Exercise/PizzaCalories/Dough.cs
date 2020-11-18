using System;
using System.Collections.Generic;

namespace PizzaCalories
{
    class Dough
    {
        private double grams;
        private double grainModifier;
        private double bakingModifier;

        private const double WhiteModifier = 1.5;
        private const double WholeGrainModifier = 1;
        private const double CrispyModifier = 0.9;
        private const double ChewyModifier = 1.1;
        private const double HomemadeModifier = 1;

        public Dough(string grainModifier, string bakingModifier, double grams)
        {
            this.GrainModifier = grainModifier;
            this.BakingModifier = bakingModifier;
            this.Grams = grams;
        }

        private double Grams
        {
            set
            {
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
                else
                {
                    grams = value;
                }
            }
        }

        private string GrainModifier
        {
            set
            {
                switch (value.ToLower())
                {
                    case "white":
                        grainModifier = WhiteModifier;
                        break;
                    case "wholegrain":
                        grainModifier = WholeGrainModifier;
                        break;
                    default:
                        throw new ArgumentException("Invalid type of dough.");
                }
            }
        }

        private string BakingModifier
        {
            set
            {
                switch (value.ToLower())
                {
                    case "crispy":
                        bakingModifier = CrispyModifier;
                        break;
                    case "chewy":
                        bakingModifier = ChewyModifier;
                        break;
                    case "homemade":
                        bakingModifier = HomemadeModifier;
                        break;
                    default:
                        throw new ArgumentException("Invalid type of dough.");
                }
            }
        }

        public double Calories
        {
            get
            {
                return 2 * grams * grainModifier * bakingModifier;
            }
        }
    }
}
