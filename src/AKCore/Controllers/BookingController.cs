﻿using System.Linq;
using AKCore.DataModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using AKCore.Extensions;

namespace AKCore.Controllers
{
    [Route("Booking")]
    public class BookingController : Controller
    {
        private readonly AKContext _db;
        private readonly UserManager<AkUser> _userManager;
        public BookingController(AKContext db, UserManager<AkUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }

        [HttpPost("SaveBooking")]
        public async Task<ActionResult> SaveBooking(BookingItem model)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var bookingItem = new BookingItem
            {
                BookedDate = model.BookedDate.ConvertToSwedishTime(),
               Message = model.Message,
               Person = user.FirstName + ' ' + user.LastName ?? "Unknown",
            };
            _db.BookingItems.Add(bookingItem);

            _db.SaveChanges();

            return
                Json(new { success = true, message = "Din bokning är skickad och kommer kunna ses av styrelsen" });
        }

        [HttpGet("GetItems")]
        public ActionResult GetBookingItems(bool archived = false)
        {
            var items = _db.BookingItems.ToList();

            return Ok(items);
        }


        [HttpPost("{id}/Archive")]
        [Authorize(Roles = AkRoles.SuperNintendo)]
        public ActionResult Archive(int id)
        {
            if (id < 0)
            {
                return Json(new { success = false });
            }
            var item = _db.MailBoxItems.FirstOrDefault(x => x.Id == id);
            if (item == null) return Json(new { success = false });
            item.Archived = !item.Archived;
            _db.SaveChanges();
            return Json(new { success = true });
        }
        [Authorize(Roles = AkRoles.SuperNintendo)]
        [HttpPost("{id}/Delete")]
        public ActionResult Remove(int id)
        {
            if (id < 0)
            {
                return Json(new { success = false });
            }
            var item = _db.MailBoxItems.FirstOrDefault(x => x.Id == id);
            if (item == null) return Json(new { success = false });
            _db.MailBoxItems.Remove(item);
            _db.SaveChanges();
            return Json(new { success = true });
        }
    }
}
