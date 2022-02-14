using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC_Struct_Exception_Lesson14
{
    internal class ComparisionTypes
    {
        public int MyProp { get; set; }
        public ComparisionTypes()
        {
            CompareWithEqualOperator();
            CompareWithReferenceEqualsMethod();
            CompareWithStaticEquals();
            CompareWithVirtualEquals();
        }

        public void CompareWithVirtualEquals()
        {
            //reference type
            MyClass mc1 = new MyClass() { Age = 5 };
            MyClass mc2 = new MyClass() { Age = 5 };
            MyClass mc3 = mc1;
            Console.WriteLine(mc1.Equals(mc2));//Output: false (reference comparison)
            Console.WriteLine(mc1.Equals(mc3));//Output: true (reference comparison)

            //value type
            int i1 = 3;
            int i2 = 3;
            int i3 = i1;
            Console.WriteLine(i1.Equals(i2));//Output: true (values comparison)
            Console.WriteLine(i1.Equals(i3));//Output: true (values comparison)

            //complex type
            string s1 = "test";
            string s2 = "test";
            string s3 = s1;
            Console.WriteLine(s1.Equals(s2));//Output: true (values comparison)
            Console.WriteLine(s1.Equals(s3));//Output: true (values comparison)
        }

        public void CompareWithStaticEquals()
        {
            //reference type
            MyClass mc1 = new MyClass() { Age = 5 };
            MyClass mc2 = new MyClass() { Age = 5 };
            MyClass mc3 = mc1;
            MyClass mc4 = null;
            Console.WriteLine(object.Equals(mc1, mc2));//Output: false (reference comparsion)
            Console.WriteLine(object.Equals(mc1, mc3));//Output: true (reference comparsion)
            Console.WriteLine(object.Equals(mc2, mc4));//Output: false (mc4 is null)
            //value type
            int i1 = 3;
            int i2 = 3;
            int i3 = i1;
            Console.WriteLine(object.Equals(i1, i2));//Output: true (values comparsion)
            Console.WriteLine(object.Equals(i1, i3));//Output: true (values comparsion)
            //complex type
            string s1 = "test";
            string s2 = "test";
            string s3 = s1;
            Console.WriteLine(object.Equals(s1, s2));//Output: true (values comparsion)
            Console.WriteLine(object.Equals(s1, s3));//Output: true (values comparsion)      

        }

        public void CompareWithReferenceEqualsMethod()
        {
            //reference type
            MyClass mc1 = new MyClass() { Age = 5 };
            MyClass mc2 = new MyClass() { Age = 5 };
            MyClass mc3 = mc1;
            Console.WriteLine(object.ReferenceEquals(mc1, mc2));//Output: false (reference comparison)
            Console.WriteLine(object.ReferenceEquals(mc1, mc3));//Output: true (reference comparison)
            //value type
            int i1 = 3;
            int i2 = 3;
            int i3 = i1;
            Console.WriteLine(object.ReferenceEquals(i1, i2));//Output: false (boxing and then compare by references)
            Console.WriteLine(object.ReferenceEquals(i1, i3));//Output: false (boxing and then compare by references)
            //complex type
            string s1 = "test";
            string s2 = "test";
            string s3 = s1;
            Console.WriteLine(object.ReferenceEquals(s1, s2));//Output: true (reference comparison but used the pool)
            Console.WriteLine(object.ReferenceEquals(s1, s3));//Output: true (reference comparison but used the pool)
        }

        public void CompareWithEqualOperator()
        {

            //reference type
            MyClass mc1 = new MyClass() { Age = 5 };
            MyClass mc2 = new MyClass() { Age = 5 };
            MyClass mc3 = mc1;
            Console.WriteLine(mc1 == mc2);//Output: false (reference comparison)
            Console.WriteLine(mc1 == mc3);//Output: true (reference comparison)
            //value type
            int i1 = 3;
            int i2 = 3;
            int i3 = i1;
            Console.WriteLine(i1 == i2);//Output: true (fields values comparison)
            Console.WriteLine(i1 == i3);//Output: true (fields values comparison)
            //complex type
            string s1 = "test";
            string s2 = "test";
            string s3 = s1;
            Console.WriteLine(s1 == s2);//Output: true (fields values comparison)
            Console.WriteLine(s1 == s3);//Output: true (fields values comparison)
        }

        public override bool Equals(object? obj)
        {

            return this.GetType() == obj.GetType();
        }
    }
}
