using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class TimedFinalEvent:Event
    {
        public TimedFinalEvent(string filename,int lanes) : base(filename, lanes) { }
        
        //Retorna una instancia de la clase StraightSeeding, recibe un array y un numero de carriles
        public override Seeding getSeeding()
        {
            return new StraightSeeding(swimmers, numLanes);
        }
        public override bool isPrelim()
        {
            return false;
        }
        public override bool isFinal()
        {
            return false;
        }
        public override bool isTimedFinal()
        {
            return true;
        }
    }
}
