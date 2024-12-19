using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meowCat
{
    public interface ICalculatable
    {
        double ToDouble();
        void SetNumerator(int numerator);
        void SetDenominator(int denominator);

    }
}
