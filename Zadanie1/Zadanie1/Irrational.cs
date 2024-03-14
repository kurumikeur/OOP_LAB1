using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    class Irrational
    {
        public int Numerator { get; private set; }
        public int Denomirator { get; private set; }
        public string ToString()
        {
            string Str = Numerator.ToString();
            if (Denomirator != 1)
                Str += "/" + Denomirator.ToString();
            return Str;
        }

        static public void ReduceFraction(ref Irrational num)
        {
            int a, b;
            a = Math.Abs(num.Numerator);
            b = Math.Abs(num.Denomirator);
            while (a > 0 && b > 0)
                if (a < b)
                    b %= a;
                else
                    a %= b;
            a += b;
            num.Numerator /= a;
            num.Denomirator /= a;
            if ((num.Denomirator < 0 && num.Numerator < 0) || (num.Denomirator < 0 && num.Numerator > 0))
            {
                num.Denomirator = -num.Denomirator;
                num.Numerator = -num.Numerator;
            }
        }
        static public Irrational operator + (Irrational num1, Irrational num2)
        {
            num1.Numerator *= num2.Denomirator;
            num2.Numerator *= num1.Denomirator;
            num1.Denomirator *= num2.Denomirator;
            num1.Numerator += num2.Numerator;
            ReduceFraction(ref num1);
            return num1;
        } 
        static public Irrational operator -(Irrational num1, Irrational num2)
        {
            num1.Numerator *= num2.Denomirator;
            num2.Numerator *= num1.Denomirator;
            num1.Denomirator *= num2.Denomirator;
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
            num1.Denomirator *= num2.Denomirator;
            ReduceFraction(ref num1);
            return num1;
        } 
        static public Irrational operator /(Irrational num1, Irrational num2)
        {
            num1.Numerator *= num2.Denomirator;
            num1.Denomirator *= num2.Numerator;
            ReduceFraction(ref num1);
            return num1;
        } 

        static public Boolean operator > (Irrational num1, Irrational num2)
        {
            num1.Numerator *= num2.Denomirator;
            num2.Numerator *= num1.Denomirator;
            if (num1.Numerator > num2.Numerator)
                return true;
            return false;
        }
        static public Boolean operator < (Irrational num1, Irrational num2)
        {
            num1.Numerator *= num2.Denomirator;
            num2.Numerator *= num1.Denomirator;
            if (num1.Numerator < num2.Numerator)
                return true;
            return false;
        }
        static public Boolean operator >= (Irrational num1, Irrational num2)
        {
            num1.Numerator *= num2.Denomirator;
            num2.Numerator *= num1.Denomirator;
            if (num1.Numerator >= num2.Numerator)
                return true;
            return false;
        }
        static public Boolean operator <= (Irrational num1, Irrational num2)
        {
            num1.Numerator *= num2.Denomirator;
            num2.Numerator *= num1.Denomirator;
            if (num1.Numerator <= num2.Numerator)
                return true;
            return false;
        }
        static public Boolean operator == (Irrational num1, Irrational num2)
        {
            if (num2.Denomirator == num1.Denomirator && num2.Numerator == num1.Numerator)
                return true;
            return false;
        }
        static public Boolean operator != (Irrational num1, Irrational num2)
        {
            if (num2.Denomirator != num1.Denomirator || num2.Numerator != num1.Numerator)
                return true;
            return false;
        }
         
        public Irrational(int Numerator, int Denomirator)
        {
            if(Denomirator == 0)
                throw new Exception("Знаменатель не может быть равен 0");

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
            this.Denomirator = Denomirator / a;

            if ((this.Denomirator < 0 &&  this.Numerator < 0) || (this.Denomirator < 0 && this.Numerator > 0))
            {
                this.Denomirator = -this.Denomirator;
                this.Numerator = -this.Numerator;
            }
        }
        
    }
}
