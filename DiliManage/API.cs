using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Xml;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;
using System.IO;
using Newtonsoft.Json;

namespace WindowsApplication2
{
    public partial class API : Form
    {
        public int checkNumber = 0;
        public string Test1, Test2, Test3;
        string currentPage = "1";  //현재 페이지
        string countPerPage = "1000"; //1페이지당 출력 갯수
        string confmKey = "U01TX0FVVEgyMDE5MDcxNTE5NDg0NDEwODg4MzU="; //테스트 Key
        string keyword = string.Empty;
        string apiurl = string.Empty;

        public API()
        {
            InitializeComponent();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            keyword = textBox1.Text.Trim();
            string apiurl = "http://www.juso.go.kr/addrlink/addrLinkApi.do?currentPage=" + currentPage + "&countPerPage=" + countPerPage + "&keyword=" + keyword + "&confmKey=" + confmKey+"&resultType=JSON";
            Console.WriteLine(apiurl);
          
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(apiurl);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                string status = response.StatusCode.ToString();
                if (status == "OK")
                {
                    int i = 0;
                    Stream stream = response.GetResponseStream();
                    StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                    string text = reader.ReadToEnd();
                    JObject obj = JObject.Parse(text);
                    JArray array = JArray.Parse(obj["results"]["juso"].ToString());
                    string [] array1 = new String[10];
                    Console.WriteLine(array[0]);
                    dataGridView2.Rows.Clear();
                    foreach (JObject Items in array)
                    {
                        array1[0] = Items["zipNo"].ToString();
                        array1[1] = Items["sggNm"].ToString();
                        array1[2] = Items["jibunAddr"].ToString();
                        array1[3] = Items["siNm"].ToString();
                        array1[4] = Items["roadAddrPart1"].ToString();
                        dataGridView2.Rows.Add(array1);
                        i++;
                    }
                }
            }
            catch(Exception e1)
            {
                Console.WriteLine(e1.ToString());
            }
         
           
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void API_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            Test1 = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            Test2 = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            Test3  =dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();
            checkNumber = 1;
        }                     
    }                          
}