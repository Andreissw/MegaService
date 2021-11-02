using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace MegaService
{
    public partial class AddDataMG : Form
    {
        public AddDataMG()
        {
            InitializeComponent();
        }
        //string path = @"C:\Users\a.volodin\Desktop\1\Шаблон МегаСервис.xlsx";
        private void BTOpen_Click(object sender, EventArgs e)
        {
            if (async)
            {
                return;
            }

            using (var file = new OpenFileDialog())
            {
                var Result = file.ShowDialog();

                if (Result == DialogResult.Cancel)
                {
                    return;
                }

                Grid.Rows.Clear();
                Excel.Application x1 = new Excel.Application() { DisplayAlerts = false }; //Инициализации приложения Excel
                Excel.Workbook wb = x1.Workbooks.Open(file.FileName); //Создание новой книги через открытие CSV файла, где лежать данные с базы 
                Excel.Worksheet worksheet = wb.Worksheets.get_Item(1);

                if (worksheet.Range["A1"].Value != "Серийный номер")
                {
                    MessageBox.Show("Не пройдена проверка файла"); return;
                }

                if (worksheet.Range["B1"].Value != "Неисправность")
                {
                    MessageBox.Show("Не пройдена проверка файла"); return;
                }

                if (worksheet.Range["C1"].Value != "Номер накладной")
                {
                    MessageBox.Show("Не пройдена проверка файла"); return;
                }

                if (worksheet.Range["D1"].Value != "Дата поступления")
                {
                    MessageBox.Show("Не пройдена проверка файла"); return;
                }

                if (worksheet.Range["E1"].Value != "Наименование товара")
                {
                    MessageBox.Show("Не пройдена проверка файла"); return;
                }

                if (worksheet.Range["F1"].Value != "Имя Заказчика")
                {
                    MessageBox.Show("Не пройдена проверка файла"); return;
                }

                if (worksheet.Range["G1"].Value != "Номенклатурный номер")
                {
                    MessageBox.Show("Не пройдена проверка файла"); return;
                }

                for (int i = 2; i < worksheet.Rows.Count; i++)
                {
                    if (worksheet.Range[$"A{i}"].Value == null)
                        break;

                    Grid.Rows.Add();
                    Grid[0, i - 2].Value = worksheet.Range[$"A{i}"].Value;
                    Grid[1, i - 2].Value = worksheet.Range[$"B{i}"].Value;
                    Grid[2, i - 2].Value = worksheet.Range[$"C{i}"].Value;
                    Grid[3, i - 2].Value = worksheet.Range[$"D{i}"].Value;
                    Grid[4, i - 2].Value = worksheet.Range[$"E{i}"].Value;
                    Grid[5, i - 2].Value = worksheet.Range[$"F{i}"].Value;
                    Grid[6, i - 2].Value = worksheet.Range[$"G{i}"].Value;
                }

                wb.Close();
                x1.Quit();
                MessageBox.Show($"Готово! Загружено {Grid.RowCount} записей");
            }
            GC.Collect();

        }

        List<string> CheckMGClientTable()
        {
            List<string> list = new List<string>();
            using (var mg = new QAEntities())
            {

                for (int i = 0; i < Grid.RowCount; i++)
                {
                    if (mg.MG_Client.Select(c => c.SN).Contains(Grid[0, i].Value.ToString()))
                    {
                        list.Add(Grid[0, i].Value.ToString());
                    }
                }



                return list;
            }
        }

        void addMgClient(List<string> list)
        {
            using (var qa = new QAEntities())
            {

                for (int i = 0; i < Grid.RowCount; i++)
                {
                    if (list.Contains(Grid[0,i].Value.ToString()))
                    {
                        continue;
                    }

                    string stocknumber;
                    string nameClient;
                    string nameProduct;
                    DateTime dateComing;
                    string numDoc;
                    string defectName;                   

                    if (Grid[6, i].Value == null)
                        stocknumber = null;
                    else
                        stocknumber = Grid[6, i].Value.ToString();

                    if (Grid[5, i].Value == null)
                        nameClient = null;
                    else
                        nameClient = Grid[5, i].Value.ToString();

                    if (Grid[4, i].Value == null)
                        nameProduct = null;
                    else
                        nameProduct = Grid[4, i].Value.ToString();

                    if (Grid[3, i].Value == null)
                    { dateComing = DateTime.Parse("2000-01-01 00:00:00.000"); }
                    else
                        dateComing = DateTime.Parse(Grid[3, i].Value.ToString());

                    if (Grid[2, i].Value == null)
                    { numDoc = null; }
                    else
                        numDoc = Grid[2, i].Value.ToString();

                    if (Grid[1, i].Value == null)
                    { defectName = null; }
                    else
                        defectName = Grid[1, i].Value.ToString();



                    var mg = new MG_Client()
                    {
                        StockNumber = stocknumber,
                        NameClient = nameClient,
                        NameProduct = nameProduct,
                        DateComing = dateComing,
                        NumDoc = numDoc,
                        DefectName = defectName,
                        SN = Grid[0, i].Value.ToString(),
                        Date = DateTime.UtcNow.AddHours(2),

                    };

                    //qa.MG_Client.Add(mg);
                }

                //qa.SaveChanges();
            }
        }

        bool CheckData(int row)
        {
            return true;
        }

        private void BTAdd_Click(object sender, EventArgs e)
        {
            string list = "";
            if (async)
            {
                return;
            }

            if (Grid.RowCount == 0)
            {
                MessageBox.Show("Отсутствуют данные"); return;
            }

            var ResultList = CheckMGClientTable();
            if (ResultList.Count != 0)
            {          
                foreach (var item in ResultList)
                {
                    if (ResultList.IndexOf(item) == ResultList.Count - 1)
                    {
                        list += "'" + item + "'" + Environment.NewLine;
                    }
                    else
                    {
                        list += "'" + item + "'," + Environment.NewLine;
                    }
                    
                }
                list = list.Substring(0, list.Length - 2);

                var R  = MessageBox.Show("В базе существует такие номера\n" + list + "\nИгнорировать добавление этих номеров?","Предупреждение", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (R != DialogResult.Yes)
                {
                    MessageBox.Show($"Добавление отменено!","",MessageBoxButtons.OK,MessageBoxIcon.Error); return;
                }
               
            }

            for (int i = 0; i < Grid.ColumnCount; i++)
                if (Grid[0, i].Value == null)
                 { MessageBox.Show($"Строка номер {i} не указан серийный номер! \n добавление в базе отменено!"); return; }
                
            

            addMgClient(ResultList);

            if (ResultList.Count != 0)
            {
                var mes = MessageBox.Show("Желаете выгрузить отчёт с номерами, которые уже существуют в базе?","Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (mes == DialogResult.Yes)
                {
                    GetReport($@"where c.SN in ({list})",$@"and o.SN in ({list}) ");
                }
            }
            

            MessageBox.Show("Добавлено успешно!");
            Grid.Rows.Clear();
        }

        void GetMG(string line)
        {
            SQL.Loadgrid(GridMG, $@"USE QA SELECT 
                                  c.ID Идентификатор,
		                          SN, 
                                 (select (select (select laz.Content from SMDCOMPONETS.dbo.LazerBase laz where laz.IDLaser = pac.PCBID) from fas.dbo.Ct_PackingTable pac where pac.SNID = f.ID) from fas.dbo.Ct_FASSN_reg f where f.SN = c.SN) Decode,
		                          c.DefectName 'Неисправность определнная заказчиком',
		                          NameProduct 'Наименование Товара',
		                          NameClient 'Заказчик',
		                          FORMAT(c.Date,'dd.MM.yyyy HH:mm:ss') 'Дата внесение информации клиента',
                                  c.NumDoc 'Номер накладной',
								  c.DateComing 'Дата поступления',
		                          (select UserName from fas.dbo.FAS_Users where ot.UserID = UserID) 'Проверил работник_ОТК',
		                          [Description] 'Неисправность определнная ЦТС(ОТК)',
		                          FORMAT(ot.Date,'dd.MM.yyyy HH:mm:ss') 'Дата тестирование платы(ОТК)',
		                          (select top(1) RapairDate from fas.dbo.M_Repair_Table r where c.SN = r.Barcode) n
		                          FROM [QA].[dbo].[MG_OTK] ot
		                          right join MG_Client c on ot.MG_Client_id = c.ID {line}
		                          order by n desc");
        }

        void GetRepair(string line)
        {
            SQL.Loadgrid(GridR, $@"  use QA select Barcode,
   (select concat(code.RepairCodeName,' ', code.RepairCodeDescription) from [PSIGMA.FLAT].dbo.TRC_RepairCode code where r.RepairCode = RepairCodeName) 'Код Ремонта'      
  ,(select concat(def.DefectCodeName,' ', def.DefectCodeDescription) from [PSIGMA.FLAT].dbo.TRC_DefectCode def where r.DefectCode = def.DefectCodeName) 'Код Дефекта'
  ,Position Позиция
  ,FORMAT(RapairDate,'dd.MM.yyyy HH:mm:ss') ДатаРемонта
  ,Repairer Ремонтник
  ,Description ПояснениеРемонтника
  ,ROW_NUMBER() over (partition by CONCAT(FORMAT(RapairDate,'dd.MM.yyyy HH:mm:ss'),barcode) order by barcode, RapairDate ) n
   from fas.dbo.M_Repair_Table r
   where Barcode in (select (select (select laz.Content from SMDCOMPONETS.dbo.LazerBase laz where laz.IDLaser = pac.PCBID) from fas.dbo.Ct_PackingTable pac where pac.SNID = f.ID) from FAS.dbo.Ct_FASSN_reg f where sn in  (select distinct c.SN from MG_Client c )) {line}

   union all

    select Barcode,
   (select concat(code.RepairCodeName,' ', code.RepairCodeDescription) from [PSIGMA.FLAT].dbo.TRC_RepairCode code where r.RepairCode = RepairCodeName) 'Код Ремонта'      
  ,(select concat(def.DefectCodeName,' ', def.DefectCodeDescription) from [PSIGMA.FLAT].dbo.TRC_DefectCode def where r.DefectCode = def.DefectCodeName) 'Код Дефекта'
  ,Position Позиция
  ,FORMAT(RapairDate,'dd.MM.yyyy HH:mm:ss') ДатаРемонта
  ,Repairer Ремонтник
  ,Description ПояснениеРемонтника
  ,ROW_NUMBER() over (partition by CONCAT(FORMAT(RapairDate,'dd.MM.yyyy HH:mm:ss'),barcode) order by barcode, RapairDate ) n
   from fas.dbo.M_Repair_Table r
   where Barcode in (select SN from MG_Client) {line}");
        }

        void ExcelMethod()
        {

            Excel.Application x1 = new Excel.Application() { DisplayAlerts = false }; //Инициализации приложения Excel   
            x1.Workbooks.Add();
            Excel.Worksheet sheet = x1.Worksheets.get_Item(1);

        

            List<int> distinctList = new List<int>();

            foreach (DataGridViewRow item in GridMG.Rows)           
                distinctList.Add(int.Parse(item.Cells[0].Value.ToString()));

            var listsn =  distinctList.Distinct().ToList();

            Invoke((Action)(() =>
            {
                progressBar1.Value = 0;
                progressBar1.Maximum = listsn.Count;
            }));

            var ROWMg = GridMG.Rows.Cast<DataGridViewRow>().ToList();
            var ROWRem = GridR.Rows.Cast<DataGridViewRow>().ToList();
            var time = DateTime.Now;
            int r = 2;

            for (int i = 0; i < listsn.Count; i++) //1 уровень цикла, заполняет ключ
            {
                if (!async)
                {
                    Invoke((Action)(() =>
                    {
                        var procent = ((Int32)Convert.ToInt32(progressBar1.Value) / ((progressBar1.Maximum - 2) / 100M)).ToString("#.#");
                        var t = DateTime.Now - time;
                        label2.Text = $"Загрузка остановлена - {procent}% \n Время - {t.Minutes + ":" + t.Seconds}";
                        label2.ForeColor = Color.Red;
                        progressBar1.Value = 0;
                        sheet = null;
                        x1.Quit();
                        GC.Collect();
                        
                    }));

                    return;
                }

                Invoke((Action)(() =>
                {
                    progressBar1.Value += 1;
                    var procent = ((Int32)Convert.ToInt32(progressBar1.Value) / ((progressBar1.Maximum - 2) / 100M)).ToString("#.#");
                    var t = DateTime.Now - time;                   
                    label2.Text = $"Загрузка - {procent}% \n Время - {t.Minutes + ":" + t.Seconds} ";
                    label2.ForeColor = Color.Black;
                }));

                sheet.Cells[r, 1].Value2 = listsn[i]; //Добавили ключ

                var rr = r; //Запоминаем где был ключ
               
                //Получаем строки с грида ОТК по ключу
                var ResultRow = ROWMg.Select(c => c.DataBoundItem as DataRowView).Where(c => c.Row.ItemArray.Contains(listsn[i])).ToList();                

                foreach (var item in ResultRow)//Заполняем полученные данные в Excel
                {
                    sheet.Cells[r, 1].Value2 = listsn[i];
                    //Заполняем инфу от слов клиента 
                    Parallel.For(2, 10, new ParallelOptions() { MaxDegreeOfParallelism = Environment.ProcessorCount} , x => {
                        if (rr == r) //Если первый раз, добавляем инфо один раз                          
                            sheet.Cells[r, x].Value2 = item.Row[x - 1];
                    });

                    //Заполняем инфу от ОТК
                    Parallel.For(10, 13, new ParallelOptions() { MaxDegreeOfParallelism = Environment.ProcessorCount }, x => { 
                            sheet.Cells[r, x].Value2 = item.Row[x - 1];
                    });

                    r += 1;
                }

                var rrr = r; //Запоминаем на какой строке мы закончили добавлять данные с МегаСервиса
                r = rr; // Возвращаем к строке, где стоял ключ 


                string Decode = "";

                //Находим Баркод у ключа 
                try
                {
                    Decode = sheet.Cells[rr, 3].Value2.ToString();
                }
                catch (Exception)
                {

                    Decode = sheet.Cells[rr, 2].Value2.ToString();
                }
                 
                //if (string.IsNullOrWhiteSpace(Decode))
                //{
                   
                //}
                

                //ПО бракоду находим строки в ремонте
                var ResultRowRem = ROWRem.Select(c => c.DataBoundItem as DataRowView).Where(c => c.Row.ItemArray.Contains(Decode)).ToList();

                foreach (var item in ResultRowRem)
                {
                    Parallel.For(13, 19, new ParallelOptions() { MaxDegreeOfParallelism = Environment.ProcessorCount }, x =>
                    {
                        sheet.Cells[r, x].Value2 = item.Row[x - 12];
                    });
                }

                if (r < rrr) //Получаем данные, на какой строке мы остановились, чтобы продолжить на следующей
                    r = rrr;
            }

            sheet.Range["A:R"].Interior.ThemeColor = Excel.XlThemeColor.xlThemeColorDark1;
            //ExcelSetting(-16776961, Excel.XlBordersIndex.xlEdgeTop, sheet.Range[$"A{r}:Q{r}"]); //Форматирование книги


            var Format = sheet.Range["A:R"];
            //Excel.FormatCondition rFor = Format.FormatConditions.Add(
            //    Type: Excel.XlFormatConditionType.xlExpression, Formula1: @"=$A1 <> $A2"
            //    );

            //rFor.Borders.Item[(Excel.XlBordersIndex)Excel.Constants.xlBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
            //rFor.StopIfTrue = true;

            Invoke((Action)(() =>
            {
                progressBar1.Value = 0;
                var t = DateTime.Now - time;
                label2.Text = $"Загрузка Завершена! \nВремя загрузки {t.Minutes + ":" + t.Seconds}";
                label2.ForeColor = Color.Green;
            }));

            ExcelFormating(sheet);

            List<string> columns = new List<string>(); //Создаем массив

            foreach (DataGridViewColumn item in GridMG.Columns)  //Добавляем в массив заголовки первой таблицы ОТК        
                columns.Add(item.HeaderText);

            foreach (DataGridViewColumn item in GridR.Columns)//Добавляем в массив заголовки второй таблицы ремонта
                columns.Add(item.HeaderText);

            columns.Remove("n"); columns.Remove("n"); //Удаляем ненужные столбцы
            columns.Remove("Barcode");

            #region Столбцы которые записали
            /*1 Идентификатор 
              2 SN  
              3 Неисправность определнная заказчиком 
              4 Наименование Товара 
              5 Заказчик    
              6 Дата внесение информации клиента  
              7 Номер накладной
              8 Дата поступления
              9 Проверил работник_ОТК   
              10 Неисправность определнная ЦТС(ОТК) 
              11 Дата тестирование платы(ОТК)    
              12 Код Ремонта 
              13 Код Дефекта 
              14 Позиция 
              15 ДатаРемонта 
              16 Ремонтник 
              17 ПояснениеРемонтника
            */
            #endregion

            for (int i = 1; i < columns.Count + 1; i++) { //Пишем в Excel столбцы   
                sheet.Cells[1, i].Value2 = columns[i - 1];
            }


            x1.Visible = true;        
        }

        void ExcelSetting(int color,Excel.XlBordersIndex border,  dynamic sh)
        {                  

            sh.Borders[border].LineStyle = Excel.XlLineStyle.xlContinuous;            
            sh.Borders.Color = color;
            sh.Borders.TintAndShade = 0;
            sh.Borders.Weight = Excel.XlBorderWeight.xlThin;
            
            sh.Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlLineStyleNone;
            sh.Borders[Excel.XlBordersIndex.xlInsideVertical].LineStyle = Excel.XlLineStyle.xlLineStyleNone;
            sh.Borders[Excel.XlBordersIndex.xlInsideHorizontal].LineStyle = Excel.XlLineStyle.xlLineStyleNone;
            sh.Borders[Excel.XlBordersIndex.xlDiagonalDown].LineStyle = Excel.XlLineStyle.xlLineStyleNone;
            sh.Borders[Excel.XlBordersIndex.xlDiagonalUp].LineStyle = Excel.XlLineStyle.xlLineStyleNone;
            sh.Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlLineStyleNone;
            sh.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlLineStyleNone;
        }

        void ExcelFormating(Excel.Worksheet ex)
        {
            ex.Range["A:R"].Columns.WrapText = false;
            ex.Range["A:C"].ColumnWidth = 15.50;
            ex.Range["D:D"].ColumnWidth = 38;
            ex.Range["E:E"].ColumnWidth = 57;
            ex.Range["F:F"].ColumnWidth = 10;
            ex.Range["G:G"].ColumnWidth = 19;
            ex.Range["H:H"].ColumnWidth = 45;
            ex.Range["I:I"].ColumnWidth = 25;
            ex.Range["J:J"].ColumnWidth = 21;
            ex.Range["K:K"].ColumnWidth = 61;
            ex.Range["L:L"].ColumnWidth = 20;
            ex.Range["M:M"].ColumnWidth = 41;
            ex.Range["N:N"].ColumnWidth = 35;
            ex.Range["O:O"].ColumnWidth = 11;
            ex.Range["P:P"].ColumnWidth = 20;
            ex.Range["Q:Q"].ColumnWidth = 16;
            ex.Range["R:R"].ColumnWidth = 54;
            ex.Range["A1:R1"].Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            ex.Rows["1:1"].RowHeight = 50;
            var r = ex.Range["A1:R1"];
            r.WrapText = true;
            r.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            r.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
        }

        bool async = false;
        async void ExcelMeth()
        {
            async = true;
            
            label2.Text = "";

            await Task.Run(() =>
            {
                ExcelMethod();
            });

            async = false;
            GC.Collect();
        }
         private void button1_Click(object sender, EventArgs e)
        {
            if (async)
            {
                return;
            }
            groupBox2.Visible = true;
            GetReport();

        }

        void GetReport(string lineMG = "", string lineRep = "")
        {
            GetMG(lineMG);
            GetRepair(lineRep);
            ExcelMeth();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!async)
            {
                return;
            }

            async = false;
        }

        private void AddDataMG_FormClosed(object sender, FormClosedEventArgs e)
        {
            GC.Collect();
        }

        private void AddDataMG_Load(object sender, EventArgs e)
        {
            if (ApplicationDeployment.IsNetworkDeployed)
            {
                label3.Text = "Verison Product - " + ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString();
                label3.Visible = true;
            }
        }
    }
}
























































            


