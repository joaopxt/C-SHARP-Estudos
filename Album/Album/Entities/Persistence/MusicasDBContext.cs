using System.Security.Cryptography;

namespace Album.Entities.Persistence;

public class MusicasDBContext {

    public List<Musica> Musicas { get; set; }

    public MusicasDBContext() {
        Musicas = new List<Musica>();   
    }
}
