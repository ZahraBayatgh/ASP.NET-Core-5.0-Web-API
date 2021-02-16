using Contracts.IServices;
using System.Threading.Tasks;
using Entities;

namespace Repository.Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        private CompanyEmployeeDbContext _repositoryContext;
        private ICompanyRepository _companyRepository;
        private IEmployeeRepository _employeeRepository;

        public RepositoryManager(CompanyEmployeeDbContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }

        public ICompanyRepository Company
        {
            get
            {
                if (_companyRepository == null)
                    _companyRepository = new CompanyRepository(_repositoryContext);

                return _companyRepository;
            }
        }

        public IEmployeeRepository Employee
        {
            get
            {
                if (_employeeRepository == null)
                    _employeeRepository = new EmployeeRepository(_repositoryContext);

                return _employeeRepository;
            }
        }

        public Task SaveAsync() => _repositoryContext.SaveChangesAsync();
    }

}
