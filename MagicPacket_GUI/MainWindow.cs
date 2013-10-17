using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MagicPacket_Shared

namespace MagicPacket_GUI
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void wakeButton_Click(object sender, EventArgs e)
        {
            string destinationText = destinationTextBox.Text;

            if (destinationText.Length == 12)
            {
                // send packet
            }
            else 
            {
                statusLabel.Text = "Incorrect MAC Address Format";
            }
            
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            statusLabel.Text = string.Empty;
        }

    }
}
