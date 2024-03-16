namespace Carros.Entities;

public class Carro {

    public Guid Id { get; set; }
    public string Modelo { get; set; }
    public int Ano { get; set; }
    public string Marca { get; set; }
    public double Preco { get; set; }
    public bool IsDeleted { get; set; }

    public Carro() {
        IsDeleted = false;
    }

    public Carro(Guid id, string modelo, int ano, string marca, double preco) {

        Id = id;
        Modelo = modelo;
        Ano = ano;
        Marca = marca;
        Preco = preco;
        IsDeleted = false;
    }

    public void Update(string modelo, int ano, string marca, double preco) {
        Modelo = modelo;
        Ano = ano;
        Marca = marca;
        Preco = preco;
    }

    public void Delete() {
        IsDeleted = true;
    }
}
