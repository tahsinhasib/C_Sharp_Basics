using System.Data;
using System.Data.SqlClient;

namespace Mini_Notes
{
    public partial class Create_Notes : Form
    {
        public Create_Notes()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-TGP1F01;Initial Catalog=MINI_NOTES_DB;Integrated Security=True");

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form= new Form1();
            form.ShowDialog();
        }

        private void Create_Notes_Load(object sender, EventArgs e)
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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO NotesTB VALUES (@num, @date, @text)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@num", num_tb.Text);
                cmd.Parameters.AddWithValue("@date", date_tb.Text);
                cmd.Parameters.AddWithValue("@text", text_tb.Text);


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Succesfully registered!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetNotesRecord();
                ResetFromControls();
            }
        }

        private bool isValid()
        {
            if(num_tb.Text == string.Empty)
            {
                MessageBox.Show("No is required!", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public void ResetFromControls()
        {
            num_tb.Clear();
            date_tb.Clear();
            text_tb.Clear();

            num_tb.Focus();
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            ResetFromControls();
        }
    }
}
