namespace WinFormsObserver
{
    partial class FormObserver
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
            label1 = new Label();
            listBoxPersons = new ListBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            listBoxBusted = new ListBox();
            label2 = new Label();
            label3 = new Label();
            button6 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(152, 9);
            label1.Name = "label1";
            label1.Size = new Size(332, 32);
            label1.TabIndex = 0;
            label1.Text = "Spies and dissidents Observer";
            // 
            // listBoxPersons
            // 
            listBoxPersons.FormattingEnabled = true;
            listBoxPersons.ItemHeight = 15;
            listBoxPersons.Location = new Point(12, 61);
            listBoxPersons.Name = "listBoxPersons";
            listBoxPersons.Size = new Size(164, 229);
            listBoxPersons.TabIndex = 1;
            listBoxPersons.SelectedIndexChanged += listBoxPersons_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Location = new Point(218, 61);
            button1.Name = "button1";
            button1.Size = new Size(196, 23);
            button1.TabIndex = 2;
            button1.Text = "Add Counterintelligence";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Location = new Point(218, 138);
            button2.Name = "button2";
            button2.Size = new Size(196, 23);
            button2.TabIndex = 3;
            button2.Text = "Add Secret Police";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Enabled = false;
            button3.Location = new Point(250, 222);
            button3.Name = "button3";
            button3.Size = new Size(130, 23);
            button3.TabIndex = 4;
            button3.Text = "Observe";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Enabled = false;
            button4.Location = new Point(221, 99);
            button4.Name = "button4";
            button4.Size = new Size(193, 23);
            button4.TabIndex = 5;
            button4.Text = "Remove Counterintelligence";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Enabled = false;
            button5.Location = new Point(218, 178);
            button5.Name = "button5";
            button5.Size = new Size(196, 23);
            button5.TabIndex = 6;
            button5.Text = "Remove Secret Police";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // listBoxBusted
            // 
            listBoxBusted.FormattingEnabled = true;
            listBoxBusted.ItemHeight = 15;
            listBoxBusted.Location = new Point(461, 61);
            listBoxBusted.Name = "listBoxBusted";
            listBoxBusted.Size = new Size(161, 229);
            listBoxBusted.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 43);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 9;
            label2.Text = "People";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(484, 43);
            label3.Name = "label3";
            label3.Size = new Size(113, 15);
            label3.TabIndex = 10;
            label3.Text = "Spies and Dissidents";
            // 
            // button6
            // 
            button6.Location = new Point(250, 267);
            button6.Name = "button6";
            button6.Size = new Size(128, 23);
            button6.TabIndex = 11;
            button6.Text = "Close";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // FormObserver
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 302);
            Controls.Add(button6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listBoxBusted);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBoxPersons);
            Controls.Add(label1);
            Name = "FormObserver";
            Text = "Observer";
            Load += FormObserver_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button3;
        private Button button2;
        private Button button1;
        private ListBox listBoxPersons;
        private Button button5;
        private Button button4;
        private ListBox listBoxBusted;
        private Label label2;
        private Label label3;
        private Button button6;
    }
}
