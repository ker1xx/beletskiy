using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beletskiy
{
    internal interface ICrud
    {
        public void create();
        public void read();
        public void update();
        public void delete();
    }
}
