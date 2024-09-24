using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB__1__PARCIAL
{
    public class Busqueda
    {
        public static void Menu()
        {
            bool regresar = true;

            while (regresar)
            {
                Console.Clear();

                Console.WriteLine("Selecciona una opción");
                Console.WriteLine("1- Busqueda Binaria");
                Console.WriteLine("2- Busqueda Secuencial");
                Console.WriteLine("3- Búsqueda de un Elemento Mayor que un Dado");
                Console.WriteLine("4- Busqueda de elementos duplicados");
                int P = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (P)
                {
                    case 1:
                        EONE();
                        break;
                    case 2:
                        ETWO();
                        break;
                    case 3:
                        ETHREE();
                        break;
                    case 4:
                        EFOUR();
                        break;
                    default:
                        Console.WriteLine("Selección no valida");
                        break;
                }
                if (regresar)
                {
                    Console.WriteLine("\n¿Deseas regresar al menú de Algoritmos de Ordenación? (S/N)");
                    string respuesta = Console.ReadLine();

                    if (respuesta.ToUpper() == "S")
                    {
                        regresar = true; // Regresar al menú de ordenación
                    }
                    else
                    {
                        regresar = false; // Salir al menú principal
                    }
                }
            }
        }


        //EJERCICIO 1: BUSQUEDA BINARIA
        public static void EONE()
        {
            Console.WriteLine("Ordenamiento de numeros");
            int[] arregloNumeros = { -1, 1, 12, 44, 440, 220, 20, 540, 8, 7, 7, 1, -2, 9 };
            Array.Sort(arregloNumeros);

            Console.WriteLine(string.Join(", ", arregloNumeros));
            int posicionBinaria = 20;

            Console.WriteLine($"Buscar {posicionBinaria}");
            int resultadoBusqueda = Array.BinarySearch(arregloNumeros, posicionBinaria);

            if (resultadoBusqueda >= 0)
            {
                Console.WriteLine($"{resultadoBusqueda}");
            }
            else
            {
                Console.WriteLine("-1");
            }
            Console.ReadKey();
        }

        //EJERCICIO 2: BUSQUEDA SECUENCIAL
        public static void ETWO()
        { 
            //Generamos un arreglo de numeros aleatorios y le digo que solo me cree 15
            Random random = new Random();
            int[] arregloNumeros = new int[15];

            //Generamos los 15 numeros aleatorios entre 1 y 100
            for (int i = 0; i < arregloNumeros.Length; i++)
            {
                arregloNumeros[i] = random.Next(1, 101);
            }

            //Mostramos arreglo
            Console.WriteLine("Arreglo Generados");
            Console.WriteLine(string.Join(" ", arregloNumeros));
            Console.WriteLine(" ");

            //Mando a llamar la fuinción
            int resultado = DivisiblePorTres(arregloNumeros);

            if (resultado != -1)
            {
                Console.WriteLine($"El primer numero divisible por 3 se encuentra en la posición numero {resultado}");
            }
            else
            {
                Console.WriteLine("No hay ningun numero divisible por 3");
            }
        }

        private static int DivisiblePorTres(int[] array)
        {
            //le decimos que pase por todos los elementos del arreglo
            for (int i = 0; i < array.Length; i++)
            {
                //checamos si en el numero actial en el que esta se puede dividir por 3
                if (array[i] % 3 == 0)
                {
                    return i;
                }
            }
            //si no encuentra ninguno qie me retorne -1
            return -1;
        }

        //EJERCICIO 3: BUSQUEDA DE UN ELEMENTO MAYOR QUE UNO DADO
        public static void ETHREE()
        {
            //en este caso yo le paso en array y el,valor referencial
            int[] numeros = { 2, 4, 6, 8, 10 };
            int ValorDado = 5;

            int indice = NumeroMayorQue(numeros, ValorDado);
            Console.WriteLine($"El indice del primer numero mayor que {ValorDado} es {indice}");
        }
        private static int NumeroMayorQue(int[] array, int valor)
        {
            //checamos sobre cada elemento del array
            for (int i = 0; i < array.Length; i++)
            {
                //si el numero que esta actualmente  es mayor al numero que deseamos retirnamos el indice
                if (array[i] > valor)
                {
                    return i;
                }
            }
            // y si no retornamos -1
            return -1;
        }

        //EJERCICIO 4: BUSQUEDA DE ELEMENTOS DUPLICADOS
        public static void EFOUR()
        {
            //paso el arreglo de numeros
            int[] array = { 1, 2, 5, 3, 7 };

            Console.WriteLine("Numeros");
            foreach (int num in array)
            {
                Console.WriteLine(num + " ");
            }
            Console.WriteLine();

            //mamdamos a llamar el metodo que ocupamos para verificar  duplicado 
            bool EsIgual = Verificar_Duplicados(array);
            Console.WriteLine($"¿El array tiene duplicado?  {EsIgual}");
        }

        private static bool Verificar_Duplicados(int[] array)
        {
            //comenzamos a iterar con todos los numeros desde el primero
            for (int i = 0; i < array.Length; i++)
            {
                //y con un for anidado comenzamos a comparar pero desde el siguiente numero
                for (int j = i + 1; j < array.Length; j++)
                {
                    //si el array es igual con el otro , retornamos un true
                    if (array[i] == array[j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

    }

}


