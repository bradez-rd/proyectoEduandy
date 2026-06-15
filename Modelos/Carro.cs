namespace ProyectoEduandy.Modelos;

public class Carro : IVehiculo
{
    public Carro(string marca)
    {
        Marca = marca;
    }

    public string Marca { get; }

    public void Encender()
    {
        Console.WriteLine($"El carro {Marca} encendió con el botón de arranque.");
    }

    public void Apagar()
    {
        Console.WriteLine($"El carro {Marca} se apagó y activó el freno de mano.");
    }
}
