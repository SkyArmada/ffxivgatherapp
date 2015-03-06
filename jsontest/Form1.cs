using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
namespace jsontest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filepath = "json\\item_nodes.json";

            LoadJson();
        }

        public void LoadJson()
        {
            using (StreamReader r = new StreamReader(@"C:\Users\rellzy\Documents\Visual Studio 2013\Projects\jsontest\jsontest\json\item_nodes.json"))
            {
                string json = r.ReadToEnd();
                List<item_node> items = JsonConvert.DeserializeObject<List<item_node>>(json);
            }
        }
    }
}
