﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabRepaso_Diego_Pérez_1114016
{
    public class Song
    {
        private List<string> Name;
        private List<string> Path;
        private string[] Time;
        public List<string> _name
        {
            get { return Name; }
            set { Name = value; }
        }

        public List<string> _path
        {
            get { return Path; }
            set { Path = value; }
        }

        public string[] _time
        {
            get { return Time; }
            set { Time = value; }
        }
    }
}
