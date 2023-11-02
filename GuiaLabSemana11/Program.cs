using GuiaLabSemana11.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaLabSemana11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = Pantallas.pantallaPrincipal();
            do
            {
                Console.Clear();
                switch (opcion)
                {
                    case 1:
                        opcion = Pantallas.RegistrarNota();
                        break;
                    case 2:
                        opcion = Pantallas.NotaMayor();
                        break;
                    case 3:
                        opcion = Pantallas.NotaMenor();
                        break;
                    case 4:
                        opcion = Pantallas.BuscarNota();
                        break;
                    case 5:
                        opcion = Pantallas.ModificarNota();
                        break;
                    case 6:
                        opcion = Pantallas.VerNotas();
                        break;

                    case 0:
                    default:
                        opcion = Pantallas.pantallaPrincipal();
                        break;
                } 
                

                
            } while (opcion != 7);
            Console.ReadLine();
        }
    }
}
