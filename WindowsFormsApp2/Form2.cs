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
    public partial class Form2 : Form
    {
        private SqlConnection sqlConnection = null;

        private SqlCommandBuilder sqlBuilder = null;

        private SqlDataAdapter sqlDataAdapter = null;

        private DataSet dataSet = null;

        private bool newRowAdding = false;

        public Form2()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable("Client");
        private void LoadData()
        {
            try
            {
                sqlDataAdapter = new SqlDataAdapter("SELECT *, 'Delete' AS [Operations] FROM Client", sqlConnection);

                sqlBuilder = new SqlCommandBuilder(sqlDataAdapter);

                sqlBuilder.GetInsertCommand();
                sqlBuilder.GetUpdateCommand();
                sqlBuilder.GetDeleteCommand();

                dataSet = new DataSet();

                sqlDataAdapter.Fill(dataSet, "Client");

                dataGridView1.DataSource = dataSet.Tables["Client"];

                dataGridView1.Columns[1].HeaderText = "Имя";
                dataGridView1.Columns[2].HeaderText = "Фамилия";
                dataGridView1.Columns[3].HeaderText = "Отчество";
                dataGridView1.Columns[4].HeaderText = "Телефон";
                dataGridView1.Columns[5].HeaderText = "Операции";
                ReloadData();

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();

                    dataGridView1[5, i] = linkCell;
                }
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
                dataSet.Tables["Client"].Clear();

                sqlDataAdapter.Fill(dataSet, "Client");

                dataGridView1.DataSource = dataSet.Tables["Client"];

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();

                    dataGridView1[5, i] = linkCell;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(@"Data Source=KRAZ;Initial Catalog=AgentNedv;Integrated Security=True");

            sqlConnection.Open();

            LoadData();

            }
           

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 5)
                {
                    string task = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

                    if(task == "Delete")
                    {
                        if(MessageBox.Show("Удалить эту строку?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            int rowIndex = e.RowIndex;

                            dataGridView1.Rows.RemoveAt(rowIndex);

                            dataSet.Tables["Client"].Rows[rowIndex].Delete();

                            sqlDataAdapter.Update(dataSet, "Client");
                        }
                    }
                    else if (task == "Insert")
                    {
                        int rowIndex = dataGridView1.Rows.Count - 2;

                        DataRow row = dataSet.Tables["Client"].NewRow();

                        
                        row["Imya"] = dataGridView1.Rows[rowIndex].Cells["Imya"].Value;
                        row["Familya"] = dataGridView1.Rows[rowIndex].Cells["Familya"].Value;
                        row["Otchestvo"] = dataGridView1.Rows[rowIndex].Cells["Otchestvo"].Value;
                        row["Telefon"] = dataGridView1.Rows[rowIndex].Cells["Telefon"].Value;

                        dataSet.Tables["Client"].Rows.Add(row);

                        dataSet.Tables["Client"].Rows.RemoveAt(dataSet.Tables["Client"].Rows.Count - 1);

                        dataGridView1.Rows.RemoveAt(dataGridView1.Rows.Count - 2);

                        dataGridView1.Rows[e.RowIndex].Cells[5].Value = "Delete";

                        sqlDataAdapter.Update(dataSet, "Client");

                        newRowAdding = false;
                    }
                    else if (task == "Update")
                    {
                        int r = e.RowIndex;
                      
                        dataSet.Tables["Client"].Rows[r]["Imya"] = dataGridView1.Rows[r].Cells["Imya"].Value;
                        dataSet.Tables["Client"].Rows[r]["Familya"] = dataGridView1.Rows[r].Cells["Familya"].Value;
                        dataSet.Tables["Client"].Rows[r]["Otchestvo"] = dataGridView1.Rows[r].Cells["Otchestvo"].Value;
                        dataSet.Tables["Client"].Rows[r]["Telefon"] = dataGridView1.Rows[r].Cells["Telefon"].Value;

                        sqlDataAdapter.Update(dataSet, "Client");

                        dataGridView1.Rows[e.RowIndex].Cells[5].Value = "Delete";
                    }

                    ReloadData();   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

            private void dataGridView1_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            try
            {
                if (newRowAdding == false)
                {
                    newRowAdding = true;

                    int lastRow = dataGridView1.Rows.Count - 2;

                    DataGridViewRow row = dataGridView1.Rows[lastRow];

                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();

                    dataGridView1[5, lastRow] = linkCell;

                    row.Cells["Operations"].Value = "Insert";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (newRowAdding == false)
                {
                    int rowIndex = dataGridView1.SelectedCells[0].RowIndex;

                    DataGridViewRow editingRow = dataGridView1.Rows[rowIndex];

                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();

                    dataGridView1[5, rowIndex] = linkCell;

                    editingRow.Cells["Operations"].Value = "Update";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            ReloadData();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void недвижимостьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
            this.Close();
        }

        private void недвижимостьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
            this.Close();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Close();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Imya LIKE '%{textBox1.Text}%'";
            ReloadData();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AboutBox1 aboutBox1 = new AboutBox1();
            aboutBox1.ShowDialog();
            Form2 f2 = new Form2();
            f2.ShowDialog();
            aboutBox1.Close();
        }

        private void риелторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();
            f4.ShowDialog();
            this.Close();
        }

        

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void экспортToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
            //Книга.
            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
            //Таблица.
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    ExcelApp.Cells[i + 1, j + 1] = dataGridView1.Rows[i].Cells[j].Value;
                }
            }
            //Вызываем нашу созданную эксельку.
            ExcelApp.Visible = true;
            ExcelApp.UserControl = true;

        }

        private void договорToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 f6 = new Form6();
            f6.ShowDialog();
            this.Close();
                 
        }
    }
}
