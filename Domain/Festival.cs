using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace FestivalVar.Domain
{
    public class Festival
    {
        [Key]
        public int Id { get; set; }
        
        [DataMember]
        public string Title { get; set; }
        
        [DataMember]
        public string City { get; set; }
        
        [DataMember]
        public Category Category { get; set; }
    }
}