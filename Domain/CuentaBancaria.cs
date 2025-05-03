using Dsw2025Ej8.Domain;

public abstract class CuentaBancaria
{
    public string Numero { get; }
    public decimal Saldo { get; protected set; }
    public Estado Estado { get; protected set; } = Estado.Activa;
    public decimal TasaDeInteres { get; init; }
    public decimal LimiteDeDescubierto { get; init; }
    public decimal Comision { get; protected set; }
    public string[] Titulares { get; }

    protected CuentaBancaria(string numero, decimal saldo, string[] titulares)
    {
        Numero = numero ?? throw new ArgumentNullException(nameof(numero));
        Saldo = saldo >= 0 ? saldo : throw new ArgumentException("El saldo inicial no puede ser negativo.");
        Titulares = titulares ?? throw new ArgumentNullException(nameof(titulares));
    }

    public abstract void Depositar(decimal monto);
    public abstract void Retirar(decimal monto);
}