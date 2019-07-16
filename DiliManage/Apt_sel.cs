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

    public partial class Apt_sel : Form
    {
        public Apt_sel()
        {
            InitializeComponent();
            DBconnect();
        }

        private static string mysql_str = "server=l.bsks.ac.kr;port=3306;Database=p201887082;Uid=p201887082;Pwd=dkxltks25;Charset=utf8;SSLMODE = NONE";
        private static int mode;
        MySqlConnection conn = new MySqlConnection(mysql_str);
        MySqlCommand cmd;
        MySqlDataReader reader;
        public static string url = "SERVER = l.bsks.ac.kr; USER=p201887082; DATABASE = p201887082; PORT=3306; PASSWORD=pp201887082;SSLMODE=NONE";

        public void DBconnect()
        {
            conn = new MySqlConnection(url);
            cmd = new MySqlCommand();
            cmd.Connection = conn;
        }
        private void Cour_Click(object sender, EventArgs e)
        {
            pra cou = new pra();
            this.Close();
            cou.Show();
        }

        private void Re_Click(object sender, EventArgs e)
        {
            requset re = new requset();
            this.Close();
            re.Show();
        }

        private void Stu_Click(object sender, EventArgs e)
        {
            Stu_sel apt = new Stu_sel();
            this.Close();
            apt.Show();
        }


        private void Ft_Click(object sender, EventArgs e)
        {
            FT ft = new FT();
            this.Close();
            ft.Show();
        }

        private void Apt_Click(object sender, EventArgs e)
        {
           Apt_sel apt = new Apt_sel();
            this.Close();
            apt.Show();
        }

        private void Sta_Click(object sender, EventArgs e)
        {
            Statics sta = new Statics();
            this.Close();
            sta.Show();
        }

        private void Ins_Click(object sender, EventArgs e)
        {
            Course_sel ce1 = new Course_sel();
            ce1.ShowDialog();
        }

        private void set_table()
        {
            string sql = "SELECT A.APP_YEAR,A.APP_SEASON,A.APP_NAME,S.STU_STUNO,S.STU_NAME,A.APP_GPA,A.APP_ADV from TATM_STU S, TATM_APP A where S.STU_STUNO = A.APP_STUNO AND A.APP_YN = 'Y';";

            listView1.Items.Clear();
            String[] arr = new String[6];
            ListViewItem lvt;
            listView1.FullRowSelect = true;
            // 리스트 뷰 데이터 출력
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            try
            {
                cmd = new MySqlCommand(sql, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    listView1.GridLines = true;
                    arr[0] = reader["APP_YEAR"].ToString();
                    arr[1] = reader["APP_SEASON"].ToString();
                    arr[2] = reader["APP_NAME"].ToString();
                    arr[3] = reader["STU_STUNO"].ToString();
                    arr[4] = reader["STU_NAME"].ToString();
                    arr[5] = reader["APP_GPA"].ToString();
                    lvt = new ListViewItem(arr);
                    listView1.Items.Add(lvt);

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                reader.Close();
            }

        }

        private void Apt_sel_Load(object sender, EventArgs e)
        {
            set_table();
        }
    }
}
