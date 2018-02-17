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
            ktimer1.Start();
            ktimer2.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            ////今日の天気予報の取得   
            string baseUrl = "http://weather.livedoor.com/forecast/webservice/json/v1";
            //東京都のID
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
                case "曇時々晴れ":
                    this.pictureBox1.Image = Properties.Resources._010701sonota147_trans;
                    break;
                case "曇時々雨":
                    this.pictureBox1.Image = Properties.Resources._010701sonota167_trans;
                    break;
                case "曇時々雪":
                    this.pictureBox1.Image = Properties.Resources._010701sonota191_trans;
                    break;
                case "曇のち晴れ":
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
                case "雨時々晴れ":
                    this.pictureBox1.Image = Properties.Resources._010701sonota179_trans;
                    break;
                case "雨時々雪":
                    this.pictureBox1.Image = Properties.Resources._010701sonota199_trans;
                    break;
                case "雨のち晴れ":
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
                case "雪時々晴れ":
                    this.pictureBox1.Image = Properties.Resources._010701sonota179_trans;
                    break;
                case "雪時々雨":
                    this.pictureBox1.Image = Properties.Resources._010701sonota179_trans;
                    break;
                case "雪のち晴れ":
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
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ////今日の天気予報の取得   
            string baseUrl = "http://weather.livedoor.com/forecast/webservice/json/v1";
            //東京都のID
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
                case "曇時々晴れ":
                    this.pictureBox1.Image = Properties.Resources._010701sonota147_trans;
                    break;
                case "曇時々雨":
                    this.pictureBox1.Image = Properties.Resources._010701sonota167_trans;
                    break;
                case "曇時々雪":
                    this.pictureBox1.Image = Properties.Resources._010701sonota191_trans;
                    break;
                case "曇のち晴れ":
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
                case "雨時々晴れ":
                    this.pictureBox1.Image = Properties.Resources._010701sonota179_trans;
                    break;
                case "雨時々雪":
                    this.pictureBox1.Image = Properties.Resources._010701sonota199_trans;
                    break;
                case "雨のち晴れ":
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
                case "雪時々晴れ":
                    this.pictureBox1.Image = Properties.Resources._010701sonota179_trans;
                    break;
                case "雪時々雨":
                    this.pictureBox1.Image = Properties.Resources._010701sonota179_trans;
                    break;
                case "雪のち晴れ":
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
            
            switch(jsonData.Alertflg)
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

        private async void ktimer1_Tick(object sender, EventArgs e)
        {
            //地表加速度
            try
            {
                DateTime dtNow = DateTime.Now;
                DateTime time = DateTime.Now.AddSeconds(-3);
                //-3＝PC時計から-3秒を取得する

                string url = UrlGenerator.Generate(UrlType.RealTimeImg, time, RealTimeImgType.Pga);
                Bitmap img = new Bitmap(new MemoryStream(await(new WebClient().DownloadDataTaskAsync(url))));

                pictureBox3.ImageLocation = url;
            }
            catch
            {
                //失敗したときの処理
                //例： MessageBox.Show("取得に失敗しました。");
                //でも↑だと失敗した分出てくるからすごい数になりそう
            }
        }

        private async void ktimer2_Tick(object sender, EventArgs e)
        {
            //地表震度
            try
            {
                DateTime dtNow = DateTime.Now;
                DateTime time = DateTime.Now.AddSeconds(-3);
                //-3＝PC時計から-3秒を取得する

                string url = UrlGenerator.Generate(UrlType.RealTimeImg, time, RealTimeImgType.Shindo);
                Bitmap img = new Bitmap(new MemoryStream(await(new WebClient().DownloadDataTaskAsync(url))));

                pictureBox4.ImageLocation = url;
            }
            catch
            {
                //取得error処理
            }
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
    //ここから↓を変えると動かないかも
    public enum RealTimeImgType
    {
        /// <summary>
        /// 震度
        /// </summary>
        Shindo,

        /// <summary>
        /// 最大加速度
        /// </summary>
        Pga,

        /// <summary>
        /// 最大速度
        /// </summary>
        Pgv,

        /// <summary>
        /// 最大変位
        /// </summary>
        Pgd,

        /// <summary>
        /// 速度応答0.125Hz
        /// </summary>
        Response_0_125Hz,

        /// <summary>
        /// 速度応答0.25Hz
        /// </summary>
        Response_0_25Hz,

        /// <summary>
        /// 速度応答0.5Hz
        /// </summary>
        Response_0_5Hz,

        /// <summary>
        /// 速度応答1Hz
        /// </summary>
        Response_1Hz,

        /// <summary>
        /// 速度応答2Hz
        /// </summary>
        Response_2Hz,

        /// <summary>
        /// 速度応答4Hz
        /// </summary>
        Response_4Hz,
    }

    /// <summary>
    /// RealTimeImgTypeの拡張メソッド
    /// </summary>
    public static class RealTimeImgTimeExtensions
    {
        /// <summary>
        /// URLに使用する文字列に変換する
        /// </summary>
        /// <param name="type">変換するRealTimeImgTypy</param>
        /// <returns>変換された文字列</returns>
        public static string ToUrlString(this RealTimeImgType type)
        {
            switch (type)
            {
                case RealTimeImgType.Shindo:
                    return "jma";

                case RealTimeImgType.Pga:
                    return "acmap";

                case RealTimeImgType.Pgv:
                    return "vcmap";

                case RealTimeImgType.Pgd:
                    return "dcmap";

                case RealTimeImgType.Response_0_125Hz:
                    return "rsp0125";

                case RealTimeImgType.Response_0_25Hz:
                    return "rsp0250";

                case RealTimeImgType.Response_0_5Hz:
                    return "rsp0500";

                case RealTimeImgType.Response_1Hz:
                    return "rsp1000";

                case RealTimeImgType.Response_2Hz:
                    return "rsp2000";

                case RealTimeImgType.Response_4Hz:
                    return "rsp4000";
            }
            return null;
        }
    }

    /// <summary>
    /// 新強震モニタのURL生成器
    /// </summary>
    public static class UrlGenerator
    {
        /// <summary>
        /// JsonEewのベースURL
        /// <para>0:時間</para>
        /// </summary>
        public static string JsonEewBase = "http://www.kmoni.bosai.go.jp/new/webservice/hypo/eew/{0}.json";

        /// <summary>
        /// PsWaveImgのベースURL
        /// <para>0:日付</para>
        /// <para>1:時間</para>
        /// </summary>
        public static string PsWaveBase = "http://www.kmoni.bosai.go.jp/new/data/map_img/PSWaveImg/eew/{0}/{1}.eew.gif";

        /// <summary>
        /// RealTimeImgのベースURL
        /// <para>0:タイプ</para>
        /// <para>1:地上(s)/地下(b)</para>
        /// <para>2:日付</para>
        /// <para>3:時間</para>
        /// </summary>
        public static string RealTimeBase = "http://www.kmoni.bosai.go.jp/new/data/map_img/RealTimeImg/{0}_{1}/{2}/{3}.{0}_{1}.gif";

        /// <summary>
        /// 予想震度のベースURL
        /// <para>0:日付</para>
        /// <para>1:時間</para>
        /// </summary>
        public static string EstShindoBase = "http://www.kmoni.bosai.go.jp/new/data/map_img/EstShindoImg/eew/{0}/{1}.eew.gif";

        /// <summary>
        /// 与えられた値を使用してURLを生成します。
        /// </summary>
        /// <param name="urlType">生成するURLのタイプ</param>
        /// <param name="datetime">生成するURLの時間</param>
        /// <param name="realTimeShindoType">(UrlType=RealTimeImgの際に使用)取得するリアルタイム情報の種類</param>
        /// <param name="isBerehole">(UrlType=RealTimeImgの際に使用)地中の情報を取得するかどうか</param>
        /// <returns></returns>
        public static string Generate(UrlType urlType, DateTime datetime,
            RealTimeImgType realTimeShindoType = RealTimeImgType.Shindo, bool isBerehole = false)
        {
            switch (urlType)
            {
                case UrlType.RealTimeImg:
                    return string.Format(RealTimeBase, realTimeShindoType.ToUrlString(), isBerehole ? "b" : "s", datetime.ToString("yyyyMMdd"), datetime.ToString("yyyyMMddHHmmss"));

                case UrlType.RestShindo:
                    return string.Format(EstShindoBase, datetime.ToString("yyyyMMdd"), datetime.ToString("yyyyMMddHHmmss"));

                case UrlType.PSWave:
                    return string.Format(PsWaveBase, datetime.ToString("yyyyMMdd"), datetime.ToString("yyyyMMddHHmmss"));

                case UrlType.EewJson:
                    return string.Format(JsonEewBase, datetime.ToString("yyyyMMddHHmmss"));
            }
            return null;
        }
    }


    /// <summary>
    /// 生成するURLの種類
    /// </summary>
    public enum UrlType
    {
        /// <summary>
        /// リアルタイム情報
        /// <para>震度、加速度など</para>
        /// </summary>
        RealTimeImg = 0,

        /// <summary>
        /// 到達予想震度
        /// </summary>
        RestShindo,

        /// <summary>
        /// P波、S波到達予想円
        /// </summary>
        PSWave,

        /// <summary>
        /// 緊急地震速報のJson
        /// </summary>
        EewJson,
    }
}