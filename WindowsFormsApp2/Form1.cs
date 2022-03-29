using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private SqlConnection sqlConnection = null;
        private SqlDataAdapter sqlDataAdapter = null;
        public Form1()
        {
            InitializeComponent();


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closebutton_MouseEnter(object sender, EventArgs e)
        {
            closebutton.ForeColor = Color.Crimson;
        }

        private void closebutton_MouseLeave(object sender, EventArgs e)
        {
            closebutton.ForeColor = Color.Aquamarine;
        }

        Point lastPoint;
        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string da = login.Text;
            string net = password.Text;


            if (da == "admin" & net == "admin")
            {
                this.Hide();
                Form2 s = new Form2();
                s.ShowDialog();
                this.Close();
            }
            else
            {
                try
                {
                    String loginUser = da;
                    String passUser = net;

                    sqlConnection = new SqlConnection(@"Data Source=KrAZ;Initial Catalog=AgentNedv;Integrated Security=True");
                    sqlConnection.Open();

                    DataTable table = new DataTable();

                    sqlDataAdapter = new SqlDataAdapter();

                    SqlCommand command = new SqlCommand("SELECT * FROM Users WHERE Username = @login AND Password = @password", sqlConnection);
                    command.Parameters.Add("@login", SqlDbType.VarChar).Value = loginUser;
                    command.Parameters.Add("@password", SqlDbType.VarChar).Value = passUser;
                    sqlDataAdapter.SelectCommand = command;
                    sqlDataAdapter.Fill(table);
                    if (table.Rows.Count > 0)
                    {
                        this.Hide();
                        AccesToken.accesToken = 0;
                        Form2 f1 = new Form2();
                        f1.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Вы ввели неправильный логин или пароль!", "Ошибка ввода!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

