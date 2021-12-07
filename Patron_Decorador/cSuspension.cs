namespace Patron_Decorador
{
    public class cSuspension : iComponente
    {
        //Variable de referencia hacia quien decoramos
        private iComponente decoramosA;

        //Pasamos al objeto que va a ser decorado.
        public cSuspension (iComponente pComponente)
        {
            decoramosA = pComponente;
        }

        public override string ToString()
        {
            return "Suspension de alto desempeño \r\n" + decoramosA.ToString();
        }
        
        //Metodos de la interfaz
        public double Costo()
        {
           return decoramosA.Costo() + 6385;
        }

        public string Funciona()
        {
            return decoramosA.Funciona()+ ", Elevando suspension";
        }
    }
}