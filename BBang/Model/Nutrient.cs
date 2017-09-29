using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBang.Model
{
    public class Nutrient
    {
        public string Calories { get; set; } //칼로리(kcal)
        public string ServingSize { get; set; } //중량
        public string Protein { get; set; } //단백질
        public string Sodium { get; set; } //나트륨
        public string Sugars { get; set; } //당류
        public string SaturatedFat { get; set; } //포화지방
    }
}
