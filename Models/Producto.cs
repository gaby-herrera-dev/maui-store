using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioMauiAppBlazor.Models
{
    internal class Producto
    {
        public int id { get; set; }
        public string title { get; set; }
        public int price { get; set; }
        public string description { get; set; }
        public List<string> images { get; set; }
        public DateTime creationAt { get; set; }
        public DateTime updatedAt { get; set; }
        public Category category { get; set; }
    }
    public class Category
    {
        public int id { get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public DateTime creationAt { get; set; }
        public DateTime updatedAt { get; set; }
    }

}
