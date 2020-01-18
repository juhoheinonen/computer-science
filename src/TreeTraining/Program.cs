using ComputerScience;
using ComputerScience.Trees;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Xml.Linq;
using TrainingRunner;

namespace TreeTraining

{
    class Program
    {
        static void Main(string[] args)
        {
            XDocument xDoc = XDocument.Load("data\\kotus-sanalista_v1.xml");
            var input = xDoc.Descendants("s").Select(x => x.Value).ToList();
            
            TrieTester.Test(input, args);
        }        
    }
}
