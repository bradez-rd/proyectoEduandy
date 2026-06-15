namespace ProyectoEduandy.Modelos;

public class Motocicleta : IVehiculo
{
    public Motocicleta(string marca)
    {
        Marca = marca;
    }

    public string Marca { get; }

    public void Encender()
    {
        Console.WriteLine($"La motocicleta {Marca} encendió con su llave.");
    }

    public void Apagar()
    {
        Console.WriteLine($"La motocicleta {Marca} apagó su motor.");
    }
}
