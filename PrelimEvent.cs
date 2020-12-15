using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class PrelimEvent:Event
    {
        public PrelimEvent(string filename, int lanes) : base(filename, lanes)
        { }
        //Retorna una instancia de la clase CircleSeeding, recibe un array y un numero de carriles
        public override Seeding getSeeding()
        {
            return new CircleSeeding(swimmers, numLanes);
        }
        public override bool isPrelim()
        {
            return true;
        }
        public override bool isFinal()
        {
            return false;
        }
        public override bool isTimedFinal()
        {
            return false;
        }

    }
}
