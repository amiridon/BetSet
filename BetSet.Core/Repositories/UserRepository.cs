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
    public class UserRepository
    {
        private List<User> Users = new List<User>()
        {
            new User
            {
                UserId = 1,
                Name = "Imamu",
                Email = "test@test.com",
                AccountNumber = "U4455",
                Password = "pass",
                BankAccountNumber = 334455656,
                RoutingNumber = 435455,
                AvailableFunds = 40
            },
            new User
            {
                UserId = 2,
                Name = "Scott",
                Email = "test2@test2.com",
                AccountNumber = "U8855",
                Password = "pass",
                BankAccountNumber = 3453678,
                RoutingNumber = 4565467,
                AvailableFunds = 200
            },
            new User
            {
                UserId = 3,
                Name = "Ginny",
                Email = "test3@test3.com",
                AccountNumber = "U8777",
                Password = "pass",
                BankAccountNumber = 666786678,
                RoutingNumber = 798797,
                AvailableFunds = 70
            },
        };

        public User GetUserById(int Id)
        {
            var user = Users.Where(u => u.UserId == Id).FirstOrDefault();
            return (User)user;
        }

        public List<User> GetUsers()
        {
            return Users;
        }
    }
}