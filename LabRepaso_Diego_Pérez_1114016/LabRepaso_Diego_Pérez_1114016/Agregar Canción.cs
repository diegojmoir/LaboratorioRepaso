using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;0
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

        private void checkNullPlaylist()
        {
            if (Music[selectedPlaylist]._name == null)
            {
                Music[selectedPlaylist]._name = new List<string>();
                Music[selectedPlaylist]._path = new List<string>();
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
            checkNullPlaylist(); 
            OpenFileDialog fileSearch = new OpenFileDialog();
            fileSearch.Multiselect = true;
            fileSearch.Filter = "Archivos MP3 (*.mp3)|*.mp3";
            if (fileSearch.ShowDialog() == DialogResult.OK)
            {
                for(int i = 0; i < fileSearch.FileNames.Length; i++)
                {
                    Music[selectedPlaylist]._name.Add(fileSearch.SafeFileNames[i]);
                    Music[selectedPlaylist]._path.Add(fileSearch.FileNames[i]);
                }
               
                //for(int i = 0; i < Music[selectedPlaylist]._path.Length; i++)
                //{
                //    mediaPlayer.URL = Music[selectedPlaylist]._path[i];
                    
                //    MessageBox.Show("hola"); 
                //}                                     
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
