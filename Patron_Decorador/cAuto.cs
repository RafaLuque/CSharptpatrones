namespace Patron_Decorador
{
    public class cAuto : iComponente
    {
        private string modelo;
        private string caracteristicas;
        public double costo;

        public cAuto(string pModelo, string pCaracteristicas, double pCosto)
        {
            modelo = pModelo;
            caracteristicas = pCaracteristicas;
            costo = pCosto;
        }
        public void Puertas(bool pEstado)
        {
            if(pEstado)
                Console.WriteLine("Puesrtas cerradas");
            else
             Console.WriteLine("Puesrtas abiertas");
        }

        public override string ToString()
        {
            return string.Format("Modelo {0}, {1} \r\n", modelo,caracteristicas);
        }

        // Estos son los metodos implementados de IComponente
        public double Costo()
        {
            return costo;
        }

        public string Funciona()
        {
            return "Encendi el motor";
        }
    }
}