namespace Estudante.Entities;

public class Aluno { // Classe de Aluno com métodos de Update e Delete  

    public Guid Id { get; set; }
    public string Nome { get; set; }
    public string Curso { get; set; }
    public int Semestre { get; set; }
    public bool IsDeleted { get; set; }

    public Aluno()
    {
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
