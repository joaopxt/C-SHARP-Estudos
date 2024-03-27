namespace Nba.Entities;

public class Time {
    public Guid Id { get; set; }
    public string Nome { get; set; }

    public int Trofeus { get; set; }

    public string Conferencia { get; set; }

    public string Star { get; set; }

    public bool IsDeleted { get; set; }

    public Time()
    {
        IsDeleted = false;  
    }

    public Time(Guid id, string nome, int trofeus, string conferencia, string star) {
        Id = id;
        Nome = nome;
        Trofeus = trofeus;
        Conferencia = conferencia;
        Star = star;
        IsDeleted = false;  
    }

    public void Update(string nome, int trofeus, string conferencia, string star) {
        Nome = nome;    
        Trofeus = trofeus;
        Conferencia = conferencia;
        Star = star;
    }

    public void Delete() {
        IsDeleted = true;
    }   
}
