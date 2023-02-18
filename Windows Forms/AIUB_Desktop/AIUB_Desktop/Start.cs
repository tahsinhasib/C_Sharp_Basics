namespace AIUB_Desktop
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel3.Width += 3;

            if(panel3.Width >= 599 )
            {
                timer1.Stop();
                Login lgn = new Login();
                lgn.Show();
                this.Hide();
            }
        }
    }
}