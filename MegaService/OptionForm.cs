using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaService
{
    public partial class OptionForm : Form
    {
        public OptionForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new Form1();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //var confirmUser = new ConfirmUser();
            //var Result = confirmUser.ShowDialog();

            //if (Result != DialogResult.OK)
            //{
            //    return;
            //}

            var form = new AddDataMG();
            form.ShowDialog();
        }
    }
}
