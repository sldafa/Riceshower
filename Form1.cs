using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Riceshower
{
    public static class common
    {
        private static string path ;
        public static string Path
        {
            get { return path; }
            set { path = value; }
        }
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            dialog.Title = "Select text file";
            dialog.Filter = "*.txt";
            if (dialog.ShowDialog() == DialogResult.OK || dialog.ShowDialog() == DialogResult.Yes)
            {
                string[] accounts = File.ReadAllLines(common.Path);
            }
            

        }

        private void btn_translation_submit_Click(object sender, EventArgs e)
        {

        }

        private void btn_previous_Click(object sender, EventArgs e)
        {

        }
    }
}
