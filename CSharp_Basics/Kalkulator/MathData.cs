using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    public class MathData
    {
        public int FirstValue;
        public int SecondValue;
        public string Operation;

        public MathData(int FirstValue, int SecondValue, string Operation)
        {
            this.FirstValue = FirstValue;
            this.SecondValue = SecondValue;
            this.Operation = Operation;
        }
    }
}
