using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LAB__1__PARCIAL
{
    public class E_y_V_A
    {
        public static void Menu()
        {
            Console.WriteLine("Selecciona una opción");
            Console.WriteLine("1- Laberinto (Maze)/");
            Console.WriteLine("2- Generación de Combinaciones");
            Console.WriteLine("3- Resolución de Rompecabezas");
            Console.WriteLine("4- Sudoku Solver");
            int R = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (R)
            {
                case 1:
                    ENINE();
                    break;
                case 2:
                    ETEN();
                    break;
                case 3:
                    ELEVEN();
                    break;
                case 4:
                    ETWELVE();
                    break;
                default:
                    Console.WriteLine("Selección no valida");
                    break;
            }
        }
        // EJERCICIO 09: Laberinto
        public static void ENINE()
        {//manipular los o y 1 para cambiar camino
            int[,] laberinto = {
                                {1, 1, 1, 0},
                                {0, 0, 1, 1},
                                {0, 1, 0, 1},
                                {0, 1, 1, 1} // la salida en la última celda
            };

            Resolver resolver = new Resolver(laberinto);

            if (resolver.Solver(0,0))
            {
                Console.WriteLine("Hay camino");
            }
            else
            {
                Console.WriteLine("No hay camino");
            }
        }
        public class Resolver
        {
            //creamos una matriz es aqui donde estamos presentando el laberinto (1-libre,0-ocupado )
            int [,] laberinto;
            int filas, columnas;
            bool[,] pasados;

            //inicializamos las dimensiones del laberinto
            public Resolver(int[,]laberinto)
            {
                this.laberinto = laberinto;
                filas = laberinto.GetLength(0);//tenemos el numero de flias del laberinto
                columnas = laberinto.GetLength(1);//tenemos el numero de columnas del laberinto
                pasados = new bool[filas, columnas];
            }

            //aqui es donde vamos a resolver el laberinto y voy a utilizar posiciones x y y (como filas y columnas)
            //obtener la solución
            public bool Solver(int x ,int y)
            {
                //Estamos utilizando el caso base: Si llegamos a la celda final 
                if(x == filas - 1 && y == columnas - 1 )
                    return true;//si llego a la ultima celda

                if(!Validar(x,y))
                    return false;

                //marcar la selda actual como visitada
                pasados[x,y] = true;

                //En este caso las cuatro direcciones posibles que se van a checar
                //primero nos movemos hacia abajo
                if(Solver (x + 1, y) ||
                 //Mover hacia la derecha 
                   Solver (x, y + 1) || 
                 //Mover hacia arriba
                   Solver (x - 1, y) ||
                 //Mover hacia izquierda
                   Solver (x, y -1))
                {
                    return true;//si alguna de estas direcciones continua, es decir si es valida ponemos un true
                }

                // si ninguna direccion seleccionada que paso  se desmarca a celda  y aqui regresamos
                pasados[x,y]= false;

                //pero si no encuentra el camino lo damos como falso
                return false;
            }
            private bool Validar(int x, int y)
            {
                return x >= 0 && x < filas && y >= 0 && y < columnas && laberinto[x, y] == 1 && !pasados[x, y];

            }

        }
        

        public static void ETEN()
        {


        }
        public static void ELEVEN()
        {

             
        }
        public static void ETWELVE()
        {

        }
    }
}
