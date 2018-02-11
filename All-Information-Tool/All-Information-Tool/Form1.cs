using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json.Linq;

namespace All_Information_Tool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ////今日の天気予報の取得   
            string baseUrl = "http://weather.livedoor.com/forecast/webservice/json/v1";
            //東京都のID
            string cityname = "340010";

            string url = $"{baseUrl}?city={cityname}";
            string json = new HttpClient().GetStringAsync(url).Result;
            JObject jobj = JObject.Parse(json);

            string todayweather = (string)((jobj["forecasts"][0]["telop"] as JValue).Value);//今日の天気の取得
            label2.Text = (todayweather);
            switch(todayweather)
            {
                case "晴":
                    this.pictureBox1.Image = Properties.Resources.sozai_cman_jp_20180211170221;
                    break;
                case "晴れ時々曇り":
                    this.pictureBox1.Image = Properties.Resources.sozai_cman_jp_20180211170221;
                    break;
                case "晴れ時々雨":
                    this.pictureBox1.Image = Properties.Resources.sozai_cman_jp_20180211170221;
                    break;
                case "晴れ時々雪":
                    this.pictureBox1.Image = Properties.Resources.sozai_cman_jp_20180211170221;
                    break;
                case "晴れのち曇り":
                    this.pictureBox1.Image = Properties.Resources.sozai_cman_jp_20180211170221;
                    break;
                case "晴れのち雨":
                    this.pictureBox1.Image = Properties.Resources.sozai_cman_jp_20180211170221;
                    break;
                case "晴れのち雪":
                    this.pictureBox1.Image = Properties.Resources.sozai_cman_jp_20180211170221;
                    break;
                case "曇り":
                    this.pictureBox1.Image = Properties.Resources.sozai_cman_jp_20180211170221;
                    break;
                case "曇り時々晴れ":
                    this.pictureBox1.Image = Properties.Resources.sozai_cman_jp_20180211170221;
                    break;
                case "曇り時々雨":
                    this.pictureBox1.Image = Properties.Resources.sozai_cman_jp_20180211170221;
                    break;
                case "曇り時々雪":
                    this.pictureBox1.Image = Properties.Resources.sozai_cman_jp_20180211170221;
                    break;
                case "曇りのち晴れ":
                    this.pictureBox1.Image = Properties.Resources.sozai_cman_jp_20180211170221;
                    break;
                case "曇りのち雨":
                    this.pictureBox1.Image = Properties.Resources.sozai_cman_jp_20180211170221;
                    break;
                case "曇りのち雪":
                    this.pictureBox1.Image = Properties.Resources.sozai_cman_jp_20180211170221;
                    break;
                case "雨":
                    this.pictureBox1.Image = Properties.Resources.sozai_cman_jp_20180211170221;
                    break;
                case "雨時々晴れ":
                    this.pictureBox1.Image = Properties.Resources.sozai_cman_jp_20180211170221;
                    break;
            }
        }
    }
}
