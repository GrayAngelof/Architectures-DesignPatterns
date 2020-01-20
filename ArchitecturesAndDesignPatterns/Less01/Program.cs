using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less01
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store(new DefaultIdGenerator());
        }
    }
}
