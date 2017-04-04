using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nkandla
{
    public enum Party
    {
        ANC,
        DA,
        EFF,
        FFP
    }

    public class Politician: Person, IVisitor
    {
        public Party Party { get; set; }

        Party IVisitor.getParty()
        {
            return Party;
        }
        
        public void visit(HomeStead homestead)
        {
            Console.WriteLine("{0} is now visiting the {1} home stead", this.Name, homestead.Name);            
        }
    }
}
