using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Menu
    {
        static void Main()
        {
            int NumSelect = -1;
            bool validar=false;

            do
            {
                do
                {
                    Console.WriteLine("Bienvenida Profe Judith. \r\n Seleccione una opción: \r\n 1-Ejercicio cola \r\n 2-Ejercicio75 pila \r\n 3-Ejercicio lista \r\n 0-Salir");

                    string ValorAParcear = Console.ReadLine();
                    int numero;
                    validar = int.TryParse(ValorAParcear, out numero);

                    if (validar == true)
                    {                      
                        NumSelect = numero;
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Valor ingresado no válido. Por favor, ingrese un número del 0 al 3.");
                    }
                } while (!validar);

                switch (NumSelect)
                {
                    case 1:
                        Queue<string> Cola = new Queue<string>();                       
                        Console.WriteLine("Escriba tantas palabras o frases como desee, enter para ingresarlas a la cola. \r\nCuando quiera verlas escriba un '.'");

                        string x = string.Empty;

                        while (x != ".")
                        {
                            x = Console.ReadLine();
                            if (x != ".") Cola.Enqueue(x); // Evitamos encolar el "."
                        }

                        Console.WriteLine("Usted guardó estas cadenas:");

                        while (Cola.Count > 0)
                        {
                            string Dato = Cola.Dequeue();
                            Console.WriteLine(Dato);
                        }
                        Console.WriteLine("presione enter para continuar");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 2:
                        Stack<string> Pila = new Stack<string>();
                        Console.WriteLine("Escriba tantas palabras o frases como desee. Cuando quiera verlas, presione 'Enter'.");

                        string z = Console.ReadLine();

                        while (!string.IsNullOrEmpty(z))
                        {
                            Pila.Push(z);
                            z = Console.ReadLine();
                        }

                        Console.WriteLine("Usted guardó estas cadenas:");

                        while (Pila.Count > 0)
                        {
                            string Dato = Pila.Pop();
                            Console.WriteLine(Dato);
                        }
                        Console.WriteLine("presione enter para continuar");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 3:
                        List<string> Lista = new List<string>();
                        Console.WriteLine("Escriba tantas palabras o frases como desee. Cuando quiera verlas, presione 'Enter'.");

                        string y = Console.ReadLine();

                        while (!string.IsNullOrEmpty(y))
                        {
                            Lista.Add(y);
                            y = Console.ReadLine();
                        }

                        if (Lista.Count > 0)
                        {
                            Console.WriteLine($"Usted guardó {Lista.Count} elementos en la lista.");
                            Console.WriteLine($"¿Cuál desea ver? Ingrese un número de 1 a {Lista.Count}.");

                            bool InputValido = false;
                            int IndiceLista;

                            while (!InputValido)
                            {
                                if (int.TryParse(Console.ReadLine(), out IndiceLista) && IndiceLista > 0 && IndiceLista <= Lista.Count)
                                {
                                    InputValido = true;
                                    Console.WriteLine($"El elemento en la posición {IndiceLista} es: {Lista[IndiceLista - 1]}");
                                }
                                else
                                {
                                    Console.WriteLine("Por favor, ingrese un número válido.");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("No se ingresaron elementos en la lista.");
                        }
                        Console.WriteLine("presione enter para continuar");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 0:
                        Console.WriteLine("Saliendo del programa...");                        
                        break;
                    default:
                        Console.WriteLine("El número seleccionado no es válido.");
                        Console.WriteLine("presione enter para continuar");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }

            } while (NumSelect != 0);           
        }
    }    
}
