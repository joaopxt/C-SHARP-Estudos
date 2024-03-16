using Library.Entities;


namespace Library.Entities.Persistence;

public class LivrosDBContext
{
    public List<Livro> Livros { get; set; }

    public LivrosDBContext()
    {
        Livros = new List<Livro>();
    }
}
