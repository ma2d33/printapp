using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Net.Mail;


namespace PrintApp
{
    public partial class Form1 : Form
    {
        private DateTime lastTime = DateTime.Today.AddDays(-0);
        public int pagesSumm = 0;
        public int pagesPlusCopies = 0;
        public int PagesPlusCopiesColor = 0;
        public int totalSumm = 0;
        public string printerName;
        public int totalBWpages = 0; // count total black and white pages per run
        public int totalColorPages = 0; //-----//--- ony color
        public int totalPagesPrinted = 0;
        public int pagesPriceIndex = 0;
        public int logTotalPagesPrinted = 0;
        public int taskNumber = 0;
        public bool dontPrint = false;
        public bool payedNumbersCleared = false;
        public int ToalPrice = 0;
        public int shiftMoney = 0;
       

        public bool maximWindow = true;
        public SQLiteConnection conn;
        public int dblines = 0;
        public int csvLines = 0;
        public DateTime DBdate;
        public int dataGridPages = 0;
       
        //public int total

        
       
        public bool countedDefected = false;
        public bool countDefectedColor = false;
        public int defectPagesBW = 0;
        public int defectPagesBWCounter = 0;
        public int defectPagesColor = 0;
        public int defectPagesColorCounter = 0;
        public int linesToRemoveFrom_PV = 0;
        private bool i = false;
        private int rowCountDB = 0;


        public Form1()

        {
            initTimer();
            InitializeComponent();
            
        }

        private void loadMyCsv() {
            string line;
            StreamReader csvFile = load_myPayed_csv();
            while((line = csvFile.ReadLine())   != null){
                //logList.Items.Add(line.ToString());
            }

        }

        



        public void diplayYesturday() {

            

         
                displayTime(0);
            
        }

        public void setShiftLabel(string val)
        {
            shiftLable.Text = val;
        }

        private void addListLine(string printTimeString,string printerName,string clientName, int copies, int pages , string fileName) {

            

            if (dontPrint == false )
            {
                
                
                    ListViewItem item1 = new ListViewItem(printTimeString, 0);
                    item1.SubItems.Add(printerName);
                    item1.SubItems.Add((copies * pages).ToString());
                    item1.SubItems.Add(clientName);
                    item1.SubItems.Add(fileName);
                    item1.SubItems.Add(taskNumber.ToString());

                   
                    
                
                
            }
            
        }



        public void loadPrintView_ToDB(string date, string printer, int pages , string pc, string file)

