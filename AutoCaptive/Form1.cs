using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoCaptive
{
    public partial class Form1 : Form
    {
        private bool allowshowdisplay = false;

        public Form1()
        {
            InitializeComponent();
            Mainprocess.callBase();
        }

        protected override void SetVisibleCore(bool value)
        {
            base.SetVisibleCore(allowshowdisplay ? value : allowshowdisplay);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mainprocess.AppExit();
        }

        private void reLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mainprocess.callBase();
        }

        private void configureAccountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Configure_AC().ShowDialog();
        }
    }
}
