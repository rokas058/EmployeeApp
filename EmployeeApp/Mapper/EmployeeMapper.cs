using EmployeeApp.DTO;
using EmployeeApp.Entity;

namespace EmployeeApp.Mapper
{
    public static class EmployeeMapper
    {
        public static EmployeeDto ToDto(Employee employee)
        {
            return new EmployeeDto
            {
                Id = employee.Id,
                Name = employee.Name,
                Salary = employee.Salary
            };
        }

        public static Employee ToEntity(EmployeeDto employeeDto)
        {
            return new Employee
            {
                Id = employeeDto.Id,
                Name = employeeDto.Name,
                Salary = employeeDto.Salary
            };
        }
    }
}
