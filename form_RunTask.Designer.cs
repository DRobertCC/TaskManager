﻿namespace TaskManager
{
    partial class form_RunTask
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Open = new System.Windows.Forms.TextBox();
            this.button_Run = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Open:";
            // 
            // textBox_Open
            // 
            this.textBox_Open.Location = new System.Drawing.Point(65, 12);
            this.textBox_Open.Name = "textBox_Open";
            this.textBox_Open.Size = new System.Drawing.Size(381, 22);
            this.textBox_Open.TabIndex = 1;
            // 
            // button_Run
            // 
            this.button_Run.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_Run.Location = new System.Drawing.Point(371, 49);
            this.button_Run.Name = "button_Run";
            this.button_Run.Size = new System.Drawing.Size(75, 23);
            this.button_Run.TabIndex = 2;
            this.button_Run.Text = "Run";
            this.button_Run.UseVisualStyleBackColor = true;
            this.button_Run.Click += new System.EventHandler(this.Button_Run_Click);
            // 
            // form_RunTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 83);
            this.Controls.Add(this.button_Run);
            this.Controls.Add(this.textBox_Open);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(480, 130);
            this.MinimumSize = new System.Drawing.Size(480, 130);
            this.Name = "form_RunTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Run New Task";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Open;
        private System.Windows.Forms.Button button_Run;
    }
}