using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Change_plane_dv_calculator
{
    public partial class FrmAbout : Form
    {
        public FrmAbout() {
            InitializeComponent();
        }

        private void WebsiteLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            e.Link.LinkData = "https://www.marcomatta.com";
            Process.Start(e.Link.LinkData as string);
        }
    }
}
