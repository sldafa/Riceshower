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
                    MessageBox.Show("Path Invalid!");
                    return false;
                }

                //If sqlite file does not exist, create .sqlite file.
                string sqlFileName = Path.GetFileNameWithoutExtension(filepath) + ".sqlite";
                if(!File.Exists(sqlFileName))
                {
                    SQLiteConnection.CreateFile(sqlFileName);

                    dbConnection = new SQLiteConnection("Data Source = "+sqlFileName+"; Version = 3; UTF8Encoding = true;");
                    dbConnection.Open();

                    //Create table.
                    string sqlCreate = "create table texts (id int, txtOrigin varchar(255), txtTrans varchar(255), txtProof varchar(255), is_edit bool, is_trans bool, is_proof bool, PRIMARY KEY(id))";
                    SQLiteCommand command = new SQLiteCommand(sqlCreate, dbConnection);
                    command.ExecuteNonQuery();

                    //**Read file to database. **Needs sample file.
                    string[] textArray = File.ReadAllLines(filepath);
                    for(int i = 1; textArray[i] == null; i++)
                    {
                        string sqlRow;
                        string sqlFill = "";
                    }

                    return true;
                }

                //**If sqlite file already exists, read it and point to last edit row.
                else
                {
                    return true;
                }
            }

            //**Save changes to database.
            public static void save(string text, string field)
            {

            }

            public static void load(string text, string field)
            {
                
            }

            public static void output(string filepath)
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

            if (dialog.ShowDialog() == DialogResult.OK)
            {
               path = dialog.FileName;
            }
            else
            {
                MessageBox.Show("Operation Cancelled.");
            }

            //Show the path in label2.
            lbl_directory.Text = path;

            //**Import txt file to SQL.
            bool sqlStatus = sql.sqlInitialize(path);
            if (sqlStatus)
            {
                //Operation begin.
                //Load SQL. Display the text in textbox. Show text No. in label1.
            }
            else
            {
                MessageBox.Show("Database Initialize failed.");
            }
        }

        //**Save the translation text to SQL.
        private void btn_translation_submit_Click(object sender, EventArgs e)
        {
            sql.save("","");
        }

        //**Save the proofread text to SQL.
        private void btn_proofreading_submit_Click(object sender, EventArgs e)
        {
            sql.save("","");
        }

        //**Load the previous line.
        private void btn_previous_Click(object sender, EventArgs e)
        {
            sql.load("","");
        }

        //**Load the next line.
        private void btn_next_Click(object sender, EventArgs e)
        {
            sql.load("","");
        }

        //**Output button. Click and output SQL to txt.
        private void btn_output_Click(object sender, EventArgs e)
        {
            sql.output("");
        }

        private void lbl_directory_Click(object sender, EventArgs e)
        {

        }
    }
}
