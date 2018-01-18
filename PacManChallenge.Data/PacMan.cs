using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacManChallenge.Data
{
    public class PacMan
    {
        public double Points { get; set; }
        public double Lives { get; set; }

        public PacMan(double initPoints, double initLives)
        {
            this.Points = initPoints;
            this.Lives = initLives;
        }
    }
}
