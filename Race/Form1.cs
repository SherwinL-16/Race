namespace Race
{
    public partial class Form1 : Form
    {
        private RaceGames raceGame;
        public int FinishLineX { get; private set; }
        public Form1()
        {
            InitializeComponent();
            raceGame = new RaceGames(this);
            FinishLineX = this.Width - 100; // Adjust finish line
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            lblCountdown.Text = "3"; await Task.Delay(1000);
            lblCountdown.Text = "2"; await Task.Delay(1000);
            lblCountdown.Text = "1"; await Task.Delay(1000);
            lblCountdown.Text = "Go!"; await Task.Delay(500);
            lblCountdown.Text = "";

            raceGame.StartRace();
            btnStart.Enabled = true;
        }


        private void btnRestart_Click(object sender, EventArgs e)
        {
            raceGame.RestartRace();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            raceGame.QuitGame();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblRunner2_Click(object sender, EventArgs e)
        {

        }
    }
}
