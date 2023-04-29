using System;

//Declaramos una subclase llamada "Esqueleto" que va a heredar todas las clases y metodos de "Personaje".
class Esqueleto : Personaje
{
    //Le agregamos un nuevo atributo llamado "libro".
    public int espada;

    //Con el metodo constructor asiganmos este nuevo atributo y le asignamos su valor.
    public Esqueleto(string nombre, int fuerza, int defensa, int vida, int espada) : base(nombre, fuerza, defensa, vida)
    {
        this.espada = espada;
        this.espada = 15;
    }

    //Agregamos a la impresion el atributo de espada asignado por el metodo constructor.
    public new void atributos()
    {
        base.atributos();
        Console.WriteLine("·Espada: " + this.espada);
    }

    //Calculamos el daño del esqueleto multiplicando su fuerza por la espada y a esto le restamos la defensa que tenga el enemigo.
    public new int daño(Personaje enemigo)
    {
        return this.fuerza * this.espada - enemigo.defensa;
    }
}

