using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NbaConsole;
internal class Armador: Jogador {

    public int Arremesso { get; set; }

    public Armador(string nome, int altura, int fisico, int defesa, int ataque) : base(nome, altura, fisico, defesa, ataque) {
    }

    public void arremessar(Jogador j1, Time t1) {
        if (this.Ataque * 0.5 + this.Arremesso > j1.Defesa) {
            t1.Pontos += 3;
            Console.WriteLine($"{t1.Nome}: {t1.Pontos} ");
        }
    }

    public override string ToString() {
        return $"Nome: {Nome}, Altura: {Altura}, Fisico: {Fisico}, Defesa: {Defesa}, Ataque: {Ataque}";
    }
}
