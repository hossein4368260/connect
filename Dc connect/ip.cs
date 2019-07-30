using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
namespace Dc_connect
{
    public partial class ip : Form
    {
	    string hostName = Dns.GetHostName();
        
        public ip()
        {
            InitializeComponent();
        }

        // Retrive the Name of HOST  
      //  Console.WriteLine(hostName);
     //   Get the IP
     
     

    private void ip_Load(object sender, EventArgs e)
    {

	    string myIP = Dns.GetHostByName(hostName).AddressList[0].ToString();
        txtip.Text = myIP;

    }

}
}
