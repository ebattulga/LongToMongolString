﻿using NumberToString;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntToMongolString
{
    class Program
    {
        static void Main(string[] args)
        {
            var con = new NumberConverter();
            Console.OutputEncoding = Encoding.UTF8;

var text= con.convert(50, false);
            Console.WriteLine("{0}", text ); 

            for (int i = 1; i < 150; i++)
            {
                Console.WriteLine("{0} - {1}", i, con.convert(i,false));    
            }

        }
    }

    
}
