using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia6_sobreescritura_y_sobreocultamiento_de_metodos
{
    internal class ReparacionFrenos : Servicio
    {
        public override void RealizarServicio()
        {
            Console.WriteLine("Realizando reparación de frenos.");
        }

        public override double CalcularCosto()
        {
            return 100.0; //Costo de la reparacion de frenos
        }

        public override double tiempoDeServicio()
        {
            return 30.0;
        }

    }
}
