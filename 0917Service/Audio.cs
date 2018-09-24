using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment
{
    class Audio : FileType
    {
        private string audiolength;


        public Audio()
        {
            audiolength = "";
        }
        public string AudioLength
        {
            get { return audiolength; }
            set { audiolength = value; }
        }
    }
}
