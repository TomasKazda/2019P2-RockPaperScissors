using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using P2RockPaperScissors.Model;
using P2RockPaperScissors.Service;

namespace P2RockPaperScissors.Pages
{
    public class IndexModel : PageModel
    {
        private readonly RpsLogic _rpsLogic;

        public IndexModel(RpsLogic rpsLogic)
        {
            _rpsLogic = rpsLogic;
        }

        public string Message { get; set; }

        [BindProperty]
        public Rps GameData { get; set; }

        [BindProperty]
        public RpsMode UserChoice { get; set; }

        /* zahájení hry - začíná první kolo */
        public void OnGet()
        {
            Message = "Začíná hra pravidla jsou ... ty znáš :-)";
            GameData = _rpsLogic.UserData;
        }

        public void OnPost()
        {
            GameData = new Rps();
            
            if (this.ModelState.IsValid)
            {
                _rpsLogic.UserData = GameData;
                _rpsLogic.GameRound(UserChoice);
            }
            
        }
    }
}
