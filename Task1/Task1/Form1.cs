using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class Form1 : Form
    {
        static string[] names = new string[5];
        static int counter = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(counter < 5)
            {
                names[counter] = txtNames.Text;
                counter++;
                txtNames.Text = null; 
                
                if(counter == 5)
                {
                    btnAdd.Visible = false;
                }
            }                                   
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < names.Length; i++)
            {
                listBox1.Items.Add($"Names: {names[i]}");
            }
        }
    }
}
