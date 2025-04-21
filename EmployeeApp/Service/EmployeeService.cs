using EmployeeApp.Data.Repository;
using EmployeeApp.Entity;
using EmployeeApp.Mapper;

namespace EmployeeApp.Service
{
    public class EmployeeService
    {
        private readonly EmployeeRepository _repository;

        public EmployeeService()
        {
            _repository = new EmployeeRepository();
        }

        public async Task AddOrUpdateEmployeeAsync(int id, string name, int salary)
        {
            var existing = await _repository.GetEmployeeByIdAsync(id);

            if (existing != null)
            {
                existing.Name = name;
                existing.Salary = salary;
                await _repository.UpdateEmployeeAsync(existing);
                Console.WriteLine("Employee updated.");
            }
            else
            {
                var newEmployee = new Employee
                {
                    Id = id,
                    Name = name,
                    Salary = salary
                };
                await _repository.AddEmployeeAsync(newEmployee);
                Console.WriteLine("Employee saved.");
            }
        }

        public async Task GetEmployeeAsync(int id)
        {
            var employee = await _repository.GetEmployeeByIdAsync(id);

            if (employee != null)
            {
                var employeeDto = EmployeeMapper.ToDto(employee);
                Console.WriteLine($"ID: {employeeDto.Id}, Name: {employeeDto.Name}, Salary: {employeeDto.Salary}");
            }
            else
            {
                Console.WriteLine("Employee not found.");
            }
        }
    }
}
