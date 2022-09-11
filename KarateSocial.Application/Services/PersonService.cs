using AutoMapper;
using KarateSocial.Application.Interfaces;
using KarateSocial.Application.ViewModels;
using KarateSocial.Domain.Entities;
using KarateSocial.Domain.Interfaces;
using System.Threading.Tasks;

namespace KarateSocial.Application.Services
{
    public class PersonService : IPersonService
    {
        public IMapper _mapper;
        public IPersonRepository _personRepository;

        public PersonService(IMapper mapper,
                             IPersonRepository personRepository)
        {
            _mapper = mapper;
            _personRepository = personRepository;
        }

        public bool Post(PersonViewModel personViewModel)
        {
            var person = _mapper.Map<Person>(personViewModel);
            _personRepository.Create(person);
            return true;
        }
    }
}
