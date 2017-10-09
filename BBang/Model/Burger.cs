using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBang.Model
{
    public class Burger // : INotifyPropertyChanged
    {
        private string nameKR;
        public string NameKR
        {
            get
            {
                return nameKR;
            }
            set
            {
                if (value != nameKR)
                {
                    nameKR = value;
                    ImagePath = Common.ImageRootPath + nameKR + Common.ImageExt;
                    ImageLargePath = Common.ImageRootPath + nameKR + Common.ImageLargeKey + Common.ImageExt;
                    //NotifyPropertyChanged("NameKR");
                }
            }
        }

        private string nameEN;
        public string NameEN
        {
            get
            {
                return nameEN;
            }
            set
            {
                if (value != nameEN)
                {
                    nameEN = value;
                    //NotifyPropertyChanged("NameEN");
                }
            }
        }

        private string mainTitle;
        public string MainTitle
        {
            get
            {
                return mainTitle;
            }
            set
            {
                if (value != mainTitle)
                {
                    mainTitle = value;
                    //NotifyPropertyChanged("MainTitle");
                }
            }
        }

        private string catergory;
        public string Catergory
        {
            get
            {
                return catergory;
            }
            set
            {
                if (value != catergory)
                {
                    catergory = value;
                    //NotifyPropertyChanged("Catergory");
                }
            }
        }

        private string description;
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                if (value != description)
                {
                    description = value;
                    //NotifyPropertyChanged("Description");
                }
            }
        }

        private string price;
        public string Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value != price)
                {
                    price = value;
                    //NotifyPropertyChanged("Price");
                }
            }
        }

        private string isSet;
        public string IsSet
        {
            get
            {
                return isSet;
            }
            set
            {
                if (value != isSet)
                {
                    isSet = value;
                    //NotifyPropertyChanged("IsSet");
                }
            }
        }

        private string imagepath;
        public string ImagePath
        {
            get
            {
                return imagepath;
            }
            set
            {
                if (value != imagepath)
                {
                    imagepath = value;
                    //NotifyPropertyChanged("ImagePath");
                }
            }
        }

        private string imageLargePath;
        public string ImageLargePath
        {
            get
            {
                return imageLargePath;
            }
            set
            {
                if (value != imageLargePath)
                {
                    imageLargePath = value;
                    //NotifyPropertyChanged("ImageLargePath");
                }
            }
        }

        private Nutrient nutrientinfo;
        public Nutrient NutrientInfo
        {
            get
            {
                return nutrientinfo;
            }
            set
            {
                if (value != nutrientinfo)
                {
                    nutrientinfo = value;
                    //NotifyPropertyChanged("NutrientInfo");
                }
            }
        }

        //public event PropertyChangedEventHandler PropertyChanged;
        //private void NotifyPropertyChanged(String propertyName)
        //{
        //    PropertyChangedEventHandler handler = PropertyChanged;
        //    if (null != handler)
        //    {
        //        handler(this, new PropertyChangedEventArgs(propertyName));
        //    }
        //}
    }
}
