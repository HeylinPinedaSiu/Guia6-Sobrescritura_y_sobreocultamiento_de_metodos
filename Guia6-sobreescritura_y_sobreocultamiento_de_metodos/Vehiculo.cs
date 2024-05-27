using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia6_sobreescritura_y_sobreocultamiento_de_metodos
{
    internal class Vehiculo
    {
         public virtual void RealizarMantenimiento()
        {
            Console.WriteLine("Realizando mantenimiento del coche: lubricacion de aceite de  revision de neumaticos");
        }

        public virtual double ObtenerCostoMantenimiento()
        {
            return 50.0;//costo base del mantenimiento
        }

        public void Lavar()//creamos el metodo lavar 

        {
            Console.WriteLine(" Lavando el  vehiculo ");
        }
        /*La palabra reservada virtual la utilizamos para  poder 
         * especificar al metodo que volveremos 
         * a definir en clases derivadas.*/
        public virtual double tiempoDeServicio()
        {

            return 2.0;  

        }

    }
}
