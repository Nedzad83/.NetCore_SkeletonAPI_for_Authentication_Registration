using System.Threading.Tasks;

namespace EducationLibrary.WebAPI.Core
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}