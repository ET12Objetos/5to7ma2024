using EjemploCuentaBancaria;

Console.Write("Ingrese Nro Cuenta: ");
int nroCuenta = Convert.ToInt32(Console.ReadLine());

Console.Write("Ingrese Nro Cliente: ");
int nroCliente = Convert.ToInt32(Console.ReadLine());

Console.Write("Ingrese Moneda: ");
string moneda = Console.ReadLine();

Console.Write("Ingrese Saldo: ");
decimal saldo = Convert.ToDecimal(Console.ReadLine());

CuentaBancaria cuenta = new CuentaBancaria(nroCliente, nroCuenta, moneda, saldo);

cuenta.Depositar(3000);
cuenta.Informar();
// cuenta.Retirar(1200);
cuenta.Informar();