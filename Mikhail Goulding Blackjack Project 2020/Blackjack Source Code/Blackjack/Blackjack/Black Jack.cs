/* Filename:            Black Jack.cs
 * Author:              Mikhail Goulding
 * Created:             02 February 2020
 * Operating System:    Windows 10
 * Version:             1.0
 * Description          This file contains the Black Jack form, which holds the mechanics of the game.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections; // Added so I can access collections.

namespace Blackjack
{
    public partial class BlackJackForm : Form
    {
        #region Variables
        readonly string[] cardLoc = new string[53]; // This array holds the location of the cards.
        readonly int[] cardVal = new int[53]; // This array holds the numeric value of the cards.
        readonly ArrayList dealer = new ArrayList(); // This arraylist holds the dealer's cards.
        readonly ArrayList user = new ArrayList(); // This arraylist holds the user's cards
        readonly PictureBox[] uPic; // Array storing the user's card picture boxes.
        readonly PictureBox[] dPic; // Array storing the dealer's card picture boxes.
        readonly Random randomCard = new Random(); // Used for random card selection.
        readonly Scoreboard scoreBoard = new Scoreboard(); // The scoreboard form.
        int wincount = 0; // Saves the total number of games won
        int losecount = 0; // Saves the total number of games lost
        int tiecount = 0; // Saves the total number of games that ended in a tie
        int userScore = 0; // User's Score for current round.
        int dealerScore = 0; // Dealer's Score for current round.
        int gamesPlayed = 0; // Total amount of games played.
        int uCardsDrawn = 0; // Amounts of cards the user has in his hand. Starts counting from 0.
        int dCardsDrawn = 0; // Amount of cards the dealer has in his hand. Starts counting from 0.

        #endregion

        public BlackJackForm()
        {
            InitializeComponent();

            #region Card Location
            for (int count = 0; count < 53; count++) // This for loop adds each card's location to the cardLoc string array.
            {
                cardLoc[count] = "Cards/" + count + ".png"; // Each card has a name like: 0.png, 1.png. All cards are saved in the 'Cards' Folder.
            }
            #endregion

            #region Card Value 
            //Adding numeric values for cards
            cardVal[0] = 0; // Card 0 is the Card Back. It has no value.

            #region Ace value
            for (int card = 1; card < 5; card++) // Sets the value of the aces to 0.
            {
                cardVal[card] = 0;
            }
            #endregion

            #region 2-9 card value
            int cardValue = 2; // The value of the card.
            int cardNumber = 0; // Counts from 1 to 4 and then resets back to 0. Used to keep track of the cards with the same value.
            for (int card = 5; card < 37; card++) // Sets the value of cards 0-9
            {
                cardVal[card] = cardValue;
                cardNumber++;

                if (cardNumber == 4)
                // Once 4 cards have been given a card value, the CardValue variable increases by 1, and cardNumber resets to 0.
                // This allows each 4 cards of the same number to be assigned the same value, and the next 4 cards to have a higher value.
                {
                    cardValue++;
                    cardNumber = 0;
                }
            }
            #endregion

            #region King, Queen, Jack and 10 value
            for (int card = 37; card < 53; card++) // Sets the value of King, Queen, Jack and 10
            {
                cardVal[card] = 10; // Value of cards set to 10
            }
            #endregion
            #endregion

            #region Picture Boxes
            uPic = new PictureBox[] // Adding user card PictureBoxes to uCard array.
            {
                UserCard1,
                UserCard2,
                UserCard3,
                UserCard4,
                UserCard5,
                UserCard6,
                UserCard7,
                UserCard8,
                UserCard9,
                UserCard10,
                UserCard11,
                UserCard12
            };
            dPic = new PictureBox[] // Adding dealer card PictureBoxes to dCard array.
            {
                DealerCard1,
                DealerCard2,
                DealerCard3,
                DealerCard4,
                DealerCard5,
                DealerCard6,
                DealerCard7,
                DealerCard8,
                DealerCard9,
                DealerCard10,
                DealerCard11,
                DealerCard12
            };
            #endregion

            // I hide a bunch of labels and buttons at startup.
            HideScore();
            HideCards();
            HideHitStand();
            HideDeal();
            HideGameResultLabel();
            // Go to StartNewGameBtn_Click & NewGameMenuItem_Click in the Events region.
            // These 2 events are user-triggered click events that are used to start/reset the game.
        }

        #region Methods
        async void GamePart1() // The method that gets called when the New-Game button/menu-item is clicked. The game starts here.
        {
            HideAndClear();
            ShowLabels();

            NewGameMenuItem.Enabled = false; // I disabled the ability to create a new game while cards are being placed.

            user.Add(DrawCard()); // User draws first card.

            #region check1
            bool check1 = false; // Will become true after a card is chosen.
            while (check1 == false) // Makes sure that same card is not drawn twice.
            {
                int card = DrawCard();
                if (!user.Contains(card)) // Check if user has the card already.
                {
                    check1 = true;
                    user.Add(card); // User draws second card.
                    uCardsDrawn++;
                }
            }
            #endregion
            #region check2
            bool check2 = false; // Will become true after a card chosen.
            while (check2 == false) // Makes sure that same card is not drawn twice.
            {
                int card = DrawCard();
                if (!user.Contains(card)) // Check if user has the card.
                {
                    check2 = true;
                    dealer.Add(card); //Dealer draws first card.
                }
            }
            #endregion
            #region check3
            bool check3 = false; // Will become true after a card chosen.
            while (check3 == false) // Makes sure that same card is not drawn twice.
            {
                int card = DrawCard();
                if ((!user.Contains(card)) & (!dealer.Contains(card))) // Check if user or dealer has the card.
                {
                    check3 = true;
                    dealer.Add(card); // Dealer draws second card.
                    dCardsDrawn++;
                }
            }
            #endregion

            #region Deal 4 cards
            // First 4 cards get images.
            await Task.Delay(750); // // This statement "pauses" the code execution in the form for a selected time, in milliseconds. Used to make cards take time to place.
            
            try // Tries to assign images to the pictureboxes
            {
                for (int i = 0; i < 2; i++) // Showing first 2 user cards and displaying their value.
                {
                    uPic[i].Image = Image.FromFile(cardLoc[(int)user[i]]);
                    uPic[i].BringToFront();
                    uPic[i].Show();

                    if (i == 0) // If first card.
                    {
                        CalcU((int)user[0]);
                    }
                    else // Second card.
                    {
                        CalcU((int)user[0], (int)user[1]);
                    }
                    await Task.Delay(750);
                }
                
                for (int i = 0; i < 2; i++) // Showing first 2 dealer cards. Second card is face-down. Only value of first card is displayed.
                {
                    dPic[i].Image = (i == 0) ? Image.FromFile(cardLoc[(int)dealer[i]]) : Image.FromFile(cardLoc[0]);
                    dPic[i].BringToFront();
                    dPic[i].Show();

                    if (i == 0) // If first card.
                    {
                        CalcD((int)dealer[0]);
                        await Task.Delay(750);
                    }
                }
            }
            catch (System.IO.FileNotFoundException e)
            {
                MessageBox.Show("File(s) Missing - " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit(); // I close the game if the card-files are missing. You cannot play the game if you cannot see the cards.
            }
            #endregion


            if (userScore == 21) // If user has a blackjack.
            {
                GamePart2();
            }
            else // If user does not have a blackjack, he has the option to hit/stand.
            {
                await Task.Delay(750);
                ShowHitStand();
                NewGameMenuItem.Enabled = true; // The new game menu button can be used again.
            }
        }

        async void GamePart2() // User turn is done. GamePart2 covers the dealer's turn.
        {
            HideHitStand();
            NewGameMenuItem.Enabled = false;

            if (userScore == 21) // Updates label, showing that user has a blackjack.
            {
                UserBlackjackText();
            }
            else if (userScore > 21) // Updates label, showing that user busted.
            {
                UserBustedText();
            }

            await Task.Delay(1000);
            try // Tries to display dealer cards and draw new cards.
            {
                dPic[1].Image = Image.FromFile((cardLoc[(int)dealer[1]])); // Display the dealers second card that was face-down.
                CalcD();

                while (dealerScore < 17) // Dealer hits when his score is less than 17.
                {
                    bool check = false; // Will become true after a card chosen.
                    while (check == false) // Dealer attempts to draw a card. Makes sure that same card is not drawn twice.
                    {
                        int card = DrawCard();
                        if ((!user.Contains(card)) & (!dealer.Contains(card))) //Check if user or dealer has the card.
                        {
                            check = true;
                            dealer.Add(card); // Dealer draws a card.
                            dCardsDrawn++;
                        }
                    }

                    // Card chosen. Now for assigning it to an image and calculating value.
                    dPic[dCardsDrawn].Image = Image.FromFile(cardLoc[(int)dealer[dCardsDrawn]]);
                    dPic[dCardsDrawn].BringToFront();
                    await Task.Delay(750);
                    dPic[dCardsDrawn].Show();
                    CalcD();
                }
            }
            catch (System.IO.FileNotFoundException e)
            {
                MessageBox.Show("File(s) Missing - " + e.Message, "Error");
                Application.Exit();
            }

            if (dealerScore == 21) // Updates label, showing that dealer has a blackjack.
            {
                DealerBlackjackText();
            }
            else if (dealerScore > 21) // Updates label, showing that dealer busted.
            {
                DealerBustedText();
            }

            if ((userScore > 21) | ((userScore < 21) & (dealerScore <= 21) & (userScore < dealerScore))) // User loses.
            {
                GameResultLbl.Text = "You lose!";
                losecount++;
                scoreBoard.Lose(losecount);
            }
            else if (userScore == dealerScore) // Tie when user and dealer have the same score. The else if ensures that this number is 21 or less.
            {
                GameResultLbl.Text = "It's a tie!";
                tiecount++;
                scoreBoard.Tie(tiecount);
            }
            else // User wins.
            {
                GameResultLbl.Text = "You win!";
                wincount++;
                scoreBoard.Win(wincount);
            }

            gamesPlayed++;
            scoreBoard.Played(gamesPlayed);
            await Task.Delay(500);
            GameResultLbl.Show();
            NewGameMenuItem.Enabled = true;
            ShowDeal();
            // A round of the game has been completed. Now user can click the deal button to start a new round.
        }

        async void UserHit() // User draws another card. (User 'hits')
        {
            bool check = false; // Will become true after a card chosen.
            while (check == false) // User attempts to draw a card. Makes sure that same card is not drawn twice.
            {
                int card = DrawCard();
                if ((!user.Contains(card)) & (!dealer.Contains(card))) // Check if user or dealer has the card.
                {
                    check = true;
                    user.Add(card); // User draws a card.
                    uCardsDrawn++;
                }
            }

            // Card chosen. Now for assigning it to an image and calculating value.
            try
            {
                uPic[uCardsDrawn].Image = Image.FromFile(cardLoc[(int)user[uCardsDrawn]]);
                uPic[uCardsDrawn].BringToFront();
                HideHitStand();
                NewGameMenuItem.Enabled = false;
                await Task.Delay(750);
                uPic[uCardsDrawn].Show();
                CalcU();

                if ((userScore >= 21) | (uCardsDrawn == 11)) // Checks if user busted or got a blackjack. Also limits total number of cards you can have to 12.
                {
                    GamePart2();
                }
                else // User can hit again, if user did not bust or get a blackjack.
                {
                    await Task.Delay(750);
                    ShowHitStand();
                    NewGameMenuItem.Enabled = true;
                }
            }
            catch (System.IO.FileNotFoundException e)
            {
                MessageBox.Show("File(s) Missing - " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit(); // I close the game if the card-files are missing. You cannot play the game if you cannot see the cards.
            }
        }

        int DrawCard() // Draw a random card
        {
            return randomCard.Next(1, 53);
        }

        #region Hide and Show
        void HideScore() // Hides the user and dealer scores.
        {
            DealerLbl.Hide();
            DealerScoreLbl.Hide();
            DealerResultLbl.Hide();

            UserLbl.Hide();
            UserScoreLbl.Hide();
            UserResultLbl.Hide();
        }

        void HideCards() // Hides the user and dealer cards.
        {
            UserCardsLbl.Hide();
            foreach (PictureBox card in uPic)
            {
                card.Hide();
            }

            foreach (PictureBox card in dPic)
            {
                card.Hide();
            }
            DealerCardsLbl.Hide();
        }

        void HideHitStand() // Hides hit and stand buttons
        {
            StandBtn.Hide();
            HitBtn.Hide();
            HitStandLbl.Hide();
        }

        void HideDeal() // Hides deal button and label
        {
            DealBtn.Hide();
            ClickHereLbl.Hide();
        }

        void HideAndClear() // Hides lables, buttons, pictureboxes. Clears user and dealer arraylists. Resets user and dealer scores.
        {
            userScore = 0;
            dealerScore = 0;
            uCardsDrawn = 0;
            dCardsDrawn = 0;

            UserScoreLbl.Text = "0";
            DealerScoreLbl.Text = "0";

            dealer.Clear(); // clears the arraylist holding the dealer's cards
            user.Clear(); // clears the arraylist holding the user's cards
            HideScore();
            HideCards();
            HideHitStand();
            HideDeal();
            StartNewGameBtn.Hide();
            GameResultLbl.Hide();
        }

        void HideGameResultLabel() // Hides game result label.
        {
            GameResultLbl.Hide();
        }

        void ShowLabels() // Shows a bunch of labels that were hidden
        {
            DealerLbl.Show();
            DealerScoreLbl.Show();
            DealerCardsLbl.Show();

            UserLbl.Show();
            UserScoreLbl.Show();
            UserCardsLbl.Show();
        }

        void ShowHitStand() // Shows hit and stand buttons.
        {
            StandBtn.Show();
            HitBtn.Show();
            HitStandLbl.Show();
        }

        void ShowDeal() // Shows deal button and label.
        {
            DealBtn.Show();
            ClickHereLbl.Show();
        }
        #endregion
        
        #region Results
        void UserBlackjackText() // Updates lable saying that user got a blackjack.
        {
            UserResultLbl.Text = "Blackjack!";
            UserResultLbl.Show();
        }

        void UserBustedText() // Updates lable saying that user busted.
        {
            UserResultLbl.Text = "Busted!";
            UserResultLbl.Show();
        }

        void DealerBlackjackText() // Updates lable saying that dealer got a blackjack.
        {
            DealerResultLbl.Text = "Blackjack!";
            DealerResultLbl.Show();
        }

        void DealerBustedText() // Updates lable saying that dealer busted.
        {
            DealerResultLbl.Text = "Busted!";
            DealerResultLbl.Show();
        }
        #endregion

        #region User Score Calculation
        void CalcU(int card1) // Calculates user score after drawing first card.
        {
            if (card1 > 0 & card1 < 5) // If card is an ace.
            {
                userScore = 11;
            }
            else
            {
                userScore = cardVal[card1];
            }
            UserScoreLbl.Text = userScore.ToString(); ;
        }

        void CalcU(int card1, int card2) // Calculates user score after drawing first two cards.
        {
            if ((card1 > 0 & card1 < 5) & (card2 > 0 & card2 < 5)) // If both cards are aces.
            {
                userScore = 12; // One ace has value of 11, and other a value of 1.
            }
            else if ((card1 > 0 & card1 < 5) | (card2 > 0 & card2 < 5)) // If one card is an ace.
            {
                    userScore = cardVal[card1] + cardVal[card2] + 11; // No possibility of busting with 2 cards, so ace gets a value of 11.
            }
            else // If there are no aces.
            {
                userScore = cardVal[card1] + cardVal[card2];
            }

            UserScoreLbl.Text = userScore.ToString();

            if (userScore == 21)
            {
                UserBlackjackText();
                UserResultLbl.Show();
            }
            else if (userScore > 21)
            {
                UserBustedText();
                UserResultLbl.Show();
            }
        }

        void CalcU() // Calculates user score for 3 or more cards.
        {
            int NumAces = 0; // Number of aces the user has.
            int AceTotalVal = 0; // Total value of aces the user has.
            int score = 0;  // User score, ignoring value of aces.

            foreach (var cards in user) // Counts how many aces the user has. Also counts score, while ignoring aces for now.
            {
                score += cardVal[(int)cards];

                if ((int)cards > 0 & (int)cards < 5) // If card is an ace.
                {
                    NumAces++;
                }
            }

            if (NumAces > 0) // Score calculation if user has one or more aces.
            {
                if ((NumAces + 10 + score) <= 21) // Calculates value of aces.
                {
                    AceTotalVal = NumAces + 10; // Here, one ace has a value of 11, while the rest have a value of 1.
                }
                else
                {
                    AceTotalVal = NumAces; // Here, all aces have a value of 1.
                }
            }
            userScore = score + AceTotalVal;
            UserScoreLbl.Text = userScore.ToString();
        }
        #endregion

        #region Dealer Score Calculation
        void CalcD(int card1) // Calculates dealer score after drawing first card.
        {
            if (card1 > 0 & card1 < 5) // If card is an ace.
            {
                dealerScore = 11;
            }
            else
            {
                dealerScore = cardVal[card1];
            }
            DealerScoreLbl.Text = dealerScore.ToString(); ;
        }

        void CalcD()  // Calculates dealer score for 2 or more cards.
        {
            int NumAces = 0; // Number of aces the dealer has.
            int AceTotalVal = 0; // Total value of aces the dealer has.
            int score = 0; // Dealer score, ignoring value of aces.

            foreach (var cards in dealer) // Counts how many aces the dealer has. Also counts score, while ignoring aces for now.
            {
                score += cardVal[(int)cards];

                if ((int)cards > 0 & (int)cards < 5) // If card is an ace.
                {
                    NumAces++;
                }
            }

            if (NumAces > 0) // Score calculation if dealer has one or more aces.
            {
                if ((NumAces + 10 + score) <= 21) // Calculates value of aces.
                {
                    AceTotalVal = NumAces + 10; // Here, one ace has a value of 11, while the rest have a value of 1.
                }
                else
                {
                    AceTotalVal = NumAces; // Here, all aces have a value of 1.
                }
            }
            dealerScore = score + AceTotalVal;
            DealerScoreLbl.Text = dealerScore.ToString();
        }
        #endregion
        #endregion

        #region Events
        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            // Exits the application.
        }

        private void StartNewGameBtn_Click(object sender, EventArgs e)
        {
            GamePart1();
            // Calls the GamePart1() method, where the game starts.
        }

        private void NewGameMenuItem_Click(object sender, EventArgs e)
        {
            // Resets all scores, clears the scoreboard and then calls the GamePart1() method to start the game again.
            wincount = 0;
            losecount = 0;
            tiecount = 0;
            gamesPlayed = 0;

            scoreBoard.Win(0);
            scoreBoard.Lose(0);
            scoreBoard.Tie(0);
            scoreBoard.Played(0);

            GamePart1();
        }

        private void StandBtn_Click(object sender, EventArgs e)
        {
            GamePart2();
            // Calls the GamePart2() method, the second part of the game. The dealer's turn.
        }

        private void HitBtn_Click(object sender, EventArgs e)
        {
            UserHit();
            // Calls UserHit() method, which draws a card for the user.
        }

        private void DealBtn_Click(object sender, EventArgs e)
        {
            GamePart1();
            // Starts a new round.
        }
        private void ScoreboardMenuItem_Click(object sender, EventArgs e)
        {
            scoreBoard.ShowDialog();
            // Shows the scoreboard.
        }
        #endregion

        private void HowtoPlayMenuItem_Click(object sender, EventArgs e)
        {
            How_To_Play viewPlay = new How_To_Play();
            try
            {
                viewPlay.ShowDialog();
            }
            catch (System.ObjectDisposedException) // The How To Play form closes when a file is missing, causing the "Object Disposed Exception". This statement catches the exception.
            {
            }
        }
    }
}
