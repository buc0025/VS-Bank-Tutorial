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
             * https://edabit.com/challenge/ToMXLjWDLQqFua7Wh
             * 
             */
            string phrase = "What went wrong??????????";
            //int exclaim = 0;
            //int question = 0;
            bool exclaim = false;
            bool question = false;
            int index = 0;

            for (int i = phrase.Length - 1; i >= 0; i--)
            {
                if (phrase[i] == '!')
                {
                    //exclaim++;
                    exclaim = true;
                } else if (phrase[i] == '?')
                {
                    //question++;
                    question = true;
                } else
                {
                    index = i;
                    break;
                }
            }

            var sentence = new StringBuilder(phrase.Substring(0, index + 1));

            if (exclaim)
            {
                sentence.Append('!');
            } else if (question)
            {
                sentence.Append('?');
            }

            Console.WriteLine(exclaim);
            Console.WriteLine(question);
            Console.WriteLine(sentence);

            
        }
    }
}
