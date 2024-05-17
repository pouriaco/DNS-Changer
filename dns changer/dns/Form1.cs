using System;
using System.Management;
using System.Windows.Forms;

using ComponentFactory.Krypton.Toolkit;

namespace dns
{
    public partial class Form1 : KryptonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kryptonComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void kryptonComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeBotton.Enabled = true;
        }

        private void changeBotton_Click(object sender, EventArgs e)
        {
            switch (kryptonComboBox2.Text)
            {
                case "Clear":

                    break;

                case "Shecan":
                    try
                    {
                        ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
                        ManagementObjectCollection moc = mc.GetInstances();
                        foreach (ManagementObject mo in moc)
                        {
                            if ((bool)mo["IPEnabled"])
                            {
                                ManagementBaseObject objdns = mo.GetMethodParameters("SetDNSServerSearchOrder");
                                if (objdns != null)
                                {
                                    string[] s = { "178.22.122.100", "185.51.200.2" };
                                    objdns["DNSServerSearchOrder"] = s;
                                    mo.InvokeMethod("SetDNSServerSearchOrder", objdns, null);
                                }
                            }
                        }
                        MessageBox.Show("! شما با موفقیت به شکن تغییر کرد DNS");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    break;

                case "Electro":
                    try
                    {
                        ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
                        ManagementObjectCollection moc = mc.GetInstances();
                        foreach (ManagementObject mo in moc)
                        {
                            if ((bool)mo["IPEnabled"])
                            {
                                ManagementBaseObject objdns = mo.GetMethodParameters("SetDNSServerSearchOrder");
                                if (objdns != null)
                                {
                                    string[] s = { "78.157.42.101", "78.157.42.100" };
                                    objdns["DNSServerSearchOrder"] = s;
                                    mo.InvokeMethod("SetDNSServerSearchOrder", objdns, null);

                                }
                            }
                        }
                        MessageBox.Show("! شما با موفقیت به الکترو تغییر کرد DNS");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    break;

                case "404":
                    try
                    {
                        ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
                        ManagementObjectCollection moc = mc.GetInstances();
                        foreach (ManagementObject mo in moc)
                        {
                            if ((bool)mo["IPEnabled"])
                            {
                                ManagementBaseObject objdns = mo.GetMethodParameters("SetDNSServerSearchOrder");
                                if (objdns != null)
                                {
                                    string[] s = { "10.202.10.202", "10.202.10.102" };
                                    objdns["DNSServerSearchOrder"] = s;
                                    mo.InvokeMethod("SetDNSServerSearchOrder", objdns, null);

                                }
                            }
                        }
                        MessageBox.Show("! شما با موفقیت به 404 تغییر کرد DNS");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    break;

                case "Google":
                    try
                    {
                        ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
                        ManagementObjectCollection moc = mc.GetInstances();
                        foreach (ManagementObject mo in moc)
                        {
                            if ((bool)mo["IPEnabled"])
                            {
                                ManagementBaseObject objdns = mo.GetMethodParameters("SetDNSServerSearchOrder");
                                if (objdns != null)
                                {
                                    string[] s = { "8.8.8.8", "8.8.4.4" };
                                    objdns["DNSServerSearchOrder"] = s;
                                    mo.InvokeMethod("SetDNSServerSearchOrder", objdns, null);

                                }
                            }
                        }
                        MessageBox.Show("! شما با موفقیت تغییر کردDNS");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    break;
                default:
                    MessageBox.Show("در حال حاضر شما دی ان اسی انتخاب نکردید");

                    break;
            }
        }
    }
}
