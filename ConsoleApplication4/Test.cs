using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Test
    {
        private string test;
        public Test(string test)
        {
            this.test = test;
        }
        public override string ToString()
        {
            return "T " + test;
        }
    }
}
