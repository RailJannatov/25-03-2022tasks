using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullAbstract
{
    class LimitException:Exception
    {
        public LimitException(string msg):base(msg)
        {

        }
    }
}
