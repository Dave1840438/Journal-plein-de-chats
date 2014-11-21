using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace PhiloJournalDeBord
{
    public partial class Form1 : Form
    {//Global variables;
        private bool _dragging = false;
        private Point _offset;
        private Point _start_point = new Point(0, 0);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;  // _dragging is your variable flag
            _start_point = new Point(e.X, e.Y);

        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false; 
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(1);
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"catmoew\catmeow2.wav");
            player.Play();

            Form_V form = new Form_V();

            this.Hide();
           form.ShowDialog();
           this.Show();
        }

     


       
    }
}
