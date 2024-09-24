using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB__1__PARCIAL
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {

                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("====================================");
                    Console.WriteLine("==   Seleccione  el apartado    ====");
                    Console.WriteLine("== 1. Algoritmos de Busqueda    ====");
                    Console.WriteLine("== 2. Algoritmo de Ordenación   ====");
                    Console.WriteLine("== 3. Exhaustiva y Vuelta Atras ====");
                    Console.WriteLine("============ 0. Salir ==============");
                    Console.WriteLine("");
                    Console.Write("Selección: ");
                    int sectionSelected = int.Parse(Console.ReadLine());

                    if (sectionSelected == 0) { break; }

                    Console.Clear();

                    switch (sectionSelected)
                    {
                        case 1:
                            Busqueda.Menu();
                            break;
                        case 2:
                            Ordenacion.Menu();
                            break;
                        case 3:
                            E_y_V_A.Menu();
;                           break;
                        default:
                            Console.WriteLine("Opción no válida. Inténtalo de nuevo.");
                            break;
                    }
                    Console.ReadKey();

                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ups ha ocurrido un error: {e.Message}");
            }
        }
    }
}
