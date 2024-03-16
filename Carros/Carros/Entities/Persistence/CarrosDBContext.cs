namespace Carros.Entities.Persistence;

public class CarrosDBContext
{
    public List<Carro> Carros { get; set; }
    public CarrosDBContext() {
        Carros = new List<Carro>(); 
    }
}
