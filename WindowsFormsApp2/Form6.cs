using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class Form6 : Form
    {
        private SqlConnection sqlConnection = null;

        private SqlCommandBuilder sqlBuilder = null;

        private SqlDataAdapter sqlDataAdapter = null;

        private DataSet dataSet = null;
        public Form6()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable("Dogovor");
        private void LoadData()
        {
            try
            {
                sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Dogovor", sqlConnection);

                sqlBuilder = new SqlCommandBuilder(sqlDataAdapter);

                sqlBuilder.GetInsertCommand();
                sqlBuilder.GetUpdateCommand();
                sqlBuilder.GetDeleteCommand();

                dataSet = new DataSet();

                sqlDataAdapter.Fill(dataSet, "Dogovor");

                dataGridView1.DataSource = dataSet.Tables["Dogovor"];

                ReloadData();
                dataGridView1.Columns[1].HeaderText = "Клиент";
                dataGridView1.Columns[2].HeaderText = "Недвижимость";
                dataGridView1.Columns[3].HeaderText = "Риелтор";
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReloadData()
        {
            try
            {
                dataSet.Tables["Dogovor"].Clear();

                sqlDataAdapter.Fill(dataSet, "Dogovor");

                dataGridView1.DataSource = dataSet.Tables["Dogovor"];

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRow row = dataSet.Tables["Dogovor"].NewRow();

            row["Client"] = Convert.ToInt32(comboBox1.SelectedValue);
            row["Nedvizhimost"] = Convert.ToInt32(comboBox2.SelectedValue);
            row["Rieltor"] = Convert.ToInt32(comboBox3.SelectedValue);         
            dataSet.Tables["Dogovor"].Rows.Add(row);

            sqlDataAdapter.Update(dataSet, "Dogovor");
            ReloadData();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "agentNedvDataSet.Rieltor". При необходимости она может быть перемещена или удалена.
            this.rieltorTableAdapter.Fill(this.agentNedvDataSet.Rieltor);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "agentNedvDataSet.Nedvizhimost". При необходимости она может быть перемещена или удалена.
            this.nedvizhimostTableAdapter.Fill(this.agentNedvDataSet.Nedvizhimost);

            // TODO: данная строка кода позволяет загрузить данные в таблицу "agentNedvDataSet.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.agentNedvDataSet.Client);

            sqlConnection = new SqlConnection(@"Data Source=KRAZ;Initial Catalog=AgentNedv;Integrated Security=True");

            sqlConnection.Open();

            LoadData();
            if (AccesToken.accesToken == 0)
            {
                panel1.Visible = false;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ReloadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;

            dataSet.Tables["Dogovor"].Rows[rowIndex].Delete();

            sqlDataAdapter.Update(dataSet, "Dogovor");

            ReloadData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;

            dataSet.Tables["Dogovor"].Rows[rowIndex]["Client"] = (comboBox1.SelectedValue);
            dataSet.Tables["Dogovor"].Rows[rowIndex]["Nedvizhimost"] = (comboBox2.SelectedValue);
            dataSet.Tables["Dogovor"].Rows[rowIndex]["Rieltor"] = (comboBox3.SelectedValue);
            
        }

        private void оПрограммемToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AboutBox1 aboutBox1 = new AboutBox1();
            aboutBox1.ShowDialog();
            Form6 f6 = new Form6();
            f6.ShowDialog();
            aboutBox1.Close();
        }

        private void экспортВExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;           
            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);           
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    ExcelApp.Cells[i + 1, j + 1] = dataGridView1.Rows[i].Cells[j].Value;
                }
            }           
            ExcelApp.Visible = true;
            ExcelApp.UserControl = true;
        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
            this.Close();
        }

        private void недвижимостьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
            this.Close();
        }

        private void риелторыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();
            f4.ShowDialog();
            this.Close();
        }

        private void договорToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }
    }
}
