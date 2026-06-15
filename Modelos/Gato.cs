namespace ProyectoEduandy.Modelos;

public class Gato : Animal
{
    public Gato(string nombre) : base(nombre)
    {
    }

    public override void HacerSonido()
    {
        Console.WriteLine($"{Nombre}, el gato, dice: Miau.");
    }
}
