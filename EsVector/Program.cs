using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsVector
{    
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayDiInteri = new int[5];
            arrayDiInteri[0] = 5;
            arrayDiInteri[1] = 3;

            for (int i = 0; i < arrayDiInteri.Length; i++)
            {
                arrayDiInteri[i] = i;
            }

            int j = 0;
            while (j < arrayDiInteri.Length)
            {
                //Fai cose
                j++;
            }

            int[] arrayDiInteri2 = new int[] { 2, 4, 5, 6, 7 };

            SVector[] arrayDiSvectors = new SVector[] { new SVector(5,8), new SVector (8,15) };

            int[] arrayDiInteri3 = { 10, 85, -5, 6, 34 };

            Console.WriteLine("arrayDiInteri2: " + arrayDiInteri2);

            foreach (int k in arrayDiInteri2)
            {
                Console.WriteLine(k);
            }

            int[,] matrice = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            Console.WriteLine("Elementi dell'arrayDiInteri3 prima del sort");
            foreach (int k in arrayDiInteri3)
            {
                Console.WriteLine(k);
            }

            int[] arrayDiInteri4 = new int[arrayDiInteri3.Length];

            Array.Copy(arrayDiInteri3, arrayDiInteri4, arrayDiInteri3.Length);

            Array.Sort(arrayDiInteri4);

            Console.WriteLine("Elementi dell'arrayDiInteri3 dopo il sort");
            foreach (int k in arrayDiInteri3)
            {
                Console.WriteLine(k);
            }

            Console.WriteLine("Elementi dell'arrayDiInteri4 dopo il sort");
            foreach (int k in arrayDiInteri4)
            {
                Console.WriteLine(k);
            }

            var arrayClone = (int[])arrayDiInteri4.Clone();

            Console.WriteLine("Elementi dell'arrayClone");
            foreach (int k in arrayClone)
            {
                Console.WriteLine(k);
            }

            arrayClone[3] = 9999;

            Console.WriteLine("Elementi dell'arrayDiInteri4 dopo la modifica");
            foreach (int k in arrayDiInteri4)
            {
                Console.WriteLine(k);
            }

            string input = Console.ReadLine();

            string result;
            string temp = string.Empty;
            if (input.Length > 2)
            {
                temp = "Sì";
            }
            else
            {
                temp = "No";
            }
            result = temp; 

            result = input.Length > 2 ? "Sì" : "No";

            CustomArray cArray = new CustomArray();
            cArray[56] = 1264;

            int a = cArray[56];

            int b = cArray[126];

            Console.ReadLine();
        }
    }
}
