using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern10723
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IHokageBuilder builder = new HokageBuilder();
            HokageJourneyDirector director = new HokageJourneyDirector(builder);

            director.JourneyToBecomeHokage();
            Hokage hokage = builder.GetHokage();
            hokage.DisplayHokageDetails();

        }
    }
}
