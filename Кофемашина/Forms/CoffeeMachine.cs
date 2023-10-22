using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Кофемашина.Forms;
using Кофемашина.Classes;

namespace Кофемашина
{
    public partial class CoffeeMachine : Form
    {
        //переменные для выбора напитка и ёмкости
        public static int napitok = 0;
        public static int emkost = 0;

        //переменные для изменения размера кнопок
        private Size OriginalButtonSize;
        private Size HoveredSize;

        private Size OriginalButtonSizeMIX;
        private Size HoveredSizeMIX;

        private Size OriginalButtonSizeSTART;
        private Size HoveredSizeSTART;
        public CoffeeMachine()
        {
            InitializeComponent();
        }

        private void хToolStripMenuItem_Click(object sender, EventArgs e) //свернуть
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void вToolStripMenuItem_Click(object sender, EventArgs e) //закрыть
        {
            Application.Exit();
        }

        private void button_эспрессо_Click(object sender, EventArgs e) 
        {
            //сброс сохранённых данных о составе напитка
            if (napitok != 1) Sostav.SaveSostav(0, 0, 0);

            napitok = 1;
            emkost = 60;

            //изменение цвета заднего фона кнопок при выборе напитка
            button_эспрессо.BackColor = Color.NavajoWhite;
            button_американо.BackColor = Color.Transparent;
            button_капучино.BackColor = Color.Transparent;
            button_молоко.BackColor = Color.Transparent;
            button_вода.BackColor = Color.Transparent;

            //выбор ёмкости по умолчанию
            button_60мл.BackColor = Color.NavajoWhite;
            button_180мл.BackColor = Color.Transparent;
            button_300мл.BackColor = Color.Transparent;

            //раскрытие кнопок "изменить состав" и "заказать"
            label_sostav.Visible = true;
            button_смешать.Visible = true;
            button_start.Visible = true;
        }

        private void button_американо_Click(object sender, EventArgs e)
        {
            if (napitok != 2) Sostav.SaveSostav(0, 0, 0);

            napitok = 2;
            emkost = 180;

            button_эспрессо.BackColor = Color.Transparent;
            button_американо.BackColor = Color.NavajoWhite;
            button_капучино.BackColor = Color.Transparent;
            button_молоко.BackColor = Color.Transparent;
            button_вода.BackColor = Color.Transparent;

            button_60мл.BackColor = Color.Transparent;
            button_180мл.BackColor = Color.NavajoWhite;
            button_300мл.BackColor = Color.Transparent;

            label_sostav.Visible = true;
            button_смешать.Visible = true;
            button_start.Visible = true;
        }

        private void button_капучино_Click(object sender, EventArgs e)
        {
            if (napitok != 3) Sostav.SaveSostav(0, 0, 0);

            napitok = 3;
            emkost = 300;

            button_эспрессо.BackColor = Color.Transparent;
            button_американо.BackColor = Color.Transparent;
            button_капучино.BackColor = Color.NavajoWhite;
            button_молоко.BackColor = Color.Transparent;
            button_вода.BackColor = Color.Transparent;

            button_60мл.BackColor = Color.Transparent;
            button_180мл.BackColor = Color.Transparent;
            button_300мл.BackColor = Color.NavajoWhite;

            label_sostav.Visible = true;
            button_смешать.Visible = true;
            button_start.Visible = true;
        }

        private void button_молоко_Click(object sender, EventArgs e)
        {
            if (napitok != 4) Sostav.SaveSostav(0, 0, 0);

            napitok = 4;
            emkost = 300;

            button_эспрессо.BackColor = Color.Transparent;
            button_американо.BackColor = Color.Transparent;
            button_капучино.BackColor = Color.Transparent;
            button_молоко.BackColor = Color.NavajoWhite;
            button_вода.BackColor = Color.Transparent;

            button_60мл.BackColor = Color.Transparent;
            button_180мл.BackColor = Color.Transparent;
            button_300мл.BackColor = Color.NavajoWhite;

            label_sostav.Visible = false;
            button_смешать.Visible = false;
            button_start.Visible = true;
        }

        private void button_вода_Click(object sender, EventArgs e)
        {
            if (napitok != 5) Sostav.SaveSostav(0, 0, 0);

            napitok = 5;
            emkost = 300;

            button_эспрессо.BackColor = Color.Transparent;
            button_американо.BackColor = Color.Transparent;
            button_капучино.BackColor = Color.Transparent;
            button_молоко.BackColor = Color.Transparent;
            button_вода.BackColor = Color.NavajoWhite;

            button_60мл.BackColor = Color.Transparent;
            button_180мл.BackColor = Color.Transparent;
            button_300мл.BackColor = Color.NavajoWhite;

            label_sostav.Visible = false;
            button_смешать.Visible = false;
            button_start.Visible = true;
        }

        private void button_60мл_Click(object sender, EventArgs e)
        {
            if (emkost != 60) Sostav.SaveSostav(0, 0, 0);

            //выбор ёмкости по желанию
            emkost = 60;
            button_60мл.BackColor = Color.NavajoWhite;
            button_180мл.BackColor = Color.Transparent;
            button_300мл.BackColor = Color.Transparent;
        }

