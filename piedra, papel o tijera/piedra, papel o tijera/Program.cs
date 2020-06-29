using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace piedra__papel_o_tijera
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int cont1 = 0, cont2 =0;
            do
            {
                int es;
                Console.WriteLine("\nEscoja");
                Console.WriteLine("\n1-Piedra");
                Console.WriteLine("2-Papel");
                Console.WriteLine("3-Tijera");
                es = Convert.ToInt32(Console.ReadLine());
                if (es > 3 || es < 1)
                {
                    Console.WriteLine("Escoja un numero valido");
                    
                }
                else
                {
                    Random rand = new Random();
                    int numero = rand.Next(1, 3);
                    string[] hola = { " ", "Piedra", "Papel", "Tijera" };
                    Console.WriteLine("Usted a lanzado: " + hola[es]);
                    Console.WriteLine("La maquina a lanzado: " + hola[numero]);
                    if (es == numero)
                    {
                        Console.WriteLine("han empatado");
                    }
                    else if ((es == 3 && numero ==2)|| (es == 2 && numero == 1)||(es == 1 && numero == 3))
                    {
                        Console.WriteLine("Usted a ganado");
                        cont2++;
                    }
                    else
                    {
                        Console.WriteLine("Usted a perdido");
                        cont1++;
                    }

                    Console.WriteLine("El contador el es siguiente: ");
                    Console.WriteLine("\nMaquina: "+ cont1);
                    Console.WriteLine("Usted: "+ cont2);
                    Console.WriteLine("\nEscriba 0 para volver a jugar, y cualquier otra tecla para terminar");
                    a = Convert.ToInt32(Console.ReadLine());
                    
                }

            } while (a==0);
            Console.ReadKey();
        }

    }
}
