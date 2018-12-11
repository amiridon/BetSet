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

namespace BetSet.Core.Helper
{
    public static class Helper
    {
        public enum TransactionType
        {
            Bet = 1,
            LoadFunds = 2,
            WithdrawFunds = 3
        }

        public enum GameType
        {
            Basketball = 1,
            Football = 2
        }
    }
}