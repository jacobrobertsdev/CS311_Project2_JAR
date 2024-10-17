namespace CS311_Project2_JAR
{
    public partial class Craps : Form
    {

        // Data fields
        private int rollCount = 0;
        private double balance = 100.00;
        private int currentPoint;
        private double currentBet;

        public Craps()
        {
            InitializeComponent();
        }

        // Roll Button 'click' event handler
        private void btnRoll_Click(object sender, EventArgs e)
        {

            // Check if textbox has input and set currentBet to validated input. Show message if invalid text entered.
            if (!string.IsNullOrEmpty(textBoxBet.Text))
            {
                if (double.TryParse(textBoxBet.Text, out double bet)) // Validate that a number was entered
                {
                    currentBet = bet;
                } else
                {
                    MessageBox.Show("Enter a number");
                    textBoxBet.Text = "";
                    rollCount = 0;
                }
                    
            }
            
            // Check if avalable balance > currentBet amount. Show error message if balance < currentBet.
            if (currentBet > balance)
            {
                MessageBox.Show("Insufficient balance");
                textBoxBet.Text = "";
                return;
            }


            // Reset the result label text when game starts over.
            if (rollCount == 0)
            {
                lblResult.Text = "Result:";
            }

            // Increment rollCount with each click
            rollCount++;

            // Get current roll with calculate_score()
            calculate_score();
            
        }

        // This method rolls the dice, calculates and the sum/score, and updates the game
        private void calculate_score()
        {
            Random random = new Random();

            int roll1 = random.Next(1, 7); // Die 1
            int roll2 = random.Next(1, 7); // Die 2

            lblDie1.Text = roll1.ToString(); // Update labels
            lblDie2.Text = roll2.ToString();

            int roll = roll1 + roll2; // Calculate roll total

            // Check result of first roll and update the game
            if (rollCount == 1)
            {
                switch (roll)
                {
                    case 7:
                    case 11:
                        winGame(); // 7 or 11 is a win
                        break;

                    case 2:
                    case 3:
                    case 12:
                        loseGame(); // 2, 3, or 12 is a loss
                        break;

                    case 4:
                    case 5:
                    case 6:
                    case 8:
                    case 9:
                    case 10:
                        currentPoint = roll; // Set 'point' if 4,5,6,8,9, or 10 is rolled
                        lblResult.Text = $"Result: Point is {currentPoint}";
                        break;
                }
            }
            else // Check result of subsequent rolls and update the game
            {
                if (roll == 7) // 7 before rolling 'point' again is a loss
                {
                    loseGame();
                }
                else if (roll == currentPoint) // Rolling 'point' again is a win
                {
                    winGame();
                }
            }
        }

        // This method updates/resets the game, bet, balance, and labels upon a loss
        private void loseGame()
        {
            lblResult.Text = "Result: You lose!";
            rollCount = 0;
            balance -= currentBet;
            currentBet = 0;
            textBoxBet.Text = "";
            lblBalance.Text = $"Balance: {balance.ToString("C")}";
        }

        // This method updates/resets the game, bet, balance, and labels upon a win
        private void winGame()
        {
            lblResult.Text = "Result: You win!";
            rollCount = 0;
            balance += currentBet;
            currentBet = 0;
            textBoxBet.Text = "";
            lblBalance.Text = $"Balance: {balance.ToString("C")}";
        }
    }
}
