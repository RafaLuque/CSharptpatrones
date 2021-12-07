namespace Patron_Decorador
{
    public class cSistemaSonido : iComponente
    {
        //Variable de referencia hacia quien decoramos
        private iComponente decoramosA;

        //Pasamos al objeto que va a ser decorado.
        public cSistemaSonido (iComponente pComponente)
        {
            decoramosA = pComponente;
        }

        public override string ToString()
        {
            return "Radio 350XZ+ \r\n" + decoramosA.ToString();
        }
        
        //Metodos de la interfaz
        public double Costo()
        {
           return decoramosA.Costo() + 3500;
        }

        public string Funciona()
        {
            return decoramosA.Funciona()+ ", Enciendo la radio";
        }
    }
}