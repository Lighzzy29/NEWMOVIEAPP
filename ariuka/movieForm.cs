using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ariuka
{
    public partial class movieForm : Form
    {
        string connStr = "server=localhost;port=3306;database=movie;uid=root;pwd=P@ssw0rd;";
        public movieForm()
        {
            InitializeComponent();
        }
        MySqlConnection GetConnection()
        {
            return new MySqlConnection(connStr);
        }

        private void movieForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            try
            {
                using (var conn = GetConnection())
                {
                    conn.Open();
                    MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM movie;", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvMovie.DataSource = dt;

                    dgvMovie.Columns["movieid"].HeaderText = "ID";
                    dgvMovie.Columns["title"].HeaderText = "Movie Name";
                    dgvMovie.Columns["year1"].HeaderText = "Year";
                    dgvMovie.Columns["Director"].HeaderText = "Director";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvMovie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMovie.CurrentRow != null)
            {
                DataGridViewRow row = dgvMovie.CurrentRow;

                txtID.Text = row.Cells["movieID"].Value?.ToString();
                txtTitle.Text = row.Cells["title"].Value?.ToString();
                txtYear.Text = row.Cells["year1"].Value?.ToString();
                txtDirector.Text = row.Cells["director"].Value?.ToString();

                string FileName = $@"{AppDomain.CurrentDomain.BaseDirectory}images\{txtID.Text}.jpg";
                string imgFileName = $@"{AppDomain.CurrentDomain.BaseDirectory}images\Nothing.jpg";
                if (File.Exists(FileName))
                {
                    imgFileName = FileName;
                }
                picMovie.Image = Image.FromFile(imgFileName);
            }
        }

        private void btnUptade_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Select the movie");
                return;
            }
            try
            {
                using (var conn = GetConnection())
                {
                    conn.Open();
                    string sql = "UPDATE movie SET title=@title, year1=@year1, director=@director WHERE movieID=@movieID;";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@title", txtTitle.Text);
                    cmd.Parameters.AddWithValue("@year1", Convert.ToInt32(txtYear.Text));
                    cmd.Parameters.AddWithValue("@director", txtDirector.Text);
                    cmd.Parameters.AddWithValue("@movieID", txtID.Text);
                    cmd.ExecuteNonQuery();
                }
                LoadData();
                MessageBox.Show("Uptade confirmed...");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text) || string.IsNullOrWhiteSpace(txtTitle.Text) || string.IsNullOrWhiteSpace(txtYear.Text) || string.IsNullOrWhiteSpace(txtDirector.Text))
            {
                MessageBox.Show("Enter your data");
                return;
            }
            try
            {
                using (var conn = GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT * FROM movie WHERE movieID = @id";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", txtID.Text);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                MessageBox.Show(txtID.Text + "Registered the movie ");
                            }
                            else
                            {
                                insertData();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }
        void insertData()
        {
            try
            {
                using (var conn = GetConnection())
                {
                    conn.Open();
                    string sql = "INSERT INTO movie (movieID, title, year1, director) VALUES (@movieID, @title, @year1, @director);";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@title", txtTitle.Text);
                    cmd.Parameters.AddWithValue("@year1", txtYear.Text);
                    cmd.Parameters.AddWithValue("@director", txtDirector.Text);
                    cmd.Parameters.AddWithValue("@movieID", txtID.Text);
                    cmd.ExecuteNonQuery();
                }
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }
    }
}
