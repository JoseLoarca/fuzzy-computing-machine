using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaC
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("**********BIBLIOTECA C#**********");
            int i1 = 0;
            String s1 = null;
            ControladorLibro.getInstancia().deserializar();
            do
            {
                Console.WriteLine("----------MENÚ----------");
                Console.WriteLine("1) Agregar.\n2) Listar.\n3) Eliminar.\n4) Salir.");
                Console.Write("Seleccione una opción: ");
                i1 = int.Parse(Console.ReadLine());
                switch (i1)
                {
                    case 1:
                        Libro libro = new Libro();
                        Console.WriteLine("AGREGAR LIBRO----->");
                        Console.Write("ID: ");
                        libro.idLibro = int.Parse(Console.ReadLine());
                        Console.Write("TITULO: ");
                        libro.titulo = Console.ReadLine();
                        Console.Write("AUTOR: ");
                        libro.autor = Console.ReadLine();
                        Console.Write("EDITORIAL: ");
                        libro.editorial = Console.ReadLine();
                        ControladorLibro.getInstancia().Agregar(libro);
                        ControladorLibro.getInstancia().serializar();
                        break;
                    case 2:
                        Console.WriteLine("LISTADO DE LIBROS----->");
                         Console.WriteLine("_______________________");
                        foreach (Libro l in ControladorLibro.getInstancia().listar())
                        {
                            Console.WriteLine("ID: " + l.idLibro);
                            Console.WriteLine("TITULO: " + l.titulo);
                            Console.WriteLine("AUTOR: " + l.autor);
                            Console.WriteLine("EDITORIAL: " + l.editorial);
                            Console.WriteLine("_______________________");
                        }
                        break;
                    case 3:
                        Console.WriteLine("ELIMINAR LIBRO----->");
                        Console.WriteLine("_______________________");
                        foreach (Libro l in ControladorLibro.getInstancia().listar())
                        {
                            Console.WriteLine("ID: " + l.idLibro);
                            Console.WriteLine("TITULO: " + l.titulo);
                            Console.WriteLine("AUTOR: " + l.autor);
                            Console.WriteLine("EDITORIAL: " + l.editorial);
                            Console.WriteLine("_______________________");
                        }
                        Console.Write("Ingrese el ID del libro que desea eliminar: ");
                        ControladorLibro.getInstancia().eliminar(int.Parse(Console.ReadLine()));
                        ControladorLibro.getInstancia().serializar();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("No ha seleccionado una opción válida.");
                        break;
                }

                Console.Write("Desea seguir utilizando la biblioteca? (s/n)");
                s1 = Console.ReadLine();
            } while (s1 == "s" || s1 =="S");
        }
    }
  }