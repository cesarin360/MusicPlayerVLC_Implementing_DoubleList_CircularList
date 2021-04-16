
namespace PlayerV1._0
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.direcciones_c = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_play = new System.Windows.Forms.Button();
            this.track_list2 = new System.Windows.Forms.ListBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lst_playlist1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // direcciones_c
            // 
            this.direcciones_c.FormattingEnabled = true;
            this.direcciones_c.Location = new System.Drawing.Point(12, 34);
            this.direcciones_c.Name = "direcciones_c";
            this.direcciones_c.Size = new System.Drawing.Size(325, 24);
            this.direcciones_c.TabIndex = 0;
            this.direcciones_c.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(11, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "PLAYLISTS GUARDADAS";
            // 
            // btn_play
            // 
            this.btn_play.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_play.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_play.Location = new System.Drawing.Point(12, 64);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(128, 31);
            this.btn_play.TabIndex = 6;
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.button2_Click);
            // 
            // track_list2
            // 
            this.track_list2.FormattingEnabled = true;
            this.track_list2.ItemHeight = 16;
            this.track_list2.Location = new System.Drawing.Point(326, 16);
            this.track_list2.Name = "track_list2";
            this.track_list2.Size = new System.Drawing.Size(10, 4);
            this.track_list2.TabIndex = 11;
            this.track_list2.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(65, 68);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(21, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lst_playlist1
            // 
            this.lst_playlist1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lst_playlist1.FormattingEnabled = true;
            this.lst_playlist1.ItemHeight = 16;
            this.lst_playlist1.Location = new System.Drawing.Point(327, 24);
            this.lst_playlist1.Name = "lst_playlist1";
            this.lst_playlist1.Size = new System.Drawing.Size(10, 4);
            this.lst_playlist1.TabIndex = 17;
            this.lst_playlist1.Visible = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 101);
            this.Controls.Add(this.lst_playlist1);
            this.Controls.Add(this.track_list2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.direcciones_c);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Playlist";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_play;
        public System.Windows.Forms.ComboBox direcciones_c;
        private System.Windows.Forms.ListBox track_list2;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.ListBox lst_playlist1;
    }
}