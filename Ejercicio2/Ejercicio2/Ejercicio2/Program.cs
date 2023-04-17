using System;

internal class Program
{
    private static void Main(string[] args)
    {
        string strNombreLocal;
        string strCantidadLocal;
        string strCantidadlocal700;
        double cantidadPersonasLocal = 0;
        double cantidadPersona700 = 0;
        int contador = 1;
        double sumaTotal700 = 0;
        double sumaTotalLocal = 0;
        int cantidadNivel2 = 0;
        int cantidadNivel4 = 0;

        while (contador <= 30)
        {
            Console.WriteLine("Por favor ingrese la siguiente informacion de su local de rendición PAES\nIngrese por favor el nombre de su local:");
            strNombreLocal = Console.ReadLine();

            Console.WriteLine("Ingrese por favor cuantas personas rindieron la prueba en su local:");
            strCantidadLocal = Console.ReadLine();
            double.TryParse(strCantidadLocal, out cantidadPersonasLocal);

            Console.WriteLine("Ingrese por favor cuantas personas tuvieron un puntaje mayor a 700 en su local:");
            strCantidadlocal700 = Console.ReadLine();
            double.TryParse(strCantidadlocal700, out cantidadPersona700);

            sumaTotal700 += cantidadPersona700;
            sumaTotalLocal += cantidadPersonasLocal;

            double porcentaje700 = cantidadPersona700 / cantidadPersonasLocal * 100;
            string nivel;

            if (porcentaje700 >= 80)
            {
                nivel = "Excelencia";
            }
            else if (porcentaje700 >= 60)
            {
                nivel = "Bueno";
            }
            else if (porcentaje700 >= 50)
            {
                nivel = "Regular";
            }
            else if (porcentaje700 >= 20)
            {
                nivel = "Inicial";
            }
            else
            {
                nivel = "no valido";
            }

            Console.WriteLine("El nivel del local es: " + nivel);

            if (nivel == "Bueno")
            {
                cantidadNivel2++;
            }
            else if (nivel == "Inicial")
            {
                cantidadNivel4++;
            }

            contador++;
        }

        double porcentajeTotal700 = sumaTotal700 / sumaTotalLocal * 100;
        double porcentaje10Total700 = sumaTotal700 * 0.1;

        Console.WriteLine("El porcentaje total de personas de 700 puntos es: " + porcentajeTotal700);
        Console.WriteLine("La cantidad de personas que rindieron la PAES es: " + sumaTotalLocal);
        Console.WriteLine("La cantidad de locales en nivel 2 es: " + cantidadNivel2);
        Console.WriteLine("La cantidad de locales en nivel 4 es: " + cantidadNivel4);
    }
}
