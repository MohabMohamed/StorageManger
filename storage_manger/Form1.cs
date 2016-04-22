using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace storage_manger
{
    public partial class Form1 : Form
    {
        private XmlDocument xdoc;
        public Form1()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            XmlTextWriter writer = new XmlTextWriter(textBox5.Text +".xml", Encoding.UTF8);
            writer.Formatting = Formatting.Indented;
            writer.WriteStartElement("HardDisk");
            writer.WriteStartElement("Track");
            writer.WriteAttributeString("Size", textBox2.Text);
            writer.WriteStartElement("Sector");
            writer.WriteAttributeString("Size", textBox1.Text);
                                           

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
