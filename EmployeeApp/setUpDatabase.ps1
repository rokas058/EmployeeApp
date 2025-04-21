
$Env:UvsTaskPassword="guest"
$Env:UvsTaskDatabase="uvsproject"
$Env:UvsTaskPort="7777"
$Env:UvsTaskSchemaLocation=$("$(Get-Location)\DatabaseSchema\dbSchema.sql")

Write-Host ""
Write-Host "This script will set up a postgres database hosted in a docker container"
read-host "Press ENTER to continue"

docker pull postgres
if (-not $?) { exit 1 }

$portAssign = $Env:UvsTaskPort + ":5432"
$container=$(docker run -e "POSTGRES_PASSWORD=$Env:UvsTaskPassword" -p "$portAssign" -d postgres)
if (-not $?) { exit 1 }

Write-Host "? Database setup complete."
