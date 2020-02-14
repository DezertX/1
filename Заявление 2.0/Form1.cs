using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace Заявление_2._0
{
    public partial class Form1 : Form
    {
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet dataset = new DataSet();

        public Form1()
        {
            InitializeComponent();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
           // string Server, BD;
           // SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection = new SqlConnection("Data Source=DESKTOP-522DB7C\\ZERO;Initial Catalog=Обслуживание;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
           
           /* try
            {
                // Подключение к базе данных
                sqlConnection.Open();
                // Выбор данных из базы данных
                adapter.SelectCommand = new SqlCommand("SELECT * FROM Заявления", sqlConnection);
                adapter.Fill(dataset);
                // Отображение данных на форме в таблице
                dataGridView1.DataSource = dataset.Tables[0];
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].HeaderText = "Дата";
                dataGridView1.Columns[2].HeaderText = "Тип заявления";
                dataGridView1.Columns[3].HeaderText = "Сотрудник";
                dataGridView1.Columns[4].HeaderText = "Описание";
                dataGridView1.Columns[5].HeaderText = "Статус";
            }
            catch
            {
                MessageBox.Show("Ошибка соединения с базой данных");
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
        }
    }
}
