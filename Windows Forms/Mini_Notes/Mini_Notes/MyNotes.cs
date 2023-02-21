using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Mini_Notes
{
    public partial class MyNotes : Form 
    {
        public MyNotes()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-TGP1F01;Initial Catalog=MINI_NOTES_DB;Integrated Security=True");
        public int NoteID;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NoteID = Convert.ToInt32(notesdatagridview.SelectedRows[0].Cells[0].Value);
            date_tb.Text = notesdatagridview.SelectedRows[0].Cells[1].Value.ToString();
            text_tb.Text = notesdatagridview.SelectedRows[0].Cells[2].Value.ToString();
            
        }

        private void MyNotes_Load(object sender, EventArgs e)
        {
            GetNotesRecord();
        }

        private void GetNotesRecord()
        {
            SqlCommand cmd = new SqlCommand("select * from NotesTB", con);

            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            notesdatagridview.DataSource= dt;
        }

        private void num_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if(NoteID > 0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE NotesTB SET Date = @date, Description = @text WHERE Number = @num", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@date", date_tb.Text);
                cmd.Parameters.AddWithValue("@text", text_tb.Text);
                cmd.Parameters.AddWithValue("@num", this.NoteID);


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Succesfully Updated!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetNotesRecord();
                ResetFromControls();
            }
            else
            {
                MessageBox.Show("Please select to update information!", "Select", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void ResetFromControls()
        {
            NoteID = 0;
            num_tb.Clear();
            date_tb.Clear();
            text_tb.Clear();

            num_tb.Focus();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if(NoteID > 0)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM NotesTB WHERE Number = @num", con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@num", this.NoteID);


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Note deleted!!", "Deleted!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetNotesRecord();
                ResetFromControls();
            }
            else
            {
                MessageBox.Show("Please select to delete information!", "Select", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            ResetFromControls();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
        }
    }
}
