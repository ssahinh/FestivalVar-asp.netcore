using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FestivalVar.Domain
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        
        public string Title { get; set; }
        
        public List<Festival> Festivals { get; set; }
    }
}