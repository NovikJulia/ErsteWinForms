using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Erste
{
    public partial class FormWindows : Form
    {
        public FormWindows()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            return;
        }

        private void FormWindows_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.smile;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saved");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            tbmitValid.Text = "1";
            this.Close();
        }

        private void FormWindows_Validating(object sender, CancelEventArgs e)
        {
          
        }

        private void mitValid_Validating(object sender, CancelEventArgs e)
        {
            int n = int.Parse(tbmitValid.Text);
            if (n > 100)
            {
                e.Cancel = true;
            }
            ValidateName();
        }
        private bool ValidateName()
        {
            bool bStatus = true;
            if (tbmitValid.Text == "")
            {
                errorProvider1.SetError(tbmitValid, "Please enter your Name");
                bStatus = false;
            }
            else
                errorProvider1.SetError(tbmitValid, "");
            return bStatus;
        }


        private void mitValid_TextChanged(object sender, EventArgs e)
        {
            int n = int.Parse(tbmitValid.Text);
            if (n > 100)
            {
                
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        class Student
        {
            public string Name { get; set; }
            public int Id { get; set; }
            public override string ToString()
            {
                return Name;
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i< 10; i++)
            {
                Student student = new Student() { Id=i, Name="Student"+i};
                comboBox3.Items.Add(student);
            }
            
            
        }
    }
}
