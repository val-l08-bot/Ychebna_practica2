using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yshebnaya_practica2
{
    public class Dishes
    {
        public int id { get; set; }
        public string name { get; set; }
        public int time { get; set; }
        public string description { get; set; }
        public decimal price { get; set; }
        public string category { get; set; }
        public string categoryId { get; set; }

        public Dishes(int Id, string Name, decimal Price, int Time, string CategoryId, string Description, string Category)
        {
            this.id = Id;
            this.name = Name;
            this.price = Price;
            this.time = Time;
            this.categoryId = CategoryId;
            this.description = Description;
            this.category = Category;
        }
    }

}
