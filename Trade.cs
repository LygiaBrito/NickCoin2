using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NickCoin2
{
    static class Trade
    {
       

        public static void Menu()
            {
                bool flag = true;
                while (flag)
                {
                    Console.WriteLine("NickCoin2.0 - Logado \n");
                    Console.WriteLine("Escolha uma das opções abaixo:");
                    Console.WriteLine("1 - ");
                    Console.WriteLine("2 - ");
                    Console.WriteLine("3 - ");
                    Console.WriteLine("0 - ");
                    string op = Console.ReadLine();

                    switch (op)
                    {
                        case "1":

                            break;
                        case "2":

                            break;
                        case "3":

                            break;
                        case "0":
                            flag = false;

                            break;
                    }


                }

            }
    }
}
        
