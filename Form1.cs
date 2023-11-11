using System;
using Amazon.Runtime.Internal;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Net.Http.Json;
using System.IO;
using System.Threading.Tasks;
using AWSSDK;
using System.Windows.Forms;
using Amazon.S3;
using Amazon;
using Amazon.Extensions.NETCore.Setup;
using Amazon.S3.Model;
using System.Net.Http;
using System.Net.Mime;

namespace WindowsFormsApp2
{
/*    private static HttpClient sharedClient = new()
    {
        BaseAddress = new Uri("https://functions.yandexcloud.net/d4ej6u7pukde3gcrhcho"),
    };*/
    public partial class Form1 : Form
    {
        string accessKey = "YCAJESpTGU0vjkBz0cF4rN9DB";
        string secretKey = "YCO5UVBdijjVvDHFJR_w4f64mXrWXp-7bee3tJS2";
        AmazonS3Config config = new AmazonS3Config{ ServiceURL = "https://s3.yandexcloud.net" };

        public Form1()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var s3client = new AmazonS3Client(accessKey, secretKey, config))
            {
                var listobj = s3client.ListObjects(new ListObjectsRequest() { BucketName = "youtubebacket" });


                foreach (var file in listobj.S3Objects)
                {
                    listBox1.Items.Add(file.Key.Remove(file.Key.LastIndexOf('.'), 4));
                }
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                using (var s3client = new AmazonS3Client(accessKey, secretKey, config))
                {
                    var listobj = s3client.ListObjects(new ListObjectsRequest() { BucketName = "youtubebacket" });

                    foreach (var file in listobj.S3Objects)
                    {
                        if (!listBox1.Items.Contains(file.Key.Remove(file.Key.LastIndexOf('.'), 4)))
                            listBox1.Items.Add(file.Key.Remove(file.Key.LastIndexOf('.'), 4));
                    }
                }
            }
            else
            {
                var name = textBox1.Text;
                var handler = new WinHttpHandler();
                var client = new HttpClient(handler);
                var requestData = new { name = name };
                var json = JsonSerializer.Serialize(requestData);
                var request = new HttpRequestMessage(HttpMethod.Get, "https://functions.yandexcloud.net/d4ej6u7pukde3gcrhcho?integration=raw")
                {
                    Content = new StringContent(json, Encoding.UTF8, "application/json"),
                };
                var response = await client.SendAsync(request);
                string responseBody = await response.Content.ReadAsStringAsync();
                MessageBox.Show(responseBody);
                listBox1.Items.Clear();
                using (var s3client = new AmazonS3Client(accessKey, secretKey, config))
                {
                    var listobj = s3client.ListObjects(new ListObjectsRequest() { BucketName = "youtubebacket" });

                    foreach (var file in listobj.S3Objects)
                    {
                        listBox1.Items.Add(file.Key.Remove(file.Key.LastIndexOf('.'), 4));
                        if(file.Key.Remove(file.Key.LastIndexOf('.'), 4) == textBox1.Text)
                        {
                            listBox1.SetSelected(listBox1.Items.Count - 1, true);
                        }
                    }
                }
                //var lobj = listBox1.Items.;
                textBox1.Text = null;
                var lbindex = listBox1.SelectedIndex;
                //listBox1_MouseClick()
                    //(listBox1.Items[listBox1.Items.Count - 1]);
                //var response = await client.SendAsync(request).ConfigureAwait(false);

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            //lname.Text = (string)sender;
            int index = listBox1.IndexFromPoint(e.Location);
/*            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                MessageBox.Show(index.ToString());
            }*/
            //MessageBox.Show(listBox1.SelectedItem.ToString());
            //int index = this.listBox1.IndexFromPoint(e.Location);
            string name = listBox1.SelectedItem.ToString();
            name = name.Replace(" ", "%20");
            name += ".txt";
            string urlitem = "https://storage.yandexcloud.net/youtubebacket/";
            urlitem += name;
            lname.Visible = true;
            subs.Visible = true;
            lsubs.Visible = true;
            views.Visible = true;
            lviews.Visible = true;
            videos.Visible = true;
            lvideos.Visible = true;
            pictureBox1.Visible = true;
            vidos1.Visible = true;
            vidos2.Visible = true;
            vidos3.Visible = true;
            vname1.Visible = true;
            vname2.Visible = true;  
            vname3.Visible = true;
            var channeldata = new List<string>(new HttpClient().GetStringAsync(urlitem).Result.Split(new string[] { "\r\n", "\r", "\n" }, StringSplitOptions.None));
            //List<string> channel = new List<string>(nfile.Split(new string[] { Environment.NewLine }, StringSplitOptions.None));
            lname.Text = channeldata[0];
            pictureBox1.Load(channeldata[1]);
            lsubs.Text = channeldata[3];
            lviews.Text = channeldata[4];
            lvideos.Text= channeldata[2];
            vidos1.Load(channeldata[6]);
            vname1.Text = channeldata[5];
            vidos2.Load(channeldata[8]);
            vname2.Text = channeldata[7];
            vidos3.Load(channeldata[10]);
            vname3.Text = channeldata[9];
        }
        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
