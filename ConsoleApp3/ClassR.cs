using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignemntOneGSG
{
    internal class ClassR : IObserver {
        public void handle(string msg) { 
            Console.WriteLine("Class R Msg :"+msg);
        }
    }
}
