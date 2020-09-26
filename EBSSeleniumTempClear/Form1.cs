using System;
using System.Windows.Forms;
using System.IO;
namespace EBSSeleniumTempClear
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }
        EBSSeleniumTempClear clear = new EBSSeleniumTempClear();
        private void button1_Click(object sender, EventArgs e)
        {
            clear.seleniumCookiedelete(label1,richTextBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear.TempClear(label1,richTextBox1);
        }
    }
}
