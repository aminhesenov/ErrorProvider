namespace ErrorProvider
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == string.Empty)
            {
                errorProvider1.SetError(textBox1, "Username empty");
            }
            else
            {
                errorProvider1.Clear();

            }
            if(textBox2.Text == string.Empty)
            {
                errorProvider2.SetError(textBox2, "Password empty");
            }
            else
            {
                errorProvider2.Clear();
            }

        }
    }
}
