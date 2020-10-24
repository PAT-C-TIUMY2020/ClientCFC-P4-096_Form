using ServiceMtk_P2_096;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientCFC_P4_096_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BasicHttpBinding bind = new BasicHttpBinding();
            ChannelFactory<IMatematika> objChannel = new ChannelFactory<IMatematika>(bind, "http://localhost:8080");
            IMatematika obj = objChannel.CreateChannel();
            double hasilTambah = obj.Tambah(1, 2);
            label1.Text ="1 + 2 = " + hasilTambah;
            double hasilKurang = obj.Kurang(3, 2);
            label2.Text = "3 - 2 = " + hasilKurang;
            double hasilKali = obj.Kali(2, 2);
            label3.Text = "2 x 2 = " + hasilKali;
            double hasilBagi = obj.Bagi(2, 2);
            label4.Text = "2 / 2 = " + hasilBagi;
            

            Koordinat objk = new Koordinat();
        }
    }
}
