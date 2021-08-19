using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kurutek.Integration.Models.HepsiburadaModels.OrderModels
{
    public class HepsiburadaOrder
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
       
        public class Root
        {
            public DateTime dueDate { get; set; }
            public DateTime lastStatusUpdateDate { get; set; }
            public string id { get; set; }
            public string sku { get; set; }
            public string orderId { get; set; }
            public string orderNumber { get; set; }
            public DateTime orderDate { get; set; }
            public int quantity { get; set; }
            public string merchantId { get; set; }
            public TotalPrice totalPrice { get; set; }
            public UnitPrice unitPrice { get; set; }
            public HbDiscount hbDiscount { get; set; }
            public int vat { get; set; }
            public int vatRate { get; set; }
            public string customerName { get; set; }
            public string customerId { get; set; }
            public string status { get; set; }
            public ShippingAddress shippingAddress { get; set; }
            public Invoice invoice { get; set; }
            public string sapNumber { get; set; }
            public int dispatchTime { get; set; }
            public Commission commission { get; set; }
            public int commissionRate { get; set; }
            public int paymentTermInDays { get; set; }
            public int commissionType { get; set; }
            public CargoCompanyModel cargoCompanyModel { get; set; }
            public string cargoCompany { get; set; }
            public string customizedText01 { get; set; }
            public string customizedText02 { get; set; }
            public string customizedText03 { get; set; }
            public string customizedText04 { get; set; }
            public string customizedTextX { get; set; }
            public object creditCardHolderName { get; set; }
            public bool isCustomized { get; set; }
            public bool canCreatePackage { get; set; }
            public bool isCancellable { get; set; }
            public bool isCancellableByHbAdmin { get; set; }
            public string deliveryType { get; set; }
            public int deliveryOptionId { get; set; }
            public object slot { get; set; }
            public object pickUpTime { get; set; }
            public List<object> discountInfo { get; set; }
            public string merchantSKU { get; set; }
            public PurchasePrice purchasePrice { get; set; }
            public DeliveryNote deliveryNote { get; set; }
        }
        public class DeliveryNote
        {
        }

    }
}
