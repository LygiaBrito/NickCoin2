using System;

namespace NickCoin2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao NickCoin2.0!");

            int i = 0;

            do
            {
                i++;
                Login usuario = new Login();
                Console.WriteLine("\nDigite suas informacões  ");
                Console.WriteLine("\nLogin:  ");
                string User = Console.ReadLine();
                Console.WriteLine("Senha:  ");
                string Pasword = Console.ReadLine();
                
                if(usuario.criterioLogar(User, Pasword))
                {
                    i = 3;
                }

            } while (i < 3);
            Console.WriteLine("Limite excedido, tente mais tarde.");
        }
    }
}
