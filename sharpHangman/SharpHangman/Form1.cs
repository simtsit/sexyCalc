using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharpHangman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        string[] wordPool = { "ABSTRACT", "DEFINITION", "ORANGE", "VELOCITY", "ILLUSION" };

        string secretWord = "ABSTRACT"; // wordPool[0];

        int remainingTries = 3;


        //MessageBox.Show(secretWord);


        private void button1_Click(object sender, EventArgs e)
        {
            /* Game Logic:
            When a key is pressed, the program first will deactivate the button so it can't be pressed again.
            Then the program will search to find if this letter belongs to the word.
            If yes it will reveal in every case the letter appears.
            If not, it will remove 1 try from user's tries pool.
            It will also change the image of the hangman.
            This check will occur in all buttons.
            */

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
