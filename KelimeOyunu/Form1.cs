using System;
using System.Windows.Forms;

namespace KelimeOyunu
{
    public partial class Form1 : Form
    {
        private GameManager game;

        public Form1()
        {
            InitializeComponent();
            game = new GameManager();
            UpdateUI();
        }

        private void UpdateUI()
        {
            lblLetters.Text = string.Join("  ", game.Puzzle.Letters).ToUpper();
            lblCenterLetter.Text = "Merkez Harf: " + game.Puzzle.CenterLetter.ToString().ToUpper();
            lblScore.Text = "Skor: " + game.Score;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string word = txtWord.Text.Trim().ToLower();
            if (word == "") return;

            if (game.TrySubmitWord(word, out int addedScore))
            {
                listWords.Items.Add(word + "  +" + addedScore);
                txtWord.Clear();
                UpdateUI();
            }
            else
            {
                MessageBox.Show("Geçersiz kelime!");
            }
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            game.Shuffle();
            UpdateUI();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtWord.Clear();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            game.StartNewGame();
            listWords.Items.Clear();
            txtWord.Clear();
            UpdateUI();
        }
    }
}
