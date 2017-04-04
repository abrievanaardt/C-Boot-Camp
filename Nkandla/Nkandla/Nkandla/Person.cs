using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nkandla
{
    public enum Type
    {
        Lawyer,
        Architect
    }

    public class Person
    {
        public String Name { get; set; }
        public String Age { get; set; }
        public String Gender { get; set; }
        public Type Type { get; set; }
    }
}
