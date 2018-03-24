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


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.BackColor == Color.Red)
            {
                this.BackColor = Color.Gray;
            }
            else if (this.BackColor == Color.Gray)
            { this.BackColor = Color.Green; }
            else
                this.BackColor = Color.Red;
        }

        private void 关闭_click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=.\\SQLEXPRESS;Initial Catalog=myschool;Integrated Security = SSPI;";

            // string connString = "server=.;database=myschool;Integrated Security = SSPI; ";

            SqlConnection connection = new SqlConnection(connString);
            connection.Open();
            MessageBox.Show("打开数据库连接成功");
            connection.Close();
            MessageBox.Show("关闭数据库连接成功");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=.\\SQLEXPRESS;Initial Catalog=myschool;Integrated Security = SSPI;";
            // string connString = "server=.;database=myschool;Integrated Security = SSPI; ";
            SqlConnection connection = new SqlConnection(connString);
            string sql = "SELECT COUNT(*) FROM dbo.Table_1";
            connection.Open();
            SqlCommand command = new SqlCommand(sql, connection);
            int num = (int)command.ExecuteScalar();
            string c=Convert.ToString(num);
               MessageBox.Show("一共记录是"+c+"条");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void 消息提示_click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("请输入用户姓名","输入提示",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if(result==DialogResult.OK)
            {
                MessageBox.Show("你选择了确认按钮");
            }
        else
            {
                MessageBox.Show("你选择了取消按钮");
            }
        }
    }
}
