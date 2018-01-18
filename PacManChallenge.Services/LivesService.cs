using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacManChallenge.Services
{
    public class LivesService
    {
        public double GetDeltaLives(string action, double points)
        {
            if (action == "InvincibleGhost")
                return -1;
            if (points >= 10000)
                return 1;
            return 0;
        }
    }
}
