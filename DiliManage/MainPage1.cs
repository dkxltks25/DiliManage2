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
    public partial class MainPage1 : Form
    {
        public static string StudentNumber;
        public static string StudentName;
        public static string StudentSex;
        public static string StudentCel;
        public static string StudentEmail;
        public static string StudentFtime;
        public static string StudentTtime;
        public static string StudentImg;

        private static string mysql_str = "server=l.bsks.ac.kr;port=3306;Database=p201887082;Uid=p201887082;Pwd=pp201887082;Charset=utf8;SSLMODE = NONE";
        MySqlConnection conn = new MySqlConnection(mysql_str);
        MySqlConnection conn1 = new MySqlConnection(mysql_str);
        MySqlConnection  conn2 = new MySqlConnection(mysql_str);
        private static int mode;
        MySqlCommand cmd,cmd1,cmd2,cmd3;

        MySqlDataReader reader, reader1,reader2,reader3;

        public void DBconnect()
        {
            conn = new MySqlConnection(mysql_str);
            cmd = new MySqlCommand();
            cmd.Connection = conn;
        }
        public MainPage1()
        {
            //메인페이지
            InitializeComponent();
            set_clear();
        }

        public MainPage1(int mode)
        {
            //관리자 등급별 메인페이지
            InitializeComponent();
            set_clear();
            if (mode == 1)
            {
                cou.Enabled = true;
                re.Enabled = true;
                apt.Enabled = true;
                ft.Enabled = true;
                stu.Enabled = true;
                sta.Enabled = true;
            }
            if (mode == 2)
            {
                cou.Enabled = false;
                re.Enabled = false;
                apt.Enabled = false;
                ft.Enabled = false;
                stu.Enabled = false;
                sta.Enabled = false;
            }
        }
        private void set_table()
        {
            listView1.Items.Clear();
            string sql = "SELECT WAR_DATE,WAR_STUNO,STU_NAME,WAR_TIME,WAR_FTIME from TATM_WAR  W, TATM_STU S where W.WAR_STUNO= S.STU_STUNO AND WAR_DATE = '"+DateTime.Now.ToString("yyyy-MM-dd")+"'";
            String[] arr = new String[5];
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
                    arr[0] = reader["WAR_DATE"].ToString();
                    arr[1] = reader["WAR_STUNO"].ToString();
                    arr[2] = reader["WAR_TIME"].ToString();
                    arr[4] = reader["STU_NAME"].ToString();
                    arr[3] = reader["WAR_FTIME"].ToString();
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
        
        private void cou_Click(object sender, EventArgs e)
        {
            pra cou = new pra();
            this.Close();
            m1.Close();
            cou.Show();
        }

        private void re_Click(object sender, EventArgs e)
        {
            requset As = new requset();
            this.Close();
            m1.Close();
            As.Show();
        }

        private void stu_Click(object sender, EventArgs e)
        {
            Stu_sel apt = new Stu_sel();
            this.Close();
            m1.Close();
            apt.Show();
        }

        private void ft_Click(object sender, EventArgs e)
        {
            FT FT = new FT();
            this.Close();
            m1.Close();
            FT.Show();
        }

        private void Apt_Click(object sender, EventArgs e)
        {

            Apt_sel stu = new Apt_sel();
            this.Close();
            m1.Close();
            stu.Show();
        }

        private void Sta_Click(object sender, EventArgs e)
        {
            Statics sta = new Statics();
            this.Close();
            m1.Close();
            sta.Show();
        }

        private void set_value()
        {
            //변수 설정
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }

        private void listView1_Leave(object sender, EventArgs e)
        {

        }

        private void set_clear()
        {
            //빈칸 조정
           

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
        private MainOrder m1 = new MainOrder();
       
        private void MainPage1_Load(object sender, EventArgs e)
        {
            Console.WriteLine(this.Location.X);
            Console.WriteLine(this.Location.Y);
            Console.WriteLine(this.Width);
            m1.Location = new Point(this.Location.X + this.Width + 10, this.Location.Y);
            m1.Show();

            set_table();
            CreateTodatQuery();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void CreateTodatQuery()
        {
            string t1 = DateTime.Now.ToString("yyyy-MM-dd");
            Console.WriteLine(t1);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            if(conn1.State == ConnectionState.Closed)
            {
                conn1.Open();
            }
            if(conn2.State == ConnectionState.Closed)
            {
                conn2.Open();
            }
            string sql = "SELECT * FROM TATM_APP";
            try
            {
                cmd = new MySqlCommand(sql, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string sql2 = "SELECT * FROM TATM_WAR WHERE WAR_DATE ='" + t1 + "' AND WAR_STUNO = '" + reader["APP_STUNO"] + "'";
                    try
                    {
                        cmd2 = new MySqlCommand(sql2, conn1);
                        reader2 = cmd2.ExecuteReader();
                        if (reader2.Read())
                        {
                            Console.WriteLine("이미 있음");
                        }
                        else
                        {
                            try
                            {
                                 string sql1 = "INSERT INTO TATM_WAR (WAR_DATE,WAR_STUNO)";
                                    sql1 += "VALUES('" + t1 + "','" + reader["APP_STUNO"] + "')";
                                    cmd1 = new MySqlCommand(sql1, conn2);
                                    reader1 = cmd1.ExecuteReader();
                                    if (reader1.Read())
                                    {
                                        Console.WriteLine("INSERT 완료");
                                    }
                            }
                            catch(Exception e2)
                            {
                                Console.WriteLine($"e2={e2.ToString()}");
                            }
                            finally
                            {
                                reader1.Close();
                            }
                          
                            
                        }
                    }catch(Exception e1)
                    {
                        Console.WriteLine($"e1 = {e1.ToString()}");
                    }
                    finally
                    {
                        reader2.Close();
                    }
                }
            }catch(Exception e)
            {
                Console.Write(e.ToString());
            }
            finally
            {
                reader.Close();
            }
            
        }
    }
}
