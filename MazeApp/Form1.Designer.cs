﻿namespace MazeApp
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
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button24 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(725, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Оставшееся время:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(890, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 20);
            this.label7.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(894, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Дойди до меня!";
            this.label6.Visible = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.YellowGreen;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.ForeColor = System.Drawing.Color.YellowGreen;
            this.button9.Location = new System.Drawing.Point(894, 394);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(49, 48);
            this.button9.TabIndex = 19;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Visible = false;
            this.button9.MouseEnter += new System.EventHandler(this.button9_MouseEnter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(556, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "- Не прикасайся!";
            this.label5.Visible = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.ForeColor = System.Drawing.Color.LightPink;
            this.label4.Location = new System.Drawing.Point(510, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 40);
            this.label4.TabIndex = 17;
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(388, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "- Твой путь";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightPink;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.ForeColor = System.Drawing.Color.LightPink;
            this.label2.Location = new System.Drawing.Point(343, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 40);
            this.label2.TabIndex = 15;
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(24, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Нажми для запуска игры!";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.button24);
            this.panel1.Controls.Add(this.button23);
            this.panel1.Controls.Add(this.button22);
            this.panel1.Controls.Add(this.button21);
            this.panel1.Controls.Add(this.button20);
            this.panel1.Controls.Add(this.button19);
            this.panel1.Controls.Add(this.button18);
            this.panel1.Controls.Add(this.button17);
            this.panel1.Controls.Add(this.button16);
            this.panel1.Controls.Add(this.button15);
            this.panel1.Controls.Add(this.button14);
            this.panel1.Controls.Add(this.button13);
            this.panel1.Controls.Add(this.button12);
            this.panel1.Controls.Add(this.button11);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(174, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(714, 407);
            this.panel1.TabIndex = 12;
            this.panel1.Visible = false;
            this.panel1.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            // 
            // button24
            // 
            this.button24.BackColor = System.Drawing.Color.LightPink;
            this.button24.FlatAppearance.BorderSize = 0;
            this.button24.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.button24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(100)));
            this.button24.ForeColor = System.Drawing.Color.DarkRed;
            this.button24.Location = new System.Drawing.Point(470, 149);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(201, 24);
            this.button24.TabIndex = 22;
            this.button24.Text = "НАЖМИ!";
            this.button24.UseVisualStyleBackColor = false;
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.Color.LightPink;
            this.button23.FlatAppearance.BorderSize = 0;
            this.button23.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.button23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button23.Location = new System.Drawing.Point(328, 279);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(36, 16);
            this.button23.TabIndex = 21;
            this.button23.UseVisualStyleBackColor = false;
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.LightPink;
            this.button22.FlatAppearance.BorderSize = 0;
            this.button22.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button22.Location = new System.Drawing.Point(350, 279);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(14, 94);
            this.button22.TabIndex = 20;
            this.button22.UseVisualStyleBackColor = false;
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.LightPink;
            this.button21.FlatAppearance.BorderSize = 0;
            this.button21.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button21.Location = new System.Drawing.Point(327, 247);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(11, 46);
            this.button21.TabIndex = 19;
            this.button21.UseVisualStyleBackColor = false;
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.LightPink;
            this.button20.FlatAppearance.BorderSize = 0;
            this.button20.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button20.Location = new System.Drawing.Point(302, 247);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(36, 16);
            this.button20.TabIndex = 18;
            this.button20.UseVisualStyleBackColor = false;
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.LightPink;
            this.button19.FlatAppearance.BorderSize = 0;
            this.button19.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.Location = new System.Drawing.Point(302, 249);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(11, 46);
            this.button19.TabIndex = 17;
            this.button19.UseVisualStyleBackColor = false;
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.LightPink;
            this.button18.FlatAppearance.BorderSize = 0;
            this.button18.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Location = new System.Drawing.Point(277, 279);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(36, 16);
            this.button18.TabIndex = 16;
            this.button18.UseVisualStyleBackColor = false;
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.LightPink;
            this.button17.FlatAppearance.BorderSize = 0;
            this.button17.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.Location = new System.Drawing.Point(275, 249);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(11, 46);
            this.button17.TabIndex = 15;
            this.button17.UseVisualStyleBackColor = false;
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.LightPink;
            this.button16.FlatAppearance.BorderSize = 0;
            this.button16.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Location = new System.Drawing.Point(250, 249);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(36, 16);
            this.button16.TabIndex = 14;
            this.button16.UseVisualStyleBackColor = false;
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.LightPink;
            this.button15.FlatAppearance.BorderSize = 0;
            this.button15.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Location = new System.Drawing.Point(250, 249);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(11, 46);
            this.button15.TabIndex = 13;
            this.button15.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.LightPink;
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Location = new System.Drawing.Point(223, 279);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(36, 16);
            this.button14.TabIndex = 12;
            this.button14.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.LightPink;
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Location = new System.Drawing.Point(223, 247);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(11, 46);
            this.button13.TabIndex = 11;
            this.button13.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.LightPink;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Location = new System.Drawing.Point(198, 247);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(36, 16);
            this.button12.TabIndex = 10;
            this.button12.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.LightPink;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Location = new System.Drawing.Point(198, 249);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(11, 46);
            this.button11.TabIndex = 9;
            this.button11.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.LightPink;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Location = new System.Drawing.Point(37, 184);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(467, 23);
            this.button10.TabIndex = 8;
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Visible = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.LightPink;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(350, 350);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(402, 23);
            this.button8.TabIndex = 7;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.LightPink;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(37, 269);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(172, 26);
            this.button7.TabIndex = 6;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.LightPink;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(37, 184);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(14, 111);
            this.button6.TabIndex = 5;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightPink;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(470, 149);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(34, 58);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightPink;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(260, 149);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(244, 23);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightPink;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(250, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 147);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightPink;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(297, 48);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.IndianRed;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.IndianRed;
            this.button3.Location = new System.Drawing.Point(119, 69);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(49, 48);
            this.button3.TabIndex = 13;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 492);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Name = "Form1";
            this.Text = "Maze";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ImageList imageList1;
    }
}

