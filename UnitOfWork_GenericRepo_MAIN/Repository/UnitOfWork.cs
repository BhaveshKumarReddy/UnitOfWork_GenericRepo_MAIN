using UnitOfWork_GenericRepo_MAIN.Models;

namespace UnitOfWork_GenericRepo_MAIN.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ShoppingContext _db;
        public UnitOfWork(ShoppingContext db) {
            _db = db;
            Employee = new EmployeeRepo(_db);
        }
        public IEmployeeRepo Employee { get; private set; }

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
