namespace Tugas_Login_Page
{
    public partial class Form1 : Form
    {
        readonly string Username = "Muiz";
        readonly string password = "123";
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == Username && txtPassword.Text == password)
            {
                new Form2().Show();
                this.Hide();
            }

            else if(txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Mohon Masukkan Username dan Password");
            }

            else
            {
                MessageBox.Show("Username atau Password salah, \ncoba lagi");
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Password_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}