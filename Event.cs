using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class Event
    {
        //Esta es la clase base, se encarga de leer un archivo de texto y por cada linea crea un objeto de tipo Swimmer 
        protected int numLanes;
        protected ArrayList swimmers;
        public Event(string filename, int lanes)
        {
            numLanes = lanes;
            swimmers = new ArrayList();
            using (StreamReader sr = new StreamReader(filename))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Swimmer sw = new Swimmer(line);
                    swimmers.Add(sw);
                }
            }
        }
        public abstract Seeding getSeeding();
        public abstract bool isPrelim();
        public abstract bool isFinal();
        public abstract bool isTimedFinal();
    }
}
