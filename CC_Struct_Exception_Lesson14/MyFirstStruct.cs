using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC_Struct_Exception_Lesson14
{
    internal struct MyFirstStruct : ICloneable
    {
        public string myType;
        public int MyProp { get; set; }

        public MyFirstStruct()
        {
            MyProp = 0;
            myType = null;
        }

        public MyFirstStruct(int myProp) : this()
        {
            //MyProp = myProp;
        }

        public MyFirstStruct(string myType, int myProp)
        {
            this.myType = myType;
            MyProp = myProp;
        }

        public string MyFirstMethod(int i)
        {
            return null;
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }
    }
}
