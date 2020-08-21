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
    public partial class PreFocusPage : Form
    {
        public PreFocusPage()
        {
            InitializeComponent();
        }

        private void BeginButton_Click(object sender, EventArgs e)
        {
            FocusPage focus = new FocusPage();
            focus.Show();
            focus.SetDesktopLocation(this.Bounds.X, this.Bounds.Y);

            this.Hide();
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            Taskbar.Show();
            SetupPage setup = new SetupPage();
            setup.Show();
            setup.SetDesktopLocation(this.Bounds.X, this.Bounds.Y);

            this.Hide();
        }
    }
}
