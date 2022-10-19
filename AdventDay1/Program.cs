using System;
using System.IO;
using System.Linq;

namespace AdventDay1
{
    class Program
    {
        static void Main(string[] args)
        {
            //var fil = File.ReadAllLines(Path.GetFullPath("text.txt"));
            //int.TryParse(fil[0], out int depth);

            int[] depth = File.ReadAllLines(Path.GetFullPath("text.txt")).Select(int.Parse).ToArray();
            int[] depthbatch = File.ReadAllLines(Path.GetFullPath("text2.txt")).Select(int.Parse).ToArray();


            int increased = 0;


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

            //Part 2 Loop

            Console.WriteLine(" BATCH TIME");

            var BatchIncreased = 0;

            for (int i = 0; i < depth.Length - 2; i++)
                if (i == 0)
                {
                    Console.Write(depth[i]);
                    Console.WriteLine(" Nothing to do Fam");
                }



                else if ((depth[i] + depth[i+1] + depth[i + 2]) > (depth[i-1] + depth[i] + depth[i + 1]))
                {
                    Console.Write(depth[i]);
                    Console.WriteLine(" Increased");
                    BatchIncreased += 1;
                }

                else if ((depth[i] + depth[i + 1] + depth[i + 2]) == (depth[i - 1] + depth[i] + depth[i + 1]))
                {
                    Console.Write(depth[i]);
                    Console.WriteLine(" No change");
                   
                }

                else
                {

                    Console.Write(depth[i]);
                    Console.WriteLine(" Decreased");
                }







            Console.WriteLine();
            Console.Write("Total number of increases in survey area = ");
            Console.WriteLine(increased);

            Console.WriteLine();
            Console.Write("Total number of increases in batch survey area = ");
            Console.WriteLine(BatchIncreased);


        }
    }
}
