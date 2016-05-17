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

        public Form1()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void clear_chart()
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            clear_chart();    
            Hard hd = new Hard();
            Track tk = new Track();
            Records rc;
            Sector sec;
            Calculate cl = new Calculate(long.Parse(textBox4.Text), long.Parse(textBox1.Text), long.Parse(textBox3.Text), long.Parse(textBox2.Text));
            int count = 0;
            int counter = dataGridView1.Rows.Count - 1;
            bool flag = false;
            long div = long.Parse(textBox2.Text) / long.Parse(textBox1.Text);

            try
            {

                for (int k = 0; k < div; k++)
                {
                    sec = new Sector();



                    for (int j = 0; j < cl.needed_Records(); j++)
                    {

                        if (k == 1)
                        {
                            count = Convert.ToInt32(cl.needed_Records());
                        }

                        Data st = new Data();
                        st.ID = dataGridView1.Rows[j + count].Cells[0].Value.ToString();
                        st.Name = dataGridView1.Rows[j + count].Cells[1].Value.ToString();
                        st.Address = dataGridView1.Rows[j + count].Cells[2].Value.ToString();
                        stlist.Add(st);
                        rc = new Records();
                        rc.push(stlist[stlist.Count - 1]);
                        stlist.RemoveAt(stlist.Count - 1);
                        sec.push(rc);

                        counter--;

                        if (counter == 0)
                        {
                            flag = true;
                            break;
                        }
                    }

                    count = count + Convert.ToInt32(cl.needed_Records());
                    tk.push(sec);
                    if (flag) break;
                }
                hd.push(tk);
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
            }
            XmlSerializer xs = new XmlSerializer(hd.GetType());
            FileStream fs = new FileStream(textBox5.Text + ".xml", FileMode.OpenOrCreate);
            xs.Serialize(fs, hd);
            fs.Close();
            dataGridView1.Rows.Clear();

            MessageBox.Show("fragmentation : " + cl.frag().ToString() + "\n" + "No. of Records/Track : " + cl.RecordsPerTrack().ToString());
            this.chart1.Series["frag."].Points.AddXY("rest of track", long.Parse(textBox2.Text) - cl.frag());
            this.chart1.Series["frag."].Points.AddXY("fragmentation", cl.frag());
           
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
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


    }
}
