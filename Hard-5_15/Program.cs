using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hard_5_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.Write("Введите размер массива:");
            int length = int.Parse(Console.ReadLine());
            int[] arr = new int[length];

            for (int i = 0; i < length; i++)
            {
                arr[i] =rnd.Next(-10,10);    
            }
            Console.WriteLine("Массив:\n" + string.Join(" ", arr));

            float min = arr[0];
            int number_min = 0;
            for (int i = 0; i < length; i++)
            {
                if (min>arr[i])
                {
                    min = arr[i];
                    number_min = i;
                }
            }
            Console.Write("Номер минимального элемент : "+(number_min+1));
            double product = 1;
            for (int i = 0; i < length; i++)
            {
                if (arr[i]<0)
                {
                    i++;
                    while (arr[i]>0)
                    {
                        i *= arr[i];
                        i++;
                    }
                    break;
                }
            }
            Console.WriteLine("\nПроизвидение ="+product);

            float[] relocation = new float[length];
            int index = 0;
            for (int i = 0; i < length; i++)
            {
                if (arr[i]>1)
                {
                    relocation[index] = arr[i];
                    index++;
                }
            }
            Console.WriteLine("Преобразованный масив");
            for (int i = 0; i < length; i++)
            {
                Console.Write(" "+relocation[i]);
            }

            Console.ReadKey();
        }
    }
}
