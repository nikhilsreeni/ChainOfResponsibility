using ChainOfResposibility.ChainBase;
using Ninject;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace ChainOfResposibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());

            var chain = kernel.Get<IChain<int, List<string>>>();

            var chainResponse = chain.CreateChain().Handle(1, new List<string>());

            Console.WriteLine(string.Join(",", chainResponse));

            Console.ReadLine();
        }
    }

}

