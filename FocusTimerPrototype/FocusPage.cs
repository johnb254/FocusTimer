using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Windows.Forms;

namespace FocusTimerPrototype {
    public partial class FocusPage : Form {

        private readonly JObject data;
        private readonly int maxTicks = 5;
        private int ticks;

        public FocusPage() {
            InitializeComponent();
            try {
                data = JObject.Parse(File.ReadAllText(Storage.storagePath));
            }
            catch (Exception ex) {
                Console.WriteLine(ex.ToString());
            }
            try {
                FocusTimer.Interval = data.Value<int>("focusTime") * 10000;
            }
            catch (Exception) {
                FocusTimer.Interval = 1;
            }
            ticks = 0;
        }

        private void FocusTimer_Tick(object sender, EventArgs e) {
            if (ticks++ == maxTicks) {
                Taskbar.Show();
                BreakPage breakPage = new BreakPage();
                breakPage.Show();
                breakPage.SetDesktopLocation(this.Bounds.X, this.Bounds.Y);
                breakPage.Activate();

                FocusTimer.Stop();
                Taskbar.Show();
                this.Hide();
            }
            this.Activate();
        }

        private void FocusReturnButton_Click(object sender, EventArgs e) {
            SetupPage setup = new SetupPage();
            setup.Show();
            setup.SetDesktopLocation(this.Bounds.X, this.Bounds.Y);

            FocusTimer.Stop();
            Taskbar.Show();
            this.Hide();
        }

        private void FocusPage_Load(object sender, EventArgs e) {
            FocusTimer.Start();
        }
    }
}
