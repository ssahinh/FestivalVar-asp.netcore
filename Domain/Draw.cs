using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace FestivalVar.Domain
{
    public class Draw
    {
        [Key]
        public int Id { get; set; }
        
        public string Title { get; set; }
        
        public string Description { get; set; }
    
        public List<IdentityUser> Users { get; set; }
    }
}