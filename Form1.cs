using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DirsCreator
{
    public partial class FormFoldersCreator : Form
    {
        public FormFoldersCreator()
        {
            InitializeComponent();

            TabPage calendaricTabPage = new TabPage("calendaric");
            TabPage practicesTabPage = new TabPage("practices");
            TabPage lecturesTabPage = new TabPage("Lectures");
            TabPage freeTabPage = new TabPage("free");

            FolderCreatorUserControl calendaric = new FolderCreatorUserControl();
            FolderCreatorUserControl practices = new FolderCreatorUserControl("תרגול");
            FolderCreatorUserControl lectures = new FolderCreatorUserControl("הרצאה");
            FolderCreatorUserControl free = new FolderCreatorUserControl("free");

            calendaricTabPage.Controls.Add(calendaric);
            practicesTabPage.Controls.Add(practices);
            lecturesTabPage.Controls.Add(lectures);
            freeTabPage.Controls.Add(free);

            tabControl.Controls.Add(calendaricTabPage);
            tabControl.Controls.Add(practicesTabPage);
            tabControl.Controls.Add(lecturesTabPage);
            tabControl.Controls.Add(freeTabPage);
        }
    }
}
