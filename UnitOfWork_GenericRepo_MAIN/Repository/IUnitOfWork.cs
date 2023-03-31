using UnitOfWork_GenericRepo_MAIN.Models;

namespace UnitOfWork_GenericRepo_MAIN.Repository
{
    public interface IUnitOfWork
    {
        IEmployeeRepo Employee { get; }
        void Dispose();
        void Save();
    }
}
