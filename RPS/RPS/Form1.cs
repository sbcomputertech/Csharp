using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPS
{
    public partial class Form1 : Form
    {
        string p1choice = "none";
        string p2choice = "none";
        public Form1()
        {
            InitializeComponent();
            label3.Visible = false;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p1choice = "rock";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            p1choice = "paper";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            p1choice = "scissors";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            p2choice = "rock";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            p2choice = "paper";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            p2choice = "scissors";
        }
        private void checkChoices()
        {
            if (p1choice != "none" && p2choice != "none")
            {
                string outcome = "none";
                Console.WriteLine("Both choices have been made:");
                Console.WriteLine("Player 1: " + p1choice);
                Console.WriteLine("Player 2: " + p2choice);
                switch (p1choice)
                {
                    case "rock":
                        switch (p2choice)
                        {
                            case "rock":
                                outcome = "tie";
                                break;
                            case "paper":
                                outcome = "p2win";
                                break;
                            case "scissors":
                                outcome = "p1win";
                                break;
                        }
                        break;
                    case "paper":
                        switch (p2choice)
                        {
                            case "rock":
                                outcome = "p1win";
                                break;
                            case "paper":
                                outcome = "tie";
                                break;
                            case "scissors":
                                outcome = "p2win";
                                break;
                        }
                        break;
                    case "scissors":
                        switch (p2choice)
                        {
                            case "rock":
                                outcome = "p2win";
                                break;
                            case "paper":
                                outcome = "p1win";
                                break;
                            case "scissors":
                                outcome = "tie";
                                break;
                        }
                        break;
                }
                switch (outcome)
                {
                    case "tie":
                        Console.WriteLine("It was a tie");
                        label3.Text = "It was a tie";
                        label3.Visible = true;
                        break;
                    case "p1win":
                        Console.WriteLine("Player 1 wins");
                        label3.Text = "Player 1 wins";
                        label3.Visible = true;
                        break;
                    case "p2win":
                        Console.WriteLine("Player 2 wins");
                        label3.Text = "Player 2 wins";
                        label3.Visible = true;
                        break;
                }
                p1choice = "none";
                p2choice = "none";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            checkChoices();
        }
    }
}
