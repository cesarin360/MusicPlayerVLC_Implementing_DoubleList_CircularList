using PlayerV1._0.CircularDefinicion;
using PlayerV1._0.ListaDoblementeEnlazada;
using PlayerV1._0.ListaPuntos;
using System;
using System.Windows.Forms;
using System.Media;
using Vlc.DotNet.Forms;
using Vlc.DotNet.Core.Interops;
using Vlc.DotNet.Core;

namespace PlayerV1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            this.check_bucle.Appearance = Appearance.Button;
            track_volumen.Value = 100;
            lbl_volume.Text = track_volumen.Value.ToString();
            pic_art.Enabled = false;
            btn_pause.Hide();
            check_bucle.Visible = false;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (track_list.SelectedIndex > 0)
            {
                track_list.SelectedIndex -= 1;
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            pic_art.Enabled = false;
            vlcControl1.Stop();

        }
        
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            vlcControl1.Audio.Volume = track_volumen.Value;
            lbl_volume.Text = track_volumen.Value.ToString();
        }
    
        public ClsListaDoble addfiles = new ClsListaDoble();
        public ClsListaCircularBase addfiles1 = new ClsListaCircularBase();
        public Nodo2 lista1;
        public Nodo1 lista;
        public int n;
        int count = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Filter = "Music files (*.mp3, *.m4a) | *.mp3; *.m4a",
                Multiselect = true
            };
            openFileDialog1.InitialDirectory = "C:\\Users\\josue\\Music";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {                
                for (int i = 0; i < openFileDialog1.FileNames.Length; i++)
                {
                    addfiles.insertaCabezaLista(openFileDialog1.FileNames[i]);
                }
                Nodo1 lista;
                lista = addfiles.cabeza;
                for (int i = 0; i < openFileDialog1.FileNames.Length; i++)
                {
                    track_list.Items.Add(lista.dato.Replace("C:\\Users\\josue\\Music\\", ""));
                    lista = lista.adelante;
                    n++;
                }
            }
        }

        private void btn_pause_Click(object sender, EventArgs e)
        {
            vlcControl1.SetPause(true);
            btn_pause.Hide();
            btn_play.Show();
            pic_art.Enabled = false;
            timer1.Enabled = false;
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            if (check_bucle.Checked)
            {
                timer1.Enabled = true;
            }
            if (check_bucle.Checked && count == 0)
            {
                vlcControl1.SetMedia(new System.IO.FileInfo(lista1.dato));
                vlcControl1.Play();
                track_list.SelectedIndex = 0;

            }
            if (track_list.Items.Count != 0)
            {
                vlcControl1.Play();
                btn_play.Hide();
                btn_pause.Show();
                pic_art.Enabled = true;
            }
            else
            {
                MessageBox.Show("¡AGREGA CANCIONES A TU LISTA!");
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (track_list.SelectedIndex < track_list.Items.Count - 1)
            {
                track_list.SelectedIndex += 1;
            }
        }

        private void btn_trash_Click(object sender, EventArgs e)
        {
            vlcControl1.Stop();
            int xl = track_list.SelectedIndex;
            addfiles.eliminar(xl);
            track_list.Items.Remove(track_list.SelectedItem);
            n--;
            if (track_list.Items.Count == 0)
            {
                MessageBox.Show("LA LISTA ESTA VACIA");
                pic_art.Enabled = false;
            }

        }

        private void track_list_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (!check_bucle.Checked)
            {
                if (track_list.Items.Count == 0)
                {
                    vlcControl1.Stop();
                }
                else
                {
                    int selected;
                    if (track_list.SelectedItem != null)
                    {
                        selected = track_list.SelectedIndex;
                        vlcControl1.SetMedia(new System.IO.FileInfo(addfiles.BuscarPosicion(selected).dato));
                        pic_art.Enabled = true;
                    }
                    else
                    {
                        if (track_list.SelectedIndex < track_list.Items.Count - 1)
                        {
                            track_list.SelectedIndex += 1;
                            selected = track_list.SelectedIndex;
                            vlcControl1.SetMedia(new System.IO.FileInfo(addfiles.BuscarPosicion(selected).dato));
                            pic_art.Enabled = true;

                        }
                        if (track_list.SelectedIndex > 0)
                        {
                            track_list.SelectedIndex -= 1;
                            selected = track_list.SelectedIndex;
                            vlcControl1.SetMedia(new System.IO.FileInfo(addfiles.BuscarPosicion(selected).dato));
                            pic_art.Enabled = true;
                        }
                    }
                    vlcControl1.Play();
                    btn_play.Hide();
                    btn_pause.Show();
                }
            }
            else
            {
                timer1.Enabled = true;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (track_list.Items.Count == 0)
            {
                MessageBox.Show("LA LISTA ESTA VACIA");
            }
            else
            {
                string message = "¿Estas seguro que quieres eliminar los elementos de la lista?";
                string caption = "Pregunta";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);
                if (result == DialogResult.Yes)
                {
                    track_list.Items.Clear();
                    vlcControl1.Stop();
                    pic_art.Enabled = false;
                    for (int j = 0; j < n; j++)
                    {
                        addfiles.eliminar(j);
                        if (addfiles1.lc != null)
                        {
                            addfiles1.eliminar(j);
                        }
                    }
                    n = 0;
                    addfiles1.lc = null;
                    addfiles.cabeza = null;
                    lista1 = null;
                    btn_pause.Hide();
                    btn_play.Show();
                }
            }

        }

        private VlcMediaPlayer vlcmedia = null;
        private VlcMedia media = null;
        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            vlcmedia = this.vlcControl1.VlcMediaPlayer;
            media = vlcmedia.GetMedia();
            media.Parse();
            String time = media.Duration.ToString();
            time = time.Remove(time.IndexOf("."));
            if (count.ToString() == time)
            {
                if (lista1 != null)
                {
                    count = 0;
                    lista1 = lista1.enlace;
                    vlcControl1.SetMedia(new System.IO.FileInfo(lista1.dato));
                    vlcControl1.Play();

                    if (track_list.SelectedIndex < track_list.Items.Count - 1)
                    {
                        track_list.SelectedIndex += 1;
                    }
                    else
                    {
                        track_list.SelectedIndex = 0;
                    }
                }
                
            }
            lblFulltime.Text = count.ToString();
        }

        private void btn_playlist_Click(object sender, EventArgs e)
        {
            Nodo1 lista;
            lista = addfiles.cabeza;
            Playlist_Form frm2 = new Playlist_Form();
            for (int j = 0; j < n && addfiles.cabeza != null; j++)
            {
                frm2.track_list2.Items.Add(lista.dato);
                lista = lista.adelante;
            }
            vlcControl1.Stop();
            frm2.Show();
            this.Hide();
        }
    }
}
