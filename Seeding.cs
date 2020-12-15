using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    //Sirve de clase base para StraightSeeding y CircleSeeding
    public abstract class Seeding
    {
        public abstract ArrayList getSwimmers();
        public abstract int getCount();
        public abstract int getHeats();
        }
    }
