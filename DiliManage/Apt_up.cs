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
    public partial class Apt_up : Form
    {
        private static String StudentYear;
        private static String StudentSeason;
        private static String StudentCourseName;
        private static String StudentNumber;
        private static String StudentName;
        private static String StudentCell1;
        private static String StudentCell2;
        private static String StudentCell3;
        private static String StudentScore;
        private static String StudentMilitary;
        private static String StudentCerName1;
        private static String StudentCerDay1;
        private static String StudentCerExe1;
        private static String StudentCerName2;
        private static String StudentCerDay2;
        private static String StudentCerExe2;
        private static String StudentLangName1;
        private static String StudentLangCon1;
        private static String StudentLangRea1;
        private static String StudentLangWrl1;
        private static String StudentLangName2;
        private static String StudentLangCon2;
        private static String StudentLangRea2;
        private static String StudentLangWrl2;
        private static String StudentDolDiv;
        private static String StudentDolDO;
        private static String StudentDolHO;
        private static String StudentContent;
        private static string StudentTeacher;

        private static string[] Grade = new string[] { "상", "중", "하" };
        
        private static string PageMode;         
        private static string mysql_str = "server=l.bsks.ac.kr;port=3306;Database=p201887082;Uid=p201887082;Pwd=pp201887082;Charset=utf8;SSLMODE = NONE";
        MySqlConnection conn = new MySqlConnection(mysql_str);
        MySqlCommand cmd;
        MySqlDataReader reader;

        public void DBconnect()
        {
            conn = new MySqlConnection(mysql_str);
            cmd = new MySqlCommand();
            cmd.Connection = conn;
        }
        public Apt_up()
        {
            InitializeComponent();
            DBconnect();
            set_clear();
        }
        public Apt_up(String Mode)
        {
            InitializeComponent();
            PageMode = Mode;
            DBconnect();
            set_clear();
        }
        private void set_clear()
        {
            textBox6.Text ="";
            comboBox4.Text ="";
            textBox9.Text ="";
            textBox10.Text ="";
            textBox11.Text ="";
            textBox12.Text ="";
            textBox13.Text ="";
            textBox14.Text ="";
            textBox17.Text ="";
            comboBox1.Text ="";
            comboBox2.Text ="";
            comboBox3.Text ="";
            textBox16.Text ="";
            comboBox7.Text ="";
            comboBox6.Text ="";
            comboBox5.Text ="";
            comboBox9.Text ="";
            comboBox8.Text ="";
            textBox7.Text  ="";
            textBox18.Text ="";
            textBox20.Text = "";
            textBox4.Enabled = false;
            textBox19.Enabled = false;
            textBox8.Enabled = false;
            if(PageMode =="5")
            {
                textBox1.Enabled =   true;
                textBox15.Enabled =  true;
                comboBox10.Enabled = true;
                textBox5.Enabled =   true;
                textBox2.Enabled =   true;
                textBox1.Text =   "";
                textBox15.Text =  "";
                comboBox10.Text = "";
                textBox5.Text =   "";
                textBox2.Text = "";
            }
            textBox1.Enabled = false;
            textBox15.Enabled = false;
            comboBox10.Enabled = false;
            textBox5.Enabled = false;
            textBox2.Enabled = false;
            comboBox8.Enabled = false;
            textBox7.Enabled  = false;
        }
        private void set_value()
        {
            StudentYear     =   textBox4.Text;
            StudentSeason  =    textBox19.Text;
            StudentCourseName = textBox8.Text;
            StudentNumber =     textBox1.Text;
            StudentName =       textBox15.Text;
            StudentCell1 =      comboBox10.Text; 
            StudentCell2 =      textBox5.Text;
            StudentCell3 =      textBox2.Text;
            StudentScore =      textBox6.Text;
            StudentMilitary =   comboBox4.Text;
            StudentCerName1 =   textBox9.Text;
            StudentCerDay1 =    textBox10.Text;
            StudentCerExe1 =    textBox11.Text;
            StudentCerName2 =   textBox12.Text;
            StudentCerDay2 =    textBox13.Text;
            StudentCerExe2 =    textBox14.Text;
            StudentLangName1 =  textBox17.Text;
            StudentLangCon1 =   comboBox1.Text;
            StudentLangRea1 =   comboBox2.Text;
            StudentLangWrl1 =   comboBox3.Text; 
            StudentLangName2 =  textBox16.Text;
            StudentLangCon2 =   comboBox7.Text;
            StudentLangRea2 =   comboBox6.Text;
            StudentLangWrl2 =   comboBox5.Text;
            StudentDolDiv =     comboBox9.Text;
            StudentDolDO =      comboBox8.Text;
            StudentDolHO =      textBox7.Text;
            StudentContent =    textBox18.Text;
            StudentTeacher =    textBox20.Text;
                                textBox4.Enabled = false;
                                textBox19.Enabled = false;
                                textBox8.Enabled = false;

            Console.WriteLine("------------테스트------------");
            Console.WriteLine(StudentYear);
            Console.WriteLine(StudentSeason);
            Console.WriteLine(StudentCourseName);
            Console.WriteLine(StudentNumber);
            Console.WriteLine(StudentName);
            Console.WriteLine(StudentCell1);
            Console.WriteLine(StudentCell2);
            Console.WriteLine(StudentCell3);
            Console.WriteLine(StudentScore);
            Console.WriteLine(StudentMilitary);
            Console.WriteLine(StudentCerName1);
            Console.WriteLine(StudentCerDay1);
            Console.WriteLine(StudentCerExe1);
            Console.WriteLine(StudentCerName2);
            Console.WriteLine(StudentCerDay2);
            Console.WriteLine(StudentCerExe2);
            Console.WriteLine(StudentLangName1);
            Console.WriteLine(StudentLangCon1);
            Console.WriteLine(StudentLangRea1);
            Console.WriteLine(StudentLangWrl1);
            Console.WriteLine(StudentLangName2);
            Console.WriteLine(StudentLangCon2);
            Console.WriteLine(StudentLangRea2);
            Console.WriteLine(StudentLangWrl2);
            Console.WriteLine(StudentDolDiv);
            Console.WriteLine(StudentDolDO);
            Console.WriteLine(StudentDolHO);
            Console.WriteLine(StudentContent);
            Console.WriteLine(StudentTeacher);
            Console.WriteLine("------------테스트------------");
            
        }
        
        public Apt_up(String a,String b,String c)
        {
            InitializeComponent();
            textBox4.Text = a;
            textBox19.Text = b;
            textBox8.Text = c;
        }
        public Apt_up(String a, String b, String c,string number)
        {
            InitializeComponent();
            textBox4.Text = a;
            textBox19.Text = b;
            textBox8.Text = c;
            StudentNumber = number;
            set_field();
        }
        private void set_field()
        {
            if(conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string sql = "SELECT * FROM TATM_STU where STU_STUNO ='"+StudentNumber+"'";
            try
            {
                cmd = new MySqlCommand(sql, conn);
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    textBox1.Text = reader["STU_STUNO"].ToString();
                    textBox15.Text = reader["STU_NAME"].ToString();
                    comboBox10.Text = reader["STU_PHONE"].ToString().Substring(0, 3);
                    textBox5.Text = reader["STU_PHONE"].ToString().Substring(3, 4);
                    textBox2.Text = reader["STU_PHONE"].ToString().Substring(7, 4);
                    textBox1.Enabled = false;
                    textBox15.Enabled = false;
                    comboBox10.Enabled = false;
                    textBox5.Enabled = false;
                    textBox2.Enabled = false;
                }
            }catch(Exception e2)
            {
                Console.WriteLine(e2.ToString());
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
            cou.Show();
        }

        private void re_Click(object sender, EventArgs e)
        {
            requset As = new requset();
            this.Close();
            As.Show();
        }

        private void stu_Click(object sender, EventArgs e)
        {
            Stu_sel apt = new Stu_sel();
            this.Close();
            apt.Show();
        }

        private void ft_Click (object sender, EventArgs e)
        {
            FT FT = new FT();
            this.Close();
            FT.Show();
        }

        private void Apt_Click(object sender, EventArgs e)
        {

            Apt_sel stu = new Apt_sel();
            this.Close();
            stu.Show();
        }

        private void Sta_Click(object sender, EventArgs e)
        {
            Statics sta = new Statics();
            this.Close();
            sta.Show();
        }
        private void Back_Click(object sender, EventArgs e)
        {

            Apt_sel stu = new Apt_sel();
            this.Close();
            stu.Show();
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

         }

        private void button9_Click(object sender, EventArgs e)
        {
            set_value();
            all_space_check();
            
            if(conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string sql = "INSERT INTO TATM_APP (";
            sql+=" APP_STUNO,";
            sql+=" APP_YEAR,";
            sql+=" APP_SEASON,";
            sql+=" APP_NAME,";
            sql+=" APP_TELNO,";
            sql+=" APP_GPA,";
            sql+=" APP_MIL,";
            sql+=" APP_CER1_NAME,";
            sql+=" APP_CER1_DAY,";
            sql+=" APP_CER1_EXE,";
            sql+=" APP_CER2_NAME,";
            sql+=" APP_CER2_DAY,";
            sql+=" APP_CER2_EXE,";
            sql+=" APP_ENG_CON,";
            sql+=" APP_ENG_REA,";
            sql+=" APP_ENG_WRI,";
            sql+=" APP_ETC_NAME,";
            sql+=" APP_ENG_NAME,";
            sql+=" APP_ETC_CON,";
            sql+=" APP_ETC_REA,";
            sql+=" APP_ETC_WRI,";
            sql+=" APP_DET,";
            sql+=" APP_ADV,";
            sql+= " APP_YN,";
            sql += "STU_DOR_DIV,";
            sql += "STU_DOR_DO,";
            sql += "STU_DOR_HO)";

            sql += "VALUES (";
            sql += "'" + StudentNumber + "',";
            sql += "'"+StudentYear+"',";
            sql += "'"+StudentSeason+"',";
            sql += "'"+StudentCourseName+"',";
            sql += "'"+StudentCell1+"-"+StudentCell2+"-"+StudentCell3+"',";
            sql += "'"+StudentScore+"',";
            sql += "'"+StudentMilitary+"',";
            sql += "'"+StudentCerName1+"',";
            sql += "'"+StudentCerDay1+"',";
            sql += "'"+StudentCerExe1+"',";
            sql += "'"+StudentCerName2+"',";
            sql += "'"+StudentCerDay2+"',";
            sql += "'"+StudentCerExe2+"',";
            sql += "'"+StudentLangName1+"',";
            sql += "'"+StudentLangCon1+"',";
            sql += "'"+StudentLangRea1+"',";
            sql += "'"+StudentLangWrl1+"',";
            sql += "'"+StudentLangName2+"',";
            sql += "'"+StudentLangCon2+"',";
            sql += "'"+StudentLangRea2+"',";
            sql += "'"+StudentLangWrl2+"',";
            sql += "'" + StudentContent + "',";
            sql += "'" + StudentTeacher + "',";
            sql += "'" + "Y" + "',";
            sql += "'"+StudentDolDiv+"',";
            sql += "'"+StudentDolDO+"',";
            sql += "'"+StudentDolHO+"')";
            Console.WriteLine(sql);

        }
        private int all_space_check()
        {
            set_value();
            if (space_check(StudentYear, "년도") == 1)
                if (space_check(StudentSeason, "계절") == 1)
                    if (space_check(StudentCourseName, "코스명") == 1)
                        if (space_check(StudentNumber, "학번") == 1)
                            if (space_check(StudentName, "이름") == 1)
                                if (space_check(StudentCell1, "전화번호") == 1)
                                    if (space_check(StudentCell2, "전화번호") == 1)
                                        if (space_check(StudentCell3, "전화번호") == 1)
                                            if (space_check(StudentScore, "학점") == 1)
                                                if (space_check(StudentMilitary, "군필여부") == 1)
                                                    if (space_check(StudentDolDiv, "기숙사여부") == 1)
                                                        if (space_check(StudentContent, "각오및다짐") == 1)
                                                        {
                                                            MessageBox.Show("빈칸체크완료");
                                                            return 1;
                                                        }
            return 0;
        }
        private int space_check(string text,string alert_msg)
        {
            if(text == "")
            {
                MessageBox.Show($"{alert_msg})이(가) 빈칸입니다");
                return 0;
            }
            else
            {
                return 1;
            }
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if(conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
          
            set_value();
            int i = 0;
            if (space_check(StudentNumber, "학번") != 1)
            {
                return;
            }
            bool result = int.TryParse(StudentNumber, out i); //i now = 108  
            if (result)
            {
                SelectQuery();
            }
            else
            {
                MessageBox.Show("학번은 문자가 들어 갈 수 없습니다");
                textBox1.Focus();
            }

        }
        private void SelectQuery()
        {
            string sql;
            
            sql = "select * from TATM_STU where STU_STUNO='"+StudentNumber+"'";
            try
            {
                cmd = new MySqlCommand(sql, conn);
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {

                }
                else
                {
                    if (MessageBox.Show("등록되지 않은 학생입니다. 등록하러 가시겠습니까?", "YesOrNo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        try
                        {
                                

                        }
                        catch (Exception e1)
                        {
                            MessageBox.Show(e1.ToString());
                        }
                        finally
                        {
                            reader.Close();
                            Stu_up s1 = new Stu_up(4);
                            s1.ShowDialog();
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("취소되었습니다");
                        textBox1.Focus();
                        reader.Close();
                    }
                }
            }
            catch (Exception e2)
                {
                    Console.WriteLine(e2.ToString());
                }
           
            }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox10_Leave(object sender, EventArgs e)
        {
            set_value();
            string[] cel = new string[3];
            cel[0] = "010";
            cel[1] = "011";
            cel[2] = "018";

            int i;
            int state = 0;
            for (i = 0; i < 3; i++)
            {
                if(StudentCell1 == cel[i])
                {
                    state = 1;
                }
            }

            if(state == 0)
            {
                MessageBox.Show("잘못된 형식의 전화번호입니다");
                comboBox10.Focus();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            set_value();
            int i;
            int state = 0;
            for (i = 0; i < 3; i++)
            {
                if (StudentLangCon1 == Grade[i])
                {
                    state = 1;
                }

            }
            if(state == 0)
            {
                MessageBox.Show("잘못된 형식입니다");
                comboBox1.Focus();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_Leave(object sender, EventArgs e)
        {
            set_value();
            int i;
            int state = 0;
            for (i = 0; i < 3; i++)
            {
                if (StudentLangRea1 == Grade[i])
                {
                    state = 1;
                }

            }
            if (state == 0)
            {
                MessageBox.Show("잘못된 형식입니다");
                comboBox2.Focus();
            }
        }

        private void comboBox3_Leave(object sender, EventArgs e)
        {
            set_value();
            int i;
            int state = 0;
            for (i = 0; i < 3; i++)
            {
                if (StudentLangWrl1 == Grade[i])
                {
                    state = 1;
                }

            }
            if (state == 0)
            {
                MessageBox.Show("잘못된 형식입니다");
                comboBox3.Focus();
            }
        }

        private void comboBox7_Leave(object sender, EventArgs e)
        {
            set_value();
            int i;
            int state = 0;
            for (i = 0; i < 3; i++)
            {
                if (StudentLangCon2 == Grade[i])
                {
                    state = 1;
                }

            }
            if (state == 0)
            {
                MessageBox.Show("잘못된 형식입니다");
                comboBox7.Focus();
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox6_Leave(object sender, EventArgs e)
        {
            set_value();
            int i;
            int state = 0;
            for (i = 0; i < 3; i++)
            {
                if (StudentLangRea2== Grade[i])
                {
                    state = 1;
                }

            }
            if (state == 0)
            {
                MessageBox.Show("잘못된 형식입니다");
                comboBox6.Focus();
            }
        }

        private void comboBox5_Leave(object sender, EventArgs e)
        {
            set_value();
            int i;
            int state = 0;
            for (i = 0; i < 3; i++)
            {
                if (StudentLangWrl2 == Grade[i])
                {
                    state = 1;
                }

            }
            if (state == 0)
            {
                MessageBox.Show("잘못된 형식입니다");
                comboBox5.Focus();
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox9_Leave(object sender, EventArgs e)
        {
            set_value();
            string[] grade = new string[2] { "사용", "비사용" };
            int i;
            int state = 0;
            for (i = 0; i < 2; i++)
            {
                if(StudentDolDiv  == grade[i])
                {
                    state = 1;
                }
            }
            if(state == 0)
            {
                MessageBox.Show("잘못된 형식입니다");
                comboBox9.Focus();
            }
            else
            {
                comboBox8.Enabled = true;
                textBox7.Enabled = true;
            }
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            set_clear();
            PageMode = "5";
        }
    }
}  
