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
using BetSet.Core.Models;

namespace BetSet.Core.Repositories
{
    public class TransactionRepository
    {
        public bool SubmitFunds(Transaction Transaction)
		{
			// Funds would get subitted to a bank and return success or fail
			return true;
		}

		public bool PlaceBet(Transaction Transaction)
		{
			// Funds would get subitted to a bank and return success or fail
			return true;
		}

		public bool WithdrawFunds(Transaction Transaction)
		{
			// Funds would get subitted to a bank and return success or fail
			return true;
		}
	}
}