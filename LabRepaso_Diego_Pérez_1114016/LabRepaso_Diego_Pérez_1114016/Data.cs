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
    public partial class Data : Form
    {
        private Playlist list;

        public Data(Playlist _list)
        {
            InitializeComponent();
            list = _list;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            list._playlistName = txtName.Text; 
            this.Close(); 
        }
    }
}
