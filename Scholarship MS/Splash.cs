using System;
using System.Windows.Forms;

namespace Scholarship_MS
{

    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3;
            if (panel2.Width >= 599)
            {
                timer1.Stop();
                AddScholar addscreen = new AddScholar();
                addscreen.Show();
                this.Hide();

            }
        }

    }
}
