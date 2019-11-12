using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ExchangeRates
{
    class Exchange
    {
        // The Arraylist gathers up all of the user's sums of money as objects
        static ArrayList wallet = new ArrayList();

        public static void addSum (Sum newSum)
        {
            wallet.Add(newSum);
        }

        // iterate through Arraylist and give the total amount in Euro
        public static void CountCoins ()
        {
            decimal total = 0;

            foreach (Sum sum in wallet)
            {
                Console.WriteLine(sum.ToString() + "("+ConvertEuro(sum)+" EUR) "+ "+");
                total += ConvertEuro(sum);
            }

            Console.WriteLine("Summa kokonaisuudessaan on: "+total + "EUR\n");
        }

        // convert individual sum to Euro and return
        private static decimal ConvertEuro(Sum convertable)
        {
            decimal Euro = 0;

            switch (convertable.Currency)
            {
                case "CAD":
                    Euro = convertable.Amount * Convert.ToDecimal(1.565);
                    break;

                case "GBP":
                    Euro = convertable.Amount * Convert.ToDecimal(0.87295);
                    break;

                case "SEK":
                    Euro = convertable.Amount * Convert.ToDecimal(10.2983);
                    break;

                case "USD":
                    Euro = convertable.Amount * Convert.ToDecimal(1.2234);
                    break;

                case "EUR":
                    Euro = convertable.Amount;
                    break;
            }

            return Math.Round(Euro, 2);
        }
    }
}
