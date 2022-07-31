using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.DTO;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API.Controllers
{   
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        private readonly DataContext _context;

        public UsersController(DataContext context)
            {
                _context = context;
            }
    
    [HttpGet]
    public ActionResult<IEnumerable<User>> GetAllUsers()
    {
        return _context.Users.ToList();
    }


    [HttpPost]
    public ActionResult<User> CreateUser(User user)
    {
        User novi = new User
        {
            Name = user.Name,
            LastName = user.LastName,
            Email = user.Email
            
            
        };

        _context.Users.Add(novi);
        _context.SaveChanges();
        return Ok(novi);
       
    }



    [HttpPut("{id}")]
    public ActionResult<User> UpdateUser(User updateUser, int id)
    {
        var postojeciUser = _context.Users.FirstOrDefault(x=> x.ID== id);

        postojeciUser.Name = updateUser.Name;
        postojeciUser.LastName = updateUser.LastName;
        postojeciUser.Email = updateUser.Email;
        /*
        postojeciUser.EmergencyContacts[0].Name = updateUser.EmergencyContacts[0].Name;
        postojeciUser.EmergencyContacts[1].Name = updateUser.EmergencyContacts[1].Name;
        postojeciUser.EmergencyContacts[0].PhoneNumber = updateUser.EmergencyContacts[0].PhoneNumber;
        postojeciUser.EmergencyContacts[1].PhoneNumber = updateUser.EmergencyContacts[1].PhoneNumber;
        */
        _context.SaveChanges();

        
        return postojeciUser;

    }


    /*Endpoint - Kreiranje korisnikovih Emergency Kontakata*/
    [HttpPost("{id}")]
    public ActionResult<User> CreateEmergencyContact(CreateContactDTO emergencyContact, int id)
    {

       var user =  _context.Users.FirstOrDefault(x => x.ID == id);

        //Check if Emergency contact list is null

        // if(user.EmergencyContacts is null)
        // {
        //     user.EmergencyContacts = new List<EmergencyContact>(2);
        // }

        var contact = new EmergencyContact
        {
            Name = emergencyContact.Name,
            PhoneNumber = emergencyContact.Phonenumber,
            User = user

        };
        
        /*_context.EmergencyContacts.Add(contact);*/
        //_context.Users
        user.EmergencyContacts.Add(contact);
        
        _context.SaveChanges();

        

        //_context.SaveChanges();

        return Ok(user);

    }




    /*Updateanje korisnikovih Emergency Kontakata*/
    
    
    
    
    }
}