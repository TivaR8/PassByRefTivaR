using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassByRefTivaR
{
    public partial class frmPassByRef : Form
    {
        // Declare global variables 
        Random randNumberGenerator = new Random();

        public frmPassByRef()
        {
            InitializeComponent();
        }

        // Procedure: ChangeCard
        // Input: ref PictureBox a PictureBox, int cardNumber
        // Output: void
        // Description: This procedure takes a picture box passed by reference and a card number
        //  It assigns the image in the picture box to card with a given card number.
        private void ChangeCard (ref PictureBox aPictureBox, int cardNumber)
        {
            if (cardNumber == 1)
            {
                aPictureBox.Image = Properties.Resources.AH;
            }
            else if ( cardNumber == 2)
            {
                aPictureBox.Image = Properties.Resources.AS;
            }
            else if (cardNumber == 3)
            {
                aPictureBox.Image = Properties.Resources.AD;
            }
        }

        private void lblAboveText_MouseHover(object sender, EventArgs e)
        {
            lblAboveText.Text = "I am Hovering :)";
        }

        private void lblAboveText_MouseLeave(object sender, EventArgs e)
        {
            lblAboveText.Text = "Click on Image to change it.";
        }
    }
}
