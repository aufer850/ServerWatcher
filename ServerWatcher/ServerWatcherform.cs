using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerWatcher
{
    public partial class ServerWatcherform : Form
    {
        //головний список перезапусків, дані з нього записуються в datagridview
        List<Reload> ReloadList = new List<Reload>();
        bool Admin = false;
        string UserName;
        //Змінна для створення унікального ідентифікатора кожному перезапуску
        int IDNumber = 0;
        public ServerWatcherform(string N, string A)
        {
            InitializeComponent();
            UserName = N;
            if (string.Equals("True", A)) Admin = true;
            DisplayName.Text = "Доброго дня, " + UserName + "!";
            // Простий користувач не буде бачити меню перезапуску
            ReloadButton.Visible = Admin;
            ReloadReasonBox.Visible = Admin;
            RAdminLabel.Visible = Admin;
            ReloadMenuAdminLabel.Visible = Admin;
            ChangeButton.Visible = Admin;
        }
        //методи нижче створені для отпимізації роботи з декількома DataGridView
        private void AddInTable(Reload R, DataGridView D)
        {
            int n = D.Rows.Add(R);
            D.Rows[n].Cells[0].Value = R.ID;
            D.Rows[n].Cells[1].Value = R.Date;
            D.Rows[n].Cells[2].Value = R.Name;
            D.Rows[n].Cells[3].Value = R.Reason;
        }
        private void ClearTable(DataGridView G)
        {
            if (G == MainMenuDataGrid)
            {
                ReloadList.Clear();
                IDNumber = 0;
            }
            G.Rows.Clear();

        }
        private void ReloadTable(DataGridView G, List<Reload> R)
        {
            G.Rows.Clear();
            foreach (Reload t in R)
            {
                AddInTable(t, G);
            }
            ShowLastReset();
        }
        // відображення останього перезапуску
        private void ShowLastReset()
        {
            if (ReloadList.Count > 0)
            {
                Reload LR = ReloadList[0];
                int last = DateTime.Now.Subtract(LR.Date).Days;
                string text = "Останній перезапуск: \n";
                if (last > 0) LastReloadLabel.Text = text + last.ToString() + " днів тому";
                else if (last == 0) LastReloadLabel.Text = text +"Сьогодні";
                else if (last < 0) LastReloadLabel.Text = text + "Через " + (last * -1).ToString() + " днів";
                LastIdLabel.Text = "ID: " + LR.ID;
                ReasonLabel.Text = "Причина: " + LR.Reason;
            }
        }
        private void SortbyDate(List<Reload> RList)
        {
            for (int i = 0; i < RList.Count; i++)
            {
                Reload KeyR = RList[i];
                int j = i;
                while ((j > 0) && (DateTime.Compare(KeyR.Date, RList[j - 1].Date) > 0))
                {
                    (RList[j - 1], RList[j]) = (RList[j], RList[j - 1]);
                    j--;
                }

                RList[j] = KeyR;
            }
        }
        private int FindIDIndex(List<Reload> RList, int ID)
        {
            for (int i = 0; i < RList.Count; i++)
            {
                Reload R = RList[i];
                if(R.ID == ID)
                {
                    return i;
                }
            }
            return -1; // не знайдено
        }
// Далі йдуть методи самої програми

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Admin == true)
            {
                checkBox1.Checked = true;
                int n = MainMenuDataGrid.SelectedCells[0].RowIndex;
                ReloadReasonBox.Text = MainMenuDataGrid.Rows[n].Cells[3].Value.ToString();
                DateTime D = Convert.ToDateTime(MainMenuDataGrid.Rows[n].Cells[1].Value);
                ReloadDateBox.Text = D.Day.ToString() + "." + D.Month.ToString() + "." + D.Year.ToString();
                ReloadTimeBox.Text = D.TimeOfDay.ToString();
            }
        }
        // Створення нового перезапуску
        private void ReloadButton_Click(object sender, EventArgs e)
        {
            if (ReloadReasonBox.Text == "")
            {
                MessageBox.Show("Вкажіть причину!", "Помилка!");
                return;
            }
            if (Admin == true)
            {
                DateTime PlanDay = DateTime.Now;
                DateTime PlanTime = DateTime.Now;
                DateTime ReloadTime = DateTime.Now;
                if (ReloadDateBox.Text != "")
                {
                    try { PlanDay = Convert.ToDateTime(ReloadDateBox.Text); } catch { MessageBox.Show("Неправильно вказана дата", "Помилка!"); return; }
                }
                if (ReloadTimeBox.Text != "")
                {
                    try { PlanTime = Convert.ToDateTime(ReloadTimeBox.Text); } catch { MessageBox.Show("Неправильно вказано час", "Помилка!"); return; }
                }
                    ReloadTime = PlanDay.Date + PlanTime.TimeOfDay;             
                if (ReloadTime >= DateTime.Now)
                {
                    foreach (Reload Rel in ReloadList)
                    {
                        DateTime D = Rel.Date;
                        //перевірка, чи існує подібний перезапуск
                        string DR = D.AddSeconds(-1 * D.Second).AddMilliseconds(-1 * D.Millisecond).ToString();
                        string RR = ReloadTime.AddSeconds(-1 * ReloadTime.Second).AddMilliseconds(-1 * ReloadTime.Millisecond).ToString();
                        if (string.Equals(DR,RR))
                        {
                            MessageBox.Show("Такий перезапуск вже створено! \nПочекайте хвилину, або заплануйте перезапуск!", "Помилка!");
                            return;
                        }
                    }
                    Reload R = new Reload(IDNumber, ReloadTime, UserName, ReloadReasonBox.Text);
                    ReloadList.Add(R);
                    SortbyDate(ReloadList);
                    ReloadTable(MainMenuDataGrid, ReloadList);
                    ShowLastReset();
                    

                    IDNumber++;
                }
                else MessageBox.Show("Вказано час, раніший за теперішній!","Помилка!");
                
            }

            else MessageBox.Show("Ви не адміністратор!", "Помилка!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Admin)
            {
                int LookID = 0;
                try { LookID = Convert.ToInt32(IDBox.Text); } catch { MessageBox.Show("Неправильно вказан ID для видалення", "Помилка!"); return; }
                int Index = FindIDIndex(ReloadList, LookID);
                if (Index == -1)
                {
                    MessageBox.Show("перезапуск не знайдено!", "Помилка!");
                    return;
                }
                ReloadList.RemoveAt(Index);
                ReloadTable(MainMenuDataGrid, ReloadList);
                IDBox.Text = "";
                IDNumber--;
            }
            else MessageBox.Show("Ви не адміністратор!", "Помилка!");              
        }

        private void IDBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void IDBox_Click(object sender, EventArgs e)
        {
            IDBox.Text = "";
        }
        //Допоміжний метод для функції збереження
        public DataSet createDS()
        {
            DataSet DS = new DataSet();
            DataTable dt = new DataTable();
            dt.TableName = "Reload";
            dt.Columns.Add("ID");
            dt.Columns.Add("Time");
            dt.Columns.Add("User");
            dt.Columns.Add("Reason");
            DS.Tables.Add(dt);
            return (DS);
        }

        //Збереження дати та створення впорядкованих даних згідно індивідуального завдання
        private void button1_Click_1(object sender, EventArgs e)
        {
        try
        {
            string path = "C:\\ReloadData";
            Directory.CreateDirectory(path);
            DataSet DS = createDS();
            DataSet SortDS = createDS();
            for (int i = 0; i < ReloadList.Count; i++)
            {
                Reload R = ReloadList[i];
                DataRow dr = DS.Tables["Reload"].NewRow();
                dr["ID"] = R.ID;
                dr["Time"] = R.Date;
                dr["User"] = R.Name;
                dr["Reason"] = R.Reason;
                DS.Tables["Reload"].Rows.Add(dr);
                string SD = R.Date.Date.ToShortDateString().Replace(".", "");
                if (i > 0)
                {
                    Reload RR = ReloadList[i - 1];
                    if (DateTime.Equals(R.Date.Date, RR.Date.Date))
                    {
                        DataRow drc = SortDS.Tables["Reload"].NewRow();
                        drc["ID"] = R.ID;
                        drc["Time"] = R.Date;
                        drc["User"] = R.Name;
                        drc["Reason"] = R.Reason;
                        SortDS.Tables["Reload"].Rows.Add(drc);
                    }
                    else
                    {
                        SortDS.WriteXml("C:\\ReloadData\\" + SD + ".xml");
                        SortDS = createDS();
                        DataRow drc = SortDS.Tables["Reload"].NewRow();
                        drc["ID"] = R.ID;
                        drc["Time"] = R.Date;
                        drc["User"] = R.Name;
                        drc["Reason"] = R.Reason;

                        SortDS.Tables["Reload"].Rows.Add(drc);
                    }
                }
                else
                {
                    DataRow drc = SortDS.Tables["Reload"].NewRow();
                    drc["ID"] = R.ID;
                    drc["Time"] = R.Date;
                    drc["User"] = R.Name;
                    drc["Reason"] = R.Reason;
                    SortDS.Tables["Reload"].Rows.Add(drc);
                }
                if (i == ReloadList.Count)
                {
                    SortDS.WriteXml("C:\\ReloadData\\" + SD + ".xml");
                }
            }
            DS.WriteXml("C:\\Data.xml");
            MessageBox.Show("Файл успішно збережено на диску C! \n Впорядковану інформацію можна знайти у файлі Data", "Зроблено!");
        }
        catch
        {
        MessageBox.Show("Вибачте, щось пішло не так!", "Помилка!");
        }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (File.Exists("C:\\Data.xml"))
            {
                IDNumber = 0;
                ReloadList.Clear();
                ClearTable(MainMenuDataGrid);
                DataSet DS = new DataSet();
                DS.ReadXml("C:\\Data.xml");
                foreach (DataRow I in DS.Tables["Reload"].Rows)
                {
                    Reload R = new Reload(Convert.ToInt32(I["ID"]), Convert.ToDateTime(I["Time"]), (string)I["User"], (string)I["Reason"]);
                    ReloadList.Add(R);
                    IDNumber++;
                }
                SortbyDate(ReloadList);
                ReloadTable(MainMenuDataGrid, ReloadList);
                ShowLastReset();
            }
            else MessageBox.Show("Немає файлу!", "Помилка!");
        }

        //Очистка
        private void button3_Click(object sender, EventArgs e)
        {
            ClearTable(MainMenuDataGrid);
        }

        // пошук Нічник перезапусків
        private void button5_Click(object sender, EventArgs e)
        {
            List < Reload > LocalList = new List<Reload>();
            SearchGridView.Rows.Clear();
            foreach (Reload R in ReloadList)
            {
                int T = R.Date.Hour;
                if(T >= 22 || T <= 6)
                {
                    LocalList.Add(R);
                }
            }
            ReloadTable(SearchGridView,LocalList);
        }

        // Пошук перезапусків в період часу
        private void button4_Click(object sender, EventArgs e)
        {
            List<Reload> LocalList = new List<Reload>();
            DateTime Min;
            DateTime Max;
            try { Min = Convert.ToDateTime(StartDataTextBox.Text); } catch { MessageBox.Show("Неправильно вказана мінімлаьна дата", "Помилка!"); return; }
            try { Max = Convert.ToDateTime(EndDataTextBox.Text); } catch { MessageBox.Show("Неправильно вказана максимальна дата", "Помилка!"); return; }
            foreach (Reload R in ReloadList)
            {
                if(DateTime.Compare(R.Date,Min) >= 0 && DateTime.Compare(R.Date,Max) <= 0)
                {
                    if (ProOnlyBox.Checked)
                    {
                            if (R.Reason == "Профілактика")
                            {
                            LocalList.Add(R);
                            }              
                    } else LocalList.Add(R);
                }
            }
            ReloadTable(SearchGridView, LocalList);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool c = checkBox1.Checked;
            PlanL1.Visible = c;
            PlanL2.Visible = c;
            ReloadDateBox.Visible = c;
            ReloadTimeBox.Visible = c;
            if(c == false)
            {
                ReloadDateBox.Text = "";
                ReloadTimeBox.Text = "";
            }
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            DateTime PlanDay = DateTime.Now;
            DateTime PlanTime = DateTime.Now;
            DateTime ReloadTime = DateTime.Now;
            if (Admin == false)
            {
                MessageBox.Show("Ви не адміністратор!", "Помилка!");
            }
            if (ReloadDateBox.Text != "")
            {
                try { PlanDay = Convert.ToDateTime(ReloadDateBox.Text); } catch { MessageBox.Show("Неправильно вказана дата", "Помилка!"); return; }
            }
            if (ReloadTimeBox.Text != "")
            {
                try { PlanTime = Convert.ToDateTime(ReloadTimeBox.Text); } catch { MessageBox.Show("Неправильно вказано час", "Помилка!"); return; }
            }
            ReloadTime = PlanDay.Date + PlanTime.TimeOfDay;
            int n = 0;
            try { n = MainMenuDataGrid.SelectedCells[0].RowIndex; } catch { MessageBox.Show("Оберіть рядок!", "Помилка!"); return; }
            int LookID = Convert.ToInt32(MainMenuDataGrid.Rows[n].Cells[0].Value);
            int Indx = FindIDIndex(ReloadList, LookID); 
            ReloadList[Indx].Reason = ReloadReasonBox.Text;
            ReloadList[Indx].Date = ReloadTime;
            ReloadList[Indx].Name = UserName;
            Reload R = ReloadList[Indx];
            MainMenuDataGrid.Rows[n].Cells[3].Value = R.Reason;
            MainMenuDataGrid.Rows[n].Cells[1].Value = R.Date;
            MainMenuDataGrid.Rows[n].Cells[2].Value = R.Name;
        }
    }
}
