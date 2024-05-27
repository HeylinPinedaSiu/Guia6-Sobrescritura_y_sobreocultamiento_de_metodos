using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia6_sobreescritura_y_sobreocultamiento_de_metodos
{
    public abstract class Servicio
    {
        /*creamos metodos  abstractos que
         * nos serviran en las clases derivadas  */
        public abstract void RealizarServicio();
        public abstract double CalcularCosto();

        //Agregamos un metodo abstracto para poder calcular el tiempo de los servicios
        public abstract double tiempoDeServicio();

    }
}
