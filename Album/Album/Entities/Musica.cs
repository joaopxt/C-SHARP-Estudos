namespace Album.Entities;

public class Musica {

    public Guid Id { get; set; }
    public string Nome { get; set; }
    public List<Artista> Artista { get; set; }
    public string Genero { get; set; }
    public bool IsDeleted { get; set; }

    public Musica() { 
    IsDeleted = false;
    }

    public Musica(Guid id, string nome, List<Artista> artista, string genero) {
        Id = id;
        Nome = nome;
        Artista = artista;
        Genero = genero;
        IsDeleted = false;
    }

    public void Update(string nome, List<Artista> artista, string genero) {
        Nome = nome;
        Artista = artista;
        Genero = genero;
    }

    public void Delete() {
        IsDeleted = true;   
    }
}
