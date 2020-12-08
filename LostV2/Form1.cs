/// created by : 
/// date       : 
/// description: A basic text adventure game engine

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LostV2
{
    public partial class Form1 : Form
    {
        // tracks what part of the game the user is at
        int scene = 0;

        // random number generator

        public Form1()
        {
            InitializeComponent();

            //display initial message and options
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            /// check to see what button has been pressed and advance
            /// to the next appropriate scene
            if (e.KeyCode == Keys.M)       //red button press
            {
                if (scene == 0)
                {
                    scene = 1;
                }

                else if (scene == 1)
                {
                    scene = 3;
                }
                else if (scene == 2)
                {
                    scene = 0;
                }
                else if (scene == 3)
                {
                    scene = 0;
                }
                else if (scene == 4)
                {
                    scene = 5;
                }
                else if (scene == 5)
                {
                    scene = 0;
                }
                else if (scene == 6)
                {
                    scene = 0;
                }
                else if (scene == 7)
                {

                }
            }
            if (e.KeyCode == Keys.B)  //blue button press
            {
                if (scene == 0)
                {
                    scene = 2;
                }
                else if (scene == 1)
                {
                    scene = 4;
                }
                else if (scene == 2)
                {
                    scene = 7;
                }
                else if (scene == 3)
                {
                    scene = 7;
                }
                else if (scene == 4)
                {
                    scene = 6;
                }
                else if (scene == 5)
                {
                    scene = 7;
                }
                else if (scene == 6)

                {
                    scene = 7;
                }
                else if (scene == 7)
                {

                }

            }
            /// Display text and game options to screen based on the current scene
            switch (scene)
            {
                case 0:  //start scene  
                    outputLabel.Text = "You wake up in a forest";
                    redLabel.Text = "north";
                    blueLabel.Text = "south";
                    break;
                case 1:
                    outputLabel.Text = " you head north";
                    redLabel.Text = "yes";
                    blueLabel.Text = "no";
                    break;
                case 2:
                    outputLabel.Text = "You fall into a pitfall";
                    redLabel.Text = "Restart";
                    break;
                case 3:
                    outputLabel.Text = "You come to a lake";
                    redLabel.Text = "drink";
                    blueLabel.Text = "no";
                    break;
                case 4:
                    outputLabel.Text = "died of thirst";
                    redLabel.Text = "reststart";
                    break;
                case 5:
                    outputLabel.Text = "see horse";
                    redLabel.Text = "Eat ";
                    blueLabel.Text = "Nahh";
                    break;
                case 6:
                    outputLabel.Text = "died of no meat";
                    redLabel.Text = "Restart";
                    break;
                case 7:
                    outputLabel.Text = "you win";
                    break;
                default:
                    break;
            }
        }

        private void OutputLabel_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }

}
