using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabRepaso_Diego_Pérez_1114016
{
    public class Playlist
    {
        private string playlistName;
        private List<Song> Songs; 
        private List<string> Name;
        private List<string> Path;
        private string[] Time;
        
        public List<Song> _songs
        {
            get { return Songs; }
            set { Songs = value; }
        }
        public string _playlistName
        {
            get { return playlistName; }
            set { playlistName = value; }
        }

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
