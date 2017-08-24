using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCalculator
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBoxWords_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ( listBoxWords.Text =="Book")
            {
                labelMeaning.Text = "বই";
//                lblPhone
  //                  lblEmail
    //                image.picture="c:\ijddd\a.jpg
                    //"
            }
            else if (listBoxWords.Text == "Pen")
            {
                labelMeaning.Text = "কলম";
            }
            else if (listBoxWords.Text == "Pencil")
            {
                labelMeaning.Text = "পেন্সিল";
            }
            else
            {
                labelMeaning.Text = "Nothing";
            }
        }

        private void FormAbout_Load(object sender, EventArgs e)
        {
            listBoxWords.Items.Add("Book");
            listBoxWords.Items.Add("Pen");
            listBoxWords.Items.Add("Pencil");
        }

        private void labelMeaning_Click(object sender, EventArgs e)
        {
         
        }
    }
}
