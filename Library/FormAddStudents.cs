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
    public partial class FormAddClients : Form
    {
        private NpgsqlConnection con;
        private string conString =
            "Host = 127.0.0.1; Username = postgres; Password = melman; Database = Library";
        public FormAddClients()
        {
            InitializeComponent();
            con = new NpgsqlConnection(conString);
            con.Open();
            loadStudents();
        }

        private void loadStudents()
        {
            DataTable dt = new DataTable();
            NpgsqlDataAdapter adap = new NpgsqlDataAdapter("SELECT * FROM students", con);
            adap.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string sql1 = "INSERT INTO students(lastname, name, surname, uni_name) VALUES(@lastname, @name, @surname, @uni_name)";
            NpgsqlCommand cmd1 = new NpgsqlCommand(sql1, con);
            cmd1.Parameters.AddWithValue("lastname", this.tbLastname.Text);
            cmd1.Parameters.AddWithValue("name", this.tbName.Text);
            cmd1.Parameters.AddWithValue("surname", this.tbSurname.Text);
            cmd1.Parameters.AddWithValue("uni_name", this.tbUniName.Text);
            cmd1.Prepare();
            cmd1.ExecuteNonQuery();

            loadStudents();

            // очистка полей
            this.tbLastname.Text = "";
            this.tbName.Text = "";
            this.tbSurname.Text = "";
            this.tbUniName.Text = "";
        }
    }
}
