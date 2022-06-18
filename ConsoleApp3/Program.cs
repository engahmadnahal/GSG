using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignemntOneGSG
{
    internal class Program
    {

        /* 
                @ Ahmad Al Nahal
                This project , using observer pattern
         
         */
        static void Main(string[] args)
        {

            Observer obs = new Observer();
            ClassA a = new ClassA();
            ClassB b = new ClassB();
            ClassR r = new ClassR();

            obs.addLastner(a);
            obs.addLastner(b);
            obs.addLastner(r);

            obs.handle("This Message Say , Hi Observer !");

            Console.ReadLine();

        }
    }
}