        {
            SQLiteCommand insertSQL = new SQLiteCommand("Insert into printView (Time,Printer,Pages,pc,filename,isPayed) Values (?,?,?,?,?,?)", conn);
            SQLiteParameter timePr = new SQLiteParameter();
            SQLiteParameter printerPr = new SQLiteParameter();
            SQLiteParameter pagesPr = new SQLiteParameter();
            SQLiteParameter pcPr = new SQLiteParameter();
            SQLiteParameter filePr = new SQLiteParameter();
            SQLiteParameter isPayed = new SQLiteParameter();

            timePr.Value = date;
            printerPr.Value = printer;
            pagesPr.Value = pages;
            pcPr.Value = pc;
            filePr.Value = file;
            isPayed.Value = 0;

            insertSQL.Parameters.Add(timePr);
            insertSQL.Parameters.Add(printerPr);
            insertSQL.Parameters.Add(pagesPr);
            insertSQL.Parameters.Add(pcPr);
            insertSQL.Parameters.Add(filePr);
            insertSQL.Parameters.Add(isPayed);

            try
            {
                insertSQL.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }

        private void populatePayedDG()

        {
            SQLiteConnection con = new SQLiteConnection("Data Source = C:\\myCsv\\dbfiles\\payed.db; Version = 3; Password = 123456;");

            try
            {

                con.Open();
              //  DateTime yesturday = DateTime.Today.AddDays(-1);
              //  DateTime today = DateTime.Today;
              //  int toDay = today.Day;
              //  string todaySTR = (toDay <= 9) ? "0" + toDay.ToString() : toDay.ToString();
                DataSet ds = new DataSet();
                var da = new SQLiteDataAdapter("SELECT* from payed WHERE pc is null and time is not null AND time is CURRENT_DATE", con);
                da.Fill(ds);
                payedGridView.DataSource = ds.Tables[0].DefaultView;

                

                con.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }

       

        private void populatePrintViedDG()
        {
            SQLiteConnection con = new SQLiteConnection("Data Source = C:\\myCsv\\dbfiles\\payed.db; Version = 3; Password = 123456;");

            try
            {
                con.Open();

                DateTime yesturday = DateTime.Today.AddDays(-1);
                DateTime today = DateTime.Today;
                int toDay = today.Day;

                string todaySTR = (toDay <= 9) ? "0" + toDay.ToString() : toDay.ToString();

                DataSet ds = new DataSet();
                var da = new SQLiteDataAdapter("SELECT rowid, *" +
                    " FROM printView WHERE Time LIKE '%-"+yesturday.Day.ToString()+ "%' AND isPayed = '0' OR" +
                    " Time LIKE '%-"+ todaySTR + "%' " +
                    "AND isPayed = '0'", con);
                da.Fill(ds);
                printViewGrid.DataSource = ds.Tables[0].DefaultView;

                ListSortDirection dir = ListSortDirection.Descending;
                printViewGrid.Sort(printViewGrid.Columns[1], dir);
                con.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }





    
       

        private void displayTime(int u ) {

            countDBRows(u);
            int counter = 0;
            int tasknum = 0;

            timeNow.Text = (DateTime.Now.ToShortDateString() +"  "+ DateTime.Now.ToLongTimeString());

            
           
            

            string line;
            
            StreamReader csvFile = load_file(u);
          

            while ((line = csvFile.ReadLine()) != null)
            {

                
                if (counter++ <=1 ) { continue; }
                
                
                
                string[] parts = line.Split(',');
                string printTimeString = parts[0].ToString();
                string printer = parts[4].Substring(0, 7).ToString();
                string clientName = parts[6].ToString();
                int pages;
                Int32.TryParse(parts[2], out pages);
                int copies;
                Int32.TryParse(parts[3], out copies);
               

                string fileName =  Convert.ToString(parts[5]);
                DateTime lineTime = Convert.ToDateTime(parts[0]);

                tasknum++;

                if (rowCountDB < tasknum )
                { //run on change (run once)


                    i = true;
                    loadPrintView_ToDB(printTimeString, printer, pages*copies, clientName, fileName);
                    DBdate = lineTime;
                    if (printViewGrid.RowCount != 0)
                    {
                        printViewGrid.FirstDisplayedScrollingRowIndex = printViewGrid.RowCount - 1;
                    }
                    countDBRows(u);
                }
                //lastTime = DateTime.Today;
            }

            if (i == true)
            { 
                populatePrintViedDG();
                i = false;
            }

            

            notifyIcon1.Text = "Printed pages:" + pagesSumm.ToString();

            
            
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private Timer timer1;
 
        public void initTimer() {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(Form1_Activated);
            timer1.Interval = 1000;
            timer1.Start();
        }

        
        private void Form1_Activated(object sender, EventArgs e)
        {


            // displayTime(1, 20 , 0);

            // diplayYesturday();
                
                calcShiftSumm();
                displayTime(0);
            if (printViewGrid.RowCount == 0)
            {
                okButton.Enabled = false;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            conn = new SQLiteConnection("Data Source = C:\\myCsv\\dbfiles\\payed.db; Version = 3; Password = 123456;");
            conn.Open();

            getDB_Date(1);

            populatePrintViedDG();
            printViewGrid.Columns[6].Visible = false;
            printViewGrid.Columns[0].Visible = false;
            if (printViewGrid.RowCount != 0)
            {
                printViewGrid.FirstDisplayedScrollingRowIndex = printViewGrid.RowCount - 1;
            }
            AdminChangeForm form = new AdminChangeForm();
            form.ShowDialog();
            displayTime(1);
            populatePayedDG();
        }
       

        private StreamReader load_file(int u)
        {
            DateTime myDate = DateTime.Today.AddDays(-u); //Date time variable

            int currentYear = myDate.Year;
            int currentMonth = myDate.Month;
            int currentDay = myDate.Day;

            string todaySTR = (currentDay <= 9) ? "0" + currentDay.ToString() : currentDay.ToString();

            string monthSTR = (currentMonth <= 9) ? "0" + currentMonth.ToString() : currentMonth.ToString();

            //CSV file path
            string csvPath = "C:\\Program Files (x86)\\PaperCut Print Logger\\logs\\csv\\daily\\papercut-print-log-"+ currentYear + "-" + monthSTR + "-" + todaySTR +".csv";
            if (File.Exists(csvPath))
            {
                FileStream fs = new FileStream(csvPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                StreamReader csvFile = new StreamReader(fs, Encoding.GetEncoding("windows-1251"));
                return csvFile;
            }
            else {
                return null;
            }
        }

        private StreamReader load_myPayed_csv()
        {
            string csvPath = "C:\\myCsv\\myPayed" + DateTime.Now.ToShortDateString() + ".csv";  
            FileStream fs = new FileStream(csvPath, FileMode.OpenOrCreate , FileAccess.Read, FileShare.ReadWrite);
            
            StreamReader myCsvFile = new StreamReader(fs);

            return myCsvFile;
        }

        private StreamReader load_myLog_csv()
        {
            string myCsfListFile = "C:\\myCsv\\mylog" + DateTime.Now.ToShortDateString() + ".csv"; // create main csv list file to work with
            FileStream fs = new FileStream(myCsfListFile, FileMode.OpenOrCreate, FileAccess.Read, FileShare.ReadWrite);
            StreamReader myCsvFile = new StreamReader(fs);
            return myCsvFile;
        }

        


        private void sixRubCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (sixRubCheckBox.Checked == true)
            {
                nineRubCheckBox.Checked = false;
                threRubCheckBox.Checked = false;
                fourRubCheckBox.Checked = false;
                brakCheckBox.Checked = false;
                colourCheckBox.Checked = false;
                otherSummTextBox.Text = "";
                calcSelected(0, 0, 6);

              
            }
            if (sixRubCheckBox.Checked == false)
            {
                calcSelected(0, 0, 9);
            }
        }

        private void nineRubCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (nineRubCheckBox.Checked == true)
            {
                sixRubCheckBox.Checked = false;
                threRubCheckBox.Checked = false;
                fourRubCheckBox.Checked = false;
                brakCheckBox.Checked = false;
                colourCheckBox.Checked = false;
                otherSummTextBox.Text = "";
                calcSelected(0, 0, 9);

                
            }
            if (nineRubCheckBox.Checked == false)
            {
                calcSelected(0, 0, 9);
            }
        }



        private void fourRubCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (fourRubCheckBox.Checked == true)
            {
                nineRubCheckBox.Checked = false;
                threRubCheckBox.Checked = false;
                sixRubCheckBox.Checked = false;
                brakCheckBox.Checked = false;
                colourCheckBox.Checked = false;
                otherSummTextBox.Text = "";
                calcSelected(0, 0, 4);

               
            }
            if (fourRubCheckBox.Checked == false)
            {
                calcSelected(0, 0, 9);
            }
        }

        private void threRubCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (threRubCheckBox.Checked == true)
            {
                nineRubCheckBox.Checked = false;
                sixRubCheckBox.Checked = false;
                fourRubCheckBox.Checked = false;
                brakCheckBox.Checked = false;
                colourCheckBox.Checked = false;
                otherSummTextBox.Text = "";
                calcSelected(0, 0, 3);

          
            }
            if (threRubCheckBox.Checked == false)
            {
                calcSelected(0, 0, 9);
            }
        }

        private void brakCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (brakCheckBox.Checked == true) {

                nineRubCheckBox.Checked = false;
                sixRubCheckBox.Checked = false;
                fourRubCheckBox.Checked = false;
                threRubCheckBox.Checked = false;
                colourCheckBox.Checked = false;
                otherSummTextBox.Text = "";
                calcSelected(0, 0, 0);

             
            }
            if (brakCheckBox.Checked == false)
            {
                calcSelected(0, 0, 9);
            }
        }

        private void colourCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (colourCheckBox.Checked == true) {

                nineRubCheckBox.Checked = false;
                sixRubCheckBox.Checked = false;
                fourRubCheckBox.Checked = false;
                threRubCheckBox.Checked = false;
                brakCheckBox.Checked = false;
                otherSummTextBox.Text = "";
                calcSelected(0, 0, 20);
                              
            }
            if (colourCheckBox.Checked == false)
            {
                calcSelected(0, 0, 9);
            }
        }


