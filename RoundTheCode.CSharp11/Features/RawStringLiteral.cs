using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundTheCode.CSharp11.Features
{
    public class RawStringLiteral
    {
        public static int MyNumber = 1;

        public string MyJsonString =
            $$"""
                {
                    "number": "{{MyNumber}}"
                }
            """;            
    }
}
