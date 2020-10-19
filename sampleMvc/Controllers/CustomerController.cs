using sampleMvc.Data;
using Microsoft.AspNetCore.Mvc;
namespace sampleMvc.Controllers
{
    public class CustomerController : Controller
    {
        private readonly SongContext _context;
        public CustomerController(SongContext context)
        {
            _context = context;
            
        }

        
    }
}