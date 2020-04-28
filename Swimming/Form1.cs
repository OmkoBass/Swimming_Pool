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
    public partial class Form1 : Form
    {
        int which = 1;

        public List<Swimmer> Swimmers = new List<Swimmer>();
        public Form1()
        {
            InitializeComponent();

            TeamName.Text = $"Ime prve ekipe:";
            AssignTeam.Text = "Dalje";
        }

        private void AssignTeam_Click(object sender, EventArgs e)
        {
            if(which <= 4)
            {
                which++;
                Swimmers.Add(new Swimmer(TeamNameInput.Text, int.Parse(TeamSpeedInput.Text)));
                TeamName.Text = $"Ime {(which == 2 ? "Druge" : which == 3 ? "Trece" : "Cetvrte")} ekipe:"; //I love ternary

                if(which == 5)
                {
                    SwimmingPool sp = new SwimmingPool(Swimmers);
                    sp.Show();

                    this.Hide();
                }
            }
        }
    }
}
