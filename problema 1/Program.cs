using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema_1
{
    class Program
    {

        //EJERCICIO 1     

        static void Main(string[] args)
        {

            int num = 0;

            Console.Clear();

            Console.WriteLine("Digite  el numero");


            num = int.Parse(Console.ReadLine());



            if (num % 2 == 0)
            {
                Console.WriteLine("El numero es par...");
            }
            else
            {
                Console.WriteLine("El numero es impar");

            }
        }

        //EJERCICIO 2
        static void Tablamult(string[] args)
        {

            int c = 1;
            int t = 0;
            int r = 0;

            Console.WriteLine("DIGITE EL NUMERO DE LA TABLA");

            t = int.Parse(Console.ReadLine());




            while (c <= 12)
            {

                r = c * t;

                Console.WriteLine(c + "X" + t + "=" + r);

                c = c + 1;

            }


            Console.ReadKey();



        }


        //Ejercicio 3
        static void Tablasmult(string[] args)
        {
            Console.WriteLine("digite el numero que desea multiplicar");
            int rango;


            rango = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine();

            for (int i = 1; i < rango; i++)
            {
                Console.WriteLine("----------------TABLA DEL #" + i);

                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine(i + "x" + j + "=" + (i + j));
                    Console.WriteLine("");
                }

            }

            Console.ReadKey();

        }

        //EJERCICIO 4
        static void Numprimo()
        {
            int n = 0;
            int c = 0;
            Console.WriteLine("  INGRESE EL NUMERO  ");



            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < (n + 1); i++)
            {

                if (n % i == 0)
                {
                    c++;
                }
            }

            if (c != 2)
            {

                Console.WriteLine(" EL NUMERO NO ES PRIMO.  ");
            }
            else
            {
                Console.WriteLine("   EL NUMERO SI ES PRIMO   ");

                Console.ReadKey();
            }


        }
        //EJERCICIO 5 Y 6
        static void Vectores(string[] args)

        {

            string[] edad = { "12", "50", "23", "11", "18", "35", "41", "85", "16", "45" };
            string[] nombre = { "juan", "maria", "tereza", "pedro", "javier", "ana", "diana", "jorge", "dayana", "lady" };

            string nombreBuscar;
            string salir;
            bool existe = false;
            int posicion = 0;

            do
            {
                Console.Clear();
                ImprimirVector(edad, " Edades");
                ImprimirVector(nombre, "Nombres");
                do
                {
                    Console.WriteLine("Digite El nombre");
                    nombreBuscar = Console.ReadLine();
                    if (nombreBuscar == String.Empty)
                    {
                        Console.WriteLine("El campo no puede esta vacio, ingrese un dato : ");
                    }
                } while (nombreBuscar == String.Empty);


                for (int i = 0; i < nombre.Length; i++)
                {
                    if (nombre[i] == nombreBuscar)
                    {
                        existe = true;
                        posicion = i;
                    }
                }

                if (existe)
                {
                    Console.WriteLine(" El Usuario " + nombreBuscar + " Existe y tiene " + edad[posicion] + " Años de edad");
                }
                else
                {
                    Console.WriteLine(" El Usuario " + nombreBuscar + " No Existe");
                }
                do
                {
                    Console.WriteLine(" \nDesea salir del sistema \n S/s para Salir \n N/n Para volver a buscar");
                    salir = Console.ReadLine();
                    if (salir == String.Empty)
                    {
                        Console.WriteLine("Porfavor digite un opcion valida");
                    }

                } while (salir != "S" && salir != "N" && salir != "s" && salir != "n");

            } while (salir != "S" && salir != "s");



        }

        static void ImprimirVector(Array vector, string titulo)
        {
            Console.WriteLine("\n Arreglo " + titulo);

            foreach (string elemento in vector)
            {
                Console.Write("[ " + elemento + " ] ");
            }
            Console.WriteLine("\n");


        }
        //EJERCICIO 7
        static void Mayormenor()

        {
            Console.Clear();


            int[] edad = { 12, 50, 23, 11, 18, 35, 41, 85, 16, 45 };
            string[] nombres = { "juan", "maria", "tereza", "pedro", "javier", "ana", "diana", "jorge", "dayana", "lady" };
            int emayor = 0, emenor = 100, npem = 0, npmn = 0;
            for (int i = 0; i < edad.Length; i++)
            {
                if (edad[i] > emayor)
                {
                    emayor = edad[i];
                    npem = i;
                }
                if (edad[i] < emenor)
                {
                    emenor = edad[i];
                    npmn = i;
                }
            }

            Console.WriteLine("Persona mayor es : " + nombres[npem] + " Edad : " + emayor + " años  ");
            Console.WriteLine("Persona menor es : " + nombres[npmn] + " Edad : " + emenor + " años  ");


        }
        //EJERCICIO 8
        static void PALINDROMO(string[] args)
        {
            string palabra, inverso, caracter;

            int i;

            Console.WriteLine("palabra que desea invertir");
            palabra = Convert.ToString(Console.ReadLine());

            i = palabra.Length;
            inverso = "";
            for (int x = i = 1; x >= 0; x = i++)
            {
                caracter = palabra.Substring(x, 1);

                inverso = inverso + caracter;

            }
            if (palabra == inverso)
            {
                Console.WriteLine("ES PALINDROMO");
            }
            else
            {
                Console.WriteLine("NO ES UN PALINDROMO");
            }

            Console.ReadKey();

        }

        //EJERCICO 9
        static void FIBIONACCI(string[] args)
        {

            byte cant;
            int a = 0, b = 1, c;



            string aux;
            Console.WriteLine("Cuantos numeros FIBONACCI desea generar?...");

            aux = Console.ReadLine();
            cant = byte.Parse(aux);

            Console.Write("LA SERIE ES:" + a + " " + b + " ");

            for (int i = 3; i <= cant; i++)
            {
                c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;

            }
            Console.WriteLine();
            Console.Write("PRESIONE UNA TECLA PARA SALIR...");
            Console.ReadKey();
        }






    }


}

