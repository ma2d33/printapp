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

namespace PrintApp
{
    public partial class AdminChangeForm : Form
    {
        public AdminChangeForm()
        {
            InitializeComponent();
        }

        private void confirmAdminButton_Click(object sender, EventArgs e)
        {
            (Application.OpenForms[0] as Form1).setShiftLabel(comboBox1.Text);
            this.Dispose();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
