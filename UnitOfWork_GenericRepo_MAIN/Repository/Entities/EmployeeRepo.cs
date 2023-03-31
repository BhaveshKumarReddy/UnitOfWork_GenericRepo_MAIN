using Microsoft.EntityFrameworkCore;
using UnitOfWork_GenericRepo_MAIN.Models;

namespace UnitOfWork_GenericRepo_MAIN.Repository
{
    public class EmployeeRepo : Repository<Employee>, IEmployeeRepo
    {
        private readonly ShoppingContext _db;

        public EmployeeRepo(ShoppingContext db): base(db)
        {
            _db = db;
        }
        public async Task<Employee> UpdateAsync(Employee entity)
        {
            return entity;
        }
    }
}
