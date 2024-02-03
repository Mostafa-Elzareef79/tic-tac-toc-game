using Azure;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{

    public partial class GameForm : Form
    {
        SqlConnection con;
        int count1 = 0;
        int count2 = 0;


        bool turn = false;
        private Form1 form1;
        private string sympole1;
        private string sympole2;
        private int score1;
        private int score2;
        public GameForm(Form1 form1)
        {
            InitializeComponent();
            con = new SqlConnection("Server=.;Database=game;Trusted_Connection=True;TrustServerCertificate=True");



            this.form1 = form1;
        }


        private void GameForm_Load(object sender, EventArgs e)
        {
            sympole1 = form1.sy_one();
            sympole2 = form1.sy_two();



            MessageBox.Show(label3.Text);

        }





        public void btnOff()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button5.Enabled = false;
            button4.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;

        }
        public void btnOn_btnEmpty()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button5.Enabled = true;
            button4.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button1.Text = string.Empty;
            button2.Text = string.Empty;
            button3.Text = string.Empty;
            button4.Text = string.Empty;
            button5.Text = string.Empty;
            button6.Text = string.Empty;
            button7.Text = string.Empty;
            button8.Text = string.Empty;
            button9.Text = string.Empty;


        }
        public void xWin()
        {
            if (label5.Text == "X")
            {
                score1 = count1++;
                label7.Text = count1.ToString();
            }
            if (label6.Text == "X")
            {
                score2 = count2++;
                label8.Text = count2.ToString();
            }
            MessageBox.Show(label3.Text + " winer");
        }
        public void oWin()
        {
            if (label5.Text == "O")
            {
                score1 = count1++;
                label7.Text = count1.ToString();
            }
            if (label6.Text == "O")
            {
                score2 = count2++;
                label8.Text = count2.ToString();
            }
            MessageBox.Show(label4.Text + " winer");
        }
        public void win()
        {
            if (button7.Text == "X" && button4.Text == "X" && button1.Text == "X")
            {

                xWin();


                btnOff();


            }
            else if (button7.Text == "O" && button4.Text == "O" && button1.Text == "O")
            {
                oWin();
                btnOff();


            }
            else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                oWin();

                btnOff();

            }
            else if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                xWin();

                btnOff();


            }
            else if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                xWin();
                btnOff();


            }
            else if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                oWin();
                btnOff();

            }
            else if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                xWin();
                btnOff();

            }
            else if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                oWin();
                btnOff();


            }
            else if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                oWin();
                btnOff();


            }
            else if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                xWin();

                btnOff();

            }

            else if (button7.Text == "X" && button5.Text == "X" && button3.Text == "X")
            {
                xWin();
                btnOff();



            }
            else if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                xWin();
                btnOff();



            }
            else if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                xWin();


                btnOff();

            }
            else if (button7.Text == "O" && button5.Text == "O" && button3.Text == "O")
            {
                oWin();
                btnOff();


            }
            else if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                oWin();
                btnOff();



            }
            else if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                oWin();
                btnOff();



            }
            else if ( button1.Text != "" && button2.Text != "" && button3.Text != "" && button4.Text != "" && button5.Text != "" && button6.Text != "" && button7.Text != "" && button8.Text != "" && button9.Text != "")
            {
                MessageBox.Show("drawen game");
            }

        }
        private void button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn) { b.Text = label6.Text; }
            else { b.Text = label5.Text; }
            b.Enabled = false;
            turn = !turn;


            win();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            win();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            win();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            win();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            win();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            win();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            win();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            win();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            win();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            btnOn_btnEmpty();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {


        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void GameForm_Load_1(object sender, EventArgs e)
        {
            label7.Text = score1.ToString();
            label8.Text = score2.ToString();
            label3.Text = form1.p_one();
            label4.Text = form1.p_two();
            label5.Text = form1.sy_one();
            label6.Text = form1.sy_two();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            score1 = 0;
            score2 = 0;
            label7.Text = 0.ToString();
            label8.Text = 0.ToString();

            btnOn_btnEmpty();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand($"insert into players([player1Name],[player2Name],[player1Score],[player2Score],[player1Symbol],[player2Symbol]) values(@name1,@name2,@score1,@score2,@symbol1,@symbol2)", con);
            cmd.Parameters.AddWithValue("name1", label3.Text);
            cmd.Parameters.AddWithValue("name2", label4.Text);
            cmd.Parameters.AddWithValue("score1", label7.Text);
            cmd.Parameters.AddWithValue("score2", label8.Text);
            cmd.Parameters.AddWithValue("symbol1", label5.Text);
            cmd.Parameters.AddWithValue("symbol2", label6.Text);
            int rowsEffected = 0;
            try
            {

                con.Open();

                rowsEffected = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

                con.Close();
            }

            if (rowsEffected > 0)
            {
                MessageBox.Show("Data was insereted");

            }
            Form3 form3 = new Form3();
            this.Hide();

            form3.ShowDialog();
            this.Close();
        }
    }

}
