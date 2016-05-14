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

        private void button1_Click_1(object sender, EventArgs e)
        {
            Hard hd = new Hard();
            Track tk = new Track();
            Records rc;
            Sector sec ;
            Calculate cl = new Calculate(long.Parse(textBox4.Text), long.Parse(textBox1.Text), long.Parse(textBox3.Text), long.Parse(textBox2.Text));
            int count = 0;
           
            //bool flag = false;
            long div = long.Parse(textBox2.Text)/long.Parse(textBox1.Text);
            
            for (int k = 0; k <div ; k++)
            {
                sec = new Sector();
                for (int j = 0; j < cl.needed_Records(); j++)
                {

                    if (k > 0)
                    {
                        count = count + int.Parse(cl.needed_Records().ToString());

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
                   
                    //int counter = dataGridView1.Rows.Count;
                    //counter--;

                //    if (counter == 0) {
                //        flag = true;
                //        break;
                //    }
                }
            //    if (flag) break;
               
                tk.push(sec);
            }
            hd.push(tk);

           

            XmlSerializer xs = new XmlSerializer(hd.GetType());
            FileStream fs = new FileStream(textBox5.Text + ".xml", FileMode.OpenOrCreate);
            xs.Serialize(fs, hd);
            fs.Close();
            //dataGridView1.Rows.Clear();

            MessageBox.Show("fragmentation : " + cl.frag().ToString() + "\n" + "No. of Records/Track : " + cl.RecordsPerTrack().ToString());
            MessageBox.Show(cl.needed_Records().ToString());
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
