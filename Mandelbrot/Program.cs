using System;
using System.Diagnostics;
using Spectre.Console;

namespace Mandelbrot
{
    class Program
    {
        readonly static string[] c = new[]
        {
            "[default on black] [/]",
            "[default on darkgreen] [/]",
            "[default on green] [/]",
            "[default on lime] [/]",
            "[default on olive] [/]",
            "[default on navyblue] [/]",
            "[default on navy] [/]",
            "[default on blue] [/]",
            "[default on teal] [/]",
            "[default on aqua] [/]",
            "[default on cyan] [/]",
            "[default on cyan1] [/]",
            "[default on red] [/]",
            "[default on red3] [/]",
            "[default on darkred] [/]",
            "[default on maroon] [/]",
            "[default on purple] [/]",
            "[default on purple3] [/]",
            "[default on fuchsia] [/]",
            "[default on yellow] [/]",
            "[default on white] [/]",
            "[default on silver] [/]",
            "[default on grey] [/]",
            "[default on black] [/]",
        };
        readonly static int max_iter = c.Length - 1;

        static void Main(string[] args)
        {
            var stop = Stopwatch.StartNew();
            for (int y = -39; y <= 39; y++)
            {
                for (int x = -39; x <= 39; x++)
                {
                    var creal = x / 20d;
                    var cimag = y / 20d;
                    var zreal = creal;
                    var zimag = cimag;
                    var count = 0;
                    while (count < max_iter)
                    {
                        var zm = zreal * zreal;
                        var zn = zimag * zimag;
                        var zl = zm + zn;
                        
                        if ( zl > 4 ) break;

                        var zr2 = zm - zn + creal;
                        zimag = zreal * zimag * 2 + cimag;
                        zreal = zr2;
                        count++;
                    }
                    AnsiConsole.Markup(c[count]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine($"{stop.ElapsedMilliseconds} ms");
        }
    }
}