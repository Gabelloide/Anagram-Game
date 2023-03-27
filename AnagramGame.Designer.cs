namespace Lab2_Anagram
{
    partial class AnagramGame
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblConsigne = new System.Windows.Forms.Label();
            this.lblWordToGuess = new System.Windows.Forms.Label();
            this.grpBoxGuess = new System.Windows.Forms.GroupBox();
            this.btnTestInput = new System.Windows.Forms.Button();
            this.txtBoxUserInput = new System.Windows.Forms.TextBox();
            this.grpBoxTries = new System.Windows.Forms.GroupBox();
            this.listBoxPreviousGuesses = new System.Windows.Forms.ListBox();
            this.lblTextPreviousGuesses = new System.Windows.Forms.Label();
            this.lblNumberOfGuessesLeft = new System.Windows.Forms.Label();
            this.lblTextNbRemainingGuesses = new System.Windows.Forms.Label();
            this.grpBoxGameHist = new System.Windows.Forms.GroupBox();
            this.lblComboBoxToGuess = new System.Windows.Forms.Label();
            this.lblPrevStatus = new System.Windows.Forms.Label();
            this.lblPrevGuesses = new System.Windows.Forms.Label();
            this.lblPrevWord = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.cmbBoxPrevGames = new System.Windows.Forms.ComboBox();
            this.lblComboBoxResult = new System.Windows.Forms.Label();
            this.lblComboBoxNbTries = new System.Windows.Forms.Label();
            this.grpBoxGuess.SuspendLayout();
            this.grpBoxTries.SuspendLayout();
            this.grpBoxGameHist.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblConsigne
            // 
            this.lblConsigne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(193)))), ((int)(((byte)(154)))));
            this.lblConsigne.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblConsigne.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblConsigne.Location = new System.Drawing.Point(12, 9);
            this.lblConsigne.Name = "lblConsigne";
            this.lblConsigne.Size = new System.Drawing.Size(776, 38);
            this.lblConsigne.TabIndex = 0;
            this.lblConsigne.Text = "Word to guess";
            // 
            // lblWordToGuess
            // 
            this.lblWordToGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F);
            this.lblWordToGuess.ForeColor = System.Drawing.SystemColors.Control;
            this.lblWordToGuess.Location = new System.Drawing.Point(52, 55);
            this.lblWordToGuess.Name = "lblWordToGuess";
            this.lblWordToGuess.Size = new System.Drawing.Size(399, 57);
            this.lblWordToGuess.TabIndex = 1;
            this.lblWordToGuess.Text = "WORD";
            // 
            // grpBoxGuess
            // 
            this.grpBoxGuess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(107)))), ((int)(((byte)(192)))));
            this.grpBoxGuess.Controls.Add(this.btnTestInput);
            this.grpBoxGuess.Controls.Add(this.txtBoxUserInput);
            this.grpBoxGuess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpBoxGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.grpBoxGuess.Location = new System.Drawing.Point(17, 117);
            this.grpBoxGuess.Name = "grpBoxGuess";
            this.grpBoxGuess.Size = new System.Drawing.Size(413, 121);
            this.grpBoxGuess.TabIndex = 2;
            this.grpBoxGuess.TabStop = false;
            this.grpBoxGuess.Text = "Guess";
            // 
            // btnTestInput
            // 
            this.btnTestInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(107)))), ((int)(((byte)(192)))));
            this.btnTestInput.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnTestInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnTestInput.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTestInput.Location = new System.Drawing.Point(283, 32);
            this.btnTestInput.Name = "btnTestInput";
            this.btnTestInput.Size = new System.Drawing.Size(113, 58);
            this.btnTestInput.TabIndex = 1;
            this.btnTestInput.Text = "🔍 Enter";
            this.btnTestInput.UseVisualStyleBackColor = false;
            this.btnTestInput.Click += new System.EventHandler(this.btnTestInput_Click);
            // 
            // txtBoxUserInput
            // 
            this.txtBoxUserInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(193)))), ((int)(((byte)(154)))));
            this.txtBoxUserInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxUserInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBoxUserInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBoxUserInput.Location = new System.Drawing.Point(25, 53);
            this.txtBoxUserInput.Name = "txtBoxUserInput";
            this.txtBoxUserInput.Size = new System.Drawing.Size(240, 26);
            this.txtBoxUserInput.TabIndex = 0;
            this.txtBoxUserInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxUserInput_KeyPress);
            // 
            // grpBoxTries
            // 
            this.grpBoxTries.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(107)))), ((int)(((byte)(192)))));
            this.grpBoxTries.Controls.Add(this.listBoxPreviousGuesses);
            this.grpBoxTries.Controls.Add(this.lblTextPreviousGuesses);
            this.grpBoxTries.Controls.Add(this.lblNumberOfGuessesLeft);
            this.grpBoxTries.Controls.Add(this.lblTextNbRemainingGuesses);
            this.grpBoxTries.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.grpBoxTries.Location = new System.Drawing.Point(17, 254);
            this.grpBoxTries.Name = "grpBoxTries";
            this.grpBoxTries.Size = new System.Drawing.Size(413, 259);
            this.grpBoxTries.TabIndex = 3;
            this.grpBoxTries.TabStop = false;
            this.grpBoxTries.Text = "Tries";
            // 
            // listBoxPreviousGuesses
            // 
            this.listBoxPreviousGuesses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(193)))), ((int)(((byte)(154)))));
            this.listBoxPreviousGuesses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxPreviousGuesses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listBoxPreviousGuesses.FormattingEnabled = true;
            this.listBoxPreviousGuesses.ItemHeight = 20;
            this.listBoxPreviousGuesses.Location = new System.Drawing.Point(9, 102);
            this.listBoxPreviousGuesses.Name = "listBoxPreviousGuesses";
            this.listBoxPreviousGuesses.Size = new System.Drawing.Size(280, 122);
            this.listBoxPreviousGuesses.TabIndex = 3;
            // 
            // lblTextPreviousGuesses
            // 
            this.lblTextPreviousGuesses.AutoSize = true;
            this.lblTextPreviousGuesses.Location = new System.Drawing.Point(6, 72);
            this.lblTextPreviousGuesses.Name = "lblTextPreviousGuesses";
            this.lblTextPreviousGuesses.Size = new System.Drawing.Size(141, 20);
            this.lblTextPreviousGuesses.TabIndex = 2;
            this.lblTextPreviousGuesses.Text = "Previous guesses :";
            // 
            // lblNumberOfGuessesLeft
            // 
            this.lblNumberOfGuessesLeft.AutoSize = true;
            this.lblNumberOfGuessesLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNumberOfGuessesLeft.Location = new System.Drawing.Point(278, 25);
            this.lblNumberOfGuessesLeft.Name = "lblNumberOfGuessesLeft";
            this.lblNumberOfGuessesLeft.Size = new System.Drawing.Size(18, 20);
            this.lblNumberOfGuessesLeft.TabIndex = 1;
            this.lblNumberOfGuessesLeft.Text = "0";
            // 
            // lblTextNbRemainingGuesses
            // 
            this.lblTextNbRemainingGuesses.AutoSize = true;
            this.lblTextNbRemainingGuesses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTextNbRemainingGuesses.Location = new System.Drawing.Point(6, 25);
            this.lblTextNbRemainingGuesses.Name = "lblTextNbRemainingGuesses";
            this.lblTextNbRemainingGuesses.Size = new System.Drawing.Size(236, 20);
            this.lblTextNbRemainingGuesses.TabIndex = 0;
            this.lblTextNbRemainingGuesses.Text = "Number of remaining guesses :  ";
            // 
            // grpBoxGameHist
            // 
            this.grpBoxGameHist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(107)))), ((int)(((byte)(192)))));
            this.grpBoxGameHist.Controls.Add(this.lblComboBoxNbTries);
            this.grpBoxGameHist.Controls.Add(this.lblComboBoxResult);
            this.grpBoxGameHist.Controls.Add(this.lblPrevGuesses);
            this.grpBoxGameHist.Controls.Add(this.lblComboBoxToGuess);
            this.grpBoxGameHist.Controls.Add(this.lblPrevStatus);
            this.grpBoxGameHist.Controls.Add(this.cmbBoxPrevGames);
            this.grpBoxGameHist.Controls.Add(this.lblPrevWord);
            this.grpBoxGameHist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.grpBoxGameHist.Location = new System.Drawing.Point(465, 117);
            this.grpBoxGameHist.Name = "grpBoxGameHist";
            this.grpBoxGameHist.Size = new System.Drawing.Size(278, 329);
            this.grpBoxGameHist.TabIndex = 4;
            this.grpBoxGameHist.TabStop = false;
            this.grpBoxGameHist.Text = "Game history";
            // 
            // lblComboBoxToGuess
            // 
            this.lblComboBoxToGuess.AutoSize = true;
            this.lblComboBoxToGuess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(107)))), ((int)(((byte)(192)))));
            this.lblComboBoxToGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblComboBoxToGuess.Location = new System.Drawing.Point(15, 101);
            this.lblComboBoxToGuess.Name = "lblComboBoxToGuess";
            this.lblComboBoxToGuess.Size = new System.Drawing.Size(120, 20);
            this.lblComboBoxToGuess.TabIndex = 12;
            this.lblComboBoxToGuess.Text = "Word to guess :";
            // 
            // lblPrevStatus
            // 
            this.lblPrevStatus.AutoSize = true;
            this.lblPrevStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(193)))), ((int)(((byte)(154)))));
            this.lblPrevStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPrevStatus.Location = new System.Drawing.Point(154, 137);
            this.lblPrevStatus.Name = "lblPrevStatus";
            this.lblPrevStatus.Size = new System.Drawing.Size(86, 20);
            this.lblPrevStatus.TabIndex = 10;
            this.lblPrevStatus.Text = "PrevResult";
            // 
            // lblPrevGuesses
            // 
            this.lblPrevGuesses.AutoSize = true;
            this.lblPrevGuesses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(193)))), ((int)(((byte)(154)))));
            this.lblPrevGuesses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPrevGuesses.Location = new System.Drawing.Point(155, 175);
            this.lblPrevGuesses.Name = "lblPrevGuesses";
            this.lblPrevGuesses.Size = new System.Drawing.Size(104, 20);
            this.lblPrevGuesses.TabIndex = 9;
            this.lblPrevGuesses.Text = "PrevGuesses";
            // 
            // lblPrevWord
            // 
            this.lblPrevWord.AutoSize = true;
            this.lblPrevWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(193)))), ((int)(((byte)(154)))));
            this.lblPrevWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPrevWord.Location = new System.Drawing.Point(154, 101);
            this.lblPrevWord.Name = "lblPrevWord";
            this.lblPrevWord.Size = new System.Drawing.Size(78, 20);
            this.lblPrevWord.TabIndex = 8;
            this.lblPrevWord.Text = "PrevWord";
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(107)))), ((int)(((byte)(192)))));
            this.btnNewGame.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnNewGame.Location = new System.Drawing.Point(465, 471);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(131, 59);
            this.btnNewGame.TabIndex = 5;
            this.btnNewGame.Text = "🎮 New Game";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(107)))), ((int)(((byte)(192)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnExit.Location = new System.Drawing.Point(612, 471);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(131, 59);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "➡️ Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cmbBoxPrevGames
            // 
            this.cmbBoxPrevGames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxPrevGames.FormattingEnabled = true;
            this.cmbBoxPrevGames.Location = new System.Drawing.Point(19, 32);
            this.cmbBoxPrevGames.Name = "cmbBoxPrevGames";
            this.cmbBoxPrevGames.Size = new System.Drawing.Size(240, 28);
            this.cmbBoxPrevGames.TabIndex = 7;
            this.cmbBoxPrevGames.SelectedIndexChanged += new System.EventHandler(this.cmbBoxPrevGames_SelectedIndexChanged);
            // 
            // lblComboBoxResult
            // 
            this.lblComboBoxResult.AutoSize = true;
            this.lblComboBoxResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(107)))), ((int)(((byte)(192)))));
            this.lblComboBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblComboBoxResult.Location = new System.Drawing.Point(15, 137);
            this.lblComboBoxResult.Name = "lblComboBoxResult";
            this.lblComboBoxResult.Size = new System.Drawing.Size(115, 20);
            this.lblComboBoxResult.TabIndex = 13;
            this.lblComboBoxResult.Text = "Game\'s result :";
            // 
            // lblComboBoxNbTries
            // 
            this.lblComboBoxNbTries.AutoSize = true;
            this.lblComboBoxNbTries.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(107)))), ((int)(((byte)(192)))));
            this.lblComboBoxNbTries.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblComboBoxNbTries.Location = new System.Drawing.Point(15, 175);
            this.lblComboBoxNbTries.Name = "lblComboBoxNbTries";
            this.lblComboBoxNbTries.Size = new System.Drawing.Size(125, 20);
            this.lblComboBoxNbTries.TabIndex = 14;
            this.lblComboBoxNbTries.Text = "Number of tries :";
            // 
            // AnagramGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(888, 556);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.grpBoxGameHist);
            this.Controls.Add(this.grpBoxTries);
            this.Controls.Add(this.grpBoxGuess);
            this.Controls.Add(this.lblWordToGuess);
            this.Controls.Add(this.lblConsigne);
            this.Name = "AnagramGame";
            this.Text = "AnagramGame";
            this.Load += new System.EventHandler(this.AnagramGame_Load);
            this.grpBoxGuess.ResumeLayout(false);
            this.grpBoxGuess.PerformLayout();
            this.grpBoxTries.ResumeLayout(false);
            this.grpBoxTries.PerformLayout();
            this.grpBoxGameHist.ResumeLayout(false);
            this.grpBoxGameHist.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblConsigne;
        private System.Windows.Forms.Label lblWordToGuess;
        private System.Windows.Forms.GroupBox grpBoxGuess;
        private System.Windows.Forms.TextBox txtBoxUserInput;
        private System.Windows.Forms.Button btnTestInput;
        private System.Windows.Forms.GroupBox grpBoxTries;
        private System.Windows.Forms.Label lblTextNbRemainingGuesses;
        private System.Windows.Forms.Label lblNumberOfGuessesLeft;
        private System.Windows.Forms.ListBox listBoxPreviousGuesses;
        private System.Windows.Forms.Label lblTextPreviousGuesses;
        private System.Windows.Forms.GroupBox grpBoxGameHist;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cmbBoxPrevGames;
        private System.Windows.Forms.Label lblPrevStatus;
        private System.Windows.Forms.Label lblPrevGuesses;
        private System.Windows.Forms.Label lblPrevWord;
        private System.Windows.Forms.Label lblComboBoxToGuess;
        private System.Windows.Forms.Label lblComboBoxNbTries;
        private System.Windows.Forms.Label lblComboBoxResult;
    }
}

