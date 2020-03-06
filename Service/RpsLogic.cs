using P2RockPaperScissors.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P2RockPaperScissors.Service
{
    public class RpsLogic
    {
        private readonly Random random;

        public RpsLogic(Random random)
        {
            this.random = random;
            userData = new Rps();
        }

        public Rps userData { get; set; }

        public void GameRound(RpsMode userChoice)
        {
            RpsMode aiChoice = (RpsMode)random.Next(1, 4);

            if (aiChoice == RpsMode.Rock && userChoice == RpsMode.Paper ||
                aiChoice == RpsMode.Paper && userChoice == RpsMode.Scissors ||
                aiChoice == RpsMode.Scissors && userChoice == RpsMode.Rock)
            {
                userData.WinCounter++;
                userData.IsWinner = true;
            }
            else if (aiChoice == userChoice)
            {
                userData.DrawCounter++;
                userData.IsWinner = null;
            }
            else
            {
                userData.LossCounter++;
                userData.IsWinner = false;
            }
        }
    }
}
