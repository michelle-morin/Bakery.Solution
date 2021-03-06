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

    [HttpPost("/vendors/{id}")]
    public ActionResult Destroy(string id)
    {
      int vendorId = int.Parse(id);
      Vendor.Delete(vendorId);
      return RedirectToAction("Index");
    }

    [HttpPost("/vendors/{vendorId}/orders")]
    public ActionResult Create(int vendorId, string orderTitle, string orderDescription, string stringOrderPrice, string orderDate, string paid)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor foundVendor = Vendor.Find(vendorId);
      try
      {
        if (String.IsNullOrWhiteSpace(orderTitle) || String.IsNullOrWhiteSpace(orderDescription) || String.IsNullOrWhiteSpace(orderDate) || String.IsNullOrWhiteSpace(stringOrderPrice))
        {
          throw new System.InvalidOperationException("invalid input");
        }
        else
        {
          double orderPrice = double.Parse(stringOrderPrice);
          Order newOrder = new Order(orderTitle, orderDescription, orderPrice, orderDate, paid);
          foundVendor.AddOrder(newOrder);
          List<Order> vendorOrders = foundVendor.Orders;
          model.Add("vendor", foundVendor);
          model.Add("orders", vendorOrders);
          return View("Show", model);
        }
      }
      catch (Exception ex)
      {
        return View("Error", ex.Message);
      }
    }
  }
}