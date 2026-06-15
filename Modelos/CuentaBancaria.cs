namespace ProyectoEduandy.Modelos;

/// <summary>
/// Mantiene el saldo protegido y permite modificarlo mediante operaciones válidas.
/// </summary>
public class CuentaBancaria
{
    private decimal saldo;

    public void Depositar(decimal monto)
    {
        if (monto <= 0)
        {
            throw new ArgumentOutOfRangeException(
                nameof(monto),
                "El monto del depósito debe ser mayor que cero.");
        }

        saldo += monto;
        Console.WriteLine($"Depósito realizado: {monto:C2}");
    }

    public decimal ObtenerSaldo()
    {
        return saldo;
    }
}
