
using System.ComponentModel.DataAnnotations;
using System;

namespace EvantPlanner.Models
{
    public class Attendee
    {
        //OneToMany for User 
        //OneToMany for Event 
        // Commen table between User and Event
        [Key]
        public int AttendeeId {get;set;}
        public int UserId {get;set;}
        public int EventId {get;set;}
        public User User {get;set;}
        public Event Event {get;set;}
    }
}