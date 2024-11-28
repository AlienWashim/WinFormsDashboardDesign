namespace SidebarDesign
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelTopBar = new Panel();
            buttonMaxi = new Button();
            panel2 = new Panel();
            button1 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            dashboardLayout = new FlowLayoutPanel();
            button2 = new Button();
            subMenu = new FlowLayoutPanel();
            button5 = new Button();
            button3 = new Button();
            button4 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            panel3 = new Panel();
            labelTest = new Label();
            panelTopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            dashboardLayout.SuspendLayout();
            subMenu.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panelTopBar
            // 
            panelTopBar.BackColor = Color.FromArgb(0, 0, 100);
            panelTopBar.Controls.Add(buttonMaxi);
            panelTopBar.Controls.Add(panel2);
            panelTopBar.Controls.Add(button1);
            panelTopBar.Controls.Add(label1);
            panelTopBar.Controls.Add(pictureBox1);
            panelTopBar.Dock = DockStyle.Top;
            panelTopBar.Location = new Point(0, 0);
            panelTopBar.Name = "panelTopBar";
            panelTopBar.Size = new Size(1332, 50);
            panelTopBar.TabIndex = 0;
            // 
            // buttonMaxi
            // 
            buttonMaxi.Dock = DockStyle.Right;
            buttonMaxi.Location = new Point(1213, 0);
            buttonMaxi.Name = "buttonMaxi";
            buttonMaxi.Size = new Size(66, 50);
            buttonMaxi.TabIndex = 4;
            buttonMaxi.Text = "M";
            buttonMaxi.UseVisualStyleBackColor = true;
            buttonMaxi.Click += buttonMaxi_Click;
            // 
            // panel2
            // 
            panel2.Location = new Point(285, 50);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 150);
            panel2.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.Brown;
            button1.Dock = DockStyle.Right;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1279, 0);
            button1.Name = "button1";
            button1.Size = new Size(53, 50);
            button1.TabIndex = 1;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(108, 11);
            label1.Name = "label1";
            label1.Size = new Size(248, 28);
            label1.TabIndex = 1;
            label1.Text = "Alien Verse | World of Alien";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(0, 0, 150);
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(6, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(83, 50);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Black;
            flowLayoutPanel1.Controls.Add(dashboardLayout);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 50);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(304, 663);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // dashboardLayout
            // 
            dashboardLayout.AutoSize = true;
            dashboardLayout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            dashboardLayout.BackColor = Color.FromArgb(64, 64, 64);
            dashboardLayout.Controls.Add(button2);
            dashboardLayout.Controls.Add(subMenu);
            dashboardLayout.Controls.Add(button6);
            dashboardLayout.Controls.Add(button7);
            dashboardLayout.Controls.Add(button8);
            dashboardLayout.Location = new Point(3, 3);
            dashboardLayout.Name = "dashboardLayout";
            dashboardLayout.Size = new Size(298, 660);
            dashboardLayout.TabIndex = 2;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 0, 64);
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ActiveCaption;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(3, 3);
            button2.Name = "button2";
            button2.Padding = new Padding(5, 0, 0, 0);
            button2.Size = new Size(292, 86);
            button2.TabIndex = 2;
            button2.Text = "Dashboard";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // subMenu
            // 
            subMenu.Controls.Add(button5);
            subMenu.Controls.Add(button3);
            subMenu.Controls.Add(button4);
            subMenu.Location = new Point(0, 92);
            subMenu.Margin = new Padding(0);
            subMenu.Name = "subMenu";
            subMenu.Size = new Size(295, 290);
            subMenu.TabIndex = 8;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(0, 0, 40);
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(3, 5);
            button5.Margin = new Padding(3, 5, 3, 5);
            button5.Name = "button5";
            button5.Padding = new Padding(5, 0, 0, 0);
            button5.Size = new Size(295, 89);
            button5.TabIndex = 7;
            button5.Text = "Menu";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(3, 102);
            button3.Name = "button3";
            button3.Padding = new Padding(8, 0, 0, 0);
            button3.Size = new Size(295, 89);
            button3.TabIndex = 5;
            button3.Text = "Sub Menu 1";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // button4
            // 
            button4.BackColor = Color.Black;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(3, 197);
            button4.Name = "button4";
            button4.Padding = new Padding(8, 0, 0, 0);
            button4.Size = new Size(295, 89);
            button4.TabIndex = 6;
            button4.Text = "Sub Menu 2";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(0, 0, 64);
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = SystemColors.ButtonHighlight;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(3, 387);
            button6.Margin = new Padding(3, 5, 3, 3);
            button6.Name = "button6";
            button6.Padding = new Padding(5, 0, 0, 0);
            button6.Size = new Size(292, 86);
            button6.TabIndex = 5;
            button6.Text = "About";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(0, 0, 64);
            button7.FlatStyle = FlatStyle.Flat;
            button7.ForeColor = SystemColors.ButtonHighlight;
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(3, 479);
            button7.Name = "button7";
            button7.Padding = new Padding(5, 0, 0, 0);
            button7.Size = new Size(292, 86);
            button7.TabIndex = 6;
            button7.Text = "Setting";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(0, 0, 64);
            button8.FlatStyle = FlatStyle.Flat;
            button8.ForeColor = SystemColors.ButtonHighlight;
            button8.Image = (Image)resources.GetObject("button8.Image");
            button8.ImageAlign = ContentAlignment.MiddleLeft;
            button8.Location = new Point(3, 571);
            button8.Name = "button8";
            button8.Padding = new Padding(5, 0, 0, 0);
            button8.Size = new Size(292, 86);
            button8.TabIndex = 7;
            button8.Text = "Logout";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(labelTest);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(304, 50);
            panel3.Name = "panel3";
            panel3.Size = new Size(1028, 663);
            panel3.TabIndex = 4;
            // 
            // labelTest
            // 
            labelTest.AutoSize = true;
            labelTest.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTest.Location = new Point(145, 238);
            labelTest.Name = "labelTest";
            labelTest.Size = new Size(326, 191);
            labelTest.TabIndex = 5;
            labelTest.Text = "Test";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1332, 713);
            Controls.Add(panel3);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panelTopBar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Sidebar Design";
            TransparencyKey = Color.FromArgb(192, 255, 255);
            panelTopBar.ResumeLayout(false);
            panelTopBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            dashboardLayout.ResumeLayout(false);
            subMenu.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTopBar;
        private PictureBox pictureBox1;
        private Label label1;
        private Button button1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button2;
        private FlowLayoutPanel dashboardLayout;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private FlowLayoutPanel subMenu;
        private Button button3;
        private Button button4;
        private Panel panel2;
        private Panel panel3;
        private Label labelTest;
        private Button buttonMaxi;
    }
}
