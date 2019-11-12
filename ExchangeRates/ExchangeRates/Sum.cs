using System;
using System.Collections.Generic;
using System.Text;

namespace ExchangeRates
{
    class Sum
    {
        public decimal Amount { get; set; }
        public string Currency { get; set; }



        public Sum(int selection, decimal amount)
        {
            switch (selection)
            {
                case 1:
                    this.Currency = "CAD";
                    break;
                case 2:
                    this.Currency = "GBP";
                    break;
                case 3:
                    this.Currency = "SEK";
                    break;
                case 4:
                    this.Currency = "USD";
                    break;
                case 5:
                    this.Currency = "EUR";
                    break;
            }

            this.Amount = amount;


        }

        public override string ToString()
        {
           return Amount + " " + Currency;
        }
    }
}
