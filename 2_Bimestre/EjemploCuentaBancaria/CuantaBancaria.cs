

namespace EjemploCuentaBancaria;

public class CuentaBancaria
{
    public int NroCuenta { get; }
    public int NroCliente { get; }
    public string Moneda { get; } = "";
    public decimal Saldo { get; set; } = 0;

    public CuentaBancaria(int NroCuenta, int NroCliente, string Moneda, decimal Saldo)
    {
        this.NroCuenta = NroCuenta;
        this.NroCliente = NroCliente;
        this.Moneda = Moneda;
        this.Saldo = Saldo;
    }

    public void Informar()
    {
        //throw new NotImplementedException();
        System.Console.WriteLine(this.Saldo);
    }

    //depositar dinero el cual consiste en ingresar una cantidad a la cuenta, el nuevo saldo de la cuenta será el actual más la cantidad a depositar.

    public void Depositar(int cantidad)
    {
        if (cantidad < 0)
            throw new Exception("Cantidad negativa");

        this.Saldo = this.Saldo + cantidad;
    }

    //retirar dinero el cual consiste en retirar una cantidad de dinero de la cuenta bancaria siempre y cuando se cuente con los fondos suficientes. En caso de no tener fondos suficientes informar por pantalla “La cuenta no posee fondos suficientes para realizar la operación.”

    public void Retirar(int cantidad)
    {
        if (cantidad < 0)
            throw new Exception("Cantidad negativa");

        if (cantidad > this.Saldo)
            throw new Exception("La cuenta no posee fondos suficientes para realizar la operación.");

        this.Saldo = this.Saldo - cantidad;
    }
}