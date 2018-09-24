using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment
{
    class Pictures : FileType
    {
        private int compression;

        public Pictures()
        {
            compression = 0;
            
        }
        public int Compression
        {
            get { return compression; }
            set { compression = value; }
        }
    }

}




