using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace EvantPlanner.Models
{
    public class Event
    {
        [Key]
        public int EventId {get;set;}

        [Required]
        public string Title {get;set;}

        [Required]
        public DateTime Date {get;set;}

        [Required]
        public string Description {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        public int UserId {get;set;}
        public User Creator {get;set;} //One to Many relation 
        public List<Attendee> Attendees {get;set;}//Many to Many relation List of people who Attend 
    }
}