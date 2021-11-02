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
    public partial class MGClientInfo : Form
    {
        public MGClientInfo()
        {
            InitializeComponent();
        }

        public string NameProduct { get; set; }

        public string NameClient { get; set; }

        public string NumDocs { get; set; }

        private void BTOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CBProduct.Text))
            {
                MessageBox.Show("Укажите имя продукта"); return;
            }

            if (string.IsNullOrWhiteSpace(CBName.Text))
            {
                MessageBox.Show("Укажите имя заказчика"); return;
            }

            if (string.IsNullOrWhiteSpace(NumDoc.Text))
            {
                MessageBox.Show("Укажите Номер накладной"); return;
            }

            NameProduct = CBProduct.Text;
            NameClient = CBName.Text;
            NumDocs = NumDoc.Text;
            DialogResult = DialogResult.OK;
        }

        private void MGClientInfo_Load(object sender, EventArgs e)
        {
            using (var qa = new QAEntities())
            {
                CBName.DataSource = qa.MG_Client.Select(c => c.NameClient).Distinct().ToList();
                CBProduct.DataSource = qa.MG_Client.Select(c => c.NameProduct).Distinct().ToList();
            }
        }
    }
}
