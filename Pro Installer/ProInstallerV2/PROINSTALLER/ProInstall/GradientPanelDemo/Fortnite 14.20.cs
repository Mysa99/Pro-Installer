using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradientPanelDemo
{
    public partial class Fortnite_14 : Form
    {
        WebClient fn1420 = new WebClient();
        public Fortnite_14()
        {
            InitializeComponent();
        }

        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Downloading... Please Be Patient, we trying to Download as fast as we can. You will get an Message If its Done.", "Download", MessageBoxButtons.OK);
            fn1420.DownloadFileCompleted += new AsyncCompletedEventHandler(FileDownloadComplete);
            Uri fortnite1420 = new Uri(textBox2.Text);
            fn1420.DownloadFileAsync(fortnite1420, "Fortnite1240.rar");
        }

        private void FileDownloadComplete(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Done Downloading your Selected Game. It should be in Your Downloads Folder!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome To Pro Installer! Download Part: So first, it will take a *LONG* time to Download your Selected File. Anyways if you Done Installing check your Path where you Opened Pro Installer click on rename and at the End you add an .rar And you already Done! now extract your File and Enjoy your Downloaded File! Select Path Part: To Select your Path just go where you putted Pro Installer and its gonna Install it there where Pro Installer is Executeable which means If you have it in your Downloads Folder it will Download it in the Downloads Folder. To Avoid problems with your Space i recommend putting it on the D: Drive. Also Don't Worry like we said It takes a LONG time to Download it will Show an Message If its Done.", "Infomation");
        }

        private void Fortnite_14_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
