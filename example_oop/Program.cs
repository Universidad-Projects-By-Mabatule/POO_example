using System;

namespace example_oop
{
    class Program
    {
        static void Main(string[] args)
        {
            Raqueta gearbox = new Raqueta();
            Console.WriteLine("Nombre: "+gearbox.nombre()+"\n");
            Console.WriteLine(gearbox.Descripcion_Raquet() + "\n");
            Marca marca = new Raqueta();
            Console.WriteLine(marca.informacion() + "\n");
        }
    }
}
