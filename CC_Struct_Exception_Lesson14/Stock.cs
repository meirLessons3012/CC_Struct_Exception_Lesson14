using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC_Struct_Exception_Lesson14
{
    internal static class Stock
    {
        public static int Pitot { get; set; }
        public static int Lafot { get; set; }
        public static int Falafel { get; set; }

        static Stock()
        {
            Pitot = 3;
            Lafot = 2;
            Falafel = 10;
        }
    }
}
