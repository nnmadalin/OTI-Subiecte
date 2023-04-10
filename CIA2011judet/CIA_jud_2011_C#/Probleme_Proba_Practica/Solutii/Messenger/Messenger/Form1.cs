using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;





namespace Messenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMaria_Click(object sender, EventArgs e)
        {
            rtbAfisareMesaj.SelectionColor = Color.Red;
            string text = "Maria: " + rtbEditareMesaj.Text;
            rtbEditareMesaj.Text = text+"\n";
            rtbAfisareMesaj.AppendText(rtbEditareMesaj.Text);
            rtbEditareMesaj.Focus();
            rtbEditareMesaj.Text = string.Empty;
        }

        private void btnIonel_Click(object sender, EventArgs e)
        {
            rtbAfisareMesaj.SelectionColor = Color.Blue;
            string text = "Ionel: " + rtbEditareMesaj.Text;
            rtbEditareMesaj.Text = text + "\n";
            rtbAfisareMesaj.AppendText(rtbEditareMesaj.Text);
            rtbEditareMesaj.Focus();
            rtbEditareMesaj.Text = string.Empty;
        }

        private void btnSalvare_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile1 = new SaveFileDialog();

            //Initializari
            saveFile1.DefaultExt = "*.rtf";
            saveFile1.Filter = "RTF Files|*.rtf";
            saveFile1.Title = "Save as...";
           
            if (saveFile1.ShowDialog() == DialogResult.OK &&
               saveFile1.FileName.Length > 0)
            {
                rtbAfisareMesaj.SaveFile(saveFile1.FileName);
            }

        }

        private void btnIncarcare_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile2 = new OpenFileDialog();
            openFile2.DefaultExt = "*.rtf";
            openFile2.Filter = "RTF Files|*.rtf";
            openFile2.Title = "Open";
                
            if (openFile2.ShowDialog() == DialogResult.OK)
            {   
                StreamReader sr = new StreamReader(openFile2.FileName, Encoding.Default);      
                string str = sr.ReadToEnd();         
                sr.Close();
                rtbAfisareMesaj.SelectedRtf = str;
            }
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            rtbAfisareMesaj.Text="";
        }
    }
}
