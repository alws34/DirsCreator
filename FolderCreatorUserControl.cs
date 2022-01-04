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

namespace DirsCreator
{
    public partial class FolderCreatorUserControl : UserControl
    {
        //private int year;
        private string type;
        private string folder_path;
        private bool isCalendaric;
        private bool isFree = false;


        public FolderCreatorUserControl()//calendaric folders
        {
            InitializeComponent();
            //this.year = year;
            this.isCalendaric = true;
            this.btnCreateFolders.Enabled = false;
            this.textBoxType.Enabled = false;
            this.textBoxHowMany.Visible = false;
            this.lblHowMany.Visible=false;
            //this.textBoxType.KeyPress += new KeyPressEventHandler(textBox_GetNumbersOnly_KeyPress);
        }

        public FolderCreatorUserControl(string type)//for non-calendar folders
        {
            InitializeComponent();

            if (type == "free")
            {
                this.type = "";

                this.textBoxType.Text = "Please enter Type";
                this.textBoxType.Enabled = true;
                this.textBoxType.TextChanged += textBox_GetNumbersOnly_TextChanged;
                
                this.lblHowMany.Visible = true;
                this.isFree = true;

                this.textBoxHowMany.Visible = true;
                this.textBoxHowMany.KeyPress += new KeyPressEventHandler(textBox_GetNumbersOnly_KeyPress);
                
            }
            else
            {
                this.type = type;

                this.textBoxHowMany.Visible = false;
                this.lblHowMany.Visible = false;

                this.textBoxType.Text = type;
                this.textBoxType.Enabled = false;
            }

            this.isCalendaric = false;
            this.btnCreateFolders.Enabled = false;

        }

        private void textBox_GetNumbersOnly_TextChanged(object sender, EventArgs e)
        {
            this.type=textBoxType.Text;
        }

        //accept only numbers in textbox if IsCalendaric
        private void textBox_GetNumbersOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        //get folder path
        private void btnOpenFileDialog_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog FD = new OpenFileDialog())
            {
                FD.InitialDirectory = "c:\\";
                FD.RestoreDirectory = true;
                FD.ValidateNames = false;
                FD.CheckFileExists = false;
                FD.CheckPathExists = true;
                FD.FileName = "Folder Selection.";

                if (FD.ShowDialog() == DialogResult.OK)
                {
                    this.folder_path = Path.GetDirectoryName(FD.FileName);
                }
            }
            textBoxFolderPath.Text = this.folder_path;
            this.btnCreateFolders.Enabled = true;
        }

        private void CreateFolders(bool isCalendaric, string type)
        {
            DateTime now = DateTime.Now;
            int year = now.Year % 100;
            int iterator = 13;
            string new_folder;
            if (isCalendaric)
            {
                for (int i = 1; i < iterator; i++)
                {
                    new_folder = this.folder_path + $"\\{i}.{year}";
                    if (!Directory.Exists(new_folder))
                        Directory.CreateDirectory(new_folder);
                }
            }
            else
            {
                if (this.isFree)
                    iterator = Int32.Parse(textBoxHowMany.Text);

                for (int i = 1; i <= iterator; i++)
                {
                    new_folder = this.folder_path + $"\\{type} {i}";
                    if (!Directory.Exists(new_folder))
                        Directory.CreateDirectory(new_folder);
                }
            }
        }


        private void btnCreateFolders_Click(object sender, EventArgs e)
        {
            CreateFolders(this.isCalendaric, this.type);
        }

        private void textBoxFolderPath_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Directory.Exists(textBoxFolderPath.Text))
                {
                    btnCreateFolders.Enabled = true;
                    this.folder_path = textBoxFolderPath.Text;
                }
                else
                {
                    btnCreateFolders.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                return;
            }
        }
    }
}
