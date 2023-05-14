using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace librarymain0.Login
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuProgressBar1_progressChanged(object sender, EventArgs e)
        {

        }
        int startpos = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpos += 1;
            MyProgress.Value = startpos;
            PercentageLabel.Text = startpos + "%";
            if (MyProgress.Value == 100)
            {
                MyProgress.Value = 0;
                timer1.Stop();
                Login log = new Login();
                log.Show();
                this.Hide();
            }
        }
    }
}
