using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Journal_de_bord_philo
{
    public partial class Form1 : Form
    {
        string[] texte;


        public Form1()
        {
            InitializeComponent();
            try
            {
                texte = System.IO.File.ReadAllLines("test.txt", Encoding.Default);
            }
            catch
            {
                MessageBox.Show("what");
            }

            for (int i = 0; i < 10; i++)
                Label_Texte.Text += texte[i] + '\n';
        }


    }
}
