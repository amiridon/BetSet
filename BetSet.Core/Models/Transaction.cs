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
    public class Transaction
    {
        public int TransactionID { get; set; }
        public TransactionType TransactionType { get; set; }
        public int UserA_ID { get; set; }
        public int UserB_ID { get; set; }
        public int Amount { get; set; }
        public DateTime TransactionDate { get; set; }
        public string UserA_Choice { get; set; }
        public string UserB_Choice { get; set; }
        public int Winner { get; set; }
    }
}