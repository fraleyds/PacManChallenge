using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PacManChallenge.Data;
using PacManChallenge.Services;

namespace PacManChallenge.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var pacMan = new PacMan(5000, 3);
            var tempPoints = pacMan.Points;
            var actionsListing = new ActionsListing();
            var livesService = new LivesService();
            var pointsService = new PointsService();
            double ghostValue = 0;
            double livesGained = 0;

            var actionsArray = actionsListing.GetActionsArray("C:\\DotNetProjects\\PacManChallenge\\PacManChallenge.Data\\katapacman-seq.csv");

            foreach (var action in actionsArray)
            {
                var consumable = pointsService.GetConsumable(action);   
                var deltaPoints = consumable.PointValue;
                var tempGhostValue = pointsService.GetGhostValue(consumable, ghostValue);
                ghostValue = tempGhostValue;
                if (consumable.Name == "VulnerableGhost")
                    deltaPoints = deltaPoints * Math.Pow(ghostValue, ghostValue - 1);
                tempPoints += deltaPoints;
                pacMan.Points += deltaPoints;
                var deltaLives = livesService.GetDeltaLives(action, tempPoints);
                pacMan.Lives += deltaLives;
                if (deltaLives == 1)
                {
                    tempPoints -= 10000;
                    livesGained++;
                }
                if (pacMan.Lives < 1)
                    break;
                Console.WriteLine(consumable.Name + deltaPoints);
            }
            if (pacMan.Lives < 1)
            {
                Console.WriteLine($"Game over. You had {pacMan.Points} points and gained {livesGained} extra lives.");
            }
            else
            {
                Console.WriteLine($"You earned {pacMan.Points} points and ended the game with {pacMan.Lives} lives, with {livesGained} extra lives.");
            }

        }
    }
}
