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
namespace loginform
{
    public partial class Form1 : Form
    {
        int fbal;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f1 = new Form2();
            f1.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("DESKTOP-EROF4DH\\SQLEXPRESS;Initial Catalog=bank_details;Integrated Security=True");
            con.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT Balance FROM acc_holder_details WHERE  Balance= (SELECT MIN(Balance)  FROM acc_holder_details); ", con);
            fbal = (int)cmd1.ExecuteScalar();
            fbal = fbal - int.Parse(textBox3.Text);
            string sql = "insert into acc_holder_details(Account_id,Account_name,Amount,Balance) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + fbal + "')";
            SqlCommand cmd = new SqlCommand(sql, con);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                MessageBox.Show("Transferred Successfully....Avl bal: " + fbal);
            }
            else
            {
                MessageBox.Show("Error");
            }
            cmd.Dispose();
            con.Close();

        }
    }
}
