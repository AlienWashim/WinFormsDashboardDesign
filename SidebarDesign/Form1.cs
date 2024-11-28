namespace SidebarDesign
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            subMenu.Height = 90;

            // Attach mouse event handlers for the panelTopBar
            panelTopBar.MouseDown += panelTopBar_MouseDown;
            panelTopBar.MouseMove += panelTopBar_MouseMove;
            panelTopBar.MouseUp += panelTopBar_MouseUp;
        }
        // Declare variables to track the mouse position relative to the form
        private int mouseX;
        private int mouseY;
        private bool isDragging = false;

        // This will handle when the mouse is pressed down on the panel
        private void panelTopBar_MouseDown(object sender, MouseEventArgs e)
        {
            // Set the dragging flag to true and capture the mouse position
            isDragging = true;
            mouseX = e.X;
            mouseY = e.Y;
        }

        // This will handle when the mouse is moved on the panel
        private void panelTopBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                // Calculate the new position of the form and set it
                this.Location = new Point(this.Left + (e.X - mouseX), this.Top + (e.Y - mouseY));
            }
        }

        // This will handle when the mouse is released
        private void panelTopBar_MouseUp(object sender, MouseEventArgs e)
        {
            // Stop the dragging when the mouse is released
            isDragging = false;
        }


        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void ActiveMenu(string buttonName)
        {
            // Define colors for active and normal state
            Color normalColor = Color.FromArgb(0, 0, 64); // Normal color: RGB (0, 0, 64)
            Color activeColor = Color.FromArgb(0, 0, 150); // Active color: RGB (0, 0, 100)

            // Reset all buttons to normal color
            button2.BackColor = normalColor;
            button3.BackColor = Color.Black;
            button4.BackColor = Color.Black;
            button5.BackColor = normalColor;
            button6.BackColor = normalColor;
            button7.BackColor = normalColor;
            button8.BackColor = normalColor;
            // Add more buttons here as needed

            // Check which button is being clicked and set its color to active
            if (buttonName == "button5")
            {
                button5.BackColor = activeColor;
            }
            else if (buttonName == "button2")
            {
                button2.BackColor = activeColor;
            }
            else if (buttonName == "button3")
            {
                button5.BackColor = activeColor;
                button3.BackColor = Color.FromArgb(0, 64, 64);
            }
            else if (buttonName == "button4")
            {
                button5.BackColor = activeColor;
                button4.BackColor = Color.FromArgb(0, 64, 64); ;
            }
            else if (buttonName == "button6")
            {
                button6.BackColor = activeColor;
            }
            else if (buttonName == "button7")
            {
                button7.BackColor = activeColor;
            }
            else if (buttonName == "button8")
            {
                button8.BackColor = activeColor;
            }
            // Add more else if conditions for additional buttons as needed
        }

        private void button2_Click(object sender, EventArgs e)
        {
            labelTest.Text = "Dashbaord";
            ActiveMenu("button2");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int _toogleDashboad = 0;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            _toogleDashboad++;

            if (_toogleDashboad % 2 == 1)
            {
                flowLayoutPanel1.Width = 90;
            }
            else
            {
                flowLayoutPanel1.Width = 304;
            }

            labelTest.Text = "Button clicked";
        }

        private int _subMenuToggle = 0;
        private void button5_Click(object sender, EventArgs e)
        {
            //ActiveMenu("button5");

            _subMenuToggle++;
            if (_subMenuToggle % 2 == 1)
            {
                subMenu.Height = 290;
                ActiveMenu("button5");
            }
            else
            {
                ActiveMenu("");
                subMenu.Height = 90;
            }

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            ActiveMenu("button3");
            labelTest.Text = "Sub Menu 1";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ActiveMenu("button4");
            labelTest.Text = "Sub Menu 2";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            labelTest.Text = "About";
            ActiveMenu("button6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ActiveMenu("button7");
            labelTest.Text = "Setting";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ActiveMenu("button9");
            labelTest.Text = "Logged Out";
        }

        private void buttonMaxi_Click(object sender, EventArgs e)
        {
            // Check the current state of the form
            if (this.WindowState == FormWindowState.Maximized)
            {
                // If the form is maximized, restore to its previous state (normal)
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                // If the form is not maximized, maximize it
                this.WindowState = FormWindowState.Maximized;
            }
        }
    }
}
