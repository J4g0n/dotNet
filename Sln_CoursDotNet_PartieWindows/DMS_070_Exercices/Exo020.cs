using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMS_070_Exercices
{
    public partial class Exo020 : Form
    {
        public Exo020()
        {
            InitializeComponent();
        }

        private void Exo020_Load(object sender, EventArgs e)
        {
            IPAddress[] ipAddressLst = Dns.GetHostEntry(Dns.GetHostName()).AddressList;
            lbl_AddressIP.Text = ipAddressLst[ipAddressLst.Length - 1].ToString();
            lbl_NomMachine.Text = System.Environment.MachineName;
            lbl_NomReseau.Text = System.Net.NetworkInformation.IPGlobalProperties.GetIPGlobalProperties().DomainName;
            lbl_User.Text = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
        }
    }
}
