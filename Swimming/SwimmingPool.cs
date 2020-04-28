using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Swimming
{
    public partial class SwimmingPool : Form
    {
        public Swimmer[] Swimmers = null;
        public SwimmingPool(List<Swimmer> swimmers)
        {
            InitializeComponent();
            Swimmers = swimmers.ToArray();

            Swimmers[0].Position = new Point(20, 30);
            Swimmers[0].Brush = Brushes.Red;

            Swimmers[1].Position = new Point(20, 70);
            Swimmers[1].Brush = Brushes.DarkGray;

            Swimmers[2].Position = new Point(20, 110);
            Swimmers[2].Brush = Brushes.Magenta;

            Swimmers[3].Position = new Point(20, 150);
            Swimmers[3].Brush = Brushes.Green;

            FirstTeam.Text = Swimmers[0].TeamName;
            SecondTeam.Text = Swimmers[1].TeamName;
            ThirdTeam.Text = Swimmers[2].TeamName;
            FourthTeam.Text = Swimmers[3].TeamName;
        }

        private void SwimmingPool_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }


        private void SwimTimer_Tick(object sender, EventArgs e)
        {
            foreach(Swimmer s in Swimmers)
            {
                s.Swim();
            }

            Refresh();
            Update();
            Invalidate();
        }

        private void Pool_Paint(object sender, PaintEventArgs e)
        {
            //I'm gonna hard code this because i don't give a fuck. I just want to get this done, don't care if it's stupid

            e.Graphics.FillRectangle(Brushes.Blue, new Rectangle(new Point(0, 0), new Size(Pool.Width, Pool.Height)));

            e.Graphics.FillRectangle(Brushes.LightBlue, new Rectangle(new Point(10, 25), new Size(Pool.Width - 20, 30)));
            e.Graphics.FillRectangle(Brushes.LightBlue, new Rectangle(new Point(10, 65), new Size(Pool.Width - 20, 30)));
            e.Graphics.FillRectangle(Brushes.LightBlue, new Rectangle(new Point(10, 105), new Size(Pool.Width - 20, 30)));
            e.Graphics.FillRectangle(Brushes.LightBlue, new Rectangle(new Point(10, 145), new Size(Pool.Width - 20, 30)));


            foreach (Swimmer s in Swimmers)
            {
                s.Draw(e);
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            SwimTimer.Start();
        }

        private void Pause_Click(object sender, EventArgs e)
        {
            SwimTimer.Stop();
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            Swimmers[0].Position = new Point(20, 30);

            Swimmers[1].Position = new Point(20, 70);

            Swimmers[2].Position = new Point(20, 110);

            Swimmers[3].Position = new Point(20, 150);

            Refresh();
            Update();
            Invalidate();
            SwimTimer.Stop();
        }
    }
}
