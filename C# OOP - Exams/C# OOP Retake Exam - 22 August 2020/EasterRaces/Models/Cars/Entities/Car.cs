using EasterRaces.Models.Cars.Contracts;
using EasterRaces.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasterRaces.Models.Cars.Entities
{
    public abstract class Car : ICar
    {
        private const int Symbols = 4;

        private string model;

        public Car(string model, int horsePower, double cubicCentimeters, int minHorsePower, int maxHorsePower)
        {
            this.Model = model;
            this.HorsePower = horsePower;
            this.CubicCentimeters = cubicCentimeters;
            this.MaxHorsePower = maxHorsePower;
            this.MinHorsePower = minHorsePower;
        }

        public int MinHorsePower { get; }

        public int MaxHorsePower { get; }

        public string Model
        {
            get
            {
                return this.model;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < Symbols)
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.InvalidModel, value, Symbols));
                }
                this.model = value;
            }
        }

        public virtual int HorsePower { get; protected set; }

        public double CubicCentimeters { get; }

        public double CalculateRacePoints(int laps)
        {
            return ((this.CubicCentimeters / this.HorsePower) * laps);
        }
    }
}
