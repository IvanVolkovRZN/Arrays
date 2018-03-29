using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_2._0
{
    class Program
    {

        

        

        static void Main(string[] args)
        {

            Start();
        }

        public static void Start()
        {
            char again = 'д';

            while (again == 'д')
            {
                Console.WriteLine("Привет, чувак!");
                Console.WriteLine("Ввиди мне два массива. Давай начнем с первого.");
                int[,] One = ArraysNew();
                Console.WriteLine("Окей. Теперь введи мне второй массив.");
                int[,] Two = ArraysNew();
                Console.WriteLine("Замечательно. А теперь давай сложим их.");
                int[,] Three = Summa(One, Two);
                foreach (var v in Three)
                    Console.WriteLine(v);

                Console.WriteLine("Ты хочешь сложить два новых массива? (д/н)");
                again = Convert.ToChar(Console.ReadLine());
            }
        






        }

        public static int[,] ArraysNew()
        {
            Console.WriteLine("число элементов по вертикали:");
            int V = int.Parse(Console.ReadLine());
            Console.WriteLine("число элементов по горизонтали:");
            int G = int.Parse(Console.ReadLine());
            Console.WriteLine("Теперь вводи элементы.");
            int[,] mas = new int[V,G];
            for (int i = 0; i < V; i++)
                for (int p = 0; p < G; p++)
                {
                    Console.Write("[" + i + "," + p + "]=");
                    mas[i, p] = int.Parse(Console.ReadLine());
                }
            return mas;



        }

        public static int[,] Summa(int[,] A, int[,] B)
        {
            int Q1=A.GetLength(0);
            int Q2= B.GetLength(0);
            int W1= A.GetLength(1);
            int W2= B.GetLength(1);

            int Q = Math.Max(Q1,Q2);
            int W = Math.Max(W1, W2);

            int[,] Resultat = new int[Q, W];
            for (int i = 0; i < Q; i++)
                for (int p = 0; p < W; p++)
                {
                    int X;
                    if (i<Q1 && p<W1) X = A[i, p]; else X = 0;
                    int Z;
                    if (i < Q2 && p < W2) Z = B[i, p]; else Z = 0;

                    Resultat[i, p] =  X + Z;
                }
         
            return Resultat;
        }






    }   




}