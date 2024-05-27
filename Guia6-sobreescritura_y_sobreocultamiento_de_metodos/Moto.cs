using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia6_sobreescritura_y_sobreocultamiento_de_metodos
{
    internal class Moto : Vehiculo
    {
        public override void RealizarMantenimiento()
        {
            Console.WriteLine("Realizando mantenimiento de la moto: lubricacion de cadena y revision de neumaticos");
        }

        public override double ObtenerCostoMantenimiento()
        {
            return 100.0;
        }

        //cremos un metodo para calcular el tiempo que dilataran en darle mantenimiento a la moto
        public override double tiempoDeServicio()
        {
            return 15.0;
        }
    }
}
