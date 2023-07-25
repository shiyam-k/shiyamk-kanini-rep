using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern10723
{
    interface IHokageBuilder
    {
        void SetName(string name);
        void Train(int years);
        void BuildRelationships(int count);
        void DemonstrateLeadership();
        void OvercomeObstacles();
        Hokage GetHokage();
        int GetTraining();
        int GetRelationShipCount();
    }
}
