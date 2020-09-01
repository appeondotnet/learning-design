using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Component departA = new Department("A总公司");

            Component departAX = new Department("AX部门");

            Component departAY = new Department("AY部门");

            Component departAX1 = new Department("AX1子部门");

            Component departAX2 = new Department("AX2子部门");

            Component ae1 = new Employee("公司直属员工1");

            Component aXe1 = new Employee("AX部门员工1");

            Component aX1e1 = new Employee("AX1部门员工1");

            Component aX1e2 = new Employee("AX1部门员工2");

            Component aYe1 = new Employee("AY部门员工1");

            Component aYe2 = new Employee("AY部门员工2");

            departA.Add(ae1);

            departA.Add(departAX);

            departA.Add(departAY);

            departAX.Add(aXe1);

            departAX.Add(departAX1);

            departAX.Add(departAX2);

            departAX1.Add(aX1e1);

            departAX1.Add(aX1e2);

            departAY.Add(aYe1);

            departAY.Add(aYe2);

            //遍历总公司
            departA.Display(0);

            Console.ReadKey();
        }
    }
}
