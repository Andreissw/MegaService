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
    public partial class AddNewSN : Form
    {
        public AddNewSN(string SN)
        {
            InitializeComponent();
            this.SN = SN;
        }

        string SN;

        private void AddNewSN_Load(object sender, EventArgs e)
        {
            using (var qa = new QAEntities())
            {
                CBName.DataSource = qa.MG_Client.OrderByDescending(c => c.Date).Select(c => c.NameClient).Distinct().ToList();
                CBProduct.DataSource = qa.MG_Client.OrderByDescending(c => c.Date).Select(c => c.NameProduct).Distinct().ToList();
                
            }
        }

        private void BTOk_Click(object sender, EventArgs e)
        {
            var confirm = new ConfirmUser();
            var result = confirm.ShowDialog();

            if (result != DialogResult.OK)
            {
                return;
            }


            using (var qa = new QAEntities())
            {
                var mg = new MG_Client()
                {
                    SN = SN,
                    NameClient = CBName.Text,
                    NameProduct = CBProduct.Text,
                    DefectName = defect.Text,
                    UserID = confirm.UserID,
                    Date = DateTime.UtcNow.AddHours(2)
                };

                qa.MG_Client.Add(mg);
                qa.SaveChanges();
            }
            DialogResult = DialogResult.OK;
        }
    }
}
