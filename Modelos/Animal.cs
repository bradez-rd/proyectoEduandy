namespace ProyectoEduandy.Modelos;

/// <summary>
/// Clase base para demostrar herencia y polimorfismo.
/// </summary>
public abstract class Animal
{
    protected Animal(string nombre)
    {
        Nombre = nombre;
    }

    public string Nombre { get; }

    public abstract void HacerSonido();
}
