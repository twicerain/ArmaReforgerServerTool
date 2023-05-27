﻿using System.Reflection;
using System.Text;

namespace ReforgerServerApp
{
    public partial class AboutBox : Form
    {
        public AboutBox()
        {
            InitializeComponent();
            StringBuilder sb = new();
            sb.AppendLine("Arma Reforger Dedicated Server Tool by soda3x");
            sb.AppendLine($"Version {Assembly.GetExecutingAssembly().GetName().Version}{Environment.NewLine}");
            aboutText.Text = sb.ToString();
        }

        private void ReportBtnPressed(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/soda3x/ArmaReforgerServerTool/issues");
        }

        private void OKBtnPressed(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
