using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nkandla
{
    public class Nkandla: HomeStead
    {
        public SwimmingPool SwimmingPool { get; set; }
        public ChickenRun ChickenRun { get; set; }
        public Amphitheatre Amphitheatre { get; set; }

        public Nkandla()
        {
            SwimmingPool = new SwimmingPool();
            ChickenRun = new ChickenRun();
            Amphitheatre = new Amphitheatre();
        }

        public override void Accept(IVisitor visitor)
        {
            if (!visitor.getParty().Equals(Party.ANC))
                throw new UnwelcomeVisitorException();

            visitor.visit(this);
        }
    }
}
