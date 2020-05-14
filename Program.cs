using System;

namespace clasedotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    abstract class Vehiculo
    {
        var Marca;
        var Año;
        var Kilometraje;

    }
    abstract class VehiculoComponentes
    {
        var EstadoComponente;
    }
    class Automovil : Vehiculo
    {

    }
    class Estanque
    {
        var Capacidad;
        var Litros;
        MitadCombustible()
        {
            /* retorne booleano en caso de que los litros sean mayores a 10.5% de la capacidad y menor
            * o igual a 50% de la capacidad. */

        }
        BajoCombustible()
        {
            /* retorne booleano en el caso de que los litros sean igual o menor a 10.5% */
        }
    }
    class Mezclador
    {
        /* Carburador o inyector */
    }
    class Rueda
    {
        var Recubrimiento; /* FENOL HULE; POLIUTERANO */
        var Durometro; /* numero entero uno mayor que el otro. */
    }
    class Motor
    {
        var ID;
        var Tipo;
        var Cilindrada;
        /* puede ser dos o cuatro tiempos */
    }
}
