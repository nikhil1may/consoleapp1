using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Class1
    {
        private string Product { get; set; }
        public string LibraryName { get; set; }

        public virtual void fun()
        {

        }
    }

    class Class2:Class1
    {
        public string LibraryNameChild { get; set; }
        public override  void fun()
        {
            Class1 class1 = new Class1();
            class1.LibraryName = "";
        }

    }
}
