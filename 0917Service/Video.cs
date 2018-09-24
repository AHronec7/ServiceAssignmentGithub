using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment
{
    class Video : FileType
    {
        private double duration;
        private int resolution;

        public Video()
        {
            duration = 0;
            resolution = 0;
        }
        public double Duration
        {
            get { return duration; }
            set { Duration = value; }
        }

        public int Resolution
        {
            get { return resolution; }
            set { resolution = value; }
        }
    }
    
}
