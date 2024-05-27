using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia6_sobreescritura_y_sobreocultamiento_de_metodos
{
    internal class Coche : Vehiculo
    {
        public override void RealizarMantenimiento()
        {
            Console.WriteLine("Realizando mantenimiento del coche: lubricacion de aceite de  revision de neumaticos");
        }

        public override double ObtenerCostoMantenimiento()
        {
            return 150.0;//costo del mantenimiento del coche 
        }
        public new void Lavar() //Modificamos la clase coche para oculatar el metodo lavar  
        {
            Console.WriteLine(" Lavando el coche ");
        }

        public override double tiempoDeServicio()
        {
            return 25.0;
        }

    }
}
