using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenchmarkTutorial.Console
{
    public sealed class SealedClass
    {
        public int Handle(int num1, int num2)
        {
            return num1 + num2;
        }
    }

    public class NotSealedClass
    {
        public virtual int Handle(int num1,int num2)
        {

            return num1 + num2;
        }
    }
}
