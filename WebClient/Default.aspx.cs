using WebClient.ServiceReference1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using Newtonsoft.Json;
namespace WebClient
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        ServiceReference1.BmiSoapServiceClient myClient = new ServiceReference1.BmiSoapServiceClient();
        protected void myBmiButton_Click(object sender, EventArgs e)
        {
            string height = heightText.Text;
            string weight = weightText.Text;
            double bmi = myClient.myBMI(Convert.ToInt32(height), Convert.ToInt32(weight));
            bmiResultText.Text = bmi.ToString();
            riskText.Text = "";
            moreText.Text = "";
        }

        protected void myHealthButton_Click(object sender, EventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder();
            string height = heightText.Text;
            string weight = weightText.Text;
            BMI bmi = myClient.myHealth(Convert.ToInt32(height), Convert.ToInt32(weight));
            bmiResultText.Text = bmi.Bmi.ToString();
            riskText.Text = bmi.Risk;
            foreach (string item in bmi.More)
            {
                stringBuilder.AppendLine(item);
            }
            moreText.Text = stringBuilder.ToString();
        }

        protected void myBmiButton_Click2(object sender, EventArgs e)
        {
            string height = heightText0.Text;
            string weight = weightText0.Text;
            string url = $"https://localhost:44395/api/bmi/myBMI?height={height}&weight={weight}";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream);
            string json = reader.ReadToEnd();
            double bmi = JsonConvert.DeserializeObject<double>(json);
            bmiResultText0.Text = bmi.ToString();
            riskText0.Text = "";
            moreText0.Text = "";
            jsonText.Text = "";
        }

        protected void myHealthButton_Click2(object sender, EventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder();
            string height = heightText0.Text;
            string weight = weightText0.Text;
            string url = $"https://localhost:44395/api/bmi/myHealth?height={height}&weight={weight}";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream);
            string json = reader.ReadToEnd();

            results r = JsonConvert.DeserializeObject<results>(json);
            bmiResultText0.Text = r.bmi.ToString();
            riskText0.Text = r.Risk;
            foreach (string item in r.More)
            {
                stringBuilder.AppendLine(item);
            }
            moreText0.Text = stringBuilder.ToString();

            string formattedJson = JsonConvert.SerializeObject(JsonConvert.DeserializeObject(json), Newtonsoft.Json.Formatting.Indented);
            jsonText.Text = formattedJson;
        }
    }
    [Serializable]
    public class results
    {
        public double bmi { get; set; }
        public string Risk { get; set; }
        public string[] More { get; set; }
    }
}