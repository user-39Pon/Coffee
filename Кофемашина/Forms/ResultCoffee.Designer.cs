
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
            this.label_coffee = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.menuStrip1.Size = new System.Drawing.Size(559, 24);
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
            // label_coffee
            // 
            this.label_coffee.AutoSize = true;
            this.label_coffee.BackColor = System.Drawing.Color.Transparent;
            this.label_coffee.Font = new System.Drawing.Font("Gabriola", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_coffee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_coffee.Location = new System.Drawing.Point(199, 36);
            this.label_coffee.Name = "label_coffee";
            this.label_coffee.Size = new System.Drawing.Size(233, 63);
            this.label_coffee.TabIndex = 7;
            this.label_coffee.Text = "Ваш заказ готов!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gabriola", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(252, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 63);
            this.label1.TabIndex = 8;
            this.label1.Text = "Приятного аппетита!";
            // 
            // ResultCoffee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(559, 321);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_coffee);
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
        private System.Windows.Forms.Label label_coffee;
        private System.Windows.Forms.Label label1;
    }
}