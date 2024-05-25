using System;
using System.Windows.Forms;

namespace DBF_Visual_Redactor
{
    public partial class CreateFolder : Form
    {
        public string id;
        public string name;

        public CreateFolder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            id = textBox1.Text;
            name = textBox2.Text;
            Close();
        }
    }
}