using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dc_connect
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void عملیاتپینگToolStripMenuItem_Click(object sender, EventArgs e)
        {
	        Form ping = new ping();
	        ping.Show();
        }

        private void عملیاتتغییرآیپیToolStripMenuItem_Click(object sender, EventArgs e)
        {
			Form ping =new detect();
			ping.Show();



        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
