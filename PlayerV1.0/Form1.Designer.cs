
namespace PlayerV1._0
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_preview = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_play = new System.Windows.Forms.Button();
            this.btn_pause = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_open = new System.Windows.Forms.Button();
            this.pic_art = new System.Windows.Forms.PictureBox();
            this.track_volumen = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_volume = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFulltime = new System.Windows.Forms.Label();
            this.check_bucle = new System.Windows.Forms.CheckBox();
            this.vlcControl1 = new Vlc.DotNet.Forms.VlcControl();
            this.track_list = new System.Windows.Forms.ListBox();
            this.btn_trash = new System.Windows.Forms.Button();
            this.btn_playlist = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pic_art)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_volumen)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_preview
            // 
            this.btn_preview.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_preview.BackgroundImage")));
            this.btn_preview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_preview.Location = new System.Drawing.Point(9, 207);
            this.btn_preview.Name = "btn_preview";
            this.btn_preview.Size = new System.Drawing.Size(44, 39);
            this.btn_preview.TabIndex = 0;
            this.btn_preview.UseVisualStyleBackColor = true;
            this.btn_preview.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_next
            // 
            this.btn_next.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_next.BackgroundImage")));
            this.btn_next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_next.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_next.Location = new System.Drawing.Point(109, 207);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(44, 39);
            this.btn_next.TabIndex = 1;
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_play
            // 
            this.btn_play.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_play.BackgroundImage")));
            this.btn_play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_play.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_play.Location = new System.Drawing.Point(59, 207);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(44, 39);
            this.btn_play.TabIndex = 2;
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // btn_pause
            // 
            this.btn_pause.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_pause.BackgroundImage")));
            this.btn_pause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_pause.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_pause.Location = new System.Drawing.Point(59, 207);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(44, 39);
            this.btn_pause.TabIndex = 3;
            this.btn_pause.UseVisualStyleBackColor = true;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Location = new System.Drawing.Point(159, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 39);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_open
            // 
            this.btn_open.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_open.BackgroundImage")));
            this.btn_open.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_open.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_open.Location = new System.Drawing.Point(459, 205);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(44, 39);
            this.btn_open.TabIndex = 5;
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.button2_Click);
            // 
            // pic_art
            // 
            this.pic_art.Image = ((System.Drawing.Image)(resources.GetObject("pic_art.Image")));
            this.pic_art.Location = new System.Drawing.Point(3, 48);
            this.pic_art.Name = "pic_art";
            this.pic_art.Size = new System.Drawing.Size(128, 108);
            this.pic_art.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_art.TabIndex = 8;
            this.pic_art.TabStop = false;
            // 
            // track_volumen
            // 
            this.track_volumen.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.track_volumen.BackColor = System.Drawing.Color.Beige;
            this.track_volumen.Location = new System.Drawing.Point(447, 32);
            this.track_volumen.Maximum = 100;
            this.track_volumen.Name = "track_volumen";
            this.track_volumen.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.track_volumen.Size = new System.Drawing.Size(56, 140);
            this.track_volumen.TabIndex = 10;
            this.track_volumen.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.track_volumen.Value = 1;
            this.track_volumen.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Beige;
            this.label1.Location = new System.Drawing.Point(440, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Volumen";
            // 
            // lbl_volume
            // 
            this.lbl_volume.AutoSize = true;
            this.lbl_volume.BackColor = System.Drawing.Color.Beige;
            this.lbl_volume.Location = new System.Drawing.Point(444, 12);
            this.lbl_volume.Name = "lbl_volume";
            this.lbl_volume.Size = new System.Drawing.Size(44, 17);
            this.lbl_volume.TabIndex = 12;
            this.lbl_volume.Text = "100%";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Beige;
            this.panel1.Controls.Add(this.lblFulltime);
            this.panel1.Controls.Add(this.check_bucle);
            this.panel1.Controls.Add(this.vlcControl1);
            this.panel1.Controls.Add(this.pic_art);
            this.panel1.Controls.Add(this.track_volumen);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_volume);
            this.panel1.Controls.Add(this.track_list);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(506, 199);
            this.panel1.TabIndex = 15;
            // 
            // lblFulltime
            // 
            this.lblFulltime.AutoSize = true;
            this.lblFulltime.Location = new System.Drawing.Point(16, 12);
            this.lblFulltime.Name = "lblFulltime";
            this.lblFulltime.Size = new System.Drawing.Size(0, 17);
            this.lblFulltime.TabIndex = 16;
            // 
            // check_bucle
            // 
            this.check_bucle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("check_bucle.BackgroundImage")));
            this.check_bucle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.check_bucle.FlatAppearance.BorderSize = 0;
            this.check_bucle.Location = new System.Drawing.Point(8, 163);
            this.check_bucle.Name = "check_bucle";
            this.check_bucle.Size = new System.Drawing.Size(30, 30);
            this.check_bucle.TabIndex = 14;
            this.check_bucle.UseVisualStyleBackColor = true;
            // 
            // vlcControl1
            // 
            this.vlcControl1.BackColor = System.Drawing.Color.Beige;
            this.vlcControl1.Location = new System.Drawing.Point(3, 3);
            this.vlcControl1.Name = "vlcControl1";
            this.vlcControl1.Size = new System.Drawing.Size(10, 10);
            this.vlcControl1.Spu = -1;
            this.vlcControl1.TabIndex = 13;
            this.vlcControl1.Text = "vlcControl1";
            this.vlcControl1.VlcLibDirectory = ((System.IO.DirectoryInfo)(resources.GetObject("vlcControl1.VlcLibDirectory")));
            this.vlcControl1.VlcMediaplayerOptions = null;
            // 
            // track_list
            // 
            this.track_list.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.track_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.track_list.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.track_list.ForeColor = System.Drawing.Color.White;
            this.track_list.FormattingEnabled = true;
            this.track_list.ItemHeight = 16;
            this.track_list.Location = new System.Drawing.Point(132, 12);
            this.track_list.Name = "track_list";
            this.track_list.Size = new System.Drawing.Size(302, 176);
            this.track_list.TabIndex = 7;
            this.track_list.SelectedIndexChanged += new System.EventHandler(this.track_list_SelectedIndexChanged);
            // 
            // btn_trash
            // 
            this.btn_trash.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_trash.BackgroundImage")));
            this.btn_trash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_trash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_trash.Location = new System.Drawing.Point(360, 205);
            this.btn_trash.Name = "btn_trash";
            this.btn_trash.Size = new System.Drawing.Size(44, 39);
            this.btn_trash.TabIndex = 17;
            this.btn_trash.UseVisualStyleBackColor = true;
            this.btn_trash.Click += new System.EventHandler(this.btn_trash_Click);
            // 
            // btn_playlist
            // 
            this.btn_playlist.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_playlist.BackgroundImage")));
            this.btn_playlist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_playlist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_playlist.Location = new System.Drawing.Point(410, 205);
            this.btn_playlist.Name = "btn_playlist";
            this.btn_playlist.Size = new System.Drawing.Size(44, 39);
            this.btn_playlist.TabIndex = 18;
            this.btn_playlist.UseVisualStyleBackColor = true;
            this.btn_playlist.Click += new System.EventHandler(this.btn_playlist_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(209, 228);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(95, 15);
            this.textBox1.TabIndex = 19;
            this.textBox1.Text = "-----------------------";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(209, 217);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(95, 15);
            this.textBox2.TabIndex = 20;
            this.textBox2.Text = "-----------------------";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(209, 207);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(95, 15);
            this.textBox3.TabIndex = 21;
            this.textBox3.Text = "-----------------------";
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.Location = new System.Drawing.Point(310, 205);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(44, 39);
            this.button2.TabIndex = 22;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(507, 251);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_playlist);
            this.Controls.Add(this.btn_trash);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_pause);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_preview);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music Player ";
            this.TransparencyKey = System.Drawing.Color.Gray;
            ((System.ComponentModel.ISupportInitialize)(this.pic_art)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_volumen)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_preview;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.PictureBox pic_art;
        private System.Windows.Forms.TrackBar track_volumen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_volume;
        private System.Windows.Forms.Panel panel1;
       // private Vlc.DotNet.Forms.VlcControl vlcControl1;
        private System.Windows.Forms.Button btn_trash;
        private System.Windows.Forms.Button btn_playlist;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.ListBox track_list;
        private System.Windows.Forms.Button button2;
        private Vlc.DotNet.Forms.VlcControl vlcControl1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblFulltime;
        public System.Windows.Forms.CheckBox check_bucle;
    }
}

