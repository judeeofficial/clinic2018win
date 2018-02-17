using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//-----------------------------------
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Clinic2018
{
    public partial class clinic_insert : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-L2HUNPH\SQLEXPRESS; Initial Catalog=Clinic2018; User ID=sa; Password=1234");

        public clinic_insert()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void comboBox5_Click(object sender, EventArgs e)
        {
        /*    conn.Open(); //ทดสอบ
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select province_name from provinces";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                comboBox5.Items.Add(dr["province_name"].ToString());
            }

            conn.Close();
            */
        }

        private void clinic_insert_Load(object sender, EventArgs e)
        {
  

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //บันทึกข้อมูลลง Database
        private void button3_Click(object sender, EventArgs e)
        {
            // tabControl1.TabPages.Add(new MyTabPage(new clinic_opd()));
            string insertquery = "insert into patient(patient_id) values('" + txtpatient_id.Text + "')";
            conn.Open();
            SqlCommand cmd = new SqlCommand(insertquery, conn);
            try
            {
                if (cmd.ExecuteNonQuery() == 1)
                {
                    //แสดงข้อความแทน
                    label6.ForeColor = Color.Green;
                    label6.Text = "ครบ 13 หลัก";

                    //แสดงป็อปอัพข้อความแทน
                    //MessageBox.Show("Data Inserted");
                }
                else
                {
                    MessageBox.Show("Data Not Inserted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



            conn.Close();
        }
    }
}
