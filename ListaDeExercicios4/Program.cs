using System;
using System.Globalization;

namespace ListaDeExercicios4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problema 0 = Impares

            int x = int.Parse(Console.ReadLine());

            for (int i = 1 ; i <= x; i++) 
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
            
            //Problema 1 = Dentro/Fora

            int n0 = int.Parse(Console.ReadLine()), dentro = 0 ,fora = 0;

            for (int i = 1; i <= n0; i++) 
            {
                int num = int.Parse(Console.ReadLine());
                
                if (num >= 10 && x <= 20) { dentro++; } else { fora++; }
            }
            Console.WriteLine($"{dentro} in\n{fora} out");
            
            //Problema 2 = Medias ponderadas

            int n = int.Parse(Console.ReadLine());
            double[] medias = {0.0,0.0,0.0}; 

            for (int i = 0; i < n; i++)
            {
                string[] vet = Console.ReadLine().Split(" ".ToString(CultureInfo.InvariantCulture));
                double num1 = double.Parse(vet[0],CultureInfo.InvariantCulture), num2 = double.Parse(vet[1], CultureInfo.InvariantCulture), num3 = double.Parse(vet[2], CultureInfo.InvariantCulture);
                medias[i] = (num1 * 2 + num2 * 3 + num3 * 5) / 10;
            }

            for (int i = 0; i < n; i++) 
            {
                Console.WriteLine(medias[i].ToString("F1", CultureInfo.InvariantCulture));
            }
            
            //Problema 3 = Divisão

            int n1 = int.Parse(Console.ReadLine());

            for ( int i = 1 ; i <= n1; i++ )
            {
                string[] vet = Console.ReadLine().Split(" ".ToString(CultureInfo.InvariantCulture));
                double dividendo = double.Parse(vet[0], CultureInfo.InvariantCulture), divisor = double.Parse(vet[1], CultureInfo.InvariantCulture);
                if (divisor == 0) 
                {
                    Console.WriteLine("Divisão impossivel");
                } else
                {
                    Console.WriteLine($"Resultado {dividendo / divisor}");
                }
            }
            
            //Problema 4 = Fatorial 

            int n2 = int.Parse(Console.ReadLine()),resultado = 0, i1 = 1;
            int fatorial = 1;
            while (i1 <= n2)
            {
                fatorial *= i1;
                i1++;
            }
            Console.WriteLine(fatorial);
            
            //Problema 5 = Divisores

            int n3 = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n3; i++)
            {
                if( n3 % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
            
            //Problema 6 = Linhas

            int l = int.Parse(Console.ReadLine());

            for (int i = 1; i <= l; i++)
            {
                Console.WriteLine($"{i} {i*i} {i*i*i}");
            }
        }
    }
}