        private void button_180мл_Click(object sender, EventArgs e)
        {
            if (emkost != 180) Sostav.SaveSostav(0, 0, 0);

            emkost = 180;
            button_60мл.BackColor = Color.Transparent;
            button_180мл.BackColor = Color.NavajoWhite;
            button_300мл.BackColor = Color.Transparent;
        }

        private void button_300мл_Click(object sender, EventArgs e)
        {
            if (emkost != 300) Sostav.SaveSostav(0, 0, 0);

            emkost = 300;
            button_60мл.BackColor = Color.Transparent;
            button_180мл.BackColor = Color.Transparent;
            button_300мл.BackColor = Color.NavajoWhite;
        }

        private void button_смешать_Click(object sender, EventArgs e)
        {
            //передача данных о выбранном кофе и ёмкости в форму Mixing
            if (napitok == 1)
            {
                Mixing mix = new Mixing("Эспрессо (мл)", emkost);
                mix.ShowDialog();
            }
            else if (napitok == 2)
            {
                Mixing mix = new Mixing("Американо (мл)", emkost);
                mix.ShowDialog();
            }
            else if (napitok == 3)
            {
                Mixing mix = new Mixing("Капучино (мл)", emkost);
                mix.ShowDialog();
            }
        }
        
        private void CoffeeMachine_Load(object sender, EventArgs e)
        {
            //внесение данных об ихменении размера кнопок
            OriginalButtonSize = this.button_эспрессо.Size;
            HoveredSize = new Size(OriginalButtonSize.Width + 10, OriginalButtonSize.Height + 10);

            OriginalButtonSizeMIX = this.button_смешать.Size;
            HoveredSizeMIX = new Size(OriginalButtonSizeMIX.Width + 10, OriginalButtonSizeMIX.Height + 10);

            OriginalButtonSizeSTART = this.button_start.Size;
            HoveredSizeSTART = new Size(OriginalButtonSizeSTART.Width + 10, OriginalButtonSizeSTART.Height + 10);

            //скрытие кнопок "изменить состав" и "заказать"
            label_sostav.Visible = false;
            button_смешать.Visible = false;
            button_start.Visible = false;
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            //перенос данных на форму ResultCoffee
            ResultCoffee resultCoffee = new ResultCoffee(napitok, Convert.ToInt32(numericUpDown_sugar.Value), emkost);

            //сброс данных о заказанном напитке на данной форме
            napitok = 0;
            emkost = 0;

            label_sostav.Visible = false;
            button_смешать.Visible = false;
            button_start.Visible = false;

            button_эспрессо.BackColor = Color.Transparent;
            button_американо.BackColor = Color.Transparent;
            button_капучино.BackColor = Color.Transparent;
            button_молоко.BackColor = Color.Transparent;
            button_вода.BackColor = Color.Transparent;

            button_60мл.BackColor = Color.Transparent;
            button_180мл.BackColor = Color.Transparent;
            button_300мл.BackColor = Color.Transparent;

            numericUpDown_sugar.Value = 0;

            //переход на форму ResultCoffee
            resultCoffee.Show();
            this.Hide();
        }

        private void button_эспрессо_MouseEnter(object sender, EventArgs e)
        {
            //увеличение кнопки при наведении
            button_эспрессо.Size = HoveredSize;
        }

        private void button_эспрессо_MouseLeave(object sender, EventArgs e)
        {
            //возвращение кнопки в исходный размер при уходе мышки с кнопки
            button_эспрессо.Size = OriginalButtonSize;
        }

        private void button_американо_MouseEnter(object sender, EventArgs e)
        {
            button_американо.Size = HoveredSize;
        }

        private void button_американо_MouseLeave(object sender, EventArgs e)
        {
            button_американо.Size = OriginalButtonSize;
        }

        private void button_капучино_MouseEnter(object sender, EventArgs e)
        {
            button_капучино.Size = HoveredSize;
        }

        private void button_капучино_MouseLeave(object sender, EventArgs e)
        {
            button_капучино.Size = OriginalButtonSize;
        }

        private void button_молоко_MouseEnter(object sender, EventArgs e)
        {
            button_молоко.Size = HoveredSize;
        }

        private void button_молоко_MouseLeave(object sender, EventArgs e)
        {
            button_молоко.Size = OriginalButtonSize;
        }

        private void button_вода_MouseEnter(object sender, EventArgs e)
        {
            button_вода.Size = HoveredSize;
        }

        private void button_вода_MouseLeave(object sender, EventArgs e)
        {
            button_вода.Size = OriginalButtonSize;
        }

        private void button_смешать_MouseEnter(object sender, EventArgs e)
        {
            button_смешать.Size = HoveredSizeMIX;
        }

        private void button_смешать_MouseLeave(object sender, EventArgs e)
        {
            button_смешать.Size = OriginalButtonSizeMIX;
        }

        private void button_start_MouseEnter(object sender, EventArgs e)
        {
            button_start.Size = HoveredSizeSTART;
        }

        private void button_start_MouseLeave(object sender, EventArgs e)
        {
            button_start.Size = OriginalButtonSizeSTART;
        }
    }
}
