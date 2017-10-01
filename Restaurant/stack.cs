using System;
namespace Restaurant
{
    public class stack : linkedList
    {
        public stack()
        {
            
        }

        public void push(string item)
        {
            Add(item);
        }

        public string pop()
        {
            string temp = getItem(getSize() - 1);
            deleteItem(getSize() - 1);
            return temp;
        }

    }

    public class stackTest
    {
        stack testList;

        public stackTest(stack list)
        {
            testList = list;
        }


        public void testAdd()
        {
            testList.push("a");
            testList.push("b");
            testList.push("c");
        }

        public void testDebug()
        {
            testList.debug_print();
        }

        public void testDelete()
        {
            testList.pop();
        }
    }
}
