using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meowCat
{
    public interface IMeowable
    {
        void Meow();
        void Meow(int n);
        int GetCount();
    }
}
