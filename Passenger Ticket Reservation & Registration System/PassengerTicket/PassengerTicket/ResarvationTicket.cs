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

namespace PassengerTicket
{
    public partial class ResarvationTicket : Form
    {
        public ResarvationTicket()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-FPTE8E0E\SQLEXPRESS;Initial Catalog=PassengerTicket;Integrated Security=True");

        void list()
        {
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from flyinginformation", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

       

        private void btnsave_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand order = new SqlCommand("insert into passengers (name,surname,telphone,tc,gender,mail) values (@p1,@p2,@p3,@p4,@p5,@p6)", connection);
            order.Parameters.AddWithValue("@p1", txtname.Text);
            order.Parameters.AddWithValue("@p2", txtsurname.Text);
            order.Parameters.AddWithValue("@p3", msktel.Text);
            order.Parameters.AddWithValue("@p4", msktc.Text);
            order.Parameters.AddWithValue("@p5", cmbgender.Text);
            order.Parameters.AddWithValue("@p6", txtmail.Text);
            order.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("New Passenger Recorded", "İnformation", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btncap_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand order = new SqlCommand("insert into captain (captianno,namesurname,telphone) values (@p1,@p2,@p3)", connection);
            order.Parameters.AddWithValue("@p1", txtcaptainno.Text);
            order.Parameters.AddWithValue("@p2", txtcaptainname.Text);
            order.Parameters.AddWithValue("@p3", msktelcap.Text);
            order.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("New Captain Recorded", "İnformation", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void btncreateflying_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand order = new SqlCommand("insert into flyinginformation (departure,arrival,date1,time1,captian,price) values (@p1,@p2,@p3,@p4,@p5,@p6)", connection);
            order.Parameters.AddWithValue("@p1", txtdepature.Text);
            order.Parameters.AddWithValue("@p2", txtarrivial.Text);
            order.Parameters.AddWithValue("@p3", mskdate.Text);
            order.Parameters.AddWithValue("@p4", msktime.Text);
            order.Parameters.AddWithValue("@p5", mskcaptain.Text);
            order.Parameters.AddWithValue("@p6", txtprice.Text);
            order.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("New Flying Recorded", "İnformation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            list();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int chosen = dataGridView1.SelectedCells[0].RowIndex;
            txtflyingno1.Text = dataGridView1.Rows[chosen].Cells[0].Value.ToString();

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtseatno.Text = "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtseatno.Text = "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtseatno.Text = "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtseatno.Text = "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtseatno.Text = "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtseatno.Text = "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtseatno.Text = "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtseatno.Text = "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtseatno.Text = "9";
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            txtseatno.Text = "10";
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            txtseatno.Text = "11";
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            txtseatno.Text = "12";
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            txtseatno.Text = "13";
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            txtseatno.Text = "14";
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            txtseatno.Text = "15";
        }

        private void btn16_Click(object sender, EventArgs e)
        {
            txtseatno.Text = "16";
        }

        private void btn17_Click(object sender, EventArgs e)
        {
            txtseatno.Text = "17";
        }

        private void btn18_Click(object sender, EventArgs e)
        {
            txtseatno.Text = "18";
        }

        private void btn19_Click(object sender, EventArgs e)
        {
            txtseatno.Text = "19";
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            txtseatno.Text = "20";
        }

        private void btnresarvation_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand order = new SqlCommand("insert into flyingdetail (flyingno,passengertc,seatno) values (@p1,@p2,@p3)", connection);
            order.Parameters.AddWithValue("@p1", txtflyingno1.Text);
            order.Parameters.AddWithValue("@p2", msktc1.Text);
            order.Parameters.AddWithValue("@p3", txtseatno.Text);
            order.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("New Resarvation Recorded", "İnformation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
