using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhiloJournalDeBord
{
    public partial class Form_Experiences : Form
    {
        int page = 1;
        string[] texteV;
        const int NbLignesAAfficher = 2;

        private bool _dragging = false;
        private Point _offset;
        private Point _start_point = new Point(0, 0);

        CustomFlowLayoutPanel cflp = new CustomFlowLayoutPanel();
        Label label1 = new Label();

        public Form_Experiences()
        {
            this.DoubleBuffered = true;

            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);



            InitializeComponent();
            label1.AutoSize = true;
            label1.MaximumSize = new System.Drawing.Size(588, 9999999);
            label1.Font = new System.Drawing.Font("Comic Sans MS", 14, FontStyle.Regular);
            label1.MouseDown += Form_Experiences_MouseDown;
            label1.MouseUp += Form_Experiences_MouseUp;
            label1.MouseMove += Form_Experiences_MouseMove;

            cflp.Location = new Point(50, 50);
            cflp.AutoSize = false;
            cflp.AutoScroll = true;
            cflp.Size = new System.Drawing.Size(588, 500);
            cflp.MouseDown += Form_Experiences_MouseDown;
            cflp.MouseUp += Form_Experiences_MouseUp;
            cflp.MouseMove += Form_Experiences_MouseMove;
            cflp.MouseEnter += cflp_MouseEnter;
            cflp.Controls.Add(label1);
            this.Controls.Add(cflp);

            try
            {
                texteV = File.ReadAllLines("Milgram et Stanford.txt", Encoding.Default);
            }
            catch
            {
                MessageBox.Show("Fichier pour V pour Vendetta non trouvé");
            }


            foreach (string s in texteV)
                label1.Text += s + '\n';

            cflp.Focus();
        }

        private void cflp_MouseEnter(object sender, EventArgs e)
        {
            cflp.Focus();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            page++;
            UpdateLabels();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            page--;
            UpdateLabels();
        }

        private void UpdateLabels()
        {
            int indice;
            label1.Text = "";

            for (int i = 0; i < NbLignesAAfficher; i++)
            {
                indice = (page - 1) * NbLignesAAfficher + i;

                if (indice > 0 && indice < texteV.Length - 1)
                    label1.Text += texteV[indice] + '\n';
            }
        }

        private void Form_Experiences_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Experiences_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;  // _dragging is your variable flag
            _start_point = new Point(e.X, e.Y);

        }

        private void Form_Experiences_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void Form_Experiences_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void panel1_Scroll(object sender, ScrollEventArgs se)
        {

            this.Invalidate();

            base.OnScroll(se);
        }

        private void flowLayoutPanel1_Scroll(object sender, ScrollEventArgs se)
        {
            this.Invalidate();
            base.OnScroll(se);
        }

    }
}
