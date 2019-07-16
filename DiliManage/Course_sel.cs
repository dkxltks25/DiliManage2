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
using MySql.Data.MySqlClient;

namespace DiliManage
{
    public partial class Course_sel : Form
    {
        private static string mysql_str = "server=l.bsks.ac.kr;port=3306;Database=p201887082;Uid=p201887082;Pwd=dkxltks25;Charset=utf8;SSLMODE = NONE";
        private static int mode;
        MySqlConnection conn = new MySqlConnection(mysql_str);
        MySqlCommand cmd;
        MySqlDataReader reader;
        public static string url = "SERVER = l.bsks.ac.kr; USER=p201887082; DATABASE = p201887082; PORT=3306; PASSWORD=pp201887082;SSLMODE=NONE";

        private static string StudentNumber = null;
        public void DBconnect()
        {
            conn = new MySqlConnection(url);
            cmd = new MySqlCommand();
            cmd.Connection = conn;
        }
        public Course_sel()
        {
            InitializeComponent();
            DBconnect();
        }
        public Course_sel(string StuNum)
        {
            InitializeComponent();
            DBconnect();
            StudentNumber = StuNum;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Course_sel_Load(object sender, EventArgs e)
        {
            
            selectQuery();
        }
        private void selectQuery()
        {
            String CurTime;
            CurTime = DateTime.Now.ToString("yyyy-MM-dd");

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string sql = "SELECT * FROM TATM_COR where COS_RSDATE <= '"+CurTime+"' AND COS_REDATE >='"+CurTime+"'";
            Console.WriteLine(sql);
            try
            {
                cmd = new MySqlCommand(sql, conn);
                reader = cmd.ExecuteReader();
                string[] array = new string[6];
                while (reader.Read())
                {
                    array[0] = reader["APP_YEAR"].ToString();
                    array[1] = reader["APP_SEASON"].ToString();
                    array[2] = reader["COS_NAME"].ToString();
                    array[3] = reader["COS_RSDATE"].ToString();
                    array[4] = reader["COS_REDATE"].ToString();
                    array[5] = reader["COS_CAR"].ToString();

                    dataGridView1.Rows.Add(array);
                }
            }catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                reader.Close();
            }



        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            button1.Enabled = true;
            textBox8.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            DateTime dt1,dt2;
            DateTime.TryParse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString(), out dt1);
            dateTimePicker1.Value = dt1;
            DateTime.TryParse(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString(), out dt2);
            dateTimePicker2.Value = dt2; 


        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("이전 페이지로 다시 돌아가시겠습니까?", "YesOrNo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Apt_sel apt = new Apt_sel();
                apt.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("취소 되었습니다.");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String text = $"년도:{textBox8.Text}\n";
                   text += $"계절:{textBox1.Text}\n";
                   text += $"코스명{textBox2.Text}\n";
                   text += $"신청시작일:{dateTimePicker1.Text}\n";
                   text += $"신청종료일:{dateTimePicker2.Text}\n";
                   text += $"담당자:{textBox3.Text}\n";
                   text += "해당정보가 맞습니까?";
            if (MessageBox.Show(text, "YesOrNo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if(StudentNumber != null)
                {
                    Apt_up apt1 = new Apt_up(textBox8.Text, textBox1.Text, textBox2.Text,StudentNumber);
                    apt1.ShowDialog();
                }
                else
                {
                    Apt_up apt = new Apt_up(textBox8.Text, textBox1.Text, textBox2.Text);
                    apt.ShowDialog();
                }
              
            }
            else
            {
                MessageBox.Show("취소 되었습니다.");
            }

            
        }
    }
}
