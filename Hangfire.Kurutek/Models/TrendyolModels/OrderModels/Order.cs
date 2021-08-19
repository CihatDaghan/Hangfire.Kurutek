using Kurutek.API.Controllers;
using System;
using System.Collections.Generic;

namespace Kurutek.API
// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
{
    public class Order
    {

        public int page { get; set; }
        public int size { get; set; }
        public int totalPages { get; set; }
        public int totalElements { get; set; }
        public List<Content> content { get; set; }
      
        public class Content
        {
            public ShipmentAddress shipmentAddress { get; set; }
            public string orderNumber { get; set; }
            public double grossAmount { get; set; }
            public double totalDiscount { get; set; }
            public double totalPrice { get; set; }
            public object taxNumber { get; set; }
            public InvoiceAddress invoiceAddress { get; set; }
            public string customerFirstName { get; set; }
            public string customerEmail { get; set; }
            public int customerId { get; set; }
            public string customerLastName { get; set; }
            public int id { get; set; }
            public long cargoTrackingNumber { get; set; }
            public string cargoTrackingLink { get; set; }
            public string cargoSenderNumber { get; set; }
            public string cargoProviderName { get; set; }
            public List<Line> lines { get; set; }
            public long orderDate { get; set; }
            public string tcIdentityNumber { get; set; }
            public string currencyCode { get; set; }
            public List<PackageHistory> packageHistories { get; set; }
            public string shipmentPackageStatus { get; set; }
            public long estimatedDeliveryStartDate { get; set; }
            public long estimatedDeliveryEndDate { get; set; }
            public string deliveryAddressType { get; set; }
            public long agreedDeliveryDate { get; set; }
        }
        public class Line
        {
            public int quantity { get; set; }
            public int salesCampaignId { get; set; }
            public string productSize { get; set; }
            public string merchantSku { get; set; }
            public string productName { get; set; }
            public int productCode { get; set; }
            public int merchantId { get; set; }
            public double amount { get; set; }
            public double discount { get; set; }
            public double price { get; set; }
            public List<DiscountDetail> discountDetails { get; set; }
            public string currencyCode { get; set; }
            public string productColor { get; set; }
            public int id { get; set; }
            public string sku { get; set; }
            public double vatBaseAmount { get; set; }
            public string barcode { get; set; }
            public string orderLineItemStatusName { get; set; }
        }

    }
}
