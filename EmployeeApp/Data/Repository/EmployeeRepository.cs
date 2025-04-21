using EmployeeApp.Entity;
using Microsoft.EntityFrameworkCore;

namespace EmployeeApp.Data.Repository
{
    public class EmployeeRepository
    {
        private readonly ApplicationDBContext _context;

        public EmployeeRepository()
        {
            _context = new ApplicationDBContext();
        }

        public async Task<Employee?> GetEmployeeByIdAsync(int id)
        {
            return await _context.Employees.FirstOrDefaultAsync(e => e.Id == id); 
        }

        public async Task UpdateEmployeeAsync(Employee employee)
        {
            _context.Employees.Update(employee);
            await _context.SaveChangesAsync();
        }

        public async Task AddEmployeeAsync(Employee employee)
        {
            await _context.Employees.AddAsync(employee);
            await _context.SaveChangesAsync();
        }
    }
}
