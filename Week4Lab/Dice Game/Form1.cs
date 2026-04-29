using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dice_Game
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        int playerBalance = 1000;
        int compBalance = 1000;
        int compDice1 = 0;
        int compDice2 = 0;
        int playerDice1 = 0;
        int playerDice2 = 0;
        int BetAmount = 0;
        public Form1()
        {
            InitializeComponent();

            UpdateBalanceDisplay();
        }
        private void UpdateBalanceDisplay()
        {
            textBoxComputerStack.Text = compBalance.ToString();
            textBoxPlayerStack.Text = playerBalance.ToString();
        }
        private void GameSpace_Paint(object sender, PaintEventArgs e)
        {
            Graphics paper = e.Graphics;
            Pen startPen = new Pen(Color.Black, 2);
            paper.DrawRectangle(startPen, 150, 50, 40, 40);
            paper.DrawRectangle(startPen, 210, 50, 40, 40);
            paper.DrawRectangle(startPen, 150, 110, 40, 40);
            paper.DrawRectangle(startPen, 210, 110, 40, 40);
            if (compDice1 > 0)
            {
                Font diceFont = new Font("Arial", 16, FontStyle.Bold);
                SolidBrush textBrush = new SolidBrush(Color.Black);
                paper.DrawString(compDice1.ToString(), diceFont, textBrush, 160, 58);
                paper.DrawString(compDice2.ToString(), diceFont, textBrush, 220, 58);
                paper.DrawString(playerDice1.ToString(), diceFont, textBrush, 160, 118);
                paper.DrawString(playerDice2.ToString(), diceFont, textBrush, 220, 118);
            }
        }

        private void buttonBet_Click(object sender, EventArgs e)
        {
            try
            {
                BetAmount = int.Parse(textBoxBet.Text);
            }
            catch
            {
                MessageBox.Show("Invaild Input!");
                return;
            }
            if (BetAmount <= 0)
            {
                MessageBox.Show("Invaild Input!");
                return;
            }
            if (BetAmount > playerBalance)
            {
                MessageBox.Show("You do not have enough money!");
                return;
            }

            if (BetAmount > compBalance)
            {
                MessageBox.Show($"Computer only have {compBalance}.");
                return;
            }
            compDice1 = rand.Next(1, 7);
            compDice2 = rand.Next(1, 7);
            playerDice1 = rand.Next(1, 7);
            playerDice2 = rand.Next(1, 7);

            GameSpace.Invalidate();

            int compSum = compDice1 + compDice2;
            int playerSum = playerDice1 + playerDice2;
            string resultMessage = $"Sum of Computer: {compSum}\nSum of You: {playerSum}\n\n";

            if (playerSum > compSum)
            {
                playerBalance += BetAmount;
                compBalance -= BetAmount;
                resultMessage += "You win!";
            }
            else if (playerSum < compSum)
            {
                playerBalance -= BetAmount;
                compBalance += BetAmount;
                resultMessage += "You lose!";
            }
            else
            {
                resultMessage += "";
            }
            MessageBox.Show(resultMessage);
            UpdateBalanceDisplay();

            textBoxBet.Clear();
            textBoxBet.Focus();

            if (playerBalance <= 0)
            {
                MessageBox.Show("You have no money! Plesase restart!");
                buttonBet.Enabled = false;
                buttonAllIn.Enabled = false;
            }
        }

        private void buttonAllIn_Click(object sender, EventArgs e)
        {
            if (playerBalance > 0 && compBalance > 0)
            {
                int allInAmount = Math.Min(playerBalance, compBalance);
                textBoxBet.Text = allInAmount.ToString();
                buttonBet_Click(sender, e);
            }
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            playerBalance = 1000;
            compBalance = 1000;
            compDice1 = 0; compDice2 = 0;
            playerDice1 = 0; playerDice2 = 0;

            buttonBet.Enabled = true;
            buttonAllIn.Enabled = true;

            UpdateBalanceDisplay();
            GameSpace.Invalidate();
            textBoxBet.Clear();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
