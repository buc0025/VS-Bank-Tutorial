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




            /*
             * https://leetcode.com/problems/goat-latin/
             * 
             */
            string sentence = "I speak Goat Latin";
            string[] arr = sentence.Split(" ");
            var stringbuilder = new StringBuilder();
            HashSet<char> set = new HashSet<char>();

            string vowels = "AEIOUaeiou";

            for (int i = 0; i < vowels.Length; i++)
            {
                set.Add(vowels[i]);
            }

            int count = 1;

            foreach (var item in arr)
            {
                if (set.Contains(item[0]))
                {
                    stringbuilder.Append(item);
                } else
                {
                    stringbuilder.Append(item.Substring(1));
                    stringbuilder.Append(item[0]);
                }

                stringbuilder.Append("ma");

                for (int i = 0; i < count; i++)
                {
                    stringbuilder.Append("a");
                }

                count++;
                stringbuilder.Append(" ");
            }
            string result = stringbuilder.ToString().Substring(0, stringbuilder.Length - 1);
            Console.WriteLine(result);
        }
    }
}
