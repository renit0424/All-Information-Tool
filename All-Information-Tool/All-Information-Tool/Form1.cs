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
using Newtonsoft.Json;
using System.Net;

namespace All_Information_Tool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            ////今日の天気予報の取得   
            string baseUrl = "http://weather.livedoor.com/forecast/webservice/json/v1";

            string cityname = "320010";

            string url = $"{baseUrl}?city={cityname}";
            string json = new HttpClient().GetStringAsync(url).Result;
            JObject jobj = JObject.Parse(json);

            string todayweather = (string)((jobj["forecasts"][0]["telop"] as JValue).Value);//今日の天気の取得
            label2.Text = (todayweather);
            switch (todayweather)
            {
                case "晴れ":
                    this.pictureBox1.Image = Properties.Resources._010701sonota107_trans;
                    break;
                case "晴時々曇":
                    this.pictureBox1.Image = Properties.Resources._010701sonota143_trans;
                    break;
                case "晴れ時々雨":
                    this.pictureBox1.Image = Properties.Resources._010701sonota175_trans;
                    break;
                case "晴れ時々雪":
                    this.pictureBox1.Image = Properties.Resources._010701sonota211_trans;
                    break;
                case "晴のち曇":
                    this.pictureBox1.Image = Properties.Resources._010701sonota218_trans;
                    break;
                case "晴のち雨":
                    this.pictureBox1.Image = Properties.Resources._010701sonota250_trans;
                    break;
                case "晴のち雪":
                    this.pictureBox1.Image = Properties.Resources._010701sonota287_trans;
                    break;
                case "曇り":
                    this.pictureBox1.Image = Properties.Resources._010701sonota111_trans;
                    break;
                case "曇時々晴":
                    this.pictureBox1.Image = Properties.Resources._010701sonota147_trans;
                    break;
                case "曇時々雨":
                    this.pictureBox1.Image = Properties.Resources._010701sonota167_trans;
                    break;
                case "曇時々雪":
                    this.pictureBox1.Image = Properties.Resources._010701sonota191_trans;
                    break;
                case "曇のち晴":
                    this.pictureBox1.Image = Properties.Resources._010701sonota222_trans;
                    break;
                case "曇のち雨":
                    this.pictureBox1.Image = Properties.Resources._010701sonota242_trans;
                    break;
                case "曇のち雪":
                    this.pictureBox1.Image = Properties.Resources._010701sonota266_trans;
                    break;
                case "雨":
                    this.pictureBox1.Image = Properties.Resources._010701sonota130_trans;
                    break;
                case "雨時々晴":
                    this.pictureBox1.Image = Properties.Resources._010701sonota179_trans;
                    break;
                case "雨時々雪":
                    this.pictureBox1.Image = Properties.Resources._010701sonota199_trans;
                    break;
                case "雨のち晴":
                    this.pictureBox1.Image = Properties.Resources._010701sonota254_trans;
                    break;
                case "雨のち曇":
                    this.pictureBox1.Image = Properties.Resources._010701sonota246_trans;
                    break;
                case "雨のち雪":
                    this.pictureBox1.Image = Properties.Resources._010701sonota274_trans;
                    break;
                case "雪":
                    this.pictureBox1.Image = Properties.Resources._010701sonota179_trans;
                    break;
                case "雪時々晴":
                    this.pictureBox1.Image = Properties.Resources._010701sonota179_trans;
                    break;
                case "雪時々雨":
                    this.pictureBox1.Image = Properties.Resources._010701sonota179_trans;
                    break;
                case "雪のち晴":
                    this.pictureBox1.Image = Properties.Resources._010701sonota282_trans;
                    break;
                case "雪のち曇":
                    this.pictureBox1.Image = Properties.Resources._010701sonota270_trans;
                    break;
                case "雪のち雨":
                    this.pictureBox1.Image = Properties.Resources._010701sonota179_trans;
                    break;
                case "暴風雪":
                    this.pictureBox1.Image = Properties.Resources._010701sonota179_trans;
                    break;
            }
            pictureBox3.ImageLocation = "https://mwsgvs.weathernews.jp/wxct/jpg/week8.jpg";
            pictureBox5.ImageLocation = "https://mwsgvs.weathernews.jp/wxct/jpg/wxcto.jpg";
            string URLText = "http://weather.livedoor.com/area/forecast/320010";
            //docがHtmlのコードを文書として保持します
            var doc = new HtmlAgilityPack.HtmlDocument();

            //webを通してHtmlのコードを取得します
            var web = new System.Net.WebClient();

            //HtmlをUTF-8で取得します。
            //特に指定しない場合、Htmlの文字コードによっては文字化けする場合があります
            web.Encoding = Encoding.UTF8;

            //web.DownloadString(URL)のURL先のHtmlを取得します。
            //今回の場合はテキストボックスに書かれているURLを入れています
            doc.LoadHtml(web.DownloadString(URLText));

            //取得したHtmlコードからどの部分を取得するのかをXPath形式で指定します
            //今回はブログの本文を指定しています
            string Tani_XPath = @"/html[1]/body[1]/div[2]/div[2]/div[1]/div[7]/p[1]";

            //指定したXPathをもとに文を取得しています
            var Tani_Collection = doc.DocumentNode.SelectNodes(Tani_XPath);

            string Tani_str = null;

            //Tani_CollectionはListなので、一つずつ文を取り出しています
            //文はInnerTextで取り出すことができます
            foreach (var tmp in Tani_Collection)
            {
                Tani_str += tmp.InnerText;
            }

            //取得した文を表示します
            textBox1.Text = Tani_str;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox2.ImageLocation = "http://memgvs.weathernews.jp/a/rad/japan2/anim.gif";
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            string json;
            DateTime rttm = DateTime.Now;
            string retime = rttm.ToString("yyyyMMddHHmmss");
            using (var wc = new System.Net.WebClient())
            {
                wc.Encoding = System.Text.Encoding.UTF8;
                json = wc.DownloadString("http://www.kmoni.bosai.go.jp/new/webservice/hypo/eew/" + retime + ".json");
                //json = wc.DownloadString("http://www.kmoni.bosai.go.jp/new/webservice/hypo/eew/20180105110259.json");
            }


            {
                if (json.Contains("ありません")) //ここ追記

                    /*EEWがないときの処理*/
                    return;
            }

            var jsonData = JsonConvert.DeserializeObject<Json>(json);

            switch (jsonData.Alertflg)
            {
                case "予報":
                    label3.Text = "緊急地震速報(予報)";
                    break;
                case "警報":
                    label3.Text = "緊急地震速報(警報)";
                    break;
            }

            //第x報
            label4.Text = ($"第{jsonData.Report_num}報");
            //発生時刻
            label5.Text = DateTime.ParseExact(jsonData.Origin_time, "yyyyMMddHHmmss", null).ToString(("yyyy/MM/dd HH:mm:ss"));
            //震源地
            label6.Text = ($"震源地 { jsonData.Region_name}");
            //深さ
            label7.Text = ($"深さ {jsonData.Depth}");
            //マグニチュード
            label8.Text = ($"マグニチュード {jsonData.Magnitude}");
            //推定最大震度
            label9.Text = ($"推定震度 {jsonData.Calcintensity}");

        }
    }

    public class Json
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("result")]
        public Results Result { get; set; }
        /// <summary>
        /// 電文発表時刻
        /// </summary>
        [JsonProperty("report_time")]
        public string Report_time { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("region_code")]
        public string Region_code { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("request_time")]
        public string Request_time { get; set; }
        /// <summary>
        /// 震源地
        /// </summary>
        [JsonProperty("region_name")]
        public string Region_name { get; set; }
        /// <summary>
        /// 経度（東経）
        /// </summary>
        [JsonProperty("longitude")]
        public string Longitude { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("is_cancel")]
        public bool Is_cancel { get; set; }
        /// <summary>
        /// 深さ
        /// </summary>
        [JsonProperty("depth")]
        public string Depth { get; set; }
        /// <summary>
        /// 最大震度
        /// </summary>
        [JsonProperty("calcintensity")]
        public string Calcintensity { get; set; }
        /// <summary>
        /// 最終報か
        /// </summary>
        [JsonProperty("is_final")]
        public bool Is_final { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("is_training")]
        public bool Is_training { get; set; }
        /// <summary>
        /// 緯度（北緯）
        /// </summary>
        [JsonProperty("latitude")]
        public string Latitude { get; set; }
        /// <summary>
        /// 地震発生／検知時刻
        /// </summary>
        [JsonProperty("origin_time")]
        public string Origin_time { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("security")]
        public Securities Security { get; set; }
        /// <summary>
        /// マグニチュード
        /// </summary>
        [JsonProperty("magunitude")]
        public string Magnitude { get; set; }
        [JsonProperty("report_num")]
        public string Report_num { get; set; }
        [JsonProperty("request_hypo_type")]
        public string Request_hypo_type { get; set; }
        [JsonProperty("report_id")]
        public string Report_id { get; set; }
        [JsonProperty("alertflg")]
        public string Alertflg { get; set; }


        public class Results
        {
            /// <summary>
            /// 
            /// </summary>
            [JsonProperty("status")]
            public string Status { get; set; }
            /// <summary>
            /// 
            /// </summary>
            [JsonProperty("message")]
            public string Message { get; set; }
            /// <summary>
            /// 
            /// </summary>
            [JsonProperty("is_auth")]
            public bool Is_auth { get; set; }
        }

        public class Securities
        {
            /// <summary>
            /// 
            /// </summary>
            [JsonProperty("realm")]
            public string Realm { get; set; }
            /// <summary>
            /// 
            /// </summary>
            [JsonProperty("hash")]
            public string Hash { get; set; }
        }
    }
}