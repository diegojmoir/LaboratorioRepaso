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
        public Form1()
        {
            this.addbtn.BackgroundImage = LabRepaso_Diego_Pérez_1114016.Properties.Resources.AddIcon;
            InitializeComponent();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            Dictionary<string, Song > lista = new Dictionary<string, Song>(); 
            
        }
    }
}
