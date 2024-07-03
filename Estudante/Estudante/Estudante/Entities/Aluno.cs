namespace Estudante.Entities;

public class Aluno { // Classe de Aluno com métodos de Update e Delete  

    internal protected Guid Id { get; set; }
    internal protected string Nome { get; set; }
    internal protected string Curso { get; set; }
    internal protected int Semestre { get; set; }
    internal protected bool IsDeleted { get; set; }

    public Aluno() {
        IsDeleted = false;
    }

    public Aluno(string nome, string curso, int semestre) {
        Id = Guid.NewGuid();
        Nome = nome;
        Curso = curso;
        Semestre = semestre;
        IsDeleted = false;
    }

    public void Update(string nome, string curso, int semestre) {
        Nome = nome;
        Curso = curso;
        Semestre = semestre;
    }
    public void Delete() {
        IsDeleted = true;
    }
}
