namespace SystemUITuner
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label2 = new System.Windows.Forms.Label();
            this.devicesCombo = new System.Windows.Forms.ComboBox();
            this.refreshButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nfcCheck = new System.Windows.Forms.CheckBox();
            this.alarmCheck = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.clockCombo = new System.Windows.Forms.ComboBox();
            this.batteryCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.airplaneCheck = new System.Windows.Forms.CheckBox();
            this.mobileCheck = new System.Windows.Forms.CheckBox();
            this.ethernetCheck = new System.Windows.Forms.CheckBox();
            this.wifiCheck = new System.Windows.Forms.CheckBox();
            this.volumeCheck = new System.Windows.Forms.CheckBox();
            this.zenCheck = new System.Windows.Forms.CheckBox();
            this.bluetoothCheck = new System.Windows.Forms.CheckBox();
            this.hotspotCheck = new System.Windows.Forms.CheckBox();
            this.castCheck = new System.Windows.Forms.CheckBox();
            this.managedCheck = new System.Windows.Forms.CheckBox();
            this.headsetCheck = new System.Windows.Forms.CheckBox();
            this.rotateCheck = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.volumeSilentCheck = new System.Windows.Forms.CheckBox();
            this.showZenCheck = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.importanceCheck = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Devices";
            // 
            // devicesCombo
            // 
            this.devicesCombo.Enabled = false;
            this.devicesCombo.FormattingEnabled = true;
            this.devicesCombo.Location = new System.Drawing.Point(16, 31);
            this.devicesCombo.Name = "devicesCombo";
            this.devicesCombo.Size = new System.Drawing.Size(338, 21);
            this.devicesCombo.TabIndex = 1;
            this.devicesCombo.SelectedIndexChanged += new System.EventHandler(this.devicesCombo_SelectedIndexChanged);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(360, 30);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 2;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nfcCheck);
            this.groupBox1.Controls.Add(this.alarmCheck);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.clockCombo);
            this.groupBox1.Controls.Add(this.batteryCombo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.airplaneCheck);
            this.groupBox1.Controls.Add(this.mobileCheck);
            this.groupBox1.Controls.Add(this.ethernetCheck);
            this.groupBox1.Controls.Add(this.wifiCheck);
            this.groupBox1.Controls.Add(this.volumeCheck);
            this.groupBox1.Controls.Add(this.zenCheck);
            this.groupBox1.Controls.Add(this.bluetoothCheck);
            this.groupBox1.Controls.Add(this.hotspotCheck);
            this.groupBox1.Controls.Add(this.castCheck);
            this.groupBox1.Controls.Add(this.managedCheck);
            this.groupBox1.Controls.Add(this.headsetCheck);
            this.groupBox1.Controls.Add(this.rotateCheck);
            this.groupBox1.Location = new System.Drawing.Point(16, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 434);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status Bar";
            // 
            // nfcCheck
            // 
            this.nfcCheck.AutoSize = true;
            this.nfcCheck.Enabled = false;
            this.nfcCheck.Location = new System.Drawing.Point(6, 410);
            this.nfcCheck.Name = "nfcCheck";
            this.nfcCheck.Size = new System.Drawing.Size(100, 17);
            this.nfcCheck.TabIndex = 17;
            this.nfcCheck.Text = "NFC (Samsung)";
            this.nfcCheck.UseVisualStyleBackColor = true;
            this.nfcCheck.CheckedChanged += new System.EventHandler(this.statusBarCheck_CheckedChanged);
            // 
            // alarmCheck
            // 
            this.alarmCheck.AutoSize = true;
            this.alarmCheck.Enabled = false;
            this.alarmCheck.Location = new System.Drawing.Point(7, 346);
            this.alarmCheck.Name = "alarmCheck";
            this.alarmCheck.Size = new System.Drawing.Size(52, 17);
            this.alarmCheck.TabIndex = 16;
            this.alarmCheck.Text = "Alarm";
            this.alarmCheck.UseVisualStyleBackColor = true;
            this.alarmCheck.CheckedChanged += new System.EventHandler(this.statusBarCheck_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Time";
            // 
            // clockCombo
            // 
            this.clockCombo.Enabled = false;
            this.clockCombo.FormattingEnabled = true;
            this.clockCombo.Items.AddRange(new object[] {
            "Show hours, minutes, and seconds",
            "Show hours and minutes (default)",
            "Don\'t show this icon"});
            this.clockCombo.Location = new System.Drawing.Point(6, 382);
            this.clockCombo.Name = "clockCombo";
            this.clockCombo.Size = new System.Drawing.Size(194, 21);
            this.clockCombo.TabIndex = 14;
            this.clockCombo.SelectedIndexChanged += new System.EventHandler(this.clockCombo_SelectedIndexChanged);
            // 
            // batteryCombo
            // 
            this.batteryCombo.Enabled = false;
            this.batteryCombo.FormattingEnabled = true;
            this.batteryCombo.Items.AddRange(new object[] {
            "Always show percentage",
            "Show percentage when charging (default)",
            "Don\'t show this icon"});
            this.batteryCombo.Location = new System.Drawing.Point(7, 319);
            this.batteryCombo.Name = "batteryCombo";
            this.batteryCombo.Size = new System.Drawing.Size(193, 21);
            this.batteryCombo.TabIndex = 13;
            this.batteryCombo.SelectedIndexChanged += new System.EventHandler(this.batteryCombo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Battery";
            // 
            // airplaneCheck
            // 
            this.airplaneCheck.AutoSize = true;
            this.airplaneCheck.Enabled = false;
            this.airplaneCheck.Location = new System.Drawing.Point(7, 283);
            this.airplaneCheck.Name = "airplaneCheck";
            this.airplaneCheck.Size = new System.Drawing.Size(93, 17);
            this.airplaneCheck.TabIndex = 11;
            this.airplaneCheck.Text = "Airplane mode";
            this.airplaneCheck.UseVisualStyleBackColor = true;
            this.airplaneCheck.CheckedChanged += new System.EventHandler(this.statusBarCheck_CheckedChanged);
            // 
            // mobileCheck
            // 
            this.mobileCheck.AutoSize = true;
            this.mobileCheck.Enabled = false;
            this.mobileCheck.Location = new System.Drawing.Point(7, 259);
            this.mobileCheck.Name = "mobileCheck";
            this.mobileCheck.Size = new System.Drawing.Size(86, 17);
            this.mobileCheck.TabIndex = 10;
            this.mobileCheck.Text = "Cellular Data";
            this.mobileCheck.UseVisualStyleBackColor = true;
            this.mobileCheck.CheckedChanged += new System.EventHandler(this.statusBarCheck_CheckedChanged);
            // 
            // ethernetCheck
            // 
            this.ethernetCheck.AutoSize = true;
            this.ethernetCheck.Enabled = false;
            this.ethernetCheck.Location = new System.Drawing.Point(7, 235);
            this.ethernetCheck.Name = "ethernetCheck";
            this.ethernetCheck.Size = new System.Drawing.Size(66, 17);
            this.ethernetCheck.TabIndex = 9;
            this.ethernetCheck.Text = "Ethernet";
            this.ethernetCheck.UseVisualStyleBackColor = true;
            this.ethernetCheck.CheckedChanged += new System.EventHandler(this.statusBarCheck_CheckedChanged);
            // 
            // wifiCheck
            // 
            this.wifiCheck.AutoSize = true;
            this.wifiCheck.Enabled = false;
            this.wifiCheck.Location = new System.Drawing.Point(7, 211);
            this.wifiCheck.Name = "wifiCheck";
            this.wifiCheck.Size = new System.Drawing.Size(50, 17);
            this.wifiCheck.TabIndex = 8;
            this.wifiCheck.Text = "Wi-Fi";
            this.wifiCheck.UseVisualStyleBackColor = true;
            this.wifiCheck.CheckedChanged += new System.EventHandler(this.statusBarCheck_CheckedChanged);
            // 
            // volumeCheck
            // 
            this.volumeCheck.AutoSize = true;
            this.volumeCheck.Enabled = false;
            this.volumeCheck.Location = new System.Drawing.Point(7, 187);
            this.volumeCheck.Name = "volumeCheck";
            this.volumeCheck.Size = new System.Drawing.Size(61, 17);
            this.volumeCheck.TabIndex = 7;
            this.volumeCheck.Text = "Volume";
            this.volumeCheck.UseVisualStyleBackColor = true;
            this.volumeCheck.CheckedChanged += new System.EventHandler(this.statusBarCheck_CheckedChanged);
            // 
            // zenCheck
            // 
            this.zenCheck.AutoSize = true;
            this.zenCheck.Enabled = false;
            this.zenCheck.Location = new System.Drawing.Point(7, 163);
            this.zenCheck.Name = "zenCheck";
            this.zenCheck.Size = new System.Drawing.Size(92, 17);
            this.zenCheck.TabIndex = 6;
            this.zenCheck.Text = "Do not disturb";
            this.zenCheck.UseVisualStyleBackColor = true;
            this.zenCheck.CheckedChanged += new System.EventHandler(this.statusBarCheck_CheckedChanged);
            // 
            // bluetoothCheck
            // 
            this.bluetoothCheck.AutoSize = true;
            this.bluetoothCheck.Enabled = false;
            this.bluetoothCheck.Location = new System.Drawing.Point(7, 139);
            this.bluetoothCheck.Name = "bluetoothCheck";
            this.bluetoothCheck.Size = new System.Drawing.Size(71, 17);
            this.bluetoothCheck.TabIndex = 5;
            this.bluetoothCheck.Text = "Bluetooth";
            this.bluetoothCheck.UseVisualStyleBackColor = true;
            this.bluetoothCheck.CheckedChanged += new System.EventHandler(this.statusBarCheck_CheckedChanged);
            // 
            // hotspotCheck
            // 
            this.hotspotCheck.AutoSize = true;
            this.hotspotCheck.Enabled = false;
            this.hotspotCheck.Location = new System.Drawing.Point(7, 115);
            this.hotspotCheck.Name = "hotspotCheck";
            this.hotspotCheck.Size = new System.Drawing.Size(63, 17);
            this.hotspotCheck.TabIndex = 4;
            this.hotspotCheck.Text = "Hotspot";
            this.hotspotCheck.UseVisualStyleBackColor = true;
            this.hotspotCheck.CheckedChanged += new System.EventHandler(this.statusBarCheck_CheckedChanged);
            // 
            // castCheck
            // 
            this.castCheck.AutoSize = true;
            this.castCheck.Enabled = false;
            this.castCheck.Location = new System.Drawing.Point(7, 91);
            this.castCheck.Name = "castCheck";
            this.castCheck.Size = new System.Drawing.Size(47, 17);
            this.castCheck.TabIndex = 3;
            this.castCheck.Text = "Cast";
            this.castCheck.UseVisualStyleBackColor = true;
            this.castCheck.CheckedChanged += new System.EventHandler(this.statusBarCheck_CheckedChanged);
            // 
            // managedCheck
            // 
            this.managedCheck.AutoSize = true;
            this.managedCheck.Enabled = false;
            this.managedCheck.Location = new System.Drawing.Point(7, 67);
            this.managedCheck.Name = "managedCheck";
            this.managedCheck.Size = new System.Drawing.Size(83, 17);
            this.managedCheck.TabIndex = 2;
            this.managedCheck.Text = "Work profile";
            this.managedCheck.UseVisualStyleBackColor = true;
            this.managedCheck.CheckedChanged += new System.EventHandler(this.statusBarCheck_CheckedChanged);
            // 
            // headsetCheck
            // 
            this.headsetCheck.AutoSize = true;
            this.headsetCheck.Enabled = false;
            this.headsetCheck.Location = new System.Drawing.Point(7, 43);
            this.headsetCheck.Name = "headsetCheck";
            this.headsetCheck.Size = new System.Drawing.Size(66, 17);
            this.headsetCheck.TabIndex = 1;
            this.headsetCheck.Text = "Headset";
            this.headsetCheck.UseVisualStyleBackColor = true;
            this.headsetCheck.CheckedChanged += new System.EventHandler(this.statusBarCheck_CheckedChanged);
            // 
            // rotateCheck
            // 
            this.rotateCheck.AutoSize = true;
            this.rotateCheck.Enabled = false;
            this.rotateCheck.Location = new System.Drawing.Point(7, 20);
            this.rotateCheck.Name = "rotateCheck";
            this.rotateCheck.Size = new System.Drawing.Size(113, 17);
            this.rotateCheck.TabIndex = 0;
            this.rotateCheck.Text = "Auto-rotate screen";
            this.rotateCheck.UseVisualStyleBackColor = true;
            this.rotateCheck.CheckedChanged += new System.EventHandler(this.statusBarCheck_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.volumeSilentCheck);
            this.groupBox2.Controls.Add(this.showZenCheck);
            this.groupBox2.Location = new System.Drawing.Point(229, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(206, 66);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Do not disturb";
            // 
            // volumeSilentCheck
            // 
            this.volumeSilentCheck.AutoSize = true;
            this.volumeSilentCheck.Enabled = false;
            this.volumeSilentCheck.Location = new System.Drawing.Point(7, 43);
            this.volumeSilentCheck.Name = "volumeSilentCheck";
            this.volumeSilentCheck.Size = new System.Drawing.Size(140, 17);
            this.volumeSilentCheck.TabIndex = 1;
            this.volumeSilentCheck.Text = "Volume buttons shortcut";
            this.volumeSilentCheck.UseVisualStyleBackColor = true;
            this.volumeSilentCheck.CheckedChanged += new System.EventHandler(this.volumeSilentCheck_CheckedChanged);
            // 
            // showZenCheck
            // 
            this.showZenCheck.AutoSize = true;
            this.showZenCheck.Enabled = false;
            this.showZenCheck.Location = new System.Drawing.Point(7, 20);
            this.showZenCheck.Name = "showZenCheck";
            this.showZenCheck.Size = new System.Drawing.Size(147, 17);
            this.showZenCheck.TabIndex = 0;
            this.showZenCheck.Text = "Show with volume control";
            this.showZenCheck.UseVisualStyleBackColor = true;
            this.showZenCheck.CheckedChanged += new System.EventHandler(this.showZenCheck_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.importanceCheck);
            this.groupBox3.Location = new System.Drawing.Point(229, 130);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(206, 45);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Other";
            // 
            // importanceCheck
            // 
            this.importanceCheck.AutoSize = true;
            this.importanceCheck.Enabled = false;
            this.importanceCheck.Location = new System.Drawing.Point(7, 20);
            this.importanceCheck.Name = "importanceCheck";
            this.importanceCheck.Size = new System.Drawing.Size(150, 17);
            this.importanceCheck.TabIndex = 0;
            this.importanceCheck.Text = "Power notification controls";
            this.importanceCheck.UseVisualStyleBackColor = true;
            this.importanceCheck.CheckedChanged += new System.EventHandler(this.importanceCheck_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(306, 466);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Created by Steven Mattera";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(380, 453);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Version 1.1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(281, 479);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Using AndroidLib by Dan Wager";
            // 
            // Main
            // 
            this.ClientSize = new System.Drawing.Size(452, 507);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.devicesCombo);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "System UI Tuner";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.Shown += new System.EventHandler(this.Main_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox devicesCombo;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox alarmCheck;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox clockCombo;
        private System.Windows.Forms.ComboBox batteryCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox airplaneCheck;
        private System.Windows.Forms.CheckBox mobileCheck;
        private System.Windows.Forms.CheckBox ethernetCheck;
        private System.Windows.Forms.CheckBox wifiCheck;
        private System.Windows.Forms.CheckBox volumeCheck;
        private System.Windows.Forms.CheckBox zenCheck;
        private System.Windows.Forms.CheckBox bluetoothCheck;
        private System.Windows.Forms.CheckBox hotspotCheck;
        private System.Windows.Forms.CheckBox castCheck;
        private System.Windows.Forms.CheckBox managedCheck;
        private System.Windows.Forms.CheckBox headsetCheck;
        private System.Windows.Forms.CheckBox rotateCheck;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox volumeSilentCheck;
        private System.Windows.Forms.CheckBox showZenCheck;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox importanceCheck;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox nfcCheck;
    }
}

