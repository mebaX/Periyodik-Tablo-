using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwentyE.Properties;

namespace TwentyE
{
    public partial class MyMessageBox : Form
    {
        static MyMessageBox newMessageBox;
        public MyMessageBox()
        {
            InitializeComponent();
        }
        public static void ShowBox(string caption)
        {
            newMessageBox = new MyMessageBox();
            newMessageBox.description.Text = caption;
            newMessageBox.ShowDialog();
        }
        public static void ShowBox(string Title, string Description, string kullanimAlanlari,int atomNumarasi,string sinif,Image image)
        {
            newMessageBox = new();
            newMessageBox.pictureBox1.Image = image;
            newMessageBox.Text = Title;
            newMessageBox.description.Text = $"{Description}\nKullanım alanları : {kullanimAlanlari}\nAtom numarası : {atomNumarasi}\nProton sayısı : {atomNumarasi}\nElektron sayısı : {atomNumarasi}\nBulunduğu sınıf : {sinif}";
            newMessageBox.ShowDialog();
        }

        private void OKbtn_Click(object sender, EventArgs e)
        {
            newMessageBox.Dispose();
        }
    }
}
