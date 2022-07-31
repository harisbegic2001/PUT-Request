using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace API.Models
{
    public class User
    {   
        [Key]
        public int ID { get; set; }

        public string Name { get; set; } = string.Empty;
    
        public string LastName { get; set; } = string.Empty;

        
        public List<EmergencyContact> EmergencyContacts { get; set; }
    
        public string Email { get; set; } = string.Empty;


        public User()
        {
            Name = "Haris";
            LastName = "Begić";
            EmergencyContacts = new List<EmergencyContact>(2);
            Email = "harisbegic01@hotmail.com";

        }

    }
}