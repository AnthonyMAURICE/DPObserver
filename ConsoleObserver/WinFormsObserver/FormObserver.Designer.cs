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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            labelCitizen = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            labelCheckCitizen = new Label();
            labelCheckTourist = new Label();
            errorProvider1 = new ErrorProvider(components);
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(104, 9);
            label1.Name = "label1";
            label1.Size = new Size(286, 32);
            label1.TabIndex = 0;
            label1.Text = "Welcome Prime Secretary";
            // 
            // labelCitizen
            // 
            labelCitizen.AutoSize = true;
            labelCitizen.Font = new Font("Segoe UI", 10F);
            labelCitizen.Location = new Point(25, 58);
            labelCitizen.Name = "labelCitizen";
            labelCitizen.Size = new Size(128, 19);
            labelCitizen.TabIndex = 1;
            labelCitizen.Text = "Enter citizen name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(341, 58);
            label2.Name = "label2";
            label2.Size = new Size(130, 19);
            label2.TabIndex = 2;
            label2.Text = "Enter tourist name :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(25, 92);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(130, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(341, 92);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(130, 23);
            textBox2.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(52, 134);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Test";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // labelCheckCitizen
            // 
            labelCheckCitizen.AutoSize = true;
            labelCheckCitizen.Location = new Point(25, 125);
            labelCheckCitizen.Name = "labelCheckCitizen";
            labelCheckCitizen.Size = new Size(0, 15);
            labelCheckCitizen.TabIndex = 6;
            // 
            // labelCheckTourist
            // 
            labelCheckTourist.AutoSize = true;
            labelCheckTourist.Location = new Point(341, 125);
            labelCheckTourist.Name = "labelCheckTourist";
            labelCheckTourist.Size = new Size(0, 15);
            labelCheckTourist.TabIndex = 7;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // button2
            // 
            button2.Location = new Point(369, 134);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 8;
            button2.Text = "Test";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FormObserver
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 203);
            Controls.Add(button2);
            Controls.Add(labelCheckTourist);
            Controls.Add(labelCheckCitizen);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(labelCitizen);
            Controls.Add(label1);
            Name = "FormObserver";
            Text = "Observer";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelCitizen;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Label labelCheckCitizen;
        private Label labelCheckTourist;
        private ErrorProvider errorProvider1;
        private Button button2;
    }
}
