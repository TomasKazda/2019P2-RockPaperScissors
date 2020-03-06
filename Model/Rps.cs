using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P2RockPaperScissors.Model
{
    public class Rps
    {
        public bool? IsWinner { get; set; }
        public int WinCounter { get; set; }
        public int LossCounter { get; set; }
        public int DrawCounter { get; set; }
        public RpsMode AiChoice { get; set; }
        public RpsMode UserChoice { get; set; }
    }
}
