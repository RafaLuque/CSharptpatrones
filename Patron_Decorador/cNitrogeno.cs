namespace Patron_Decorador
{
    public class cNitrogeno : iComponente
    {
        //Variable de referencia hacia quies decoramos.
        private iComponente decoramosA;

        //Pasamos al objeto que va a ser decorado
        public cNitrogeno(iComponente pComponente)
        {
            decoramosA = pComponente;
        }

        public override string ToString()
        {
            return "Sistema de Nicogeno \r\n" + decoramosA.ToString();
        }

        public void UsaN()
        {
            Console.WriteLine("Nitrogeno en uso");
        }

        //Metrodos de la interfaz.
        public double Costo()
        {
            //Calculamos el costoe
            //El costo de lo que decoro mas mi costo como componente
            return decoramosA.Costo() + 4500;
        }

        public string Funciona()
        {
            return decoramosA.Funciona()+ ", Nitrogeno listo";
        }
    }
}