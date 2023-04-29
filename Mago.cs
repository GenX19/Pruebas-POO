using System;

//Declaramos una subclase llamada "Mago" que va a heredar todas las clases y metodos de "Personaje".
class Mago : Personaje
{
    //Le agregamos un nuevo atributo llamado "libro".
    public int libro;

    //Con el metodo constructor asiganmos este nuevo atributo.
    public Mago(string nombre, int fuerza, int defensa, int vida, int libro) : base(nombre, fuerza, defensa, vida)
    {
        this.libro = libro;
    }

    //Creamos un metodo llamado Cambiar_Libro cuya labor sera alterar el valor guardado en libro.
    public void cambiar_libro()
    {
        Console.Write("Elige un libro: (1) Fuerza bestial, daño 8. (2) Aniquilacion, daño 10: ");
        int opcion = int.Parse(Console.ReadLine());
        if (opcion == 1)
        {
            this.libro = 8;
        }
        else if (opcion == 2)
        {
            this.libro = 10;
        }
        else
        {
            Console.WriteLine("Número de libro incorrecto");
        }
    }

    //Agregamos a la impresion el atributo de libro asignado por el metodo constructor.
    public new void atributos()
    {
        base.atributos();
        Console.WriteLine("·libro: " + this.libro);
    }

    //Calculamos el daño del mago multiplicando su fuerza por el libro y a esto le restamos la defensa que tenga el enemigo.
    public new int daño(Personaje enemigo)
    {
        return this.fuerza * this.libro - enemigo.defensa;
    }
}
