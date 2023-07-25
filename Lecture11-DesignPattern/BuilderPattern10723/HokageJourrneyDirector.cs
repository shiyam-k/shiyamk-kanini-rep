using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SupportClassLibrary;


namespace BuilderPattern10723
{
    class HokageJourneyDirector
    {
        private IHokageBuilder builder;

        public HokageJourneyDirector(IHokageBuilder builder)
        {
            this.builder = builder;
        }

        public void JourneyToBecomeHokage()
        {
            var v = new SupportClassLibrary.Class1();
            builder.SetName(v.GetStringInput("Enter Shinobi Name:"));
            bool flag = true;
            do
            {
                string str = "";
                Console.WriteLine("");
                Console.WriteLine("Press one to train");
                Console.WriteLine("Press two to Build relationship");
                Console.WriteLine("press three to Demonstrate Leadership");
                Console.WriteLine("press four to Overcome Obstacles");
                str = builder.GetTraining() >= 3 && builder.GetRelationShipCount() >= 3 ? "Become Hokage" : "";
                Console.WriteLine(str);
                Console.WriteLine("");
                switch (v.GetNumberInput("Enter Option"))
                {
                    case 1: builder.Train(1);break;
                    case 2: builder.BuildRelationships(1);break;
                    case 3: builder.DemonstrateLeadership(); break;
                    case 4: builder.OvercomeObstacles(); break;
                    case 5: builder.GetHokage(); flag = false; break;
                }
            }
            while (flag);
            
        }
    }
}