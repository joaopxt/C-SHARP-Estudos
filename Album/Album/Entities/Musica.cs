namespace Album.Entities;

public class Musica {

    public Guid Id { get; set; }
    public string Nome { get; set; }
    public List<Artista> Artistas { get; set; }
    public string Genero { get; set; }
    public bool IsDeleted { get; set; }

    public Musica() { 
    IsDeleted = false;
    }

    public Musica(Guid id, string nome, List<Artista> artista, string genero) {
        Id = id;
        Nome = nome;
        Artistas = artista;
        Genero = genero;
        IsDeleted = false;
    }

    public void Update(string nome, List<Artista> artista, string genero) {
        Nome = nome;
        Artistas = artista;
        Genero = genero;
    }

    public void Delete() {
        IsDeleted = true;   
    }
}
