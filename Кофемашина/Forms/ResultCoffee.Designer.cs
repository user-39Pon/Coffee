
namespace Кофемашина.Forms
{
    partial class ResultCoffee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultCoffee));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.закрыть = new System.Windows.Forms.ToolStripMenuItem();
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_napitok = new System.Windows.Forms.Label();
            this.label_coffeeML = new System.Windows.Forms.Label();
            this.label_milkML = new System.Windows.Forms.Label();
            this.label_waterML = new System.Windows.Forms.Label();
            this.label_sugar = new System.Windows.Forms.Label();
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
            this.menuStrip1.Size = new System.Drawing.Size(738, 24);
            this.menuStrip1.TabIndex = 2;
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
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Gabriola", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label.Location = new System.Drawing.Point(343, 24);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(213, 57);
            this.label.TabIndex = 7;
            this.label.Text = "Ваш заказ готов!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gabriola", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(436, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 63);
            this.label1.TabIndex = 8;
            this.label1.Text = "Приятного аппетита!";
            // 
            // label_napitok
            // 
            this.label_napitok.AutoSize = true;
            this.label_napitok.BackColor = System.Drawing.Color.Transparent;
            this.label_napitok.Font = new System.Drawing.Font("Gabriola", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_napitok.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_napitok.Location = new System.Drawing.Point(390, 64);
            this.label_napitok.Name = "label_napitok";
            this.label_napitok.Size = new System.Drawing.Size(0, 50);
            this.label_napitok.TabIndex = 9;
            // 
            // label_coffeeML
            // 
            this.label_coffeeML.AutoSize = true;
            this.label_coffeeML.BackColor = System.Drawing.Color.Transparent;
            this.label_coffeeML.Font = new System.Drawing.Font("Gabriola", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_coffeeML.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_coffeeML.Location = new System.Drawing.Point(410, 104);
            this.label_coffeeML.Name = "label_coffeeML";
            this.label_coffeeML.Size = new System.Drawing.Size(0, 50);
            this.label_coffeeML.TabIndex = 10;
            // 
            // label_milkML
            // 
            this.label_milkML.AutoSize = true;
            this.label_milkML.BackColor = System.Drawing.Color.Transparent;
            this.label_milkML.Font = new System.Drawing.Font("Gabriola", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_milkML.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_milkML.Location = new System.Drawing.Point(410, 141);
            this.label_milkML.Name = "label_milkML";
            this.label_milkML.Size = new System.Drawing.Size(0, 50);
            this.label_milkML.TabIndex = 11;
            // 
            // label_waterML
            // 
            this.label_waterML.AutoSize = true;
            this.label_waterML.BackColor = System.Drawing.Color.Transparent;
            this.label_waterML.Font = new System.Drawing.Font("Gabriola", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_waterML.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_waterML.Location = new System.Drawing.Point(410, 178);
            this.label_waterML.Name = "label_waterML";
            this.label_waterML.Size = new System.Drawing.Size(0, 50);
            this.label_waterML.TabIndex = 12;
            // 
            // label_sugar
            // 
            this.label_sugar.AutoSize = true;
            this.label_sugar.BackColor = System.Drawing.Color.Transparent;
            this.label_sugar.Font = new System.Drawing.Font("Gabriola", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_sugar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_sugar.Location = new System.Drawing.Point(410, 215);
            this.label_sugar.Name = "label_sugar";
            this.label_sugar.Size = new System.Drawing.Size(0, 50);
            this.label_sugar.TabIndex = 13;
            // 
            // ResultCoffee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(738, 485);
            this.Controls.Add(this.label_sugar);
            this.Controls.Add(this.label_waterML);
            this.Controls.Add(this.label_milkML);
            this.Controls.Add(this.label_coffeeML);
            this.Controls.Add(this.label_napitok);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ResultCoffee";
            this.Text = "ResultCoffee";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem закрыть;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_napitok;
        private System.Windows.Forms.Label label_coffeeML;
        private System.Windows.Forms.Label label_milkML;
        private System.Windows.Forms.Label label_waterML;
        private System.Windows.Forms.Label label_sugar;
    }
}