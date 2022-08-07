using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundTheCode.CSharp11.Features
{
    public class RequiredMember
    {
        [SetsRequiredMembers]
        public RequiredMember(string name)
        {
            Name = name;
        }

        public required string Name { get; set; }
    }
}
