using Azure;

namespace project
{
    public partial class Form1 : Form
    {
         public string player1Name;
        public string player2Name;
        private string player1Symbol;
        private string player2Symbol;
        bool turn = true;
        string p1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

           

              player1Name = playone.Text;
            player2Name = playtwo.Text;
           
            if (X1.Checked)
            {
                player1Symbol = "X";
                player2Symbol = "O";
            }
            if (O1.Checked)
            {
                player1Symbol = "O";
                player2Symbol = "X";
            }
            playgame();
        }
        public string p_one()
        {
            return player1Name;
        }
        public string p_two()
        {
            return player2Name;
        }
       
        public string sy_one()
        { return player1Symbol;
           
        }
        public string sy_two()
        {
            return player2Symbol;
            

        }

        private void playgame()
        {
            this.Hide();
            GameForm gameForm = new GameForm(this);
            gameForm.ShowDialog();
            this.Close();

           

            
        } 
        public string getplay1(string player1)
        {
            return player1Name;
        }
        public string getplay2(string player2)
        {
            return player2Name;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            choose();

        }

        private void player1_Enter(object sender, EventArgs e)
        {


        }
        public void choose()
        {
            string check = "";
            bool radio = true;
            if (O1.Checked)
            {

                //MessageBox.Show("this player will play with" + O1.Text + "and the other player will play with " + X2.Text);
                X2.Checked = true;
                check = O1.Text;
            }
            if (X1.Checked)
            {
                //MessageBox.Show("this player will play with" + X2.Text + "and the other player will play with " + O1.Text);
                O2.Checked = true;
            }
            if (X2.Checked)
            {
                //MessageBox.Show("this player will play with" + X2.Text + "and the other player will play with " + O1.Text);
                O1.Checked = true;
            }
            if (O2.Checked)
            {
                //MessageBox.Show("this player will play with" + O2.Text + "and the other player will play with " + X1.Text);
                X1.Checked = true;
            }





        }

        private void X_CheckedChanged(object sender, EventArgs e)
        {
            choose();
        }

        private void X2_CheckedChanged(object sender, EventArgs e)
        {
            choose();
        }

        private void O2_CheckedChanged(object sender, EventArgs e)
        {
            choose();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string p1 = playtwo.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void playone_Leave(object sender, EventArgs e)
        {
            
                
              
            
        }
    }
}
