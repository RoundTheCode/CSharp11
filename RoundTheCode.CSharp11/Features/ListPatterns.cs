using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundTheCode.CSharp11.Features
{
    public class ListPatterns
    {
        public bool Is_1_3_5(int[] myNumbers)
        {
            return myNumbers is [1, 3, 5];
        }

        public bool Is_1___5(int[] myNumbers)
        {
            return myNumbers is [1, _, 5];
        }

        public bool Is_1_DotDot_5(int[] myNumbers)
        {
            return myNumbers is [1, .., 5];
        }

        public bool Is_1_Over_5(int[] myNumbers)
        {
            return myNumbers is [1, .., >=5];
        }
    }
}
