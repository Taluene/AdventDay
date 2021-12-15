using System;

namespace AdventDay1
{
    class Program
    {
        static void Main(string[] args)
        {
            int increased = 0;
            int[] depth = new int[10] { 199,
                                            200,
                                            208,
                                            210,
                                            200,
                                            207,
                                            240,
                                            269,
                                            260,
                                            263
                                             };


            for (int i = 0; i < depth.Length; i++)
                if (i == 0)
                {
                         Console.Write(depth[i]);
                         Console.WriteLine(" Nothing to do Fam");
                }
                
                
                
                else if (depth[i] > depth[i - 1])
                   { 
                         Console.Write(depth[i]);
                         Console.WriteLine(" Increased");
                          increased += 1;
                    }
                else
                {

                    Console.Write(depth[i]);
                    Console.WriteLine(" Decreased");
                }

            Console.WriteLine();
            Console.Write("Total number of increases in survey area = ");
            Console.WriteLine(increased);


        }
    }
}
