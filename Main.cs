using System;

//Creamos la clase "Program".
class Program
{
    //Declaramos la funcion principal que ejecutara nuestro proyecto.
    static void Main(string[] args)
    {
        //Creamos un nuevo mago.
        Mago mago_uno = new Mago("Gandal", 30, 20, 100, 5);
        //Creamos un nuevo esqueleto.
        Esqueleto esqueleto_uno = new Esqueleto("Skull",35, 10, 50,5);

        Console.WriteLine("Atributos de los personajes antes de atacar: ");
        mago_uno.atributos();
        esqueleto_uno.atributos();

        //Elegimos el libro que va a usar el Mago
        mago_uno.cambiar_libro();

        mago_uno.atacar(esqueleto_uno);
        esqueleto_uno.atacar(mago_uno);

        Console.WriteLine("Atributos de los personajes despues de atacar: ");
        mago_uno.atributos();
        esqueleto_uno.atributos();
    }
}

