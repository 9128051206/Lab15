using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15
{
    class Program
    {
        static void Main(string[] args)
        {
            ArithProgression arithProgression = new ArithProgression();
            arithProgression.setStart(15);
            arithProgression.setStep(3);
            Console.WriteLine(arithProgression.getNext());
            Console.WriteLine(arithProgression.getNext());
            Console.WriteLine(arithProgression.getNext());
            Console.WriteLine(arithProgression.getNext());
            arithProgression.reset();
            Console.WriteLine(arithProgression.getNext());
            Console.WriteLine(arithProgression.getNext());
            GeomProgression geomProgression = new GeomProgression();
            geomProgression.setStart(15);
            geomProgression.setStep(3);
            Console.WriteLine(geomProgression.getNext());
            Console.WriteLine(geomProgression.getNext());
            Console.WriteLine(geomProgression.getNext());
            geomProgression.reset();
            Console.WriteLine(geomProgression.getNext());
            Console.ReadKey();
        }
    }
}
