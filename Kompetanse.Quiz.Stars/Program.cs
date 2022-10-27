﻿using System.Linq;

var tasks = Enumerable.Range(0, 5)
    .Select( e=> Task.Run(() =>
        {
            Console.Write("*");
             return;    
        }));

await Task.WhenAll(tasks);

Console.Write($"{tasks.Count()} stars");

