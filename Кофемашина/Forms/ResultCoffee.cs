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
    public partial class ResultCoffee : Form
    {
        string napitok;
        public ResultCoffee(int napitok, int sugar, int emkost)
        {
            InitializeComponent();

            if (napitok == 1) this.napitok = "Эспрессо";
            else if (napitok == 2) this.napitok = "Американо";
            else if (napitok == 3) this.napitok = "Капучино";
            else if (napitok == 4) this.napitok = "Молоко";
            else if (napitok == 5) this.napitok = "Вода";

            //вывод данных о напитке
            label_napitok.Text = $"{this.napitok} {emkost} мл";
            
            //вывод данных о составе напитка
            if (Sostav.sost[0] == 0)
            {
                if (sugar != 0) label_coffeeML.Text = $"- {this.napitok} {emkost - 10} мл";
            }
            else
            {
                if (sugar != 0 || Sostav.sost[1] != 0 || Sostav.sost[2] != 0) label_coffeeML.Text = $"- {this.napitok} {Sostav.sost[0]} мл";
                if (Sostav.sost[1] != 0) label_milkML.Text = $"- Молоко {Sostav.sost[1]} мл";
                if (label_milkML.Text == "" && Sostav.sost[2] != 0) label_milkML.Text = $"- Вода {Sostav.sost[2]} мл";
                else if (Sostav.sost[2] != 0) label_waterML.Text = $"- Вода {Sostav.sost[2]} мл";
            }

            //вывод данных о сахаре
            if (sugar != 0)
            {
                if (label_milkML.Text == "") label_milkML.Text = $"- Сахар {sugar} ч.л.";
                else if (label_waterML.Text == "") label_waterML.Text = $"- Сахар {sugar} ч.л.";
                else label_sugar.Text = $"- Сахар {sugar} ч.л.";
            }
        }

        private void закрыть_Click(object sender, EventArgs e)
        {
            // возвращение на форму CoffeeMachine
            Sostav.SaveSostav(0, 0, 0);
            CoffeeMachine coffeeMachine = new CoffeeMachine();
            coffeeMachine.Show();
            this.Close();
        }
    }
}
