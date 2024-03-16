namespace Library.Entities;

public class Livro {
    public Guid Id { get; set; }
    public string Nome { get; set; }
    public string Autor { get; set; }
    public int Ano { get; set; }
    public bool IsDeleted { get; set; }

    public Livro() {
        IsDeleted = false;
    }

    public Livro(Guid id, string nome, string autor, int ano) {
        Id = id;
        Nome = nome;
        Autor = autor;
        Ano = ano;
        IsDeleted = false;
    }

    public void Update(string nome, string autor, int ano) {
        Nome = nome;
        Autor = autor;
        Ano = ano;
    }

    public void Delete() {
        IsDeleted = false;
    }
}
