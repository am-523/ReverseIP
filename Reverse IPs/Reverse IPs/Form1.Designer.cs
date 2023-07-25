namespace Reverse_IPs
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            tbInputFile = new TextBox();
            lvResults = new ListView();
            tbResults = new TextBox();
            tbThreads = new TextBox();
            label1 = new Label();
            lbIPs = new ListBox();
            button2 = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Location = new Point(12, 52);
            button1.Name = "button1";
            button1.Size = new Size(91, 28);
            button1.TabIndex = 0;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tbInputFile
            // 
            tbInputFile.BackColor = SystemColors.ButtonFace;
            tbInputFile.Location = new Point(109, 17);
            tbInputFile.Name = "tbInputFile";
            tbInputFile.ReadOnly = true;
            tbInputFile.Size = new Size(252, 23);
            tbInputFile.TabIndex = 1;
            // 
            // lvResults
            // 
            lvResults.Location = new Point(6, 22);
            lvResults.Name = "lvResults";
            lvResults.Size = new Size(337, 370);
            lvResults.TabIndex = 2;
            lvResults.UseCompatibleStateImageBehavior = false;
            lvResults.View = View.Details;
            // 
            // tbResults
            // 
            tbResults.Location = new Point(6, 22);
            tbResults.Multiline = true;
            tbResults.Name = "tbResults";
            tbResults.ScrollBars = ScrollBars.Vertical;
            tbResults.Size = new Size(337, 74);
            tbResults.TabIndex = 3;
            // 
            // tbThreads
            // 
            tbThreads.Location = new Point(159, 55);
            tbThreads.Name = "tbThreads";
            tbThreads.Size = new Size(100, 23);
            tbThreads.TabIndex = 4;
            tbThreads.Text = "100";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(109, 59);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 5;
            label1.Text = "Thread";
            // 
            // lbIPs
            // 
            lbIPs.FormattingEnabled = true;
            lbIPs.ItemHeight = 15;
            lbIPs.Location = new Point(772, 133);
            lbIPs.Name = "lbIPs";
            lbIPs.Size = new Size(201, 154);
            lbIPs.TabIndex = 6;
            // 
            // button2
            // 
            button2.Location = new Point(12, 12);
            button2.Name = "button2";
            button2.Size = new Size(91, 28);
            button2.TabIndex = 7;
            button2.Text = "Import";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lvResults);
            groupBox1.Location = new Point(12, 90);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(349, 398);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Result";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tbResults);
            groupBox2.Location = new Point(12, 494);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(349, 100);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Logs";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 606);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(lbIPs);
            Controls.Add(label1);
            Controls.Add(tbThreads);
            Controls.Add(tbInputFile);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reverse IP Lookup using API | blog.am-studio.dev";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox tbInputFile;
        private ListView lvResults;
        private TextBox tbResults;
        private TextBox tbThreads;
        private Label label1;
        private ListBox lbIPs;
        private Button button2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}