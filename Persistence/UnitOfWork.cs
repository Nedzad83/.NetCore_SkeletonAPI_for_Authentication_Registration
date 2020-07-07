using System.Threading.Tasks;
using EducationLibrary.WebAPI.Core;
using WebApi.Persistence;

namespace EducationLibrary.WebAPI.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext context;

        public UnitOfWork(DataContext context)
        {
            this.context = context;
        }

        public async Task CompleteAsync()
        {
            await context.SaveChangesAsync();
        }
    }
}