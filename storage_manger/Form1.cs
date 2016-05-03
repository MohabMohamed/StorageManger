using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace storage_manger
{
    public partial class Form1 : Form
    {
        List<Data> stlist = new List<Data>();
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
            for (int i = 0; i < dataGridView1.Rows.Count -1 ; i++) {
               
               Data st = new Data();
                st.ID = dataGridView1.Rows[i].Cells[0].Value.ToString();
                st.Name = dataGridView1.Rows[i].Cells[1].Value.ToString();
                st.Address = dataGridView1.Rows[i].Cells[2].Value.ToString();
                stlist.Add(st);
            }
            XmlSerializer xs = new XmlSerializer(stlist.GetType());
            FileStream fs = new FileStream("StudentData.xml", FileMode.OpenOrCreate);
            xs.Serialize(fs, stlist);
            fs.Close();
            dataGridView1.Rows.Clear();
          
            //long div = long.Parse(textBox2.Text) / long.Parse(textBox1.Text);
           
            //Calculate cl = new Calculate(long.Parse(textBox4.Text), long.Parse(textBox1.Text), long.Parse(textBox3.Text),long.Parse(textBox2.Text));
           
            //MessageBox.Show("fragmentation : " + cl.frag().ToString() + "\n" + "No. of Records/Track : " + cl.RecordsPerTrack().ToString());
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

       
    }
}
