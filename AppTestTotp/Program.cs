using OtpNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTestTotp
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("ABCDEF34");
            var totp = new Totp(bytes);

            string codigo = totp.ComputeTotp(DateTime.Now);

            Console.WriteLine(codigo);
            Console.ReadKey();
        }
    }
}
