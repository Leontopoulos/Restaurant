using RestaurantApp.Models;
using RestaurantApp.Persistence;
using System.Linq;
using System.Web.Http;

namespace RestaurantApp.Controllers
{
    public class ItemsController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/Items
        public IQueryable<Item> GetItems()
        {
            return db.Items;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}