using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Timer = System.Timers.Timer;
using System.Timers;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Globalization;
using System.IO;
using System.IO.Ports;
using System.Diagnostics;
using System.Drawing.Printing;
using System.Runtime.InteropServices;
using System.Management;
using System.Text.RegularExpressions;
using Microsoft.Win32;

namespace YerIstasyonu_v3
{
    public partial class Form1 : Form
    {
        string[] portlar = SerialPort.GetPortNames();//portları çek pc'ye
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           foreach (string port in portlar)
            {
                comboBox1_port.Items.Add(port);//portları al
                comboBox1_port.SelectedIndex = 0;//baştan yazdır
            }
            comboBox2_baudrate.Items.Add("4800");
            comboBox2_baudrate.Items.Add("9600");
            comboBox2_baudrate.Items.Add("115200");
            comboBox2_baudrate.SelectedIndex = 1;
            label2_baglanti_durumu.Text = "Bağlantı kapalı";
        }
        double temperature = 0, humidity = 0, pressure = 0, altitude = 0;
        double latitude = 0, longitude = 0, date = 0, time = 0;
        double gyrox = 0, gyroy = 0, gyroz = 0;

   

        double accelx = 0,accely = 0, accelz = 0;


        string[] gelen_veri;
        string gelen;
            

        public void Serial_Parse_Incoming_Datas(object sender, EventArgs e)
        {
            try
            {

                gelen = gelen.Replace("\r", "");
                gelen = gelen.Replace("\n", "");
                gelen = gelen.Replace("\0", "");
                int gelen_size = gelen.Length;
                gelen_veri = gelen.Split(',');
                if (gelen_veri[0].Equals("P1"))
                    {
                    if (gelen_size < 25) { return; }
                }
                else if (gelen_veri[0].Equals("P5"))
                {
                    if (gelen_size < 15) { return; }
                }
                else if (gelen_veri[0].Equals("P3"))
                    {
                    if (gelen_size < 35) { return; }
                }

                
                if (gelen_veri[0].Equals("P1"))//payload 1
                {
                    temperature = Convert.ToDouble(gelen_veri[1].Replace(".", ","));
                    humidity = Convert.ToDouble(gelen_veri[2].Replace(".", ","));
                    pressure = Convert.ToDouble(gelen_veri[3].Replace(".", ","));
                    altitude = Convert.ToDouble(gelen_veri[4].Replace(".", ","));
                    textBox1_sicaklik.Text = temperature.ToString();
                    textBox2_nem.Text = humidity.ToString();
                    textBox3_basinc.Text = pressure.ToString();
                    textBox4_irtifa.Text = altitude.ToString();

                }

                //elseif p2
                else if (gelen_veri[0].Equals("P5"))//payload2
                {
                    latitude = Convert.ToDouble(gelen_veri[1].Replace(".", ","));
                    longitude = Convert.ToDouble(gelen_veri[2].Replace(".", ","));
                    //date = Convert.ToDouble(gelen_veri[3].Replace(".", ","));
                    //time = Convert.ToDouble(gelen_veri[4].Replace(".", ","));
                    textBox1_enlem.Text = latitude.ToString();
                    textBox1_boylam.Text = longitude.ToString();
                    //textBox1_tarih.Text = date.ToString();
                    //textBox1_zaman.Text = time.ToString();
                }



                else if (gelen_veri[0].Equals("P3"))//Payload3
                {
                    accelx = Convert.ToDouble(gelen_veri[1].Replace(".", ","));
                    accely = Convert.ToDouble(gelen_veri[2].Replace(".", ","));
                    accelz = Convert.ToDouble(gelen_veri[3].Replace(".", ","));
                    gyrox = Convert.ToDouble(gelen_veri[4].Replace(".", ","));
                    gyroy = Convert.ToDouble(gelen_veri[5].Replace(".", ","));
                    gyroz = Convert.ToDouble(gelen_veri[6].Replace(".", ","));
                    textBox1_ivmex.Text = accelx.ToString();
                    textBox1_ivmey.Text = accely.ToString();
                    textBox1_ivmez.Text = accelz.ToString();
                    textBox1_gyrox.Text = gyrox.ToString();
                    textBox1_gyroy.Text = gyroy.ToString();
                    textBox1_gyroz.Text = gyroz.ToString();
                }
                

           
     

            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //timer1.Stop();

            }
           
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
             
        
                try
            {
                gelen = serialPort1.ReadLine();


                if (gelen.Equals(string.Empty))
                { return; }
                Invoke(new EventHandler(Serial_Parse_Incoming_Datas));
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata:" + hata.Message);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
           

            if (serialPort1.IsOpen == false)
            {
                if (comboBox1_port.Text == "")
                    return;
                serialPort1.PortName = comboBox1_port.Text;
                serialPort1.BaudRate = Convert.ToInt16(comboBox2_baudrate.Text); //int değere dönüştü string
               
                try
                {
                    serialPort1.Open();
                    timer1.Start();
                    label2_baglanti_durumu.Text = "Bağlantı Açık";
                }
                catch (Exception hata)
                {
                    MessageBox.Show(" Hata : " + hata.Message);

                }
            }

            }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Close();
                label2_baglanti_durumu.Text = "Bağlantı Kapalı";
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(serialPort1.IsOpen== true)
            {
                serialPort1.Close();
            }
        }
    }

        
    }

