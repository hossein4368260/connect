using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dc_connect111
{
    using Dc_connect;
    using System.Data;
    using System.Drawing;
    using System.Net.NetworkInformation;

    public class iphaye
	{
		public string kar1 = "192.168.0.20";
		public string kar2 = "192.168.0.22";
		public string kar3 = "192.168.0.24";
		public string n;
		public string nameip;
		public void switchIP()
		{

			switch (n)
			{

				case "192.168.0.82":
					nameip = "سازماندهی 1";
					break;
				case "192.168.0.86":
					nameip = "سازماندهی 2";
					break;
				case "192.168.0.84":
					nameip = "سازماندهی 3";
					break;
				case "192.168.0.20":
					nameip = "کارگزینی 1";
					break;
				case "192.168.0.22":
					nameip = "کارگزینی 2";
					break;
				case "192.168.0.24":
					nameip = "کارگزینی 3";
					break;
				case "192.168.0.70":
					nameip = "بایگانی 1";
					break;
				case "192.168.0.72":
					nameip = "بایگانی 2";
					break;
				default:
					//nameip = "  Not Found .... ";
					break;


			}

		}

		public string ipping;
        public bool ping(string Ip)
        {
            Ping png = new Ping();
            {
                PingReply pr = null;
                try
                {
                    pr = png.Send(Ip, 100);
                    if (pr.Status == IPStatus.Success)
                    {
	                    return true;
                    }
                    else
                    {
	                    return false;
                    }
                }


                catch
                {
	                return false;
                }
            }

        }
    }

}
