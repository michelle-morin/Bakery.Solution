using Microsoft.AspNetCore.Mvc;
using Bakery.Models;
using System.Collections.Generic;

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

    [HttpPost("/vendors/{vendorId}/orders/{orderId}")]
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