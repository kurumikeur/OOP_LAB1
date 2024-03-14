using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    abstract class TimeDate
    { 
        public abstract void GetTime();
    }

    class EU_Date : TimeDate
    {
        public override void GetTime()
        {
            DateTime a = DateTime.Now;

        }
    }
    class US_Date : TimeDate
    {
        public override void GetTime()
        {
            DateTime a = DateTime.Now;
            Console.WriteLine(a.ToString("hh:mm:tt:"));
        }
    }
}
