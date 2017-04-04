using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nkandla
{
    public abstract class HomeStead
    {
        public String Name { get; set; }
        public String District { get; set; }
        public String Province { get; set; }
        public String Country { get; set; }

        public abstract void Accept(IVisitor visitor); 
    }
}
