using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Eternal_Queue
{
    public class CashRegister
    {
        public int Number, Queue, Served, ServeTime;
        public object Locker;

        public CashRegister(int Number, int ServeTime)
        {
            this.Number = Number;
            this.ServeTime = ServeTime * 1000;
            Locker = new object();
        }
    }
}
