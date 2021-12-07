// See https://aka.ms/new-console-template for more information
namespace Patron_Decorador
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creamos el componente central con tipo Icomponente
            //para permitir la decoración.
            iComponente miAuto = new cAuto("2018","4 puertas",20000);

            Console.WriteLine(miAuto);

            //Si necesitamos usar un metodo propio de cAuto
            //necesitamos hacer uso de un type cast.
            ((cAuto)miAuto).Puertas(true);

            Console.WriteLine("-------------");

            ////Decoramos el auto con un sistema de sonido
            miAuto = new cSistemaSonido(miAuto);

            //Comprobaos la adición de las caracteristicas
            Console.WriteLine(miAuto.Costo());
            Console.WriteLine(miAuto.Funciona());
            Console.WriteLine(miAuto);

            Console.WriteLine("-------------");

            miAuto = new cNitrogeno(miAuto);

            //Comprobaos la adición de las caracteristicas
            Console.WriteLine(miAuto.Costo());
            Console.WriteLine(miAuto.Funciona());
            Console.WriteLine(miAuto);

            //para usar algo propio del Nitrogeno
            ((cNitrogeno) miAuto).UsaN();

            Console.WriteLine("-------------");

            miAuto = new cSuspension(miAuto);

            //Comprobaos la adición de las caracteristicas
            Console.WriteLine(miAuto.Costo());
            Console.WriteLine(miAuto.Funciona());
            Console.WriteLine(miAuto);

            Console.WriteLine("-------------");

            //Ojo, No podemos usar metodos especificos una vez que decoramos
            //sobre de ella
            
            //((cNitrogeno) miAuto).UsaN();
            //((cAuto)miAuto).Puertas(false);
        }
    }
}

