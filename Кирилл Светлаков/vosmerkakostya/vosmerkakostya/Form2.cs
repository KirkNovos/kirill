using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vosmerkakostya
{
    public partial class Form2 : Form
    {
        UserControl1 uc1 = new UserControl1();
        UserControl2 uc2 = new UserControl2();
        public Form2()
        {
            InitializeComponent();

            elementHost1.Child = uc1;
            elementHost2.Child = uc2;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
