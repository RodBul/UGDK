using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ugadaika
{
    public partial class congratulationForm : Form
    {
        public congratulationForm()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile(@"media/interface/stage.jpg");
        }
    }
}
