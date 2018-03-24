namespace WF_Eatstuff
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbDrinkWater = new System.Windows.Forms.RadioButton();
            this.rbDrinkBlacktea = new System.Windows.Forms.RadioButton();
            this.rbDrinkGreentea = new System.Windows.Forms.RadioButton();
            this.rbDrinkEspresso = new System.Windows.Forms.RadioButton();
            this.lblDrinkEspresso = new System.Windows.Forms.Label();
            this.lblDrinkGreentea = new System.Windows.Forms.Label();
            this.lblDrinkBlacktea = new System.Windows.Forms.Label();
            this.lblDrinkWater = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblSugar = new System.Windows.Forms.Label();
            this.lblDrinkSyrup = new System.Windows.Forms.Label();
            this.lblDrinkMilk = new System.Windows.Forms.Label();
            this.lblDrinkSugar = new System.Windows.Forms.Label();
            this.numDrinkSugarCount = new System.Windows.Forms.NumericUpDown();
            this.chboxDrinkSyrup = new System.Windows.Forms.CheckBox();
            this.chboxDrinkMilk = new System.Windows.Forms.CheckBox();
            this.chboxComplex = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblComplex = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbFoodBread = new System.Windows.Forms.RadioButton();
            this.rbFoodBun = new System.Windows.Forms.RadioButton();
            this.rbFoodCookie = new System.Windows.Forms.RadioButton();
            this.rbFoodCrisps = new System.Windows.Forms.RadioButton();
            this.lblFoodCrisps = new System.Windows.Forms.Label();
            this.lblFoodCookie = new System.Windows.Forms.Label();
            this.lblFoodBun = new System.Windows.Forms.Label();
            this.lblFoodBread = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblFoodJam = new System.Windows.Forms.Label();
            this.lblFoodCheese = new System.Windows.Forms.Label();
            this.lblFoodHam = new System.Windows.Forms.Label();
            this.chboxFoodJam = new System.Windows.Forms.CheckBox();
            this.chboxFoodCheese = new System.Windows.Forms.CheckBox();
            this.chboxFoodHam = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblFinalPrice = new System.Windows.Forms.Label();
            this.btnGiveOrder = new System.Windows.Forms.Button();
            this.btnRenewPrice = new System.Windows.Forms.Button();
            this.test = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDrinkSugarCount)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDrinkWater);
            this.groupBox1.Controls.Add(this.rbDrinkBlacktea);
            this.groupBox1.Controls.Add(this.rbDrinkGreentea);
            this.groupBox1.Controls.Add(this.rbDrinkEspresso);
            this.groupBox1.Controls.Add(this.lblDrinkEspresso);
            this.groupBox1.Controls.Add(this.lblDrinkGreentea);
            this.groupBox1.Controls.Add(this.lblDrinkBlacktea);
            this.groupBox1.Controls.Add(this.lblDrinkWater);
            this.groupBox1.Location = new System.Drawing.Point(6, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 120);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип";
            // 
            // rbDrinkWater
            // 
            this.rbDrinkWater.AutoSize = true;
            this.rbDrinkWater.Checked = true;
            this.rbDrinkWater.Location = new System.Drawing.Point(6, 19);
            this.rbDrinkWater.Name = "rbDrinkWater";
            this.rbDrinkWater.Size = new System.Drawing.Size(50, 17);
            this.rbDrinkWater.TabIndex = 6;
            this.rbDrinkWater.TabStop = true;
            this.rbDrinkWater.Tag = "Вода";
            this.rbDrinkWater.Text = "Вода";
            this.rbDrinkWater.UseVisualStyleBackColor = true;
            this.rbDrinkWater.CheckedChanged += new System.EventHandler(this.rbDrinkWater_CheckedChanged);
            // 
            // rbDrinkBlacktea
            // 
            this.rbDrinkBlacktea.AutoSize = true;
            this.rbDrinkBlacktea.Location = new System.Drawing.Point(6, 43);
            this.rbDrinkBlacktea.Name = "rbDrinkBlacktea";
            this.rbDrinkBlacktea.Size = new System.Drawing.Size(85, 17);
            this.rbDrinkBlacktea.TabIndex = 7;
            this.rbDrinkBlacktea.TabStop = true;
            this.rbDrinkBlacktea.Tag = "Чай черный";
            this.rbDrinkBlacktea.Text = "Чай черный";
            this.rbDrinkBlacktea.UseVisualStyleBackColor = true;
            this.rbDrinkBlacktea.CheckedChanged += new System.EventHandler(this.rbDrinkBlacktea_CheckedChanged);
            // 
            // rbDrinkGreentea
            // 
            this.rbDrinkGreentea.AutoSize = true;
            this.rbDrinkGreentea.Location = new System.Drawing.Point(6, 67);
            this.rbDrinkGreentea.Name = "rbDrinkGreentea";
            this.rbDrinkGreentea.Size = new System.Drawing.Size(92, 17);
            this.rbDrinkGreentea.TabIndex = 8;
            this.rbDrinkGreentea.TabStop = true;
            this.rbDrinkGreentea.Tag = "Чай зеленый";
            this.rbDrinkGreentea.Text = "Чай зеленый";
            this.rbDrinkGreentea.UseVisualStyleBackColor = true;
            this.rbDrinkGreentea.CheckedChanged += new System.EventHandler(this.rbDrinkGreentea_CheckedChanged);
            // 
            // rbDrinkEspresso
            // 
            this.rbDrinkEspresso.AutoSize = true;
            this.rbDrinkEspresso.Location = new System.Drawing.Point(6, 91);
            this.rbDrinkEspresso.Name = "rbDrinkEspresso";
            this.rbDrinkEspresso.Size = new System.Drawing.Size(74, 17);
            this.rbDrinkEspresso.TabIndex = 9;
            this.rbDrinkEspresso.TabStop = true;
            this.rbDrinkEspresso.Tag = "Эспрессо";
            this.rbDrinkEspresso.Text = "Эспрессо";
            this.rbDrinkEspresso.UseVisualStyleBackColor = true;
            this.rbDrinkEspresso.CheckedChanged += new System.EventHandler(this.rbDrinkEspresso_CheckedChanged);
            // 
            // lblDrinkEspresso
            // 
            this.lblDrinkEspresso.AutoSize = true;
            this.lblDrinkEspresso.Location = new System.Drawing.Point(130, 91);
            this.lblDrinkEspresso.Name = "lblDrinkEspresso";
            this.lblDrinkEspresso.Size = new System.Drawing.Size(42, 13);
            this.lblDrinkEspresso.TabIndex = 15;
            this.lblDrinkEspresso.Text = "50 руб.";
            // 
            // lblDrinkGreentea
            // 
            this.lblDrinkGreentea.AutoSize = true;
            this.lblDrinkGreentea.Location = new System.Drawing.Point(130, 67);
            this.lblDrinkGreentea.Name = "lblDrinkGreentea";
            this.lblDrinkGreentea.Size = new System.Drawing.Size(42, 13);
            this.lblDrinkGreentea.TabIndex = 14;
            this.lblDrinkGreentea.Text = "25 руб.";
            // 
            // lblDrinkBlacktea
            // 
            this.lblDrinkBlacktea.AutoSize = true;
            this.lblDrinkBlacktea.Location = new System.Drawing.Point(130, 43);
            this.lblDrinkBlacktea.Name = "lblDrinkBlacktea";
            this.lblDrinkBlacktea.Size = new System.Drawing.Size(42, 13);
            this.lblDrinkBlacktea.TabIndex = 13;
            this.lblDrinkBlacktea.Text = "25 руб.";
            // 
            // lblDrinkWater
            // 
            this.lblDrinkWater.AutoSize = true;
            this.lblDrinkWater.Location = new System.Drawing.Point(130, 19);
            this.lblDrinkWater.Name = "lblDrinkWater";
            this.lblDrinkWater.Size = new System.Drawing.Size(42, 13);
            this.lblDrinkWater.TabIndex = 12;
            this.lblDrinkWater.Text = "20 руб.";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblSugar);
            this.groupBox3.Controls.Add(this.lblDrinkSyrup);
            this.groupBox3.Controls.Add(this.lblDrinkMilk);
            this.groupBox3.Controls.Add(this.lblDrinkSugar);
            this.groupBox3.Controls.Add(this.numDrinkSugarCount);
            this.groupBox3.Controls.Add(this.chboxDrinkSyrup);
            this.groupBox3.Controls.Add(this.chboxDrinkMilk);
            this.groupBox3.Location = new System.Drawing.Point(6, 145);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(182, 91);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Добавки";
            // 
            // lblSugar
            // 
            this.lblSugar.AutoSize = true;
            this.lblSugar.Location = new System.Drawing.Point(40, 22);
            this.lblSugar.Name = "lblSugar";
            this.lblSugar.Size = new System.Drawing.Size(37, 13);
            this.lblSugar.TabIndex = 18;
            this.lblSugar.Text = "Сахар";
            // 
            // lblDrinkSyrup
            // 
            this.lblDrinkSyrup.AutoSize = true;
            this.lblDrinkSyrup.Location = new System.Drawing.Point(130, 70);
            this.lblDrinkSyrup.Name = "lblDrinkSyrup";
            this.lblDrinkSyrup.Size = new System.Drawing.Size(36, 13);
            this.lblDrinkSyrup.TabIndex = 17;
            this.lblDrinkSyrup.Text = "5 руб.";
            // 
            // lblDrinkMilk
            // 
            this.lblDrinkMilk.AutoSize = true;
            this.lblDrinkMilk.Location = new System.Drawing.Point(129, 46);
            this.lblDrinkMilk.Name = "lblDrinkMilk";
            this.lblDrinkMilk.Size = new System.Drawing.Size(42, 13);
            this.lblDrinkMilk.TabIndex = 16;
            this.lblDrinkMilk.Text = "10 руб.";
            // 
            // lblDrinkSugar
            // 
            this.lblDrinkSugar.AutoSize = true;
            this.lblDrinkSugar.Location = new System.Drawing.Point(130, 22);
            this.lblDrinkSugar.Name = "lblDrinkSugar";
            this.lblDrinkSugar.Size = new System.Drawing.Size(36, 13);
            this.lblDrinkSugar.TabIndex = 15;
            this.lblDrinkSugar.Text = "3 руб.";
            // 
            // numDrinkSugarCount
            // 
            this.numDrinkSugarCount.Location = new System.Drawing.Point(7, 17);
            this.numDrinkSugarCount.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numDrinkSugarCount.Name = "numDrinkSugarCount";
            this.numDrinkSugarCount.Size = new System.Drawing.Size(29, 20);
            this.numDrinkSugarCount.TabIndex = 3;
            this.numDrinkSugarCount.Tag = "Сахар";
            this.numDrinkSugarCount.ValueChanged += new System.EventHandler(this.numDrinkSugarCount_ValueChanged);
            // 
            // chboxDrinkSyrup
            // 
            this.chboxDrinkSyrup.AutoSize = true;
            this.chboxDrinkSyrup.Location = new System.Drawing.Point(7, 68);
            this.chboxDrinkSyrup.Name = "chboxDrinkSyrup";
            this.chboxDrinkSyrup.Size = new System.Drawing.Size(57, 17);
            this.chboxDrinkSyrup.TabIndex = 2;
            this.chboxDrinkSyrup.Tag = "Сироп";
            this.chboxDrinkSyrup.Text = "Сироп";
            this.chboxDrinkSyrup.UseVisualStyleBackColor = true;
            this.chboxDrinkSyrup.CheckedChanged += new System.EventHandler(this.chboxDrinkSyrup_CheckedChanged);
            // 
            // chboxDrinkMilk
            // 
            this.chboxDrinkMilk.AutoSize = true;
            this.chboxDrinkMilk.Location = new System.Drawing.Point(7, 44);
            this.chboxDrinkMilk.Name = "chboxDrinkMilk";
            this.chboxDrinkMilk.Size = new System.Drawing.Size(65, 17);
            this.chboxDrinkMilk.TabIndex = 1;
            this.chboxDrinkMilk.Tag = "Молоко";
            this.chboxDrinkMilk.Text = "Молоко";
            this.chboxDrinkMilk.UseVisualStyleBackColor = true;
            this.chboxDrinkMilk.CheckedChanged += new System.EventHandler(this.chboxDrinkMilk_CheckedChanged);
            // 
            // chboxComplex
            // 
            this.chboxComplex.AutoSize = true;
            this.chboxComplex.Location = new System.Drawing.Point(24, 23);
            this.chboxComplex.Name = "chboxComplex";
            this.chboxComplex.Size = new System.Drawing.Size(246, 30);
            this.chboxComplex.TabIndex = 6;
            this.chboxComplex.Tag = "Комплекс";
            this.chboxComplex.Text = "Комплекс (один напиток с любой добавкой\r\nи один снэк с любой добавкой)";
            this.chboxComplex.UseVisualStyleBackColor = true;
            this.chboxComplex.CheckedChanged += new System.EventHandler(this.chboxComplex_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox1);
            this.groupBox5.Controls.Add(this.groupBox3);
            this.groupBox5.Location = new System.Drawing.Point(18, 68);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(195, 244);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Напитки";
            // 
            // lblComplex
            // 
            this.lblComplex.AutoSize = true;
            this.lblComplex.Location = new System.Drawing.Point(295, 31);
            this.lblComplex.Name = "lblComplex";
            this.lblComplex.Size = new System.Drawing.Size(42, 13);
            this.lblComplex.TabIndex = 8;
            this.lblComplex.Text = "90 руб.";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Location = new System.Drawing.Point(229, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(195, 244);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Снэки";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbFoodBread);
            this.groupBox4.Controls.Add(this.rbFoodBun);
            this.groupBox4.Controls.Add(this.rbFoodCookie);
            this.groupBox4.Controls.Add(this.rbFoodCrisps);
            this.groupBox4.Controls.Add(this.lblFoodCrisps);
            this.groupBox4.Controls.Add(this.lblFoodCookie);
            this.groupBox4.Controls.Add(this.lblFoodBun);
            this.groupBox4.Controls.Add(this.lblFoodBread);
            this.groupBox4.Location = new System.Drawing.Point(6, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(182, 120);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Тип";
            // 
            // rbFoodBread
            // 
            this.rbFoodBread.AutoSize = true;
            this.rbFoodBread.Checked = true;
            this.rbFoodBread.Location = new System.Drawing.Point(6, 19);
            this.rbFoodBread.Name = "rbFoodBread";
            this.rbFoodBread.Size = new System.Drawing.Size(50, 17);
            this.rbFoodBread.TabIndex = 6;
            this.rbFoodBread.TabStop = true;
            this.rbFoodBread.Tag = "Хлеб";
            this.rbFoodBread.Text = "Хлеб";
            this.rbFoodBread.UseVisualStyleBackColor = true;
            this.rbFoodBread.CheckedChanged += new System.EventHandler(this.rbFoodBread_CheckedChanged);
            // 
            // rbFoodBun
            // 
            this.rbFoodBun.AutoSize = true;
            this.rbFoodBun.Location = new System.Drawing.Point(6, 43);
            this.rbFoodBun.Name = "rbFoodBun";
            this.rbFoodBun.Size = new System.Drawing.Size(66, 17);
            this.rbFoodBun.TabIndex = 7;
            this.rbFoodBun.TabStop = true;
            this.rbFoodBun.Tag = "Булочка";
            this.rbFoodBun.Text = "Булочка";
            this.rbFoodBun.UseVisualStyleBackColor = true;
            this.rbFoodBun.CheckedChanged += new System.EventHandler(this.rbFoodBun_CheckedChanged);
            // 
            // rbFoodCookie
            // 
            this.rbFoodCookie.AutoSize = true;
            this.rbFoodCookie.Location = new System.Drawing.Point(6, 67);
            this.rbFoodCookie.Name = "rbFoodCookie";
            this.rbFoodCookie.Size = new System.Drawing.Size(68, 17);
            this.rbFoodCookie.TabIndex = 8;
            this.rbFoodCookie.TabStop = true;
            this.rbFoodCookie.Tag = "Печенье";
            this.rbFoodCookie.Text = "Печенье";
            this.rbFoodCookie.UseVisualStyleBackColor = true;
            this.rbFoodCookie.CheckedChanged += new System.EventHandler(this.rbFoodCookie_CheckedChanged);
            // 
            // rbFoodCrisps
            // 
            this.rbFoodCrisps.AutoSize = true;
            this.rbFoodCrisps.Location = new System.Drawing.Point(6, 91);
            this.rbFoodCrisps.Name = "rbFoodCrisps";
            this.rbFoodCrisps.Size = new System.Drawing.Size(59, 17);
            this.rbFoodCrisps.TabIndex = 9;
            this.rbFoodCrisps.TabStop = true;
            this.rbFoodCrisps.Tag = "Чипсы";
            this.rbFoodCrisps.Text = "Чипсы";
            this.rbFoodCrisps.UseVisualStyleBackColor = true;
            this.rbFoodCrisps.CheckedChanged += new System.EventHandler(this.rbFoodCrisps_CheckedChanged);
            // 
            // lblFoodCrisps
            // 
            this.lblFoodCrisps.AutoSize = true;
            this.lblFoodCrisps.Location = new System.Drawing.Point(130, 91);
            this.lblFoodCrisps.Name = "lblFoodCrisps";
            this.lblFoodCrisps.Size = new System.Drawing.Size(42, 13);
            this.lblFoodCrisps.TabIndex = 15;
            this.lblFoodCrisps.Text = "34 руб.";
            // 
            // lblFoodCookie
            // 
            this.lblFoodCookie.AutoSize = true;
            this.lblFoodCookie.Location = new System.Drawing.Point(130, 67);
            this.lblFoodCookie.Name = "lblFoodCookie";
            this.lblFoodCookie.Size = new System.Drawing.Size(42, 13);
            this.lblFoodCookie.TabIndex = 14;
            this.lblFoodCookie.Text = "29 руб.";
            // 
            // lblFoodBun
            // 
            this.lblFoodBun.AutoSize = true;
            this.lblFoodBun.Location = new System.Drawing.Point(130, 43);
            this.lblFoodBun.Name = "lblFoodBun";
            this.lblFoodBun.Size = new System.Drawing.Size(42, 13);
            this.lblFoodBun.TabIndex = 13;
            this.lblFoodBun.Text = "15 руб.";
            // 
            // lblFoodBread
            // 
            this.lblFoodBread.AutoSize = true;
            this.lblFoodBread.Location = new System.Drawing.Point(130, 19);
            this.lblFoodBread.Name = "lblFoodBread";
            this.lblFoodBread.Size = new System.Drawing.Size(42, 13);
            this.lblFoodBread.TabIndex = 12;
            this.lblFoodBread.Text = "10 руб.";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lblFoodJam);
            this.groupBox6.Controls.Add(this.lblFoodCheese);
            this.groupBox6.Controls.Add(this.lblFoodHam);
            this.groupBox6.Controls.Add(this.chboxFoodJam);
            this.groupBox6.Controls.Add(this.chboxFoodCheese);
            this.groupBox6.Controls.Add(this.chboxFoodHam);
            this.groupBox6.Location = new System.Drawing.Point(6, 145);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(182, 91);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Добавки";
            // 
            // lblFoodJam
            // 
            this.lblFoodJam.AutoSize = true;
            this.lblFoodJam.Location = new System.Drawing.Point(130, 70);
            this.lblFoodJam.Name = "lblFoodJam";
            this.lblFoodJam.Size = new System.Drawing.Size(36, 13);
            this.lblFoodJam.TabIndex = 17;
            this.lblFoodJam.Text = "7 руб.";
            // 
            // lblFoodCheese
            // 
            this.lblFoodCheese.AutoSize = true;
            this.lblFoodCheese.Location = new System.Drawing.Point(128, 46);
            this.lblFoodCheese.Name = "lblFoodCheese";
            this.lblFoodCheese.Size = new System.Drawing.Size(42, 13);
            this.lblFoodCheese.TabIndex = 16;
            this.lblFoodCheese.Text = "10 руб.";
            // 
            // lblFoodHam
            // 
            this.lblFoodHam.AutoSize = true;
            this.lblFoodHam.Location = new System.Drawing.Point(130, 22);
            this.lblFoodHam.Name = "lblFoodHam";
            this.lblFoodHam.Size = new System.Drawing.Size(42, 13);
            this.lblFoodHam.TabIndex = 15;
            this.lblFoodHam.Text = "15 руб.";
            // 
            // chboxFoodJam
            // 
            this.chboxFoodJam.AutoSize = true;
            this.chboxFoodJam.Location = new System.Drawing.Point(7, 68);
            this.chboxFoodJam.Name = "chboxFoodJam";
            this.chboxFoodJam.Size = new System.Drawing.Size(57, 17);
            this.chboxFoodJam.TabIndex = 2;
            this.chboxFoodJam.Tag = "Джем";
            this.chboxFoodJam.Text = "Джем";
            this.chboxFoodJam.UseVisualStyleBackColor = true;
            this.chboxFoodJam.CheckedChanged += new System.EventHandler(this.chboxFoodJam_CheckedChanged);
            // 
            // chboxFoodCheese
            // 
            this.chboxFoodCheese.AutoSize = true;
            this.chboxFoodCheese.Location = new System.Drawing.Point(7, 44);
            this.chboxFoodCheese.Name = "chboxFoodCheese";
            this.chboxFoodCheese.Size = new System.Drawing.Size(47, 17);
            this.chboxFoodCheese.TabIndex = 1;
            this.chboxFoodCheese.Tag = "Сыр";
            this.chboxFoodCheese.Text = "Сыр";
            this.chboxFoodCheese.UseVisualStyleBackColor = true;
            this.chboxFoodCheese.CheckedChanged += new System.EventHandler(this.chboxFoodCheese_CheckedChanged);
            // 
            // chboxFoodHam
            // 
            this.chboxFoodHam.AutoSize = true;
            this.chboxFoodHam.Location = new System.Drawing.Point(7, 20);
            this.chboxFoodHam.Name = "chboxFoodHam";
            this.chboxFoodHam.Size = new System.Drawing.Size(67, 17);
            this.chboxFoodHam.TabIndex = 0;
            this.chboxFoodHam.Tag = "Ветчина";
            this.chboxFoodHam.Text = "Ветчина";
            this.chboxFoodHam.UseVisualStyleBackColor = true;
            this.chboxFoodHam.CheckedChanged += new System.EventHandler(this.chboxFoodHam_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(57, 353);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Стоимость:";
            // 
            // lblFinalPrice
            // 
            this.lblFinalPrice.AutoSize = true;
            this.lblFinalPrice.Location = new System.Drawing.Point(154, 353);
            this.lblFinalPrice.Name = "lblFinalPrice";
            this.lblFinalPrice.Size = new System.Drawing.Size(36, 13);
            this.lblFinalPrice.TabIndex = 11;
            this.lblFinalPrice.Text = "0 руб.";
            // 
            // btnGiveOrder
            // 
            this.btnGiveOrder.Location = new System.Drawing.Point(235, 318);
            this.btnGiveOrder.Name = "btnGiveOrder";
            this.btnGiveOrder.Size = new System.Drawing.Size(96, 48);
            this.btnGiveOrder.TabIndex = 12;
            this.btnGiveOrder.Text = "Выдать заказ";
            this.btnGiveOrder.UseVisualStyleBackColor = true;
            this.btnGiveOrder.Click += new System.EventHandler(this.btnGiveOrder_Click);
            // 
            // btnRenewPrice
            // 
            this.btnRenewPrice.Location = new System.Drawing.Point(60, 318);
            this.btnRenewPrice.Name = "btnRenewPrice";
            this.btnRenewPrice.Size = new System.Drawing.Size(130, 23);
            this.btnRenewPrice.TabIndex = 13;
            this.btnRenewPrice.Text = "Посчитать стоимость";
            this.btnRenewPrice.UseVisualStyleBackColor = true;
            this.btnRenewPrice.Click += new System.EventHandler(this.btnRenewPrice_Click);
            // 
            // test
            // 
            this.test.AutoSize = true;
            this.test.Location = new System.Drawing.Point(39, 390);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(0, 13);
            this.test.TabIndex = 14;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 429);
            this.Controls.Add(this.test);
            this.Controls.Add(this.btnRenewPrice);
            this.Controls.Add(this.btnGiveOrder);
            this.Controls.Add(this.lblFinalPrice);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblComplex);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.chboxComplex);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Аппарат с едой";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDrinkSugarCount)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbDrinkWater;
        private System.Windows.Forms.RadioButton rbDrinkBlacktea;
        private System.Windows.Forms.RadioButton rbDrinkGreentea;
        private System.Windows.Forms.RadioButton rbDrinkEspresso;
        private System.Windows.Forms.Label lblDrinkEspresso;
        private System.Windows.Forms.Label lblDrinkGreentea;
        private System.Windows.Forms.Label lblDrinkBlacktea;
        private System.Windows.Forms.Label lblDrinkWater;
        private System.Windows.Forms.Label lblDrinkSyrup;
        private System.Windows.Forms.Label lblDrinkMilk;
        private System.Windows.Forms.Label lblDrinkSugar;
        private System.Windows.Forms.NumericUpDown numDrinkSugarCount;
        private System.Windows.Forms.CheckBox chboxDrinkSyrup;
        private System.Windows.Forms.CheckBox chboxDrinkMilk;
        private System.Windows.Forms.CheckBox chboxComplex;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblComplex;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblFoodCrisps;
        private System.Windows.Forms.Label lblFoodCookie;
        private System.Windows.Forms.Label lblFoodBun;
        private System.Windows.Forms.Label lblFoodBread;
        private System.Windows.Forms.RadioButton rbFoodBread;
        private System.Windows.Forms.RadioButton rbFoodBun;
        private System.Windows.Forms.RadioButton rbFoodCrisps;
        private System.Windows.Forms.RadioButton rbFoodCookie;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lblFoodJam;
        private System.Windows.Forms.Label lblFoodCheese;
        private System.Windows.Forms.Label lblFoodHam;
        private System.Windows.Forms.CheckBox chboxFoodJam;
        private System.Windows.Forms.CheckBox chboxFoodCheese;
        private System.Windows.Forms.CheckBox chboxFoodHam;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblFinalPrice;
        private System.Windows.Forms.Button btnGiveOrder;
        private System.Windows.Forms.Button btnRenewPrice;
        private System.Windows.Forms.Label test;
        private System.Windows.Forms.Label lblSugar;
    }
}

