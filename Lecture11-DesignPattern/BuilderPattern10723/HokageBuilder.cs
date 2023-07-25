using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern10723
{
    class HokageBuilder : IHokageBuilder
    {
        private Hokage hokage;

        public HokageBuilder()
        {
            hokage = new Hokage();
        }

        public void SetName(string name)
        {
            hokage.Name = name;
        }

        public void Train(int years)
        {
            hokage.YearsInTraining += years;
        }

        public void BuildRelationships(int count)
        {
            hokage.RelationshipsBuilt += count;
        }

        public void DemonstrateLeadership()
        {
            hokage.DemonstratedLeadership = true;
        }

        public void OvercomeObstacles()
        {
            hokage.OvercameObstacles = true;
        }

        public Hokage GetHokage()
        {
            return hokage;
        }
        public int GetTraining()
        {
            return hokage.YearsInTraining;
        }
        public int GetRelationShipCount()
        {
            return hokage.RelationshipsBuilt;
        }
    }
}
