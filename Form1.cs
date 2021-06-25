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
            //Database initialize.
            public static bool sqlInitialize(string filepath)
            {                
                SQLiteConnection dbConnection;
                if(!File.Exists(filepath))
                {
                    //Show a warning dialog box.

                    return false;
                }
                SQLiteConnection.CreateFile("tmp.sqlite");

                dbConnection = new SQLiteConnection("Data Source = tmp.sqlite; Version = 3; UTF8Encoding = true;");
                dbConnection.Open();

                //Create table.
                string sql = "create table texts (id int, txtOrigin varchar(255), txtTrans varchar(255), txtProof varchar(255)";
                SQLiteCommand command = new SQLiteCommand(sql, dbConnection);
                command.ExecuteNonQuery();

                //Read file to database.


                return true;
            }

            //Save changes to database.
            public static void save()
            {

            }
        }

        //Load button. Click and open file dialog box.
        private void btn_load_Click(object sender, EventArgs e)
        {
            //Select txt file in the dialog box.
            OpenFileDialog dialog = new OpenFileDialog();
            string path = "";
            dialog.Multiselect = false;
            dialog.Title = "Select text file";
            dialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK || dialog.ShowDialog() == DialogResult.Yes)
            {
               path = dialog.FileName;
            }
            //Show the path in label2.
            lbl_directory.Text = path;
            //Import txt file to SQL.
            sql.sqlInitialize(path);

            //Load SQL. Display the text in textbox. Show text No. in label1.
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

        //Output button. Click and output SQL to txt.
        private void btn_output_Click(object sender, EventArgs e)
        {

        }

        private void lbl_directory_Click(object sender, EventArgs e)
        {

        }
    }
}
