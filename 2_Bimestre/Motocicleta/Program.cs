using EjemploMotocicleta;

Motocicleta moto1 = new Motocicleta()
{
    Color = "Azul",
    Patente = "ASD123",
    Modelo = "Clio",
};

moto1.Prender();
moto1.Apagar();
moto1.Informar();

//Motocicleta moto2 = new Motocicleta(color: "Azul", "ASD123", "Clio");