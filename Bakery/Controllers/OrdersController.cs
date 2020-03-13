using Microsoft.AspNetCore.Mvc;
using Bakery.Models;
using System.Collections.Generic;
using System;

namespace Bakery.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
      Vendor vendor = Vendor.Find(vendorId);
      return View(vendor);
    }

    [HttpGet("/vendors/{vendorId}/orders/{orderId}")]
    public ActionResult Show(int vendorId, int orderId)
    {
      Order currentOrder = Order.Find(orderId);
      Vendor currentVendor = Vendor.Find(vendorId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("vendor", currentVendor);
      model.Add("order", currentOrder);
      return View(model);
    }

    [HttpGet("/vendors/{vendorId}/orders/{orderId}/edit")]
    public ActionResult Edit(int vendorId, int orderId)
    {
      Order currentOrder = Order.Find(orderId);
      Vendor currentVendor = Vendor.Find(vendorId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("vendor", currentVendor);
      model.Add("order", currentOrder);
      return View(model);
    }

    [HttpPost("/vendors/{vendorId}/orders/{orderId}")]
    public ActionResult Update(string strOrderId, string strVendorId, string orderTitle, string orderDescription, string stringOrderPrice, string orderDate, string paid)
    {
      int orderId = int.Parse(strOrderId);
      int vendorId = int.Parse(strVendorId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor foundVendor = Vendor.Find(vendorId);
      Order foundOrder = Order.Find(orderId);
      try
      {
        if (String.IsNullOrWhiteSpace(orderTitle) || String.IsNullOrWhiteSpace(orderDescription) || String.IsNullOrWhiteSpace(orderDate) || String.IsNullOrWhiteSpace(stringOrderPrice) || String.IsNullOrWhiteSpace(paid))
        {
          throw new System.InvalidOperationException("invalid input");
        }
        else
        {
          foundOrder.Title = orderTitle;
          foundOrder.Description = orderDescription;
          foundOrder.Date = orderDate;
          foundOrder.Price = double.Parse(stringOrderPrice);
          foundOrder.Paid = paid;
          model.Add("vendor", foundVendor);
          model.Add("order", foundOrder);
          return View("Show", model);
        }
      }
      catch (Exception ex)
      {
        return View("Error", ex.Message);
      }
    }

    [HttpPost("/vendors/{vendorId}/orders/{orderId}/delete")]
    public ActionResult Destroy(string strOrderId, string strVendorId)
    {
      int orderId = int.Parse(strOrderId);
      int vendorId = int.Parse(strVendorId);
      Order.DeleteOrder(orderId);
      Vendor selectedVendor = Vendor.Find(vendorId);
      selectedVendor.DeleteOrder(orderId);
      return View();
    }
  }
}