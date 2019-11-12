using System;
using System.Collections.Generic;
using System.Text;

namespace ExchangeRates
{
    class Dialog
    {

        public static void StartDialog()
        {
            Console.WriteLine("Valuuttakurssisovellus:\n"
            + "Ohjelma laskee yhteen eri valuutoissa ilmoitettuja rahamääriä ja antaa summan euroina\n");

            ShowRates();
            RunDialog();
        }

        
        static void ShowRates() => 
            Console.WriteLine("Kurssit:\n CAD: 1,565,\n GBP: 0,87295,\n SEK: 10,2983,\n USD: 1,2234");

        static void RunDialog()
        {

            while (true)
            {
                select:
                try
                {

                    Console.WriteLine("1: Syötä rahamäärä,\n2: Tulosta summa\n3: Näytä kurssit,\n4: Tulosta summa ja lopeta");
                    int selection = Convert.ToInt32(Console.ReadLine());

                    switch (selection)
                    {
                        case 1:
                            Console.WriteLine("Valitse valuutta:\n1: CAD, 2: GBP, 3: SEK, 4: USD, 5: EUR\n");
                            int inputCurrency = Convert.ToInt32(Console.ReadLine());

                            if (inputCurrency <= 0 || inputCurrency > 5)
                            {
                                Console.WriteLine("Syötä luku väliltä 1-5!\n");
                                goto case 1;
                            }

                        input:
                            Console.Write("Syötä rahasumma muodossa \"xxx.yy\":\n");
                            try
                            {
                                Sum newSum = new Sum(inputCurrency, Math.Round(decimal.Parse(Console.ReadLine()), 2));


                                Console.WriteLine("Syötit summan: " + newSum.ToString() + "\n");
                                Exchange.addSum(newSum);
                            }
                            catch (Exception)
                            {
                                goto input;
                            }
                            break;

                        case 2:
                            Exchange.CountCoins();

                            break;

                        case 3:
                            Console.WriteLine("Kurssit:\n CAD: 1,565,\n GBP: 0,87295,\n SEK: 10,2983,\n USD: 1,2234\n");
                            break;

                        case 4:
                            Exchange.CountCoins();
                            Environment.Exit(1);
                            break;

                        default:
                            Console.WriteLine("Vastaa syöttämällä luku 1-4\n");
                            break;
                    }
                } catch (Exception)
                {
                    goto select;
                }
            }
        }
        

    }
}
