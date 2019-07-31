using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Windows.Forms;



namespace Dc_connect
{
    public partial class ping : Form
    {
        public ping()
        {
            InitializeComponent();
        }

        public void connect()
        {
	           // ghat.Text = "0";
		       // vasl.Text = "0";
            ghat.Text = listBox3.Items.Count.ToString();
	        vasl.Text = listBox2.Items.Count.ToString();
        }
        public void button1_Click(object sender, EventArgs e)
        {
	        #region CodeMain
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
         //   listBox3.Items.Clear();
        //    listBox4.Items.Clear();
       //     listBox5.Items.Clear();

            var dt = new DataTable();
            dt.Columns.Add(new DataColumn("URL", typeof(string)));
            var view = new DataView(dt);
            this.dataGridView1.DataSource = view;
            Ping png = new Ping();
            int i = 0;
            progressBar1.Maximum = listBox1.Items.Count;
            foreach (var item in listBox1.Items)
            {
                PingReply pr = null;
                int m = 0;
                dt.Rows.Add(new DataColumn(item.ToString(), typeof(string)));
                try
                {
                    m = dt.Rows.Count;
                    pr = png.Send(item.ToString(),100);
                    if  (pr.Status == IPStatus.Success)
                    {
	                   
                        listBox2.Items.Add(item);
                        listBox4.Items.Add(m.ToString());
                        listBox2.BackColor = Color.Green;
                    //    vasl.Text = listBox2.Items.Count.ToString();
				
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                    }
                    else
                    {
					
	                    listBox3.Items.Add(item);
                        listBox5.Items.Add(m.ToString());
                        listBox3.BackColor = Color.Red;
                    //    ghat.Text = listBox3.Items.Count.ToString();
						
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    }
                }

           
                catch
                {

                    listBox3.Items.Add(item);
	                listBox5.Items.Add(m.ToString());
	                listBox3.BackColor = Color.Red;
	          //    ghat.Text = listBox3.Items.Count.ToString();
					
	                dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
                i++;
                progressBar1.Value = i;
            }


            #endregion
		
            xpq = 100;
            timer2.Start();
			timer1.Stop();

        }
        internal void timer1_Tick(object sender, EventArgs e)
        {
			
            button1_Click(null, null);

        }
   
        private void timer1_Tick()
        {
            throw new NotImplementedException();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            listBox1.Items.Add(tx1.Text + "." + tx2.Text + "." + tx3.Text + "." + tx4.Text);
            timer1.Start();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void button6_Click(object sender, EventArgs e)
        {
	       	timer2.Stop();
            timer1.Stop();
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            listBox3.Items.Clear();
            ghat.Text = listBox3.Items.Count.ToString();
            vasl.Text = listBox2.Items.Count.ToString();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            listBox2.BackColor = Color.White;
            listBox3.BackColor = Color.White;
            listBox1.Items.Clear();
			listBox2.Items.Clear();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            listBox1.Items.AddRange(textBox1.Text.Split('\n'));
            timer1.Start();
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            button5_Click(null, null);
            timer1.Stop();
            int b = Convert.ToInt32(text8.Text);
            int a = Convert.ToInt32(tx4.Text);
            for (int i = Convert.ToInt32(text4.Text); i <= b; i++)
            {
                listBox1.Items.Add(text5.Text + "." + text6.Text + "." + text7.Text + "." + i.ToString());
            }
        }

        public void distlist()
        {
	        var items = listBox1.Items.OfType<string>().GroupBy(item => item).ToList();
	        var items2 = listBox2.Items.OfType<string>().GroupBy(item => item).ToList();
	        var items3 = listBox3.Items.OfType<string>().GroupBy(item => item).ToList();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            foreach (var item in items)
	        {
		        listBox1.Items.Add(item.Key);
	        }
			foreach (var item in items2)
	        {
		        listBox2.Items.Add(item.Key);
	        }
	        foreach (var item in items3)
	        {
		        listBox3.Items.Add(item.Key);
	        }
        }

        private void button2_Click(object sender, EventArgs e)
        {
			distlist();
        }

       private int xpq = 100;
        private void timer2_Tick(object sender, EventArgs e)
        {
	       distlist();
		   connect();
		   
                --xpq;
		        button1.Text = "...."+xpq.ToString()+"....";
		        if (xpq == 0)
		        {
			        timer2.Stop();
					listBox2.Items.Clear();
					listBox3.Items.Clear();
                    timer1.Start();
					
		        }


        }
    }

}
