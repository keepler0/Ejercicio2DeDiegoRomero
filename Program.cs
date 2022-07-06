using System;

namespace Ejercicio2DeDiegoRomero
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("que tipó de triangulo es?");
            Console.WriteLine("ingrese los valores de los lados");
            double perimetro, superficie, semiperimetro;
            Console.Write("lado A: ");
            var ladoA = int.Parse(Console.ReadLine());
            Console.Write("lado B: ");
            var ladoB = int.Parse(Console.ReadLine());
            Console.Write("lado C: ");
            var ladoC = int.Parse(Console.ReadLine());
            if ((ladoA + ladoB > ladoC) && (ladoA + ladoC > ladoC) && (ladoB + ladoC > ladoA))
            {
                if (ladoA == (Math.Sqrt(Math.Pow(ladoB,2) + Math.Pow(ladoC,2))))
                {
                    Console.WriteLine("se trata de un triangulo rectangulo.");
                    semiperimetro = (ladoA + ladoB + ladoC) / 2;
                    perimetro = ladoA + ladoB + ladoC;
                    superficie = Math.Sqrt(semiperimetro * (semiperimetro - ladoA) * (semiperimetro - ladoB) * (semiperimetro - ladoC));
                    Console.WriteLine($"Su superficie es {superficie} ");
                    Console.WriteLine($"Y su perimetro es {perimetro} ");
                }
                else
                {
                    if (ladoA > (Math.Sqrt(Math.Pow(ladoB, 2)) + (Math.Pow(ladoC, 2))))
                    {
                        Console.WriteLine("se trata de un triangulo obtusangulo");
                        semiperimetro = (ladoA + ladoB + ladoC) / 2;
                        perimetro = ladoA + ladoB + ladoC;
                        superficie = Math.Sqrt(semiperimetro * (semiperimetro - ladoA) * (semiperimetro - ladoB) * (semiperimetro - ladoC));
                        Console.WriteLine($"Su superficie es {superficie} ");
                        Console.WriteLine($"Y su perimetro es {perimetro}");
                    }   
                    else
                    {
                        if (ladoA<(Math.Sqrt(Math.Pow(ladoB,2))+(Math.Pow(ladoC,2))))
                        {
                            Console.WriteLine("Se trata de un triangulo acutangulo");
                            semiperimetro = (ladoA + ladoB + ladoC) / 2;
                            perimetro = ladoA + ladoB + ladoC;
                            superficie = Math.Sqrt(semiperimetro * (semiperimetro - ladoA) * (semiperimetro - ladoB) * (semiperimetro - ladoC));
                            Console.WriteLine($"Su superficie es {superficie} ");
                            Console.WriteLine($"Y su perimetro es {perimetro}");
                        }
                    }
                        
                }
            }
            else
            {
                Console.WriteLine("los datos ingresados no conforman un triangulo");
            }
            
        }
    }
}
