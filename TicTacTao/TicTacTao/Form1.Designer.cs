namespace TicTacTao
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PlayerName1 = new System.Windows.Forms.TextBox();
            this.PlayerName2 = new System.Windows.Forms.TextBox();
            this.PlayerDesign = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.XOChoiceTwoPlayer = new System.Windows.Forms.TextBox();
            this.XOChoiceOnePlayer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PlayerNameOne = new System.Windows.Forms.Label();
            this.StartGame = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TicTacToeGame = new System.Windows.Forms.GroupBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.PlayerTwoNameDisplay = new System.Windows.Forms.TextBox();
            this.PlayerOneNameDisplay = new System.Windows.Forms.TextBox();
            this.SaveGame = new System.Windows.Forms.Button();
            this.RestartGame = new System.Windows.Forms.Button();
            this.PyTwo = new System.Windows.Forms.Label();
            this.PyOne = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.PlayerDesign.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.TicTacToeGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlayerName1
            // 
            this.PlayerName1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PlayerName1.Location = new System.Drawing.Point(194, 76);
            this.PlayerName1.Multiline = true;
            this.PlayerName1.Name = "PlayerName1";
            this.PlayerName1.Size = new System.Drawing.Size(188, 27);
            this.PlayerName1.TabIndex = 5;
            this.PlayerName1.UseWaitCursor = true;
            this.PlayerName1.TextChanged += new System.EventHandler(this.PlayerName1_TextChanged);
            // 
            // PlayerName2
            // 
            this.PlayerName2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PlayerName2.Location = new System.Drawing.Point(194, 160);
            this.PlayerName2.Name = "PlayerName2";
            this.PlayerName2.Size = new System.Drawing.Size(188, 27);
            this.PlayerName2.TabIndex = 6;
            this.PlayerName2.UseWaitCursor = true;
            this.PlayerName2.TextChanged += new System.EventHandler(this.PlayerName2_TextChanged);
            // 
            // PlayerDesign
            // 
            this.PlayerDesign.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PlayerDesign.BackColor = System.Drawing.SystemColors.ControlDark;
            this.PlayerDesign.Controls.Add(this.label3);
            this.PlayerDesign.Controls.Add(this.label2);
            this.PlayerDesign.Controls.Add(this.XOChoiceTwoPlayer);
            this.PlayerDesign.Controls.Add(this.XOChoiceOnePlayer);
            this.PlayerDesign.Controls.Add(this.label1);
            this.PlayerDesign.Controls.Add(this.PlayerNameOne);
            this.PlayerDesign.Controls.Add(this.StartGame);
            this.PlayerDesign.Controls.Add(this.PlayerName2);
            this.PlayerDesign.Controls.Add(this.PlayerName1);
            this.PlayerDesign.Location = new System.Drawing.Point(3, 12);
            this.PlayerDesign.Name = "PlayerDesign";
            this.PlayerDesign.Size = new System.Drawing.Size(595, 334);
            this.PlayerDesign.TabIndex = 7;
            this.PlayerDesign.TabStop = false;
            this.PlayerDesign.Text = "Tic-Tac-Toe";
            this.PlayerDesign.UseWaitCursor = true;
            this.PlayerDesign.Enter += new System.EventHandler(this.PlayerDesign_Enter);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(429, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 28);
            this.label3.TabIndex = 13;
            this.label3.Text = "X/O";
            this.label3.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(429, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 28);
            this.label2.TabIndex = 12;
            this.label2.Text = "X/O";
            this.label2.UseWaitCursor = true;
            // 
            // XOChoiceTwoPlayer
            // 
            this.XOChoiceTwoPlayer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.XOChoiceTwoPlayer.Location = new System.Drawing.Point(512, 160);
            this.XOChoiceTwoPlayer.Name = "XOChoiceTwoPlayer";
            this.XOChoiceTwoPlayer.Size = new System.Drawing.Size(43, 27);
            this.XOChoiceTwoPlayer.TabIndex = 11;
            this.XOChoiceTwoPlayer.UseWaitCursor = true;
            this.XOChoiceTwoPlayer.TextChanged += new System.EventHandler(this.XOChoiceTwoPlayer_TextChanged);
            // 
            // XOChoiceOnePlayer
            // 
            this.XOChoiceOnePlayer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.XOChoiceOnePlayer.Location = new System.Drawing.Point(512, 68);
            this.XOChoiceOnePlayer.Name = "XOChoiceOnePlayer";
            this.XOChoiceOnePlayer.Size = new System.Drawing.Size(43, 27);
            this.XOChoiceOnePlayer.TabIndex = 10;
            this.XOChoiceOnePlayer.UseWaitCursor = true;
            this.XOChoiceOnePlayer.TextChanged += new System.EventHandler(this.XOChoiceOnePlayer_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(33, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 28);
            this.label1.TabIndex = 9;
            this.label1.Text = "PlayerName2";
            this.label1.UseWaitCursor = true;
            // 
            // PlayerNameOne
            // 
            this.PlayerNameOne.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PlayerNameOne.AutoSize = true;
            this.PlayerNameOne.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PlayerNameOne.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PlayerNameOne.Location = new System.Drawing.Point(33, 70);
            this.PlayerNameOne.Name = "PlayerNameOne";
            this.PlayerNameOne.Size = new System.Drawing.Size(139, 28);
            this.PlayerNameOne.TabIndex = 8;
            this.PlayerNameOne.Text = "PlayerName1";
            this.PlayerNameOne.UseWaitCursor = true;
            // 
            // StartGame
            // 
            this.StartGame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StartGame.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StartGame.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.StartGame.Location = new System.Drawing.Point(166, 240);
            this.StartGame.Name = "StartGame";
            this.StartGame.Size = new System.Drawing.Size(256, 61);
            this.StartGame.TabIndex = 7;
            this.StartGame.Text = "Start Game";
            this.StartGame.UseVisualStyleBackColor = true;
            this.StartGame.UseWaitCursor = true;
            this.StartGame.Click += new System.EventHandler(this.StartGame_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TicTacToeGame);
            this.groupBox1.Controls.Add(this.PlayerTwoNameDisplay);
            this.groupBox1.Controls.Add(this.PlayerOneNameDisplay);
            this.groupBox1.Controls.Add(this.SaveGame);
            this.groupBox1.Controls.Add(this.RestartGame);
            this.groupBox1.Controls.Add(this.PyTwo);
            this.groupBox1.Controls.Add(this.PyOne);
            this.groupBox1.Location = new System.Drawing.Point(604, 88);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(881, 763);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tic-Tac-Toe";
            this.groupBox1.UseWaitCursor = true;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // TicTacToeGame
            // 
            this.TicTacToeGame.Controls.Add(this.button9);
            this.TicTacToeGame.Controls.Add(this.button8);
            this.TicTacToeGame.Controls.Add(this.button7);
            this.TicTacToeGame.Controls.Add(this.button6);
            this.TicTacToeGame.Controls.Add(this.button5);
            this.TicTacToeGame.Controls.Add(this.button4);
            this.TicTacToeGame.Controls.Add(this.button3);
            this.TicTacToeGame.Controls.Add(this.button2);
            this.TicTacToeGame.Controls.Add(this.button1);
            this.TicTacToeGame.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TicTacToeGame.Location = new System.Drawing.Point(37, 108);
            this.TicTacToeGame.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TicTacToeGame.Name = "TicTacToeGame";
            this.TicTacToeGame.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TicTacToeGame.Size = new System.Drawing.Size(605, 460);
            this.TicTacToeGame.TabIndex = 6;
            this.TicTacToeGame.TabStop = false;
            this.TicTacToeGame.Text = "Tic-Tac-Toe Game";
            this.TicTacToeGame.UseWaitCursor = true;
            this.TicTacToeGame.Enter += new System.EventHandler(this.TicTacToeGame_Enter);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(399, 314);
            this.button9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(188, 130);
            this.button9.TabIndex = 8;
            this.button9.Text = "button9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.UseWaitCursor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(206, 314);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(188, 130);
            this.button8.TabIndex = 7;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.UseWaitCursor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 314);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(188, 130);
            this.button7.TabIndex = 6;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.UseWaitCursor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(399, 177);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(188, 130);
            this.button6.TabIndex = 5;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.UseWaitCursor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(206, 177);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(188, 130);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.UseWaitCursor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 177);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(188, 130);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.UseWaitCursor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(399, 39);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(188, 130);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.UseWaitCursor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(206, 39);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 130);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.UseWaitCursor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 39);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 130);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.UseWaitCursor = true;
            // 
            // PlayerTwoNameDisplay
            // 
            this.PlayerTwoNameDisplay.Enabled = false;
            this.PlayerTwoNameDisplay.Location = new System.Drawing.Point(126, 584);
            this.PlayerTwoNameDisplay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PlayerTwoNameDisplay.Multiline = true;
            this.PlayerTwoNameDisplay.Name = "PlayerTwoNameDisplay";
            this.PlayerTwoNameDisplay.Size = new System.Drawing.Size(162, 34);
            this.PlayerTwoNameDisplay.TabIndex = 5;
            this.PlayerTwoNameDisplay.UseWaitCursor = true;
            this.PlayerTwoNameDisplay.TextChanged += new System.EventHandler(this.PlayerTwoNameDisplay_TextChanged);
            // 
            // PlayerOneNameDisplay
            // 
            this.PlayerOneNameDisplay.Enabled = false;
            this.PlayerOneNameDisplay.Location = new System.Drawing.Point(126, 40);
            this.PlayerOneNameDisplay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PlayerOneNameDisplay.Multiline = true;
            this.PlayerOneNameDisplay.Name = "PlayerOneNameDisplay";
            this.PlayerOneNameDisplay.Size = new System.Drawing.Size(162, 32);
            this.PlayerOneNameDisplay.TabIndex = 4;
            this.PlayerOneNameDisplay.UseWaitCursor = true;
            this.PlayerOneNameDisplay.TextChanged += new System.EventHandler(this.PlayerOneNameDisplay_TextChanged);
            // 
            // SaveGame
            // 
            this.SaveGame.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SaveGame.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SaveGame.Location = new System.Drawing.Point(538, 668);
            this.SaveGame.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SaveGame.Name = "SaveGame";
            this.SaveGame.Size = new System.Drawing.Size(225, 69);
            this.SaveGame.TabIndex = 3;
            this.SaveGame.Text = "Save Game";
            this.SaveGame.UseVisualStyleBackColor = true;
            this.SaveGame.UseWaitCursor = true;
            this.SaveGame.Click += new System.EventHandler(this.SaveGame_Click);
            // 
            // RestartGame
            // 
            this.RestartGame.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RestartGame.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RestartGame.Location = new System.Drawing.Point(115, 668);
            this.RestartGame.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RestartGame.Name = "RestartGame";
            this.RestartGame.Size = new System.Drawing.Size(233, 69);
            this.RestartGame.TabIndex = 2;
            this.RestartGame.Text = "Restart Game";
            this.RestartGame.UseVisualStyleBackColor = true;
            this.RestartGame.UseWaitCursor = true;
            this.RestartGame.Click += new System.EventHandler(this.RestartGame_Click);
            // 
            // PyTwo
            // 
            this.PyTwo.AutoSize = true;
            this.PyTwo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PyTwo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PyTwo.Location = new System.Drawing.Point(7, 584);
            this.PyTwo.Name = "PyTwo";
            this.PyTwo.Size = new System.Drawing.Size(113, 32);
            this.PyTwo.TabIndex = 1;
            this.PyTwo.Text = "Player 2:";
            this.PyTwo.UseWaitCursor = true;
            // 
            // PyOne
            // 
            this.PyOne.AutoSize = true;
            this.PyOne.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PyOne.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PyOne.Location = new System.Drawing.Point(7, 40);
            this.PyOne.Name = "PyOne";
            this.PyOne.Size = new System.Drawing.Size(113, 32);
            this.PyOne.TabIndex = 0;
            this.PyOne.Text = "Player 1:";
            this.PyOne.UseWaitCursor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::TicTacTao.Properties.Resources.BackGround;
            this.ClientSize = new System.Drawing.Size(1489, 859);
            this.Controls.Add(this.PlayerDesign);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic-Tac-Tao";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PlayerDesign.ResumeLayout(false);
            this.PlayerDesign.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.TicTacToeGame.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private TextBox PlayerName1;
        private TextBox PlayerName2;
        private GroupBox PlayerDesign;
        private Button StartGame;
        private Label PlayerNameOne;
        private Label label1;
        private Label label2;
        private TextBox XOChoiceTwoPlayer;
        private TextBox XOChoiceOnePlayer;
        private Label label3;
        private GroupBox groupBox1;
        private Label PyTwo;
        private Label PyOne;
        private System.Windows.Forms.Timer timer1;
        private Button RestartGame;
        private Button SaveGame;
        private ImageList imageList1;
        private TextBox PlayerTwoNameDisplay;
        private TextBox PlayerOneNameDisplay;
        private GroupBox TicTacToeGame;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}