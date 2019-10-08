using System.ComponentModel.DataAnnotations;

namespace FestivalVar.Domain
{
    public class Contract
    {
        [Key]
        public int Id { get; set; }
        
        public string Title { get; set; }
        
        public string Description { get; set; }
    }
}