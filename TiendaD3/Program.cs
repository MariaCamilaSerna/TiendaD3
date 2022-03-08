using System;
using System.Collections.Generic;

namespace TiendaD3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool sal = true;
            List<ClienteServicio> listaClientes = new();

            while (true)
            {
                Console.WriteLine("\nBIENVENIDO A D3");
                Console.WriteLine("Elija una opción por favor.");
                Console.WriteLine("\n 1.Modulo clientes.");
                Console.WriteLine("\n 2.Modulo producto");
                Console.WriteLine("\n 3.Modulo venta");
                Console.WriteLine("\n 4.Modulo reporte");
                Console.WriteLine("\n 5.Modulo configuración");
                Console.WriteLine("\n 6. Salir.");

                string elegir = Console.ReadLine();
                Console.Clear();
                switch (elegir)
                {
                    case "1":
                        string elige1 = "1";
                        string elige2 = "2";
                        string elige3 = "3";
                        string elige4 = "4";
                        string elige5 = "5";
                        Console.WriteLine("Elegiste el modulo clientes.");
                        Console.WriteLine("Bienvenido, que quieres hacer?");
                        Console.WriteLine("\n 1.Registrar clientes");
                        Console.WriteLine("\n 2.Buscar clientes");
                        Console.WriteLine("\n 3.Modificar clientes");
                        Console.WriteLine("\n 4.Deshabilitar clientes");
                        string opción = Console.ReadLine();
                        Console.Clear();
                        if (opción == elige1)
                        {
                            var clienteServicio = new ClienteServicio();
                            sal = true;
                            do
                            {
                                Console.WriteLine("REGISTRO CLIENTE");
                                Console.WriteLine("Ingrese el nombre del cliente");
                                clienteServicio.nombre = Console.ReadLine();
                                Console.WriteLine("Ingrese la dirección.");
                                clienteServicio.direccion = Console.ReadLine();
                                Console.WriteLine("Ingrese el número de telefono");
                                clienteServicio.telefono = int.Parse(Console.ReadLine());
                                Console.WriteLine("Digite el número de cédula");
                                clienteServicio.cedula = Console.ReadLine();
                                
                                Console.WriteLine("\n ¿Quieres seguir registrando clientes?");
                                string opcion = Console.ReadLine();

                                if (opcion != "si")
                                    sal = false;
                                Console.Clear();
                            } while (sal == true);
                            listaClientes.Add(clienteServicio);

                        }


                        else if (opción == elige5)
                        {
                            break;
                        }


                        break;
                    case "6":
                        Console.WriteLine("Hasta luego");
                        break;
                    default:
                        // code block
                        break;
                }


            }

        }
    }
}
