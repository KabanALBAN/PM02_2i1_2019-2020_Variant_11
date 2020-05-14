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

namespace xml_reader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            load();
        }
        private void load()
        {
            XmlDocument O = new XmlDocument();             
            O.Load(“xmltext.xml”);
            foreach(XmlNode D in O.DocumentElement)
            {
                string A = D.Attributes[0].Value;        
                int G = int.Parse(D[“G”].InnerText);
                bool R = bool.Parse(D[“R”].InnerText);        
                listBox1.Items.Add(new Employee(A, G, R));
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                propertyGrid1.SelectedObject = listBox1.SelectedItem;
            }
        }
    }
}