using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Windows.Forms;

namespace FocusTimerPrototype
{
    public partial class BreakPage : Form {

        private readonly JObject data;
        private int minutesLeft;
        private int secondsLeft;

        public BreakPage() {
            InitializeComponent();
            try {
                data = JObject.Parse(File.ReadAllText(Storage.storagePath));
            }
            catch (Exception ex) {
                Console.WriteLine(ex.ToString());
            }
            minutesLeft = data.Value<int>("breakTime");
            secondsLeft = 0;
        }

        private void SetupButton_Click(object sender, EventArgs e) {
            SetupPage setup = new SetupPage();
            setup.Show();
            setup.SetDesktopLocation(this.Bounds.X, this.Bounds.Y);

            this.Hide();
        }

        private void BreakPage_Load(object sender, EventArgs e) {
            BreakTimerLabel.Text = minutesLeft + ":" + secondsLeft.ToString().PadLeft(2, '0');
            BreakTimer.Start();
        }

        private void BreakTimer_Tick(object sender, EventArgs e) {
            if (minutesLeft <= 0 && secondsLeft <= 0) {
                BreakTimer.Stop();

                PreFocusPage preFocus = new PreFocusPage();
                preFocus.Show();
                preFocus.SetDesktopLocation(this.Bounds.X, this.Bounds.Y);
                preFocus.Activate();

                this.Hide();
            }

            if (minutesLeft != 0 && secondsLeft == 0) {
                minutesLeft--;
                secondsLeft = 59;
            } else {
                secondsLeft--;
            }

            BreakTimerLabel.Text = minutesLeft + ":" + secondsLeft.ToString().PadLeft(2, '0');
        }
    }
}
