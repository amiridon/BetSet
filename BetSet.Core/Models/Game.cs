using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using static BetSet.Core.Helper.Helper;

namespace BetSet.Core.Models
{
    public class Game
    {
        public int GameID { get; set; }
        public GameType GameType { get; set; }
        public string TeamA { get; set; }
        public string TeamB { get; set; }
        public DateTime EventDate { get; set; }
        public string Winner { get; set; }
        public string FinalScore { get; set; }
    }
}