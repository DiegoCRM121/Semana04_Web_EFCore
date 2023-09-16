using System.Data.SqlTypes;

namespace Semana04_Web_EFCore.API.Data
{
    public class Product
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }
        public bool IsActive { get; set; }
    }
}
