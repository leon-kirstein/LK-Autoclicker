using System.Runtime.InteropServices;

namespace Autoclicker
{
    public partial class Form1 : Form
    {

        [DllImport("user32.dll")]
        private static extern void mouse_event(int dwFlags, int dx, int dy, int dxData, int dwExtraInfo);

        public Form1()
        {
            InitializeComponent();
        }

        private void Autoclicker_Tick(object sender, EventArgs e)
        {
            if (!ModifierKeys.HasFlag(Keys.Control))
                if (!Bounds.Contains(PointToClient(MousePosition)))
                {
                    mouse_event(0x02, 0, 0, 0, 0);
                    System.Threading.Thread.Sleep(10);
                    mouse_event(0x04, 0, 0, 0, 0);
                }

        }

        private void StopAutoclick(object sender, EventArgs e)
        {
            Autoclicker.Stop();
            button1.Enabled = false;
            btnStart.Enabled = true;
        }

        private void StartAutoclick(object sender, EventArgs e)
        {
            Autoclicker.Interval = (int)(1000000.0 / trackBar1.Value);
            Autoclicker.Start();
            button1.Enabled = true;
            btnStart.Enabled = false;
        }

        private void SetClicks(object sender, EventArgs e)
        {
            label1.Text = (trackBar1.Value) + " Clicks/Sec.";
        }

        private void HelpDialog(object sender, EventArgs e)
        {

        }
    }
}