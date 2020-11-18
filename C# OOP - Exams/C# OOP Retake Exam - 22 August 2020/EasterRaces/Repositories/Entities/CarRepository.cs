﻿using EasterRaces.Models.Cars.Contracts;
using EasterRaces.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasterRaces.Repositories.Entities
{
    public class CarRepository : IRepository<ICar>
    {
        private List<ICar> models;

        public CarRepository()
        {
            this.models = new List<ICar>();
        }

        public List<ICar> Models => this.models;

        public void Add(ICar model)
        {
            this.models.Add(model);
        }

        public IReadOnlyCollection<ICar> GetAll()
        {
            return this.models;
        }

        public ICar GetByName(string name)
        {
            return this.models.FirstOrDefault(c => c.Model == name);
        }

        public bool Remove(ICar model)
        {
            return this.models.Remove(model);
        }
    }
}
