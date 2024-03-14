using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{ 
    abstract class TimeDate
    { 
        public abstract string GetTime();
    }

    class EU_Date : TimeDate
    {
        protected CultureInfo time_reg = new CultureInfo("EU");
        public override string GetTime()
        {
            string time = DateTime.Now.ToString("hh:mm:ss dd:MM:yyyy");
            return time;
        }
    }
    class US_Date : TimeDate
    {
        protected CultureInfo time_reg = new CultureInfo("US");
        public override string GetTime()
        {
            string time = DateTime.Now.ToString("hh:mm:tt MM:dd:yyyy");
            return time;
        }
    }
    class TimeDateDecorator : TimeDate
    {
        public override string GetTime()
        {
            throw new NotImplementedException();
        }
    }
}
