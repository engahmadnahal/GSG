using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignemntOneGSG
{
    internal class Observer
    {

        List<IObserver> items = new List<IObserver>();

        public void addLastner(IObserver item) { 
            items.Add(item);
        }

        public void handle(string msg) {
            foreach (IObserver item in items) {
                item.handle(msg);
            }
        }
    }
}
