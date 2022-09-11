using AutoMapper;
using KarateSocial.Application.Interfaces;
using KarateSocial.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace KarateSocial.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IPersonService _personService;

        public StudentController(IMapper mapper,
                                 IPersonService personService)
        {
            _mapper = mapper;
            _personService = personService;
        }

        [HttpPost]
        [Route("add")]
        public bool Add(StudentViewModel studentViewModel)
        {
            if (studentViewModel?.Senha?.ToLower().Equals("senhateste123456") ?? false)
                return _personService.Post(_mapper.Map<PersonViewModel>(studentViewModel));
            else
                return false;
        }
    }
}
