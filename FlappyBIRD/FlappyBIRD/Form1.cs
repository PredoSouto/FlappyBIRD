namespace FlappyBIRD
{
    public partial class FlappyBird : Form
    {

        int pipeSpeed = 8;
        int gravity = 5;
        int score = 0;
        public FlappyBird()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void FlappyBird_Load(object sender, EventArgs e)
        {

        }

        private void PIPE_Click(object sender, EventArgs e)
        {

        }

        private void GameTimerEvent(object sender, EventArgs e)
        {

        }

        private void GameKeyisDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -5;
            }
        }

        private void GameKeyisUP(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -5;
            }
        }
    }
}