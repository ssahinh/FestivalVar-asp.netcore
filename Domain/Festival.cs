using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace FestivalVar.Domain
{
    public class Festival
    {
        [Key]
        public int Id { get; set; }
        
        public string Title { get; set; }
        
        public string City { get; set; }
    }
}