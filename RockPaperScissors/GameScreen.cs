using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class GameScreen : UserControl
    {
        Random randNum = new Random();
        int guess = 0;
        int count = 0;

        public GameScreen()
        {
            InitializeComponent();
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            Form1.pattern.Clear();
            Refresh();
            Thread.Sleep(100);

        }

        private void playerTurn()
        {

        }
        private void click(String s)

        {
            if (s == "Rock")
            {
                guess = 1;

                playerLabel.Text = "You chose Rock";
                Refresh();
                Thread.Sleep(2000);
                Refresh();

                ComputerTurn();

            }

            if (s == "Paper")
            {
                guess = 2;

                playerLabel.Text = "You chose Paper";
                Refresh();
                Thread.Sleep(2000);
                Refresh();

                ComputerTurn();
            }

            if (s == "Scissor")
            {
                guess = 3;

                playerLabel.Text = "You chose Scissors";
                Refresh();
                Thread.Sleep(2000);
                Refresh();

                ComputerTurn();
                Refresh();

            }

        }

        private void rockButton_Click(object sender, EventArgs e)
        {
            click("Rock");
        }

        private void paperButton_Click(object sender, EventArgs e)
        {
            click("Paper");
        }

        private void scissorButton_Click(object sender, EventArgs e)
        {
            click("Scissor");
        }

        private void ComputerTurn()
        {
            Form1.pattern.Clear();
            int rand = randNum.Next(1, 3);
            Form1.pattern.Add(rand);
            for (int i = 0; i < Form1.pattern.Count(); i++)

            {
                if (Form1.pattern[i] == 1)
                {
                    Refresh();
                    computerLabel.Text = "Computer Chose Rock";
                    Refresh();
                    Thread.Sleep(1000);
                        
                        if (guess == 1)
                        { 
                            Refresh();
                            resultLabel.Text = "Draw";
                            Refresh();
                            Thread.Sleep(200);
                            playerLabel.Text = "";
                            computerLabel.Text = "";
                            playerTurn();
                        
                    }
                        if (guess == 2)
                        {
                            Refresh();
                            resultLabel.Text = "You Win";
                            playerLabel.Text = "";
                            computerLabel.Text = "";
                            playerTurn();
                        count++;

                    }
                        if (guess == 3)
                        {
                            Refresh();
                            Thread.Sleep(1000);
                            resultLabel.Text = "You Lose";
                        Form f = this.FindForm();
                        f.Controls.Remove(this);
                        GameOverScreen gs = new GameOverScreen();
                        f.Controls.Add(gs);
                    }

                    }
                    if (Form1.pattern[i] == 2)
                    {
                        Refresh();
                        computerLabel.Text = "Computer Chose Paper";
                        Refresh();
                        Thread.Sleep(1000);
                        
                        if (guess == 2)
                        {
                            Refresh();
                            Thread.Sleep(100);
                            resultLabel.Text = "draw";
                            playerLabel.Text = "";
                            computerLabel.Text = "";
                            playerTurn();
                        }
                        if (guess == 3)
                        {
                            resultLabel.Text = "You Win";
                            Refresh();
                            Thread.Sleep(1000);
                            count++;
                        }
                        if (guess == 1)
                        {
                            Refresh();
                            Thread.Sleep(500);
                            resultLabel.Text = "You Lose";
                            
                        Form f = this.FindForm();
                        f.Controls.Remove(this);
                        GameOverScreen gs = new GameOverScreen();
                        f.Controls.Add(gs);
                    }
                    }
                    if (Form1.pattern[i] == 3)
                    {

                        Refresh();
                        computerLabel.Text = "Computer Chose Scissor";
                        Refresh();
                        Thread.Sleep(500);
                    
                        

                        if (guess == 3)
                        {
                            Refresh();
                            resultLabel.Text = "draw";
                            Thread.Sleep(200);
                            playerLabel.Text = "";
                            computerLabel.Text = "";
                            playerTurn();
                        }
                        if (guess == 1)
                        {
                            resultLabel.Text = "You Lose";
                            Refresh();
                            Thread.Sleep(1000);
                            Form f = this.FindForm();
                            f.Controls.Remove(this);
                            GameOverScreen gs = new GameOverScreen();
                            f.Controls.Add(gs);
                        }
                        if (guess == 2)
                        {
                            Refresh();
                            Thread.Sleep(500);
                            resultLabel.Text = "You Win";
                            playerLabel.Text = "";
                            computerLabel.Text = "";
                            playerTurn();
                        count++;
                    }
                    }
                   
                }
            }
        }
    }

                    
                    
            
                  

    

            

                
             

