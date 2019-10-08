using System.ComponentModel.DataAnnotations;

namespace FestivalVar.Domain
{
    public class Draw
    {
        [Key]
        public int Id { get; set; }
        
        public string Title { get; set; }
        
        public string Description { get; set; }
    }
}