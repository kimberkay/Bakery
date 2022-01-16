using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Bakery.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;

namespace Bakery.Controllers
{
  public class OrdersController : Controller
  {
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly BakeryContext _db;

    public OrdersController(UserManager<ApplicationUser> userManager, BakeryContext db)
    {
      _userManager = userManager;
      _db = db;
    }

    public async Task<ActionResult> Index()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);
      var userOrders = _db.Orders.Where(entry => entry.User.Id == currentUser.Id).ToList();
      return View(userOrders);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public async Task<ActionResult> Create(Order order)
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);
      order.User = currentUser;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      var thisOrder = _db.Orders
          .Include(flavor => flavor.JoinEntities)
          .ThenInclude(join => join.treat)
          .FirstOrDefault(order => order.OrderId == id);
      return View(thisOrder);
    }


    public ActionResult Edit(int id)
    {
      var thisFlavor = _db.Flavors.FirstOrDefault(item => item.FlavorId == id);
      ViewBag.TreatId = new SelectList(_db.Treats, "TreatId", "Name");
      ViewBag.FlavorId = new SelectList(_db.Flavors, "FlavorId", "Description");
      return View(thisFlavor);
    }

    [HttpPost]
    public ActionResult Edit(Order order)
    {
      _db.Entry(order).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Details", order.OrderId);
    }

    
  }
}