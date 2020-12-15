using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    //Esta clase representa a un nadador
    public class Swimmer
    {
        private string data;

        public Swimmer(string data)
        {
            this.Data = data;
        }

        public string Data { get => data; set => data = value; }
    }
}
