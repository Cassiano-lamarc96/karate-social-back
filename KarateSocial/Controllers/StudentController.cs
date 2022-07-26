using KarateSocial.Application.ViewModels.Person;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace KarateSocial.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : Controller
    {
        [HttpPost]
        [Route("add")]
        public async Task<bool> Add(PersonViewModel personViewModel)
        {
            return true;
        }
    }
}
