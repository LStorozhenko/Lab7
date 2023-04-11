namespace Lab7
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.відкритиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зберегтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зберегтиЯкToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редагуванняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вирізатиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копіюватиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.шрифтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.налштуванняШрифтуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фонToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.налаштуванняФонуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.виділитиВсеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.копіюватиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.вирізатиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.виділитиВсеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.вирівнюванняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зліваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.посерединіToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.змінаКольоруШрифтуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.розміткаСторінкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поляToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.колонкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.абзацToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.міжрядковийІнтервалToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 24);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(800, 426);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.richTextBox1_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.редагуванняToolStripMenuItem,
            this.шрифтToolStripMenuItem,
            this.фонToolStripMenuItem,
            this.вирівнюванняToolStripMenuItem,
            this.розміткаСторінкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.відкритиToolStripMenuItem,
            this.зберегтиToolStripMenuItem,
            this.зберегтиЯкToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // відкритиToolStripMenuItem
            // 
            this.відкритиToolStripMenuItem.Name = "відкритиToolStripMenuItem";
            this.відкритиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.відкритиToolStripMenuItem.Text = "Відкрити";
            this.відкритиToolStripMenuItem.Click += new System.EventHandler(this.відкритиToolStripMenuItem_Click);
            // 
            // зберегтиToolStripMenuItem
            // 
            this.зберегтиToolStripMenuItem.Name = "зберегтиToolStripMenuItem";
            this.зберегтиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.зберегтиToolStripMenuItem.Text = "Зберегти";
            this.зберегтиToolStripMenuItem.Click += new System.EventHandler(this.зберегтиToolStripMenuItem_Click);
            // 
            // зберегтиЯкToolStripMenuItem
            // 
            this.зберегтиЯкToolStripMenuItem.Name = "зберегтиЯкToolStripMenuItem";
            this.зберегтиЯкToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.зберегтиЯкToolStripMenuItem.Text = "Зберегти як";
            this.зберегтиЯкToolStripMenuItem.Click += new System.EventHandler(this.зберегтиЯкToolStripMenuItem_Click);
            // 
            // редагуванняToolStripMenuItem
            // 
            this.редагуванняToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вирізатиToolStripMenuItem,
            this.копіюватиToolStripMenuItem,
            this.вставитиToolStripMenuItem,
            this.виділитиВсеToolStripMenuItem});
            this.редагуванняToolStripMenuItem.Name = "редагуванняToolStripMenuItem";
            this.редагуванняToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.редагуванняToolStripMenuItem.Text = "Редагування";
            // 
            // вирізатиToolStripMenuItem
            // 
            this.вирізатиToolStripMenuItem.Name = "вирізатиToolStripMenuItem";
            this.вирізатиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.вирізатиToolStripMenuItem.Text = "Вирізати";
            this.вирізатиToolStripMenuItem.Click += new System.EventHandler(this.вирізатиToolStripMenuItem_Click);
            // 
            // копіюватиToolStripMenuItem
            // 
            this.копіюватиToolStripMenuItem.Name = "копіюватиToolStripMenuItem";
            this.копіюватиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.копіюватиToolStripMenuItem.Text = "Копіювати";
            this.копіюватиToolStripMenuItem.Click += new System.EventHandler(this.копіюватиToolStripMenuItem_Click);
            // 
            // вставитиToolStripMenuItem
            // 
            this.вставитиToolStripMenuItem.Name = "вставитиToolStripMenuItem";
            this.вставитиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.вставитиToolStripMenuItem.Text = "Вставити";
            this.вставитиToolStripMenuItem.Click += new System.EventHandler(this.вставитиToolStripMenuItem_Click);
            // 
            // шрифтToolStripMenuItem
            // 
            this.шрифтToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.налштуванняШрифтуToolStripMenuItem,
            this.змінаКольоруШрифтуToolStripMenuItem,
            this.абзацToolStripMenuItem,
            this.міжрядковийІнтервалToolStripMenuItem});
            this.шрифтToolStripMenuItem.Name = "шрифтToolStripMenuItem";
            this.шрифтToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.шрифтToolStripMenuItem.Text = "Шрифт";
            // 
            // налштуванняШрифтуToolStripMenuItem
            // 
            this.налштуванняШрифтуToolStripMenuItem.Name = "налштуванняШрифтуToolStripMenuItem";
            this.налштуванняШрифтуToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.налштуванняШрифтуToolStripMenuItem.Text = "Налштування шрифту";
            this.налштуванняШрифтуToolStripMenuItem.Click += new System.EventHandler(this.налштуванняШрифтуToolStripMenuItem_Click);
            // 
            // фонToolStripMenuItem
            // 
            this.фонToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.налаштуванняФонуToolStripMenuItem});
            this.фонToolStripMenuItem.Name = "фонToolStripMenuItem";
            this.фонToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.фонToolStripMenuItem.Text = "Фон";
            // 
            // налаштуванняФонуToolStripMenuItem
            // 
            this.налаштуванняФонуToolStripMenuItem.Name = "налаштуванняФонуToolStripMenuItem";
            this.налаштуванняФонуToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.налаштуванняФонуToolStripMenuItem.Text = "Налаштування фону";
            this.налаштуванняФонуToolStripMenuItem.Click += new System.EventHandler(this.налаштуванняФонуToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // виділитиВсеToolStripMenuItem
            // 
            this.виділитиВсеToolStripMenuItem.Name = "виділитиВсеToolStripMenuItem";
            this.виділитиВсеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.виділитиВсеToolStripMenuItem.Text = "Виділити все";
            this.виділитиВсеToolStripMenuItem.Click += new System.EventHandler(this.виділитиВсеToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.копіюватиToolStripMenuItem1,
            this.вставитиToolStripMenuItem1,
            this.вирізатиToolStripMenuItem1,
            this.виділитиВсеToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(145, 92);
            // 
            // копіюватиToolStripMenuItem1
            // 
            this.копіюватиToolStripMenuItem1.Name = "копіюватиToolStripMenuItem1";
            this.копіюватиToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.копіюватиToolStripMenuItem1.Text = "Копіювати";
            this.копіюватиToolStripMenuItem1.Click += new System.EventHandler(this.копіюватиToolStripMenuItem1_Click);
            // 
            // вставитиToolStripMenuItem1
            // 
            this.вставитиToolStripMenuItem1.Name = "вставитиToolStripMenuItem1";
            this.вставитиToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.вставитиToolStripMenuItem1.Text = "Вставити";
            this.вставитиToolStripMenuItem1.Click += new System.EventHandler(this.вставитиToolStripMenuItem1_Click);
            // 
            // вирізатиToolStripMenuItem1
            // 
            this.вирізатиToolStripMenuItem1.Name = "вирізатиToolStripMenuItem1";
            this.вирізатиToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.вирізатиToolStripMenuItem1.Text = "Вирізати";
            this.вирізатиToolStripMenuItem1.Click += new System.EventHandler(this.вирізатиToolStripMenuItem1_Click);
            // 
            // виділитиВсеToolStripMenuItem1
            // 
            this.виділитиВсеToolStripMenuItem1.Name = "виділитиВсеToolStripMenuItem1";
            this.виділитиВсеToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.виділитиВсеToolStripMenuItem1.Text = "Виділити все";
            this.виділитиВсеToolStripMenuItem1.Click += new System.EventHandler(this.виділитиВсеToolStripMenuItem1_Click);
            // 
            // вирівнюванняToolStripMenuItem
            // 
            this.вирівнюванняToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.зліваToolStripMenuItem,
            this.посерединіToolStripMenuItem,
            this.справаToolStripMenuItem});
            this.вирівнюванняToolStripMenuItem.Name = "вирівнюванняToolStripMenuItem";
            this.вирівнюванняToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.вирівнюванняToolStripMenuItem.Text = "Вирівнювання";
            // 
            // зліваToolStripMenuItem
            // 
            this.зліваToolStripMenuItem.Name = "зліваToolStripMenuItem";
            this.зліваToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.зліваToolStripMenuItem.Text = "Зліва";
            this.зліваToolStripMenuItem.Click += new System.EventHandler(this.зліваToolStripMenuItem_Click);
            // 
            // посерединіToolStripMenuItem
            // 
            this.посерединіToolStripMenuItem.Name = "посерединіToolStripMenuItem";
            this.посерединіToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.посерединіToolStripMenuItem.Text = "Посередині";
            this.посерединіToolStripMenuItem.Click += new System.EventHandler(this.посерединіToolStripMenuItem_Click);
            // 
            // справаToolStripMenuItem
            // 
            this.справаToolStripMenuItem.Name = "справаToolStripMenuItem";
            this.справаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.справаToolStripMenuItem.Text = "Справа";
            this.справаToolStripMenuItem.Click += new System.EventHandler(this.справаToolStripMenuItem_Click);
            // 
            // змінаКольоруШрифтуToolStripMenuItem
            // 
            this.змінаКольоруШрифтуToolStripMenuItem.Name = "змінаКольоруШрифтуToolStripMenuItem";
            this.змінаКольоруШрифтуToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.змінаКольоруШрифтуToolStripMenuItem.Text = "Зміна кольору шрифту";
            this.змінаКольоруШрифтуToolStripMenuItem.Click += new System.EventHandler(this.змінаКольоруШрифтуToolStripMenuItem_Click);
            // 
            // розміткаСторінкиToolStripMenuItem
            // 
            this.розміткаСторінкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поляToolStripMenuItem,
            this.колонкиToolStripMenuItem});
            this.розміткаСторінкиToolStripMenuItem.Name = "розміткаСторінкиToolStripMenuItem";
            this.розміткаСторінкиToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.розміткаСторінкиToolStripMenuItem.Text = "Розмітка сторінки";
            // 
            // поляToolStripMenuItem
            // 
            this.поляToolStripMenuItem.Name = "поляToolStripMenuItem";
            this.поляToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.поляToolStripMenuItem.Text = "Налаштування сторінки";
            this.поляToolStripMenuItem.Click += new System.EventHandler(this.поляToolStripMenuItem_Click);
            // 
            // колонкиToolStripMenuItem
            // 
            this.колонкиToolStripMenuItem.Name = "колонкиToolStripMenuItem";
            this.колонкиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.колонкиToolStripMenuItem.Text = "Колонки";
            // 
            // абзацToolStripMenuItem
            // 
            this.абзацToolStripMenuItem.Name = "абзацToolStripMenuItem";
            this.абзацToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.абзацToolStripMenuItem.Text = "Абзац";
            this.абзацToolStripMenuItem.Click += new System.EventHandler(this.абзацToolStripMenuItem_Click);
            // 
            // міжрядковийІнтервалToolStripMenuItem
            // 
            this.міжрядковийІнтервалToolStripMenuItem.Name = "міжрядковийІнтервалToolStripMenuItem";
            this.міжрядковийІнтервалToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.міжрядковийІнтервалToolStripMenuItem.Text = "Міжрядковий інтервал";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Lab7Office";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem відкритиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зберегтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зберегтиЯкToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редагуванняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вирізатиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem копіюватиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставитиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem шрифтToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem налштуванняШрифтуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фонToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem налаштуванняФонуToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem виділитиВсеToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem копіюватиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem вставитиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem вирізатиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem виділитиВсеToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem вирівнюванняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зліваToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem посерединіToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem змінаКольоруШрифтуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem розміткаСторінкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поляToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem колонкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem абзацToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem міжрядковийІнтервалToolStripMenuItem;
    }
}

