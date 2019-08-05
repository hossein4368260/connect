using System;
using System.Diagnostics;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Windows.Forms;
using Dc_connect111;


namespace Dc_connect
{
	public partial class detect : Form
	{
		public detect()
		{
			InitializeComponent();
		}

		public void pingzadan()
		{
			iphaye x1 = new iphaye();
			iphaye x = new iphaye();
			bool pingred = x.ping(textBox4.Text);
			bool pingblue = x1.ping(textBox5.Text);
			if (pingred || pingblue)
			{
				lxleror.Text = "شبکه متصل است ";
				pictureBox4.Visible = false;
				
			}
			else 
			{
				lxleror.Text = "کابل ها چک شود ";
				pictureBox4.Visible = true;
			}

        }
		public static string GetLocalIPAddress()
		{
			var host = Dns.GetHostEntry(Dns.GetHostName());
			foreach (var ip in host.AddressList)
			{
				if (ip.AddressFamily == AddressFamily.InterNetwork)
				{
					return ip.ToString();
				}
			}

			throw new Exception("Local IP Address Not Found!");

		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			Process p = new Process();
			ProcessStartInfo startInfo = new ProcessStartInfo("..\\..\\bat\\restip.bat");
			startInfo.Verb = "runas";

			//go to user -> Administrator and then to file C:\\Info.bat (not working)
			startInfo.Arguments = "..\\..\\bat\\restip.bat";
			//  startInfo.Password = pass;
			startInfo.UseShellExecute = false;
			p.StartInfo = startInfo;

			// save all output data to string
			p.Start();
		}

		private void detect_Load(object sender, EventArgs e)
		{
			timer1.Start();
			timer2.Start();
		}

		private void button3_Click_1(object sender, EventArgs e)
		{
			Process p = new Process();
			ProcessStartInfo startInfo = new ProcessStartInfo("..\\..\\bat\\red.bat");
			startInfo.Verb = "runas";
			startInfo.Arguments = "..\\..\\bat\\red.bat";
			startInfo.UseShellExecute = false;
			p.StartInfo = startInfo;
			// save all output data to string
			p.Start();
		}



		Ping ping = new Ping();


		private void timer1_Tick(object sender, EventArgs e)
		{
			label1.Text = GetLocalIPAddress();
			if (GetLocalIPAddress() == textBox1.Text)
			{
				pictureBox1.Visible = false;
				pictureBox2.Visible = true;
			}

			else if (GetLocalIPAddress() == textBox2.Text)
			{
				pictureBox1.Visible = true;
				pictureBox2.Visible = false;

			}
			else
			{
				pictureBox1.Visible = false;
				pictureBox2.Visible = false;
			}

	

		}

		private void button4_Click(object sender, EventArgs e)
		{
			Process p = new Process();
			ProcessStartInfo startInfo = new ProcessStartInfo("..\\..\\bat\\restip.bat");
			startInfo.Verb = "runas";

			//go to user -> Administrator and then to file C:\\Info.bat (not working)
			startInfo.Arguments = "..\\..\\bat\\restip.bat";
			//  startInfo.Password = pass;
			startInfo.UseShellExecute = false;
			p.StartInfo = startInfo;

			// save all output data to string
			p.Start();
		}

		private void button2_Click(object sender, EventArgs e)
		{


			Process p = new Process();
			ProcessStartInfo startInfo = new ProcessStartInfo("..\\..\\bat\\blue.bat");
			startInfo.Verb = "runas";

			startInfo.Arguments = "..\\..\\bat\\blue.bat";
			startInfo.UseShellExecute = false;
			p.StartInfo = startInfo;
			p.Start();
		}


        private void button5_Click(object sender, EventArgs e)
        {
	       

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
	     pingzadan();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
	        Process p = new Process();
	        ProcessStartInfo startInfo = new ProcessStartInfo("cmd.exe");
	        startInfo.Verb = "runas";

	        startInfo.Arguments = "/c ipconfig";
	        startInfo.UseShellExecute = false;
	        p.StartInfo = startInfo;
			
	        p.Start();
        }
    }
}