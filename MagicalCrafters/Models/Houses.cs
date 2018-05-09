using System.ComponentModel.DataAnnotations;

namespace MagicalCrafters.Models
{
    public class Houses
    {
        public int House_Id { get; set; }
        public int Source_Id { get; set; }
        public string Name { get; set; }
        public string Motto { get; set; }
        public long Points { get; set; }
    }
}