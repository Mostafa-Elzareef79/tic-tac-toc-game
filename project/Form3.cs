using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{


    public partial class Form3 : Form
    {
        SqlConnection con;
        public Form3()
        {
            InitializeComponent();
            con = new SqlConnection("Server=.;Database=game;Trusted_Connection=True;TrustServerCertificate=True");

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Getplayers();
        }
        public void Getplayers()
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = System.Data.CommandType.Text;
            sqlCommand.CommandText = "select [player1Name],[player1Symbol],[player1Score],[player2Name],[player2Symbol],[player2Score] from players;";
            sqlCommand.Connection = con;
            con.Open();

            SqlDataReader reader = sqlCommand.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);

            con.Close();

            contain.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
