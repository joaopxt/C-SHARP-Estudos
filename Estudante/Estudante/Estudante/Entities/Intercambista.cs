namespace Estudante.Entities;

public class Intercambista : Aluno {

    public string PaisOrigem { get; set; }
    public string UniversidadeOrigem { get; set; }

    public Intercambista(string nome, string curso, int semestre, string paisOrigem, string universidadeOrigem) : base(nome, curso, semestre) {
        PaisOrigem = paisOrigem;
        UniversidadeOrigem = universidadeOrigem;
    }

    public void Update(string nome, string curso, int semestre, string paisOrigem, string universidadeOrigem) {
        base.Update(nome, curso, semestre);
        PaisOrigem = paisOrigem;
        UniversidadeOrigem = universidadeOrigem;
    }

}
