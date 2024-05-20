using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class FormChangeBooks : Form
    {
        private NpgsqlConnection con;
        private string conString =
            "Host = 127.0.0.1; Username = postgres; Password = melman; Database = Library";
        public FormChangeBooks()
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbTitle.Text = dataGridView1.SelectedCells[1].Value.ToString();
            tbAuthor.Text = dataGridView1.SelectedCells[2].Value.ToString();
            tbCost.Text = dataGridView1.SelectedCells[3].Value.ToString();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE books SET title = @title, cost = @cost, author = @author WHERE id = @id";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.AddWithValue("title", this.tbTitle.Text);
            cmd.Parameters.AddWithValue("author", this.tbAuthor.Text);
            cmd.Parameters.AddWithValue("cost", Decimal.Parse(tbCost.Text));
            int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            cmd.Parameters.AddWithValue("id", id);
            cmd.Prepare();
            cmd.ExecuteNonQuery();

            loadBooks();

            this.tbTitle.Text = "";
            this.tbAuthor.Text = "";
            this.tbCost.Text = "";
        }
    }
}
