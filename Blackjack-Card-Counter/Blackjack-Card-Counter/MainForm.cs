using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Blackjack_Card_Counter
{
    public partial class MainForm : Form
    {
        List<string> cards = new List<string>();
        int totalDecks = 8;
        int totalCards = 416;
        decimal decksRemaining = 8;
        int cardsRemaining = 416;
        int runningCount = 0;
        decimal trueCount = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtDecksUsed.ReadOnly = false;
            cards.Clear();
            runningCount = 0;
            trueCount = 0;
            lblRunningCount.Text = $"Running Count: {runningCount}";
            lblTrueCount.Text = $"True Count: {trueCount}";
            lblBetAmount.Text = "Bet Amount: 1 Unit";
            lblLast5Cards.Text = "Last 5 Cards: None";
            lblCardsCounted.Text = $"Cards Counted: 0 of {totalCards}";
            ModifyButtons(true);
            lblInsurance.Text = "Insurance: No";
            lbl16vs9.Text = "16 vs 9: Hit";
            lbl16vs10.Text = "16 vs 10: Hit";
            lbl15vs10.Text = "15 vs 10: Hit";
            lbl13vs2.Text = "13 vs 2: Stand";
            lbl13vs3.Text = "13 vs 3: Stand";
            lbl12vs2.Text = "12 vs 2: Hit";
            lbl12vs3.Text = "12 vs 3: Hit";
            lbl12vs4.Text = "12 vs 4: Stand";
            lbl12vs5.Text = "12 vs 5: Stand";
            lbl12vs6.Text = "12 vs 6: Stand";
            lbl11vsA.Text = "11 vs A: Hit";
            lbl10vs10.Text = "10 vs 10: Hit";
            lbl10vsA.Text = "10 vs A: Hit";
            lbl9vs2.Text = "9 vs 2: Hit";
            lbl9vs7.Text = "9 vs 7: Hit";
            lbl20vs5.Text = "10-10 vs 5: Stand";
            lbl20vs6.Text = "10-10 vs 6: Stand";
        }

        private bool Started()
        {
            return txtDecksUsed.ReadOnly;
        }

        private void ConfigureSettings()
        {
            txtDecksUsed.ReadOnly = true;

            if (!int.TryParse(txtDecksUsed.Text, out totalDecks))
            {
                MessageBox.Show("Please enter a valid number of decks. Default of 8 decks will be used.", "Invalid Decks", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDecksUsed.Text = "8";
                totalDecks = 8;
            }
            else if (totalDecks <= 0)
            {
                MessageBox.Show("Please enter a valid number of decks. Default of 8 decks will be used.", "Invalid Decks", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDecksUsed.Text = "8";
                totalDecks = 8;
            }

            totalCards = 52 * totalDecks;
            decksRemaining = totalDecks;
            cardsRemaining = totalCards;

            lblCardsCounted.Text = $"Cards Counted: 0 of {totalCards}";
        }

        private void ModifyButtons(bool enabled)
        {
            btnPlus.Enabled = enabled;
            btnMinus.Enabled = enabled;
            btnSeven.Enabled = enabled;
            btnEight.Enabled = enabled;
            btnNine.Enabled = enabled;
            btnFour.Enabled = enabled;
            btnFive.Enabled = enabled;
            btnSix.Enabled = enabled;
            btnAce.Enabled = enabled;
            btnTwo.Enabled = enabled;
            btnThree.Enabled = enabled;
            btnTen.Enabled = enabled;
        }

        private void UpdateLast5Cards(Button button = null)
        {
            if (button != null)
            {
                string buttonText = button.Text;

                if (button.Text == "10 J Q K")
                {
                    buttonText = "10";
                }
                else if (button.Text == "A / 1")
                {
                    buttonText = "A";
                }

                cards.Add(buttonText);
            }

            if (cards.Count == 0)
            {
                lblLast5Cards.Text = "Last 5 Cards: None";
            }
            else
            {
                List<string> last5Cards = cards.Skip(Math.Max(0, cards.Count() - 5)).ToList();
                lblLast5Cards.Text = $"Last 5 Cards: {string.Join(" ", last5Cards.Select(x => x))}";
            }
        }

        private void UpdateRunningCount(int increment)
        {
            runningCount += increment;
            lblRunningCount.Text = $"Running Count: {runningCount}";
        }

        private void UpdateTrueCount()
        {
            cardsRemaining--;
            decksRemaining = Convert.ToDecimal(cardsRemaining) / Convert.ToDecimal(totalCards) * Convert.ToDecimal(totalDecks);

            UpdateCardsCounted();

            if (decksRemaining == 0)
            {
                MessageBox.Show("No more cards left in the shoe, please use the reset button if you want to start again.", "Shoe Finished", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ModifyButtons(false);
                return;
            }

            trueCount = Convert.ToDecimal(runningCount) / decksRemaining;
            lblTrueCount.Text = $"True Count: {Math.Round(trueCount, 2)}";
        }

        private void UpdateBetAmount()
        {
            if (trueCount >= 4)
            {
                lblBetAmount.Text = $"Bet Amount: 8 Units";
            }
            else if (trueCount >= 3)
            {
                lblBetAmount.Text = $"Bet Amount: 4 Units";
            }
            else if (trueCount >= 2)
            {
                lblBetAmount.Text = $"Bet Amount: 2 Units";
            }
            else if (trueCount < 2)
            {
                lblBetAmount.Text = $"Bet Amount: 1 Unit";
            }
        }

        private void UpdateCardsCounted()
        {
            int cardsCounted = totalCards - cardsRemaining;
            lblCardsCounted.Text = $"Cards Counted: {cardsCounted} of {totalCards}";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (!Started())
            {
                ConfigureSettings();
            }

            UpdateLast5Cards((Button)sender);
            UpdateRunningCount(1);
            UpdateTrueCount();
            UpdateBetAmount();
            CheckInsurance();
            Check16vs9();
            Check16vs10();
            Check15vs10();
            Check13vs2();
            Check13vs3();
            Check12vs2();
            Check12vs3();
            Check12vs4();
            Check12vs5();
            Check12vs6();
            Check11vsA();
            Check10vs10();
            Check10vsA();
            Check9vs2();
            Check9vs7();
            Check20vs5();
            Check20vs6();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (!Started())
            {
                ConfigureSettings();
            }

            UpdateLast5Cards((Button)sender);
            UpdateRunningCount(-1);
            UpdateTrueCount();
            UpdateBetAmount();
            CheckInsurance();
            Check16vs9();
            Check16vs10();
            Check15vs10();
            Check13vs2();
            Check13vs3();
            Check12vs2();
            Check12vs3();
            Check12vs4();
            Check12vs5();
            Check12vs6();
            Check11vsA();
            Check10vs10();
            Check10vsA();
            Check9vs2();
            Check9vs7();
            Check20vs5();
            Check20vs6();
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if (!Started())
            {
                ConfigureSettings();
            }

            UpdateLast5Cards((Button)sender);
            UpdateTrueCount();
            UpdateBetAmount();
            CheckInsurance();
            Check16vs9();
            Check16vs10();
            Check15vs10();
            Check13vs2();
            Check13vs3();
            Check12vs2();
            Check12vs3();
            Check12vs4();
            Check12vs5();
            Check12vs6();
            Check11vsA();
            Check10vs10();
            Check10vsA();
            Check9vs2();
            Check9vs7();
            Check20vs5();
            Check20vs6();
        }

        private void btnUndoLastCard_Click(object sender, EventArgs e)
        {
            if (cards.Count == 0)
            {
                MessageBox.Show("There are no cards to undo.", "No Cards", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string lastElement = cards.Last();
            cards.RemoveAt(cards.Count - 1);

            if (lastElement == "A")
            {
                lastElement = "11";
            }
            else if (lastElement == "+")
            {
                lastElement = "2";
            }
            else if (lastElement == "-")
            {
                lastElement = "10";
            }

            int lastCard = Convert.ToInt32(lastElement);

            if (lastCard >= 2 && lastCard <= 6)
            {
                UpdateRunningCount(-1);
            }
            else if (lastCard == 10 || lastCard == 11)
            {
                UpdateRunningCount(1);
            }

            cardsRemaining += 2;
            UpdateLast5Cards();
            UpdateTrueCount();
            UpdateBetAmount();
            CheckInsurance();
            Check16vs9();
            Check16vs10();
            Check15vs10();
            Check13vs2();
            Check13vs3();
            Check12vs2();
            Check12vs3();
            Check12vs4();
            Check12vs5();
            Check12vs6();
            Check11vsA();
            Check10vs10();
            Check10vsA();
            Check9vs2();
            Check9vs7();
            Check20vs5();
            Check20vs6();
            ModifyButtons(true);
        }

        private void CheckInsurance()
        {
            if (trueCount >= 3)
            {
                lblInsurance.Text = "Insurance: Yes";
            }
            else
            {
                lblInsurance.Text = "Insurance: No";
            }
        }

        private void Check16vs9()
        {
            if (trueCount >= 5)
            {
                lbl16vs9.Text = "16 vs 9: Stand";
            }
            else
            {
                lbl16vs9.Text = "16 vs 9: Hit";
            }
        }

        private void Check16vs10()
        {
            if (trueCount >= 0 && cardsRemaining != totalCards)
            {
                lbl16vs10.Text = "16 vs 10: Stand";
            }
            else
            {
                lbl16vs10.Text = "16 vs 10: Hit";
            }
        }

        private void Check15vs10()
        {
            if (trueCount >= 4)
            {
                lbl15vs10.Text = "15 vs 10: Stand";
            }
            else
            {
                lbl15vs10.Text = "15 vs 10: Hit";
            }
        }

        private void Check13vs2()
        {
            if (trueCount >= -1)
            {
                lbl13vs2.Text = "13 vs 2: Stand";
            }
            else
            {
                lbl13vs2.Text = "13 vs 2: Hit";
            }
        }

        private void Check13vs3()
        {
            if (trueCount >= -2)
            {
                lbl13vs3.Text = "13 vs 3: Stand";
            }
            else
            {
                lbl13vs3.Text = "13 vs 3: Hit";
            }
        }

        private void Check12vs2()
        {
            if (trueCount >= 4)
            {
                lbl12vs2.Text = "12 vs 2: Stand";
            }
            else
            {
                lbl12vs2.Text = "12 vs 2: Hit";
            }
        }

        private void Check12vs3()
        {
            if (trueCount >= 2)
            {
                lbl12vs3.Text = "12 vs 3: Stand";
            }
            else
            {
                lbl12vs3.Text = "12 vs 3: Hit";
            }
        }

        private void Check12vs4()
        {
            if (trueCount >= 0)
            {
                lbl12vs4.Text = "12 vs 4: Stand";
            }
            else
            {
                lbl12vs4.Text = "12 vs 4: Hit";
            }
        }

        private void Check12vs5()
        {
            if (trueCount >= -1)
            {
                lbl12vs5.Text = "12 vs 5: Stand";
            }
            else
            {
                lbl12vs5.Text = "12 vs 5: Hit";
            }
        }

        private void Check12vs6()
        {
            if (trueCount >= -1)
            {
                lbl12vs6.Text = "12 vs 6: Stand";
            }
            else
            {
                lbl12vs6.Text = "12 vs 6: Hit";
            }
        }

        private void Check11vsA()
        {
            if (trueCount >= 1)
            {
                lbl11vsA.Text = "11 vs A: Double";
            }
            else
            {
                lbl11vsA.Text = "11 vs A: Hit";
            }
        }

        private void Check10vs10()
        {
            if (trueCount >= 4)
            {
                lbl10vs10.Text = "10 vs 10: Double";
            }
            else
            {
                lbl10vs10.Text = "10 vs 10: Hit";
            }
        }

        private void Check10vsA()
        {
            if (trueCount >= 4)
            {
                lbl10vsA.Text = "10 vs A: Double";
            }
            else
            {
                lbl10vsA.Text = "10 vs A: Hit";
            }
        }

        private void Check9vs2()
        {
            if (trueCount >= 1)
            {
                lbl9vs2.Text = "9 vs 2: Double";
            }
            else
            {
                lbl9vs2.Text = "9 vs 2: Hit";
            }
        }

        private void Check9vs7()
        {
            if (trueCount >= 2)
            {
                lbl9vs7.Text = "9 vs 7: Double";
            }
            else
            {
                lbl9vs7.Text = "9 vs 7: Hit";
            }
        }

        private void Check20vs5()
        {
            if (trueCount >= 5)
            {
                lbl20vs5.Text = "10-10 vs 5: Split";
            }
            else
            {
                lbl20vs5.Text = "10-10 vs 5: Stand";
            }
        }

        private void Check20vs6()
        {
            if (trueCount >= 5)
            {
                lbl20vs6.Text = "10-10 vs 6: Split";
            }
            else
            {
                lbl20vs6.Text = "10-10 vs 6: Stand";
            }
        }
    }
}
