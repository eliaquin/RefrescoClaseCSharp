using System;
using System.Threading;

namespace Refresco
{
    class Program
    {
        static void Main(string[] args)
        {

            //1. Un producto de la tienda fue comprado a X precio.
            //El margen de ganancia de los productos es un Y%.
            //¿Cuál es el precio final del producto? 
            Console.Write("Digite el costo del producto: ");
            var costoDigitado = Console.ReadLine();

            Console.Write("Si el producto es americano digite A y si es chino digite C otro digite lo que sea: ");
            var origenDigitado = Console.ReadLine();
            var costoProducto = Convert.ToDecimal(costoDigitado);

            CalcularCostos(costoDigitado, origenDigitado);
            var precioFinal = CalcularPrecioFinal(costoProducto, origenDigitado);
            Console.WriteLine("El precio final es {0}", precioFinal);

            Console.Read();
        }

        static void CalcularCostos(string costoDigitado, string origenDigitado)
        {
            var costoProducto = Convert.ToDecimal(costoDigitado);
            CalcularCostos(costoProducto, origenDigitado);
        }

        static void CalcularCostos(decimal costoProducto, string origenDigitado)
        {
            var porcentajeGanancia = 0.30m;

            var porcentajeGananciaUSA = 0.15m;
            var porcentajeGananciaChina = 0.20m;


            if (origenDigitado == "A" || origenDigitado == "a")
            {
                porcentajeGanancia = porcentajeGananciaUSA;
            }

            if (origenDigitado == "C" || origenDigitado == "c")
            {
                porcentajeGanancia = porcentajeGananciaChina;
            }

            var totalGanancia = costoProducto * porcentajeGanancia;
            var precioFinal = costoProducto + totalGanancia;
            Console.WriteLine("El producto cuesta {0} y la ganancia es {1} por eso el precio final es {2}", costoProducto, totalGanancia, precioFinal);
        }

        static decimal CalcularPrecioFinal(decimal costoProducto, string origenDigitado)
        {
            var porcentajeGanancia = 0.30m;

            var porcentajeGananciaUSA = 0.15m;
            var porcentajeGananciaChina = 0.20m;


            if (origenDigitado == "A" || origenDigitado == "a")
            {
                porcentajeGanancia = porcentajeGananciaUSA;
            }

            if (origenDigitado == "C" || origenDigitado == "c")
            {
                porcentajeGanancia = porcentajeGananciaChina;
            }

            var totalGanancia = costoProducto * porcentajeGanancia;
            var precioFinal = costoProducto + totalGanancia;
            return precioFinal;
        }
    }
}

