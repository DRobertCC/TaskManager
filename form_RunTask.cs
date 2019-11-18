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

namespace TaskManager
{
    public partial class form_RunTask : Form
    {
        public form_RunTask()
        {
            InitializeComponent();
        }

        private void RunProcess()
        {
            if (!string.IsNullOrEmpty(textBox_Open.Text))
            {
                try
                {
                    Process process = new Process();
                    process.StartInfo.FileName = textBox_Open.Text;
                    process.Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Button_Run_Click(object sender, EventArgs e)
        {
            RunProcess();
        }
    }
}
