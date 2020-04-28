using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Swimming
{
    public enum Style {
        Ledjno,
        Prsno,
        Delfin,
        Slobodno
    }
    public class Swimmer
    {
        public string TeamName { get; set; }
        public int Velocity { get; set; }
        public Style Style { get; set; }
        public Point Position { get; set; }
        public Brush Brush { get; set; }
        private Size size = new Size(20, 20);

        private bool goingRight = false;
        public Swimmer()
        {
            this.Style = Style.Delfin;
            this.Velocity = 5;
        }

        public Swimmer(string teamName, int velocity)
        {
            this.TeamName = teamName;
            this.Velocity = velocity;
        }

        public void Draw(PaintEventArgs e)
        {
            e.Graphics.FillEllipse(this.Brush, new Rectangle(this.Position, this.size));
        }

        public void Swim()
        {
            if(goingRight)
            {
                if (this.Position.X > 380)
                    goingRight = false;
                this.Position = new Point(this.Position.X + Velocity, this.Position.Y);
            }
            else
            {
                if(this.Position.X < 20)
                    goingRight = true;
                this.Position = new Point(this.Position.X - Velocity, this.Position.Y);
            }
        }

        public override string ToString()
        {
            return $"Tim:{this.TeamName} {this.Style} {this.Velocity}";
        }
    }
}
