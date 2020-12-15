using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class StraightSeeding : Seeding
    {
        private ArrayList swimmers;
        private int numLanes;

        //Esta clase recibe un array con objetos de tipo Swimmer y un número de carriles
        public StraightSeeding(ArrayList swimmers, int numLanes)
        {
            this.swimmers = swimmers;
            this.numLanes = numLanes;
        }

        public override int getCount()
        {
            return swimmers.Count;
        }

        public override int getHeats()
        {
            return numLanes;
        }

        public override ArrayList getSwimmers()
        {
            return swimmers;
        }
    }
}
