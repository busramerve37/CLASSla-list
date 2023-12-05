using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buttpn.ornek._48
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Ogrenci>ogrenciList = new List<Ogrenci>();

            ogrenciList.Add(new Ogrenci(34, "Meryem Akbahar", "10A", "5555555555"));
            ogrenciList.Add(new Ogrenci(65, "Ayda  Ersoy", "10E", "5444444444"));
            ogrenciList.Add(new Ogrenci(656, "Elmas  Gümüş", "10E", "5333333333"));

            dataGridView1.DataSource= ogrenciList.ToList();


        }
    }
}
