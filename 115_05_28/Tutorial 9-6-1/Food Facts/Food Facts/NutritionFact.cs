using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_Facts
{
    class NutritionFact
    {
        private string foodName;
        private int calories;
        private double fat;
        private int carb;

        public NutritionFact()
        {
            foodName = string.Empty;
            calories = 0;
            fat = 0.0;
            carb = 0;
        }

        public string FoodName { 
            set { foodName = value; }
            get { return foodName; } 
        }

        public int Calories
        {
            set { calories = value; }
            get { return calories; }
        }

        public double Fat
        {
            set {  fat = value; }
            get { return fat; }
        }

        public int Carb
        {
            set { carb = value; }
            get { return carb; }
        }
    }
}
