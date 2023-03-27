// GABELLE Olivier - TP2B | Anagram Game coded in C#
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace Lab2_Anagram
{
    public partial class AnagramGame : Form
    {
        private List<string> words = new List<string>();
        private List<string> userAnswers = new List<string>();
        private const int MAX_TRIES = 5; // ---------------------> EDIT THIS NUMBER TO INCREASE / DECREASE YOUR TRIES
        private static int remainingTries = MAX_TRIES;
        private static bool victory = false; // The player lost the game by default, will be changed if he wins
        private static int gameCount = 0; // We save the number of games played

        Random random = new Random(); // Initializing the random number generator.

        string wordPicked; // Will be the word picked to play the current game

        Game currentGame = new Game();
        List<Game> gameHistory = new List<Game>();

        public AnagramGame()
        {
            InitializeComponent();
        }

        private void initialization()
        {
            // Things to be done when the application is launched

            lblNumberOfGuessesLeft.Text = remainingTries.ToString();
            // Adding some words to the game using a text file with words composed of five letters in the english dictionnary : 
            foreach (string line in File.ReadLines("words.txt")) // The file is located in /bin/Debug since it is where the executable is launched
            {
                words.Add(line.ToUpper());
            }
            
            NewGame(); //Launching a game
        }   

        private String jumble(String word)
        {
            // take each character of the initial string and
            // insert it in a new string,
            // initially empty, at a random position (including the first and last positions). 
            string newWord = "";
            foreach (char c in word)
            {
                int rdnIndex = random.Next(newWord.Length + 1);
                newWord = newWord.Insert(rdnIndex, c.ToString());
            }
            return newWord;
        }

        private void NewGame()
        {
            // Displaying the state of the previous game before reseting previous variables

            if (gameCount > 0) {  // No previous game if it is the first game, only after.

                // The purpose is to save the previous game's attributes in a Game object, then adding it in a List of Games.
                // Then the comboBox can decide which one to display.

                // Updating all the informations in the current object's attributes
                currentGame.PastStatus = (victory);
                currentGame.PastNbGuess = (MAX_TRIES - remainingTries);
                currentGame.PastWord = (wordPicked);
                cmbBoxPrevGames.Items.Add(currentGame.getName()); // Adding the game's name in the combobox

                gameHistory.Add(currentGame);
                currentGame = new Game(); // Rerolling a new game object.

            }

            //------------------------------

            gameCount++; // next game

            // Clearing | reseting routine
            victory = false; // reseting victory state

            txtBoxUserInput.Clear(); // Clearing the answer field if there was something remaining

            listBoxPreviousGuesses.Items.Clear(); //Clearing previous guesses

            remainingTries = MAX_TRIES; // Reseting tries

            updatingTries(); // updating label
            int rdnPick = random.Next(words.Count); // Picking a word in the list. The list of words goes from 0 to N elements (size of N+1), we pick a random between 0 and N+1 excluded, so N.
            wordPicked = words[rdnPick]; // We pick a random word
            string wordJumbled = jumble(wordPicked); // We jumble it.
            lblWordToGuess.Text = wordJumbled; // We display it.
            lblWordToGuess.Text = lblWordToGuess.Text.ToUpper(); // Will always be in uppercase

        }

        private void correctWord()
        {
            
                if (remainingTries >= 0)
                { // If the word is correct and there are tries left
                    victory = true; // Updating the game's state.

                    DialogResult result = MessageBox.Show("Congratulations! You found the word. Do you want to play again?", "VICTORY", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes) NewGame(); // if the user wants to play again
                    else this.Dispose(); // If not, quitting the application.

               
            }
        }

        private void incorrectWord()
        {

                if (remainingTries == 0) // if there is no tries left
                {
                    DialogResult result = MessageBox.Show("You lost! The word was " + wordPicked + ". Do you want to play again?", "DEFEAT", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes) NewGame();  // if the user wants to play again
                    else this.Dispose(); // If not, quitting the application.
                
            }

        }
        private void AnagramGame_Load(object sender, EventArgs e)
        {
            initialization(); // Called only once
        }

        private void btnTestInput_Click(object sender, EventArgs e)
        {
            

            if (string.IsNullOrWhiteSpace(txtBoxUserInput.Text)) // If the answer field is left empty (or a space)
            {
                // Warning the user
                DialogResult result = MessageBox.Show("You need to order a word before submitting an answer.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBoxUserInput.Clear(); // Clearing the wrong answer to prevent it to go in the previousGuesses list (null or space)
            }

            if (remainingTries >= 0 && !string.IsNullOrWhiteSpace(txtBoxUserInput.Text)) // string.IsNullOrWhiteSpace(TextBox.Text) returns a boolean if the textbox is empty. More reliable than if == ""
            {
                remainingTries--; // Minus one try since the user entered a word.
                updatingTries(); // Updating label
                                 // 

                // Checking the word entered.
                if (txtBoxUserInput.Text.ToUpper() == wordPicked)  correctWord();
                else incorrectWord();
                updatingTries(); // Updating label 

                userAnswers.Add(txtBoxUserInput.Text.ToUpper()); // Add the user input in the dictionnary of answers IN UPPERCASE
                txtBoxUserInput.Clear(); // Clearing the input box when the test button is clicked
                listBoxPreviousGuesses.Items.Add(userAnswers.Last()); //Adding the last answer of the user in the previous guess list.

            }
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("This will cancel the current game and it will be lost. Are you sure ?", "START A NEW GAME", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes) NewGame();
        }

        private void txtBoxUserInput_KeyPress(object sender, KeyPressEventArgs e)
        // Used to allow the user to press Enter in order to trigger the test button.
        {
            // The keystroke Enter corresponds to the number 13 -> Chr(13) is Enter.
            if (Convert.ToInt32(e.KeyChar) == 13) // If enter pressed
            {
                btnTestInput_Click(sender, e); // same behaviour as if the test button was pressed.
            }
        }

        private void updatingTries()
        // Procedure to simplify the code
        {
            lblNumberOfGuessesLeft.Text = remainingTries.ToString(); // Updating label 
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to exit the application?", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes) this.Dispose();
        }

        private void cmbBoxPrevGames_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < gameHistory.Count(); i++)
            // Each game of the history corresponds to a line in the comboBox. For each line, we display the 3 differents attributes of the Game object.
            {
                if (cmbBoxPrevGames.SelectedIndex == i) 
                {
                    lblPrevWord.Text = gameHistory[i].PastWord;
                    lblPrevGuesses.Text = gameHistory[i].PastNbGuess.ToString();
                    lblPrevStatus.Text = (gameHistory[i].PastStatus) ? "Won" : "Lose";
                }
            }
        }
    }

    public class Game
    {
        //Storing information about games
        private int gameNumber;
        private static int counter = 1;
        // Data attributes
        private String pastWord;
        private bool pastStatus; // Won or Lost, using a boolean
        private int pastNbGuess;

        // Automatically generated Setters and Getters with the keystrokes Ctrl+R + Ctrl+E
        public string PastWord { get => pastWord; set => pastWord = value; }
        public bool PastStatus { get => pastStatus; set => pastStatus = value; }
        public int PastNbGuess { get => pastNbGuess; set => pastNbGuess = value; }

        public Game()
        {
            this.gameNumber = counter;
            counter++;
        }

        public String getName()
            // Method to return the name of the object Game in a formalized way : Game + gameNumber
        {
            return "Game " + (gameNumber).ToString();
        }
    }
}
