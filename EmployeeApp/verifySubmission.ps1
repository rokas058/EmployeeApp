dotnet build

dotnet run --no-build set-employee --employeeId 1 --employeeName John --employeeSalary 123
dotnet run --no-build set-employee --employeeId 2 --employeeName Steve --employeeSalary 456

dotnet run --no-build get-employee --employeeId 1
dotnet run --no-build get-employee --employeeId 2

cd ../..