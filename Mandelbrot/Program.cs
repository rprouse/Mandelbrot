using System;

namespace Mandelbrot
{
    class Program
    {
        const int MAXITER = 20;
        const string c = " .,'~!^:;[/<&?oxOX#  ";
        
        static void Main(string[] args)
        {
            for (int y = -39; y <= 39; y++)
            {
                for (int x = -39; x <= 39; x++)
                {
                    var creal = x / 20d;
                    var cimag = y / 20d;
                    var zreal = creal;
                    var zimag = cimag;
                    var count = 0;
                    while (count < MAXITER)
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
                    Console.Write(c[count]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("*** Press ENTER ***");
            Console.ReadLine();
        }
    }
}