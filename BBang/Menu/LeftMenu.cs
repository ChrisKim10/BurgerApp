using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBang
{
    public class LeftMenu
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                string prefix = Common.ImageSubMenuPath + name;
                ImagePath = prefix + Common.ImageExt;
                ImageHoverPath = prefix + Common.ImageHoverName + Common.ImageExt;
            }
        }
        public string ImagePath { get; set; }
        public string ImageHoverPath { get; set; }
    }
}
