using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
namespace AzureRestApi.Controllers
{
    public class ItemController : Controller
    {
        public const int ShippingFee = 8;
        public double CalculateItemPrice(double itemPrice, double weight, double dollarToRmb)
        {
            
            double cost = (itemPrice + weight * ShippingFee) * dollarToRmb;
            return cost;
        }
    }
}
