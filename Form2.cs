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

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public static string Connection_Database_Path = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= Картотека абонентів АТС.mdb";
        private OleDbConnection Database_Connection;
        
        public Form2()
        {
            InitializeComponent();
            Database_Connection = new OleDbConnection(Connection_Database_Path);
            Database_Connection.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Subscriber_Code = Convert.ToInt32(textBox1.Text);
            string Surname = textBox2.Text;
            string Name = textBox3.Text;
            string Patronymic = textBox4.Text;
            string query = "INSERT INTO Card_File ([Код абонента], Прізвище, Ім'я, По батькові) VALUES (" + Subscriber_Code + ",'" + Surname + "','" + Name + "','" + Patronymic + "')";
            OleDbCommand command_add = new OleDbCommand(query, Database_Connection);
            command_add.ExecuteNonQuery();
            MessageBox.Show("Абонент доданий");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
