using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using _SCREEN_CAPTURE;

namespace DllTest
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();
            //this.Enabled = false;
            this.FormClosed += (s, e) => this.Dispose();
        }
        ~Form1() {
            MessageBox.Show("test");
        }

        private void Form1_Load(object sender, EventArgs e) {
            //this.Enabled = false;
            //MessageBox.Show(toolButton1.IsSelected.ToString());
        }

        private void Form1_Paint(object sender, PaintEventArgs e) {
   
        }

        private void button1_Click_1(object sender, EventArgs e) {
            //this.Enabled = false;
            //FrmCapture.ImgProcessBox = new ImageProcessBox();
            FrmCapture frmC = new FrmCapture();
            //frmC.IsCaptureCursor = true;                //是否捕获鼠标
            //frmC.ImgProcessBoxIsShowInfo = true;        //是否绘制图像信息显示
            //frmC.ImgProcessBoxDotColor = Color.Yellow;  //操作框点的颜色
            //frmC.ImgProcessBoxLineColor = Color.Cyan;   //操作框边框的颜色
            //frmC.ImgProcessBoxMagnifySize = new System.Drawing.Size(15, 15);//信息的原始图像大小
            //frmC.ImgProcessBoxMagnifyTimes = 7;         //信息放大的倍数
            frmC.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            textBox1.Height = (textBox1.Lines.Length + 1) * textBox1.Font.Height;
        }
    }
}
