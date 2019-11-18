namespace TaskManager
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_EndTask = new System.Windows.Forms.Button();
            this.label_Processes = new System.Windows.Forms.Label();
            this.label_NumberOfProc = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.endContextMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView_Tasks = new System.Windows.Forms.ListView();
            this.Pid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Memory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(622, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.runToolStripMenuItem.Text = "Run New Task";
            this.runToolStripMenuItem.Click += new System.EventHandler(this.RunToolStripMenuItem_Click);
            // 
            // button_EndTask
            // 
            this.button_EndTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_EndTask.Location = new System.Drawing.Point(501, 638);
            this.button_EndTask.Name = "button_EndTask";
            this.button_EndTask.Size = new System.Drawing.Size(99, 23);
            this.button_EndTask.TabIndex = 2;
            this.button_EndTask.Text = "End Task";
            this.button_EndTask.UseVisualStyleBackColor = true;
            this.button_EndTask.Click += new System.EventHandler(this.Button_EndTask_Click);
            // 
            // label_Processes
            // 
            this.label_Processes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_Processes.AutoSize = true;
            this.label_Processes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Processes.Location = new System.Drawing.Point(12, 641);
            this.label_Processes.Name = "label_Processes";
            this.label_Processes.Size = new System.Drawing.Size(99, 20);
            this.label_Processes.TabIndex = 3;
            this.label_Processes.Text = "Processes: ";
            // 
            // label_NumberOfProc
            // 
            this.label_NumberOfProc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_NumberOfProc.AutoSize = true;
            this.label_NumberOfProc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NumberOfProc.Location = new System.Drawing.Point(117, 641);
            this.label_NumberOfProc.Name = "label_NumberOfProc";
            this.label_NumberOfProc.Size = new System.Drawing.Size(18, 20);
            this.label_NumberOfProc.TabIndex = 4;
            this.label_NumberOfProc.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.endContextMenuStripItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(157, 28);
            // 
            // endContextMenuStripItem
            // 
            this.endContextMenuStripItem.Name = "endContextMenuStripItem";
            this.endContextMenuStripItem.Size = new System.Drawing.Size(156, 24);
            this.endContextMenuStripItem.Text = "End Process";
            this.endContextMenuStripItem.Click += new System.EventHandler(this.EndContextMenuStripItem_Click);
            // 
            // listView_Tasks
            // 
            this.listView_Tasks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_Tasks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Pid,
            this.PName,
            this.Memory});
            this.listView_Tasks.ContextMenuStrip = this.contextMenuStrip1;
            this.listView_Tasks.FullRowSelect = true;
            this.listView_Tasks.GridLines = true;
            this.listView_Tasks.HideSelection = false;
            this.listView_Tasks.Location = new System.Drawing.Point(0, 31);
            this.listView_Tasks.MultiSelect = false;
            this.listView_Tasks.Name = "listView_Tasks";
            this.listView_Tasks.Size = new System.Drawing.Size(622, 591);
            this.listView_Tasks.TabIndex = 5;
            this.listView_Tasks.UseCompatibleStateImageBehavior = false;
            this.listView_Tasks.View = System.Windows.Forms.View.Details;
            this.listView_Tasks.DoubleClick += new System.EventHandler(this.ListView_Tasks_DoubleClick);
            // 
            // Pid
            // 
            this.Pid.Text = "PID";
            // 
            // PName
            // 
            this.PName.Text = "Name";
            this.PName.Width = 250;
            // 
            // Memory
            // 
            this.Memory.Text = "Memory";
            this.Memory.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Memory.Width = 90;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 673);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.listView_Tasks);
            this.Controls.Add(this.label_NumberOfProc);
            this.Controls.Add(this.label_Processes);
            this.Controls.Add(this.button_EndTask);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(300, 400);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.Button button_EndTask;
        private System.Windows.Forms.Label label_Processes;
        private System.Windows.Forms.Label label_NumberOfProc;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem endContextMenuStripItem;
        private System.Windows.Forms.ListView listView_Tasks;
        private System.Windows.Forms.ColumnHeader Pid;
        private System.Windows.Forms.ColumnHeader PName;
        private System.Windows.Forms.ColumnHeader Memory;
    }
}