        private void loadPaylog() {

            string path = "C:\\myCsv\\myPayed" + DateTime.Now.ToShortDateString() + ".csv";
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read, FileShare.ReadWrite);
            StreamReader payedLog = new StreamReader(fs);
            string line;

            

            while ((line = payedLog.ReadLine()) != null) {


                string[] parts = line.Split(',');
                string time = parts[1].ToString();
                string copies = parts[2].ToString();
                string money = parts[3].ToString();
                ListViewItem items1 = new ListViewItem(time);
                items1.SubItems.Add(copies);
                items1.SubItems.Add(money);
               // logList.Items.AddRange(new ListViewItem[] {items1});

                
            }

         // logList.Items[logList.Items.Count - 1].EnsureVisible(); //scroll to bottom


        }

      

        private void okButton_Click(object sender, EventArgs e)
        {

            
            string time = "";
            string printer = "";
            string pc = "";
            string file = "";
            string adminname = shiftLable.Text;
            int sumo = 0;
            int rowid = 0;
            foreach (DataGridViewRow row in printViewGrid.SelectedRows)
            {
                time = Convert.ToString(row.Cells[1].Value);
                printer = Convert.ToString(row.Cells[2].Value);
                pc = Convert.ToString(row.Cells[4].Value);
                file = Convert.ToString(row.Cells[5].Value);
                sumo = Convert.ToInt32(row.Cells[3].Value);
                rowid = Convert.ToInt32(row.Cells[0].Value);

                SQLiteCommand commm = new SQLiteCommand("INSERT INTO payed (time,printer,pc,file,sum,admin) VALUES " +
                    "('" + time + "','" + printer + "','" + pc + "','" + file + "','"+sumo+"','"+ adminname + "')",conn);
                commm.ExecuteNonQuery();

                SQLiteCommand command = new SQLiteCommand("UPDATE printView SET isPayed = '1' WHERE rowid = '"+rowid+"'", conn);
                command.ExecuteNonQuery();

            }
            SQLiteCommand comm = new SQLiteCommand("INSERT INTO payed (time,sum,admin) VALUES (CURRENT_DATE,'" + ToalPrice + "','"+adminname+"')", conn);
            comm.ExecuteNonQuery();
            populatePrintViedDG();
            populatePayedDG();



        }

