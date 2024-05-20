using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class FormAddBooks : Form
    {
        
        private NpgsqlConnection con;
        private string conString =
            "Host = 127.0.0.1; Username = postgres; Password = melman; Database = Library";


        public FormAddBooks()
        {
            InitializeComponent();
            con = new NpgsqlConnection(conString);
            con.Open();
            loadBooks();
        }

        private void loadBooks()
        {

            DataTable dt = new DataTable();
            NpgsqlDataAdapter adap = new NpgsqlDataAdapter("SELECT * FROM books", con);
            adap.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO books(title, author, cost) VALUES(@title, @author, @cost)";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.AddWithValue("title", this.tbTitle.Text);
            cmd.Parameters.AddWithValue("author", this.tbAuthor.Text);
            cmd.Parameters.AddWithValue("cost", Decimal.Parse(this.tbCost.Text));
            cmd.Prepare();
            cmd.ExecuteNonQuery();

            loadBooks();

            this.tbTitle.Text = "";
            this.tbCost.Text = "";
            this.tbAuthor.Text = "";
        }
    }
}
