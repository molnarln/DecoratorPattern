using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class MyCustomAttribute : Attribute
    {
        public string SomeProperty { get; set; }
    }
    [MyCustomAttribute(SomeProperty = "foo bar")]
    public class Foo
    {

    }

}
