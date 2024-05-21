using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MusicProject
{
 
    public partial class Form3 : Form

    {

        Queue<string> q = new Queue<string>();
        private List<Song> Musics = new List<Song>();
        private Dictionary<string, Image> songImages = new Dictionary<string, Image>();
      
       

        public Form3()
        {
            InitializeComponent();
            LoadPredefinedSongs();
            InitializeSongImages();
        
           
            timer1.Start();
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
        }

        
      
      
        private void InitializeSongImages()
        {
         
            songImages["Adagio - Mohamad Shaxi"] = Properties.Resources.adagio;
            songImages["Every Breath You Take - The Police"] = Properties.Resources.police;
            songImages["I Still... - Backstreet Boys"] = Properties.Resources.bsb;
            songImages["Fishtail - Lana Del Rey"] = Properties.Resources.fishtail;
            songImages["Felina - Mohamad Shaxi"] = Properties.Resources.felina;
            songImages["Hours - Mohamad Shaxi"] = Properties.Resources.hours;
            songImages["haunt u - Lil Peep"] = Properties.Resources.haunt;
            songImages["My Love Mine All Mine - Mitski"] = Properties.Resources.mitski;
            songImages["tolerate it - Taylor Swift"] = Properties.Resources.taylor;
            songImages["Robbers - The 1975"] = Properties.Resources.t19;
            songImages["Alison - Slowdive"] = Properties.Resources.slowdive;
            songImages["Teenage Blue - Dreamgirl"] = Properties.Resources.girl;


        }
        private void LoadPredefinedSongs()
        {
         
            Musics.Add(new Song { Title = "Adagio - Mohamad Shaxi", FilePath = "https://github.com/hiimnowhwere/music/raw/main/Adagio%20-%20Mohamad%20Shaxi.mp3" });
            Musics.Add(new Song { Title = "Every Breath You Take - The Police", FilePath = "https://github.com/hiimnowhwere/music/raw/main/Every%20Breath%20You%20Take%20-%20The%20Police.mp3" });
            Musics.Add(new Song { Title = "I Still... - Backstreet Boys", FilePath = "https://github.com/hiimnowhwere/music/raw/main/I%20Still...%20-%20Backstreet%20Boys.mp3" });
            Musics.Add(new Song { Title = "Fishtail - Lana Del Rey", FilePath = "https://github.com/hiimnowhwere/music/raw/main/Fishtail%20-%20Lana%20Del%20Rey.mp3" });
            Musics.Add(new Song { Title = "Felina - Mohamad Shaxi", FilePath = "https://github.com/hiimnowhwere/music/raw/main/Felina%20-%20Mohamad%20Shaxi.mp3" });
            Musics.Add(new Song { Title = "Hours - Mohamad Shaxi", FilePath = "https://github.com/hiimnowhwere/music/raw/main/Hours%20-%20Mohamad%20Shaxi.mp3" });
            Musics.Add(new Song { Title = "haunt u - Lil Peep", FilePath = "https://github.com/hiimnowhwere/music/raw/main/haunt%20u-%20Lil%20Peep.mp3" });
            Musics.Add(new Song { Title = "My Love Mine All Mine - Mitski", FilePath = "https://github.com/hiimnowhwere/music/raw/main/My%20Love%20Mine%20All%20Mine%20-%20Mitski.mp3" });
            Musics.Add(new Song { Title = "tolerate it - Taylor Swift", FilePath = "https://github.com/hiimnowhwere/music/raw/main/tolerate%20it%20-%20Taylor%20Swift.mp3" });
            Musics.Add(new Song { Title = "Robbers - The 1975", FilePath = "https://github.com/hiimnowhwere/music/raw/main/Robbers%20-%20The%201975.mp3" });
            Musics.Add(new Song { Title = "Alison - Slowdive", FilePath = "https://github.com/hiimnowhwere/music/raw/main/Alison%20-%20Slowdive.mp3" });
            Musics.Add(new Song { Title = "Teenage Blue - Dreamgirl", FilePath = "https://github.com/hiimnowhwere/music/raw/main/Teenage%20blue.mp3" });

           
            RefreshListBox(); 
        }
        private void RefreshListBox(string searchText = "")
        {
            listBox1.Items.Clear();
            foreach (Song song in Musics)
            {
                if (song.Title.ToLower().Contains(searchText))
                {
                    listBox1.Items.Add(song.Title);
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Multiselect = true;

            if (open.ShowDialog() == DialogResult.OK)
            {
                foreach (string filePath in open.FileNames)
                {
                    string fileName = Path.GetFileName(filePath); 
                    if (!Musics.Exists(song => song.FilePath == filePath))
                    {
                        Song newSong = new Song
                        {
                            Title = fileName, 
                            FilePath = filePath 
                        };
                        Musics.Add(newSong);
                    }
                }

                RefreshListBox(); 
            }
        }


        private void previousbtn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > 0)
            {
                listBox1.SetSelected(listBox1.SelectedIndex - 1, true);
                PlayCurrentMusic();
            }
            else
            {
                listBox1.SelectedIndex = listBox1.Items.Count - 1;
                PlayCurrentMusic();
            }
        }

        private void playbtn_Click(object sender, EventArgs e)
        {
            if (player.URL != "")
            {
                player.Ctlcontrols.play();
               
                PlayCurrentMusic();
            }
            else
            {
                MessageBox.Show("Please select a music file to play.");
            }
        }

        private void pausebtn_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.pause();
        }

        private void nextbtn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < listBox1.Items.Count - 1)
            {
                listBox1.SetSelected(listBox1.SelectedIndex + 1, true);
                PlayCurrentMusic();
            }
            else
            {
                listBox1.SelectedIndex = 0;
                PlayCurrentMusic();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (player != null && player.Ctlcontrols != null && player.currentMedia != null)
            {
                label1.Text = player.Ctlcontrols.currentPositionString;
                label2.Text = player.currentMedia.durationString;
            }
            if (player != null && player.Ctlcontrols != null && player.currentMedia != null)
            {
                label1.Text = player.Ctlcontrols.currentPositionString;
                label2.Text = player.currentMedia.durationString;

                
                if (player.currentMedia.duration > 0)
                {
                    progressBar1.Value = (int)(player.Ctlcontrols.currentPosition / player.currentMedia.duration * 100);
                }
            }
        }

        private void progressBar1_MouseDown(object sender, MouseEventArgs e)
        {
            if (player != null && player.Ctlcontrols != null && player.currentMedia != null)
            {
              
                player.Ctlcontrols.pause();

             
                double clickPosition = (double)e.X / progressBar1.Width;
                double newPosition = clickPosition * player.currentMedia.duration;

             
                player.Ctlcontrols.currentPosition = newPosition;

               
                progressBar1.Value = (int)newPosition;

               
                player.Ctlcontrols.play();
            }
        }

    


        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            int value = trackBar1.Value;
            player.settings.volume = value;
        }

        private void PlayCurrentMusic()
        {
            if (listBox1.SelectedIndex >= 0 && listBox1.SelectedIndex < Musics.Count)
            {
                Song selectedSong = Musics[listBox1.SelectedIndex];
                string filePath = selectedSong.FilePath;
                player.URL = filePath;
                player.Ctlcontrols.play();

               
                label4.Visible = true;
                label4.Text = selectedSong.Title;
            }
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
           
            if (listBox1.SelectedIndex != -1)
            {
               
                Song selectedSong = Musics[listBox1.SelectedIndex];

              
                player.URL = selectedSong.FilePath;
                PlayCurrentMusic();

               
                if (songImages.ContainsKey(selectedSong.Title))
                {
                   
                    pictureBox5.Image = songImages[selectedSong.Title];
                }
               
                pictureBox1.Visible = false;
                pictureBox5.Visible = true;
               
                
                if (selectedSong.Title == "Adagio - Mohamad Shaxi")
                {
                    label4.ForeColor = Color.DarkBlue;
                    label4.Location = new Point(324, 420);

                }
                else if (selectedSong.Title == "Every Breath You Take - The Police")
                {
                   label4.ForeColor = Color.DarkRed;
                    label4.Location = new Point(280, 420);
                   
                }
                else if (selectedSong.Title == "I Still... - Backstreet Boys")
                {
                    label4.ForeColor = Color.SandyBrown;
                    label4.Location = new Point(324, 420);

                }
                else if (selectedSong.Title == "Fishtail - Lana Del Rey")
                {
                    label4.ForeColor = Color.DarkGray;
                    label4.Location = new Point(324, 420);

                }
                else if (selectedSong.Title == "Felina - Mohamad Shaxi")
                {
                    label4.ForeColor = Color.Pink;
                    label4.Location = new Point(324, 420);
                }
                else if (selectedSong.Title == "Hours - Mohamad Shaxi")
                {
                    label4.ForeColor = Color.DarkOrange;
                    label4.Location = new Point(324, 420);

                }
                else if (selectedSong.Title == "haunt u - Lil Peep")
                {
                    label4.ForeColor = Color.Black;
                    label4.Location = new Point(350, 420);

                }
                else if (selectedSong.Title == "My Love Mine All Mine - Mitski")
                {
                    label4.ForeColor = Color.Orange;
                    label4.Location = new Point(295, 420);

                }
                else if (selectedSong.Title == "tolerate it - Taylor Swift")
                {
                    label4.ForeColor = Color.SaddleBrown;
                    label4.Location = new Point(325, 420);

                }
                else if (selectedSong.Title == "Robbers - The 1975")
                {
                    label4.ForeColor = Color.LightGray;
                    label4.Location = new Point(335, 420);

                }
                else if (selectedSong.Title == "Alison - Slowdive")
                {
                    label4.ForeColor = Color.Black;
                    label4.Location = new Point(355, 420);


                }
                else if (selectedSong.Title == "Teenage Blue - Dreamgirl")
                {
                    label4.ForeColor = Color.LightBlue;
                    label4.Location = new Point(325, 420);

                }
            }
        }

        public class Song
        {
            public string Title { get; set; }
            public string FilePath { get; set; }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

       
    }
    
}
