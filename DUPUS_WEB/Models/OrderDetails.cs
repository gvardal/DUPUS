namespace DUPUS_WEB.Models
{
    public class OrderDetails
    {
        public OrderDetails(int? orderID, string customerID, int? employeeID, double? freight, 
            string shipCity, bool verified, DateTime orderDate, string shipName, string shipCountry, 
            DateTime shippedDate, string shipAddress)
        {
            this.OrderID = orderID;
            this.CustomerID = customerID;
            this.EmployeeID = employeeID;
            this.Freight = freight;
            this.ShipCity = shipCity;
            this.Verified = verified;
            this.OrderDate = orderDate;
            this.ShipName = shipName;
            this.ShipCountry = shipCountry;
            this.ShippedDate = shippedDate;
            this.ShipAddress = shipAddress;
        }

        public int? OrderID { get; set; }
        public string CustomerID { get; set; }
        public int? EmployeeID { get; set; }
        public double? Freight { get; set; }
        public string ShipCity { get; set; }
        public bool Verified { get; set; }
        public DateTime OrderDate { get; set; }
        public string ShipName { get; set; }
        public string ShipCountry { get; set; }
        public DateTime ShippedDate { get; set; }
        public string ShipAddress { get; set; }
    }
}
