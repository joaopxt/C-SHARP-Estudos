using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy_sec5
{
    internal class Conta
    {

        //ATRIBUTOS, PRIVATES E PROPERTIES
        private string _nome { get; set; } //O nome não pode ser uma AUTOPROPERTY porque ele possui uma lógica atrelada a ele na sua função SET
        public int Numero { get; private set; } //Isso é uma AUTOPROPERTY
        public double Saldo { get; private set; }


        //CONSTRUTORES
        public Conta() { }    

        public Conta(string nome, int numero, double saldo)
        {
            _nome = nome;    
            Numero = numero;  
            Saldo = saldo;
        }

        /*
        public Conta(string nome, double saldo) {
            _nome = nome;
            Numero = Numero;
            Saldo = 0; //Mas se eu não colocasse, por padrão ela iniciaria com 0
        }*/


        //PROPERTIES CUSTOMIZADAS
        public string Nome //Isso é uma Property implementada na mão
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }


        //MÉTODOS

        public void Deposito(double quant)
        {
            Saldo = Saldo + quant;
        }
        public void Saque(double quant)
        {
            Saldo = (Saldo - quant) - 5;
        }

        public void ViewDados()
        {
            Console.WriteLine($"Conta {Numero}, Titular: {Nome}, Saldo: ${Saldo.ToString("F2")}");
        }
    }
}
