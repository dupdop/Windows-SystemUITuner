using RegawMOD.Android;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemUITuner
{
    public partial class Main : Form
    {
        BackgroundWorker deviceListWorker = new BackgroundWorker();
        AndroidController android;
        Device device;
        String user;
        bool loading = true;

        public Main()
        {
            InitializeComponent();

            deviceListWorker.DoWork += new DoWorkEventHandler(updateDeviceList);
            deviceListWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler((object s, RunWorkerCompletedEventArgs args) =>
            {
                devicesCombo.DataSource = args.Result;

                if (devicesCombo.DataSource != null)
                {
                    devicesCombo.Enabled = true;
                }
                else
                {
                    devicesCombo.Enabled = false;
                    devicesCombo.SelectedIndex = -1;
                }
            });
        }

        private void Main_Load(object sender, EventArgs e)
        {
            android = AndroidController.Instance;
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            deviceListWorker.RunWorkerAsync();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            android.Dispose();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            if (deviceListWorker.IsBusy)
            {
                return;
            }

            deviceListWorker.RunWorkerAsync();
        }

        private void devicesCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectDevice((String)devicesCombo.SelectedItem);
        }

        private void statusBarCheck_CheckedChanged(object sender, EventArgs e)
        {
            applyIconBlacklist();
        }

        private void batteryCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            applyIconBlacklist();
            applyBatteryPercentage();
        }

        private void clockCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            applyIconBlacklist();
            applyClockSeconds();
        }

        private void showZenCheck_CheckedChanged(object sender, EventArgs e)
        {
            applyShowZen();
        }

        private void volumeSilentCheck_CheckedChanged(object sender, EventArgs e)
        {
            applyVolumeShortcut();
        }

        private void importanceCheck_CheckedChanged(object sender, EventArgs e)
        {
            applyImportance();
        }

        private void updateDeviceList(object sender, DoWorkEventArgs e)
        {
            android.UpdateDeviceList();

            if (android.HasConnectedDevices)
            {
                e.Result = android.ConnectedDevices;
            }
            else
            {
                e.Result = null;
            }
        }

        private void selectDevice(String serial)
        {
            device = null;
            user = null;
            loading = true;
            android.UpdateDeviceList();

            if (android.HasConnectedDevices)
            {
                List<String> devices = android.ConnectedDevices;

                if (devices.Exists(x => (x == serial)))
                {
                    device = android.GetConnectedDevice(serial);
                }
            }

            if (device == null)
            {
                MessageBox.Show("The device you selected is no longer available.", "Device Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Error);

                rotateCheck.Enabled = false;
                headsetCheck.Enabled = false;
                managedCheck.Enabled = false;
                castCheck.Enabled = false;
                hotspotCheck.Enabled = false;
                bluetoothCheck.Enabled = false;
                zenCheck.Enabled = false;
                volumeCheck.Enabled = false;
                wifiCheck.Enabled = false;
                ethernetCheck.Enabled = false;
                mobileCheck.Enabled = false;
                airplaneCheck.Enabled = false;
                batteryCombo.Enabled = false;
                batteryCombo.SelectedIndex = -1;
                alarmCheck.Enabled = false;
                clockCombo.Enabled = false;
                clockCombo.SelectedIndex = -1;
                showZenCheck.Enabled = false;
                volumeSilentCheck.Enabled = false;
                importanceCheck.Enabled = false;
            }
            else
            {
                getCurrentSettings();

                rotateCheck.Enabled = true;
                headsetCheck.Enabled = true;
                managedCheck.Enabled = true;
                castCheck.Enabled = true;
                hotspotCheck.Enabled = true;
                bluetoothCheck.Enabled = true;
                zenCheck.Enabled = true;
                volumeCheck.Enabled = true;
                wifiCheck.Enabled = true;
                ethernetCheck.Enabled = true;
                mobileCheck.Enabled = true;
                airplaneCheck.Enabled = true;
                batteryCombo.Enabled = true;
                alarmCheck.Enabled = true;
                clockCombo.Enabled = true;
                showZenCheck.Enabled = true;
                volumeSilentCheck.Enabled = true;
                importanceCheck.Enabled = true;
            }

            loading = false;
        }

        private void getCurrentSettings()
        {
            StringReader reader;
            String line = null;

            // Get current user
            AdbCommand userCommand = Adb.FormAdbShellCommand(device, false, "pm", "list", "users");
            String userResults = Adb.ExecuteAdbCommand(userCommand);

            line = null;
            reader = new StringReader(userResults);
            do
            {
                line = reader.ReadLine();
                if (line != null && line.Contains("} running"))
                {
                    int index = line.IndexOf(':');
                    user = line.Substring(10, index - 10);
                    break;
                }
            }
            while (line != null);

            if (user != null)
            {
                // Get secure settings
                AdbCommand secureCommand = Adb.FormAdbShellCommand(device, false, "settings", "--user", user, "list", "secure");
                String secResults = Adb.ExecuteAdbCommand(secureCommand);

                line = null;
                reader = new StringReader(secResults);
                do
                {
                    line = reader.ReadLine();
                    if (line != null)
                    {
                        if (line.Contains("icon_blacklist"))
                        {
                            rotateCheck.Checked = !line.Contains("rotate");
                            headsetCheck.Checked = !line.Contains("headset");
                            managedCheck.Checked = !line.Contains("managed_profile");
                            castCheck.Checked = !line.Contains("cast");
                            hotspotCheck.Checked = !line.Contains("hotspot");
                            bluetoothCheck.Checked = !line.Contains("bluetooth");
                            zenCheck.Checked = !line.Contains("zen");
                            volumeCheck.Checked = !line.Contains("volume");
                            wifiCheck.Checked = !line.Contains("wifi");
                            ethernetCheck.Checked = !line.Contains("ethernet");
                            mobileCheck.Checked = !line.Contains("mobile");
                            airplaneCheck.Checked = !line.Contains("airplane");

                            if (line.Contains("battery"))
                            {
                                batteryCombo.SelectedIndex = 2;
                            }
                            else
                            {
                                batteryCombo.SelectedIndex = 1;
                            }

                            alarmCheck.Checked = !line.Contains("alarm_clock");

                            if (line.Contains(",clock") || line.Contains("clock,") || line.Contains(" clock"))
                            {
                                clockCombo.SelectedIndex = 2;
                            }
                            else
                            {
                                clockCombo.SelectedIndex = 1;
                            }
                        }
                        else if (line.Contains("clock_seconds"))
                        {
                            if (line.Contains("1"))
                            {
                                clockCombo.SelectedIndex = 0;
                            }
                        }
                        else if (line.Contains("sysui_show_full_zen"))
                        {
                            showZenCheck.Checked = line.Contains("1");
                        }
                        else if (line.Contains("sysui_volume_up_silent") || line.Contains("sysui_volume_down_silent"))
                        {
                            volumeSilentCheck.Checked = line.Contains("1");
                        }
                        else if (line.Contains("show_importance_slider"))
                        {
                            importanceCheck.Checked = line.Contains("1");
                        }
                    }
                }
                while (line != null);

                // Get system settings
                AdbCommand systemCommand = Adb.FormAdbShellCommand(device, false, "settings", "--user", user, "list", "system");
                String sysResults = Adb.ExecuteAdbCommand(systemCommand);

                line = null;
                reader = new StringReader(sysResults);
                do
                {
                    line = reader.ReadLine();
                    if (line != null)
                    {
                        if (line.Contains("status_bar_show_battery_percent"))
                        {
                            if (line.Contains("1"))
                            {
                                batteryCombo.SelectedIndex = 0;
                            }
                        }
                    }
                }
                while (line != null);
            }
            else
            {
                MessageBox.Show("Unable to get the current logged in user.", "Unknown User", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void applyIconBlacklist()
        {
            if (user == null || loading)
            {
                return;
            }

            String value = "";

            if (!rotateCheck.Checked)
            {
                value += "rotate,";
            }

            if (!headsetCheck.Checked)
            {
                value += "headset,";
            }

            if (!managedCheck.Checked)
            {
                value += "managed_profile,";
            }

            if (!castCheck.Checked)
            {
                value += "cast,";
            }

            if (!hotspotCheck.Checked)
            {
                value += "hotspot,";
            }

            if (!bluetoothCheck.Checked)
            {
                value += "bluetooth,";
            }

            if (!zenCheck.Checked)
            {
                value += "zen,";
            }

            if (!volumeCheck.Checked)
            {
                value += "volume,";
            }

            if (!wifiCheck.Checked)
            {
                value += "wifi,";
            }

            if (!ethernetCheck.Checked)
            {
                value += "ethernet,";
            }

            if (!mobileCheck.Checked)
            {
                value += "mobile,";
            }

            if (!airplaneCheck.Checked)
            {
                value += "airplane,";
            }

            if (batteryCombo.SelectedIndex == 2)
            {
                value += "battery,";
            }

            if (!alarmCheck.Checked)
            {
                value += "alarm_clock,";
            }

            if (clockCombo.SelectedIndex == 2)
            {
                value += "clock,";
            }

            AdbCommand command;

            if (value.Length != 0)
            {
                value = value.Substring(0, value.Length - 1);
                command = Adb.FormAdbShellCommand(device, false, "settings", "--user", user, "put", "secure", "icon_blacklist", value);
            }
            else
            {
                command = Adb.FormAdbShellCommand(device, false, "settings", "--user", user, "delete", "secure", "icon_blacklist");
            }

            Adb.ExecuteAdbCommand(command);
        }

        private void applyBatteryPercentage()
        {
            if (user == null || loading)
            {
                return;
            }

            AdbCommand command;

            if (clockCombo.SelectedIndex == 0)
            {
                command = Adb.FormAdbShellCommand(device, false, "settings", "--user", user, "put", "system", "status_bar_show_battery_percent", "1");
            }
            else
            {
                command = Adb.FormAdbShellCommand(device, false, "settings", "--user", user, "delete", "system", "status_bar_show_battery_percent");
            }

            Adb.ExecuteAdbCommand(command);
        }

        private void applyClockSeconds()
        {
            if (user == null || loading)
            {
                return;
            }

            AdbCommand command;

            if (clockCombo.SelectedIndex == 0)
            {
                command = Adb.FormAdbShellCommand(device, false, "settings", "--user", user, "put", "secure", "clock_seconds", "1");
            }
            else
            {
                command = Adb.FormAdbShellCommand(device, false, "settings", "--user", user, "delete", "secure", "clock_seconds");
            }

            Adb.ExecuteAdbCommand(command);
        }

        private void applyShowZen()
        {
            if (user == null || loading)
            {
                return;
            }

            AdbCommand command;

            if (showZenCheck.Checked)
            {
                command = Adb.FormAdbShellCommand(device, false, "settings", "--user", user, "put", "secure", "sysui_show_full_zen", "1");
            }
            else
            {
                command = Adb.FormAdbShellCommand(device, false, "settings", "--user", user, "delete", "secure", "sysui_show_full_zen");
            }

            Adb.ExecuteAdbCommand(command);
        }

        private void applyVolumeShortcut()
        {
            if (user == null || loading)
            {
                return;
            }

            AdbCommand command1, command2;

            if (showZenCheck.Checked)
            {
                command1 = Adb.FormAdbShellCommand(device, false, "settings", "--user", user, "put", "secure", "sysui_volume_down_silent", "1");
                command2 = Adb.FormAdbShellCommand(device, false, "settings", "--user", user, "put", "secure", "sysui_volume_up_silent", "1");
            }
            else
            {
                command1 = Adb.FormAdbShellCommand(device, false, "settings", "--user", user, "delete", "secure", "sysui_volume_down_silent");
                command2 = Adb.FormAdbShellCommand(device, false, "settings", "--user", user, "delete", "secure", "sysui_volume_up_silent");
            }

            Adb.ExecuteAdbCommand(command1);
            Adb.ExecuteAdbCommand(command2);
        }

        private void applyImportance()
        {
            if (user == null || loading)
            {
                return;
            }

            AdbCommand command;

            if (importanceCheck.Checked)
            {
                command = Adb.FormAdbShellCommand(device, false, "settings", "--user", user, "put", "secure", "show_importance_slider", "1");
            }
            else
            {
                command = Adb.FormAdbShellCommand(device, false, "settings", "--user", user, "delete", "secure", "show_importance_slider");
            }

            Adb.ExecuteAdbCommand(command);
        }
    }
}
