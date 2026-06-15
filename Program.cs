using ProyectoEduandy.Modelos;

namespace ProyectoEduandy;

internal static class Program
{
    private static void Main()
    {
        Console.WriteLine("========================================");
        Console.WriteLine("  Bienvenidos al proyecto del grupo Eduandy");
        Console.WriteLine("========================================\n");

        MostrarVariables();
        EjecutarEstructurasDeControl();
        EjecutarPersonas();
        EjecutarHerenciaYPolimorfismo();
        EjecutarCuentaBancaria();
        EjecutarVehiculos();

        Console.WriteLine("\nFin de la práctica.");
    }

    private static void MostrarVariables()
    {
        Console.WriteLine("--- 1. Sintaxis básica y variables ---");

        int cantidadIntegrantes = 3;
        string nombreGrupo = "Eduandy";
        double calificacionEsperada = 100.0;
        bool practicaCompletada = true;

        Console.WriteLine($"Cantidad de integrantes (int): {cantidadIntegrantes}");
        Console.WriteLine($"Nombre del grupo (string): {nombreGrupo}");
        Console.WriteLine($"Calificación esperada (double): {calificacionEsperada}");
        Console.WriteLine($"Práctica completada (bool): {practicaCompletada}\n");
    }

    private static void EjecutarEstructurasDeControl()
    {
        Console.WriteLine("--- 2. Estructuras de control ---");
        Console.Write("Escribe un número entero: ");
        int numero;

        // TryParse evita que el programa falle cuando el usuario escribe un valor no numérico.
        while (!int.TryParse(Console.ReadLine(), out numero))
        {
            Console.Write("Entrada inválida. Escribe un número entero: ");
        }

        Console.WriteLine(numero % 2 == 0
            ? $"El número {numero} es par."
            : $"El número {numero} es impar.");

        Console.WriteLine("Números del 1 al 10:");
        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"{i} ");
        }

        Console.WriteLine("\n");
    }

    private static void EjecutarPersonas()
    {
        Console.WriteLine("--- 3. Clases y objetos ---");

        // Sustituir estos datos por los nombres y edades reales de los integrantes.
        var personas = new List<Persona>
        {
            new("Integrante 1", 20),
            new("Integrante 2", 21),
            new("Integrante 3", 22)
        };

        foreach (Persona persona in personas)
        {
            persona.Presentarse();
        }

        Console.WriteLine();
    }

    private static void EjecutarHerenciaYPolimorfismo()
    {
        Console.WriteLine("--- 4. Herencia ---");
        var perro = new Perro("Firulais");
        var gato = new Gato("Michi");

        perro.HacerSonido();
        gato.HacerSonido();

        Console.WriteLine("\n--- 5. Polimorfismo ---");

        // Aunque la lista usa el tipo base, cada objeto ejecuta su propia implementación.
        var animales = new List<Animal> { perro, gato };
        foreach (Animal animal in animales)
        {
            animal.HacerSonido();
        }

        Console.WriteLine();
    }

    private static void EjecutarCuentaBancaria()
    {
        Console.WriteLine("--- 6. Encapsulamiento ---");
        var cuenta = new CuentaBancaria();
        cuenta.Depositar(2500.00m);
        Console.WriteLine($"Saldo actual: {cuenta.ObtenerSaldo():C2}\n");
    }

    private static void EjecutarVehiculos()
    {
        Console.WriteLine("--- 7. Interfaces y abstracción ---");
        var vehiculos = new List<IVehiculo>
        {
            new Carro("Toyota"),
            new Motocicleta("Honda")
        };

        foreach (IVehiculo vehiculo in vehiculos)
        {
            vehiculo.Encender();
            vehiculo.Apagar();
        }
    }
}
