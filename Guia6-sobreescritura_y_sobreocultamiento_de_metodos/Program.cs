using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia6_sobreescritura_y_sobreocultamiento_de_metodos
{
    internal class Program
    {
        static void Main(String[] args)

        {
            Console.WriteLine(" ▒▒▒▒▒ Bienvenidos al taller de reparacion de vehiculos ▒▒▒▒▒ ");
            Console.WriteLine("");

            //creamos las variables que vamos a ocupar para calcular el tiepo de cad uno de los vehiculos 
            double totalTiempo;
           

            Vehiculo miCoche = new Coche();
            miCoche.RealizarMantenimiento(); //Output : Realizando mantenimiento del coche: Cambio de aceite y revisión de frenos  
            Console.WriteLine("Costo del mantenimiento del coche : $" + miCoche.ObtenerCostoMantenimiento());

            Vehiculo miMoto = new Moto();
            miMoto.RealizarMantenimiento();//Output : Realizando mabtenimiento de la moto: Lubricación de cadena y revisión de neumatico
            Console.WriteLine("Costo del mantenimiento de la moto :$ " + miMoto.ObtenerCostoMantenimiento());

            miCoche.Lavar(); //Output : Lavando el vehiculo
            Coche miCocheReal = new Coche(); // instancia para poder acceder al estado oculto lavar que esta la clase coche
            miCocheReal.Lavar();   //output lavando el coche con cera o shampoo espacial

            Servicio ServicioAceite = new CambiarAceite();
            ServicioAceite.RealizarServicio(); //Output : Realizando cambio de aceite
            Console.WriteLine("Costo del cambio de aceite: $" + ServicioAceite.CalcularCosto());

            Servicio servicioFrenos = new ReparacionFrenos();
            servicioFrenos.RealizarServicio(); //Output: Realizando reparacion de frenos
            Console.WriteLine("Costo de la reparación de frenos : $" + servicioFrenos.CalcularCosto());

            //Servicio ser = new Servicio();
            //La clase servicio es una clase abstracta por lo tanto no se puede instanciar.


            /* Calculamos el tiempo que dilataran en brindarle mantenimiento
             * a la moto y al coche asi como tambien mandamos a llamar 
             * los objetos creados en las instancias */
            Console.WriteLine("");
            Console.Write("Tiempo de duración de los servicios brindados:");

            totalTiempo = Calcular_total_tiempocoche(miCoche, ServicioAceite, servicioFrenos);
            Console.WriteLine();
            Console.WriteLine($" El tiempo total de los servicios al coche: {totalTiempo} minutos");
            Console.WriteLine("");

            totalTiempo = CalcularTiempomoto(miMoto, ServicioAceite, servicioFrenos);
            Console.WriteLine();
            Console.WriteLine($"Tiempo total de los servicios de la moto: {totalTiempo} minutos");
            Console.WriteLine("");
        }

       
        static double Calcular_total_tiempocoche(Vehiculo coche, Servicio Aceite, Servicio frenos)
        {
            double totalTiempo;
            totalTiempo = coche.tiempoDeServicio() + Aceite.tiempoDeServicio() + frenos.tiempoDeServicio();
            return totalTiempo;
        }
        static double CalcularTiempomoto(Vehiculo moto, Servicio Aceite, Servicio frenos)
        {
            double totalTiempo;
            totalTiempo = moto.tiempoDeServicio() + Aceite.tiempoDeServicio() + frenos.tiempoDeServicio();
            return totalTiempo;
            Console.WriteLine("******El Programa Ha finalizado *****");
        }
    }
}