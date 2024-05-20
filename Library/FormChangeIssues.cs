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
using System.Xml.Linq;

namespace Library
{
    public partial class FormChangeIssues : Form
    {
        bool fl = false;
        private NpgsqlConnection con;
        private string conString =
            "Host = 127.0.0.1; Username = postgres; Password = melman; Database = Library";
        public FormChangeIssues()
        {
            InitializeComponent();
            con = new NpgsqlConnection(conString);
            con.Open();
            loadIssues();

            // запрашиваем все имена и фамилии
            string sql = "SELECT name, surname, lastname FROM students";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
            NpgsqlDataReader reader = cmd.ExecuteReader();

            // очищаем наш список
            comboBoxStudent.Items.Clear();

            // читаем запрос из БД
            while (reader.Read())
            {
                // добавляем в список прочитанные данные
                comboBoxStudent.Items.Add(reader.GetString(0) + " " + reader.GetString(1) + " " + reader.GetString(2));
            }
            reader.Close();


            string sql1 = "SELECT title FROM books";
            NpgsqlCommand cmd1 = new NpgsqlCommand(sql1, con);
            NpgsqlDataReader reader1 = cmd1.ExecuteReader();
            comboBoxBook.Items.Clear();
            while (reader1.Read())
            {
                comboBoxBook.Items.Add(reader1.GetString(0));
            }
            reader1.Close();

            this.returnDate.Visible = false;
            this.label5.Visible = false;

        }

        // загружаем все из бд
        private void loadIssues()
        {
            DataTable dt = new DataTable();
            NpgsqlDataAdapter adap = new NpgsqlDataAdapter("SELECT * FROM issues", con);
            adap.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            string sql = "SELECT id, name, surname, lastname FROM students";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            //int client_id = 0;
            while (reader.Read())
            {
                if (int.Parse(dataGridView1.SelectedCells[1].Value.ToString()) == int.Parse(reader.GetValue(0).ToString()))
                {
                    comboBoxStudent.SelectedItem = reader.GetString(1) + " " + reader.GetString(2) + " " + reader.GetString(3);
                }
            }
            reader.Close();

            string sql1 = "SELECT id, title FROM books";
            NpgsqlCommand cmd1 = new NpgsqlCommand(sql1, con);
            NpgsqlDataReader reader1 = cmd1.ExecuteReader();
            //int product_id = 0;
            while (reader1.Read())
            {
                //comboBoxTour.Items.Add(reader.GetString(0));17
                if (dataGridView1.SelectedCells[2].Value.ToString() == reader1.GetValue(0).ToString())
                {
                    comboBoxBook.SelectedItem = reader1.GetString(1);
                }
            }
            reader1.Close();


            //this.comboBoxClient.Text = dataGridView1.SelectedCells[1].Value.ToString();
            //this.comboBoxProduct.Text = dataGridView1.SelectedCells[2].Value.ToString();
            this.startDate.Text = dataGridView1.SelectedCells[3].Value.ToString();
            this.endDate.Text = dataGridView1.SelectedCells[4].Value.ToString();
            this.returnDate.Text = dataGridView1.SelectedCells[5].Value.ToString();
            fl = true;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string sql = "SELECT id, name, surname, lastname FROM students";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            int student_id = 0;
            while (reader.Read())
            {
                
                if (comboBoxStudent.SelectedItem.ToString() == reader.GetString(1) + " " + reader.GetString(2) + " " + reader.GetString(3))
                {
                    student_id = Convert.ToInt32(reader.GetValue(0));
                }
            }
            reader.Close();

            string sql1 = "SELECT id, title FROM books";
            NpgsqlCommand cmd1 = new NpgsqlCommand(sql1, con);
            NpgsqlDataReader reader1 = cmd1.ExecuteReader();
            int book_id = 0;
            while (reader1.Read())
            {
                
                if (comboBoxBook.SelectedItem.ToString() == reader1.GetString(1))
                {
                    book_id = Convert.ToInt32(reader1.GetValue(0));
                }
            }
            reader1.Close();

            if (this.checkBoxReturn.Checked)
            {
                string sql2 = "UPDATE issues SET student_id = @student_id, book_id = @book_id, start_date = @start_date, end_date = @end_date, return_date = @return_date  WHERE id = @id";
                NpgsqlCommand cmd2 = new NpgsqlCommand(sql2, con);
                cmd2.Parameters.AddWithValue("student_id", student_id);
                cmd2.Parameters.AddWithValue("book_id", book_id);
                cmd2.Parameters.AddWithValue("start_date", this.startDate.Value);
                cmd2.Parameters.AddWithValue("end_date", this.endDate.Value);
                cmd2.Parameters.AddWithValue("return_date", this.returnDate.Value);
                int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                cmd2.Parameters.AddWithValue("id", id);
                cmd2.Prepare();
                cmd2.ExecuteNonQuery();
            }
            else
            {
                string sql2 = "UPDATE issues SET student_id = @student_id, book_id = @book_id, start_date = @start_date, end_date = @end_date  WHERE id = @id";
                NpgsqlCommand cmd2 = new NpgsqlCommand(sql2, con);
                cmd2.Parameters.AddWithValue("student_id", student_id);
                cmd2.Parameters.AddWithValue("book_id", book_id);
                cmd2.Parameters.AddWithValue("start_date", this.startDate.Value);
                cmd2.Parameters.AddWithValue("end_date", this.endDate.Value);
                int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                cmd2.Parameters.AddWithValue("id", id);
                cmd2.Prepare();
                cmd2.ExecuteNonQuery();
            }

            loadIssues();

            this.comboBoxStudent.Text = "";
            this.comboBoxBook.Text = "";
            this.startDate.Text = "";
            this.endDate.Text = "";
            this.returnDate.Text = "";
        }

        private void numericUpDownCount_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBoxReturn_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxReturn.Checked)
            {
                this.returnDate.Visible = true;
                this.label5.Visible = true;
            }
            else
            {
                this.returnDate.Visible = false;
                this.label5.Visible = false;
            }
        }
    }
}
