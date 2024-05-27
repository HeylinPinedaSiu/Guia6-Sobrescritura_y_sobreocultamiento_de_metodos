using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia6_sobreescritura_y_sobreocultamiento_de_metodos
{
    internal class CambiarAceite: Servicio
    {
        public override void RealizarServicio()
        {
            Console.WriteLine("Realizando cambio de aceite.");
        }

        public override double CalcularCosto()
        {
            return 50.0; //Costo del cambio de aceite
        }

        public override double tiempoDeServicio()
        {
            return 10.0;
        }
    }
}

