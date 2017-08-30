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
        List<Song> aux = new List<Song>();
        
        public Form1()
        {            
            InitializeComponent();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            Playlist list = new Playlist();
            Data listName = new Data(list);
            listName.ShowDialog();
            if(list._playlistName != null)
            {
                Music.Add(list);
            }           
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
            for(int i = 0; i < Music[cmbPlaylists.SelectedIndex]._songs.Count; i++)
            {
                lstSongs.Items.Add(Music[cmbPlaylists.SelectedIndex]._songs[i]._name + " Tiempo: " + 
                   Music[cmbPlaylists.SelectedIndex]._songs[i]._time); 
            }

            MediaPlayer.URL = Music[cmbPlaylists.SelectedIndex]._songs[0]._path;
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
            MediaPlayer.URL = Music[cmbPlaylists.SelectedIndex]._songs[lstSongs.SelectedIndex]._path;             
        }

        private void cmbPlaylists_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstSongs.Items.Clear();
            loadSongs();
        }

        private void pbxUp_Click(object sender, EventArgs e)
        {
            if (Music.Count == 0 || cmbPlaylists.SelectedIndex < 0)
            {
                MessageBox.Show("No hay ninguna playlist, porfavor cree una");

            }
            else
            {
                if(rbtnSortName.Checked == false && rbtnSortTime.Checked == false)
                {
                    MessageBox.Show("Seleccione el parametro por el cual desea ordenar"); 
                }
                else if(rbtnSortName.Checked == true)
                {
                    lstSongs.Items.Clear();
                    IEnumerable<Song> sortedSongs =
                    from song in Music[cmbPlaylists.SelectedIndex]._songs
                    orderby song._name ascending
                    select song;

                    foreach (Song song in sortedSongs)
                    {
                        lstSongs.Items.Add(song._name + " Tiempo: " + song._time);
                    }
                    Music[cmbPlaylists.SelectedIndex]._songs = sortedSongs.ToList();
                }
                else if(rbtnSortTime.Checked == true)
                {
                    lstSongs.Items.Clear();
                    IEnumerable<Song> sortedSongs =
                    from song in Music[cmbPlaylists.SelectedIndex]._songs
                    orderby song._time ascending
                    select song;

                    foreach (Song song in sortedSongs)
                    {
                        lstSongs.Items.Add( "Tiempo:" + song._time + " Nombre: " + song._name);
                    }
                    Music[cmbPlaylists.SelectedIndex]._songs = sortedSongs.ToList(); 
                }
               
            }
        }

        private void pbxDown_Click(object sender, EventArgs e)
        {

            if (Music.Count == 0 || cmbPlaylists.SelectedIndex < 0)
            {
                MessageBox.Show("No hay existe ninguna playlist, porfavor cree una");
            }
            else
            {
                if (rbtnSortName.Checked == false && rbtnSortTime.Checked == false)
                {
                    MessageBox.Show("Seleccione el parametro por el cual desea ordenar");
                }
                else if (rbtnSortName.Checked == true)
                {
                    lstSongs.Items.Clear();
                    IEnumerable<Song> sortedSongs =
                    from song in Music[cmbPlaylists.SelectedIndex]._songs
                    orderby song._name descending
                    select song;

                    foreach (Song song in sortedSongs)
                    {
                        lstSongs.Items.Add(song._name + " Tiempo: " + song._time);
                    }
                    Music[cmbPlaylists.SelectedIndex]._songs = sortedSongs.ToList();
                }
                else if (rbtnSortTime.Checked == true)
                {
                    lstSongs.Items.Clear();
                    IEnumerable<Song> sortedSongs =
                    from song in Music[cmbPlaylists.SelectedIndex]._songs
                    orderby song._time descending
                    select song;

                    foreach (Song song in sortedSongs)
                    {
                        lstSongs.Items.Add("Tiempo:" + song._time + " Nombre: " + song._name);
                    }
                    Music[cmbPlaylists.SelectedIndex]._songs = sortedSongs.ToList(); 
                }

            }
        }

        private void pbxSearch_Click(object sender, EventArgs e)
        {
            bool find = false; 
            if(txtboxSearch.Text == null)
            {
                MessageBox.Show("Ingrese el nombre de la canción");
            }
            else
            {
                foreach(Playlist playlist in Music)
                {
                    foreach(Song song in playlist._songs)
                    {
                        if (txtboxSearch.Text.ToUpper().Trim() == song._name.ToUpper().Trim())
                        {
                            lstSongs.Items.Clear();
                            lstSongs.Items.Add(song._name + " Tiempo: " + song._time);
                            MediaPlayer.URL = song._path;
                            find = true; 
                        }
                    }
                }
                if(find == false)
                {
                    MessageBox.Show("Canción no encontrada en ninguna playlist"); 
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (lstSongs.SelectedIndex < Music[cmbPlaylists.SelectedIndex]._songs.Count -1 && lstSongs.Items.Count > 1)
            {
                lstSongs.SelectedIndex++;
                timer1.Enabled = false;
            }
            else
            {
                timer1.Enabled = false;
            }
        }

        private void MediaPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (MediaPlayer.playState == WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                timer1.Interval = 100;
                timer1.Enabled = true;
            }
        }
    }
}
