
namespace Кофемашина.Forms
{
    partial class Mixing
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mixing));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.закрыть = new System.Windows.Forms.ToolStripMenuItem();
            this.label_coffee = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_save = new System.Windows.Forms.Button();
            this.textBox_coffee = new System.Windows.Forms.TextBox();
            this.textBox_milk = new System.Windows.Forms.TextBox();
            this.textBox_water = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.закрыть});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(413, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // закрыть
            // 
            this.закрыть.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.закрыть.Image = ((System.Drawing.Image)(resources.GetObject("закрыть.Image")));
            this.закрыть.Name = "закрыть";
            this.закрыть.Size = new System.Drawing.Size(28, 20);
            this.закрыть.Click += new System.EventHandler(this.закрыть_Click);
            // 
            // label_coffee
            // 
            this.label_coffee.AutoSize = true;
            this.label_coffee.BackColor = System.Drawing.Color.Transparent;
            this.label_coffee.Font = new System.Drawing.Font("Gabriola", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_coffee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_coffee.Location = new System.Drawing.Point(15, 38);
            this.label_coffee.Name = "label_coffee";
            this.label_coffee.Size = new System.Drawing.Size(162, 50);
            this.label_coffee.TabIndex = 6;
            this.label_coffee.Text = "Капучино (мл)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gabriola", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(15, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 50);
            this.label1.TabIndex = 23;
            this.label1.Text = "Молоко (мл)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Gabriola", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(186, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 50);
            this.label2.TabIndex = 25;
            this.label2.Text = "Вода (мл)";
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.Color.Transparent;
            this.button_save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_save.BackgroundImage")));
            this.button_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_save.FlatAppearance.BorderSize = 0;
            this.button_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_save.Location = new System.Drawing.Point(195, 32);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(197, 85);
            this.button_save.TabIndex = 27;
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            this.button_save.MouseEnter += new System.EventHandler(this.button_save_MouseEnter);
            this.button_save.MouseLeave += new System.EventHandler(this.button_save_MouseLeave);
            // 
            // textBox_coffee
            // 
            this.textBox_coffee.Font = new System.Drawing.Font("Century Schoolbook", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_coffee.ForeColor = System.Drawing.Color.SaddleBrown;
            this.textBox_coffee.Location = new System.Drawing.Point(24, 85);
            this.textBox_coffee.Name = "textBox_coffee";
            this.textBox_coffee.ReadOnly = true;
            this.textBox_coffee.Size = new System.Drawing.Size(131, 32);
            this.textBox_coffee.TabIndex = 28;
            // 
            // textBox_milk
            // 
            this.textBox_milk.Font = new System.Drawing.Font("Century Schoolbook", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_milk.ForeColor = System.Drawing.Color.SaddleBrown;
            this.textBox_milk.Location = new System.Drawing.Point(24, 163);
            this.textBox_milk.Name = "textBox_milk";
            this.textBox_milk.Size = new System.Drawing.Size(131, 32);
            this.textBox_milk.TabIndex = 29;
            this.textBox_milk.Tag = "";
            this.textBox_milk.TextChanged += new System.EventHandler(this.textBox_milk_TextChanged);
            // 
            // textBox_water
            // 
            this.textBox_water.Font = new System.Drawing.Font("Century Schoolbook", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_water.ForeColor = System.Drawing.Color.SaddleBrown;
            this.textBox_water.Location = new System.Drawing.Point(195, 163);
            this.textBox_water.Name = "textBox_water";
            this.textBox_water.Size = new System.Drawing.Size(131, 32);
            this.textBox_water.TabIndex = 30;
            this.textBox_water.Tag = "";
            this.textBox_water.TextChanged += new System.EventHandler(this.textBox_water_TextChanged);
            // 
            // Mixing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(413, 225);
            this.Controls.Add(this.textBox_water);
            this.Controls.Add(this.textBox_milk);
            this.Controls.Add(this.textBox_coffee);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_coffee);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Mixing";
            this.Text = "Mixing";
            this.Load += new System.EventHandler(this.Mixing_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem закрыть;
        private System.Windows.Forms.Label label_coffee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.TextBox textBox_coffee;
        private System.Windows.Forms.TextBox textBox_milk;
        private System.Windows.Forms.TextBox textBox_water;
    }
}