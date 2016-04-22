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
            writer.WriteStartElement("Sector"); //<Sector>
            writer.WriteAttributeString("Size", textBox1.Text);
            long x = long.Parse(textBox2.Text);
            long y = long.Parse(textBox1.Text);
            long div = x / y;
            writer.WriteString(div.ToString());

            writer.WriteEndElement();// </Sector>
            writer.WriteStartElement("Frag");// Frag
            writer.WriteString("2");
            writer.WriteEndElement();//</Frag>
            writer.WriteEndElement();// </Track>
            writer.WriteEndElement();// </harddisk>
            writer.Close();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