        private void otherSummTextBox_TextChanged(object sender, EventArgs e)
        {
            nineRubCheckBox.Checked = false;
            sixRubCheckBox.Checked = false;
            fourRubCheckBox.Checked = false;
            threRubCheckBox.Checked = false;
            brakCheckBox.Checked = false;
            colourCheckBox.Checked = false;

            int otherSummInt;
            Int32.TryParse(otherSummTextBox.Text , out otherSummInt) ;
            calcSelected(0, 0, otherSummInt);
            //totalSummLable.Text = "=" + (logTotalPagesPrinted * pagesPriceIndex).ToString() + "  Руб.";
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {

            
            
        }

      

        public void countPages(string printerName , string numberOfPagesSelected , int pagesSumm) {

            
            if (printerName == "EPSON X" || printerName == "EPSON T")
            {
                totalColorPages += pagesSumm;
                if (countDefectedColor == false)
                {
                    totalColorPages -= defectPagesColor;
                    countDefectedColor = true;
                    
                }

                if (totalColorPages >= 11)
                    {
                        pagesPriceIndex = 18;
                    }
                    else if (totalColorPages <= 10)
                    {
                        pagesPriceIndex = 20;
                    }

                    logTotalPagesPrinted += pagesSumm;
                    int price = totalColorPages * pagesPriceIndex;
                    PagesPlusCopiesColor = price;
                    totalPagesPrinted = pagesPlusCopies + PagesPlusCopiesColor;

                priceDisplayerFunct((totalPagesPrinted));
               // totalSummLable.Text = "=" + totalPagesPrinted.ToString() + " Руб.";

                    //show baloon tip in tray
                   // notifyIcon1.BalloonTipText = printerName + " Страниц " + " " + totalColorPages.ToString() + Environment.NewLine + totalPagesPrinted.ToString();
                    //notifyIcon1.ShowBalloonTip(100);
                
            }
            else if (printerName == "Kyocera" || printerName == "HP Lase")
            {
                totalBWpages += pagesSumm;
                if (countedDefected == false) {
                    totalBWpages -= defectPagesBW; 
                    countedDefected = true;
                    
                }
                

                if (Enumerable.Range(51, 100).Contains(totalBWpages))
                    {
                        pagesPriceIndex = 4;
                    }
                    else if (Enumerable.Range(10, 51).Contains(totalBWpages))
                    {
                        pagesPriceIndex = 6;
                    }
                    else if (Enumerable.Range(0, 10).Contains(totalBWpages))
                    {
                        pagesPriceIndex = 9;
                    }
                    else // if more than 100 pages are printed
                    {
                        pagesPriceIndex = 3;
                    }


                    logTotalPagesPrinted += pagesSumm;
                    int price = totalBWpages * pagesPriceIndex;
                    pagesPlusCopies = price;
                    totalPagesPrinted = pagesPlusCopies + PagesPlusCopiesColor;
                     priceDisplayerFunct(totalPagesPrinted);
                    //totalSummLable.Text = "=" + totalPagesPrinted.ToString() + " Руб.";
                    //show baloon tip in tray
                  //  notifyIcon1.BalloonTipText = printerName + " Страниц " + " " + totalBWpages.ToString() + Environment.NewLine + totalPagesPrinted.ToString();
                   // notifyIcon1.ShowBalloonTip(100);
                
            }

        }

        private void priceDisplayerFunct(int price) {

            totalSummLable.Text =  price.ToString();
            ToalPrice = price;
        }

  

       

        private void defectControl_ValueChanged(object sender, EventArgs e)
        {
            defectPagesBW = Convert.ToInt32(defectControl.Value);

            calcSelected(Convert.ToInt32(colorDefectControl.Value),Convert.ToInt32( defectControl.Value));
            
        }

        private void бракToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void colorDefectControl_ValueChanged(object sender, EventArgs e)
        {
            defectPagesColor = Convert.ToInt32(colorDefectControl.Value);

            calcSelected(Convert.ToInt32(colorDefectControl.Value), Convert.ToInt32(defectControl.Value));

        }

       private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (maximWindow == true)
            {
                this.WindowState = FormWindowState.Minimized;
                maximWindow = false;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                maximWindow = true;
            }
        }

      

