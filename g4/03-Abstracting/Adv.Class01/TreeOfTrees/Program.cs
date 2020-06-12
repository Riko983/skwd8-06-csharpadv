﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Xml.XPath;

namespace TreeOfTrees
{
    class Program
    {
        static void Main(string[] args)
        {
            var weko = new Person { FirstName = "Wekoslav", LastName = "Stefanovski" };
            Console.WriteLine(weko.GetType().FullName);
            Console.WriteLine(weko);
            Console.WriteLine("------------");


            Tree myTree = new AppleTree();
            var result = myTree.GetSeedsMultiple(3);
            Console.WriteLine(string.Join("\n", result));
            Console.WriteLine("------------");

            var trees = new List<Tree>
            {
                new AppleTree(),
                new PearTree(),
                new BananaTree(),
                new WalnutTree()
            };

            var fruits = trees.Select(tree => tree.GetSeeds());
            Console.WriteLine(string.Join("\n", fruits));
            Console.WriteLine("------------");

            var climbables = new List<IClaimable>();

            climbables.Add(new AppleTree());
            climbables.Add(new WoodyHill("Ljubash"));
            climbables.Add(new WoodyMountain("Baba"));

            foreach (var item in climbables)
            {
                //Console.WriteLine(item is Tree);
                //Console.WriteLine(item is Mountain);
                //Console.WriteLine(item is WoodyMountain);
                if (item is Mountain mountain)
                {
                    Console.WriteLine("Is item mountain?");
                    Console.WriteLine(item == mountain);
                    // Console.WriteLine(item.Name);
                    Console.WriteLine(mountain.Name);
                }

                item.Climb();
            }

        }
    }
}
