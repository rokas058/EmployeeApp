$Env:connectionString="Server=localhost; User ID=postgres; Password=guest; Port=7777; Database=uvsproject;"

Write-Host "Running Entity Framework migrations..."

dotnet build

dotnet ef migrations add InitialCreate --no-build

dotnet ef database update --no-build

Write-Host "? Database migrate completed."
