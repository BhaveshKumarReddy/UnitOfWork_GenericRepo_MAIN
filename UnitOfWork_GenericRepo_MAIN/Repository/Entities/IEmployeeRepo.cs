using UnitOfWork_GenericRepo_MAIN.Models;

namespace UnitOfWork_GenericRepo_MAIN.Repository
{
    public interface IEmployeeRepo : IRepository<Employee>
    {
        Task<Employee> UpdateAsync(Employee entity);
    }
}
