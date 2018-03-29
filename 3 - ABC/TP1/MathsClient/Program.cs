﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathsClient.MathsService;

namespace MathsClient
{
    class Program
    {
        static void Main(string[] args)
        {
            MathsOperationsClient client = new MathsOperationsClient("BasicHTTP");
            Console.WriteLine(client.Add(100, 101));
            Console.WriteLine(client.Multiply(100, 101));
            Console.ReadLine();
        }
    }
}
