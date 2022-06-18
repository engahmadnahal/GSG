using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignemntOneGSG
{
    internal class ClassB : IObserver {

        public void handle(string msg) {
            Console.WriteLine("Class B Msg :"+msg);
        }
    }
}
