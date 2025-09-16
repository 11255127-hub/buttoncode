namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "red light"; pictureBox1.BackColor = Color.Red;
        }






        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "green light";
            pictureBox1.BackColor = Color.Green;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
