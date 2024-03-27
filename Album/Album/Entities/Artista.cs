namespace Album.Entities;

public class Artista {

    public string Nome { get; set; }

    public Guid ArtistaId { get; set; }

    public Artista(string nome)
    {
        Nome = nome;
    }
}