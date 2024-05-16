namespace EjemploCafetera;

public class Cafetera
{
    public int CantidadMaxima { get; } = 1500; //centimetros cubicos
    public int CantidadActual { get; set; }

    public Cafetera(int CantidadActual)
    {
        if (CantidadActual < 0)
        {
            // Console.WriteLine($"Valor cantidad actual incorrecto ${CantidadActual}");
            // return;
            throw new Exception($"Valor cantidad actual incorrecto ${CantidadActual}");
        }

        if (CantidadActual > this.CantidadMaxima)
        {
            throw new Exception($"Valor cantidad actual supera al valor de la cantidad maxima");
            //return;
        }

        this.CantidadActual = CantidadActual;
    }

    //hacer: este método refleja la acción de realizar una jarra nueva de café, la 
    public void Hacer() => this.CantidadActual = this.CantidadMaxima;

    //vaciar: asigna la cantidad de café actual en cero.
    public void Vaciar() => this.CantidadActual = 0;

    // servir(cantidad): representa la acción de servir una taza con la capacidad indicada (capacidad de la taza, en c.c.). Si la cantidad actual de café “no alcanza” para llenar la taza, se sirve lo que quede y la jarra quedará vacía es decir la capacidad actual de la jarra queda en cero.
    public void Servir(int cantidad)
    {
        if (cantidad <= this.CantidadActual)
            this.CantidadActual = this.CantidadActual - cantidad;
        else
            throw new Exception("No es posible servir la cantidad deseada");
    }

    //informar: muestra la cantidad de café que se encuentra actualmente en la jarra.
    public void Informar() => Console.WriteLine($"Cantidad actual: {this.CantidadActual}");
}