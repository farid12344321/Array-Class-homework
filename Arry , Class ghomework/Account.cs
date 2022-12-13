using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Arry___Class_ghomework
{
    internal class Account
    {

        public void Login(string username, string password)
        {

            if (username == "cavid123" && password == "Cavid1993")
            {
                Console.WriteLine("giris ugurludur");
            }
            else
            {
                Console.WriteLine("sehvdir");
            }

        }


    }



}

























