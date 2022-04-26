using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navigation_Menu_App.ViewModels
{
    public class MenuItemModel
    {
        public string Header { get; set; }
        public string Foreground { get; set; }

        public string Icon { get; set; }

        public List<MenuItemModel> SubMenuItem { get; set; }
    }
}
