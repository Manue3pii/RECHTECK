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

namespace Dateiverarbeitung
{
    public partial class Form1 : Form
    {      
        //dateien: Vokabeln, Vokabeln2, wordsENG und wordsGER
        
        public Form1()
        {
            InitializeComponent();
        }

        private void SpeichernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog s = new SaveFileDialog
            {
                FileName = string.Empty,
                InitialDirectory = @"C:\Users\TEMP\Desktop",
                Filter = "TXT-Datei| *.txt"
            };
            s.FileName = string.Empty;

            if (s.ShowDialog() == DialogResult.OK)
	        {
                FileStream fs = new FileStream(s.FileName, FileMode.Create, FileAccess.Write);
                StreamWriter wr = new StreamWriter(fs);
                wr.WriteLine(TxtBox.Text);
                wr.Close();
        	}     
        }

        private void LadenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog
            {
                Filter = "TXT-Datei|*.txt",
                InitialDirectory = @"C:\Users\TEMP\Desktop",
                FileName = string.Empty
            };
            if (o.ShowDialog() == DialogResult.OK)TxtBox.Text = new StreamReader(o.FileName).ReadToEnd();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BeendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NachBuchstabenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TxtBox.Text = String.Concat(TxtBox.Text.Replace(((char)32).ToString(), string.Empty).GroupBy(x => x)); //funktioniert nicht
        }
    }
}
