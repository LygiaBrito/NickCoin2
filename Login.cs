using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NickCoin2
{
    class Login
    {
        public bool criterioLogar(string login, string senha)
        {
           
            if (login.Equals("admin") && senha.Equals("admin"))
            {
                Console.Clear();
                Console.WriteLine("\nLogado.");
                return true;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\nUsuário ou senha incorretos.");
                return false;
            }
        }
    }
}



       
    
