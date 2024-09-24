using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB__1__PARCIAL
{
    public  class Ordenacion
    {
        public static void Menu()
        {
            Console.WriteLine("Selecciona una opción");
            Console.WriteLine("1- Busqueda Binaria");
            Console.WriteLine("2- Busqueda Secuencial");
            Console.WriteLine("3- Búsqueda de un Elemento Mayor que un Dado");
            Console.WriteLine("4- Busqueda de elementos duplicados");
            int Q = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (Q)
            {
                case 1:
                    EFIVE();
                    break;
                case 2:
                    ESIX();
                    break;
                case 3:
                    ESEVEN();
                    break;
                case 4:
                    EEIGHT();
                    break;
                default:
                    Console.WriteLine("Selección no valida");
                    break;
            }
        }

        //EJERCICIO 5: Ordenación por Inserción
        public static void EFIVE()
        {
            // creamos una instancia de la clase Random para generar números aleatorios
            Random random = new Random();

            // definimos un array de enteros de tamaño 6, en este caso generamos números aleatorios entre 1 y 100
            int[] array = new int[6];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 101); // Generamos números aleatorios entre 1 y 100
            }

            // mostramos el array original antes de ser ordenado
            Console.WriteLine("Array original:");
            Console.WriteLine($"{string.Join(" ", array)}");

            // llamamos al método 
            InsertionSort(array);

            // mostramos el array, pero esta vez ya ordenado
            Console.WriteLine("Array ordenado:");
            Console.WriteLine($"{string.Join(" ", array)}");
        }
        public static void InsertionSort(int[] array)
        {
            // empezamos desde el segundo elemento por que tomemos como si el primero ya estuviera ordenado
            for (int i = 1; i < array.Length; i++)
            {
                // guardamos el valor del numero actual como si ya estuvier ordenado
                int Eactual = array[i];

                // este apunta al índice del elemento anterior
                int j = i - 1;

                // comenzamos a mover los elementos que son mayores que la posición hacia la derecha
                // para hacer espacio donde se insertará el nu ero actual
                while (j >= 0 && array[j] > Eactual)
                {
                    // movemos el elemento hacia la derecha
                    array[j + 1] = array[j];
                    // retrocedemos al siguiente elemento hacia la izquierda
                    j--;
                }

                // insertamos el elemento que esta actual en la posición correcta
                array[j + 1] = Eactual;
            }
        }

        //EJERCICIO 6: Ordenación por Selección
        public static void ESIX()
        {
            // creamos una instancia de la clase Random para generar  los numeros aleatorios
            Random random = new Random();

            // definimos un array de enteros de tamaño 6 en este caso generamos números aleatorios entre 1 y 100
            int[] array = new int[6];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 101); // generamos números aleatorios entre 1 y 100
            }

            // mostramos el array original antes de ser ordenado
            Console.WriteLine("Array original:");
            Console.WriteLine($"{string.Join(" ", array)}");

            // llamamos al método
            InsertionSortt(array);

            // mostramos el array ya ordenado
            Console.WriteLine("Array ordenado:");
            Console.WriteLine($"{string.Join(" ", array)}");
        }
        public static void InsertionSortt(int[] array)
        {
            // recorremos el array comenzando desde el segundo elemento
            for (int i = 1; i < array.Length; i++)
            {
                // guardamos el valor actual (que vamos a insertar en la posición correcta)
                int currentValue = array[i];
                int position = i;

                //verificamos si el anterior es mayor.
                // Si lo es, movemos el valor anterior una posición hacia adelante, y seguimos verificando.
                while (position > 0 && array[position - 1] > currentValue)
                {
                    // Movemos el valor hacia adelante si el anterior es mayor que el valor actual
                    array[position] = array[position - 1];
                    position--;
                }

                // Insertamos el valor actual en la posición que quedó después del ciclo
                array[position] = currentValue;
            }
        }

        //EJERCICIO 7: Ordenación por Burbuja Optimizada
        public static void ESEVEN()
        {
            // Creamos una instancia de la clase Random para generar números aleatorios
            Random random = new Random();

            // Definimos un array de enteros de tamaño 6, en este caso generamos números aleatorios entre 1 y 100
            int[] array = new int[6];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 101); // Generamos números aleatorios entre 1 y 100
            }

            // Mostramos el array original antes de ser ordenado
            Console.WriteLine("Array original:");
            Console.WriteLine($"{string.Join(" ", array)}");

            // Llamamos al método que implementa el algoritmo de burbuja optimizado
            BubbleSortOptimized(array);

            // Mostramos el array ya ordenado
            Console.WriteLine("Array ordenado:");
            Console.WriteLine($"{string.Join(" ", array)}");
        }
        public static void BubbleSortOptimized(int[] array)
        {
            int n = array.Length;

            // Recorremos el array como en la versión básica, pero añadimos la bandera `swapped`
            for (int i = 0; i < n - 1; i++)
            {
                bool swapped = false; // Bandera que indica si hubo intercambios

                // Este ciclo va desde el primer elemento hasta el último no ordenado
                for (int j = 0; j < n - i - 1; j++)
                {
                    // Si el elemento actual es mayor que el siguiente, los intercambiamos
                    if (array[j] > array[j + 1])
                    {
                        // Intercambiamos los elementos
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;

                        // Como hubo un intercambio, activamos la bandera `swapped`
                        //swapped = true;
                    }
                }

                // Si no hubo ningún intercambio en una pasada, el array ya está ordenado
                // y no hace falta continuar
                //if (!swapped)
                //{
                //    break;
                //}
            }
        }

        //EJERCICIO 8: Algoritmos de Ordenación por Fusión
        public static void EEIGHT()
        {
            // declaramos un array de enteros para poder ser ordenados
            int[] array = { 38, 27, 43, 3, 9, 82, 10 };

            // ostrar el array original antes de ejecutar
            Console.WriteLine("Array original:");
            Console.WriteLine(string.Join(", ", array));

            // Llamar al método
            MergeSort(array);

            //Y despues mostramos el array ya ordenado
            Console.WriteLine("Array ordenado:");
            Console.WriteLine(string.Join(", ", array));
        }
        public static void MergeSort(int[] array)
        {
            //si el arreglo tiene un longitud de uno ya esta ordenado
            if (array.Length <= 1)
                return;
            
            //calculamos en indice del medio array
            int mid = array.Length / 2;

            //se crean dos nuevos arregls para dividir entre dos 
            //para dividirmitan y mitad
            int[] left = new int[mid];//para mitad de la izquierda del array
            int[] right = new int[array.Length - mid];//mitad derechadel array

            //del array original copiamos los numeros a los nuevos array
            Array.Copy(array, 0, left, 0, mid);//izquierda
            Array.Copy(array, mid, right, 0, array.Length - mid);//derecha

            // Llamada recursiva para cada mitad del array
            MergeSort(left);
            MergeSort(right);

            // union de las mitades ordenadas
            Merge(array, left, right);
        }


        private static void Merge(int[] array, int[] left, int[] right)
        {
            int i = 0, j = 0, k = 0;

            // Combinar elementos de las dos mitades ordenadas
            while (i < left.Length && j < right.Length)
            {

                //comparamos si el arreglo de la izquierda es menor o igual  al
                //de la derecho
                if (left[i] <= right[j])
                {
                    //si, si lo es insertamos el array de la izquierda en el arreglo final
                    array[k++] = left[i++];
                }
                else
                {
                    //de lo contrario se inserta insertamos array de la derecha
                    array[k++] = right[j++];
                }
            }

            // copiar los elementos restantes de la mitad izquierda si es quelos hay
            while (i < left.Length)
            {
                array[k++] = left[i++];
            }

            // lo mismo los elementos restantes de la mitad derecha si lo hubiera
            while (j < right.Length)
            {
                array[k++] = right[j++];
            }
        }
    }
}
