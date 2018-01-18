using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PacManChallenge.Data;

namespace PacManChallenge.Services
{
    public class PointsService
    {
        public Consumables GetConsumable(string action)
        {
            var consumable = new Consumables { Name = action };

            switch (action)
            {
                case "InvincibleGhost":
                    consumable.PointValue = 0;
                    break;
                case "Dot":
                    consumable.PointValue = 10;
                    break;
                case "Cherry":
                    consumable.PointValue = 100;
                    break;
                case "Strawberry":
                    consumable.PointValue = 300;
                    break;
                case "Orange":
                    consumable.PointValue = 500;
                    break;
                case "Apple":
                    consumable.PointValue = 700;
                    break;
                case "Melon":
                    consumable.PointValue = 1000;
                    break;
                case "Galaxian":
                    consumable.PointValue = 2000;
                    break;
                case "Bell":
                    consumable.PointValue = 3000;
                    break;
                case "Key":
                    consumable.PointValue = 5000;
                    break;
                case "VulnerableGhost":
                    consumable.PointValue = 200;
                    break;
                default:
                    consumable.PointValue = 0;
                    break;
            }
            return consumable;
        }

        public double GetGhostValue(Consumables consumable, double ghostValue)
        {
            if (consumable.Name == "InvincibleGhost")
                return 0;
            if (consumable.Name == "VulnerableGhost")
                return ghostValue + 1;
            return ghostValue;
        }
    }
}
