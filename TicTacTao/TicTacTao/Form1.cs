using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TicTacTao
{

    public partial class Form1 : Form
    {
        private Dictionary<string, char> FirstPlayer = new Dictionary<string, char>();
        private Dictionary<string, char> SecondPlayer = new Dictionary<string, char>();
        private string? PlayerOne = null;
        private string? PlayerTwo = null;
        private char PlayerOneChar;
        private char PlayerTwoChar;
        private bool isPlayerOneTurn = true;
        private GroupBox groupBoxOne;
        private int[,] buttonStates = new int[3, 3];
        Button[] buttons = new Button[9];
        public Form1()
        {
            InitializeComponent();

            groupBoxOne = new GroupBox();

            buttons[0] = button1;
            buttons[1] = button2;
            buttons[2] = button3;
            buttons[3] = button4;
            buttons[4] = button5;
            buttons[5] = button6;
            buttons[6] = button7;
            buttons[7] = button8;
            buttons[8] = button9;

            for (int i = 0; i < buttons.Length; i++)
            {

                buttons[i].Click += handleButtonclick;
                buttons[i].Tag = i;
            }
            //make tiktactoe dispper 
            groupBox1.Visible = false;

        }
        private void CenterControl(Control control)
        {
            int parentWidth = this.ClientSize.Width;
            int parentHeight = this.ClientSize.Height;

            int controlWidth = control.Width;
            int controlHeight = control.Height;

            int x = (parentWidth - controlWidth) / 2;
            int y = (parentHeight - controlHeight) / 2;

            control.Location = new Point(x, y);
        }

        private void handleButtonclick(object? sender, EventArgs e)
        {
            if (sender is not Button clickedButton) return;

            int gameSquareNumber = (int)clickedButton.Tag;

            if (buttonStates[gameSquareNumber / 3, gameSquareNumber % 3] != 0)
            {
                MessageBox.Show("This square is already occupied. Choose another square.", "Occupied Square", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int currentPlayerValue = isPlayerOneTurn ? 1 : 2;
            buttonStates[gameSquareNumber / 3, gameSquareNumber % 3] = currentPlayerValue;
            clickedButton.Text = isPlayerOneTurn ? "X" : "O";
            string? winnerName1 = isPlayerOneTurn ? PlayerOne : PlayerTwo;
            string? winnerName2 = isPlayerOneTurn ? PlayerTwo : PlayerOne;
            if (CheckForWinners() && winnerName1 != null)
            {
                

             
                MessageBox.Show($"Player {winnerName1} ({(isPlayerOneTurn ? PlayerOneChar : PlayerTwoChar)}) won the game!", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               DisableAllButtons();
            }
            if (CheckForWinners() && winnerName2 != null)
            {
                MessageBox.Show($"Player {winnerName2} ({(isPlayerOneTurn ? PlayerTwoChar : PlayerOneChar)}) won the game!", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                UpdateBorad();
                isPlayerOneTurn = !isPlayerOneTurn;
            }
        }

        private bool CheckForWinners()
        {
            int currentPlayerValue = isPlayerOneTurn ? 1 : 2 ;

            // Check for a winner in rows, columns, and diagonals
            for (int i = 0; i < 3; i++)
            {
                if (buttonStates[i, 0] == currentPlayerValue && buttonStates[i, 1] == currentPlayerValue && buttonStates[i, 2] == currentPlayerValue ||
                    buttonStates[0, i] == currentPlayerValue && buttonStates[1, i] == currentPlayerValue && buttonStates[2, i] == currentPlayerValue)
                {
                    return true;
                }
            }

            return buttonStates[1, 1] == currentPlayerValue && (
                buttonStates[0, 0] == currentPlayerValue && buttonStates[2, 2] == currentPlayerValue ||
                buttonStates[0, 2] == currentPlayerValue && buttonStates[2, 0] == currentPlayerValue
            );
        }

        private void UpdateBorad()
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                int row = i / 3;
                int col = i % 3;
                buttons[i].Text = buttonStates[row, col] == 0 ? " " : (buttonStates[row, col] == 1 ? "X" : "O");
            }

            if (IsBoardFull())
            {
                MessageBox.Show("It's a tie!", "Tie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisableAllButtons();
            }
        }

        private bool IsBoardFull()
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    if (buttonStates[row, col] == 0)
                    {
                        return false; // There's an empty space, the board is not full
                    }
                }
            }
            return true; // All spaces are filled, it's a tie
        }



        //diaple all button
        private async void DisableAllButtons()
        {
            foreach (Button button in buttons)
            {
                button.Enabled = false;
            }

            // Introduce a delay to make it harder to click on the buttons
            await Task.Delay(1000); // Adjust the delay time as needed
        }

        //undiaple all button
        private void AnableAllButtons()
        {
            foreach (Button button in buttons)
            {
                button.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateBorad();
           
        }

      
        private void RestartGame_Click(object sender, EventArgs e)
        {
            restartGame();
        }

        private void restartGame()
        {
            for(int row = 0; row < 3; row++)
            {
                for(int colums = 0; colums< 3; colums++)
                {
                    buttonStates[row, colums] = 0;
                }
            }
            isPlayerOneTurn = true;
            foreach (Button button in buttons)
            {
                button.Text = " ";
            }
            AnableAllButtons();
            UpdateBorad();
        }

        private void SaveGame_Click(object sender, EventArgs e)
        {

        }






        private void PlayerName1_TextChanged(object sender, EventArgs e)
        {
            PlayerOne = PlayerName1.Text;
        }

        private void PlayerName2_TextChanged(object sender, EventArgs e)
        {
            PlayerTwo = PlayerName2.Text;
        }




        private void StartGame_Click(object sender, EventArgs e)
        {
            try
            {
                string ValidCheckOne = CheckName(PlayerOne, PlayerTwo);
                string ValidCheckTwo = CheckOneChar(PlayerOneChar, PlayerTwoChar);
                if (ValidCheckOne == "Success" && ValidCheckTwo == "Success")
                {
                    FirstPlayer?.Add(PlayerOne, PlayerOneChar);
                    SecondPlayer?.Add(PlayerTwo, PlayerTwoChar);


                    PlayerOneNameDisplay.Text = PlayerOne;
                    PlayerTwoNameDisplay.Text = PlayerTwo;

                    MessageBox.Show("Game started!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Hide the groupBox1 after the game starts
                    PlayerDesign.Visible = false;
                    groupBox1.Visible = true;
                  
                }
                else
                {
                    MessageBox.Show("Validation failed. Please check your input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

            CenterControl(groupBox1);
        }

        private static string CheckName(string? PlayerOne, string? PlayerTwo)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(PlayerTwo) || string.IsNullOrWhiteSpace(PlayerOne))
                {
                    throw new ArgumentException("Player Name cannot be empty or whitespace.");
                }

                if (string.Equals(PlayerTwo, PlayerOne, StringComparison.OrdinalIgnoreCase))
                {
                    throw new ArgumentException("Players cannot have the same name.");
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"CheckName Error: {ex.Message}\nPlayerOne: {PlayerOne}, PlayerTwo: {PlayerTwo}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return "Success";
        }
        private static string CheckOneChar(char playerOneChar, char playerTwoChar)
        {
            try
            {


                if (!((playerOneChar.ToString().ToUpper() == "X" || playerOneChar.ToString().ToUpper() == "O") &&
                      (playerTwoChar.ToString().ToUpper() == "X" || playerTwoChar.ToString().ToUpper() == "O")))
                {
                    throw new ArgumentException("Error, Choose X or O.");
                }

                else if (playerTwoChar.ToString().ToUpper() == playerOneChar.ToString().ToUpper())
                {
                    throw new ArgumentException("Players cannot have the same Character.");
                }



                MessageBox.Show("Character validation successful.");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return "Success";
        }



        private void PlayerDesign_Enter(object sender, EventArgs e)
        {
            CenterControl(PlayerDesign);
        }

        private void XOChoiceOnePlayer_TextChanged(object sender, EventArgs e)
        {

            if (XOChoiceOnePlayer.Text.Length == 1)
            {
                PlayerOneChar = XOChoiceOnePlayer.Text[0];
            }

            else
            {


                XOChoiceOnePlayer.Clear();
                MessageBox.Show($"Sorry, Player: {PlayerOne}, Only One Character (X or O).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void XOChoiceTwoPlayer_TextChanged(object sender, EventArgs e)
        {
            if (XOChoiceTwoPlayer.Text.Length == 1)
            {
                PlayerTwoChar = XOChoiceTwoPlayer.Text[0];
            }

            else
            {

                XOChoiceTwoPlayer.Clear();
                MessageBox.Show($"Sorry, Player: {PlayerTwo}, Only One Character (X or O). ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

        }

        private void TicTacToeGame_Enter(object sender, EventArgs e)
        {

        }

        private void PlayerOneNameDisplay_TextChanged(object sender, EventArgs e)
        {
            PlayerOneNameDisplay.Text = PlayerOne;
        }

        private void PlayerTwoNameDisplay_TextChanged(object sender, EventArgs e)
        {
            PlayerTwoNameDisplay.Text = PlayerTwo;
        }

   
    }
}