using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Irrational
    {
        public int Numerator {
            get
            {
                return Numerator;
            }
            private set
            {
                Numerator = value;
            }
        }
        public int Denomirator { 
            get
            {
                if (Denomirator == 0) { throw; }
                return Denomirator;
            }
            private set { 
                Denomirator = value;
            } 
        }
        public string ToString()
        {
            string Str = Numerator.ToString() + "/" + Denomirator.ToString();
            return Str;
        }
        static public Irrational operator + (Irrational num1, Irrational num2)
        {
            num1.Numerator *= num2.Denomirator;
            num2.Numerator *= num1.Denomirator;
            num1.Numerator += num2.Numerator;
            num1.Denomirator += num2.Denomirator;
            return num1;
        } // Fraction
        static public Irrational operator -(Irrational num1, Irrational num2)
        {
            num1.Numerator *= num2.Denomirator;
            num2.Numerator *= num1.Denomirator;
            num1.Numerator -= num2.Numerator;
            num1.Denomirator -= num2.Denomirator;
            return num1;
        } // Fraction
        static public Irrational operator *(Irrational num1, Irrational num2)
        {
            num1.Numerator *= num2.Numerator;
            num1.Denomirator *= num2.Denomirator;
            return num1;
        } // Fraction
        static public Irrational operator /(Irrational num1, Irrational num2)
        {
            num1.Numerator *= num2.Denomirator;
            num1.Denomirator *= num2.Numerator;
            return num1;
        } // Fraction
        static public Boolean operator == (Irrational num1, Irrational num2)
        {
            if (num2.Denomirator == num1.Denomirator && num2.Numerator == num1.Numerator)
                return true;
            return false;
        }
        static public Boolean operator != (Irrational num1, Irrational num2)
        {
            if (num2.Denomirator != num1.Denomirator || num2.Numerator != num1.Numerator)
                return false;
            return true;
        }
         
        Irrational(int Numerator, int Denomirator)
        {
            this.Numerator = Numerator;
            this.Denomirator = Denomirator;

        }
        
    }
}
