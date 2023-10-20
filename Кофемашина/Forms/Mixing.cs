using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Кофемашина.Classes;

namespace Кофемашина.Forms
{
    public partial class Mixing : Form
    {
        //максимальное кол-во миллилитров в стакане
        public static int maxML;

        //вспомогательная переменная для определения наличия сохранённых данных о смешивании
        public static int mix_no = 0;

        //вспомогательная переменная для определения количества произведённых изменений текста в textBox
        public static int change = 0;

        //переменные для изменения размера кнопки "Сохранить"
        private Size OriginalButtonSize;
        private Size HoveredSize;

        public string ML(string mikl, string water) //метод подсчёта кол-ва кофе в стакане после добавления молока или воды
        {
            try
            {
                if (maxML < 50 || Convert.ToInt32(mikl) < 0 || Convert.ToInt32(water) < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                if (maxML > 290 || Convert.ToInt32(mikl) > maxML || Convert.ToInt32(water) > maxML)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                if (Convert.ToInt32(mikl) + Convert.ToInt32(water) >= maxML)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    int coffee = maxML - Convert.ToInt32(mikl) - Convert.ToInt32(water);
                    return coffee.ToString();
                }
            }
            catch
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public Mixing(string name_coffee, int ml)
        {
            InitializeComponent();
            
            //расчёт максимамльной вместимости стакана
            maxML = ml - 10;
            label_coffee.Text = name_coffee;
        }

        private void закрыть_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            //передача сохранённых данных в класс Sostav
            Sostav.SaveSostav(Convert.ToInt32(textBox_coffee.Text), Convert.ToInt32(textBox_milk.Text), Convert.ToInt32(textBox_water.Text));
            change = 0;
            this.Close();
        }

        private void Mixing_Load(object sender, EventArgs e)
        {
            change = 0;

            //проверка наличия сохранённых данных
            for (int i = 0; i < 3; i++)
            {
                if (Sostav.sost[i] == 0) mix_no++;
            }

            //запись нулей и максимального кол-ва миллилитров в поля, если сохранённых данных нет
            if (mix_no == 3)
            {
                textBox_coffee.Text = maxML.ToString();
                textBox_milk.Text = "0";
                textBox_water.Text = "0";
            }
            else //запись сохранённых данных, при их наличии
            {
                textBox_coffee.Text = Sostav.sost[0].ToString();
                textBox_milk.Text = Sostav.sost[1].ToString();
                textBox_water.Text = Sostav.sost[2].ToString();
            }
            mix_no = 0;

            OriginalButtonSize = this.button_save.Size;
            HoveredSize = new Size(OriginalButtonSize.Width + 10, OriginalButtonSize.Height + 10);
        }

        private void textBox_milk_TextChanged(object sender, EventArgs e)
        {
            if (textBox_milk.Text != "")
            {
                try
                {
                    //пересчёт кол-ва миллилитров кофе
                    textBox_coffee.Text = ML(textBox_milk.Text, textBox_water.Text);
                    if (Convert.ToInt32(textBox_coffee.Text) <= 0) // если результат не соответствует условиям, данные в полях возвращаются в исходное положение
                    {
                        textBox_milk.Text = "0";
                        textBox_coffee.Text = ML(textBox_milk.Text, textBox_water.Text);
                    }
                }
                catch
                {
                    if (change != 0)
                    {
                        MessageBox.Show($"Введите в поле число, которое не будет привышать и не будет равно {maxML} мл.");
                        textBox_milk.Text = "0";
                    }
                }
                change++;
            }
            else textBox_milk.Text = "0";
        }

        private void textBox_water_TextChanged(object sender, EventArgs e)
        {
            if (textBox_water.Text != "")
            {
                try
                {
                    textBox_coffee.Text = ML(textBox_milk.Text, textBox_water.Text);
                    if (Convert.ToInt32(textBox_coffee.Text) <= 0)
                    {
                        textBox_water.Text = "0";
                        textBox_coffee.Text = ML(textBox_milk.Text, textBox_water.Text);
                    }
                }
                catch
                {
                    if (change != 0)
                    {
                        MessageBox.Show($"Введите в поле число, которое не будет привышать и не будет равно {maxML} мл.");
                        textBox_water.Text = "0";
                    }
                }
                change++;
            }
            else textBox_water.Text = "0";
        }

        private void button_save_MouseEnter(object sender, EventArgs e)
        {
            button_save.Size = HoveredSize;
        }

        private void button_save_MouseLeave(object sender, EventArgs e)
        {
            button_save.Size = OriginalButtonSize;
        }
    }
}
