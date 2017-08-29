using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; 

namespace LabRepaso_Diego_Pérez_1114016
{
    public partial class Agregar_Canción : Form
    {
        private AxWMPLib.AxWindowsMediaPlayer mediaPlayer;
        private List<Playlist> Music;
        private int selectedPlaylist; 
        public Agregar_Canción(AxWMPLib.AxWindowsMediaPlayer _mediaPlayer, List<Playlist> _music)
        {
            InitializeComponent();           
            mediaPlayer = _mediaPlayer;
            Music = _music;
            showPlaylists();
        }
        private void checkNullList()
        {
            if(Music[selectedPlaylist]._songs == null)
            {
                Music[selectedPlaylist]._songs = new List<Song>(); 
            }
        }
        private void showPlaylists()
        {
            for(int i = 0; i < Music.Count; i++)
            {
                lstPlaylists.Items.Add(Music[i]._playlistName);
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            checkNullList(); 
            OpenFileDialog fileSearch = new OpenFileDialog();
            fileSearch.Multiselect = true;
            fileSearch.Filter = "Archivos MP3 (*.mp3)|*.mp3";
            if (fileSearch.ShowDialog() == DialogResult.OK)
            {
                for(int i = 0; i < fileSearch.FileNames.Length; i++)
                {
                    Song aux = new Song();
                    aux._name = fileSearch.SafeFileNames[i].Substring(0, fileSearch.SafeFileNames[i].Length - 4);
                    aux._path = fileSearch.FileNames[i];
                    TagLib.File time = TagLib.File.Create(fileSearch.FileNames[i]);
                    aux._time = Math.Round(time.Properties.Duration.TotalMinutes, 2); 
                   
                    Music[selectedPlaylist]._songs.Add(aux); 
                }
                                                 
            }
            this.Close(); 
        }

        private void lstPlaylists_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedPlaylist = lstPlaylists.SelectedIndex;
            btnSearch.Enabled = true; 
        }
    }
}
