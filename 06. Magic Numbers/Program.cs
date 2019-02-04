using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Magic_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());


            for (int i = 1; i < 9; i++)
            {
                for (int m = 1; m < 9; m++)
                {
                    for (int z = 1; z < 9; z++)
                    {
                        for (int l = 1; l < 9; l++)
                        {
                            for (int k = 1; k < 9; k++)
                            {
                                for (int j = 1; j < 9; j++)
                                {
                                    if (i*m*z*l*k*j == number)
                                    {
                                        Console.Write($"{i}{m}{z}{l}{k}{j} ");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
