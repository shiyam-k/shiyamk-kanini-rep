using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern10723
{
    class Hokage
    {
        public string Name { get; set; }
        public int YearsInTraining { get; set; }
        public int RelationshipsBuilt { get; set; }
        public bool DemonstratedLeadership { get; set; }
        public bool OvercameObstacles { get; set; }

        public void DisplayHokageDetails()
        {
            Console.WriteLine($"Congratulations! {Name} is now the Hokage!");
            Console.WriteLine("Lead the village with wisdom and strength!");
        }
    }
}
