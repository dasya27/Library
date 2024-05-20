using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.VisualStyles;
using Microsoft.Office.Interop.Excel;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using DataTable = System.Data.DataTable;
using Excel = Microsoft.Office.Interop.Excel;
using Series = System.Windows.Forms.DataVisualization.Charting.Series;


namespace Library
{
    public partial class Form1 : Form
    {
        private NpgsqlConnection con;
        private string conString =
            "Host = 127.0.0.1; Username = postgres; Password = melman; Database = Library";
        public Form1()
        {
            InitializeComponent();
            con = new NpgsqlConnection(conString);
            con.Open();

            loadStudents();
            loadBooks();
            loadIssues();
        }

        private void loadStudents()
        {
            DataTable dt = new DataTable();
            NpgsqlDataAdapter adap = new NpgsqlDataAdapter("SELECT * FROM students", con);
            adap.Fill(dt);
            dgvStudents.DataSource = dt;
        }

        private void loadBooks()
        {
            
            DataTable dt = new DataTable();
            NpgsqlDataAdapter adap = new NpgsqlDataAdapter("SELECT * FROM books", con);
            adap.Fill(dt);
            dgvBooks.DataSource = dt;
        }

        private void loadIssues()
        {

            DataTable dt = new DataTable();
            NpgsqlDataAdapter adap = new NpgsqlDataAdapter("SELECT * FROM issues", con);
            adap.Fill(dt);
            dgvIssues.DataSource = dt;
        }

        private void btnStudentsAddChange_Click(object sender, EventArgs e)
        {
            FormAddClients f = new FormAddClients();
            f.ShowDialog();
            loadStudents();
        }

        private void btnStudentsChange_Click(object sender, EventArgs e)
        {
            FormChangeStudents f = new FormChangeStudents();
            f.ShowDialog();
            loadStudents();
        }


        private void btnStudentsDelete_Click(object sender, EventArgs e)
        {
            string sql = $"DELETE FROM students WHERE id=(@id)";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
            int id = int.Parse(dgvStudents.CurrentRow.Cells[0].Value.ToString());
            cmd.Parameters.AddWithValue("id", id);
            cmd.Prepare();
            cmd.ExecuteNonQuery();

            loadStudents();
        }

        private void btnBooksDelete_Click(object sender, EventArgs e)
        {
            string sql = $"DELETE FROM books WHERE id=(@id)";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
            int id = int.Parse(dgvBooks.CurrentRow.Cells[0].Value.ToString());
            cmd.Parameters.AddWithValue("id", id);
            cmd.Prepare();
            cmd.ExecuteNonQuery();

            loadBooks();
        }

        private void btnBooksAdd_Click(object sender, EventArgs e)
        {
            FormAddBooks f = new FormAddBooks();
            f.ShowDialog();
            loadBooks();
        }

        private void btnBooksChange_Click(object sender, EventArgs e)
        {
            FormChangeBooks f = new FormChangeBooks();
            f.ShowDialog();
            loadBooks();
        }

        private void btnIssuesDelete_Click(object sender, EventArgs e)
        {
            string sql = $"DELETE FROM issues WHERE id=(@id)";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
            int id = int.Parse(dgvIssues.CurrentRow.Cells[0].Value.ToString());
            cmd.Parameters.AddWithValue("id", id);
            cmd.Prepare();
            cmd.ExecuteNonQuery();

            loadIssues();
        }

        private void btnIssuesAdd_Click(object sender, EventArgs e)
        {
            FormAddIssues f = new FormAddIssues();
            f.ShowDialog();
            loadIssues();
        }

