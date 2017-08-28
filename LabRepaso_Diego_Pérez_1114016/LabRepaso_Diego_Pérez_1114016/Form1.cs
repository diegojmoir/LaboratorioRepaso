using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabRepaso_Diego_Pérez_1114016
{
    public partial class Form1 : Form
    {
        List<Playlist> Music = new List<Playlist>();
        public Form1()
        {            
            InitializeComponent();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            Playlist list = new Playlist();
            Data listName = new Data(list);
            listName.ShowDialog();
            Music.Add(list);
        }

        private void loadPlaylist()
        {
            for (int i = 0; i < Music.Count; i++)
            {
                cmbPlaylists.Items.Add(Music[i]._playlistName); 
            }
            lstSongs.Enabled = true; 
        }

        private void loadSongs()
        {
            for(int i = 0; i < Music[cmbPlaylists.SelectedIndex]._name.Count; i++)
            {
                lstSongs.Items.Add(Music[cmbPlaylists.SelectedIndex]._name[i]); 
            }

            MediaPlayer.URL = Music[cmbPlaylists.SelectedIndex]._path[0];
            lstSongs.SelectedIndex = 0; 
        }
        private void addSongbtn_Click(object sender, EventArgs e)
        {
            if(Music.Count == 0)
            {
                MessageBox.Show("No existe ninguna lista, porfavor cree una"); 
            }
            else
            {
                Agregar_Canción addSong = new Agregar_Canción(MediaPlayer, Music);
                addSong.Show();
                cmbPlaylists.Items.Clear();
                loadPlaylist();
            }
        }

        private void lstSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            MediaPlayer.URL = Music[cmbPlaylists.SelectedIndex]._path[lstSongs.SelectedIndex];                   
        }

        private void cmbPlaylists_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstSongs.Items.Clear();
            loadSongs();
        }

        private void pbxUp_Click(object sender, EventArgs e)
        {
            if(Music.Count == 0 && cmbPlaylists.SelectedIndex < 0)
            {
                MessageBox.Show("No hay existe ninguna playlist, porfavor cree una"); 
            }
            else
            {
                
            }
        }
    }
}
