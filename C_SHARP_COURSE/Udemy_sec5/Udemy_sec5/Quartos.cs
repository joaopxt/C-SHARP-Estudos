using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy_sec5
{
    internal class Quartos
    {
        public int Numero { get; set; }
        public string Hospede { get; set; }

        public string Email { get; set; }

        public void ViewDados()
        {
            Console.WriteLine($"{Numero}: {Hospede}, {Email}");
        }
    }
}
