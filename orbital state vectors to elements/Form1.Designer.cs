namespace orbital_state_vectors_to_elements
{
    partial class main_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_form));
            this.groupBox_input = new System.Windows.Forms.GroupBox();
            this.groupBox_V = new System.Windows.Forms.GroupBox();
            this.radioButton_kmPerSec = new System.Windows.Forms.RadioButton();
            this.radioButton_metresPerSecond = new System.Windows.Forms.RadioButton();
            this.label_Vz = new System.Windows.Forms.Label();
            this.textBox_Vz = new System.Windows.Forms.TextBox();
            this.label_Vy = new System.Windows.Forms.Label();
            this.textBox_Vy = new System.Windows.Forms.TextBox();
            this.label_Vx = new System.Windows.Forms.Label();
            this.textBox_Vx = new System.Windows.Forms.TextBox();
            this.groupBox_R = new System.Windows.Forms.GroupBox();
            this.radioButton_kilometres = new System.Windows.Forms.RadioButton();
            this.radioButton_metres = new System.Windows.Forms.RadioButton();
            this.label_Rz = new System.Windows.Forms.Label();
            this.textBox_Rz = new System.Windows.Forms.TextBox();
            this.label_Ry = new System.Windows.Forms.Label();
            this.textBox_Ry = new System.Windows.Forms.TextBox();
            this.label_Rx = new System.Windows.Forms.Label();
            this.textBox_Rx = new System.Windows.Forms.TextBox();
            this.groupBox_output = new System.Windows.Forms.GroupBox();
            this.radioButton_T_years = new System.Windows.Forms.RadioButton();
            this.radioButton_T_days = new System.Windows.Forms.RadioButton();
            this.radioButton_T_hours = new System.Windows.Forms.RadioButton();
            this.radioButton_T_min = new System.Windows.Forms.RadioButton();
            this.radioButton_T_sec = new System.Windows.Forms.RadioButton();
            this.label_T = new System.Windows.Forms.Label();
            this.textBox_T = new System.Windows.Forms.TextBox();
            this.textBox_LAN = new System.Windows.Forms.TextBox();
            this.textBox_a = new System.Windows.Forms.TextBox();
            this.textBox_i = new System.Windows.Forms.TextBox();
            this.textBox_MA = new System.Windows.Forms.TextBox();
            this.textBox_EA = new System.Windows.Forms.TextBox();
            this.textBox_omega = new System.Windows.Forms.TextBox();
            this.textBox_e = new System.Windows.Forms.TextBox();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_Calculate = new System.Windows.Forms.Button();
            this.groupBox_CentralBody = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox_nu = new System.Windows.Forms.TextBox();
            this.label_e = new System.Windows.Forms.Label();
            this.label_nu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox_input.SuspendLayout();
            this.groupBox_V.SuspendLayout();
            this.groupBox_R.SuspendLayout();
            this.groupBox_output.SuspendLayout();
            this.groupBox_CentralBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_input
            // 
            this.groupBox_input.Controls.Add(this.groupBox_V);
            this.groupBox_input.Controls.Add(this.groupBox_R);
            this.groupBox_input.Location = new System.Drawing.Point(12, 84);
            this.groupBox_input.Name = "groupBox_input";
            this.groupBox_input.Size = new System.Drawing.Size(290, 354);
            this.groupBox_input.TabIndex = 0;
            this.groupBox_input.TabStop = false;
            this.groupBox_input.Text = "State Vectors";
            // 
            // groupBox_V
            // 
            this.groupBox_V.Controls.Add(this.radioButton_kmPerSec);
            this.groupBox_V.Controls.Add(this.radioButton_metresPerSecond);
            this.groupBox_V.Controls.Add(this.label_Vz);
            this.groupBox_V.Controls.Add(this.textBox_Vz);
            this.groupBox_V.Controls.Add(this.label_Vy);
            this.groupBox_V.Controls.Add(this.textBox_Vy);
            this.groupBox_V.Controls.Add(this.label_Vx);
            this.groupBox_V.Controls.Add(this.textBox_Vx);
            this.groupBox_V.Location = new System.Drawing.Point(20, 180);
            this.groupBox_V.Name = "groupBox_V";
            this.groupBox_V.Size = new System.Drawing.Size(255, 153);
            this.groupBox_V.TabIndex = 1;
            this.groupBox_V.TabStop = false;
            this.groupBox_V.Text = "Velocity";
            // 
            // radioButton_kmPerSec
            // 
            this.radioButton_kmPerSec.AutoSize = true;
            this.radioButton_kmPerSec.Location = new System.Drawing.Point(164, 130);
            this.radioButton_kmPerSec.Name = "radioButton_kmPerSec";
            this.radioButton_kmPerSec.Size = new System.Drawing.Size(94, 17);
            this.radioButton_kmPerSec.TabIndex = 7;
            this.radioButton_kmPerSec.TabStop = true;
            this.radioButton_kmPerSec.Text = "kilometres/sec";
            this.radioButton_kmPerSec.UseVisualStyleBackColor = true;
            // 
            // radioButton_metresPerSecond
            // 
            this.radioButton_metresPerSecond.AutoSize = true;
            this.radioButton_metresPerSecond.Location = new System.Drawing.Point(32, 130);
            this.radioButton_metresPerSecond.Name = "radioButton_metresPerSecond";
            this.radioButton_metresPerSecond.Size = new System.Drawing.Size(78, 17);
            this.radioButton_metresPerSecond.TabIndex = 6;
            this.radioButton_metresPerSecond.TabStop = true;
            this.radioButton_metresPerSecond.Text = "metres/sec";
            this.radioButton_metresPerSecond.UseVisualStyleBackColor = true;
            // 
            // label_Vz
            // 
            this.label_Vz.AutoSize = true;
            this.label_Vz.Location = new System.Drawing.Point(7, 96);
            this.label_Vz.Name = "label_Vz";
            this.label_Vz.Size = new System.Drawing.Size(19, 13);
            this.label_Vz.TabIndex = 5;
            this.label_Vz.Text = "Vz";
            // 
            // textBox_Vz
            // 
            this.textBox_Vz.Location = new System.Drawing.Point(32, 93);
            this.textBox_Vz.Name = "textBox_Vz";
            this.textBox_Vz.Size = new System.Drawing.Size(217, 20);
            this.textBox_Vz.TabIndex = 4;
            // 
            // label_Vy
            // 
            this.label_Vy.AutoSize = true;
            this.label_Vy.Location = new System.Drawing.Point(7, 57);
            this.label_Vy.Name = "label_Vy";
            this.label_Vy.Size = new System.Drawing.Size(19, 13);
            this.label_Vy.TabIndex = 3;
            this.label_Vy.Text = "Vy";
            // 
            // textBox_Vy
            // 
            this.textBox_Vy.Location = new System.Drawing.Point(32, 54);
            this.textBox_Vy.Name = "textBox_Vy";
            this.textBox_Vy.Size = new System.Drawing.Size(217, 20);
            this.textBox_Vy.TabIndex = 2;
            // 
            // label_Vx
            // 
            this.label_Vx.AutoSize = true;
            this.label_Vx.Location = new System.Drawing.Point(7, 19);
            this.label_Vx.Name = "label_Vx";
            this.label_Vx.Size = new System.Drawing.Size(19, 13);
            this.label_Vx.TabIndex = 1;
            this.label_Vx.Text = "Vx";
            // 
            // textBox_Vx
            // 
            this.textBox_Vx.Location = new System.Drawing.Point(32, 19);
            this.textBox_Vx.Name = "textBox_Vx";
            this.textBox_Vx.Size = new System.Drawing.Size(217, 20);
            this.textBox_Vx.TabIndex = 0;
            // 
            // groupBox_R
            // 
            this.groupBox_R.Controls.Add(this.radioButton_kilometres);
            this.groupBox_R.Controls.Add(this.radioButton_metres);
            this.groupBox_R.Controls.Add(this.label_Rz);
            this.groupBox_R.Controls.Add(this.textBox_Rz);
            this.groupBox_R.Controls.Add(this.label_Ry);
            this.groupBox_R.Controls.Add(this.textBox_Ry);
            this.groupBox_R.Controls.Add(this.label_Rx);
            this.groupBox_R.Controls.Add(this.textBox_Rx);
            this.groupBox_R.Location = new System.Drawing.Point(20, 19);
            this.groupBox_R.Name = "groupBox_R";
            this.groupBox_R.Size = new System.Drawing.Size(255, 155);
            this.groupBox_R.TabIndex = 0;
            this.groupBox_R.TabStop = false;
            this.groupBox_R.Text = "Position";
            // 
            // radioButton_kilometres
            // 
            this.radioButton_kilometres.AutoSize = true;
            this.radioButton_kilometres.Location = new System.Drawing.Point(177, 117);
            this.radioButton_kilometres.Name = "radioButton_kilometres";
            this.radioButton_kilometres.Size = new System.Drawing.Size(72, 17);
            this.radioButton_kilometres.TabIndex = 7;
            this.radioButton_kilometres.TabStop = true;
            this.radioButton_kilometres.Text = "kilometres";
            this.radioButton_kilometres.UseVisualStyleBackColor = true;
            // 
            // radioButton_metres
            // 
            this.radioButton_metres.AutoSize = true;
            this.radioButton_metres.Location = new System.Drawing.Point(32, 117);
            this.radioButton_metres.Name = "radioButton_metres";
            this.radioButton_metres.Size = new System.Drawing.Size(56, 17);
            this.radioButton_metres.TabIndex = 6;
            this.radioButton_metres.TabStop = true;
            this.radioButton_metres.Text = "metres";
            this.radioButton_metres.UseVisualStyleBackColor = true;
            // 
            // label_Rz
            // 
            this.label_Rz.AutoSize = true;
            this.label_Rz.Location = new System.Drawing.Point(6, 94);
            this.label_Rz.Name = "label_Rz";
            this.label_Rz.Size = new System.Drawing.Size(20, 13);
            this.label_Rz.TabIndex = 5;
            this.label_Rz.Text = "Rz";
            // 
            // textBox_Rz
            // 
            this.textBox_Rz.Location = new System.Drawing.Point(32, 91);
            this.textBox_Rz.Name = "textBox_Rz";
            this.textBox_Rz.Size = new System.Drawing.Size(217, 20);
            this.textBox_Rz.TabIndex = 4;
            // 
            // label_Ry
            // 
            this.label_Ry.AutoSize = true;
            this.label_Ry.Location = new System.Drawing.Point(6, 57);
            this.label_Ry.Name = "label_Ry";
            this.label_Ry.Size = new System.Drawing.Size(20, 13);
            this.label_Ry.TabIndex = 3;
            this.label_Ry.Text = "Ry";
            // 
            // textBox_Ry
            // 
            this.textBox_Ry.Location = new System.Drawing.Point(32, 54);
            this.textBox_Ry.Name = "textBox_Ry";
            this.textBox_Ry.Size = new System.Drawing.Size(217, 20);
            this.textBox_Ry.TabIndex = 2;
            // 
            // label_Rx
            // 
            this.label_Rx.AutoSize = true;
            this.label_Rx.Location = new System.Drawing.Point(6, 22);
            this.label_Rx.Name = "label_Rx";
            this.label_Rx.Size = new System.Drawing.Size(20, 13);
            this.label_Rx.TabIndex = 1;
            this.label_Rx.Text = "Rx";
            // 
            // textBox_Rx
            // 
            this.textBox_Rx.Location = new System.Drawing.Point(32, 19);
            this.textBox_Rx.Name = "textBox_Rx";
            this.textBox_Rx.Size = new System.Drawing.Size(217, 20);
            this.textBox_Rx.TabIndex = 0;
            // 
            // groupBox_output
            // 
            this.groupBox_output.Controls.Add(this.label6);
            this.groupBox_output.Controls.Add(this.label5);
            this.groupBox_output.Controls.Add(this.label4);
            this.groupBox_output.Controls.Add(this.label3);
            this.groupBox_output.Controls.Add(this.label2);
            this.groupBox_output.Controls.Add(this.label1);
            this.groupBox_output.Controls.Add(this.label_nu);
            this.groupBox_output.Controls.Add(this.label_e);
            this.groupBox_output.Controls.Add(this.textBox_nu);
            this.groupBox_output.Controls.Add(this.radioButton_T_years);
            this.groupBox_output.Controls.Add(this.radioButton_T_days);
            this.groupBox_output.Controls.Add(this.radioButton_T_hours);
            this.groupBox_output.Controls.Add(this.radioButton_T_min);
            this.groupBox_output.Controls.Add(this.radioButton_T_sec);
            this.groupBox_output.Controls.Add(this.label_T);
            this.groupBox_output.Controls.Add(this.textBox_T);
            this.groupBox_output.Controls.Add(this.textBox_LAN);
            this.groupBox_output.Controls.Add(this.textBox_a);
            this.groupBox_output.Controls.Add(this.textBox_i);
            this.groupBox_output.Controls.Add(this.textBox_MA);
            this.groupBox_output.Controls.Add(this.textBox_EA);
            this.groupBox_output.Controls.Add(this.textBox_omega);
            this.groupBox_output.Controls.Add(this.textBox_e);
            this.groupBox_output.Controls.Add(this.button_Clear);
            this.groupBox_output.Controls.Add(this.button_Calculate);
            this.groupBox_output.Location = new System.Drawing.Point(325, 84);
            this.groupBox_output.Name = "groupBox_output";
            this.groupBox_output.Size = new System.Drawing.Size(318, 354);
            this.groupBox_output.TabIndex = 1;
            this.groupBox_output.TabStop = false;
            this.groupBox_output.Text = "Keplerian Elements";
            // 
            // radioButton_T_years
            // 
            this.radioButton_T_years.AutoSize = true;
            this.radioButton_T_years.Location = new System.Drawing.Point(264, 290);
            this.radioButton_T_years.Name = "radioButton_T_years";
            this.radioButton_T_years.Size = new System.Drawing.Size(52, 17);
            this.radioButton_T_years.TabIndex = 16;
            this.radioButton_T_years.TabStop = true;
            this.radioButton_T_years.Text = "Years";
            this.radioButton_T_years.UseVisualStyleBackColor = true;
            // 
            // radioButton_T_days
            // 
            this.radioButton_T_days.AutoSize = true;
            this.radioButton_T_days.Location = new System.Drawing.Point(209, 290);
            this.radioButton_T_days.Name = "radioButton_T_days";
            this.radioButton_T_days.Size = new System.Drawing.Size(49, 17);
            this.radioButton_T_days.TabIndex = 15;
            this.radioButton_T_days.TabStop = true;
            this.radioButton_T_days.Text = "Days";
            this.radioButton_T_days.UseVisualStyleBackColor = true;
            // 
            // radioButton_T_hours
            // 
            this.radioButton_T_hours.AutoSize = true;
            this.radioButton_T_hours.Location = new System.Drawing.Point(150, 290);
            this.radioButton_T_hours.Name = "radioButton_T_hours";
            this.radioButton_T_hours.Size = new System.Drawing.Size(53, 17);
            this.radioButton_T_hours.TabIndex = 14;
            this.radioButton_T_hours.TabStop = true;
            this.radioButton_T_hours.Text = "Hours";
            this.radioButton_T_hours.UseVisualStyleBackColor = true;
            // 
            // radioButton_T_min
            // 
            this.radioButton_T_min.AutoSize = true;
            this.radioButton_T_min.Location = new System.Drawing.Point(82, 290);
            this.radioButton_T_min.Name = "radioButton_T_min";
            this.radioButton_T_min.Size = new System.Drawing.Size(62, 17);
            this.radioButton_T_min.TabIndex = 13;
            this.radioButton_T_min.TabStop = true;
            this.radioButton_T_min.Text = "Minutes";
            this.radioButton_T_min.UseVisualStyleBackColor = true;
            this.radioButton_T_min.CheckedChanged += new System.EventHandler(this.radioButton_T_min_CheckedChanged);
            // 
            // radioButton_T_sec
            // 
            this.radioButton_T_sec.AutoSize = true;
            this.radioButton_T_sec.Location = new System.Drawing.Point(9, 290);
            this.radioButton_T_sec.Name = "radioButton_T_sec";
            this.radioButton_T_sec.Size = new System.Drawing.Size(67, 17);
            this.radioButton_T_sec.TabIndex = 12;
            this.radioButton_T_sec.TabStop = true;
            this.radioButton_T_sec.Text = "Seconds";
            this.radioButton_T_sec.UseVisualStyleBackColor = true;
            // 
            // label_T
            // 
            this.label_T.AutoSize = true;
            this.label_T.Location = new System.Drawing.Point(6, 316);
            this.label_T.Name = "label_T";
            this.label_T.Size = new System.Drawing.Size(50, 13);
            this.label_T.TabIndex = 11;
            this.label_T.Text = "Period, T";
            // 
            // textBox_T
            // 
            this.textBox_T.Location = new System.Drawing.Point(61, 313);
            this.textBox_T.Name = "textBox_T";
            this.textBox_T.Size = new System.Drawing.Size(251, 20);
            this.textBox_T.TabIndex = 10;
            // 
            // textBox_LAN
            // 
            this.textBox_LAN.Location = new System.Drawing.Point(172, 237);
            this.textBox_LAN.Name = "textBox_LAN";
            this.textBox_LAN.Size = new System.Drawing.Size(140, 20);
            this.textBox_LAN.TabIndex = 9;
            // 
            // textBox_a
            // 
            this.textBox_a.Location = new System.Drawing.Point(172, 210);
            this.textBox_a.Name = "textBox_a";
            this.textBox_a.Size = new System.Drawing.Size(140, 20);
            this.textBox_a.TabIndex = 8;
            // 
            // textBox_i
            // 
            this.textBox_i.Location = new System.Drawing.Point(172, 184);
            this.textBox_i.Name = "textBox_i";
            this.textBox_i.Size = new System.Drawing.Size(140, 20);
            this.textBox_i.TabIndex = 7;
            // 
            // textBox_MA
            // 
            this.textBox_MA.Location = new System.Drawing.Point(172, 158);
            this.textBox_MA.Name = "textBox_MA";
            this.textBox_MA.Size = new System.Drawing.Size(140, 20);
            this.textBox_MA.TabIndex = 6;
            // 
            // textBox_EA
            // 
            this.textBox_EA.Location = new System.Drawing.Point(172, 132);
            this.textBox_EA.Name = "textBox_EA";
            this.textBox_EA.Size = new System.Drawing.Size(140, 20);
            this.textBox_EA.TabIndex = 5;
            // 
            // textBox_omega
            // 
            this.textBox_omega.Location = new System.Drawing.Point(172, 106);
            this.textBox_omega.Name = "textBox_omega";
            this.textBox_omega.Size = new System.Drawing.Size(140, 20);
            this.textBox_omega.TabIndex = 4;
            // 
            // textBox_e
            // 
            this.textBox_e.Location = new System.Drawing.Point(172, 48);
            this.textBox_e.Name = "textBox_e";
            this.textBox_e.Size = new System.Drawing.Size(140, 20);
            this.textBox_e.TabIndex = 2;
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(178, 19);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(106, 23);
            this.button_Clear.TabIndex = 1;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // button_Calculate
            // 
            this.button_Calculate.Location = new System.Drawing.Point(6, 19);
            this.button_Calculate.Name = "button_Calculate";
            this.button_Calculate.Size = new System.Drawing.Size(141, 23);
            this.button_Calculate.TabIndex = 0;
            this.button_Calculate.Text = "Calculate";
            this.button_Calculate.UseVisualStyleBackColor = true;
            this.button_Calculate.Click += new System.EventHandler(this.button_Calculate_Click);
            // 
            // groupBox_CentralBody
            // 
            this.groupBox_CentralBody.Controls.Add(this.listBox1);
            this.groupBox_CentralBody.Location = new System.Drawing.Point(18, 12);
            this.groupBox_CentralBody.Name = "groupBox_CentralBody";
            this.groupBox_CentralBody.Size = new System.Drawing.Size(284, 68);
            this.groupBox_CentralBody.TabIndex = 2;
            this.groupBox_CentralBody.TabStop = false;
            this.groupBox_CentralBody.Text = "Central Body";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Earth",
            "Moon",
            "Sun",
            "Mars",
            "Phobos",
            "Deimos",
            "Jupiter",
            "Saturn",
            "Uranus",
            "Neptune",
            "Pluto",
            "Sedna",
            "Eris",
            "Alpha Centauri",
            "Sirius",
            "Betelgeuse",
            "Rigel",
            "CUSTOM"});
            this.listBox1.Location = new System.Drawing.Point(24, 17);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(248, 43);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBox_nu
            // 
            this.textBox_nu.Location = new System.Drawing.Point(172, 78);
            this.textBox_nu.Name = "textBox_nu";
            this.textBox_nu.Size = new System.Drawing.Size(140, 20);
            this.textBox_nu.TabIndex = 17;
            // 
            // label_e
            // 
            this.label_e.AutoSize = true;
            this.label_e.Location = new System.Drawing.Point(92, 51);
            this.label_e.Name = "label_e";
            this.label_e.Size = new System.Drawing.Size(74, 13);
            this.label_e.TabIndex = 18;
            this.label_e.Text = "Eccentricity, e";
            // 
            // label_nu
            // 
            this.label_nu.AutoSize = true;
            this.label_nu.Location = new System.Drawing.Point(83, 80);
            this.label_nu.Name = "label_nu";
            this.label_nu.Size = new System.Drawing.Size(83, 13);
            this.label_nu.TabIndex = 19;
            this.label_nu.Text = "True anomaly, ν";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Argument of Periapsis, ω";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Eccentric anomaly, E";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Mean Anomaly, M";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Orbital Inclination, i";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Semimajor axis, a";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Longitude of ascending node, Ω";
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 450);
            this.Controls.Add(this.groupBox_CentralBody);
            this.Controls.Add(this.groupBox_output);
            this.Controls.Add(this.groupBox_input);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "main_form";
            this.Text = "Orbital State Vectors to Keplerian Elements";
            this.groupBox_input.ResumeLayout(false);
            this.groupBox_V.ResumeLayout(false);
            this.groupBox_V.PerformLayout();
            this.groupBox_R.ResumeLayout(false);
            this.groupBox_R.PerformLayout();
            this.groupBox_output.ResumeLayout(false);
            this.groupBox_output.PerformLayout();
            this.groupBox_CentralBody.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_input;
        private System.Windows.Forms.GroupBox groupBox_output;
        private System.Windows.Forms.GroupBox groupBox_V;
        private System.Windows.Forms.GroupBox groupBox_R;
        private System.Windows.Forms.Label label_Ry;
        private System.Windows.Forms.TextBox textBox_Ry;
        private System.Windows.Forms.Label label_Rx;
        private System.Windows.Forms.TextBox textBox_Rx;
        private System.Windows.Forms.Label label_Rz;
        private System.Windows.Forms.TextBox textBox_Rz;
        private System.Windows.Forms.Label label_Vx;
        private System.Windows.Forms.TextBox textBox_Vx;
        private System.Windows.Forms.Label label_Vz;
        private System.Windows.Forms.TextBox textBox_Vz;
        private System.Windows.Forms.Label label_Vy;
        private System.Windows.Forms.TextBox textBox_Vy;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button_Calculate;
        private System.Windows.Forms.TextBox textBox_T;
        private System.Windows.Forms.TextBox textBox_LAN;
        private System.Windows.Forms.TextBox textBox_a;
        private System.Windows.Forms.TextBox textBox_i;
        private System.Windows.Forms.TextBox textBox_MA;
        private System.Windows.Forms.TextBox textBox_EA;
        private System.Windows.Forms.TextBox textBox_omega;
        private System.Windows.Forms.TextBox textBox_e;
        private System.Windows.Forms.RadioButton radioButton_kilometres;
        private System.Windows.Forms.RadioButton radioButton_metres;
        private System.Windows.Forms.RadioButton radioButton_metresPerSecond;
        private System.Windows.Forms.RadioButton radioButton_kmPerSec;
        private System.Windows.Forms.GroupBox groupBox_CentralBody;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label_T;
        private System.Windows.Forms.RadioButton radioButton_T_sec;
        private System.Windows.Forms.RadioButton radioButton_T_min;
        private System.Windows.Forms.RadioButton radioButton_T_hours;
        private System.Windows.Forms.RadioButton radioButton_T_days;
        private System.Windows.Forms.RadioButton radioButton_T_years;
        private System.Windows.Forms.TextBox textBox_nu;
        private System.Windows.Forms.Label label_e;
        private System.Windows.Forms.Label label_nu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

