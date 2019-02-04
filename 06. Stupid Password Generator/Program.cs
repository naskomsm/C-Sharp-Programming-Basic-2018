using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Stupid_Password_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());



            for (int i = 1; i < n; i++)
            {
                for (int k = 0; k < n; k++)
                {
                    for (char m = 'a';  m < 'a' + l;  m++)
                    {
                        for (int z = 0; z < 'a' + l; z++)
                        {
                            for (int num = 1; num <= n; num++)
                            {
                                if(num > i && num > k)
                                {
                                    Console.Write($"{i}{k}{m}{z}{num} ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
