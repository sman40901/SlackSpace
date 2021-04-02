
namespace SlackSpace
{
    partial class SlackSpace
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNotice = new System.Windows.Forms.TextBox();
            this.txtClusterSize = new System.Windows.Forms.TextBox();
            this.lblClusterSize = new System.Windows.Forms.Label();
            this.lblFileSize = new System.Windows.Forms.Label();
            this.txtFileSize = new System.Windows.Forms.TextBox();
            this.chkUseDefaultSize = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPhysicalSize = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSlackSpace = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRamSlack = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNoOfCluster = new System.Windows.Forms.TextBox();
            this.btnCalculateSize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNotice
            // 
            this.txtNotice.Location = new System.Drawing.Point(138, 3);
            this.txtNotice.Multiline = true;
            this.txtNotice.Name = "txtNotice";
            this.txtNotice.ReadOnly = true;
            this.txtNotice.Size = new System.Drawing.Size(358, 53);
            this.txtNotice.TabIndex = 0;
            this.txtNotice.Text = "File Related Space Calculator\r\nAll numbers entered should be the same unit\r\nAssum" +
    "tion : 512 Bytes Sector Size\r\n";
            // 
            // txtClusterSize
            // 
            this.txtClusterSize.Location = new System.Drawing.Point(138, 62);
            this.txtClusterSize.Name = "txtClusterSize";
            this.txtClusterSize.Size = new System.Drawing.Size(358, 20);
            this.txtClusterSize.TabIndex = 1;
            // 
            // lblClusterSize
            // 
            this.lblClusterSize.AutoSize = true;
            this.lblClusterSize.Location = new System.Drawing.Point(12, 65);
            this.lblClusterSize.Name = "lblClusterSize";
            this.lblClusterSize.Size = new System.Drawing.Size(90, 13);
            this.lblClusterSize.TabIndex = 2;
            this.lblClusterSize.Text = "Enter Cluster Size";
            // 
            // lblFileSize
            // 
            this.lblFileSize.AutoSize = true;
            this.lblFileSize.Location = new System.Drawing.Point(12, 91);
            this.lblFileSize.Name = "lblFileSize";
            this.lblFileSize.Size = new System.Drawing.Size(111, 13);
            this.lblFileSize.TabIndex = 4;
            this.lblFileSize.Text = "Enter Logical File Size";
            // 
            // txtFileSize
            // 
            this.txtFileSize.Location = new System.Drawing.Point(138, 88);
            this.txtFileSize.Name = "txtFileSize";
            this.txtFileSize.Size = new System.Drawing.Size(358, 20);
            this.txtFileSize.TabIndex = 3;
            // 
            // chkUseDefaultSize
            // 
            this.chkUseDefaultSize.AutoSize = true;
            this.chkUseDefaultSize.Location = new System.Drawing.Point(502, 65);
            this.chkUseDefaultSize.Name = "chkUseDefaultSize";
            this.chkUseDefaultSize.Size = new System.Drawing.Size(105, 17);
            this.chkUseDefaultSize.TabIndex = 2;
            this.chkUseDefaultSize.Text = "Use Default Size";
            this.chkUseDefaultSize.UseVisualStyleBackColor = true;
            this.chkUseDefaultSize.CheckedChanged += new System.EventHandler(this.chkUseDefaultSize_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Physical File Size";
            // 
            // txtPhysicalSize
            // 
            this.txtPhysicalSize.Location = new System.Drawing.Point(138, 114);
            this.txtPhysicalSize.Name = "txtPhysicalSize";
            this.txtPhysicalSize.Size = new System.Drawing.Size(358, 20);
            this.txtPhysicalSize.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Slack Space";
            // 
            // txtSlackSpace
            // 
            this.txtSlackSpace.Location = new System.Drawing.Point(138, 140);
            this.txtSlackSpace.Name = "txtSlackSpace";
            this.txtSlackSpace.Size = new System.Drawing.Size(358, 20);
            this.txtSlackSpace.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ram Slack";
            // 
            // txtRamSlack
            // 
            this.txtRamSlack.Location = new System.Drawing.Point(138, 166);
            this.txtRamSlack.Name = "txtRamSlack";
            this.txtRamSlack.Size = new System.Drawing.Size(358, 20);
            this.txtRamSlack.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Number of Cluster Used";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtNoOfCluster
            // 
            this.txtNoOfCluster.Location = new System.Drawing.Point(138, 192);
            this.txtNoOfCluster.Name = "txtNoOfCluster";
            this.txtNoOfCluster.Size = new System.Drawing.Size(358, 20);
            this.txtNoOfCluster.TabIndex = 8;
            // 
            // btnCalculateSize
            // 
            this.btnCalculateSize.Location = new System.Drawing.Point(502, 85);
            this.btnCalculateSize.Name = "btnCalculateSize";
            this.btnCalculateSize.Size = new System.Drawing.Size(75, 23);
            this.btnCalculateSize.TabIndex = 4;
            this.btnCalculateSize.Text = "&Calculate";
            this.btnCalculateSize.UseVisualStyleBackColor = true;
            this.btnCalculateSize.Click += new System.EventHandler(this.btnCalculateSize_Click);
            // 
            // SlackSpace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 333);
            this.Controls.Add(this.btnCalculateSize);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNoOfCluster);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRamSlack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSlackSpace);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPhysicalSize);
            this.Controls.Add(this.chkUseDefaultSize);
            this.Controls.Add(this.lblFileSize);
            this.Controls.Add(this.txtFileSize);
            this.Controls.Add(this.lblClusterSize);
            this.Controls.Add(this.txtClusterSize);
            this.Controls.Add(this.txtNotice);
            this.Name = "SlackSpace";
            this.Text = "Slack Space";
            this.Load += new System.EventHandler(this.SlackSpace_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNotice;
        private System.Windows.Forms.TextBox txtClusterSize;
        private System.Windows.Forms.Label lblClusterSize;
        private System.Windows.Forms.Label lblFileSize;
        private System.Windows.Forms.TextBox txtFileSize;
        private System.Windows.Forms.CheckBox chkUseDefaultSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPhysicalSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSlackSpace;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRamSlack;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNoOfCluster;
        private System.Windows.Forms.Button btnCalculateSize;
    }
}

