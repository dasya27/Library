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
    public partial class FormAddIssues : Form
    {
        private NpgsqlConnection con;
        private string conString =
            "Host = 127.0.0.1; Username = postgres; Password = melman; Database = Library";
        public FormAddIssues()
        {
            InitializeComponent();
            con = new NpgsqlConnection(conString);
            con.Open();
            loadIssues();

            string sql = "SELECT name, surname, lastname FROM students";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            comboBoxStudent.Items.Clear();
            while (reader.Read())
            {
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string sql = "SELECT id, name, surname, lastname FROM students";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            int student_id = 0;
            while (reader.Read())
            {
                //comboBoxTour.Items.Add(reader.GetString(0));
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
                //comboBoxTour.Items.Add(reader.GetString(0));
                if (comboBoxBook.SelectedItem.ToString() == reader1.GetString(1))
                {
                    book_id = Convert.ToInt32(reader1.GetValue(0));
                }
            }
            reader1.Close();

            

            if (this.checkBoxReturn.Checked)
            {
                string sql2 = "INSERT INTO issues(student_id, book_id, start_date, end_date, return_date) VALUES(@student_id, @book_id, @start_date, @end_date, @return_date)";
                NpgsqlCommand cmd2 = new NpgsqlCommand(sql2, con);
                cmd2.Parameters.AddWithValue("student_id", student_id);
                cmd2.Parameters.AddWithValue("book_id", book_id);
                cmd2.Parameters.AddWithValue("start_date", this.startDate.Value);
                cmd2.Parameters.AddWithValue("end_date", this.endDate.Value);
                cmd2.Parameters.AddWithValue("return_date", this.returnDate.Value);

                cmd2.Prepare();
                cmd2.ExecuteNonQuery();
            }
            else
            {
                string sql2 = "INSERT INTO issues(student_id, book_id, start_date, end_date) VALUES(@student_id, @book_id, @start_date, @end_date)";
                NpgsqlCommand cmd2 = new NpgsqlCommand(sql2, con);
                cmd2.Parameters.AddWithValue("student_id", student_id);
                cmd2.Parameters.AddWithValue("book_id", book_id);
                cmd2.Parameters.AddWithValue("start_date", this.startDate.Value);
                cmd2.Parameters.AddWithValue("end_date", this.endDate.Value);

                cmd2.Prepare();
                cmd2.ExecuteNonQuery();
            }


            loadIssues();

            this.comboBoxStudent.Text = "";
            this.comboBoxBook.Text = "";
            this.startDate.Text = "";
            this.endDate.Text = "";
            this.endDate.Text = "";
            this.returnDate.Text = "";

        }

        private void numericUpDownCount_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBoxIsCompleted_CheckedChanged(object sender, EventArgs e)
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
