using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlackSpace
{
    public partial class SlackSpace : Form
    {
        DiskCluster diskCluster = new DiskCluster();
        public SlackSpace()
        {
            InitializeComponent();
        }

        private void chkUseDefaultSize_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkUseDefaultSize.Checked)
            {
                this.txtClusterSize.Text = "512";
                this.txtClusterSize.Enabled = false;
            } else
            {
                this.txtClusterSize.Enabled = true;
                this.txtClusterSize.Text = "";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculateSize_Click(object sender, EventArgs e)
        {
            clickCalculate();
        }

        private void clickCalculate()
        {
            double cluster = Convert.ToDouble(this.txtClusterSize.Text);
            double file = Convert.ToDouble(this.txtFileSize.Text);
            this.txtPhysicalSize.Text = diskCluster.calculatePhysicalSize(cluster, file) + "";
            this.txtNoOfCluster.Text = diskCluster.calculateClusterUsed(cluster, file) + "";
            this.txtSlackSpace.Text = diskCluster.calculateSlackSpace(cluster, file) + "";
            this.txtRamSlack.Text = diskCluster.calculateRamSlack(file) + "";
        }

        private void SlackSpace_Load(object sender, EventArgs e)
        {
            this.ActiveControl = this.txtClusterSize;
        }
    }
}
