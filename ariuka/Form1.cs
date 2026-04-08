using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ariuka
{
    public partial class Form1 : Form
    {
        string connStr = "server=localhost;port=3306;database=movie;uid=root;pwd=P@ssw0rd;";
        public Form1()
        {
            InitializeComponent();
        }
        MySqlConnection GetConnection()
        {
            return new MySqlConnection(connStr);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = GetConnection();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Username or password is wrong");
                return;
            }
            try
            {
                using (var conn = GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT * FROM reviewer WHERE rName = @name AND rPass = @pass";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", txtUserName.Text);
                        cmd.Parameters.AddWithValue("@pass", txtPassword.Text);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                MessageBox.Show("Login succeed");
                                new mainForm().Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Username or password is wrong");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    
