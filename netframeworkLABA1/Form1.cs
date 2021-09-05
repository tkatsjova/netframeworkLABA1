using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLibrary1;

namespace netframeworkLABA1
{
    public partial class Form1 : Form
    {
        Employee emp1 = new Employee();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            emp1 = new Employee();
            emp1.EmpId = (int) numericUpDown1.Value;
            emp1.Name = textBox1.Text;
            richTextBox1.Text += String.Format("Сотрудник {0} {2} с таб_номером {1} \n", Employee.Enterprise, emp1.EmpId, emp1.Name);
            textBox1.Text = " ";
            numericUpDown1.Value = 0;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = " ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string hashCode = emp1.GetHashCode().ToString();
            richTextBox1.Text += "Хэш-код, который используется для идентификации данного объекта = " + hashCode + "\n";
        }
    }
}
