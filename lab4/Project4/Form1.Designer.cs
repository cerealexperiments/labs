namespace Project2_4
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
            components = new System.ComponentModel.Container();
            menuStrip = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem = new ToolStripMenuItem();
            работаСКартинкойToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            normalToolStripMenuItem = new ToolStripMenuItem();
            stretchImageToolStripMenuItem = new ToolStripMenuItem();
            autoSizeToolStripMenuItem = new ToolStripMenuItem();
            centerImageToolStripMenuItem = new ToolStripMenuItem();
            zoomToolStripMenuItem = new ToolStripMenuItem();
            примерыРаботыToolStripMenuItem = new ToolStripMenuItem();
            toolStripTextBox1 = new ToolStripTextBox();
            toolStripComboBox1 = new ToolStripComboBox();
            pictureBox1 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label1 = new Label();
            label2 = new Label();
            menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, работаСКартинкойToolStripMenuItem, примерыРаботыToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(800, 28);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip";
            menuStrip.ItemClicked += menuStrip_ItemClicked;
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(59, 24);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // toolStripMenuItem
            // 
            toolStripMenuItem.Name = "toolStripMenuItem";
            toolStripMenuItem.Size = new Size(136, 26);
            toolStripMenuItem.Text = "Выход";
            toolStripMenuItem.Click += toolStripMenuItem_Click;
            // 
            // работаСКартинкойToolStripMenuItem
            // 
            работаСКартинкойToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2 });
            работаСКартинкойToolStripMenuItem.Name = "работаСКартинкойToolStripMenuItem";
            работаСКартинкойToolStripMenuItem.Size = new Size(159, 24);
            работаСКартинкойToolStripMenuItem.Text = "Работа с картинкой";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(284, 26);
            toolStripMenuItem1.Text = "Загрузить картинку с файла";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { normalToolStripMenuItem, stretchImageToolStripMenuItem, autoSizeToolStripMenuItem, centerImageToolStripMenuItem, zoomToolStripMenuItem });
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(284, 26);
            toolStripMenuItem2.Text = "Размещение картиники";
            // 
            // normalToolStripMenuItem
            // 
            normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            normalToolStripMenuItem.Size = new Size(181, 26);
            normalToolStripMenuItem.Text = "Normal";
            normalToolStripMenuItem.Click += normalToolStripMenuItem_Click;
            // 
            // stretchImageToolStripMenuItem
            // 
            stretchImageToolStripMenuItem.Name = "stretchImageToolStripMenuItem";
            stretchImageToolStripMenuItem.Size = new Size(181, 26);
            stretchImageToolStripMenuItem.Text = "StretchImage";
            stretchImageToolStripMenuItem.Click += stretchImageToolStripMenuItem_Click;
            // 
            // autoSizeToolStripMenuItem
            // 
            autoSizeToolStripMenuItem.Name = "autoSizeToolStripMenuItem";
            autoSizeToolStripMenuItem.Size = new Size(181, 26);
            autoSizeToolStripMenuItem.Text = "Auto Size";
            autoSizeToolStripMenuItem.Click += autoSizeToolStripMenuItem_Click;
            // 
            // centerImageToolStripMenuItem
            // 
            centerImageToolStripMenuItem.Name = "centerImageToolStripMenuItem";
            centerImageToolStripMenuItem.Size = new Size(181, 26);
            centerImageToolStripMenuItem.Text = "Center Image";
            centerImageToolStripMenuItem.Click += centerImageToolStripMenuItem_Click;
            // 
            // zoomToolStripMenuItem
            // 
            zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            zoomToolStripMenuItem.Size = new Size(181, 26);
            zoomToolStripMenuItem.Text = "Zoom";
            zoomToolStripMenuItem.Click += zoomToolStripMenuItem_Click;
            // 
            // примерыРаботыToolStripMenuItem
            // 
            примерыРаботыToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripTextBox1, toolStripComboBox1 });
            примерыРаботыToolStripMenuItem.Name = "примерыРаботыToolStripMenuItem";
            примерыРаботыToolStripMenuItem.Size = new Size(147, 24);
            примерыРаботыToolStripMenuItem.Text = "Примеры работы";
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(100, 27);
            toolStripTextBox1.TextChanged += toolStripTextBox1_TextChanged;
            // 
            // toolStripComboBox1
            // 
            toolStripComboBox1.Name = "toolStripComboBox1";
            toolStripComboBox1.Size = new Size(121, 28);
            toolStripComboBox1.DropDown += toolStripComboBox1_TextChanged;
            toolStripComboBox1.SelectedIndexChanged += toolStripComboBox1_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources._41a24d31b319e03ad021214a054f6fdf;
            pictureBox1.Location = new Point(12, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(338, 371);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(475, 103);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 2;
            label1.Text = "label1";
            label1.TextChanged += toolStripTextBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(538, 225);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 3;
            label2.Text = "label2";
            label2.TextChanged += toolStripComboBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private PictureBox pictureBox1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem работаСКартинкойToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem normalToolStripMenuItem;
        private ToolStripMenuItem stretchImageToolStripMenuItem;
        private ToolStripMenuItem autoSizeToolStripMenuItem;
        private ToolStripMenuItem centerImageToolStripMenuItem;
        private ToolStripMenuItem zoomToolStripMenuItem;
        private ToolStripMenuItem примерыРаботыToolStripMenuItem;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripComboBox toolStripComboBox1;
        private Label label1;
        private Label label2;
    }
}