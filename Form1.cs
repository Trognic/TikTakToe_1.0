using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EpicTicTacToe
{
    public partial class EpicTicTacToe : Form
    {
        bool turn = true;
        int turnCount = 0;
        int scoreO = 0;
        int scoreX = 0;
        public EpicTicTacToe()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            try
            {
                Button b = (Button)sender;

                if (turn == true)
                {
                    b.Text = "X";
                }
                else
                {
                    b.Text = "O";
                }
                turn = !turn;
                turnCount++;
                b.Enabled = false;
                check();
            }
            catch { }
        }

        public void check()
        {
            bool thereIsAWinner = false;

            if (button0.Text == button1.Text && button1.Text == button2.Text && button0.Text != "")
            {
                thereIsAWinner = true;
            }
            if (button3.Text == button4.Text && button4.Text == button5.Text && button3.Text != "")
            {
                thereIsAWinner = true;
            }
            if (button6.Text == button7.Text && button7.Text == button8.Text && button6.Text != "")
            {
                thereIsAWinner = true;
            }
            if (button0.Text == button4.Text && button4.Text == button8.Text && button0.Text != "")
            {
                thereIsAWinner = true;
            }
            if (button2.Text == button4.Text && button4.Text == button6.Text && button2.Text != "")
            {
                thereIsAWinner = true;
            }
            if (button0.Text == button3.Text && button3.Text == button6.Text && button0.Text != "")
            {
                thereIsAWinner = true;
            }
            if (button1.Text == button4.Text && button4.Text == button7.Text && button1.Text != "")
            {
                thereIsAWinner = true;
            }
            if (button2.Text == button5.Text && button5.Text == button8.Text && button2.Text != "")
            {
                thereIsAWinner = true;
            }

            if (thereIsAWinner)
            {
                string w = "";


                if (turn)
                {
                    w = "O";
                    scoreO++;

                }
                else
                {
                    w = "X";
                    scoreX++;

                }
                MessageBox.Text = "The winner is " + w + "!";
                restart();
                textBoxScore.Text = "Spieler X " + scoreX + " : " + scoreO + " Spieler O";
            }
            else if (turnCount == 9)
            {
                MessageBox.Text = "It's a draw!";
                restart();
            }
        }

        private void restart()
        {
            foreach (Control b in Controls.OfType<Button>())
            {
                b.Enabled = true;
                b.Text = "";
                buttonRESET.Text = "RESET";

            }
            turnCount = 0;
            turn = true;
        }

        private void buttonRESET_Click(object sender, EventArgs e)
        {
            scoreO = 0;
            scoreX = 0;
            restart();
            textBoxScore.Text = "Spieler X " + scoreX + " : " + scoreO + " Spieler O";
            MessageBox.Text = "";
        }

        private void TikTakToe_Load(object sender, EventArgs e)
        {

        }
    }
}