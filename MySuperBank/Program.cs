using System;
using System.Collections.Generic;
using System.Text;

namespace MySuperBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //var account = new BankAccount("Stanley", 10000);
            //var account2 = new BankAccount("Nancy", 500000);
            //Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}.");
            //Console.WriteLine($"Account {account2.Number} was created for {account2.Owner} with {account2.Balance}.");

            //account.MakeWithdrawal(120, DateTime.Now, "Hammock");
            //Console.WriteLine(account.Balance);

            //account.MakeWithdrawal(50, DateTime.Now, "Xbox Game");
            //Console.WriteLine(account.Balance);

            //Console.WriteLine(account.GetAccountHistory());


            // Test for a negative balance:
            //try
            //{
            //    account.MakeWithdrawal(75000, DateTime.Now, "Attempt to overdraw");
            //}
            //catch (InvalidOperationException e)
            //{
            //    Console.WriteLine("Exception caught trying to overdraw");
            //    Console.WriteLine(e.ToString());
            //}

            //// Test that the initial balances must be positive.
            //try
            //{
            //    var invalidAccount = new BankAccount("invalid", -55);
            //}
            //catch (ArgumentOutOfRangeException e)
            //{
            //    Console.WriteLine("Exception caught creating account with negative balance");
            //    Console.WriteLine(e.ToString());
            //}

            int[] arr = { 5, 5, 10, 10, 15, 15, 20, 20 };

            string str = "Someone is outside the doorway";

            string[] words = str.Split(" ");

            Console.WriteLine(IsSmooth(str));




        }

        //https://edabit.com/challenge/SkY5Nw3rS7WvkQmFc
        public static bool IsSmooth(string sentence)
        {
            string[] words = sentence.Split(" ");
            char end = words[0][words[0].Length - 1];

            for (int i = 1; i < words.Length; i++)
            {
                if (end != words[i][0])
                {
                    return false;
                }

                end = words[i][words[i].Length - 1];
            }

            return true;
        }
    }
}
