using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace FestivalVar.Domain
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        
        public string Title { get; set; }
 
        [JsonIgnore]
        [IgnoreDataMember]
        public List<Festival> Festivals { get; set; }
    }
}