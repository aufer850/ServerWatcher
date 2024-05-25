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
        }
        //методи нижче створені для отпимізації роботи з декількома DataGridView
        private void AddInTable(Reload R, DataGridView D)
        {
            int n = D.Rows.Add();
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
            // відображення останього перезапуску
            if (ReloadList.Count > 0)
            {
                Reload LR = ReloadList[0];
                string last = DateTime.Now.Subtract(LR.Date).Days.ToString();
                LastReloadLabel.Text = "Останній перезапуск: \n" + last + " днів тому";
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
        int BinarySearch(List<Reload> SeekList, int SeekID)
        {
        int low = 0;
        int high = SeekList.Count - 1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                int r = SeekList[mid].ID;
                if (r == SeekID)
                {
                    return mid;
                }
                if (r > SeekID)
                low = mid + 1;
                else
                high = mid - 1;
            }
                  return -1; // Не знайдено   
        
        }
// Далі йдуть методи самої програми

private void Search_Click(object sender, EventArgs e)
        {

        }

        private void Main_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                IDNumber++;
                Reload R = new Reload(IDNumber, DateTime.Now, UserName, ReloadReasonBox.Text);
                AddInTable(R, MainMenuDataGrid);
                ReloadList.Add(R);
            }
            else MessageBox.Show("Ви не адміністратор!", "Помилка!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ReloadList.Count; i++)
            {

                if (string.Equals(Convert.ToString(ReloadList[i].ID), IDBox.Text))
                {
                    ReloadList.RemoveAt(i);
                    ReloadTable(MainMenuDataGrid, ReloadList);
                    IDBox.Text = "";
                    IDNumber--;
                }
            }
        }

        private void IDBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void IDBox_Click(object sender, EventArgs e)
        {
            IDBox.Text = "";
        }
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
                DataRow drc = SortDS.Tables["Reload"].NewRow();
                drc["ID"] = R.ID;
                drc["Time"] = R.Date;
                drc["User"] = R.Name;
                drc["Reason"] = R.Reason;
                string SD = R.Date.Date.ToShortDateString().Replace(".", "");
                if (i > 0)
                {
                    Reload RR = ReloadList[i - 1];
                    if (DateTime.Equals(R.Date.Date, RR.Date.Date))
                    {
                        SortDS.Tables["Reload"].Rows.Add(drc);
                    }
                    else
                    {
                        SortDS.WriteXml("C:\\ReloadData\\" + SD + ".xml");
                        SortDS = createDS();
                        SortDS.Tables["Reload"].Rows.Add(drc);
                    }
                } else SortDS.Tables["Reload"].Rows.Add(drc);
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
            }
            else MessageBox.Show("Немає файлу!", "Помилка!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClearTable(MainMenuDataGrid);
        }
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

        private void SearchGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

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
    }
}
