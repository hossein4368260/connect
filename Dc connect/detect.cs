using System;
using System.Diagnostics;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Windows.Forms;


namespace Dc_connect
{
    public partial class detect : Form
    {
        public detect()
        {
            InitializeComponent();
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

          
	       

        }

     

        private void button3_Click_1(object sender, EventArgs e)
        {
	        Process p = new Process();
	        ProcessStartInfo startInfo = new ProcessStartInfo("..\\..\\bat\\red.bat");
	        startInfo.Verb = "runas";
	        //go to user -> Administrator and then to file C:\\Info.bat (not working)
	        startInfo.Arguments = "..\\..\\bat\\red.bat";
	        //  startInfo.Password = pass;
	        startInfo.UseShellExecute = false;
	        p.StartInfo = startInfo;
	        // save all output data to string
	        p.Start();
        }

        private void تنظیماتولیهToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
	        textBox3.Visible = false;
        }

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
	        // admin password with secure string
	        //var pass = new SecureString();
	        //pass.AppendChar('p');
	        //pass.AppendChar('a');
	        //pass.AppendChar('s');
	        //pass.AppendChar('s');

	        Process p = new Process();
	        ProcessStartInfo startInfo = new ProcessStartInfo("..\\..\\bat\\blue.bat");
	        startInfo.Verb = "runas";

	        //go to user -> Administrator and then to file C:\\Info.bat (not working)
	        startInfo.Arguments = "..\\..\\bat\\blue.bat";
	        //  startInfo.Password = pass;
	        startInfo.UseShellExecute = false;
	        p.StartInfo = startInfo;

	        // save all output data to string
	        p.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
	        Ping png = new Ping();
	        PingReply pr = null;
	        pr = png.Send(/*textBox4.Text*/"20.30.40.71", 10000);

	        if (pr.Status == IPStatus.Success)
	        {
		        label4.Text = "اتصال قرمز برقرار شد";
	        }
        }
    }
}
