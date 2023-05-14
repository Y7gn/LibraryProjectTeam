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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
            populate1();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Reset()
        {
            UnameTb.Text = "";
            UPassTb.Text = "";
            UPhoneTb.Text = "";
            UAddressTb.Text = "";
        }
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\malek\OneDrive\المستندات\BookShop.mdf;Integrated Security=True;Connect Timeout=30");
        private void populate1()
        {
            Con.Open();
            string query = "select * from UserTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            UserGdv.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (UnameTb.Text == "" || UPassTb.Text == "" || UPhoneTb.Text == "" || UAddressTb.Text == "" )
            {
                MessageBox.Show("Missing Info, Please complete all the fields.");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into UserTbl values ('" + UnameTb.Text + "','" + UPhoneTb.Text + "','" + UAddressTb.Text + "','" + UPassTb.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Saved Successfuly");
                    Con.Close();
                    populate1();
                    Reset();

                }
                catch (Exception Exp) { MessageBox.Show(Exp.Message); }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Missing Information.");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from UserTbl where UID=" + key + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Deleted Successfuly");
                    Con.Close();
                    populate1();
                    Reset();

                }
                catch (Exception Exp) { MessageBox.Show(Exp.Message); }
            }
        }
        int key = 0;
        private void UserGdv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UnameTb.Text = UserGdv.SelectedRows[0].Cells[1].Value.ToString();
            UPhoneTb.Text = UserGdv.SelectedRows[0].Cells[2].Value.ToString();
            UAddressTb.Text = UserGdv.SelectedRows[0].Cells[3].Value.ToString();
            UPassTb.Text = UserGdv.SelectedRows[0].Cells[4].Value.ToString();
            if (UnameTb.Text == "")
            {
                key = 0;
                MessageBox.Show("key"+ key);

            }
            else
            {
                key = Convert.ToInt32(UserGdv.SelectedRows[0].Cells[0].Value.ToString());
                MessageBox.Show("key" + key);

            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (UnameTb.Text == "" || UPhoneTb.Text == "" || UPassTb.Text == "" || UAddressTb.Text == "")
            {
                MessageBox.Show("Missing Information.");
            }
            else
            {
                try
                {
                    Con.Open();

                    string query = "update UserTbl set UName='" + UnameTb.Text + "', UPhone='" + UPhoneTb.Text + "', UAdd='" + UAddressTb.Text + "', UPass='" + UPassTb.Text + "' where UID=" + key + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Deleted Successfuly");
                    Con.Close();
                    populate1();
                    Reset();

                }
                catch (Exception Exp) { MessageBox.Show(Exp.Message); }
            }
        }

        private void UserGdv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UnameTb.Text = UserGdv.SelectedRows[0].Cells[1].Value.ToString();
            UPhoneTb.Text = UserGdv.SelectedRows[0].Cells[2].Value.ToString();
            UAddressTb.Text = UserGdv.SelectedRows[0].Cells[3].Value.ToString();
            UPassTb.Text = UserGdv.SelectedRows[0].Cells[4].Value.ToString();
            if (UnameTb.Text == "")
            {
                key = 0;
                MessageBox.Show("key" + key);

            }
            else
            {
                key = Convert.ToInt32(UserGdv.SelectedRows[0].Cells[0].Value.ToString());
                MessageBox.Show("key" + key);

            }

        }
    }
}
