using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using Bakery.Models;

namespace Bakery.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string vendorName, string description)
    {
      try
      {
        if (String.IsNullOrWhiteSpace(vendorName) || String.IsNullOrWhiteSpace(description))
        {
          throw new System.InvalidOperationException("invalid input");
        }
        else
        {
          Vendor newVendor = new Vendor(vendorName, description);
          return RedirectToAction("Index");
        }
      }
      catch(Exception ex)
      {
        return View("Error", ex.Message);
      }
    }

    [HttpGet("/error")]
    public ActionResult Error(string message)
    {
      return View(message);
    }

    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor selectedVendor = Vendor.Find(id);
      List<Order> vendorOrders = selectedVendor.Orders;
      model.Add("vendor", selectedVendor);
      model.Add("orders", vendorOrders);
      return View(model);
    }
  }
}