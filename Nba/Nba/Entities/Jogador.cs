using System.Numerics;

namespace Nba.Entities;

public class Jogador : Atleta {

    public Guid Id { get; set; }
    public string Posicao;
    public int Pontos;
    public Guid Time_id;

    public Jogador() {

    }

}
