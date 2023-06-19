namespace YerIstasyonu_v3
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBox1_port = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.comboBox2_baudrate = new System.Windows.Forms.ComboBox();
            this.button1_baslat = new System.Windows.Forms.Button();
            this.label2_baglanti_durumu = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2_durdur = new System.Windows.Forms.Button();
            this.label3_port_secin = new System.Windows.Forms.Label();
            this.label4_baudrate_secin = new System.Windows.Forms.Label();
            this.label5_sicaklik = new System.Windows.Forms.Label();
            this.textBox1_sicaklik = new System.Windows.Forms.TextBox();
            this.label6_nem = new System.Windows.Forms.Label();
            this.textBox2_nem = new System.Windows.Forms.TextBox();
            this.label7_basinc = new System.Windows.Forms.Label();
            this.textBox3_basinc = new System.Windows.Forms.TextBox();
            this.label8_irtifa = new System.Windows.Forms.Label();
            this.textBox4_irtifa = new System.Windows.Forms.TextBox();
            this.label1_enlem = new System.Windows.Forms.Label();
            this.label1_boylam = new System.Windows.Forms.Label();
            this.textBox1_enlem = new System.Windows.Forms.TextBox();
            this.textBox1_boylam = new System.Windows.Forms.TextBox();
            this.label1_ivmex = new System.Windows.Forms.Label();
            this.label1_ivmey = new System.Windows.Forms.Label();
            this.label1_ivmez = new System.Windows.Forms.Label();
            this.label1_gyrox = new System.Windows.Forms.Label();
            this.label1_gyroy = new System.Windows.Forms.Label();
            this.label1_gyroz = new System.Windows.Forms.Label();
            this.textBox1_ivmex = new System.Windows.Forms.TextBox();
            this.textBox1_ivmey = new System.Windows.Forms.TextBox();
            this.textBox1_ivmez = new System.Windows.Forms.TextBox();
            this.textBox1_gyrox = new System.Windows.Forms.TextBox();
            this.textBox1_gyroy = new System.Windows.Forms.TextBox();
            this.textBox1_gyroz = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1_port
            // 
            this.comboBox1_port.BackColor = System.Drawing.Color.Gold;
            this.comboBox1_port.FormattingEnabled = true;
            this.comboBox1_port.Location = new System.Drawing.Point(543, 41);
            this.comboBox1_port.Name = "comboBox1_port";
            this.comboBox1_port.Size = new System.Drawing.Size(190, 24);
            this.comboBox1_port.TabIndex = 0;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // comboBox2_baudrate
            // 
            this.comboBox2_baudrate.BackColor = System.Drawing.Color.Orange;
            this.comboBox2_baudrate.FormattingEnabled = true;
            this.comboBox2_baudrate.Location = new System.Drawing.Point(543, 105);
            this.comboBox2_baudrate.Name = "comboBox2_baudrate";
            this.comboBox2_baudrate.Size = new System.Drawing.Size(190, 24);
            this.comboBox2_baudrate.TabIndex = 1;
            // 
            // button1_baslat
            // 
            this.button1_baslat.BackColor = System.Drawing.Color.GreenYellow;
            this.button1_baslat.Location = new System.Drawing.Point(543, 151);
            this.button1_baslat.Name = "button1_baslat";
            this.button1_baslat.Size = new System.Drawing.Size(85, 32);
            this.button1_baslat.TabIndex = 2;
            this.button1_baslat.Text = "BAŞLA";
            this.button1_baslat.UseVisualStyleBackColor = false;
            this.button1_baslat.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2_baglanti_durumu
            // 
            this.label2_baglanti_durumu.AutoSize = true;
            this.label2_baglanti_durumu.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2_baglanti_durumu.Location = new System.Drawing.Point(312, 198);
            this.label2_baglanti_durumu.Name = "label2_baglanti_durumu";
            this.label2_baglanti_durumu.Size = new System.Drawing.Size(137, 16);
            this.label2_baglanti_durumu.TabIndex = 5;
            this.label2_baglanti_durumu.Text = "BAĞLANTI DURUMU";
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button2_durdur
            // 
            this.button2_durdur.BackColor = System.Drawing.Color.DarkRed;
            this.button2_durdur.ForeColor = System.Drawing.Color.White;
            this.button2_durdur.Location = new System.Drawing.Point(648, 151);
            this.button2_durdur.Name = "button2_durdur";
            this.button2_durdur.Size = new System.Drawing.Size(85, 32);
            this.button2_durdur.TabIndex = 6;
            this.button2_durdur.Text = "DUR";
            this.button2_durdur.UseVisualStyleBackColor = false;
            this.button2_durdur.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3_port_secin
            // 
            this.label3_port_secin.AutoSize = true;
            this.label3_port_secin.Location = new System.Drawing.Point(540, 22);
            this.label3_port_secin.Name = "label3_port_secin";
            this.label3_port_secin.Size = new System.Drawing.Size(48, 16);
            this.label3_port_secin.TabIndex = 8;
            this.label3_port_secin.Text = "PORT ";
            // 
            // label4_baudrate_secin
            // 
            this.label4_baudrate_secin.AutoSize = true;
            this.label4_baudrate_secin.Location = new System.Drawing.Point(540, 86);
            this.label4_baudrate_secin.Name = "label4_baudrate_secin";
            this.label4_baudrate_secin.Size = new System.Drawing.Size(82, 16);
            this.label4_baudrate_secin.TabIndex = 9;
            this.label4_baudrate_secin.Text = "BAUDRATE";
            // 
            // label5_sicaklik
            // 
            this.label5_sicaklik.AutoSize = true;
            this.label5_sicaklik.Location = new System.Drawing.Point(58, 29);
            this.label5_sicaklik.Name = "label5_sicaklik";
            this.label5_sicaklik.Size = new System.Drawing.Size(57, 16);
            this.label5_sicaklik.TabIndex = 10;
            this.label5_sicaklik.Text = "Sıcaklık:";
            // 
            // textBox1_sicaklik
            // 
            this.textBox1_sicaklik.BackColor = System.Drawing.Color.Bisque;
            this.textBox1_sicaklik.Location = new System.Drawing.Point(128, 23);
            this.textBox1_sicaklik.Name = "textBox1_sicaklik";
            this.textBox1_sicaklik.Size = new System.Drawing.Size(93, 22);
            this.textBox1_sicaklik.TabIndex = 12;
            // 
            // label6_nem
            // 
            this.label6_nem.AutoSize = true;
            this.label6_nem.Location = new System.Drawing.Point(58, 53);
            this.label6_nem.Name = "label6_nem";
            this.label6_nem.Size = new System.Drawing.Size(39, 16);
            this.label6_nem.TabIndex = 13;
            this.label6_nem.Text = "Nem:";
            // 
            // textBox2_nem
            // 
            this.textBox2_nem.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textBox2_nem.Location = new System.Drawing.Point(128, 50);
            this.textBox2_nem.Name = "textBox2_nem";
            this.textBox2_nem.Size = new System.Drawing.Size(93, 22);
            this.textBox2_nem.TabIndex = 14;
            // 
            // label7_basinc
            // 
            this.label7_basinc.AutoSize = true;
            this.label7_basinc.Location = new System.Drawing.Point(58, 79);
            this.label7_basinc.Name = "label7_basinc";
            this.label7_basinc.Size = new System.Drawing.Size(51, 16);
            this.label7_basinc.TabIndex = 15;
            this.label7_basinc.Text = "Basınç:";
            // 
            // textBox3_basinc
            // 
            this.textBox3_basinc.BackColor = System.Drawing.Color.RosyBrown;
            this.textBox3_basinc.Location = new System.Drawing.Point(128, 79);
            this.textBox3_basinc.Name = "textBox3_basinc";
            this.textBox3_basinc.Size = new System.Drawing.Size(93, 22);
            this.textBox3_basinc.TabIndex = 16;
            // 
            // label8_irtifa
            // 
            this.label8_irtifa.AutoSize = true;
            this.label8_irtifa.Location = new System.Drawing.Point(58, 108);
            this.label8_irtifa.Name = "label8_irtifa";
            this.label8_irtifa.Size = new System.Drawing.Size(34, 16);
            this.label8_irtifa.TabIndex = 17;
            this.label8_irtifa.Text = "İrtifa:";
            // 
            // textBox4_irtifa
            // 
            this.textBox4_irtifa.BackColor = System.Drawing.Color.YellowGreen;
            this.textBox4_irtifa.Location = new System.Drawing.Point(128, 108);
            this.textBox4_irtifa.Name = "textBox4_irtifa";
            this.textBox4_irtifa.Size = new System.Drawing.Size(92, 22);
            this.textBox4_irtifa.TabIndex = 18;
            // 
            // label1_enlem
            // 
            this.label1_enlem.AutoSize = true;
            this.label1_enlem.Location = new System.Drawing.Point(49, 280);
            this.label1_enlem.Name = "label1_enlem";
            this.label1_enlem.Size = new System.Drawing.Size(48, 16);
            this.label1_enlem.TabIndex = 19;
            this.label1_enlem.Text = "Enlem:";
            // 
            // label1_boylam
            // 
            this.label1_boylam.AutoSize = true;
            this.label1_boylam.Location = new System.Drawing.Point(49, 324);
            this.label1_boylam.Name = "label1_boylam";
            this.label1_boylam.Size = new System.Drawing.Size(56, 16);
            this.label1_boylam.TabIndex = 20;
            this.label1_boylam.Text = "Boylam:";
            // 
            // textBox1_enlem
            // 
            this.textBox1_enlem.BackColor = System.Drawing.Color.LightPink;
            this.textBox1_enlem.Location = new System.Drawing.Point(128, 277);
            this.textBox1_enlem.Name = "textBox1_enlem";
            this.textBox1_enlem.Size = new System.Drawing.Size(92, 22);
            this.textBox1_enlem.TabIndex = 23;
            // 
            // textBox1_boylam
            // 
            this.textBox1_boylam.BackColor = System.Drawing.Color.LightSkyBlue;
            this.textBox1_boylam.Location = new System.Drawing.Point(128, 321);
            this.textBox1_boylam.Name = "textBox1_boylam";
            this.textBox1_boylam.Size = new System.Drawing.Size(92, 22);
            this.textBox1_boylam.TabIndex = 24;
            // 
            // label1_ivmex
            // 
            this.label1_ivmex.AutoSize = true;
            this.label1_ivmex.Location = new System.Drawing.Point(538, 247);
            this.label1_ivmex.Name = "label1_ivmex";
            this.label1_ivmex.Size = new System.Drawing.Size(57, 16);
            this.label1_ivmex.TabIndex = 27;
            this.label1_ivmex.Text = "İvme_X :";
            // 
            // label1_ivmey
            // 
            this.label1_ivmey.AutoSize = true;
            this.label1_ivmey.Location = new System.Drawing.Point(538, 284);
            this.label1_ivmey.Name = "label1_ivmey";
            this.label1_ivmey.Size = new System.Drawing.Size(55, 16);
            this.label1_ivmey.TabIndex = 28;
            this.label1_ivmey.Text = "İvme_Y:";
            // 
            // label1_ivmez
            // 
            this.label1_ivmez.AutoSize = true;
            this.label1_ivmez.Location = new System.Drawing.Point(540, 314);
            this.label1_ivmez.Name = "label1_ivmez";
            this.label1_ivmez.Size = new System.Drawing.Size(54, 16);
            this.label1_ivmez.TabIndex = 29;
            this.label1_ivmez.Text = "İvme_Z:";
            // 
            // label1_gyrox
            // 
            this.label1_gyrox.AutoSize = true;
            this.label1_gyrox.Location = new System.Drawing.Point(540, 347);
            this.label1_gyrox.Name = "label1_gyrox";
            this.label1_gyrox.Size = new System.Drawing.Size(54, 16);
            this.label1_gyrox.TabIndex = 30;
            this.label1_gyrox.Text = "Gyro_X:";
            // 
            // label1_gyroy
            // 
            this.label1_gyroy.AutoSize = true;
            this.label1_gyroy.Location = new System.Drawing.Point(540, 379);
            this.label1_gyroy.Name = "label1_gyroy";
            this.label1_gyroy.Size = new System.Drawing.Size(55, 16);
            this.label1_gyroy.TabIndex = 31;
            this.label1_gyroy.Text = "Gyro_Y:";
            // 
            // label1_gyroz
            // 
            this.label1_gyroz.AutoSize = true;
            this.label1_gyroz.Location = new System.Drawing.Point(541, 408);
            this.label1_gyroz.Name = "label1_gyroz";
            this.label1_gyroz.Size = new System.Drawing.Size(54, 16);
            this.label1_gyroz.TabIndex = 32;
            this.label1_gyroz.Text = "Gyro_Z:";
            // 
            // textBox1_ivmex
            // 
            this.textBox1_ivmex.BackColor = System.Drawing.Color.PowderBlue;
            this.textBox1_ivmex.ForeColor = System.Drawing.Color.Black;
            this.textBox1_ivmex.Location = new System.Drawing.Point(601, 244);
            this.textBox1_ivmex.Name = "textBox1_ivmex";
            this.textBox1_ivmex.Size = new System.Drawing.Size(77, 22);
            this.textBox1_ivmex.TabIndex = 33;
            // 
            // textBox1_ivmey
            // 
            this.textBox1_ivmey.BackColor = System.Drawing.Color.PowderBlue;
            this.textBox1_ivmey.Location = new System.Drawing.Point(602, 277);
            this.textBox1_ivmey.Name = "textBox1_ivmey";
            this.textBox1_ivmey.Size = new System.Drawing.Size(75, 22);
            this.textBox1_ivmey.TabIndex = 34;
            // 
            // textBox1_ivmez
            // 
            this.textBox1_ivmez.BackColor = System.Drawing.Color.PowderBlue;
            this.textBox1_ivmez.Location = new System.Drawing.Point(603, 313);
            this.textBox1_ivmez.Name = "textBox1_ivmez";
            this.textBox1_ivmez.Size = new System.Drawing.Size(75, 22);
            this.textBox1_ivmez.TabIndex = 35;
            // 
            // textBox1_gyrox
            // 
            this.textBox1_gyrox.BackColor = System.Drawing.Color.MediumPurple;
            this.textBox1_gyrox.Location = new System.Drawing.Point(602, 344);
            this.textBox1_gyrox.Name = "textBox1_gyrox";
            this.textBox1_gyrox.Size = new System.Drawing.Size(76, 22);
            this.textBox1_gyrox.TabIndex = 36;
            // 
            // textBox1_gyroy
            // 
            this.textBox1_gyroy.BackColor = System.Drawing.Color.MediumPurple;
            this.textBox1_gyroy.Location = new System.Drawing.Point(601, 376);
            this.textBox1_gyroy.Name = "textBox1_gyroy";
            this.textBox1_gyroy.Size = new System.Drawing.Size(77, 22);
            this.textBox1_gyroy.TabIndex = 37;
            // 
            // textBox1_gyroz
            // 
            this.textBox1_gyroz.BackColor = System.Drawing.Color.MediumPurple;
            this.textBox1_gyroz.Location = new System.Drawing.Point(601, 408);
            this.textBox1_gyroz.Name = "textBox1_gyroz";
            this.textBox1_gyroz.Size = new System.Drawing.Size(77, 22);
            this.textBox1_gyroz.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 39;
            this.label1.Text = "Celcius";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 16);
            this.label2.TabIndex = 40;
            this.label2.Text = "%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 41;
            this.label3.Text = "hPa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(226, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 42;
            this.label4.Text = "Meter";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(145, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 43;
            this.label5.Text = "BME280";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(125, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 16);
            this.label6.TabIndex = 44;
            this.label6.Text = "Ublox M8N GPS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(684, 344);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 16);
            this.label7.TabIndex = 45;
            this.label7.Text = "m/s^2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(684, 376);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 16);
            this.label8.TabIndex = 46;
            this.label8.Text = "m/s^2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(684, 408);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 16);
            this.label9.TabIndex = 47;
            this.label9.Text = "m/s^2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(684, 247);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 16);
            this.label10.TabIndex = 48;
            this.label10.Text = "g";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(684, 284);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 16);
            this.label11.TabIndex = 49;
            this.label11.Text = "g";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(684, 313);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 16);
            this.label12.TabIndex = 50;
            this.label12.Text = "g";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(585, 214);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 16);
            this.label13.TabIndex = 51;
            this.label13.Text = "DFRobot BMX160";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 448);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1_gyroz);
            this.Controls.Add(this.textBox1_gyroy);
            this.Controls.Add(this.textBox1_gyrox);
            this.Controls.Add(this.textBox1_ivmez);
            this.Controls.Add(this.textBox1_ivmey);
            this.Controls.Add(this.textBox1_ivmex);
            this.Controls.Add(this.label1_gyroz);
            this.Controls.Add(this.label1_gyroy);
            this.Controls.Add(this.label1_gyrox);
            this.Controls.Add(this.label1_ivmez);
            this.Controls.Add(this.label1_ivmey);
            this.Controls.Add(this.label1_ivmex);
            this.Controls.Add(this.textBox1_boylam);
            this.Controls.Add(this.textBox1_enlem);
            this.Controls.Add(this.label1_boylam);
            this.Controls.Add(this.label1_enlem);
            this.Controls.Add(this.textBox4_irtifa);
            this.Controls.Add(this.label8_irtifa);
            this.Controls.Add(this.textBox3_basinc);
            this.Controls.Add(this.label7_basinc);
            this.Controls.Add(this.textBox2_nem);
            this.Controls.Add(this.label6_nem);
            this.Controls.Add(this.textBox1_sicaklik);
            this.Controls.Add(this.label5_sicaklik);
            this.Controls.Add(this.label4_baudrate_secin);
            this.Controls.Add(this.label3_port_secin);
            this.Controls.Add(this.button2_durdur);
            this.Controls.Add(this.label2_baglanti_durumu);
            this.Controls.Add(this.button1_baslat);
            this.Controls.Add(this.comboBox2_baudrate);
            this.Controls.Add(this.comboBox1_port);
            this.Name = "Form1";
            this.Text = "Yer İstasyonu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1_port;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox comboBox2_baudrate;
        private System.Windows.Forms.Button button1_baslat;
        private System.Windows.Forms.Label label2_baglanti_durumu;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button2_durdur;
        private System.Windows.Forms.Label label3_port_secin;
        private System.Windows.Forms.Label label4_baudrate_secin;
        private System.Windows.Forms.Label label5_sicaklik;
        private System.Windows.Forms.TextBox textBox1_sicaklik;
        private System.Windows.Forms.Label label6_nem;
        private System.Windows.Forms.TextBox textBox2_nem;
        private System.Windows.Forms.Label label7_basinc;
        private System.Windows.Forms.TextBox textBox3_basinc;
        private System.Windows.Forms.Label label8_irtifa;
        private System.Windows.Forms.TextBox textBox4_irtifa;
        private System.Windows.Forms.Label label1_enlem;
        private System.Windows.Forms.Label label1_boylam;
        private System.Windows.Forms.TextBox textBox1_enlem;
        private System.Windows.Forms.TextBox textBox1_boylam;
        private System.Windows.Forms.Label label1_ivmex;
        private System.Windows.Forms.Label label1_ivmey;
        private System.Windows.Forms.Label label1_ivmez;
        private System.Windows.Forms.Label label1_gyrox;
        private System.Windows.Forms.Label label1_gyroy;
        private System.Windows.Forms.Label label1_gyroz;
        private System.Windows.Forms.TextBox textBox1_ivmex;
        private System.Windows.Forms.TextBox textBox1_ivmey;
        private System.Windows.Forms.TextBox textBox1_ivmez;
        private System.Windows.Forms.TextBox textBox1_gyrox;
        private System.Windows.Forms.TextBox textBox1_gyroy;
        private System.Windows.Forms.TextBox textBox1_gyroz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}

