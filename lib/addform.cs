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

namespace lib
{
    public partial class addform : Form
    {
        public addform()
        {
            InitializeComponent();
        }

        private void cnclbtn_Click(object sender, EventArgs e)
        {
           Close();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            var сonnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dmtrge\documents\visual studio 2017\Projects\lib\lib\Database.mdf;Integrated Security=True;Connect Timeout=30";
            using (var myConnection = new SqlConnection(сonnectionString))
            {
                myConnection.Open();
                var sqlCommand = new SqlCommand("INSERT INTO books (name, auth, year,IDbook, notes, exist) VALUES (@books,@auth,@year, @IDbook, @notes, exist)", myConnection);
                sqlCommand.Parameters.Add(new SqlParameter("@name", namebox.Text));


            }
    }
}