        private void endShiftButton_Click(object sender, EventArgs e)
        {
            AdminChangeForm form = new AdminChangeForm();
            form.ShowDialog();
        }

        private void defectControl_ValueChanged_1(object sender, EventArgs e)
        {

        }

        public void writeShiftmoney(int summ) {
            shiftMoney += summ;
            File.WriteAllText("C:\\myCsv\\Shifts\\ShiftLog" + DateTime.Today.ToShortDateString()+".csv", shiftMoney.ToString());
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            int i;
            
            bool worked = int.TryParse(textBox1.Text, out i);
            if (worked)
            {
                ToalPrice = i;
                totalSummLable.Text ="="+" "+ i.ToString();
            }
            else
            {
                MessageBox.Show("...");

            }
           
        }

        public void calcShiftSumm()
        {
            DateTime date = DateTime.Today;
            int today = date.Day;
            string toDay = (today < 9) ? "0" + today.ToString() : today.ToString();
            SQLiteCommand comm = new SQLiteCommand("SELECT SUM(sum) FROM payed WHERE pc is null and time is not null AND time is CURRENT_DATE ", conn);
            totalShiftSummLBL.Text = comm.ExecuteScalar().ToString();

        }

        public void createdb(string time,string printer, int pages, string pc, string file)
        {
            SQLiteConnection con = new SQLiteConnection("Data Source = C:\\myCsv\\dbfiles\\payed.db; Version = 3; Password = 123456;");
            con.Open();
            
            SQLiteCommand insertSQL = new SQLiteCommand("Insert into payed (time,printer,sum,pc,file) Values (?,?,?,?,?)",con);
            SQLiteParameter timePr = new SQLiteParameter();
            SQLiteParameter printerPr = new SQLiteParameter();
            SQLiteParameter pagesPr = new SQLiteParameter();
            SQLiteParameter pcPr = new SQLiteParameter();
            SQLiteParameter filePr = new SQLiteParameter();

            timePr.Value = time;
            printerPr.Value = printer;
            pagesPr.Value = pages;
            pcPr.Value = pc;
            filePr.Value = file;

            insertSQL.Parameters.Add(timePr);
            insertSQL.Parameters.Add(printerPr);
            insertSQL.Parameters.Add(pagesPr);
            insertSQL.Parameters.Add(pcPr);
            insertSQL.Parameters.Add(filePr);

            try
            {
                insertSQL.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        

       
        

       

        //---------------db Functions------------

        private void CountLinesInDB()
        {
            SQLiteDataReader DBRead;
            SQLiteCommand comm = new SQLiteCommand("select count(*) from printView", conn);
            DBRead = comm.ExecuteReader();
            DBRead.Read();
            dblines = DBRead.GetInt32(0); 
        }

        private void CountLinesInCSV()
        {
            string line;
            int counter = 0;
            StreamReader printViewCSV = load_file(0);
            while ((line = printViewCSV.ReadLine()) != null)
            {
                if (counter++ <= 1) { continue; }
                csvLines++;
            }
        }

        private void getDB_Date(int u)
        {
            DateTime Yesturday = DateTime.Today;
            SQLiteDataReader DBread;

            if (u == 1)
            {
                Yesturday.AddDays(-u);
                SQLiteCommand comm = new SQLiteCommand("SELECT Time FROM printView WHERE Time LIKE '%-" + Yesturday.Day.ToString() + "%' ORDER BY ROWID DESC LIMIT 1", conn);
                DBread = comm.ExecuteReader();
                if (DBread.HasRows)
                {
                    DBread.Read();
                    DBdate = DBread.GetDateTime(0);
                }
                else
                {
                    DBdate = DateTime.Today.AddDays(-1);
                }

                DBread.Close();
                displayTime(u);

            }
            //-------------today----------
            else if (u == 0)
            {

                DateTime today = DateTime.Today;
                SQLiteCommand comm = new SQLiteCommand("SELECT Time FROM printView WHERE Time LIKE '%-" + today.Day.ToString() + "%' ORDER BY ROWID DESC LIMIT 1", conn);

                DBread = comm.ExecuteReader();
                if (DBread.HasRows)
                {
                    DBread.Read();
                    DBdate = DBread.GetDateTime(0);
                }
                else
                {
                    DBdate = DateTime.Today.AddDays(0);
                }
                displayTime(u);
                DBread.Close();
            }
            

        }

        private void printViewGrid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

            calcSelected(0,0);
            okButton.Enabled = true;

        }

        private void calcSelected(int colorDefect , int BW_defect, int custom = 0)
        {
            int colorPages = 0;
            int coloPagesSumm = 0;
            int bwPages = 0;
            int bwPageSumm = 0;
            string printerName;

            ToalPrice = 0;
            foreach (DataGridViewRow row in printViewGrid.SelectedRows)
            {
                printerName = row.Cells[2].Value.ToString();
                if (printerName == "Kyocera" || printerName == "HP Lase")
                {
                    bwPages +=  Convert.ToInt32(row.Cells[3].Value);
                }
                else if (printerName == "EPSON X")
                {
                    colorPages +=  Convert.ToInt32(row.Cells[3].Value);
                }
            }
            bwPages -= BW_defect;
            colorPages -= colorDefect;

            if (brakCheckBox.Checked == true)
            {
                ToalPrice = 0;
                bwPageSumm = bwPages * 0;
                coloPagesSumm = colorPages * 0;
            }
            else
            {
                if (custom != 0)

                {
                    bwPageSumm = bwPages * custom;
                    coloPagesSumm = colorPages * custom;
                    ToalPrice = (bwPages + colorPages) * custom;
                }
                else
                {

                    if (bwPages < 0)
                    {
                        bwPages = 0;
                        defectControl.Value = 0;
                    }
                    if (colorPages < 0)
                    {
                        colorPages = 0;
                        colorDefectControl.Value = 0;
                    }


                    if (Enumerable.Range(51, 100).Contains(bwPages) || fourRubCheckBox.Checked == true)
                    {
                        bwPageSumm = bwPages * 4;
                    }
                    else if (Enumerable.Range(10, 50).Contains(bwPages) || sixRubCheckBox.Checked == true)
                    {
                        bwPageSumm = bwPages * 6;
                    }
                    else if (Enumerable.Range(1, 9).Contains(bwPages) || nineRubCheckBox.Checked == true)
                    {
                        bwPageSumm = bwPages * 9;
                    }
                    else
                    {
                        bwPageSumm = bwPages * 3;
                    }

                    if (Enumerable.Range(1, 9).Contains(colorPages))
                    {
                        coloPagesSumm = colorPages * 20;
                    }
                    else
                    {
                        coloPagesSumm = colorPages * 18;
                    }

                    ToalPrice = coloPagesSumm + bwPageSumm;
                }
            }
                totalSummLable.Text = (bwPageSumm.ToString()+'('+bwPages.ToString()+')'+ '/' 
                + coloPagesSumm.ToString()+'('+colorPages.ToString()+')'+
                '='+ (coloPagesSumm+bwPageSumm).ToString());
            
        }

        public void countDBRows(int u)
        {
            
            DateTime day = DateTime.Today.AddDays(-u);

            int currentYear = day.Year;
            int currentMonth = day.Month;
            int currentDay = day.Day;

            string todaySTR = (currentDay <= 9) ? "0" + currentDay.ToString() : currentDay.ToString();

            string monthSTR = (currentMonth <= 9) ? "0" + currentMonth.ToString() : currentMonth.ToString();

            SQLiteCommand comm = new SQLiteCommand("SELECT count(Time) FROM printView WHERE Time Like '%"+day.Year.ToString()+"-"+monthSTR+"-"+todaySTR+"%'",conn);
            rowCountDB = Convert.ToInt32(comm.ExecuteScalar());

        }

        private void printViewGrid_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            defectControl.Value = 0;
            colorDefectControl.Value = 0;
        }

        private void totalShiftSummLBL_Click(object sender, EventArgs e)
        {

        }
    }
}




