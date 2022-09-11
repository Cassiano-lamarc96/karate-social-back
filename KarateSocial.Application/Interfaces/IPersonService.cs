using KarateSocial.Application.ViewModels;
using System.Threading.Tasks;

namespace KarateSocial.Application.Interfaces
{
    public interface IPersonService
    {
        bool Post(PersonViewModel personViewModel);
    }
}
