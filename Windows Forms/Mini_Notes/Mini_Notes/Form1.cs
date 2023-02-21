namespace Mini_Notes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Create_Notes crtN = new Create_Notes();
            crtN.Show();
        }

        private void button_notes_Click(object sender, EventArgs e)
        {
            this.Hide();
            MyNotes myn = new MyNotes();
            myn.Show();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}