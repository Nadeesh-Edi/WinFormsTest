using HelloWorld.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace HelloWorld
{
    public partial class Page2 : Form
    {
        public Page2()
        {
            InitializeComponent();
        }

        private async void configureData()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(@"https://api.nasa.gov/planetary/apod?api_key=mQhMNIei72xPngdwB6pYM17cshnvGGr3b1yWj2Ay");
            request.Method = "GET";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string content = new StreamReader(response.GetResponseStream()).ReadToEnd();

            ApodResponseModel responseObj = JsonConvert.DeserializeObject<ApodResponseModel>(content);

            pictureBox.ImageLocation = responseObj.Url;
            TitleLabel.Text = responseObj.Title;
            explanation.Text = responseObj.Explanation;
            date.Text = responseObj.Date;
        }

        private void buttonGroup_Enter(object sender, EventArgs e)
        {

        }

        private void Page2_Load(object sender, EventArgs e)
        {
            configureData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
        }
    }
}
