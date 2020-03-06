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
            UserData = new Rps();
        }

        public Rps UserData { get; set; }

        public void GameRound(RpsMode userChoice)
        {
            RpsMode aiChoice = (RpsMode)random.Next(1, 4);

            if (aiChoice == RpsMode.Rock && userChoice == RpsMode.Paper ||
                aiChoice == RpsMode.Paper && userChoice == RpsMode.Scissors ||
                aiChoice == RpsMode.Scissors && userChoice == RpsMode.Rock)
            {
                UserData.WinCounter++;
                UserData.IsWinner = true;
            }
            else if (aiChoice == userChoice)
            {
                UserData.DrawCounter++;
                UserData.IsWinner = null;
            }
            else
            {
                UserData.LossCounter++;
                UserData.IsWinner = false;
            }
        }
    }
}
