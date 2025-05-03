using Dsw2025Ej8.Domain;
using static Excepciones;

public override void Depositar(decimal monto)
{
    if (monto <= 0)
        throw new MontoNoValido();

    if (_estado != Estado.Activa)
        throw new CuentaNoActiva(_estado);

    _saldo += monto;
}
public override void Retirar(decimal monto)
{
    if (monto <= 0)
        throw new MontoNoValido();

    if (_estado != Estado.Activa)
        throw new CuentaNoActiva(_estado);

    if (_saldo >= monto)
    {
        _saldo -= monto;
    }
    else
    {
        _estado = Estado.Suspendida;
        throw new SaldoInsuficiente();
    }