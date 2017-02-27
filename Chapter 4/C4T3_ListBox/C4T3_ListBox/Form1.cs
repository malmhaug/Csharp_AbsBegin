using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C4T3_ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox.Items.Contains(addBox.Text))
            {
                //Item already in the box
                MessageBox.Show("Item is already in the box!");
            }
            else
            {
                //Add item
                listBox.Items.Add(addBox.Text);
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            //Remove item
            listBox.Items.Remove(listBox.SelectedItem);
        }

        private void reorderButton_Click(object sender, EventArgs e)
        {
            //Reorder items
            listBox.Sorted = true;
            listBox.Sorted = false;
        }
    }
}
