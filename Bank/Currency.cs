using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logics
{

    public class Currency
    {
        float _in, _out;
        DateTime _date;

        public float In { get { return _in; } set { _in = value; } }
        public float Out { get { return _out; } set { _out = value; } }
        public DateTime Date { get { return _date; } set { _date = value; } }

    }
}