        private void btnIssuesChange_Click(object sender, EventArgs e)
        {
            FormChangeIssues f = new FormChangeIssues();
            f.ShowDialog();
            loadIssues();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql1 = "SELECT id, name, lastname, surname, uni_name FROM students";
            NpgsqlCommand cmd1 = new NpgsqlCommand(sql1, con);
            
            Excel.Application ex = new Excel.Application();
            Workbook wb = ex.Workbooks.Open("C:/Users/dasyy/Documents/sharp.xlsx");
            Worksheet sheet = wb.Sheets[1];

            sheet.Cells[1, 1].Value = "Имя студента";
            sheet.Cells[1, 2].Value = "Фамилия студента";
            sheet.Cells[1, 3].Value = "Отчество студента";
            sheet.Cells[1, 4].Value = "Университет";

            string name = "";
            string lastname = "";
            string surname = "";
            string uni = "";

            DateTime d0 = day.Value;
            int countRows = 2;

            List<string> students = new List<string>();

            for (int i = 0; i < dgvIssues.Rows.Count; i++)
                if (dgvIssues.Rows[i].Cells[5].Value == DBNull.Value  && Convert.ToDateTime(dgvIssues.Rows[i].Cells[4].Value) <= d0)
                {
                    NpgsqlDataReader reader1 = cmd1.ExecuteReader();

                    bool fl = false;
                    // идем по всем студентам
                    while (reader1.Read())
                    {
                        // если натыкаемся на id
                        if (dgvIssues.Rows[i].Cells[2].Value.ToString() == reader1.GetValue(0).ToString())
                        {
                           name = reader1.GetString(1);
                           lastname = reader1.GetString(2);
                           surname = reader1.GetString(3);
                           uni = reader1.GetString(4);

                            if (!students.Contains(reader1.GetValue(0).ToString()))
                            {
                                fl = true;
                                students.Add(reader1.GetValue(0).ToString());
                            }
                        }
                    }
                    reader1.Close();

                    if (fl == true)
                    {
                        sheet.Cells[countRows, 1].Value = name;
                        sheet.Cells[countRows, 2].Value = lastname;
                        sheet.Cells[countRows, 3].Value = surname;
                        sheet.Cells[countRows, 4].Value = uni;
                        countRows++;
                    }
                }
                else if (dgvIssues.Rows[i].Cells[5].Value != DBNull.Value)
                {
                    if (Convert.ToDateTime(dgvIssues.Rows[i].Cells[5].Value) > Convert.ToDateTime(dgvIssues.Rows[i].Cells[4].Value))
                    {
                        NpgsqlDataReader reader1 = cmd1.ExecuteReader();

                        bool fl = false;
                        // идем по всем студентам
                        while (reader1.Read())
                        {
                            // если натыкаемся на id
                            
                            if (dgvIssues.Rows[i].Cells[1].Value.ToString() == reader1.GetValue(0).ToString())
                            {
                                Console.WriteLine(dgvIssues.Rows[i].Cells[2].Value.ToString());
                                name = reader1.GetValue(1).ToString();
                                lastname = reader1.GetString(2);
                                surname = reader1.GetString(3);
                                uni = reader1.GetString(4);

                                if (!students.Contains(reader1.GetValue(0).ToString())){
                                    fl = true;
                                    students.Add(reader1.GetValue(0).ToString());
                                }
                            }
                        }
                        reader1.Close();

                        
                        if (fl == true)
                        {
                            sheet.Cells[countRows, 1].Value = name;
                            sheet.Cells[countRows, 2].Value = lastname;
                            sheet.Cells[countRows, 3].Value = surname;
                            sheet.Cells[countRows, 4].Value = uni;
                            countRows++;
                        }
                    }
                    
                    
                }

            sheet.Rows[1].Style.HorizontalAlignment = HorizontalAlignment.Center;
            sheet.Rows[1].Style.VerticalAlignment = VerticalAlignment.Center;
            sheet.Cells.WrapText = true;
            ex.Visible = true;
        }


