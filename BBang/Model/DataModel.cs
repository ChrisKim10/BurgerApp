using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBang.Model
{
    public class DataModel// : INotifyPropertyChanged
    {
        //public event EventHandler OnDataChanged;

        public ObservableCollection<Burger> Items { get; set; }
        public ObservableCollection<GroupInfoList> groups { get; set; }

        public bool IsDataLoaded { get; set; }

        public List<Burger> lstBurger = new List<Burger>()
        {
            new Burger()
            {
                NameKR = "통새우와퍼주니어",
                NameEN = "TONG SHRIMP WHOPPER JR®",
                Catergory = "WHOPPER® 와퍼",
                Description = "직화 방식으로 구운 100% 순쇠고기 패티에 갈릭페퍼 통새우와 스파이시토마토소스가 더해진 프리미엄 버거",
                IsSet = "단품",
                Price = "4,600",
                NutrientInfo = new Nutrient() { Calories = "381", ServingSize = "162", Protein = "21", Sodium = "522", Sugars = "5", SaturatedFat = "7" },
            },
            new Burger()
            {
                NameKR = "통새우스테이크버거",
                NameEN = "TONG SHRIMP STEAK BURGER",
                Catergory = "WHOPPER® 와퍼",
                Description = "직화 방식으로 구운 프리미엄 스테이크 패티에 갈릭페퍼 통새우와 고소한 치즈, 스파이시토마토소스가 더해진 프리미엄 버거",
                IsSet = "단품",
                Price = "7,600",
                NutrientInfo = new Nutrient() { Calories = "839", ServingSize = "348", Protein = "37", Sodium = "1437", Sugars = "5", SaturatedFat = "19" },
            },
            new Burger()
            {
                NameKR = "통새우와퍼",
                NameEN = "TONG SHRIMP WHOPPER",
                Catergory = "WHOPPER® 와퍼",
                Description = "직화 방식으로 구운 100% 순쇠고기 패티에 갈릭페퍼 통새우와 스파이시토마토소스가 더해진 프리미엄버거",
                IsSet = "단품",
                Price = "6,500",
                NutrientInfo = new Nutrient() { Calories = "741", ServingSize = "328", Protein = "34", Sodium = "984", Sugars = "5", SaturatedFat = "15" },
            },
            new Burger()
            {
                NameKR = "와퍼",
                NameEN = "WHOPPER®",
                Catergory = "WHOPPER® 와퍼",
                Description = "불에 직접 구운 순 쇠고기 패티에 싱싱한 야채가 한가득~ 버거킹의 대표 메뉴!",
                IsSet = "단품",
                Price = "5,600",
                NutrientInfo = new Nutrient() { Calories = "619", ServingSize = "278", Protein = "29", Sodium = "809", Sugars = "10.5", SaturatedFat = "13" },
            },
            new Burger()
            {
                NameKR = "불고기와퍼",
                NameEN = "BULGOGI WHOPPER®",
                Catergory = "WHOPPER® 와퍼",
                Description = "불에 직접 구운 순 쇠고기 패티가 들어간 와퍼에 달콤한 불고기 소스까지!",
                IsSet = "단품",
                Price = "5,600",
                NutrientInfo = new Nutrient() { Calories = "682", ServingSize = "278", Protein = "28", Sodium = "912", Sugars = "5.7", SaturatedFat = "14" },
            },
            new Burger()
            {
                NameKR = "콰트로치즈와퍼",
                NameEN = "QUATTRO CHEESE WHOPPER®",
                Catergory = "WHOPPER® 와퍼",
                Description = "진짜 불만을 즐겨라, 4가지 고품격 치즈와 불에 직접 구운 와퍼 패티의 만남!",
                IsSet = "단품",
                Price = "6,500",
                NutrientInfo = new Nutrient() { Calories = "769", ServingSize = "309", Protein = "40", Sodium = "1051", Sugars = "6.2", SaturatedFat = "20" },
            },
            new Burger()
            {
                NameKR = "치즈와퍼",
                NameEN = "CHEESE WHOPPER®",
                Catergory = "WHOPPER® 와퍼",
                Description = "불에 직접 구운 순 쇠고기 패티가 들어간 와퍼에 고소한 치즈까지!",
                IsSet = "단품",
                Price = "6,200",
                NutrientInfo = new Nutrient() { Calories = "716", ServingSize = "303", Protein = "33", Sodium = "1288", Sugars = "7.1", SaturatedFat = "16" },
            },
            new Burger()
            {
                NameKR = "와퍼주니어",
                NameEN = "WHOPPER JR®",
                Catergory = "WHOPPER® 와퍼",
                Description = "불에 직접 구운 순 쇠고기 패티가 들어간 와퍼의 주니어 버전~ 작지만 꽉 찼다!",
                IsSet = "단품",
                Price = "4,000",
                NutrientInfo = new Nutrient() { Calories = "399", ServingSize = "158", Protein = "17", Sodium = "570", Sugars = "4.6", SaturatedFat = "8" },
            },
            new Burger()
            {
                NameKR = "불고기와퍼주니어",
                NameEN = "BULGOGI WHOPPER JR®",
                Catergory = "WHOPPER® 와퍼",
                Description = "불에 직접 구운 순 쇠고기 패티가 들어간 와퍼주니어에 달콤한 불고기 소스까지!",
                IsSet = "단품",
                Price = "4,000",
                NutrientInfo = new Nutrient() { Calories = "380", ServingSize = "158", Protein = "18", Sodium = "523", Sugars = "3.6", SaturatedFat = "8" },
            },
            new Burger()
            {
                NameKR = "콰트로치즈와퍼주니어",
                NameEN = "QUATTRO CHEESE WHOPPER JR®",
                Catergory = "WHOPPER® 와퍼",
                Description = "진짜 불맛을 즐겨라, 4가지 고품격 치즈와 불에 직접 구운 와퍼 패티의 만남!",
                IsSet = "단품",
                Price = "4,600",
                NutrientInfo = new Nutrient() { Calories = "446", ServingSize = "173", Protein = "21", Sodium = "631", Sugars = "3.1", SaturatedFat = "10" },
            },
            new Burger()
            {
                NameKR = "치즈와퍼주니어",
                NameEN = "CHEESE WHOPPER JR®",
                Catergory = "WHOPPER® 와퍼",
                Description = "불에 직접 구운 순 쇠고기 패티가 들어간 와퍼주니어에 고소한 치즈 추가!",
                IsSet = "단품",
                Price = "4,300",
                NutrientInfo = new Nutrient() { Calories = "438", ServingSize = "170", Protein = "19", Sodium = "771", Sugars = "4.8", SaturatedFat = "10" },
            },
            //갈릭스테이크
            new Burger()
            {
                NameKR = "갈릭스테이크버거",
                NameEN = "GARLIC STEAK BURGER",
                Catergory = "GARLIC STEAK 갈릭스테이크",
                Description = "두툼한 스테이크 패티, 향긋한 갈릭, 달콤한 볶음 양파의 맛있는 조화!",
                IsSet = "단품",
                Price = "6,700",
                NutrientInfo = new Nutrient() { Calories = "637", ServingSize = "295", Protein = "36", Sodium = "1142", Sugars = "8.9", SaturatedFat = "15" },
            },
            //비프&치킨
            new Burger()
            {
                NameKR = "BLT뉴올리언스치킨버거",
                NameEN = "BLT NEW ORLEANS CHICKEN BURGER",
                Catergory = "BEEF&CHICKEN 비프&치킨",
                Description = "두툼한 치킨 통가슴살에 베이컨과 치즈, 양상추, 토마토, 잠발라야 시즈닝을 더한 새로운 매콤한 치킨버거",
                IsSet = "단품",
                Price = "5,700",
                NutrientInfo = new Nutrient() { Calories = "860", ServingSize = "319", Protein = "34", Sodium = "1480", Sugars = "9.1", SaturatedFat = "13" },
            },
            new Burger()
            {
                NameKR = "뉴올리언스치킨버거",
                NameEN = "NEW ORLEANS CHICKEN BURGER",
                Catergory = "BEEF&CHICKEN 비프&치킨",
                Description = "두툼한 치킨 통가슴살에 잠발라야 시즈닝을 더한 새로운 매콤한 치킨버거",
                IsSet = "단품",
                Price = "4,500",
                NutrientInfo = new Nutrient() { Calories = "798", ServingSize = "282", Protein = "30", Sodium = "1407", Sugars = "2.8", SaturatedFat = "10" },
            },
            new Burger()
            {
                NameKR = "2000치킨버거",
                NameEN = "2000 CHICKEN BURGER",
                Catergory = "BEEF&CHICKEN 비프&치킨",
                Description = "신선한 양상추와 바삭한 치킨패티의 만남!",
                IsSet = "단품",
                Price = "2,000",
                NutrientInfo = new Nutrient() { Calories = "461", ServingSize = "160", Protein = "12", Sodium = "810", Sugars = "2", SaturatedFat = "7" },
            },
            new Burger()
            {
                NameKR = "2000치즈버거",
                NameEN = "2000 CHEESE BURGER",
                Catergory = "BEEF&CHICKEN 비프&치킨",
                Description = "달콤 상큼한 스위트사우전 소스, 신선한 토마토와 고소한 치즈의 조화!",
                IsSet = "단품",
                Price = "2,000",
                NutrientInfo = new Nutrient() { Calories = "432", ServingSize = "170", Protein = "17", Sodium = "640", Sugars = "8.4", SaturatedFat = "8" },
            },
            new Burger()
            {
                NameKR = "BLT롱치킨버거",
                NameEN = "BLT LONG CHICKEN BURGER",
                Catergory = "BEEF&CHICKEN 비프&치킨",
                Description = "바삭한 베이컨과 신선한 야채 그리고 담백한 롱~ 치킨패티의 완벽한 조화!",
                IsSet = "단품",
                Price = "4,900",
                NutrientInfo = new Nutrient() { Calories = "642", ServingSize = "269", Protein = "28", Sodium = "1217", Sugars = "3", SaturatedFat = "6" },
            },
            new Burger()
            {
                NameKR = "롱킹",
                NameEN = "LONG KING",
                Catergory = "BEEF&CHICKEN 비프&치킨",
                Description = "100% 순쇠고기 패티가 두 장! 달콤 상큼한 스위트 사우전드 소스의 완벽한 조화",
                IsSet = "단품",
                Price = "5,900",
                NutrientInfo = new Nutrient() { Calories = "545", ServingSize = "230", Protein = "24", Sodium = "983", Sugars = "9.2", SaturatedFat = "9" },
            },
            new Burger()
            {
                NameKR = "X-TRA크런치치킨",
                NameEN = "X-TRA CRUNCH CHICKEN",
                Catergory = "BEEF&CHICKEN 비프&치킨",
                Description = "매콤한 치킨, 바삭한 옥수수, 그리고 신선한 토마토와 아삭한 피클까지!",
                IsSet = "단품",
                Price = "4,700",
                NutrientInfo = new Nutrient() { Calories = "740", ServingSize = "279", Protein = "22", Sodium = "1050", Sugars = "5.4", SaturatedFat = "5" },
            },
            new Burger()
            {
                NameKR = "크런치치킨",
                NameEN = "CRUNCH CHICKEN",
                Catergory = "BEEF&CHICKEN 비프&치킨",
                Description = "매콤한 치킨과 바삭한 옥수수의 조화, 크런치치킨",
                IsSet = "단품",
                Price = "4,300",
                NutrientInfo = new Nutrient() { Calories = "731", ServingSize = "225", Protein = "22", Sodium = "1049", Sugars = "3.4", SaturatedFat = "5" },
            },
            new Burger()
            {
                NameKR = "오리지널롱치킨버거",
                NameEN = "ORIGINAL LONG CHICKEN SANDWICH",
                Catergory = "BEEF&CHICKEN 비프&치킨",
                Description = "담백한 치킨 패티에 부드러운 마요네즈 소스와 싱싱한 야채가 듬뿍~",
                IsSet = "단품",
                Price = "4,400",
                NutrientInfo = new Nutrient() { Calories = "571", ServingSize = "210", Protein = "25", Sodium = "1100", Sugars = "5.7", SaturatedFat = "5.5" },
            },
            new Burger()
            {
                NameKR = "치즈버거",
                NameEN = "CHEESE BURGER",
                Catergory = "BEEF&CHICKEN 비프&치킨",
                Description = "불에 구운 쇠고기 패티와 사르르 치즈까지, 작지만 알차다!",
                IsSet = "단품",
                Price = "3,000",
                NutrientInfo = new Nutrient() { Calories = "366", ServingSize = "133", Protein = "19", Sodium = "752", Sugars = "5.9", SaturatedFat = "9" },
            },
            new Burger()
            {
                NameKR = "불고기버거",
                NameEN = "BULGOGI BURGER",
                Catergory = "BEEF&CHICKEN 비프&치킨",
                Description = "달콤한 불고기소스를 더한 실속 만점의 버거. 크기는 깜찍, 맛은 어메이징!",
                IsSet = "단품",
                Price = "3,000",
                NutrientInfo = new Nutrient() { Calories = "371", ServingSize = "140", Protein = "17", Sodium = "432", Sugars = "9.9", SaturatedFat = "8" },
            },
            new Burger()
            {
                NameKR = "햄버거",
                NameEN = "HAMBURGER",
                Catergory = "BEEF&CHICKEN 비프&치킨",
                Description = "불에 구운 소고기 패티가 쏙~ 실속 있게 즐긴다!",
                IsSet = "단품",
                Price = "2,700",
                NutrientInfo = new Nutrient() { Calories = "306", ServingSize = "121", Protein = "17", Sodium = "513", Sugars = "6.3", SaturatedFat = "6" },
            },
        };

        public DataModel()
        {
            this.Items = new ObservableCollection<Burger>();
            this.groups = new ObservableCollection<GroupInfoList>();
        }

        private void LoadData()
        {
            foreach (Burger burger in lstBurger)
            {
                this.Items.Add(burger);
            }

            //if (OnDataChanged != null)
            //    OnDataChanged(this, null);
        }

        public ObservableCollection<GroupInfoList> GetBurgersGrouped()
        {
            LoadData();

            var query = from item in this.Items
                        group item by item.Catergory into g
                        //orderby g.Key
                        select new { GroupName = g.Key, Items = g };

            foreach (var g in query)
            {
                GroupInfoList info = new GroupInfoList();
                info.Key = g.GroupName;
                foreach (var item in g.Items)
                {
                    info.Add(item);
                }
                groups.Add(info);
            }

            this.IsDataLoaded = true;
            return groups;
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
