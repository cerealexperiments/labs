namespace Project2_2
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
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(30, 33);
            button1.Name = "button1";
            button1.Size = new Size(416, 77);
            button1.TabIndex = 0;
            button1.Text = "MessageBox.Show(string)";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(30, 132);
            button2.Name = "button2";
            button2.Size = new Size(416, 77);
            button2.TabIndex = 0;
            button2.Text = "MessageBox.Show(string, string)";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(30, 230);
            button3.Name = "button3";
            button3.Size = new Size(416, 77);
            button3.TabIndex = 0;
            button3.Text = "MessageBox.Show(string, string, MessageBoxButtons)";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(30, 330);
            button4.Name = "button4";
            button4.Size = new Size(416, 77);
            button4.TabIndex = 0;
            button4.Text = "MessageBox.Show(string, string, MessageBoxButtons, MessageBoxIcon)";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(461, 132);
            button5.Name = "button5";
            button5.Size = new Size(316, 77);
            button5.TabIndex = 0;
            button5.Text = "Вызов диалового окна";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}