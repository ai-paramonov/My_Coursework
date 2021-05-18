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
    public partial class Form1 : Form
    {
        public static string Connection_Database_Path = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= Картотека абонентів АТС.mdb";
        private OleDbConnection Database_Connection;
        public Form1()
        {

            InitializeComponent();
            Database_Connection = new OleDbConnection(Connection_Database_Path);
            Database_Connection.Open();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'картотека_абонентів_АТСDataSet.Card_File' table. You can move, or remove it, as needed.
            this.card_FileTableAdapter.Fill(this.картотека_абонентів_АТСDataSet.Card_File);

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Database_Connection.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try {
                int Subscriber_Code = Convert.ToInt32(textBox1.Text);
                string query = "DELETE FROM Card_File WHERE [Код абонента] = " + Subscriber_Code;
                OleDbCommand command_delete = new OleDbCommand(query, Database_Connection);
                command_delete.ExecuteNonQuery();
                MessageBox.Show("Усі дані про абонента видалені");
                this.card_FileTableAdapter.Fill(this.картотека_абонентів_АТСDataSet.Card_File);
            }
            catch(Exception)
            {
                MessageBox.Show("Неправильно введено код абонента");
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try {
                int Subscriber_Code = Convert.ToInt32(textBox2.Text);
                string query = "UPDATE Card_File SET Тариф = '" + textBox3.Text + "' WHERE [Код абонента] = " + Subscriber_Code;
                OleDbCommand command_update = new OleDbCommand(query, Database_Connection);
                command_update.ExecuteNonQuery();
                MessageBox.Show("Тариф змінено");
                this.card_FileTableAdapter.Fill(this.картотека_абонентів_АТСDataSet.Card_File);
            }
            catch (Exception)
            {
                MessageBox.Show("Неправильно введені дані");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Form_2 = new Form2();
            Form_2.Owner = this;
            Form_2.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.card_FileTableAdapter.Fill(this.картотека_абонентів_АТСDataSet.Card_File);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                bool payment = Convert.ToBoolean(textBox4.Text);
                int Subscriber_Code = Convert.ToInt32(textBox5.Text);
                string query = "UPDATE Card_File SET Оплата = " + payment + " WHERE [Код абонента] = " + Subscriber_Code;
                OleDbCommand command_update = new OleDbCommand(query, Database_Connection);
                command_update.ExecuteNonQuery();
                MessageBox.Show("Відомості про оплату внесено");
                this.card_FileTableAdapter.Fill(this.картотека_абонентів_АТСDataSet.Card_File);
            }
            catch (Exception)
            {
                MessageBox.Show("Неправильно введені дані");
            }
           
        }

        private void абонентівПоТарифуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Form_3 = new Form3();
            Form_3.Owner = this;
            Form_3.Show();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            this.card_FileTableAdapter.Fill(this.картотека_абонентів_АТСDataSet.Card_File);
        }

        private void абонентаПоНомеруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Form_4 = new Form4();
            Form_4.Owner = this;
            Form_4.Show();
        }
    }
}
