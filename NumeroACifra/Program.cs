using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroACifra
{
    class Program
    {
        public static void numeroLiteral(int numero)
        {
            string[] especialesArray = new string[] { "", "once", "doce", "trece", "catorce", "quince", "diesiseis", "diecisiete", "dieciocho", "diecinueve" };
            string[] millaresArray = new string[] { "", "Mil", "Dosmil", "Tresmil", "Cuatromil", "Cincomil", "Seismil", "Sietemil", "Ochomil", "Nuevemil" };
            string[] decenasArray = new string[] { "", "diez", "veinte", "treinta", "cuarenta", "cincuenta", "sesenta", "setenta", "ochenta", "noventa" };
            string[] centenasArray = new string[] { "", "ciento", "doscientos", "trecientos", "cuatrocientos", "quinientos", "seiscientos", "setecientos", "ochocientos", "novecientos" };
            string[] unidadesArray = new string[] { "cero", "uno", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve" };

            int millares = numero / 1000;
            int centenas = (numero - (millares * 1000)) / 100;
            int decenas = (numero - (millares * 1000 + centenas * 100)) / 10;
            int unidades = numero - (millares * 1000 + centenas * 100 + decenas * 10);

            if (unidadesArray.Length >= 0 && numero < unidadesArray.Length)
                Console.WriteLine("El número ingresado es : {0} ", unidadesArray[numero]);

            else if (numero < 20)
                Console.WriteLine("El número ingresado es : {0} ", especialesArray[numero - unidadesArray.Length]);

            else if (numero < 100)
            {
                if (unidades == 0)
                    Console.WriteLine("El número ingresado es : {0} ", decenasArray[decenas]);
                else
                    Console.WriteLine("El número ingresado es : {0} y {1} ", decenasArray[decenas], unidadesArray[unidades]);
            }
            else if (numero < 1000)
            {
                if (unidades == 0)
                    Console.WriteLine("El número ingresado es : {0} ", centenasArray[centenas]);
                else
                    Console.WriteLine("El número ingresado es : {0} {1} y {2}", centenasArray[centenas], decenasArray[decenas], unidadesArray[unidades]);
            }
            else if (numero > 1000)
            {
                if (unidades == 0)
                    Console.WriteLine("El número ingresado es : {0} ", millaresArray[millares]);
                else
                    Console.WriteLine("El número ingresado es : {0} {1} {2} y {3} ", millaresArray[millares], centenasArray[centenas], decenasArray[decenas], unidadesArray[unidades]);
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero : ");
            int numero = Convert.ToInt32(Console.ReadLine());
            numeroLiteral(numero);
        }
    }
}
