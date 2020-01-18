using System;
using System.Collections.Generic;
using System.Linq;
using TrainingRunner;

namespace TreeTraining

{
    class Program
    {
        static void Main(string[] args)
        {
            var trainer = new BinaryTreeTrainer();
            trainer.MinimalTree();

            //var trainer = new GraphTrainer();
            //trainer.Run(args);
            
            //BinarySearchTreeRunning(args);
        }

        private static void BinarySearchTreeRunning(string[] args)
        {
            var trainer = new BinaryTreeTrainer();

            if (args.Length == 0)
            {
                Random r = new Random();
                var input = new List<int>();

                for (int i = 0; i < r.Next(25, 30); i++)
                {
                    input.Add(r.Next(-10, 100));
                }

                Console.WriteLine("input: " + string.Join(',', input));

                trainer.Run(input.ToArray());
            }
        }
    }
}
