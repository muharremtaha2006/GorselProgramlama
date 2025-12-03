namespace KelimeOyunu
{
    partial class Form1
    {
        /// <summary>
        /// Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodu 
        /// kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblLetters = new System.Windows.Forms.Label();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.listWords = new System.Windows.Forms.ListBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.lblCenterLetter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLetters
            // 
            this.lblLetters.AutoSize = true;
            this.lblLetters.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblLetters.Location = new System.Drawing.Point(150, 40);
            this.lblLetters.Name = "lblLetters";
            this.lblLetters.Size = new System.Drawing.Size(121, 24);
            this.lblLetters.TabIndex = 0;
            this.lblLetters.Text = "A B C D E F G";
            // 
            // lblCenterLetter
            // 
            this.lblCenterLetter.AutoSize = true;
            this.lblCenterLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCenterLetter.Location = new System.Drawing.Point(150, 70);
            this.lblCenterLetter.Name = "lblCenterLetter";
            this.lblCenterLetter.Size = new System.Drawing.Size(120, 20);
            this.lblCenterLetter.TabIndex = 8;
            this.lblCenterLetter.Text = "Merkez Harf: E";
            // 
            // txtWord
            // 
            this.txtWord.Location = new System.Drawing.Point(154, 100);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(150, 20);
            this.txtWord.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(154, 130);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(80, 25);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Onayla";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnShuffle
            // 
            this.btnShuffle.Location = new System.Drawing.Point(260, 130);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(80, 25);
            this.btnShuffle.TabIndex = 3;
            this.btnShuffle.Text = "Karıştır";
            this.btnShuffle.UseVisualStyleBackColor = true;
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(370, 130);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 25);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Sil";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // listWords
            // 
            this.listWords.FormattingEnabled = true;
            this.listWords.Location = new System.Drawing.Point(520, 90);
            this.listWords.Name = "listWords";
            this.listWords.Size = new System.Drawing.Size(150, 160);
            this.listWords.TabIndex = 5;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblScore.Location = new System.Drawing.Point(360, 40);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(62, 20);
            this.lblScore.TabIndex = 6;
            this.lblScore.Text = "Skor: 0";
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(154, 180);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(150, 30);
            this.btnNewGame.TabIndex = 7;
            this.btnNewGame.Text = "Yeni Oyun";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 300);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.listWords);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnShuffle);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtWord);
            this.Controls.Add(this.lblCenterLetter);
            this.Controls.Add(this.lblLetters);
            this.Name = "Form1";
            this.Text = "Kelime Oyunu - Spelling Bee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLetters;
        private System.Windows.Forms.Label lblCenterLetter;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnShuffle;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListBox listWords;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnNewGame;
    }
}
