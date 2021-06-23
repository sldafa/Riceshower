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
using System.Data.SQLite;

namespace Riceshower
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public class sql
        {
            private string text;
            public string load 
            { 
                get 
                {
                    return "1";
                } 
                set 
                {
                    text = value;
                } 
            }
            public Boolean save { get; set; }
        }

        //Load button. Click and open file dialog box.
        private void btn_load_Click(object sender, EventArgs e)
        {
            //Select txt file in the dialog box.
            string path = "";
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            dialog.Title = "Select text file";
            dialog.Filter = "*.txt";
            if (dialog.ShowDialog() == DialogResult.OK || dialog.ShowDialog() == DialogResult.Yes)
            {
                path = dialog.FileName;
            }

            //Connect to the database.

            //Read text file. Then save it in the tmp SQL.

            //Load SQL. Display the text in textbox.
        }

        //Save the translation text to SQL.
        private void btn_translation_submit_Click(object sender, EventArgs e)
        {

        }

        //Save the proofread text to SQL.
        private void btn_proofreading_submit_Click(object sender, EventArgs e)
        {

        }

        //Load the previous line.
        private void btn_previous_Click(object sender, EventArgs e)
        {

        }

        //Load the next line.
        private void btn_next_Click(object sender, EventArgs e)
        {

        }

        //Save button. Click and output SQL to txt.
        private void btn_save_Click(object sender, EventArgs e)
        {

        }

        
    }
}
