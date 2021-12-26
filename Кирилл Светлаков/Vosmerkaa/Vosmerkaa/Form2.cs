using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vosmerkaa
{
    public partial class Form2 : Form
    {
        UserControl2 wpfControl2 = new UserControl2();
        UserControl1 wpfControl1 = new UserControl1();
        public Form2()
        {
            InitializeComponent();
            elementHost1.Child = wpfControl2;
            elementHost2.Child = wpfControl1;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
 
        private void elementHost1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
