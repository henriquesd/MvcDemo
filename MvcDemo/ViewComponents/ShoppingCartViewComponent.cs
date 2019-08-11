using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MvcDemo.ViewComponents
{
    [ViewComponent(Name = "ShoppingCart")]
    public class ShoppingCartViewComponent : ViewComponent
    {
        public int CartItens { get; set; }

        public ShoppingCartViewComponent()
        {
            CartItens = 3;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(CartItens);
        }
    }
}
