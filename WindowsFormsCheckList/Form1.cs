using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCheckList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string task = taskTextBox.Text.Trim();
            if (!string.IsNullOrEmpty(task))
            {
                checkListBox.Items.Add(task);
                taskTextBox.Clear();
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            List<int> indicesToRemove = new List<int>();

            foreach (int index in checkListBox.CheckedIndices)
            {
                indicesToRemove.Add(index);
            }

            indicesToRemove.Sort(); // Сортируем индексы в убывающем порядке, чтобы правильно удалять элементы.
            indicesToRemove.Reverse();

            foreach (int index in indicesToRemove)
            {
                checkListBox.Items.RemoveAt(index);
            }
        }


        private void markAsDoneButton_Click(object sender, EventArgs e)
        {
            List<string> selectedItems = new List<string>();

            foreach (var item in checkListBox.SelectedItems)
            {
                selectedItems.Add(item.ToString());
            }

            foreach (string item in selectedItems)
            {
                int index = checkListBox.Items.IndexOf(item);
                if (index >= 0)
                {
                    checkListBox.Items[index] = "OK  " + item;
                }
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            checkListBox.Items.Clear();
        }
    }
}