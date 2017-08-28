namespace LabRepaso_Diego_Pérez_1114016
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.AddSonglb = new System.Windows.Forms.Label();
            this.MediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.lstSongs = new System.Windows.Forms.ListBox();
            this.cmbPlaylists = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pbxUp = new System.Windows.Forms.PictureBox();
            this.pbxSearch = new System.Windows.Forms.PictureBox();
            this.addSongbtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.pbxDown = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(409, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Crear Playlist";
            // 
            // AddSonglb
            // 
            this.AddSonglb.AutoSize = true;
            this.AddSonglb.Location = new System.Drawing.Point(313, 64);
            this.AddSonglb.Name = "AddSonglb";
            this.AddSonglb.Size = new System.Drawing.Size(86, 13);
            this.AddSonglb.TabIndex = 3;
            this.AddSonglb.Text = "Agregar Canción";
            // 
            // MediaPlayer
            // 
            this.MediaPlayer.Enabled = true;
            this.MediaPlayer.Location = new System.Drawing.Point(12, 12);
            this.MediaPlayer.Name = "MediaPlayer";
            this.MediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MediaPlayer.OcxState")));
            this.MediaPlayer.Size = new System.Drawing.Size(279, 65);
            this.MediaPlayer.TabIndex = 4;
            // 
            // lstSongs
            // 
            this.lstSongs.Enabled = false;
            this.lstSongs.FormattingEnabled = true;
            this.lstSongs.Location = new System.Drawing.Point(12, 101);
            this.lstSongs.Name = "lstSongs";
            this.lstSongs.Size = new System.Drawing.Size(163, 121);
            this.lstSongs.TabIndex = 5;
            this.lstSongs.SelectedIndexChanged += new System.EventHandler(this.lstSongs_SelectedIndexChanged);
            // 
            // cmbPlaylists
            // 
            this.cmbPlaylists.FormattingEnabled = true;
            this.cmbPlaylists.Location = new System.Drawing.Point(181, 101);
            this.cmbPlaylists.Name = "cmbPlaylists";
            this.cmbPlaylists.Size = new System.Drawing.Size(121, 21);
            this.cmbPlaylists.TabIndex = 6;
            this.cmbPlaylists.SelectedIndexChanged += new System.EventHandler(this.cmbPlaylists_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Seleccione una canción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Seleccione una playlist";
            // 
            // pbxUp
            // 
            this.pbxUp.Image = global::LabRepaso_Diego_Pérez_1114016.Properties.Resources.Down;
            this.pbxUp.Location = new System.Drawing.Point(412, 101);
            this.pbxUp.Name = "pbxUp";
            this.pbxUp.Size = new System.Drawing.Size(48, 52);
            this.pbxUp.TabIndex = 10;
            this.pbxUp.TabStop = false;
            this.pbxUp.Click += new System.EventHandler(this.pbxUp_Click);
            // 
            // pbxSearch
            // 
            this.pbxSearch.Image = global::LabRepaso_Diego_Pérez_1114016.Properties.Resources.SearchIcon;
            this.pbxSearch.Location = new System.Drawing.Point(314, 185);
            this.pbxSearch.Name = "pbxSearch";
            this.pbxSearch.Size = new System.Drawing.Size(51, 52);
            this.pbxSearch.TabIndex = 9;
            this.pbxSearch.TabStop = false;
            // 
            // addSongbtn
            // 
            this.addSongbtn.BackgroundImage = global::LabRepaso_Diego_Pérez_1114016.Properties.Resources.AddSong1;
            this.addSongbtn.Location = new System.Drawing.Point(316, 12);
            this.addSongbtn.Name = "addSongbtn";
            this.addSongbtn.Size = new System.Drawing.Size(49, 49);
            this.addSongbtn.TabIndex = 2;
            this.addSongbtn.UseVisualStyleBackColor = true;
            this.addSongbtn.Click += new System.EventHandler(this.addSongbtn_Click);
            // 
            // addbtn
            // 
            this.addbtn.BackgroundImage = global::LabRepaso_Diego_Pérez_1114016.Properties.Resources.AddIcon;
            this.addbtn.Location = new System.Drawing.Point(412, 12);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(50, 49);
            this.addbtn.TabIndex = 0;
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // pbxDown
            // 
            this.pbxDown.Image = global::LabRepaso_Diego_Pérez_1114016.Properties.Resources.Up;
            this.pbxDown.Location = new System.Drawing.Point(316, 103);
            this.pbxDown.Name = "pbxDown";
            this.pbxDown.Size = new System.Drawing.Size(50, 50);
            this.pbxDown.TabIndex = 11;
            this.pbxDown.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(311, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Buscar canción ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(311, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 26);
            this.label5.TabIndex = 13;
            this.label5.Text = "Ordenar \r\nDescendentemente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(409, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 26);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ordenar \r\nAscendentemente";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 266);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pbxDown);
            this.Controls.Add(this.pbxUp);
            this.Controls.Add(this.pbxSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbPlaylists);
            this.Controls.Add(this.lstSongs);
            this.Controls.Add(this.MediaPlayer);
            this.Controls.Add(this.AddSonglb);
            this.Controls.Add(this.addSongbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addbtn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addSongbtn;
        private System.Windows.Forms.Label AddSonglb;
        private AxWMPLib.AxWindowsMediaPlayer MediaPlayer;
        private System.Windows.Forms.ListBox lstSongs;
        private System.Windows.Forms.ComboBox cmbPlaylists;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbxSearch;
        private System.Windows.Forms.PictureBox pbxUp;
        private System.Windows.Forms.PictureBox pbxDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

