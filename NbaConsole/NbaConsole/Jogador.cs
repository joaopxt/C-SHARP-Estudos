using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NbaConsole;
internal class Jogador {

    protected string Nome { get; set; }
    protected double Altura { get; set; }
    protected double Fisico { get; set; }
    public double Defesa { get; set; }
    public double Ataque { get; set; }

    protected Jogador(string nome,int altura, int fisico, int defesa, int ataque) {
        Nome = nome;
        Altura = altura;
        Fisico = fisico;
        Defesa = defesa;
        Ataque = ataque;
    }

    protected void pontuar(Jogador j1, Time t1) {
        if (this.Ataque * 0.8 > j1.Defesa) {
            t1.Pontos += 2;
            Console.WriteLine($"{t1.Nome}: {t1.Pontos} ");
        }
    }

    protected void defender(Jogador j1, Time t1) {
        j1.Defesa *= 1.5;
    }

}
