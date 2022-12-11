namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // New vars
        bool player = true;
        int mv = 0;
        // After clicking Restart btn, set everything to 0 and player set to O
        private void btnRestart_Click(object sender, EventArgs e)
        {
            Restart();
            scoreO.Text = "0";
            scoreX.Text = "0";
            labelWho.Text = "O";
            player = true;
        }
        // After Restart, reset moves and buttons...
        private void Restart()
        {
            mv = 0;
            Button[] all = new Button[9];
            all[0] = btn1;
            all[1] = btn2;
            all[2] = btn3;
            all[3] = btn4;
            all[4] = btn5;
            all[5] = btn6;
            all[6] = btn7;
            all[7] = btn8;
            all[8] = btn9;
            // ...make it again clickable and empty
            foreach(Button btn in all)
            {
                btn.Enabled = true;
                btn.Text = "";
            }
        }
        // Check if combinations of btns are clicked to win...
        private void Check()
        {
            if (btn1.Text != "" && btn1.Text == btn2.Text && btn2.Text == btn3.Text ||
                btn4.Text != "" && btn4.Text == btn5.Text && btn5.Text == btn6.Text ||
                btn4.Text != "" && btn4.Text == btn5.Text && btn5.Text == btn6.Text ||
                btn7.Text != "" && btn7.Text == btn8.Text && btn8.Text == btn9.Text ||
                btn1.Text != "" && btn1.Text == btn5.Text && btn5.Text == btn9.Text ||
                btn3.Text != "" && btn3.Text == btn5.Text && btn5.Text == btn7.Text ||
                btn1.Text != "" && btn1.Text == btn4.Text && btn4.Text == btn7.Text ||
                btn2.Text != "" && btn2.Text == btn5.Text && btn5.Text == btn8.Text ||
                btn3.Text != "" && btn3.Text == btn6.Text && btn6.Text == btn9.Text)
            {
                Win();
            }
            // ...or else make a tie if all 9 btns are clicked and show message box and restart
            else if (mv == 9)
            {
                MessageBox.Show("Tie", "Game over", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Restart();
            }
        }
        // Show message box if someone won and add one point to O || X and restart
        private void Win()
        {
            MessageBox.Show("Winner: " + (player ? "O" : "X"), "Win", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (player) scoreO.Text = ((int.Parse(scoreO.Text)) + 1).ToString();
            else scoreX.Text = ((int.Parse(scoreX.Text)) + 1).ToString();
            Restart();
        }
        // The next lines are just copy-paste, for every btn
        // Makes next move and if moves are >= 5, it checks a win or nah, also changes label of which player moves
        private void btn1_Click(object sender, EventArgs e)
        {
            mv++;
            ((Button)sender).Text = player ? "O" : "X";
            ((Button)sender).Enabled = false;
            if(mv >= 5)
            {
                Check();
            }
            player = !player;
            labelWho.Text = player ? "O" : "X";
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            mv++;
            ((Button)sender).Text = player ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (mv >= 5)
            {
                Check();
            }
            player = !player;
            labelWho.Text = player ? "O" : "X";
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            mv++;
            ((Button)sender).Text = player ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (mv >= 5)
            {
                Check();
            }
            player = !player;
            labelWho.Text = player ? "O" : "X";
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            mv++;
            ((Button)sender).Text = player ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (mv >= 5)
            {
                Check();
            }
            player = !player;
            labelWho.Text = player ? "O" : "X";
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            mv++;
            ((Button)sender).Text = player ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (mv >= 5)
            {
                Check();
            }
            player = !player;
            labelWho.Text = player ? "O" : "X";
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            mv++;
            ((Button)sender).Text = player ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (mv >= 5)
            {
                Check();
            }
            player = !player;
            labelWho.Text = player ? "O" : "X";
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            mv++;
            ((Button)sender).Text = player ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (mv >= 5)
            {
                Check();
            }
            player = !player;
            labelWho.Text = player ? "O" : "X";
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            mv++;
            ((Button)sender).Text = player ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (mv >= 5)
            {
                Check();
            }
            player = !player;
            labelWho.Text = player ? "O" : "X";
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            mv++;
            ((Button)sender).Text = player ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (mv >= 5)
            {
                Check();
            }
            player = !player;
            labelWho.Text = player ? "O" : "X";
        }
    }
}