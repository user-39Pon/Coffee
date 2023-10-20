using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Кофемашина.Classes
{
    class Sostav
    {
        public static int[] sost = { 0, 0, 0};
        public int Coffee { set; get; }
        public int Milk { set; get; }
        public int Water { set; get; }
        public Sostav(int coffee, int milk, int water)
        {
            Coffee = coffee;
            Milk = milk;
            Water = water;
        }
        public static void SaveSostav(int coffee, int milk, int water) // запись сохранённых данных
        {
            sost[0] = coffee;
            sost[1] = milk;
            sost[2] = water;
        }
    }
}
