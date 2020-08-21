using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FocusTimerPrototype
{
    public partial class StartingPage : Form
    {
        public StartingPage()
        {
            InitializeComponent();
        }

        private void WelcomeStartButton_Click(object sender, EventArgs e)
        {
            SetupPage setup = new SetupPage();
            setup.Show();
            setup.SetDesktopLocation(this.Bounds.X, this.Bounds.Y);

            this.Hide();
        }
    }
}
