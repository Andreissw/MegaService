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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();           
        }

        MG_Client cl;
        int idCulprit;
        private void button1_Click(object sender, EventArgs e)
        {
            #region Проверки на поля
            if (string.IsNullOrWhiteSpace(OTK_Desc.Text))
            {
                MessageBox.Show("Поле для описания тестирования пустое!","Не заполнены поля",MessageBoxButtons.OK,MessageBoxIcon.Error); OTK_Desc.Select(); return;
            }         

            if (string.IsNullOrWhiteSpace(CBCulprit.Text))
            {
                MessageBox.Show("Поле виновник пустое", "Не заполнены поля", MessageBoxButtons.OK, MessageBoxIcon.Error); CBCulprit.Select(); return;
            }
            #endregion

            var confirm = new ConfirmUser();
            var Result = confirm.ShowDialog();

            if (Result != DialogResult.OK)
                return;

            using (var qa = new QAEntities())
            {
                var OTK = new MG_OTK()
                {
                    MG_Client_id = cl.ID,
                    Description = OTK_Desc.Text,
                    UserID = confirm.UserID,
                    Date = DateTime.UtcNow.AddHours(2),                    
                    Culprit = idCulprit
                };

                qa.MG_OTK.Add(OTK);
                qa.SaveChanges();
                
            }
            LBSuccess.Visible = true;
            OTK_Desc.Clear();            
            CBCulprit.Text = "";
            GBinfo.Visible = false;
            TBSN.Select();
            cl = null;

        }

        private void TBSN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;
            Link: 
            if (string.IsNullOrWhiteSpace(TBSN.Text))
            {
                MesError("Поле пустое!"); return;
            }

            using (var qa = new QAEntities())
            {
              
                var MgRow = qa.MG_Client.Where(c=>c.SN == TBSN.Text).FirstOrDefault();

                
                if (MgRow == null)
                {
                    //MesError($"{TBSN.Text}  - SN Номер не найден в таблице MG_Client");  return;
                    var result = MessageBox.Show($"{TBSN.Text}  - SN Номер не найден в таблице MG_Client","",MessageBoxButtons.YesNo);
                    if (result != DialogResult.Yes)                   
                        return;

                    var add = new AddNewSN(TBSN.Text);
                    var r = add.ShowDialog();

                    if (r != DialogResult.OK)
                    {
                        return;
                    }
                    
                    MessageBox.Show("Успешно добавлен");
                    goto Link;

                }

                cl = MgRow;
               

                var MgOTK = qa.MG_OTK.Where(c => qa.MG_Client.FirstOrDefault(b => b.SN == TBSN.Text).ID == c.MG_Client_id).FirstOrDefault();

                if (MgOTK == null)
                    GBinfo.Size = new Size(891, 279);
                else
                {
                    
                    GBinfo.Size = new Size(891, 662);
                    var otkData = qa.MG_OTK.Where(c => c.MG_Client_id == cl.ID);
                    InfoOTKTB.Clear();
                    foreach (var item in otkData)
                    {
                        string name;
                        using (var fas = new FASEntities())
                        {
                            name = fas.FAS_Users.FirstOrDefault(c=>c.UserID == item.UserID).UserName;
                        }

                        string desc;
                        var cul = qa.Scrap_Culprit.FirstOrDefault(c => c.id == item.Culprit);
                        if (cul == null)                       
                            desc = "";                        
                        else                       
                            desc = cul.Description;
                        



                        InfoOTKTB.Text += "Описание тестирования - " + item.Description + Environment.NewLine +  Environment.NewLine + "Виновник - " + desc + Environment.NewLine + $"Добавил Пользователь - {name}" +  Environment.NewLine +  new string('-',70) + Environment.NewLine;

                    }
                }                
            }

            GridInfoSet();
            
            LBSuccess.Visible = false;
            OTK_Desc.Clear();            
            CBCulprit.Text = "";
            LBError.Visible = false;
            GBinfo.Visible = true;
            TBSN.Clear();
            GBSetInfo.Visible = true;
            OTK_Desc.Select();
        }

        void GridInfoSet()
        {            
            GridInfo.RowCount = 4;
            GridInfo[0, 0].Value = "Имя Продукта"; GridInfo[1, 0].Value = cl.NameProduct;
            GridInfo[0,1].Value = "Имя Клиента"; GridInfo[1, 1].Value = cl.NameClient;
            GridInfo[0, 2].Value = "SN"; GridInfo[1, 2].Value = cl.SN;
            GridInfo[0, 3].Value = "Дата"; GridInfo[1, 3].Value = cl.Date;
            ProblemLB.Text = cl.DefectName;
        }

        void MesError(string error)
        {
            LBError.Text = error;
            LBError.Visible = true;
            TBSN.Clear();
            TBSN.Select();
        }

        private void CBCulprit_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CBCulprit.Text))
                return;

            using (var qa = new QAEntities())
            {
                idCulprit = qa.Scrap_Culprit.FirstOrDefault(c => c.Description == CBCulprit.Text).id;
            }
        }       
    }
}
