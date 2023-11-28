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

            switch (stopKeyComboBox.SelectedIndex)
            {
                case 0:
                    if (!ModifierKeys.HasFlag(Keys.Control))
                    {
                        if (!Bounds.Contains(PointToClient(MousePosition)))
                        {
                            mouse_event(0x02, 0, 0, 0, 0);
                            System.Threading.Thread.Sleep(10);
                            mouse_event(0x04, 0, 0, 0, 0);
                        }
                    }
                    break;

                case 1:
                    if (!ModifierKeys.HasFlag(Keys.Alt))
                    {
                        if (!Bounds.Contains(PointToClient(MousePosition)))
                        {
                            mouse_event(0x02, 0, 0, 0, 0);
                            System.Threading.Thread.Sleep(10);
                            mouse_event(0x04, 0, 0, 0, 0);
                        }
                    }
                    break;

                case 2:
                    if (!ModifierKeys.HasFlag(Keys.Shift))
                    {
                        if (!Bounds.Contains(PointToClient(MousePosition)))
                        {
                            mouse_event(0x02, 0, 0, 0, 0);
                            System.Threading.Thread.Sleep(10);
                            mouse_event(0x04, 0, 0, 0, 0);
                        }
                    }
                    break;

                default:
                    Autoclicker.Stop();
                    btnStop.Enabled = false;
                    btnStart.Enabled = true;
                    MessageBox.Show("Please Select the Pause Key!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }



        }

        private void StopAutoclick(object sender, EventArgs e)
        {
            Autoclicker.Stop();
            btnStop.Enabled = false;
            btnStart.Enabled = true;
        }

        private void StartAutoclick(object sender, EventArgs e)
        {
            Autoclicker.Interval = (int)(1000.0 / clickSetBar.Value);
            Autoclicker.Start();
            btnStop.Enabled = true;
            btnStart.Enabled = false;
        }

        private void SetClicks(object sender, EventArgs e)
        {
            cpsLabel.Text = (clickSetBar.Value) + " Clicks/Sec.";
        }

        private void HelpDialog(object sender, EventArgs e)
        {
            MessageBox.Show("Autor: L. Kirstein\nContributor: J. S.\nVersion 1.0", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}