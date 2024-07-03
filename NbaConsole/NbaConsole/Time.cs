using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NbaConsole;
internal class Time {

    public string Nome { get; set; }
    public List<Jogador> Jogadores { get; set; }
    public int Pontos { get; set; }

    public Time(string nome) {
        Nome = nome;
        Jogadores = new List<Jogador>();
        Pontos = 0;
    }

    public void adicionarJogador(Jogador j) {
        Jogadores.Add(j);
    }

    public string listarJogadores() {
        string lista = "";
        foreach (Jogador j in Jogadores) {
            lista += j.ToString() + "\n";
        }
        return lista;
    }   

}
