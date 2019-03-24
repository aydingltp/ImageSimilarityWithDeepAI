using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DeepAI;
using ImageSimilarity.Model;
using Newtonsoft.Json;

namespace ImageSimilarity
{
    public partial class Form1 : Form
    {
        OpenFileDialog resim1 = new OpenFileDialog();
        OpenFileDialog resim2 = new OpenFileDialog();
        DataContext db = new DataContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void form1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
             
        } 

        private void btnResim1_Click(object sender, EventArgs e)
        {
            resim1.Filter = "resimler|*.BMP*.JPG; *|All Files|*.*";

            if (resim1.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                return;
            }
            pictureBox1.ImageLocation = resim1.FileName;
        }

        private void btnResim2_Click(object sender, EventArgs e)
        {
            resim2.Filter = "resimler|*.BMP*.JPG; *|All Files|*.*";

            if (resim2.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                return;
            }
            pictureBox2.ImageLocation = resim2.FileName;
        }

        private void btnKarsilastir_Click(object sender, EventArgs e)
        {
            DeepAI_API api = new DeepAI_API(apiKey: "df10d4f7-7797-4030-b0f6-e5243e869c91");
            string a = resim1.FileName;
            string a2 = resim2.FileName;

            StandardApiResponse resp = api.callStandardApi("image-similarity", new
            {
                //image1 = resim1.FileName.ToString(),
                //image2 = resim2.FileName.ToString(),
                image1 = File.OpenRead(a),
                image2 = File.OpenRead(a2),

                //File.OpenRead("C:\\path\\to\\your\\file.jpg"),

            });
            string gelen = api.objectAsJsonString(resp.output);
            lblSonuc.Text = api.objectAsJsonString(resp.output).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }

}
