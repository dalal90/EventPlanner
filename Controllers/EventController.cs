using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EvantPlanner.Models;
using System.Linq;
using Microsoft.AspNetCore.Http;
using System;

namespace EvantPlanner.Controllers
{
    public class EventController : Controller
    {
        private MyContext _context;
        public EventController(MyContext context)
        {
            _context = context;
        }

        [HttpGet("dashboard")]
        public IActionResult Dashboard()
        {
            if (HttpContext.Session.GetInt32("uid") != null)
            {
                List<Event> allEvents = _context.Events
                .Include( e => e.Creator)
                .OrderByDescending(e => e.Title)
                .Include( e => e.Attendees)
                .ThenInclude( a => a.User)
                .ToList();
                return View("Dashboard", allEvents);
            }
            else
            {
                return RedirectToAction("NotLoggedIn");
            }
        }
        [HttpGet("not_logged_in")]
        public ViewResult NotLoggedIn()
        {
            return View("LogError");
        }

        [HttpGet("logout")]
        public RedirectToActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "User");
        }
        [HttpGet("event/new")]
        public ViewResult NewEvent()
        {
            return View();
        }
        
        [HttpPost("event/process")]
        public IActionResult ProcessNewEvent(Event newEvent)
        {
            if (ModelState.IsValid)
            {
                //check date not in past
                if (newEvent.Date < DateTime.Now)
                {
                    ModelState.AddModelError("Date", "Event must be in the future");
                    return View("NewEvent");
                }
                else
                {
                    newEvent.UserId = (int)HttpContext.Session.GetInt32("uid");
                    _context.Events.Add(newEvent);
                    _context.SaveChanges();
                    return Redirect($"/event/{newEvent.EventId}");
                }
            }
            else 
            {
                return View("NewEvent");
            }
        }
        [HttpGet("event/delete/{eid}")]
        public RedirectToActionResult DeleteEvent(int eid)
        {
            Event EventToDelete = _context.Events.SingleOrDefault(e => e.EventId == eid);
            _context.Remove(EventToDelete);
            _context.SaveChanges();
            return RedirectToAction("Dashboard");
        }
        [HttpGet("event/join/{eid}")]
        public RedirectToActionResult JoinEvent(int eid)
        {
            Attendee thisAttendee = new Attendee();
            thisAttendee.UserId = (int)HttpContext.Session.GetInt32("uid");
            thisAttendee.EventId = eid;
            _context.Attendees.Add(thisAttendee);
            _context.SaveChanges();
            return RedirectToAction("Dashboard");
        }

        [HttpGet("event/leave/{eid}")]
        public RedirectToActionResult LeaveEvent(int eid)
        {
            Attendee thisAttendee = _context.Attendees.FirstOrDefault( a => a.EventId == eid && a.UserId == (int)HttpContext.Session.GetInt32("uid"));
            _context.Attendees.Remove(thisAttendee);
            _context.SaveChanges();
            return RedirectToAction("Dashboard");
        }

        [HttpGet("event/{eid}")]
        public ViewResult EventDetail(int eid)
        {
            Event thisEvent = _context.Events
            .Include( e => e.Attendees)
            .ThenInclude( a => a.User)
            .FirstOrDefault(e => e.EventId == eid);
            return View("Detail", thisEvent);
        }

        [HttpGet("event/edit/{eid}")]
        public ViewResult EditEvent(int eid)
        {
            Event thisEvent = _context.Events.FirstOrDefault(e => e.EventId == eid);

            return View("EditEvent", thisEvent);
        }

        [HttpPost("event/processedit/{eid}")]
        public IActionResult ProcessEditEvent(int eid, Event editedEvent)
        {
            Event thisEvent = _context.Events.FirstOrDefault(e => e.EventId == eid);
            if(ModelState.IsValid)
            {
                thisEvent.Title = editedEvent.Title;
                thisEvent.Date = editedEvent.Date;
                thisEvent.Description = editedEvent.Description;
                thisEvent.UpdatedAt = DateTime.Now;
                _context.SaveChanges();
                // return Redirect($"/event/{thisEvent.EventId}");//to another edit page 
                return RedirectToAction("Dashboard");// return to main page

            }
            else
            {
                return View("EditEvent", thisEvent);
            }
        }
    }
}

// blackbelt 
// .OrderByDescending(w => w.CreatedAt)
//  .OrderBy(d=>d.ActivityDate)

