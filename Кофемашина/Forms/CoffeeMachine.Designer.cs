
namespace Кофемашина
{
    partial class CoffeeMachine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoffeeMachine));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.закрыть = new System.Windows.Forms.ToolStripMenuItem();
            this.свернуть = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button_60мл = new System.Windows.Forms.Button();
            this.button_180мл = new System.Windows.Forms.Button();
            this.button_300мл = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDown_sugar = new System.Windows.Forms.NumericUpDown();
            this.label_sostav = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_start = new System.Windows.Forms.Button();
            this.button_смешать = new System.Windows.Forms.Button();
            this.button_вода = new System.Windows.Forms.Button();
            this.button_молоко = new System.Windows.Forms.Button();
            this.button_капучино = new System.Windows.Forms.Button();
            this.button_американо = new System.Windows.Forms.Button();
            this.button_эспрессо = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sugar)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.закрыть,
            this.свернуть});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(556, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // закрыть
            // 
            this.закрыть.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.закрыть.Image = ((System.Drawing.Image)(resources.GetObject("закрыть.Image")));
            this.закрыть.Name = "закрыть";
            this.закрыть.Size = new System.Drawing.Size(28, 20);
            this.закрыть.Click += new System.EventHandler(this.вToolStripMenuItem_Click);
            // 
            // свернуть
            // 
            this.свернуть.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.свернуть.Image = ((System.Drawing.Image)(resources.GetObject("свернуть.Image")));
            this.свернуть.Name = "свернуть";
            this.свернуть.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.свернуть.Size = new System.Drawing.Size(28, 20);
            this.свернуть.Click += new System.EventHandler(this.хToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(556, 111);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Gabriola", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Linen;
            this.label2.Location = new System.Drawing.Point(5, -5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 110);
            this.label2.TabIndex = 4;
            this.label2.Text = "Кофемашина";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gabriola", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(130, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 74);
            this.label1.TabIndex = 5;
            this.label1.Text = "Выберите напиток";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Gabriola", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(89, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(391, 74);
            this.label3.TabIndex = 9;
            this.label3.Text = "Выберите размер порции";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Gabriola", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label4.Location = new System.Drawing.Point(28, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 42);
            this.label4.TabIndex = 10;
            this.label4.Text = "Эспрессо";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Gabriola", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label5.Location = new System.Drawing.Point(120, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 42);
            this.label5.TabIndex = 11;
            this.label5.Text = "Американо";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Gabriola", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label6.Location = new System.Drawing.Point(232, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 42);
            this.label6.TabIndex = 12;
            this.label6.Text = "Капучино";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Gabriola", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label7.Location = new System.Drawing.Point(348, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 42);
            this.label7.TabIndex = 13;
            this.label7.Text = "Молоко";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Gabriola", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label8.Location = new System.Drawing.Point(466, 314);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 42);
            this.label8.TabIndex = 14;
            this.label8.Text = "Вода";
            // 
            // button_60мл
            // 
            this.button_60мл.BackColor = System.Drawing.Color.Transparent;
            this.button_60мл.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_60мл.BackgroundImage")));
            this.button_60мл.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_60мл.FlatAppearance.BorderSize = 0;
            this.button_60мл.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button_60мл.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_60мл.Location = new System.Drawing.Point(69, 433);
            this.button_60мл.Name = "button_60мл";
            this.button_60мл.Size = new System.Drawing.Size(137, 113);
            this.button_60мл.TabIndex = 15;
            this.button_60мл.UseVisualStyleBackColor = false;
            this.button_60мл.Click += new System.EventHandler(this.button_60мл_Click);
            // 
            // button_180мл
            // 
            this.button_180мл.BackColor = System.Drawing.Color.Transparent;
            this.button_180мл.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_180мл.BackgroundImage")));
            this.button_180мл.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_180мл.FlatAppearance.BorderSize = 0;
            this.button_180мл.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button_180мл.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_180мл.Location = new System.Drawing.Point(212, 433);
            this.button_180мл.Name = "button_180мл";
            this.button_180мл.Size = new System.Drawing.Size(140, 113);
            this.button_180мл.TabIndex = 16;
            this.button_180мл.UseVisualStyleBackColor = false;
            this.button_180мл.Click += new System.EventHandler(this.button_180мл_Click);
            // 
            // button_300мл
            // 
            this.button_300мл.BackColor = System.Drawing.Color.Transparent;
            this.button_300мл.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_300мл.BackgroundImage")));
            this.button_300мл.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_300мл.FlatAppearance.BorderSize = 0;
            this.button_300мл.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button_300мл.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_300мл.Location = new System.Drawing.Point(358, 433);
            this.button_300мл.Name = "button_300мл";
            this.button_300мл.Size = new System.Drawing.Size(140, 113);
            this.button_300мл.TabIndex = 17;
            this.button_300мл.UseVisualStyleBackColor = false;
            this.button_300мл.Click += new System.EventHandler(this.button_300мл_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Gabriola", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label9.Location = new System.Drawing.Point(11, 549);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(239, 50);
            this.label9.TabIndex = 19;
            this.label9.Text = "Сахар (чайные ложки)";
            // 
            // numericUpDown_sugar
            // 
            this.numericUpDown_sugar.BackColor = System.Drawing.Color.Linen;
            this.numericUpDown_sugar.Font = new System.Drawing.Font("Century Schoolbook", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown_sugar.ForeColor = System.Drawing.Color.SaddleBrown;
            this.numericUpDown_sugar.Location = new System.Drawing.Point(239, 559);
            this.numericUpDown_sugar.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_sugar.Name = "numericUpDown_sugar";
            this.numericUpDown_sugar.Size = new System.Drawing.Size(140, 32);
            this.numericUpDown_sugar.TabIndex = 21;
            this.numericUpDown_sugar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_sostav
            // 
            this.label_sostav.AutoSize = true;
            this.label_sostav.BackColor = System.Drawing.Color.Transparent;
            this.label_sostav.Font = new System.Drawing.Font("Gabriola", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_sostav.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label_sostav.Location = new System.Drawing.Point(43, 599);
            this.label_sostav.Name = "label_sostav";
            this.label_sostav.Size = new System.Drawing.Size(195, 50);
            this.label_sostav.TabIndex = 23;
            this.label_sostav.Text = "Изменить состав";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.button_start);
            this.panel2.Controls.Add(this.button_смешать);
            this.panel2.Location = new System.Drawing.Point(0, 637);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1012, 190);
            this.panel2.TabIndex = 5;
            // 
            // button_start
            // 
            this.button_start.BackColor = System.Drawing.Color.Transparent;
            this.button_start.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_start.BackgroundImage")));
            this.button_start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_start.FlatAppearance.BorderSize = 0;
            this.button_start.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_start.Location = new System.Drawing.Point(335, 3);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(187, 164);
            this.button_start.TabIndex = 25;
            this.button_start.UseVisualStyleBackColor = false;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            this.button_start.MouseEnter += new System.EventHandler(this.button_start_MouseEnter);
            this.button_start.MouseLeave += new System.EventHandler(this.button_start_MouseLeave);
            // 
            // button_смешать
            // 
            this.button_смешать.BackColor = System.Drawing.Color.Transparent;
            this.button_смешать.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_смешать.BackgroundImage")));
            this.button_смешать.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_смешать.FlatAppearance.BorderSize = 0;
            this.button_смешать.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_смешать.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_смешать.Location = new System.Drawing.Point(60, 4);
            this.button_смешать.Name = "button_смешать";
            this.button_смешать.Size = new System.Drawing.Size(146, 152);
            this.button_смешать.TabIndex = 23;
            this.button_смешать.UseVisualStyleBackColor = false;
            this.button_смешать.Click += new System.EventHandler(this.button_смешать_Click);
            this.button_смешать.MouseEnter += new System.EventHandler(this.button_смешать_MouseEnter);
            this.button_смешать.MouseLeave += new System.EventHandler(this.button_смешать_MouseLeave);
            // 
            // button_вода
            // 
            this.button_вода.BackColor = System.Drawing.Color.Transparent;
            this.button_вода.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_вода.BackgroundImage")));
            this.button_вода.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_вода.FlatAppearance.BorderSize = 0;
            this.button_вода.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_вода.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_вода.Location = new System.Drawing.Point(442, 213);
            this.button_вода.Name = "button_вода";
            this.button_вода.Size = new System.Drawing.Size(99, 99);
            this.button_вода.TabIndex = 28;
            this.button_вода.UseVisualStyleBackColor = false;
            this.button_вода.Click += new System.EventHandler(this.button_вода_Click);
            this.button_вода.MouseEnter += new System.EventHandler(this.button_вода_MouseEnter);
            this.button_вода.MouseLeave += new System.EventHandler(this.button_вода_MouseLeave);
            // 
            // button_молоко
            // 
            this.button_молоко.BackColor = System.Drawing.Color.Transparent;
            this.button_молоко.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_молоко.BackgroundImage")));
            this.button_молоко.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_молоко.FlatAppearance.BorderSize = 0;
            this.button_молоко.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_молоко.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_молоко.Location = new System.Drawing.Point(337, 213);
            this.button_молоко.Name = "button_молоко";
            this.button_молоко.Size = new System.Drawing.Size(99, 99);
            this.button_молоко.TabIndex = 27;
            this.button_молоко.UseVisualStyleBackColor = false;
            this.button_молоко.Click += new System.EventHandler(this.button_молоко_Click);
            this.button_молоко.MouseEnter += new System.EventHandler(this.button_молоко_MouseEnter);
            this.button_молоко.MouseLeave += new System.EventHandler(this.button_молоко_MouseLeave);
            // 
            // button_капучино
            // 
            this.button_капучино.BackColor = System.Drawing.Color.Transparent;
            this.button_капучино.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_капучино.BackgroundImage")));
            this.button_капучино.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_капучино.FlatAppearance.BorderSize = 0;
            this.button_капучино.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_капучино.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_капучино.Location = new System.Drawing.Point(232, 213);
            this.button_капучино.Name = "button_капучино";
            this.button_капучино.Size = new System.Drawing.Size(99, 99);
            this.button_капучино.TabIndex = 26;
            this.button_капучино.UseVisualStyleBackColor = false;
            this.button_капучино.Click += new System.EventHandler(this.button_капучино_Click);
            this.button_капучино.MouseEnter += new System.EventHandler(this.button_капучино_MouseEnter);
            this.button_капучино.MouseLeave += new System.EventHandler(this.button_капучино_MouseLeave);
            // 
            // button_американо
            // 
            this.button_американо.BackColor = System.Drawing.Color.Transparent;
            this.button_американо.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_американо.BackgroundImage")));
            this.button_американо.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_американо.FlatAppearance.BorderSize = 0;
            this.button_американо.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_американо.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_американо.Location = new System.Drawing.Point(127, 213);
            this.button_американо.Name = "button_американо";
            this.button_американо.Size = new System.Drawing.Size(99, 99);
            this.button_американо.TabIndex = 25;
            this.button_американо.UseVisualStyleBackColor = false;
            this.button_американо.Click += new System.EventHandler(this.button_американо_Click);
            this.button_американо.MouseEnter += new System.EventHandler(this.button_американо_MouseEnter);
            this.button_американо.MouseLeave += new System.EventHandler(this.button_американо_MouseLeave);
            // 
            // button_эспрессо
            // 
            this.button_эспрессо.BackColor = System.Drawing.Color.Transparent;
            this.button_эспрессо.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_эспрессо.BackgroundImage")));
            this.button_эспрессо.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_эспрессо.FlatAppearance.BorderSize = 0;
            this.button_эспрессо.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_эспрессо.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_эспрессо.Location = new System.Drawing.Point(22, 213);
            this.button_эспрессо.Name = "button_эспрессо";
            this.button_эспрессо.Size = new System.Drawing.Size(99, 99);
            this.button_эспрессо.TabIndex = 24;
            this.button_эспрессо.UseVisualStyleBackColor = false;
            this.button_эспрессо.Click += new System.EventHandler(this.button_эспрессо_Click);
            this.button_эспрессо.MouseEnter += new System.EventHandler(this.button_эспрессо_MouseEnter);
            this.button_эспрессо.MouseLeave += new System.EventHandler(this.button_эспрессо_MouseLeave);
            // 
            // CoffeeMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(556, 827);
            this.Controls.Add(this.button_вода);
            this.Controls.Add(this.button_молоко);
            this.Controls.Add(this.button_капучино);
            this.Controls.Add(this.button_американо);
            this.Controls.Add(this.button_эспрессо);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label_sostav);
            this.Controls.Add(this.numericUpDown_sugar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button_300мл);
            this.Controls.Add(this.button_180мл);
            this.Controls.Add(this.button_60мл);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CoffeeMachine";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CoffeeMachine_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sugar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem закрыть;
        private System.Windows.Forms.ToolStripMenuItem свернуть;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button_60мл;
        private System.Windows.Forms.Button button_180мл;
        private System.Windows.Forms.Button button_300мл;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDown_sugar;
        private System.Windows.Forms.Label label_sostav;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button button_смешать;
        private System.Windows.Forms.Button button_вода;
        private System.Windows.Forms.Button button_молоко;
        private System.Windows.Forms.Button button_капучино;
        private System.Windows.Forms.Button button_американо;
        private System.Windows.Forms.Button button_эспрессо;
    }
}

