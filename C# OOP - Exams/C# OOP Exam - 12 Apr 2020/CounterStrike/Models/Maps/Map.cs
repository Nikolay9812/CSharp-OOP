using CounterStrike.Models.Maps.Contracts;
using CounterStrike.Models.Players.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CounterStrike.Models.Maps
{
    public class Map : IMap
    {
        private ICollection<IPlayer> terrorists;
        private ICollection<IPlayer> counterTerrorists;

        public Map()
        {
            this.terrorists = new List<IPlayer>();
            this.counterTerrorists = new List<IPlayer>();
        }

        public string Start(ICollection<IPlayer> players)
        {
            foreach (var player in players)
            {
                if (player.GetType().Name == "Terrorist")
                {
                    this.terrorists.Add(player);
                }
                else if (player.GetType().Name == "CounterTerrorist")
                {
                    this.counterTerrorists.Add(player);
                }
            }

            while (true)
            {
                foreach (var terrorist in this.terrorists)
                {
                    foreach (var counterTerrorist in this.counterTerrorists)
                    {
                        if (terrorist.IsAlive && counterTerrorist.IsAlive)
                        {
                            counterTerrorist.TakeDamage(terrorist.Gun.Fire());
                        }
                    }
                }

                foreach (var counterTerrorist in this.counterTerrorists)
                {
                    foreach (var terrorist in this.terrorists)
                    {
                        if (counterTerrorist.IsAlive && terrorist.IsAlive)
                        {
                            terrorist.TakeDamage(counterTerrorist.Gun.Fire());
                        }
                    }
                }

                if (this.terrorists.All(t => t.IsAlive == false))
                {
                    return "Counter Terrorist wins!";
                }
                if (this.counterTerrorists.All(cT => cT.IsAlive == false))
                {
                    return "Terrorist wins!";
                }
            }
        }
    }
}
