using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace TaskManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Process[] processes;

        private void GetAllProcess()
        {
            // processes = Process.GetProcesses();

        // Only the current user's processes:
            Process[] runningProcesses = Process.GetProcesses();
            var currentSessionID = Process.GetCurrentProcess().SessionId;
            processes = runningProcesses.Where(p => p.SessionId == currentSessionID).ToArray();

            if (Convert.ToInt32(label_NumberOfProc.Text) != processes.Length)
            {
                listView_Tasks.Items.Clear();
                foreach (Process process in processes)
                {
                    ListViewItem lvi = new ListViewItem(process.Id.ToString());
                    lvi.SubItems.Add(process.ProcessName);
                    lvi.SubItems.Add(String.Format("{0:N0}", process.WorkingSet64));
                    listView_Tasks.Items.Add(lvi);
                }
                label_NumberOfProc.Text = processes.Length.ToString();
            }
        }

        private void EndTask()
        {
            try
            {
                int pid = Convert.ToInt32(listView_Tasks.SelectedItems[0].SubItems[0].Text);
                Process proc = Process.GetProcessById(pid);
                proc.Kill();
                GetAllProcess();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetAllProcess();
        }

        private void RunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(form_RunTask form = new form_RunTask())
            {
                if (form.ShowDialog() == DialogResult.OK)
                    GetAllProcess();
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            GetAllProcess();
        }

        private void Button_EndTask_Click(object sender, EventArgs e)
        {
            if (listView_Tasks.SelectedItems.Count != 0)
            {
                EndTask(); 
            }
        }

        private void EndContextMenuStripItem_Click(object sender, EventArgs e)
        {
            EndTask();
        }

        private void ListView_Tasks_DoubleClick(object sender, EventArgs e)
        {
            if (listView_Tasks.SelectedItems.Count > 0)
            {
                ListViewItem item = listView_Tasks.SelectedItems[0];
                MessageBox.Show(item.SubItems[0].ToString());
            }
        }
    }
}
