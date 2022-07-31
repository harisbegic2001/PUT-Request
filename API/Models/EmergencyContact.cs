using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace API.Models
{
    public class EmergencyContact
    {
        [Key]
        public int ID { get; set; }

        public string Name { get; set; } = string.Empty;
    
        public string PhoneNumber { get; set; } = string.Empty;
        

        [JsonIgnore]
        public User User { get; set; }

        public int UserID { get; set; }
    }
}