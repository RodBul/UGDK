using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ugadaika
{
    public partial class RoundNotific : Form
    {
        public RoundNotific(int numRound)
        {
            InitializeComponent();

            this.BackgroundImage = Image.FromFile(@"media/interface/stage.jpg");
            //label1.Text = textRound;
            pictureBox1.Image = Image.FromFile($"media/interface/round{numRound}.png");
        }
    }
}
