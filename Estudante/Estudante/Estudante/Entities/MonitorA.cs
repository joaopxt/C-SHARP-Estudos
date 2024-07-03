namespace Estudante.Entities;

public class MonitorA : Aluno {

    internal string MateriaMonitorada { get; set; }
    internal double Bolsa { get; set; }
    internal string Orientador { get; set; }

    public MonitorA(string nome, string curso, int semestre, string materiaMonitorada, double bolsa, string orientador) : base(nome, curso, semestre) {
        MateriaMonitorada = materiaMonitorada;
        Bolsa = bolsa;
        Orientador = orientador;
    }

    public void Update(string nome, string curso, int semestre, string materiaMonitorada, double bolsa, string orientador) {
        base.Update(nome, curso, semestre);
        MateriaMonitorada = materiaMonitorada;
        Bolsa = bolsa;
        Orientador = orientador;
    }

}
