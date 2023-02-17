using System;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace CRUD_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-TGP1F01;Initial Catalog=CRUD_Test;Integrated Security=True");
        public int UserID;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void UserDataRecords_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetUserRecords();
        }

        private void GetUserRecords()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM InfoTable", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            UserDataRecords.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO InfoTable VALUES (@id, @name, @mob, @blood)", con);
                cmd.CommandType= CommandType.Text;
                cmd.Parameters.AddWithValue("@id", txtUserID.Text);
                cmd.Parameters.AddWithValue("@name", txtUserName.Text);
                cmd.Parameters.AddWithValue("@mob", txtMobile.Text);
                cmd.Parameters.AddWithValue("@blood", txtBlood.Text);


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Succesfully registered!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetUserRecords();
                ResetFromControls();
            }
        }

        private bool IsValid()
        {
            if(txtUserName.Text == string.Empty)
            {
                MessageBox.Show("Username is required!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ResetFromControls();
        }

        private void ResetFromControls()
        {
            txtUserID.Clear();
            txtUserName.Clear();
            txtMobile.Clear();
            txtBlood.Clear();

            txtUserID.Focus();
        }

        private void UserDataRecords_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UserID = Convert.ToInt32(UserDataRecords.Rows[0].Cells[0].Value);
            txtUserID.Text = UserDataRecords.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().ShowDialog();

        }
    }
}
