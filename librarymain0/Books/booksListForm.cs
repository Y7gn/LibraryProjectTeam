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


namespace WindowsFormsApp3
{
    public partial class booksListForm : Form
    {
        public booksListForm()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\isc\Documents\LibraryDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null || textBox2.Text == null || textBox3.Text == null || textBox4.Text == null || comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Info, Please complete all the fields.");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into BookTable values ('" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.SelectedIndex.ToString() + "','" + textBox3.Text + "','" + textBox4.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book Saved Successfuly");
                    Con.Close();

                }
                catch (Exception Exp) { MessageBox.Show(Exp.Message); }
            }
        }
    }
}
