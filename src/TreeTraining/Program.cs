using System;
using System.Collections.Generic;
using System.Linq;

namespace TreeTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            //if (args.Length == 0)
            //{
            //    args = new string[] { "50", "8", "4", "6", "5", "7", "9", "6", "3", "51" };
            //}

            var trainer = new BinaryTreeTrainer();
            //trainer.Run(args);


            //args = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };

            //Console.WriteLine();             
            //trainer.Run(args);

            if (args.Length == 0)
            {

                Random r = new Random();
                var input = new List<int>();

                for (int i = 0; i < r.Next(25, 200); i++)
                {
                    input.Add(r.Next(-300, 1000));
                }

                trainer.Run(input.ToArray());
            }

            else
            {
                trainer.Run(args.Select(a => int.Parse(a)).ToArray());
            }

        }
    }
}
