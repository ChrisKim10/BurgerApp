using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBang
{
    /// <summary>
    /// Not Used
    /// </summary>
    public class Menu
    {
        public List<CenterMenu> listCenterMenu = new List<CenterMenu>()
        {
            new CenterMenu() { MenuPath = Common.ImageMenuPath + "gnb_01.png", MenuWidth = 110, MenuHeight = 79 },
            new CenterMenu() { MenuPath = Common.ImageMenuPath + "gnb_02.png", MenuWidth = 110, MenuHeight = 92 },
            new CenterMenu() { MenuPath = Common.ImageMenuPath + "gnb_03.png", MenuWidth = 110, MenuHeight = 104 },
            new CenterMenu() { MenuPath = Common.ImageMenuPath + "gnb_04.png", MenuWidth = 110, MenuHeight = 89 },
            new CenterMenu() { MenuPath = Common.ImageMenuPath + "gnb_05.png", MenuWidth = 110, MenuHeight = 110 },
        };

        public List<LeftMenu> listLeftMenu = new List<LeftMenu>()
        {
            new LeftMenu() { Name = "BurgerMenu"},
            new LeftMenu() { Name = "WhopperMenu"},
            new LeftMenu() { Name = "GarlicSteakMenu"},
            new LeftMenu() { Name = "BeefChickenMenu"},
        };


    }
}
