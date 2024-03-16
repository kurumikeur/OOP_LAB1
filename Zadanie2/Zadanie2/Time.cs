using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2
{ 
    abstract class Date
    { 
        public abstract string GetTime();
    }

    class EU_Date : Date
    {
        protected CultureInfo time_reg = new CultureInfo("es-ES", false);
        public override string GetTime()
        {
            string time = DateTime.Now.ToString(time_reg);
            return time;
        }
    }
    class US_Date : Date
    {
        protected CultureInfo time_reg = new CultureInfo("en-US", false);
        public override string GetTime()
        {
            string time = DateTime.Now.ToString(time_reg);
            return time;
        }
    }
    class DateDecorator : Date
    {
        protected Date time;
        public DateDecorator(Date time)
        {
            this.time = time;
        }
        public override string GetTime ()
        {
            return time.GetTime();
        }
    }
    class US_DateDecorator : DateDecorator
    {
        public US_DateDecorator(Date date) : base(date) { }
        public override string GetTime()
        {
            StringBuilder output = new StringBuilder(time.GetTime());
            output.Append(" - American time");
            return output.ToString();
        }
    }

    class EU_DateDecorator : DateDecorator
    {
        public EU_DateDecorator(Date date) : base(date) { }
        public override string GetTime()
        {
            StringBuilder output = new StringBuilder(time.GetTime());
            output.Append(" - European time");
            return output.ToString();
        }
    }

}
