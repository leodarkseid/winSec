using System;
using System.Media;
using System.Windows.Forms;

namespace secMouse
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();

            // Add event handlers for mouse and keyboard events
            this.MouseMove += new MouseEventHandler(Form1_MouseMove);
            this.KeyPress += new KeyPressEventHandler(Form1_KeyPress);
        }
        
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (sender != null)
            {
            // Play a loud noise when the mouse is moved
            Console.Beep(1000, 100);
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Play a loud noise when a key is pressed
            if (sender != null)
            {
            // Play a loud noise when the mouse is moved
            Console.Beep(1000, 100);
            }
        }

        // Overrides the Dispose method in the base class
        
    }
}
