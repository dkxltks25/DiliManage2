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
   
    public partial class MainOrder : Form
    {
        public static string StudentNumber;
        public static string StudentName;
        public static string StudentSex;
        public static string StudentCel;
        public static string StudentEmail;
        public static string StudentFtime;
        public static string StudentTtime;
        public static string StudentImg;


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
        public MainOrder()
        {
            InitializeComponent();
            DBconnect();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_button_Click(object sender, EventArgs e)
        {
            StudentNumber = textBox1.Text;
            string sql = "SELECT  W.WAR_STUNO, S.STU_NAME,S.STU_SEX,S.STU_PHONE,S.STU_MAIL,W.WAR_TIME,W.WAR_FTIME from TATM_WAR W, TATM_STU S where W.WAR_STUNO = S.STU_STUNO AND W.WAR_DATE ='"+DateTime.Now.ToString("yyyy-MM-dd")+"'";
            Console.WriteLine(sql);
            if(conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            try
            {
                cmd = new MySqlCommand(sql, conn);
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    textBox2.Text = reader["STU_NAME"].ToString();
                    textBox3.Text = reader["STU_SEX"].ToString();
                    textBox4.Text = reader["STU_PHONE"].ToString();
                    textBox6.Text = reader["STU_MAIL"].ToString();
                    textBox5.Text = reader["WAR_TIME"].ToString();
                    textBox8.Text = reader["WAR_FTIME"].ToString();
                    if (textBox5.Text == "")
                    {
                        button1.Enabled = true;

                    }
                    else if (textBox8.Text == "")
                    {
                        button2.Enabled = true;
                    }
                    else
                    {

                    }

                }
            }
            catch(Exception e1)
            {
                Console.WriteLine(e1.ToString());
            }
            finally
            {
                reader.Close();
            }

        }
        private void MainOrder_Load(object sender, EventArgs e)
        {
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox8.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string sql = "UPDATE  TATM_WAR SET WAR_TIME = '" + DateTime.Now.ToString("hh시mm분") + "' where WAR_DATE = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' AND WAR_STUNO = '" + textBox1.Text + "'";
            try
            {

                cmd = new MySqlCommand(sql, conn);
                reader = cmd.ExecuteReader();
            }
            catch(Exception e1)
            {
                Console.WriteLine(e1.ToString());
            }
            finally
            {
                reader.Close();
            }
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if(conn.State == ConnectionState.Closed)
            {
                conn.Close();
            }
            string sql = "UPDATE  TATM_WAR SET WAR_FTIME = '" + DateTime.Now.ToString("hh시mm분") + "' where WAR_DATE = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' AND WAR_STUNO = '" + textBox1.Text + "'";
            try
            {
                cmd = new MySqlCommand(sql, conn);
                reader = cmd.ExecuteReader();
            }
            catch (Exception e1)
            {
                Console.WriteLine(e1.ToString());
            }
            finally
            {
                reader.Close();
            }
        }
    }
}
