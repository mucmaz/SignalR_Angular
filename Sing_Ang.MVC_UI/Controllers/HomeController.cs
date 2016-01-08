using System.Threading.Tasks;
using System.Web.Mvc;
using Microsoft.AspNet.SignalR;
using Sing_Ang.Bll;

namespace Sing_Ang.MVC_UI.Controllers
{
    public class HomeController : Controller
    {
        ProductBusiness _busiProduct;

        public ActionResult Index()
        {
            //_busiProduct = new ProductBusiness();
            //_busiProduct.Ekle(new Product
            //{
            //    ProductName = "PS4",
            //    CreateDate = DateTime.Now,
            //    Price = new decimal(154.94)
            //});
            return View();
        }
    }
}

public class ProductHub : Hub
{
    ProductBusiness _busiProduct;
    public override async Task OnConnected()
    {
        _busiProduct = new ProductBusiness();
        var prod = _busiProduct.TumunuGetir();
        await Clients.Caller.getAllProcuts(prod);
    }
}