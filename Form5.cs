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
using System.Xml.Serialization;

namespace Baitap
{
    public partial class Form5 : Form
    {
        string path = "D:\form1.xml";
        InfoWindows iw = new InfoWindows();
        public Form5()
        {
            InitializeComponent();
        }
        public void Write(InfoWindows iw)
        {
            XmlSerializer writer = new XmlSerializer(typeof(InfoWindows));
            StreamWriter file = new StreamWriter(path);
            writer.Serialize(file, iw);
            file.Close();
        }
        public InfoWindows Read()
        {
            XmlSerializer reader = new XmlSerializer(typeof(InfoWindows));
            StreamReader file = new StreamReader(path);
            InfoWindows iw = (InfoWindows)reader.Deserialize(file);
            file.Close();
            return iw;
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            iw.Width = this.Size.Width;
            iw.Height = this.Size.Height;
            iw.Location = this.location;
            Write(iw);
        }

        private void Form1_load(object sender, EventArgs e)
        {
            iw = Read();
            this.Width = iw.width;
            this.Height = iw.Height;
            this.Location = iw.Location;
        }


        public Point location { get; set; }
    }
}
