using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    public class Irrational
    {
        public int Numerator { get; private set; }
        public int Denominator { get; private set; }
        public string ToString()
        {
            string Str = Numerator.ToString();
            if (Denominator != 1)
                Str += "/" + Denominator.ToString();
            return Str;
        }

        static public void ReduceFraction(ref Irrational num)
        {
            int a, b;
            a = Math.Abs(num.Numerator);
            b = Math.Abs(num.Denominator);
            while (a > 0 && b > 0)
                if (a < b)
                    b %= a;
                else
                    a %= b;
            a += b;
            num.Numerator /= a;
            num.Denominator /= a;
            if ((num.Denominator < 0 && num.Numerator < 0) || (num.Denominator < 0 && num.Numerator > 0))
            {
                num.Denominator = -num.Denominator;
                num.Numerator = -num.Numerator;
            }
        }
        static public Irrational operator + (Irrational num1, Irrational num2)
        {
            num1.Numerator *= num2.Denominator;
            num2.Numerator *= num1.Denominator;
            num1.Denominator *= num2.Denominator;
            num1.Numerator += num2.Numerator;
            ReduceFraction(ref num1);
            return num1;
        } 
        static public Irrational operator -(Irrational num1, Irrational num2)
        {
            num1.Numerator *= num2.Denominator;
            num2.Numerator *= num1.Denominator;
            num1.Denominator *= num2.Denominator;
            num1.Numerator -= num2.Numerator;
            ReduceFraction(ref num1);
            return num1;
        }
        static public Irrational operator -(Irrational num1)
        {
            num1.Numerator = -num1.Numerator;
            return num1;
        }
        static public Irrational operator *(Irrational num1, Irrational num2)
        {
            num1.Numerator *= num2.Numerator;
            num1.Denominator *= num2.Denominator;
            ReduceFraction(ref num1);
            return num1;
        } 
        static public Irrational operator /(Irrational num1, Irrational num2)
        {
            num1.Numerator *= num2.Denominator;
            num1.Denominator *= num2.Numerator;
            ReduceFraction(ref num1);
            return num1;
        } 

        static public Boolean operator > (Irrational num1, Irrational num2)
        {
            num1.Numerator *= num2.Denominator;
            num2.Numerator *= num1.Denominator;
            if (num1.Numerator > num2.Numerator)
                return true;
            return false;
        }
        static public Boolean operator < (Irrational num1, Irrational num2)
        {
            num1.Numerator *= num2.Denominator;
            num2.Numerator *= num1.Denominator;
            if (num1.Numerator < num2.Numerator)
                return true;
            return false;
        }
        static public Boolean operator >= (Irrational num1, Irrational num2)
        {
            num1.Numerator *= num2.Denominator;
            num2.Numerator *= num1.Denominator;
            if (num1.Numerator >= num2.Numerator)
                return true;
            return false;
        }
        static public Boolean operator <= (Irrational num1, Irrational num2)
        {
            num1.Numerator *= num2.Denominator;
            num2.Numerator *= num1.Denominator;
            if (num1.Numerator <= num2.Numerator)
                return true;
            return false;
        }
        static public Boolean operator == (Irrational num1, Irrational num2)
        {
            if (num2.Denominator == num1.Denominator && num2.Numerator == num1.Numerator)
                return true;
            return false;
        }
        static public Boolean operator != (Irrational num1, Irrational num2)
        {
            if (num2.Denominator != num1.Denominator || num2.Numerator != num1.Numerator)
                return true;
            return false;
        }
         
        public Irrational(int Numerator, int Denomirator)
        {
            if(Denomirator == 0)
                throw new ArgumentException("Знаменатель не может быть равен 0", nameof(Denominator));

            int a, b;
            a = Math.Abs(Numerator);
            b = Math.Abs(Denomirator);
            while (a > 0 && b > 0)
                if (a < b)
                    b %= a;
                else
                    a %= b;
            a += b;
            this.Numerator = Numerator / a;
            this.Denominator = Denomirator / a;

            if ((this.Denominator < 0 &&  this.Numerator < 0) || (this.Denominator < 0 && this.Numerator > 0))
            {
                this.Denominator = -this.Denominator;
                this.Numerator = -this.Numerator;
            }
        }
        
    }
}
