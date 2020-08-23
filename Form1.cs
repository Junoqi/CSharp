using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteTakingApp
{
    public partial class Form1 : Form
    {
        DataTable table;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("Title", typeof(String));
            table.Columns.Add("Messages", typeof(String));

            dataGridView2.DataSource = table;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            titleInput.Clear();
            messageInput.Clear(); 
        }

        private void button10_Click(object sender, EventArgs e)
        {
            table.Rows.Add(titleInput.Text, messageInput.Text);

            titleInput.Clear();
            messageInput.Clear();

        }


        private void button9_Click(object sender, EventArgs e)
        {
            int index = dataGridView2.CurrentCell.RowIndex;

            if (index > -1)
            {
                titleInput.Text = table.Rows[index].ItemArray[0].ToString();
                messageInput.Text = table.Rows[index].ItemArray[1].ToString();

            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int index = dataGridView2.CurrentCell.RowIndex;

            table.Rows[index].Delete();
        }

        private void titleInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
