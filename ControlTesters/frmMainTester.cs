using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlTesters
{
    public partial class frmMainTester : Form
    {
        public frmMainTester()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmTrafficLightTester tester = new frmTrafficLightTester();
            tester.Show();
        }
    }
}
