using EmployeeApp.Service;

class Program
{
    static async Task Main(string[] args)
    {     
        if (args.Length == 0)
        {
            Console.WriteLine("Please provide a valid command.");
            return;
        }

        var command = args[0];
        var employeeService = new EmployeeService();

        if (command == "set-employee")
        {
            var id = int.Parse(GetArg(args, "--employeeId"));
            var name = GetArg(args, "--employeeName");
            var salary = int.Parse(GetArg(args, "--employeeSalary"));

            await employeeService.AddOrUpdateEmployeeAsync(id, name, salary);
        }
        else if (command == "get-employee")
        {
            var id = int.Parse(GetArg(args, "--employeeId"));
            await employeeService.GetEmployeeAsync(id);
        }
        else
        {
            Console.WriteLine("Unknown command.");
        }
    }

    static string GetArg(string[] args, string name)
    {
        var index = Array.IndexOf(args, name);
        return (index >= 0 && index < args.Length - 1) ? args[index + 1] : throw new ArgumentException($"Missing argument: {name}");
    }
}

