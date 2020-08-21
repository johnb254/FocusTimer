using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Windows.Forms;

namespace FocusTimerPrototype
{
    public partial class SetupPage : Form {
        private readonly JObject data;

        public SetupPage() {
            InitializeComponent();
            try {
                data = JObject.Parse(File.ReadAllText(Storage.storagePath));
            }
            catch (Exception ex) {
                Console.WriteLine(ex.ToString());
            }
        }

        private void SetupCloseButton_Click(object sender, EventArgs e)
        {
            Taskbar.Show();
            Application.Exit();
        }

        private void SetupStartButton_Click(object sender, EventArgs e)
        {
            data.Property("focusTime").Value = FocusPromptTextBox.Text;
            data.Property("breakTime").Value = BreakPromptTextBox.Text;
            data.Property("taskbarHide").Value = TaskbarCheckBox.Checked;
            File.WriteAllText(Storage.storagePath, data.ToString());

            if (TaskbarCheckBox.Checked) {
                Taskbar.Hide();
            }

            PreFocusPage preFocus = new PreFocusPage();
            preFocus.Show();
            preFocus.SetDesktopLocation(this.Bounds.X, this.Bounds.Y);

            this.Hide();
        }

        private void SetupPage_Load(object sender, EventArgs e)
        {
            try
            {
                FocusPromptTextBox.Text = data.Value<String>("focusTime");
                BreakPromptTextBox.Text = data.Value<String>("breakTime");
                TaskbarCheckBox.Checked = data.Value<Boolean>("taskbarHide");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
