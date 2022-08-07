using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundTheCode.CSharp11.Features
{
    public class Attr<T1> : Attribute { }

    public class GenericAttribute<T1>
    {
        [Attr<string>]
        public void MyClass()
        {

        }
    }
}
