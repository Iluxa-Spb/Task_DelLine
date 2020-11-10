using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_DelLine.EventsLib
{
    public class FilterChangeEventArgs: EventArgs
    {
        public string Param { get; internal set; }
        public DateTime DateStart { get; internal set; }
        public DateTime DateEnd { get; internal set; }
        public bool IsPct { get; internal set; }

        public FilterChangeEventArgs(string param, DateTime start, DateTime end, bool isPct)
        {
            this.Param = param;
            this.DateStart = start;
            this.DateEnd = end;
            this.IsPct = isPct;
        }

        public FilterChangeEventArgs()
        {
        }
    }
}
