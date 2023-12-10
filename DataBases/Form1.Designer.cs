namespace DataBases
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Kr = new System.Windows.Forms.TextBox();
            this.Kd = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.u = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.T1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.sigmaHP = new System.Windows.Forms.TextBox();
            this.Kbe = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Op = new System.Windows.Forms.ComboBox();
            this.Td = new System.Windows.Forms.ComboBox();
            this.Zv = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Shir = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Khb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Re = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Kbee = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Вспомогательный \r\nкоэффициент, Kd";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Вспомогательный \r\nкоэффициент, Kr";
            // 
            // Kr
            // 
            this.Kr.Location = new System.Drawing.Point(195, 99);
            this.Kr.Name = "Kr";
            this.Kr.ReadOnly = true;
            this.Kr.Size = new System.Drawing.Size(90, 20);
            this.Kr.TabIndex = 4;
            // 
            // Kd
            // 
            this.Kd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Kd.FormattingEnabled = true;
            this.Kd.Items.AddRange(new object[] {
            "1000",
            "870",
            "835"});
            this.Kd.Location = new System.Drawing.Point(195, 62);
            this.Kd.Name = "Kd";
            this.Kd.Size = new System.Drawing.Size(90, 21);
            this.Kd.TabIndex = 5;
            this.Kd.SelectedIndexChanged += new System.EventHandler(this.Kd_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Передаточное\r\nчисло передачи, u";
            // 
            // u
            // 
            this.u.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.u.FormattingEnabled = true;
            this.u.Items.AddRange(new object[] {
            "1",
            "1,25",
            "1,4",
            "1,6",
            "2",
            "2,5",
            "3,15",
            "4"});
            this.u.Location = new System.Drawing.Point(195, 198);
            this.u.Name = "u";
            this.u.Size = new System.Drawing.Size(90, 21);
            this.u.TabIndex = 7;
            this.u.SelectedIndexChanged += new System.EventHandler(this.u_SelectedIndexChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "Крутящий момент \r\nна шестерне, T1";
            // 
            // T1
            // 
            this.T1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.T1.FormattingEnabled = true;
            this.T1.Location = new System.Drawing.Point(195, 236);
            this.T1.Name = "T1";
            this.T1.Size = new System.Drawing.Size(90, 21);
            this.T1.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 26);
            this.label6.TabIndex = 10;
            this.label6.Text = "Допускаемое контактное\r\nнапряжение, sigmaHP";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 26);
            this.label7.TabIndex = 11;
            this.label7.Text = "Коэффициент ширины \r\nзубчатого венца, Kbe";
            // 
            // sigmaHP
            // 
            this.sigmaHP.Location = new System.Drawing.Point(194, 149);
            this.sigmaHP.Name = "sigmaHP";
            this.sigmaHP.Size = new System.Drawing.Size(90, 20);
            this.sigmaHP.TabIndex = 12;
            // 
            // Kbe
            // 
            this.Kbe.Location = new System.Drawing.Point(0, 0);
            this.Kbe.Name = "Kbe";
            this.Kbe.Size = new System.Drawing.Size(100, 20);
            this.Kbe.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(497, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 26);
            this.label9.TabIndex = 15;
            this.label9.Text = "Твёрдость рабочих\r\nповерхностей зубьев";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(634, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Тип зубьев";
            // 
            // Op
            // 
            this.Op.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Op.FormattingEnabled = true;
            this.Op.Items.AddRange(new object[] {
            "Шариковые",
            "Роликовые"});
            this.Op.Location = new System.Drawing.Point(369, 98);
            this.Op.Name = "Op";
            this.Op.Size = new System.Drawing.Size(90, 21);
            this.Op.TabIndex = 17;
            // 
            // Td
            // 
            this.Td.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Td.FormattingEnabled = true;
            this.Td.Items.AddRange(new object[] {
            "HB > 350",
            "HB =< 350"});
            this.Td.Location = new System.Drawing.Point(500, 98);
            this.Td.Name = "Td";
            this.Td.Size = new System.Drawing.Size(90, 21);
            this.Td.TabIndex = 18;
            // 
            // Zv
            // 
            this.Zv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Zv.FormattingEnabled = true;
            this.Zv.Items.AddRange(new object[] {
            "Прямые и тангенциальные",
            "Круглые"});
            this.Zv.Location = new System.Drawing.Point(637, 98);
            this.Zv.Name = "Zv";
            this.Zv.Size = new System.Drawing.Size(90, 21);
            this.Zv.TabIndex = 19;
            this.Zv.SelectedIndexChanged += new System.EventHandler(this.Zv_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 325);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(159, 39);
            this.label11.TabIndex = 20;
            this.label11.Text = "Относительная ширина \r\nэквивалентного конического \r\nколеса, Shir";
            // 
            // Shir
            // 
            this.Shir.Location = new System.Drawing.Point(194, 334);
            this.Shir.Name = "Shir";
            this.Shir.ReadOnly = true;
            this.Shir.Size = new System.Drawing.Size(90, 20);
            this.Shir.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(366, 157);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(209, 39);
            this.label12.TabIndex = 22;
            this.label12.Text = "Коэффициент, учитывающий\r\nраспредиление нагрузки по \r\nширине венца конического ко" +
    "леса, Kнв";
            // 
            // Khb
            // 
            this.Khb.Location = new System.Drawing.Point(637, 176);
            this.Khb.Name = "Khb";
            this.Khb.ReadOnly = true;
            this.Khb.Size = new System.Drawing.Size(90, 20);
            this.Khb.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(269, 29);
            this.button1.TabIndex = 24;
            this.button1.Text = "Рассчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Re
            // 
            this.Re.Location = new System.Drawing.Point(637, 389);
            this.Re.Name = "Re";
            this.Re.ReadOnly = true;
            this.Re.Size = new System.Drawing.Size(90, 20);
            this.Re.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(365, 396);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(190, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Внешнее конусное расстояние, Re  ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(365, 358);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Результат";
            // 
            // Kbee
            // 
            this.Kbee.Location = new System.Drawing.Point(195, 291);
            this.Kbee.Name = "Kbee";
            this.Kbee.Size = new System.Drawing.Size(90, 20);
            this.Kbee.TabIndex = 31;
            this.Kbee.TextChanged += new System.EventHandler(this.Kbee_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(366, 57);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 13);
            this.label15.TabIndex = 32;
            this.label15.Text = "Тип опоры";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(744, 442);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.Kbee);
            this.Controls.Add(this.Re);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Khb);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Shir);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Zv);
            this.Controls.Add(this.Td);
            this.Controls.Add(this.Op);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Kbe);
            this.Controls.Add(this.sigmaHP);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.T1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.u);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Kd);
            this.Controls.Add(this.Kr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Kr;
        private System.Windows.Forms.ComboBox Kd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox u;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox T1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox sigmaHP;
        private System.Windows.Forms.TextBox Kbe;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox Op;
        private System.Windows.Forms.ComboBox Td;
        private System.Windows.Forms.ComboBox Zv;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Shir;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Khb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Re;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Kbee;
        private System.Windows.Forms.Label label15;
    }
}

