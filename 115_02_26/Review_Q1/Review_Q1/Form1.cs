namespace Review_Q1
{
    public partial class Form1 : Form
    {
        private int computerChoice;
        private int playerChoice;
        private int playerWins = 0;
        private int computerWins = 0;
        private int ties = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            computerPictureBox.Image = null;
            playerPictureBox.Image = null;
            computerPictureBox.Visible = false;
            playerPictureBox.Visible = false;
            resultLabel.Text = "";
        }

        private void getCompChoice()
        {
            Random random = new Random();
            computerChoice = random.Next(1, 4);
        }

        private void showComputerImage()
        {
            computerPictureBox.Visible = true;
            switch (computerChoice)
            {
                case 1:
                    computerPictureBox.Image = Properties.Resources.stone_computer;
                    break;
                case 2:
                    computerPictureBox.Image = Properties.Resources.paper_computer;
                    break;
                case 3:
                    computerPictureBox.Image = Properties.Resources.scissor_computer;
                    break;
            }
        }

        private void showPlayerImage()
        {
            playerPictureBox.Visible = true;
            switch (playerChoice)
            {
                case 1:
                    playerPictureBox.Image = Properties.Resources.stone_player;
                    break;
                case 2:
                    playerPictureBox.Image = Properties.Resources.paper_player;
                    break;
                case 3:
                    playerPictureBox.Image = Properties.Resources.scissor_player;
                    break;
            }
        }

        private void showWinner()
        {
            if (playerChoice == computerChoice)
            {
                resultLabel.Text = "平手";
                ties++;
            }
            else if ((playerChoice == 1 && computerChoice == 3) ||
                     (playerChoice == 2 && computerChoice == 1) ||
                     (playerChoice == 3 && computerChoice == 2))
            {
                resultLabel.Text = "玩家贏";
                playerWins++;
            }
            else
            {
                resultLabel.Text = "電腦贏";
                computerWins++;
            }
        }

        private void stoneButton_Click(object sender, EventArgs e)
        {
            playerChoice = 1;
            getCompChoice();
            showPlayerImage();
            showComputerImage();
            showWinner();
        }

        private void paperButton_Click(object sender, EventArgs e)
        {
            playerChoice = 2;
            getCompChoice();
            showPlayerImage();
            showComputerImage();
            showWinner();
        }

        private void scissorButton_Click(object sender, EventArgs e)
        {
            playerChoice = 3;
            getCompChoice();
            showPlayerImage();
            showComputerImage();
            showWinner();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            string message = $"遊戲統計：\n\n玩家勝場：{playerWins}\n電腦勝場：{computerWins}\n平手場數：{ties}\n\n感謝您的遊玩！";
            MessageBox.Show(message, "遊戲結束", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }
    }
}
