﻿using System;
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
    public partial class Form4 : Form
    {
        public static string Connection_Database_Path = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= Картотека абонентів АТС.mdb";
        private OleDbConnection Database_Connection;
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Database_Connection = new OleDbConnection(Connection_Database_Path);
            Database_Connection.Open();
            try
            {
                int number = Convert.ToInt32(textBox1.Text);
                string query = "SELECT * FROM Card_File WHERE Телефон LIKE '%" + number + "%'";
                OleDbDataAdapter command_select = new OleDbDataAdapter(query, Database_Connection);
                DataTable dtable = new DataTable();
                command_select.Fill(dtable);
                dataGridView1.DataSource = dtable;
                Database_Connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Неправильно введено дані");
            }
            
        }
    }
}
