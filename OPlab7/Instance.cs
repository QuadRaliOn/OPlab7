using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPlab7
{
    public class Instance
    {
        public float data;
        public Instance nextInstance;

        public Instance(float data)
        {
            this.data = data;
        }
    }
}
