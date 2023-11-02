using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaLabSemana11.interfaces
{
    public class Pantallas
    {
        public static float[] notas = new float[100];
        public static int contador;

        public static int pantallaPrincipal()
        { 
            string texto=
            "================================" +
                "\nCasos con arreglos" +
                "\n================================" +
                "\n1: Registrar notas" +
                "\n2: Hallar la nota mayor" +
                "\n3: Hallar la nota menor" +
                "\n4: Encontrar una nota" +
                "\n5: Modificar una nota" +
                "\n6: Ver notas registradas" +
                "\n7: Salir" +
                "\n================================\n";
            Console.Write(texto);
            
            return operaciones.getEntero("Ingresa una opcion: ",texto);

        }
        public static int RegistrarNota() {
            string texto = "================================\r\n" +
                "Registrar una nota\r\n" +
                "================================\r\n";
            Console.Write(texto);


            float notaRegistrar = operaciones.getDecimal("Ingrese la nota : ");
            if (contador ==300)
            {
                Console.WriteLine( "La lista esta llena");
            }
            notas[contador] = notaRegistrar;
            contador++;
            string texto2= "================================\r\n" +
                "1: Registrar otra nota\r\n" +
                "2: Regresar\n";
          Console.Write(texto2);

            int opcion = operaciones.getEntero("Ingresa una opcion: ", texto);
            if (opcion == 2) return 0;

            return opcion;


        }

        public static int NotaMayor()
        {
            string texto = "================================\r\n" +
                "La nota mayor\r\n" +
                "================================\r\n";

            Console.Write(texto);
            if (contador == 0)
            {
                Console.WriteLine("No existen productos todavía");
            }
            else
            {
                float mayor = notas[0];
                int posicioMayor = 0;
                for (int i = 0; i < contador; i++)
                {
                    if (notas[i] > mayor)
                    {
                        mayor = notas[i];
                        posicioMayor = i;
                    }
                }

                Console.WriteLine("La nota mayor es: " + mayor); 

                for (int i = 0; i < contador; i++)
                {
                    if (i == posicioMayor)
                    {
                        Console.Write("[" + notas[i] + "] "); 
                    }
                    else
                    {
                        Console.Write(notas[i] + " ");
                    }
                }

                Console.WriteLine("\n================================");

            }

            string texto2 = "\n1: Regresar\n";
            Console.Write(texto2);

            int opcion = operaciones.getEntero("Ingresa una opción: ", texto);
            if (opcion == 1) return 0;

            return opcion;
        }
       
        public static int NotaMenor()
        {
            string texto = "================================\r\n" +
                "La nota menor\r\n" +
                "================================\r\n";

            Console.Write(texto);
            if (contador == 0)
            {
                Console.WriteLine("No existen productos todavía");
            }
            else
            {
                float menor = notas[0];
                int posicioMenor = 0;
                for (int i = 0; i < contador; i++)
                {
                    if (notas[i] < menor)
                    {
                        menor = notas[i];
                        posicioMenor = i;
                    }
                }

                Console.WriteLine("La nota menor es: " + menor);

                for (int i = 0; i < contador; i++)
                {
                    if (i == posicioMenor)
                    {
                        Console.Write("[" + notas[i] + "] "); 
                    }
                    else
                    {
                        Console.Write(notas[i] + " ");
                    }
                }

                Console.WriteLine("\n================================");
            }

            string texto2 = "\n1: Regresar\n";
            Console.Write(texto2);

            int opcion = operaciones.getEntero("Ingresa una opción: ", texto);
            if (opcion == 1) return 0;

            return opcion;
        }
       
        public static int BuscarNota()
        {
            string texto = "================================\r\n" +
                "Buscar nota\r\n" +
                "================================\r\n";
            Console.Write(texto);

            float valorBuscar = operaciones.getDecimal("Ingrese un numero: ");
            int posicionEncontrada = -1;

            for (int i = 0; i < contador; i++)
            {
                if (valorBuscar == notas[i])
                {
                    posicionEncontrada = i;
                    break; 
                }
            }

            Console.WriteLine("Ingrese la nota a buscar: " + valorBuscar);
            if (posicionEncontrada != -1)
            {
                Console.WriteLine("La nota está en la posición " + posicionEncontrada);

                for (int i = 0; i < contador; i++)
                {
                    if (i == posicionEncontrada)
                    {
                        Console.WriteLine(i + " -> [" + notas[i] + "]");
                    }
                    else
                    {
                        Console.WriteLine(i + " -> " + notas[i]);
                    }
                }
            }
            else
            {
                Console.WriteLine("La nota no se encontró en la lista.");
            }

            string texto4 = "================================\r\n" +
                "1: Regresar\n";
            Console.Write(texto4);

            int opcion = operaciones.getEntero("Ingresa una opcion: ", texto);
            if (opcion == 1) return 0;

            return opcion;
        }
        public static int ModificarNota()
        {
            string texto = "================================\r\n" +
                "Modificar nota\r\n" +
                "================================\r\n";
            Console.Write(texto);

            float valorBuscar = operaciones.getDecimal("Ingrese un número: ");
            int posicionEncontrada = -1;

            for (int i = 0; i < contador; i++)
            {
                if (valorBuscar == notas[i])
                {
                    posicionEncontrada = i;
                    break;
                }
            }

            if (posicionEncontrada > -1)
            {
                float nuevoValor = operaciones.getDecimal("Ingresa el nuevo número: ");
                Console.WriteLine("================================");
                Console.WriteLine("Antes:");

                for (int i = 0; i < contador; i++)
                {
                    if (i == posicionEncontrada)
                    {
                        Console.Write("[" + notas[i] + "] ");
                    }
                    else
                    {
                        Console.Write(notas[i] + " ");
                    }
                }

                notas[posicionEncontrada] = nuevoValor;

                Console.WriteLine("\nDespués:");

                for (int i = 0; i < contador; i++)
                {
                    if (i == posicionEncontrada)
                    {
                        Console.Write("[" + notas[i] + "] ");
                    }
                    else
                    {
                        Console.Write(notas[i] + " ");
                    }
                }

                Console.WriteLine("\n================================");
            }
            else
            {
                Console.WriteLine("No se ha encontrado el número.");
            }

            string texto2 = "================================\r\n" +
                "1: Regresar\n";

            Console.Write(texto2);

            int opcion = operaciones.getEntero("Ingresa una opción: ", texto);
            if (opcion == 1) return 0;

            return opcion;
        }
    
        public static int VerNotas()
        {
            string texto = "================================\r\n" +
                "Notas Registradas\r\n" +
                "================================\r\n";
            Console.Write(texto);

            if (contador == 0)
            {
                Console.WriteLine("No existen productos todavía");
            }
            else
            {
                Console.Write("Notas actuales: ");
                for (int i = 0; i < contador; i++)
                {
                    if (i == contador - 1)
                    {
                        Console.Write(notas[i]);
                    }
                    else
                    {
                        Console.Write(notas[i] + " - ");
                    }
                }
                Console.WriteLine("\nSiguiente posición será: " + contador);
            }

            string texto2 = "\n================================\r\n" +
                "1: Regresar\n";

            Console.Write(texto2);

            int opcion = operaciones.getEntero("Ingresa una opción: ", texto);
            if (opcion == 1) return 0;

            return opcion;
        }

      

    }

}
