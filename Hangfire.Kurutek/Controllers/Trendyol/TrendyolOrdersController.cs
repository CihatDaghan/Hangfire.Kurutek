using Kurutek.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.SqlServer;


namespace Kurutek.API.Controllers
{
    public static class TrendyolOrdersController 
    {
        /// <summary>
        /// Trendyol Sipariş Entegrasyonu
        /// </summary>
        /// <returns></returns>
        public static void TrendyolOrders()
        {
            DatabaseContext c = new DatabaseContext();
            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", "Basic WGw5NkRYS2NZMHdSRVVBaWp0M086eGh5djhHMXVjdjJEc3VHVjE0Z3I=");
            client.BaseAddress = new Uri("https://api.trendyol.com/");
            HttpResponseMessage response =  client.GetAsync("sapigw/suppliers/191316/orders").Result;
            string result =  response.Content.ReadAsStringAsync().Result;
            Order convertdata = JsonConvert.DeserializeObject<Order>(result);
            Orders t = new Orders();
            var ordersdata = c.Orders.ToList().OrderByDescending(x => x.id).FirstOrDefault().id;
            var convertlastdata = convertdata.content.OrderByDescending(x => x.id).FirstOrDefault().id;
            DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            if (ordersdata != convertlastdata)
            {
                foreach (var item in convertdata.content)
                {
                    if (item.id != ordersdata)
                    {
                    t.id = item.id;
                    t.customerFirstName = item.customerFirstName;
                    t.customerLastName = item.customerLastName;
                    t.orderNumber = item.orderNumber;
                    t.grossAmount = item.grossAmount;
                    t.totalDiscount = item.totalDiscount;
                    t.totalPrice = item.totalPrice;
                    t.customerEmail = item.customerEmail;
                    t.customerId = item.customerId;
                    t.cargoTrackingNumber = item.cargoTrackingNumber;
                    t.cargoSenderNumber = item.cargoSenderNumber;
                    t.cargoProviderName = item.cargoProviderName;
                    t.orderDate = dateTime.AddMilliseconds(item.orderDate).ToLocalTime();
                    t.tcIdentityNumber = item.tcIdentityNumber;
                    t.currencyCode = item.currencyCode;
                    t.shipmentPackageStatus = item.shipmentPackageStatus;
                    t.estimatedDeliveryStartDate = item.estimatedDeliveryStartDate;
                    t.estimatedDeliveryEndDate = item.estimatedDeliveryEndDate;
                    t.deliveryAddressType = item.deliveryAddressType;
                    t.agreedDeliveryDate = item.agreedDeliveryDate;
                    t.marketplace = 0;
                    c.Orders.Add(t);
                    c.SaveChanges();
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }
    }
}
