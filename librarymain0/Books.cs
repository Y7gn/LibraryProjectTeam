using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace librarymain0
{
    public partial class Books : Form
    {
        public Books()
        {
            InitializeComponent();
            populate();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\malek\OneDrive\المستندات\BookShop.mdf;Integrated Security=True;Connect Timeout=30");

        private void populate()
        {
            Con.Open();
            string query = "select * from BookTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            gunaDataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Filter()
        {
            Con.Open();
            string query = "select * from BookTbl where BCat='"+ CatSearchTb.SelectedItem.ToString()+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            gunaDataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (BTitleTb.Text == "" || BAuthTb.Text == "" || QtyTb.Text == "" || PriceTb.Text == "" || BCatTb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Info, Please complete all the fields.");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into BookTbl values ('" + BTitleTb.Text + "','" + BAuthTb.Text + "','" + BCatTb.SelectedIndex.ToString() + "','" + QtyTb.Text + "','" + PriceTb.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book Saved Successfuly");
                    Con.Close();
                    populate();
                    Reset();

                }
                catch (Exception Exp) { MessageBox.Show(Exp.Message); }
            }
        }
        int key = 0;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BTitleTb.Text = gunaDataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            BAuthTb.Text = gunaDataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            BCatTb.SelectedItem = gunaDataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            QtyTb.Text = gunaDataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            PriceTb.Text = gunaDataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            if (BTitleTb.Text == "")
            {
                key = 0;
                MessageBox.Show("The value of key is: " + key);

            }
            else
            {
                key = Convert.ToInt32(gunaDataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                MessageBox.Show("The value of key is: " + key);
            }
        }

        private void CatSearchTb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Filter();
        }
        private void Reset()
        {
            BTitleTb.Text = "";
            BAuthTb.Text = "";
            BCatTb.SelectedIndex = -1;
            PriceTb.Text = "";
            QtyTb.Text = "";
        }
        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            populate();
            CatSearchTb.SelectedIndex = -1;

        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Reset();
            CatSearchTb.SelectedIndex = -1;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (key==0)
            {
                MessageBox.Show("Missing Information.");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from BookTbl where BId=" + key+"";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book Deleted Successfuly");
                    Con.Close();
                    populate();
                    Reset();

                }
                catch (Exception Exp) { MessageBox.Show(Exp.Message); }
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (BTitleTb.Text == "" || BAuthTb.Text == "" || QtyTb.Text == "" || PriceTb.Text == "" || BCatTb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information.");
            }
            else
            {
                try
                {
                    Con.Open();

                    string query = "update BookTbl set  BTitle=" + BTitleTb.Text + ",BAuthor='"+BAuthTb.Text+"',BCat='"+ BCatTb.SelectedIndex.ToString()+"',BQty="+QtyTb.Text+",BPrice="+PriceTb.Text+ " where BId=" + key+";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("The value of key is: " + key);
                    //MessageBox.Show("Book Edited Successfuly");

                    Con.Close();
                    populate();
                    Reset();

                }
                catch (Exception Exp) { MessageBox.Show(Exp.Message); }
            }
        }

        private void Books_Load(object sender, EventArgs e)
        {

        }

        private void gunaDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("The value of key is: " + key);

        }
    }
}
