﻿namespace BeliveOrNotBelive
{
    partial class MainMenu
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
            System.Windows.Forms.ToolStripMenuItem Menu_Open;
            System.Windows.Forms.ToolStripMenuItem Menu_SaveAs;
            System.Windows.Forms.ToolStripMenuItem Menu_Exit;
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Add_But = new System.Windows.Forms.Button();
            this.Del_But = new System.Windows.Forms.Button();
            this.MainMenu_strip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_PlayGame = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Create = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Add2_But = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.издевательствоНадСтудентамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Look = new System.Windows.Forms.ToolStripMenuItem();
            Menu_Open = new System.Windows.Forms.ToolStripMenuItem();
            Menu_SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            Menu_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu_strip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu_Open
            // 
            Menu_Open.Name = "Menu_Open";
            Menu_Open.Size = new System.Drawing.Size(153, 22);
            Menu_Open.Text = "Открыть";
            Menu_Open.Click += new System.EventHandler(this.Menu_Open_Click);
            // 
            // Menu_SaveAs
            // 
            Menu_SaveAs.Name = "Menu_SaveAs";
            Menu_SaveAs.Size = new System.Drawing.Size(153, 22);
            Menu_SaveAs.Text = "Сохранить как";
            Menu_SaveAs.Click += new System.EventHandler(this.Menu_SaveAs_Click);
            // 
            // Menu_Exit
            // 
            Menu_Exit.Name = "Menu_Exit";
            Menu_Exit.Size = new System.Drawing.Size(153, 22);
            Menu_Exit.Text = "Выход";
            Menu_Exit.Click += new System.EventHandler(this.Menu_Exit_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(70, 56);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(630, 323);
            this.textBox1.TabIndex = 0;
            // 
            // Add_But
            // 
            this.Add_But.Location = new System.Drawing.Point(82, 420);
            this.Add_But.Name = "Add_But";
            this.Add_But.Size = new System.Drawing.Size(75, 23);
            this.Add_But.TabIndex = 1;
            this.Add_But.Text = "Добавить";
            this.Add_But.UseVisualStyleBackColor = true;
            this.Add_But.Click += new System.EventHandler(this.Add_But_Click);
            // 
            // Del_But
            // 
            this.Del_But.Location = new System.Drawing.Point(196, 420);
            this.Del_But.Name = "Del_But";
            this.Del_But.Size = new System.Drawing.Size(75, 23);
            this.Del_But.TabIndex = 2;
            this.Del_But.Text = "Удалить";
            this.Del_But.UseVisualStyleBackColor = true;
            this.Del_But.Click += new System.EventHandler(this.Del_But_Click);
            // 
            // MainMenu_strip
            // 
            this.MainMenu_strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.издевательствоНадСтудентамиToolStripMenuItem});
            this.MainMenu_strip.Location = new System.Drawing.Point(0, 0);
            this.MainMenu_strip.Name = "MainMenu_strip";
            this.MainMenu_strip.Size = new System.Drawing.Size(811, 24);
            this.MainMenu_strip.TabIndex = 4;
            this.MainMenu_strip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            Menu_Open,
            this.Menu_PlayGame,
            this.Menu_Create,
            this.Menu_Save,
            Menu_SaveAs,
            this.toolStripMenuItem1,
            Menu_Exit});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // Menu_PlayGame
            // 
            this.Menu_PlayGame.Name = "Menu_PlayGame";
            this.Menu_PlayGame.Size = new System.Drawing.Size(153, 22);
            this.Menu_PlayGame.Text = "Играть";
            this.Menu_PlayGame.Click += new System.EventHandler(this.Menu_PlayGame_Click);
            // 
            // Menu_Create
            // 
            this.Menu_Create.Name = "Menu_Create";
            this.Menu_Create.Size = new System.Drawing.Size(153, 22);
            this.Menu_Create.Text = "Создать";
            this.Menu_Create.Click += new System.EventHandler(this.Menu_Create_Click);
            // 
            // Menu_Save
            // 
            this.Menu_Save.Name = "Menu_Save";
            this.Menu_Save.Size = new System.Drawing.Size(153, 22);
            this.Menu_Save.Text = "Сохранить";
            this.Menu_Save.Click += new System.EventHandler(this.Menu_Save_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(150, 6);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(46, 29);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(462, 20);
            this.textBox2.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Да",
            "Нет"});
            this.comboBox1.Location = new System.Drawing.Point(46, 75);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // Add2_But
            // 
            this.Add2_But.Location = new System.Drawing.Point(46, 103);
            this.Add2_But.Name = "Add2_But";
            this.Add2_But.Size = new System.Drawing.Size(75, 23);
            this.Add2_But.TabIndex = 7;
            this.Add2_But.Text = "Добавить";
            this.Add2_But.UseVisualStyleBackColor = true;
            this.Add2_But.Click += new System.EventHandler(this.Add2_But_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(46, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Текст вопроса";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(46, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ответ";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(292, 422);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 403);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Индекс для удаления строки";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Add2_But);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Location = new System.Drawing.Point(36, 448);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(549, 138);
            this.panel1.TabIndex = 12;
            this.panel1.Visible = false;
            // 
            // издевательствоНадСтудентамиToolStripMenuItem
            // 
            this.издевательствоНадСтудентамиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Look});
            this.издевательствоНадСтудентамиToolStripMenuItem.Name = "издевательствоНадСтудентамиToolStripMenuItem";
            this.издевательствоНадСтудентамиToolStripMenuItem.Size = new System.Drawing.Size(193, 20);
            this.издевательствоНадСтудентамиToolStripMenuItem.Text = "Издевательство над студентами";
            // 
            // Menu_Look
            // 
            this.Menu_Look.Name = "Menu_Look";
            this.Menu_Look.Size = new System.Drawing.Size(200, 22);
            this.Menu_Look.Text = "Вы только посмотрите";
            this.Menu_Look.Click += new System.EventHandler(this.Menu_Look_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 589);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.Del_But);
            this.Controls.Add(this.Add_But);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.MainMenu_strip);
            this.MainMenuStrip = this.MainMenu_strip;
            this.Name = "MainMenu";
            this.Text = "Редактор вопросов";
            this.MainMenu_strip.ResumeLayout(false);
            this.MainMenu_strip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Add_But;
        private System.Windows.Forms.Button Del_But;
        private System.Windows.Forms.MenuStrip MainMenu_strip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem Menu_Save;
        private System.Windows.Forms.ToolStripMenuItem Menu_Create;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Add2_But;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem Menu_PlayGame;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem издевательствоНадСтудентамиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Menu_Look;
    }
}

