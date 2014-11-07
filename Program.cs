using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppsSumaYProducto
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, suma, producto;
            string linea;

            Console.WriteLine("PROGRAMA SUMA Y PRODUCTO DE DOS NUMEROS!!! ");
            Console.WriteLine("Digite Numero 1: ");
            linea= Console.ReadLine();         
            // para convertir a numero
            numero1= int.Parse(linea);
            
            Console.WriteLine("Digite Numero 2: ");
            linea= Console.ReadLine();
            // para convertir a numero
            numero2= int.Parse(linea);

            suma = numero1 + numero2;
            Console.WriteLine("La suma es: "+suma); // es write LINE para que salte a la otra linea hace la funcion de /n

            producto = numero1 * numero2;
            Console.WriteLine("El producto es: " + producto);

            Console.ReadKey(); // para q cree un intermitente.... es como el return 0 creo :S


        }
    }
}
