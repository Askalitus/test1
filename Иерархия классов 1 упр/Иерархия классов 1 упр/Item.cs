using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Иерархия_классов_1_упр
{
    internal class Item
    {
        protected long invNumber;

        protected bool taken;

        public bool IsAvailable()
        {
            if (taken == true)
                return true;
            else
                return false;
        }

        public long GetInvNumber()
        {
            return invNumber;
        }

        public void Take()
        {
            taken = false;
        }

        public void Return()
        {
            taken = true;
        }
        
        public void Show()
        {
            Console.WriteLine("Состояние единицы хранения: \n Инвентарный номер: {0}\n Наличие: {1}", invNumber, taken);
        }
    }
}
