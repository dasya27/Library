using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class FormChangeStudents : Form
    {
        private NpgsqlConnection con;
        private string conString =
            "Host = 127.0.0.1; Username = postgres; Password = melman; Database = Library";
        public FormChangeStudents()
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbLastname.Text = dataGridView1.SelectedCells[1].Value.ToString();
            tbName.Text = dataGridView1.SelectedCells[2].Value.ToString();
            tbSurname.Text = dataGridView1.SelectedCells[3].Value.ToString();
            tbUni_name.Text = dataGridView1.SelectedCells[4].Value.ToString();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE students SET lastname=@lastname, name=@name, surname=@surname, uni_name=@uni_name WHERE id = @id";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.AddWithValue("lastname", this.tbLastname.Text);
            cmd.Parameters.AddWithValue("name", this.tbName.Text);
            cmd.Parameters.AddWithValue("surname", this.tbSurname.Text);
            cmd.Parameters.AddWithValue("uni_name", this.tbUni_name.Text);
            int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            cmd.Parameters.AddWithValue("id", id);
            cmd.Prepare();
            cmd.ExecuteNonQuery();

            loadStudents();

            this.tbLastname.Text = "";
            this.tbName.Text = "";
            this.tbSurname.Text = "";
            this.tbUni_name.Text = "";
        }
    }
}
