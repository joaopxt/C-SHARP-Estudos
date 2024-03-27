namespace Professores.Entities;

public class Professor {

    public Guid Id { get; set; }

    public string Nome { get; set; }

    public string Curso { get; set; }

    public bool IsDeleted { get; set; }

    public Professor()
    {
        IsDeleted = false;
    }

    public Professor(Guid id, string nome, string curso) {
        Id = id;
        Nome = nome;
        Curso = curso;
        IsDeleted = false;  
    }

    public void Update(string nome, string curso) {
        Nome = nome;
        Curso = curso;
    }   

    public void Delete() {
        IsDeleted = true;
    }
}
