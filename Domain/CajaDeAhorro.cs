using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsw2025Ej8.Domain;

internal class CajaDeAhorro : CuentaBancaria
{
    public CajaDeAhorro(string numero, decimal saldo, string[] titulares)
        : base(numero, saldo, titulares)
    {
    }

    public override void Retirar(decimal monto)
    {
        if (_saldo >= monto)
        {
            _saldo -= monto;
        }
    }
    public override void Depositar(decimal monto)
    {
        _saldo += monto;
    }
    public void AplicarInteres()
    {
        _saldo += _saldo * _tasaDeInteres;
    }
}
