using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace FestivalVar.Domain
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        
        public string Title { get; set; }
    }
}