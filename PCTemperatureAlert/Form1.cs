using OpenHardwareMonitor.Hardware;

namespace PCTemperatureAlert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtThreshold_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnGetTemp_Click(object sender, EventArgs e)
        {
            if (txtThreshold.Text == "")
            {
                lblWarning.Text = "Please enter threshold!";
            }
            else
            {
                double threshold = Convert.ToDouble(txtThreshold.Text);

                if (threshold < 0 || threshold > 150)
                    lblWarning.Text = "Invalid threshold!";
                else
                {
                    lblWarning.Text = "";
                    this.WindowState = FormWindowState.Minimized;
                    OpenHardwareMonitor.Hardware.Computer computer = new OpenHardwareMonitor.Hardware.Computer();
                    computer.Open();
                    computer.CPUEnabled = true;
                    bool IsContinue = true;

                    while (IsContinue)
                    {
                        foreach (var hardware in computer.Hardware)
                        {
                            hardware.Update();

                            if (hardware.HardwareType == HardwareType.CPU)
                            {
                                foreach (var sensor in hardware.Sensors)
                                {
                                    if (sensor.SensorType == SensorType.Temperature)
                                    {
                                        if (sensor.Value > threshold)
                                            if (MessageBox.Show(
                                                new Form() { TopMost = true },
                                                "CPU temperature exceeds threshold: " + sensor.Value + "°C\nContinue monitoring CPU temperature?",
                                                "CPU Temperature Alert!",
                                                MessageBoxButtons.OKCancel,
                                                MessageBoxIcon.Warning
                                                ) != DialogResult.OK)
                                            {
                                                IsContinue = false;
                                                break;
                                            }

                                    }
                                }
                                if (!IsContinue)
                                    break;
                            }
                        }
                        if (IsContinue)
                            System.Threading.Thread.Sleep(2000);
                    }

                    this.Close();
                }
            }

        }

    }
}