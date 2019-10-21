using System.ComponentModel.DataAnnotations;

namespace FestivalVar.Domain
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        
        public string Text { get; set; }
        
        public ApplicationUser User { get; set; }
    }
}