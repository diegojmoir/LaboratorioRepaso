using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabRepaso_Diego_Pérez_1114016
{
    public class Song
    {
        private string Name;
        private string Path;
        private double Time;
        public string _name
        {
            get { return Name; }
            set { Name = value; }
        }

        public string _path
        {
            get { return Path; }
            set { Path = value; }
        }

        public double _time
        {
            get { return Time; }
            set { Time = value; }
        }
    }
}
