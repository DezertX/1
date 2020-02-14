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

namespace Заявление_2._0
{
    public partial class Form2 : Form
    {
        SqlConnection sqlConnection = new SqlConnection();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet dataset = new DataSet();
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Свойство - Изменение данных
            adapter.UpdateCommand = new SqlCommand("UPDATE Заявления SET Дата = ?, Тип заявления = ?, Сотрудник = ?, Описание = ?, Статус = ?" + "WHERE Номер = ? ", sqlConnection);
            adapter.UpdateCommand.Parameters.Add("name", SqlDbType.VarChar, 50, "name");
            adapter.UpdateCommand.Parameters.Add("phone", SqlDbType.VarChar, 50, "phone");
            adapter.UpdateCommand.Parameters.Add("email", SqlDbType.VarChar, 50, "email");
            adapter.UpdateCommand.Parameters.Add("img", SqlDbType.VarChar, 50, "img");
            adapter.UpdateCommand.Parameters.Add("cin", SqlDbType.Int, 10, "cin");
            // Свойство - Добавление данных
            adapter.InsertCommand = new SqlCommand("INSERT INTO Заявления (name, phone, email, img) " + "VALUES(?, ?, ?, ?)", sqlConnection);
            adapter.InsertCommand.Parameters.Add("name", SqlDbType.VarChar, 50, "name");
            adapter.InsertCommand.Parameters.Add("phone", SqlDbType.VarChar, 50, "phone");
            adapter.InsertCommand.Parameters.Add("email", SqlDbType.VarChar, 50, "email");
            adapter.InsertCommand.Parameters.Add("img", SqlDbType.VarChar, 50, "img");
            // Свойство - Удаление данных
            adapter.DeleteCommand = new SqlCommand("DELETE FROM Заявления WHERE Номер = ? ", sqlConnection);
            adapter.DeleteCommand.Parameters.Add("Номер", SqlDbType.Int, 10, "Номер");
            // Сохранение данных в базе данных      
            adapter.Update(dataset.Tables[0]);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
            sqlConnection = new SqlConnection("Data Source=DESKTOP-522DB7C\\ZERO;Initial Catalog=Обслуживание;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            try
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
            }
        }
    }
}
