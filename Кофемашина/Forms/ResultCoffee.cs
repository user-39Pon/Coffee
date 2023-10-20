using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Кофемашина.Forms
{
    public partial class ResultCoffee : Form
    {
        public ResultCoffee()
        {
            InitializeComponent();
        }

        private void закрыть_Click(object sender, EventArgs e)
        {
            // возвращение на форму CoffeeMachine
            CoffeeMachine coffeeMachine = new CoffeeMachine();
            coffeeMachine.Show();
            this.Close();
        }
    }
}
