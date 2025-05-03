internal class CuentaCorriente : CuentaBancaria
{
    public CuentaCorriente(string numero, decimal saldo, string[] titulares)
        : base(numero, saldo, titulares)
    {
        Comision = 0.02m;
    }

    public override void Depositar(decimal monto)
    {
        Saldo += monto * (1 - Comision);
    }

    public override void Retirar(decimal monto)
    {
        if (Saldo - monto >= -LimiteDeDescubierto)
        {
            Saldo -= monto;
            if (Saldo < 0)
            {
                Estado = Estado.Suspendida;
            }
        }
    }
}