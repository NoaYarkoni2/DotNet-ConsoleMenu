using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    public class ActionMenuItem : MenuItem
    {
        public event Action MenuItemToDoOnSelection;
        public ActionMenuItem(string i_Text, Action i_MethodToAdd) : base(i_Text)
        {
            MenuItemToDoOnSelection += i_MethodToAdd;
        }
        protected override void OnSelection()
        {
            MenuItemToDoOnSelection?.Invoke();
        }
    }
}
