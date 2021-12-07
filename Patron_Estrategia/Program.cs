namespace Patron_Estrategia
{
    class program
    {
        static void Main (string[] args)
        {
            string dato ="";
            double x=0;
            double y=0;
            double r=0;
            string opcion="";

            iCalculo miCalculo = new suma();

            while (opcion!="3")
            {
                Console.WriteLine("1- Suma, 2- Resta, 3- Salir");
                opcion = Console.ReadLine();

                if (opcion=="3")
                    break;

                Console.WriteLine("Dame el valor de a");
                dato = Console.ReadLine();
                x= double.Parse(dato);


                Console.WriteLine("Dame el valor de b");
                dato = Console.ReadLine();
                y= double.Parse(dato);

                if(opcion=="1")
                    miCalculo = new suma();

                if(opcion=="2")
                    miCalculo = new resta();

                r = miCalculo.operacion(x,y);

                Console.WriteLine("El resultado es {0}",r);
            }
        }
    }
}