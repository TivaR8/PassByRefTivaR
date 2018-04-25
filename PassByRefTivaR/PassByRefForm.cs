using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Created by: Tiva Rait
 * Created on: 25-04-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #28 - Pass by Reference & Click Events
 * This program Lets you click on a picture box and changesthe card when this occurs
*/

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
                aPictureBox.Image = Properties.Resources._3H;
            }
            else if ( cardNumber == 2)
            {
                aPictureBox.Image = Properties.Resources.AS;
            }
            else if (cardNumber == 3)
            {
                aPictureBox.Image = Properties.Resources.AD;
            }
            else if (cardNumber == 4)
            {
                aPictureBox.Image = Properties.Resources._2C;
            }
            else if (cardNumber == 5)
            {
                aPictureBox.Image = Properties.Resources._2H;
            }
            else if (cardNumber == 6)
            {
                aPictureBox.Image = Properties.Resources._2S;
            }
            else if (cardNumber == 7)
            {
                aPictureBox.Image = Properties.Resources._2D;
            }
            else if (cardNumber == 8)
            {
                aPictureBox.Image = Properties.Resources._3D;
            }
            else if (cardNumber == 9)
            {
                aPictureBox.Image = Properties.Resources.AH;
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

        private void picImages_Click(object sender, EventArgs e)
        {
            // Declare locla constants
            const int MAX_NUM_CARDS =  8;

            // Declare local variables 
            int aRandomNumber;

            // Get a random number between 1 and the maximum
            aRandomNumber = randNumberGenerator.Next(1, MAX_NUM_CARDS + 1);

            // Get the card depending on the random selection
            ChangeCard(ref this.picImages, aRandomNumber);
        }
    }
}
