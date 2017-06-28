using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lib
{
    public partial class genform : Form
    {
        public genform()
        {
            InitializeComponent();
        }

        private void genform_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.stud". При необходимости она может быть перемещена или удалена.
            this.studTableAdapter.Fill(this.databaseDataSet.stud);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.books". При необходимости она может быть перемещена или удалена.
            this.booksTableAdapter.Fill(this.databaseDataSet.books);

        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addform addform = new addform();
            addform.Show();
        }
    }
}
