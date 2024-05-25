
namespace ServerWatcher
{
    partial class ServerWatcherform
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.MainMenu = new System.Windows.Forms.TabPage();
            this.ReasonLabel = new System.Windows.Forms.Label();
            this.LastIdLabel = new System.Windows.Forms.Label();
            this.LastReloadLabel = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.ReloadMenuAdminLabel = new System.Windows.Forms.Label();
            this.RAdminLabel = new System.Windows.Forms.Label();
            this.ReloadReasonBox = new System.Windows.Forms.ComboBox();
            this.MainMenuDataGrid = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReloadButton = new System.Windows.Forms.Button();
            this.DisplayName = new System.Windows.Forms.Label();
            this.SearchTab = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SearchGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDataTextBox = new System.Windows.Forms.TextBox();
            this.EndDataTextBox = new System.Windows.Forms.TextBox();
            this.ProOnlyBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainMenuDataGrid)).BeginInit();
            this.SearchTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.MainMenu);
            this.tabControl1.Controls.Add(this.SearchTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)), true);
            this.tabControl1.ItemSize = new System.Drawing.Size(284, 20);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(884, 461);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // MainMenu
            // 
            this.MainMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MainMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainMenu.Controls.Add(this.ReasonLabel);
            this.MainMenu.Controls.Add(this.LastIdLabel);
            this.MainMenu.Controls.Add(this.LastReloadLabel);
            this.MainMenu.Controls.Add(this.button3);
            this.MainMenu.Controls.Add(this.button2);
            this.MainMenu.Controls.Add(this.button1);
            this.MainMenu.Controls.Add(this.IDBox);
            this.MainMenu.Controls.Add(this.Deletebutton);
            this.MainMenu.Controls.Add(this.ReloadMenuAdminLabel);
            this.MainMenu.Controls.Add(this.RAdminLabel);
            this.MainMenu.Controls.Add(this.ReloadReasonBox);
            this.MainMenu.Controls.Add(this.MainMenuDataGrid);
            this.MainMenu.Controls.Add(this.ReloadButton);
            this.MainMenu.Controls.Add(this.DisplayName);
            this.MainMenu.Location = new System.Drawing.Point(4, 24);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Padding = new System.Windows.Forms.Padding(3);
            this.MainMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MainMenu.Size = new System.Drawing.Size(876, 433);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "Головна";
            this.MainMenu.UseVisualStyleBackColor = true;
            this.MainMenu.Click += new System.EventHandler(this.Main_Click);
            // 
            // ReasonLabel
            // 
            this.ReasonLabel.AutoSize = true;
            this.ReasonLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)), true);
            this.ReasonLabel.Location = new System.Drawing.Point(10, 132);
            this.ReasonLabel.Name = "ReasonLabel";
            this.ReasonLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ReasonLabel.Size = new System.Drawing.Size(95, 18);
            this.ReasonLabel.TabIndex = 13;
            this.ReasonLabel.Text = "Користувач:";
            // 
            // LastIdLabel
            // 
            this.LastIdLabel.AutoSize = true;
            this.LastIdLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)), true);
            this.LastIdLabel.Location = new System.Drawing.Point(10, 101);
            this.LastIdLabel.Name = "LastIdLabel";
            this.LastIdLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LastIdLabel.Size = new System.Drawing.Size(27, 18);
            this.LastIdLabel.TabIndex = 12;
            this.LastIdLabel.Text = "ID:";
            // 
            // LastReloadLabel
            // 
            this.LastReloadLabel.AutoSize = true;
            this.LastReloadLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)), true);
            this.LastReloadLabel.Location = new System.Drawing.Point(10, 43);
            this.LastReloadLabel.Name = "LastReloadLabel";
            this.LastReloadLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LastReloadLabel.Size = new System.Drawing.Size(157, 18);
            this.LastReloadLabel.TabIndex = 11;
            this.LastReloadLabel.Text = "Останній перезапуск";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)), true);
            this.button3.Location = new System.Drawing.Point(712, 389);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 35);
            this.button3.TabIndex = 10;
            this.button3.Text = "Очистити";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)), true);
            this.button2.Location = new System.Drawing.Point(507, 389);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 35);
            this.button2.TabIndex = 9;
            this.button2.Text = "Завантажити";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)), true);
            this.button1.Location = new System.Drawing.Point(290, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "Зберегти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // IDBox
            // 
            this.IDBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IDBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)), true);
            this.IDBox.Location = new System.Drawing.Point(290, 332);
            this.IDBox.Name = "IDBox";
            this.IDBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.IDBox.Size = new System.Drawing.Size(496, 26);
            this.IDBox.TabIndex = 7;
            this.IDBox.Text = "Введіть ID";
            this.IDBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.IDBox.Click += new System.EventHandler(this.IDBox_Click);
            this.IDBox.TextChanged += new System.EventHandler(this.IDBox_TextChanged);
            // 
            // Deletebutton
            // 
            this.Deletebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deletebutton.Location = new System.Drawing.Point(785, 332);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(82, 26);
            this.Deletebutton.TabIndex = 6;
            this.Deletebutton.Text = "Видалити";
            this.Deletebutton.UseVisualStyleBackColor = true;
            this.Deletebutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ReloadMenuAdminLabel
            // 
            this.ReloadMenuAdminLabel.AutoSize = true;
            this.ReloadMenuAdminLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)), true);
            this.ReloadMenuAdminLabel.Location = new System.Drawing.Point(44, 285);
            this.ReloadMenuAdminLabel.Name = "ReloadMenuAdminLabel";
            this.ReloadMenuAdminLabel.Size = new System.Drawing.Size(186, 19);
            this.ReloadMenuAdminLabel.TabIndex = 5;
            this.ReloadMenuAdminLabel.Text = "МЕНЮ ПЕРЕЗАПУСКУ";
            // 
            // RAdminLabel
            // 
            this.RAdminLabel.AutoSize = true;
            this.RAdminLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)), true);
            this.RAdminLabel.Location = new System.Drawing.Point(7, 316);
            this.RAdminLabel.Name = "RAdminLabel";
            this.RAdminLabel.Size = new System.Drawing.Size(125, 18);
            this.RAdminLabel.TabIndex = 4;
            this.RAdminLabel.Text = "Вкажіть причину";
            // 
            // ReloadReasonBox
            // 
            this.ReloadReasonBox.FormattingEnabled = true;
            this.ReloadReasonBox.Items.AddRange(new object[] {
            "Профілактика",
            "Оновлення",
            "Технічні проблеми",
            "Інше"});
            this.ReloadReasonBox.Location = new System.Drawing.Point(7, 337);
            this.ReloadReasonBox.Name = "ReloadReasonBox";
            this.ReloadReasonBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ReloadReasonBox.Size = new System.Drawing.Size(155, 21);
            this.ReloadReasonBox.TabIndex = 1;
            // 
            // MainMenuDataGrid
            // 
            this.MainMenuDataGrid.AllowUserToAddRows = false;
            this.MainMenuDataGrid.AllowUserToDeleteRows = false;
            this.MainMenuDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainMenuDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Date,
            this.User,
            this.Reason});
            this.MainMenuDataGrid.Location = new System.Drawing.Point(290, 6);
            this.MainMenuDataGrid.Name = "MainMenuDataGrid";
            this.MainMenuDataGrid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MainMenuDataGrid.RowHeadersVisible = false;
            this.MainMenuDataGrid.Size = new System.Drawing.Size(577, 328);
            this.MainMenuDataGrid.TabIndex = 3;
            this.MainMenuDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.FillWeight = 10F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Date.FillWeight = 20F;
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // User
            // 
            this.User.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.User.FillWeight = 30F;
            this.User.HeaderText = "User";
            this.User.Name = "User";
            this.User.ReadOnly = true;
            // 
            // Reason
            // 
            this.Reason.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Reason.FillWeight = 30F;
            this.Reason.HeaderText = "Reason";
            this.Reason.Name = "Reason";
            this.Reason.Width = 69;
            // 
            // ReloadButton
            // 
            this.ReloadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)), true);
            this.ReloadButton.Location = new System.Drawing.Point(7, 389);
            this.ReloadButton.Name = "ReloadButton";
            this.ReloadButton.Size = new System.Drawing.Size(155, 35);
            this.ReloadButton.TabIndex = 2;
            this.ReloadButton.Text = "Перезавантажити";
            this.ReloadButton.UseVisualStyleBackColor = true;
            this.ReloadButton.Click += new System.EventHandler(this.ReloadButton_Click);
            // 
            // DisplayName
            // 
            this.DisplayName.AutoSize = true;
            this.DisplayName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)), true);
            this.DisplayName.Location = new System.Drawing.Point(7, 3);
            this.DisplayName.Name = "DisplayName";
            this.DisplayName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DisplayName.Size = new System.Drawing.Size(87, 19);
            this.DisplayName.TabIndex = 1;
            this.DisplayName.Text = "NickName";
            this.DisplayName.Click += new System.EventHandler(this.label2_Click);
            // 
            // SearchTab
            // 
            this.SearchTab.Controls.Add(this.label3);
            this.SearchTab.Controls.Add(this.label2);
            this.SearchTab.Controls.Add(this.label1);
            this.SearchTab.Controls.Add(this.ProOnlyBox);
            this.SearchTab.Controls.Add(this.EndDataTextBox);
            this.SearchTab.Controls.Add(this.StartDataTextBox);
            this.SearchTab.Controls.Add(this.button5);
            this.SearchTab.Controls.Add(this.button4);
            this.SearchTab.Controls.Add(this.SearchGridView);
            this.SearchTab.Location = new System.Drawing.Point(4, 24);
            this.SearchTab.Name = "SearchTab";
            this.SearchTab.Size = new System.Drawing.Size(876, 433);
            this.SearchTab.TabIndex = 2;
            this.SearchTab.Text = "Пошук";
            this.SearchTab.UseVisualStyleBackColor = true;
            this.SearchTab.Click += new System.EventHandler(this.Search_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(481, 378);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(195, 47);
            this.button5.TabIndex = 6;
            this.button5.Text = "Показати нічні перезапуски";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(8, 313);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(158, 47);
            this.button4.TabIndex = 5;
            this.button4.Text = "Знайти";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // SearchGridView
            // 
            this.SearchGridView.AllowUserToAddRows = false;
            this.SearchGridView.AllowUserToDeleteRows = false;
            this.SearchGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1});
            this.SearchGridView.Location = new System.Drawing.Point(291, 3);
            this.SearchGridView.Name = "SearchGridView";
            this.SearchGridView.RowHeadersVisible = false;
            this.SearchGridView.Size = new System.Drawing.Size(577, 357);
            this.SearchGridView.TabIndex = 4;
            this.SearchGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SearchGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.FillWeight = 10F;
            this.dataGridViewTextBoxColumn4.HeaderText = "ID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.FillWeight = 20F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Date";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.FillWeight = 30F;
            this.dataGridViewTextBoxColumn2.HeaderText = "User";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn1.FillWeight = 30F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Reason";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 69;
            // 
            // StartDataTextBox
            // 
            this.StartDataTextBox.Location = new System.Drawing.Point(8, 136);
            this.StartDataTextBox.Name = "StartDataTextBox";
            this.StartDataTextBox.Size = new System.Drawing.Size(158, 20);
            this.StartDataTextBox.TabIndex = 7;
            // 
            // EndDataTextBox
            // 
            this.EndDataTextBox.Location = new System.Drawing.Point(8, 215);
            this.EndDataTextBox.Name = "EndDataTextBox";
            this.EndDataTextBox.Size = new System.Drawing.Size(158, 20);
            this.EndDataTextBox.TabIndex = 8;
            this.EndDataTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // ProOnlyBox
            // 
            this.ProOnlyBox.AutoSize = true;
            this.ProOnlyBox.Location = new System.Drawing.Point(8, 278);
            this.ProOnlyBox.Name = "ProOnlyBox";
            this.ProOnlyBox.Size = new System.Drawing.Size(162, 17);
            this.ProOnlyBox.TabIndex = 9;
            this.ProOnlyBox.Text = "Тільки через профілактику";
            this.ProOnlyBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)), true);
            this.label1.Location = new System.Drawing.Point(8, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Початкова дата:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)), true);
            this.label2.Location = new System.Drawing.Point(8, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Кінцева дата:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)), true);
            this.label3.Location = new System.Drawing.Point(52, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "ПОШУК";
            // 
            // ServerWatcherform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.tabControl1);
            this.Name = "ServerWatcherform";
            this.Text = "ServerWatcher";
            this.tabControl1.ResumeLayout(false);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainMenuDataGrid)).EndInit();
            this.SearchTab.ResumeLayout(false);
            this.SearchTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage MainMenu;
        private System.Windows.Forms.TabPage SearchTab;
        private System.Windows.Forms.Label DisplayName;
        private System.Windows.Forms.Button ReloadButton;
        private System.Windows.Forms.DataGridView MainMenuDataGrid;
        private System.Windows.Forms.ComboBox ReloadReasonBox;
        private System.Windows.Forms.Label ReloadMenuAdminLabel;
        private System.Windows.Forms.Label RAdminLabel;
        private System.Windows.Forms.Button Deletebutton;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label LastReloadLabel;
        private System.Windows.Forms.Label LastIdLabel;
        private System.Windows.Forms.Label ReasonLabel;
        private System.Windows.Forms.DataGridView SearchGridView;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reason;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ProOnlyBox;
        private System.Windows.Forms.TextBox EndDataTextBox;
        private System.Windows.Forms.TextBox StartDataTextBox;
        private System.Windows.Forms.Label label3;
    }
}

