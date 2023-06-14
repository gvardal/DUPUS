using DUPUS_WEB.Models;
using Microsoft.AspNetCore.Mvc;

namespace DUPUS_WEB.Controllers
{
    public class WorkOrderController : Controller
    {

        public IActionResult Index()
        {
            List<OrderDetails> order = new();

            if (order.Count() == 0)
            {
                int code = 10000;
                for (int i = 1; i < 5; i++)
                {
                    order.Add(new OrderDetails(code + 1, "ALFKI", i + 0, 2.3 * i, "Berlin", false, new DateTime(1990, 04, 01), "Simons bistro", "Denmark", new DateTime(1996, 7, 16), "Kirchgasse 6"));
                    order.Add(new OrderDetails(code + 2, "ANATR", i + 2, 3.3 * i, "Madrid", true, new DateTime(1990, 04, 04), "Queen Cozinha", "Brazil", new DateTime(1996, 9, 11), "Avda. Azteca 123"));
                    order.Add(new OrderDetails(code + 3, "ANTON", i + 1, 4.3 * i, "Cholchester", true, new DateTime(1957, 11, 30), "Frankenversand", "Germany", new DateTime(1996, 10, 7), "Carrera 52 con Ave. Bolívar #65-98 Llano Largo"));
                    order.Add(new OrderDetails(code + 4, "BLONP", i + 3, 5.3 * i, "Marseille", false, new DateTime(1930, 10, 22), "Ernst Handel", "Austria", new DateTime(1996, 12, 30), "Magazinweg 7"));
                    order.Add(new OrderDetails(code + 5, "BOLID", i + 4, 6.3 * i, "Tsawassen", true, new DateTime(1953, 02, 18), "Hanari Carnes", "Switzerland", new DateTime(1997, 12, 3), "1029 - 12th Ave. S."));
                    code += 5;
                }
            }
            return View(order);
        }
    }
}