        // получаем диаграмму
        private void button2_Click(object sender, EventArgs e)
        {
            // очищаем наш чарт
            chart1.Series.Clear();
            

            // получаем дату и конец периода
            DateTime d1 = startPeriod.Value;
            DateTime d3 = endPeriod.Value;

            // устанавливаем количество невозвращенных, выданных и утерянных книг
            int countNotReturn = 0;
            int countLost = 0;
            int countIssued = 0;

            // проходимся по всем выдачам
            for (int i = 0; i < dgvIssues.Rows.Count; i++)
                // если дата выдачи в заданных пределах, то она выданная
                if (Convert.ToDateTime(dgvIssues.Rows[i].Cells[3].Value) >= d1 && Convert.ToDateTime(dgvIssues.Rows[i].Cells[3].Value) <= d3)
                {
                    countIssued += 1;

                    // срок сдачи позже периода и ретурн позже сдачи - невозвращенная
                    // или ретурн больше периода и срок сдачи позже периода
                    if (dgvIssues.Rows[i].Cells[5].Value != DBNull.Value)
                    {
                        if (Convert.ToDateTime(dgvIssues.Rows[i].Cells[5].Value) >= d3 && Convert.ToDateTime(dgvIssues.Rows[i].Cells[4].Value) >= d3)
                        {
                            countNotReturn += 1;
                        }
                    }
            

                        // если поле ретурн пустое и срок сдачи раньше периода - утеренная
                        if (dgvIssues.Rows[i].Cells[5].Value == DBNull.Value && Convert.ToDateTime(dgvIssues.Rows[i].Cells[4].Value) <= d3)
                    {
                        countLost += 1;
                    }
                        
                }

            Series s1 = chart1.Series.Add("S1");
            s1.ChartType = SeriesChartType.Pie;
            chart1.Series[0]["PieLabelStyle"] = "Disabled";



            s1.Points.AddXY("Выданные, "  +Convert.ToString(countIssued), Convert.ToString(countIssued));
            s1.Points.AddXY("Утерянные, " + Convert.ToString(countLost), Convert.ToString(countLost));
            s1.Points.AddXY("Невозвращенные, " + Convert.ToString(countNotReturn), Convert.ToString(countNotReturn));


            foreach (DataPoint point in s1.Points)
            {
                point.Label = "";
            }

        }



        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            // получаем дату и конец периода
            DateTime d1 = startPeriod.Value;
            DateTime d3 = endPeriod.Value;

            // устанавливаем количество невозвращенных, выданных и утерянных книг
            int countNotReturn = 0;
            int countLost = 0;
            int countIssued = 0;

            // проходимся по всем выдачам
            for (int i = 0; i < dgvIssues.Rows.Count; i++)
                // если дата выдачи в заданных пределах, то она выданная
                if (Convert.ToDateTime(dgvIssues.Rows[i].Cells[3].Value) >= d1 && Convert.ToDateTime(dgvIssues.Rows[i].Cells[3].Value) <= d3)
                {
                    countIssued += 1;

                    // срок сдачи позже периода и ретурн позже сдачи - невозвращенная
                    // или ретурн больше периода и срок сдачи позже периода
                    if (dgvIssues.Rows[i].Cells[5].Value != DBNull.Value)
                    {
                        if (Convert.ToDateTime(dgvIssues.Rows[i].Cells[5].Value) >= d3 && Convert.ToDateTime(dgvIssues.Rows[i].Cells[4].Value) >= d3)
                        {
                            countNotReturn += 1;
                        }
                    }

                    // если поле ретурн пустое и срок сдачи раньше периода - утеренная
                    if (dgvIssues.Rows[i].Cells[5].Value == DBNull.Value && Convert.ToDateTime(dgvIssues.Rows[i].Cells[4].Value) <= d3)
                    {
                        countLost += 1;
                    }

                }

            Excel.Application ex = new Excel.Application();
            Workbook wb = ex.Workbooks.Open("C:/Users/dasyy/Documents/sharp.xlsx");
            Worksheet sheet = wb.Sheets[1];

            sheet.Cells[1, 1].Value = "Невозвращенные";
            sheet.Cells[1, 2].Value = "Утерянные";
            sheet.Cells[1, 3].Value = "Выданные";

            sheet.Cells[2, 1].Value = countNotReturn;
            sheet.Cells[2, 2].Value = countLost;
            sheet.Cells[2, 3].Value = countIssued;

            sheet.Rows[1].Style.HorizontalAlignment = HorizontalAlignment.Center;
            sheet.Rows[1].Style.VerticalAlignment = VerticalAlignment.Center;
            sheet.Cells.WrapText = true;
            ex.Visible = true;

        }
    }
}

