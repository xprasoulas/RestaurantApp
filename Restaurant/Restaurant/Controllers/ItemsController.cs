using Restaurant.Models;
using Restaurant.Persistence;
using System.Linq;
using System.Web.Http;

namespace Restaurant.Controllers
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