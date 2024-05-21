namespace MusicProject
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.nextbtn = new System.Windows.Forms.PictureBox();
            this.pausebtn = new System.Windows.Forms.PictureBox();
            this.playbtn = new System.Windows.Forms.PictureBox();
            this.previousbtn = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pausebtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previousbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(248)))), ((int)(((byte)(226)))));
            this.progressBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(159)))), ((int)(((byte)(138)))));
            this.progressBar1.Location = new System.Drawing.Point(305, 637);
            this.progressBar1.Maximum = 250;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(466, 15);
            this.progressBar1.Step = 100;
            this.progressBar1.TabIndex = 1;
            this.progressBar1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.progressBar1_MouseDown);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(48)))), ((int)(((byte)(83)))));
            this.listBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(255, 124);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(230, 626);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "00:00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(777, 626);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "00:00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(405, 523);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 27);
            this.label3.TabIndex = 10;
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.White;
            this.trackBar1.Location = new System.Drawing.Point(932, 181);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(56, 314);
            this.trackBar1.TabIndex = 12;
            this.trackBar1.Value = 50;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(391, 505);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(715, 28);
            this.label4.TabIndex = 16;
            this.label4.Text = "           label4                                                                " +
    "    ";
            this.label4.Visible = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Location = new System.Drawing.Point(357, 99);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(457, 370);
            this.pictureBox5.TabIndex = 15;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::MusicProject.Properties.Resources.volume_1_1s_200px__2_;
            this.pictureBox4.Location = new System.Drawing.Point(932, 482);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(74, 50);
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::MusicProject.Properties.Resources.volume_1_1s_200px__1___1_;
            this.pictureBox3.Location = new System.Drawing.Point(932, 125);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(74, 50);
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // nextbtn
            // 
            this.nextbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextbtn.Image = global::MusicProject.Properties.Resources.photo_2024_03_14_19_20_40__3_;
            this.nextbtn.Location = new System.Drawing.Point(620, 566);
            this.nextbtn.Name = "nextbtn";
            this.nextbtn.Size = new System.Drawing.Size(40, 40);
            this.nextbtn.TabIndex = 9;
            this.nextbtn.TabStop = false;
            this.nextbtn.Click += new System.EventHandler(this.nextbtn_Click);
            // 
            // pausebtn
            // 
            this.pausebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pausebtn.Image = global::MusicProject.Properties.Resources.photo_2024_03_14_19_21_24;
            this.pausebtn.Location = new System.Drawing.Point(540, 566);
            this.pausebtn.Name = "pausebtn";
            this.pausebtn.Size = new System.Drawing.Size(40, 40);
            this.pausebtn.TabIndex = 8;
            this.pausebtn.TabStop = false;
            this.pausebtn.Click += new System.EventHandler(this.pausebtn_Click);
            // 
            // playbtn
            // 
            this.playbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playbtn.Image = global::MusicProject.Properties.Resources.photo_2024_03_14_19_23_34;
            this.playbtn.Location = new System.Drawing.Point(447, 566);
            this.playbtn.Name = "playbtn";
            this.playbtn.Size = new System.Drawing.Size(40, 40);
            this.playbtn.TabIndex = 7;
            this.playbtn.TabStop = false;
            this.playbtn.Click += new System.EventHandler(this.playbtn_Click);
            // 
            // previousbtn
            // 
            this.previousbtn.BackColor = System.Drawing.Color.Transparent;
            this.previousbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.previousbtn.Image = global::MusicProject.Properties.Resources.photo_2024_03_14_19_20_52__1_;
            this.previousbtn.Location = new System.Drawing.Point(369, 566);
            this.previousbtn.Name = "previousbtn";
            this.previousbtn.Size = new System.Drawing.Size(40, 40);
            this.previousbtn.TabIndex = 6;
            this.previousbtn.TabStop = false;
            this.previousbtn.Click += new System.EventHandler(this.previousbtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::MusicProject.Properties.Resources.music__1_;
            this.pictureBox2.Location = new System.Drawing.Point(273, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 48);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MusicProject.Properties.Resources.PurE_ezgif_com_resize;
            this.pictureBox1.Location = new System.Drawing.Point(282, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(653, 490);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // player
            // 
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(64, 335);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(75, 23);
            this.player.TabIndex = 11;
            this.player.Visible = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1018, 768);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.player);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nextbtn);
            this.Controls.Add(this.pausebtn);
            this.Controls.Add(this.playbtn);
            this.Controls.Add(this.previousbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form3";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music Player";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pausebtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.previousbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox previousbtn;
        private System.Windows.Forms.PictureBox playbtn;
        private System.Windows.Forms.PictureBox pausebtn;
        private System.Windows.Forms.PictureBox nextbtn;
        private System.Windows.Forms.Label label3;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label4;
    }
}