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
    }
}
